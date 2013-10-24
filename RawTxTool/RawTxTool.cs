using Bitcoin_Tool.Crypto;
using Bitcoin_Tool.DataConverters;
using Bitcoin_Tool.RPC;
using Bitcoin_Tool.Scripts;
using Bitcoin_Tool.Structs;
using Bitcoin_Tool.Structs.Other;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace RawTxTool
{
	public partial class RawTxTool : Form
	{
		bool disableUpdate = false;

		Dictionary<UnspentTxOutHeader, TxOut> UTXO = new Dictionary<UnspentTxOutHeader, TxOut>();
		Dictionary<UnspentTxOutHeader, TxOut> selectedUTXO = new Dictionary<UnspentTxOutHeader, TxOut>();
		List<TxOut> outputs = new List<TxOut>();

		BitcoinRPC rpc = null;

		public RawTxTool()
		{
			InitializeComponent();
			dgvInputs.Columns["inValue"].DefaultCellStyle.Format = "#######0.00000000";
			inValue.ValueType = typeof(decimal);
			invOut.ValueType = typeof(UInt32);
			outAmount.ValueType = typeof(decimal);
		}

		private bool getRpc()
		{
			if (rpc != null)
				return true;

			string rpchost = "127.0.0.1";
			string rpcport = "8332";
			string rpcuser = null;
			string rpcpass = null;

			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\bitcoin\bitcoin.conf"))
			{
				string[] confLines = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\bitcoin\bitcoin.conf");
				foreach (string confLine in confLines)
				{
					if (confLine.Contains("rpcport="))
						rpcport = confLine.Replace("rpcport=", "").Trim();
					if (confLine.Contains("rpcuser="))
						rpcuser = confLine.Replace("rpcuser=", "").Trim();
					if (confLine.Contains("rpcpassword="))
						rpcpass = confLine.Replace("rpcpassword=", "").Trim();
				}
			}

			if (string.IsNullOrEmpty(rpcuser) || string.IsNullOrEmpty(rpcpass))
			{
				BitcoindDialog dialog = new BitcoindDialog();
				DialogResult dres = dialog.ShowDialog();
				if (dres == DialogResult.Cancel)
					return false;
				rpchost = dialog.txtHost.Text;
				rpcport = dialog.txtPort.Text;
				rpcuser = dialog.txtUser.Text;
				rpcpass = dialog.txtPass.Text;
			}

			rpc = new BitcoinRPC(rpchost, rpcport, rpcuser, rpcpass);
			return true;
		}

		private void btnFromBitcoind_Click(object sender, EventArgs e)
		{
			if (!getRpc())
				return;

			try
			{
				object[] obj = rpc.doRequest<object[]>("listunspent", new object[0]);

				for (int i = 0; i < obj.Length; i++)
				{
					Dictionary<string, object> p = rpc.jss.ConvertToType<Dictionary<string, object>>(obj[i]);

					string txid = (string)p["txid"];
					int vout = (int)p["vout"];
					ulong amount = (ulong)(((decimal)p["amount"]) * 100000000m);
					string scriptPubKey = (string)p["scriptPubKey"];

					UTXO.Add(new UnspentTxOutHeader(HexString.ToByteArrayReversed(txid), (uint)vout), new TxOut(amount, HexString.ToByteArray(scriptPubKey)));
				}

				updateUTXOList();
			}
			catch (Exception)
			{
				MessageBox.Show("Error downloading unspent outputs.");
				return;
			}
		}

		private void btnFromBlockchain_Click(object sender, EventArgs e)
		{	
			try 
			{
				WebClient wc = new WebClient();
				string json = wc.DownloadString("http://blockchain.info/unspent?active=" + txtAddress.Text);
				JavaScriptSerializer jss = new JavaScriptSerializer();

				Dictionary<string, object> jso = jss.Deserialize<Dictionary<string, object>>(json);
				Dictionary<string, object>[] outputs = jss.ConvertToType<Dictionary<string, object>[]>(jso["unspent_outputs"]);
				foreach (Dictionary<string, object> txo in outputs)
				{
					string tx_hash = (string)txo["tx_hash"];
					int tx_output_n = (int)txo["tx_output_n"];
					ulong value = Convert.ToUInt64((string)txo["value_hex"], 16);
					string script = (string)txo["script"];

					UTXO.Add(new UnspentTxOutHeader(HexString.ToByteArray(tx_hash), (uint)tx_output_n), new TxOut(value, HexString.ToByteArray(script)));
				}
				updateUTXOList();
			}
			catch (Exception)
			{
				MessageBox.Show("Error downloading unspent outputs.");
				return;
			}
		}

		private void updateUTXOList()
		{
			dgvInputs.Rows.Clear();

			foreach (KeyValuePair<UnspentTxOutHeader, TxOut> tx in UTXO)
			{

				dgvInputs.Rows.Add(false,
					Address.FromScript(tx.Value.scriptPubKey).ToString(),
					((decimal)tx.Value.value / (decimal)100000000),
					tx.Key.index,
					HexString.FromByteArrayReversed(tx.Key.txid));

			}
		}

		private void txtAddress_Enter(object sender, EventArgs e)
		{
			if (txtAddress.Text == "Bitcoin Address")
				txtAddress.Text = "";
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			UTXO.Clear();
			updateUTXOList();
			selectedUTXO.Clear();
			dgvOutputs.Rows.Clear();
			outputs.Clear();
			updateTx();
		}

		private void dgvInputs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (disableUpdate) return;

			disableUpdate = true;
			selectedUTXO.Clear();
			for (int i = 0; i < dgvInputs.Rows.Count; i++)
			{
				if ((bool)dgvInputs["inSelected", i].Value == true)
				{
					UnspentTxOutHeader uth = new UnspentTxOutHeader(HexString.ToByteArrayReversed((string)dgvInputs["inTxId", i].Value), (UInt32)dgvInputs["invOut", i].Value);
					selectedUTXO.Add(uth, UTXO[uth]);
				}
			}
			updateTx();
			disableUpdate = false;
		}

		private void dgvOutputs_Changed(object sender, EventArgs e)
		{
			if (disableUpdate) return;

			disableUpdate = true;
			outputs.Clear();
			for (int i = 0; i < dgvOutputs.Rows.Count; i++)
			{
				if (i != dgvOutputs.Rows.Count - 1)
				{
					if (!string.IsNullOrWhiteSpace((string)dgvOutputs["outAddress", i].Value))
					{
						try
						{
							Address addr = new Address((string)dgvOutputs["outAddress", i].Value);
							byte addrType = addr.calcHash();
							TxOut txo;
							if (addrType == Address.PUBKEYHASH)
								txo = new TxOut((UInt64)((decimal)dgvOutputs["outAmount", i].Value * 100000000m), ScriptTemplate.PayToAddress(addr).ToBytes());
							else if (addrType == Address.SCRIPTHASH)
								txo = new TxOut((UInt64)((decimal)dgvOutputs["outAmount", i].Value * 100000000m), ScriptTemplate.PayToScriptHash(addr).ToBytes());
							else
								throw new Exception();

							outputs.Add(txo);

							dgvOutputs.Rows[i].ErrorText = "";
						}
						catch (Exception)
						{
							dgvOutputs.Rows[i].ErrorText = "Invalid";
						}
					}
					else
					{
						dgvOutputs.Rows[i].ErrorText = "Invalid";
					}
				}
			}
			updateTx();
			disableUpdate = false;
		}

		private void updateTx(bool changeText = true)
		{
			decimal totalInput = 0;
			decimal totalOutput = 0;
			decimal change = 0;

			List<TxIn> txin = new List<TxIn>();

			foreach (KeyValuePair<UnspentTxOutHeader, TxOut> input in selectedUTXO)
			{
				totalInput += input.Value.value;
				txin.Add(new TxIn(input.Key.txid, input.Key.index, new byte[0]));
			}
			totalInput /= 100000000;

			foreach (TxOut output in outputs)
			{
				totalOutput = output.value;
			}
			totalOutput /= 100000000;

			change = totalInput - totalOutput;

			lblTotalIn.Text = "Total Inputs:\n" + totalInput;
			lblTotalOut.Text = "Total Outputs:\n" + totalOutput;
			lblChange.Text = "Change:\n" + change;

			Transaction tx = new Transaction(1, txin.ToArray(), outputs.ToArray(), 0);
			if (changeText)
				txtTx.Text = HexString.FromByteArray(tx.ToBytes());
		}

		private void btnSignBitcoind_Click(object sender, EventArgs e)
		{
			if (!getRpc())
				return;

			try
			{
				Dictionary<string, object> obj = rpc.doRequest<Dictionary<string, object>>("signrawtransaction", new object[] { txtTx.Text });

				txtTx.Text = (string)obj["hex"];
			}
			catch (BitcoinRPCException brex)
			{
				MessageBox.Show(brex.Message);
				return;
			}
		}

		private void btnSignPrivkey_Click(object sender, EventArgs e)
		{
			PrivateKeyDialog pkd = new PrivateKeyDialog();
			DialogResult res = pkd.ShowDialog();
			if (res == DialogResult.Cancel)
				return;

			PrivateKey pk = null;
			if (pkd.rbWIF.Checked)
				pk = PrivateKey.FromWIF(pkd.txtKey.Text);
			if (pkd.rbHEX.Checked)
				pk = PrivateKey.FromHex(pkd.txtKey.Text);

			Transaction tx = new Transaction(HexString.ToByteArray(txtTx.Text));

			for (int i = 0; i < tx.inputs.Length; i++)
			{
				TxOut prevOut = selectedUTXO[new UnspentTxOutHeader(tx.inputs[i].prevOut, tx.inputs[i].prevOutIndex)];
				Address a = Address.FromScript(prevOut.scriptPubKey);
				Address b = pk.pubKey.address;
				if (a.ToString() == b.ToString())
				{
					tx.inputs[i].Sign(tx, prevOut, pk);
				}
			}

			txtTx.Text = HexString.FromByteArray(tx.ToBytes());
		}

		private void btnSendBlockchain_Click(object sender, EventArgs e)
		{
			WebClient wc = new WebClient();
			NameValueCollection nvc = new NameValueCollection();
			nvc.Add("tx", txtTx.Text);
			string response;
			try
			{
				response = Encoding.UTF8.GetString(wc.UploadValues("http://blockchain.info/pushtx", "POST", nvc));
			}
			catch (WebException ex)
			{
				response = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();
			}
			MessageBox.Show(response);
		}

		private void btnSendBitcoind_Click(object sender, EventArgs e)
		{
			if (!getRpc())
				return;

			try
			{
				object obj = rpc.doRequest("sendrawtransaction", new object[] { txtTx.Text });
				MessageBox.Show((string)obj);
			}
			catch (BitcoinRPCException brex)
			{
				MessageBox.Show(brex.Message);
				return;
			}
		}

		private void exportInputsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.CheckPathExists = true;
			sfd.AutoUpgradeEnabled = true;
			if (sfd.ShowDialog() == DialogResult.Cancel)
				return;
			using (FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate, FileAccess.Write))
			{
				foreach (KeyValuePair<UnspentTxOutHeader, TxOut> tx in UTXO)
				{
					tx.Key.Write(fs);
					tx.Value.Write(fs);
				}
				fs.Close();
			}
		}

		private void importInputsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.CheckFileExists = true;
			ofd.AutoUpgradeEnabled = true;
			if (ofd.ShowDialog() == DialogResult.Cancel)
				return;
			using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
			{
				while (fs.Position != fs.Length)
				{
					UnspentTxOutHeader txh = UnspentTxOutHeader.FromStream(fs);
					TxOut txo = TxOut.FromStream(fs);
					UTXO.Add(txh, txo);
				}
				fs.Close();
			}
			updateUTXOList();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dgvInputs_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (dgvInputs.IsCurrentCellDirty)
			{
				dgvInputs.CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}

		private void dgvOutputs_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete && dgvOutputs.CurrentRow != dgvOutputs.Rows[dgvOutputs.Rows.Count - 1])
			{
				dgvOutputs.Rows.Remove(dgvOutputs.CurrentRow);
			}
		}

		private void dgvOutputs_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			dgvOutputs.CancelEdit();
		}

		private void dgvInputs_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Space)
				foreach (DataGridViewRow r in dgvInputs.SelectedRows)
					r.Cells["inSelected"].Value = !(bool)r.Cells["inSelected"].Value;
		}

		private void copyAddressToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (dgvInputs.SelectedRows.Count > 0)
				Clipboard.SetText((string)dgvInputs.SelectedRows[0].Cells["inAddress"].Value);
		}

		private void copyTxIdToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (dgvInputs.SelectedRows.Count > 0)
				Clipboard.SetText((string)dgvInputs.SelectedRows[0].Cells["inTxId"].Value);
		}

		private void copyValueToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (dgvInputs.SelectedRows.Count > 0)
				Clipboard.SetText(((decimal)dgvInputs.SelectedRows[0].Cells["inValue"].Value).ToString("#######0.00000000"));
		}

		private void txtTx_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
			{
				txtTx.SelectAll();
			}
		}

		private void txtTx_TextChanged(object sender, EventArgs e)
		{
			if (disableUpdate) return;

			try
			{
				Transaction tx = new Transaction(HexString.ToByteArray(txtTx.Text));

				// Disable *_Changed events
				disableUpdate = true;

				// Clear everything
				UTXO.Clear();
				updateUTXOList();
				selectedUTXO.Clear();
				dgvOutputs.Rows.Clear();
				outputs.Clear();

				foreach (TxIn txin in tx.inputs)
				{
					UnspentTxOutHeader txh;
					TxOut txo;

					// Try local bitcoind first
					if (rpc != null)
					{
						try
						{
							string sPrevTx = rpc.doRequest<string>("getrawtransaction", new object[] { HexString.FromByteArrayReversed(txin.prevOut) });
							Transaction prevTx = new Transaction(HexString.ToByteArray(sPrevTx));
							txh = new UnspentTxOutHeader(txin.prevOut, txin.prevOutIndex);
							txo = prevTx.outputs[txin.prevOutIndex];
							UTXO.Add(txh, txo);
							selectedUTXO.Add(txh, txo);
							continue;
						}
						catch (Exception)
						{
						}
					}

					// Get from blockchain if bitcoind fails
					try
					{
						string json;
						using (WebClient wc = new WebClient())
						{
							json = wc.DownloadString("https://blockchain.info/rawtx/" + HexString.FromByteArrayReversed(txin.prevOut));
						}
						JavaScriptSerializer jss = new JavaScriptSerializer();
						Dictionary<string, object> jso = jss.Deserialize<Dictionary<string, object>>(json);
						Dictionary<string, object>[] outs = jss.ConvertToType<Dictionary<string, object>[]>(jso["out"]);
						Address addr = new Address((string)outs[txin.prevOutIndex]["addr"]);
						byte[] scriptPubKey = null;
						if (addr.calcHash() == Address.PUBKEYHASH)
						{
							scriptPubKey = ScriptTemplate.PayToAddress(addr).ToBytes();

						}
						else if (addr.calcHash() == Address.SCRIPTHASH)
						{
							scriptPubKey = ScriptTemplate.PayToScriptHash(addr).ToBytes();
						}
						txh = new UnspentTxOutHeader(txin.prevOut, txin.prevOutIndex);
						txo = new TxOut(jss.ConvertToType<UInt64>(outs[txin.prevOutIndex]["value"]), scriptPubKey);
						UTXO.Add(txh, txo);
						selectedUTXO.Add(txh, txo);
					}
					catch (Exception)
					{
						MessageBox.Show("Could not get input data.");
						return;
					}
				}
				updateUTXOList();
				foreach (DataGridViewRow row in dgvInputs.Rows)
				{
					row.Cells["inSelected"].Value = true;
				}
				foreach (TxOut txout in tx.outputs)
				{
					string addr;
					try
					{
						addr = Address.FromScript(txout.scriptPubKey).ToString();
					}
					catch (Exception)
					{
						addr = "Could not decode address";
					}
					dgvOutputs.Rows.Add(addr, (decimal)txout.value / 100000000m);
					outputs.Add(txout);
				}
				updateTx(false);
				txtTx.ForeColor = SystemColors.WindowText;
			}
			// Transaction invalid
			catch (Exception)
			{
				txtTx.ForeColor = Color.Red;
				return;
			}
			finally
			{
				disableUpdate = false;
			}
		}
	}
}
