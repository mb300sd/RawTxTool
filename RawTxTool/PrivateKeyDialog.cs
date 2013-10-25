using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RawTxTool
{
	public partial class PrivateKeyDialog : Form
	{
		public List<TextBox> txtKeyList = new List<TextBox>();

		public PrivateKeyDialog()
		{
			InitializeComponent();
			txtKeyList.Add(txtKey0);
			txtKeyList.Add(txtKey1);
			txtKeyList.Add(txtKey2);
			txtKeyList.Add(txtKey3);
			txtKeyList.Add(txtKey4);
		}

		private void cbP2SH_CheckedChanged(object sender, EventArgs e)
		{
			txtRedeemScript.Enabled = cbP2SH.Checked;
		}
	}
}
