namespace RawTxTool
{
	partial class RawTxTool
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvInputs = new System.Windows.Forms.DataGridView();
			this.inSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.inAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.inValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.invOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.inTxId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnFromBitcoind = new System.Windows.Forms.Button();
			this.lblGetInputs = new System.Windows.Forms.Label();
			this.btnFromBlockchain = new System.Windows.Forms.Button();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.btnClear = new System.Windows.Forms.Button();
			this.dgvOutputs = new System.Windows.Forms.DataGridView();
			this.outAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.outAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblTotalIn = new System.Windows.Forms.Label();
			this.lblTotalOut = new System.Windows.Forms.Label();
			this.lblChange = new System.Windows.Forms.Label();
			this.txtTx = new System.Windows.Forms.TextBox();
			this.btnSignBitcoind = new System.Windows.Forms.Button();
			this.btnSignPrivkey = new System.Windows.Forms.Button();
			this.btnSendBlockchain = new System.Windows.Forms.Button();
			this.btnSendBitcoind = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportInputsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importInputsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			((System.ComponentModel.ISupportInitialize)(this.dgvInputs)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvOutputs)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvInputs
			// 
			this.dgvInputs.AllowUserToAddRows = false;
			this.dgvInputs.AllowUserToDeleteRows = false;
			this.dgvInputs.AllowUserToResizeRows = false;
			this.dgvInputs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvInputs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvInputs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvInputs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inSelected,
            this.inAddress,
            this.inValue,
            this.invOut,
            this.inTxId});
			this.dgvInputs.Location = new System.Drawing.Point(12, 56);
			this.dgvInputs.Name = "dgvInputs";
			this.dgvInputs.RowHeadersVisible = false;
			this.dgvInputs.Size = new System.Drawing.Size(768, 200);
			this.dgvInputs.TabIndex = 0;
			this.dgvInputs.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInputs_CellValueChanged);
			// 
			// inSelected
			// 
			this.inSelected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.inSelected.HeaderText = "";
			this.inSelected.Name = "inSelected";
			this.inSelected.Width = 5;
			// 
			// inAddress
			// 
			this.inAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.inAddress.HeaderText = "Address";
			this.inAddress.Name = "inAddress";
			this.inAddress.ReadOnly = true;
			this.inAddress.Width = 70;
			// 
			// inValue
			// 
			this.inValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.inValue.DefaultCellStyle = dataGridViewCellStyle6;
			this.inValue.HeaderText = "Value";
			this.inValue.Name = "inValue";
			this.inValue.Width = 59;
			// 
			// invOut
			// 
			this.invOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.invOut.HeaderText = "vOut";
			this.invOut.Name = "invOut";
			this.invOut.Width = 55;
			// 
			// inTxId
			// 
			this.inTxId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.inTxId.HeaderText = "TxId";
			this.inTxId.Name = "inTxId";
			// 
			// btnFromBitcoind
			// 
			this.btnFromBitcoind.Location = new System.Drawing.Point(77, 27);
			this.btnFromBitcoind.Name = "btnFromBitcoind";
			this.btnFromBitcoind.Size = new System.Drawing.Size(85, 23);
			this.btnFromBitcoind.TabIndex = 1;
			this.btnFromBitcoind.Text = "From Bitcoind";
			this.btnFromBitcoind.UseVisualStyleBackColor = true;
			this.btnFromBitcoind.Click += new System.EventHandler(this.btnFromBitcoind_Click);
			// 
			// lblGetInputs
			// 
			this.lblGetInputs.AutoSize = true;
			this.lblGetInputs.Location = new System.Drawing.Point(12, 32);
			this.lblGetInputs.Name = "lblGetInputs";
			this.lblGetInputs.Size = new System.Drawing.Size(59, 13);
			this.lblGetInputs.TabIndex = 2;
			this.lblGetInputs.Text = "Get Inputs:";
			// 
			// btnFromBlockchain
			// 
			this.btnFromBlockchain.Location = new System.Drawing.Point(168, 27);
			this.btnFromBlockchain.Name = "btnFromBlockchain";
			this.btnFromBlockchain.Size = new System.Drawing.Size(114, 23);
			this.btnFromBlockchain.TabIndex = 3;
			this.btnFromBlockchain.Text = "From Blockchain.info";
			this.btnFromBlockchain.UseVisualStyleBackColor = true;
			this.btnFromBlockchain.Click += new System.EventHandler(this.btnFromBlockchain_Click);
			// 
			// txtAddress
			// 
			this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAddress.Location = new System.Drawing.Point(288, 29);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(411, 20);
			this.txtAddress.TabIndex = 4;
			this.txtAddress.Text = "Bitcoin Address";
			this.txtAddress.Enter += new System.EventHandler(this.txtAddress_Enter);
			// 
			// btnClear
			// 
			this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClear.Location = new System.Drawing.Point(705, 27);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 5;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// dgvOutputs
			// 
			this.dgvOutputs.AllowUserToResizeRows = false;
			this.dgvOutputs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvOutputs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvOutputs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvOutputs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.outAddress,
            this.outAmount});
			this.dgvOutputs.Location = new System.Drawing.Point(12, 262);
			this.dgvOutputs.Name = "dgvOutputs";
			this.dgvOutputs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvOutputs.Size = new System.Drawing.Size(768, 200);
			this.dgvOutputs.TabIndex = 6;
			this.dgvOutputs.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOutputs_CellEndEdit);
			// 
			// outAddress
			// 
			this.outAddress.HeaderText = "Address";
			this.outAddress.Name = "outAddress";
			// 
			// outAmount
			// 
			this.outAmount.HeaderText = "Amount";
			this.outAmount.Name = "outAmount";
			// 
			// lblTotalIn
			// 
			this.lblTotalIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTotalIn.Location = new System.Drawing.Point(654, 471);
			this.lblTotalIn.Name = "lblTotalIn";
			this.lblTotalIn.Size = new System.Drawing.Size(126, 26);
			this.lblTotalIn.TabIndex = 7;
			this.lblTotalIn.Text = "Total Inputs:\r\n0";
			// 
			// lblTotalOut
			// 
			this.lblTotalOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTotalOut.Location = new System.Drawing.Point(654, 497);
			this.lblTotalOut.Name = "lblTotalOut";
			this.lblTotalOut.Size = new System.Drawing.Size(126, 26);
			this.lblTotalOut.TabIndex = 8;
			this.lblTotalOut.Text = "Total Outputs:\r\n0";
			// 
			// lblChange
			// 
			this.lblChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblChange.Location = new System.Drawing.Point(654, 523);
			this.lblChange.Name = "lblChange";
			this.lblChange.Size = new System.Drawing.Size(126, 26);
			this.lblChange.TabIndex = 9;
			this.lblChange.Text = "Change:\r\n0";
			// 
			// txtTx
			// 
			this.txtTx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTx.Location = new System.Drawing.Point(12, 468);
			this.txtTx.Multiline = true;
			this.txtTx.Name = "txtTx";
			this.txtTx.Size = new System.Drawing.Size(636, 215);
			this.txtTx.TabIndex = 10;
			// 
			// btnSignBitcoind
			// 
			this.btnSignBitcoind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSignBitcoind.Location = new System.Drawing.Point(654, 573);
			this.btnSignBitcoind.Name = "btnSignBitcoind";
			this.btnSignBitcoind.Size = new System.Drawing.Size(126, 23);
			this.btnSignBitcoind.TabIndex = 11;
			this.btnSignBitcoind.Text = "Sign with Bitcoind";
			this.btnSignBitcoind.UseVisualStyleBackColor = true;
			this.btnSignBitcoind.Click += new System.EventHandler(this.btnSignBitcoind_Click);
			// 
			// btnSignPrivkey
			// 
			this.btnSignPrivkey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSignPrivkey.Location = new System.Drawing.Point(654, 602);
			this.btnSignPrivkey.Name = "btnSignPrivkey";
			this.btnSignPrivkey.Size = new System.Drawing.Size(126, 23);
			this.btnSignPrivkey.TabIndex = 12;
			this.btnSignPrivkey.Text = "Sign with Private Key";
			this.btnSignPrivkey.UseVisualStyleBackColor = true;
			this.btnSignPrivkey.Click += new System.EventHandler(this.btnSignPrivkey_Click);
			// 
			// btnSendBlockchain
			// 
			this.btnSendBlockchain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSendBlockchain.Location = new System.Drawing.Point(654, 660);
			this.btnSendBlockchain.Name = "btnSendBlockchain";
			this.btnSendBlockchain.Size = new System.Drawing.Size(126, 23);
			this.btnSendBlockchain.TabIndex = 13;
			this.btnSendBlockchain.Text = "Send (blockchain.info)";
			this.btnSendBlockchain.UseVisualStyleBackColor = true;
			this.btnSendBlockchain.Click += new System.EventHandler(this.btnSendBlockchain_Click);
			// 
			// btnSendBitcoind
			// 
			this.btnSendBitcoind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSendBitcoind.Location = new System.Drawing.Point(654, 631);
			this.btnSendBitcoind.Name = "btnSendBitcoind";
			this.btnSendBitcoind.Size = new System.Drawing.Size(126, 23);
			this.btnSendBitcoind.TabIndex = 14;
			this.btnSendBitcoind.Text = "Send (bitcoind)";
			this.btnSendBitcoind.UseVisualStyleBackColor = true;
			this.btnSendBitcoind.Click += new System.EventHandler(this.btnSendBitcoind_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(792, 24);
			this.menuStrip1.TabIndex = 15;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportInputsToolStripMenuItem,
            this.importInputsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exportInputsToolStripMenuItem
			// 
			this.exportInputsToolStripMenuItem.Name = "exportInputsToolStripMenuItem";
			this.exportInputsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exportInputsToolStripMenuItem.Text = "Export Inputs";
			this.exportInputsToolStripMenuItem.Click += new System.EventHandler(this.exportInputsToolStripMenuItem_Click);
			// 
			// importInputsToolStripMenuItem
			// 
			this.importInputsToolStripMenuItem.Name = "importInputsToolStripMenuItem";
			this.importInputsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.importInputsToolStripMenuItem.Text = "Import Inputs";
			this.importInputsToolStripMenuItem.Click += new System.EventHandler(this.importInputsToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
			// 
			// RawTxTool
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(792, 695);
			this.Controls.Add(this.btnSendBitcoind);
			this.Controls.Add(this.btnSendBlockchain);
			this.Controls.Add(this.btnSignPrivkey);
			this.Controls.Add(this.btnSignBitcoind);
			this.Controls.Add(this.txtTx);
			this.Controls.Add(this.lblChange);
			this.Controls.Add(this.lblTotalOut);
			this.Controls.Add(this.lblTotalIn);
			this.Controls.Add(this.dgvOutputs);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.btnFromBlockchain);
			this.Controls.Add(this.lblGetInputs);
			this.Controls.Add(this.btnFromBitcoind);
			this.Controls.Add(this.dgvInputs);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "RawTxTool";
			this.Text = "Raw Tx Tool";
			((System.ComponentModel.ISupportInitialize)(this.dgvInputs)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvOutputs)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvInputs;
		private System.Windows.Forms.Button btnFromBitcoind;
		private System.Windows.Forms.Label lblGetInputs;
		private System.Windows.Forms.Button btnFromBlockchain;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.DataGridView dgvOutputs;
		private System.Windows.Forms.DataGridViewTextBoxColumn outAddress;
		private System.Windows.Forms.DataGridViewTextBoxColumn outAmount;
		private System.Windows.Forms.Label lblTotalIn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn inSelected;
		private System.Windows.Forms.DataGridViewTextBoxColumn inAddress;
		private System.Windows.Forms.DataGridViewTextBoxColumn inValue;
		private System.Windows.Forms.DataGridViewTextBoxColumn invOut;
		private System.Windows.Forms.DataGridViewTextBoxColumn inTxId;
		private System.Windows.Forms.Label lblTotalOut;
		private System.Windows.Forms.Label lblChange;
		private System.Windows.Forms.TextBox txtTx;
		private System.Windows.Forms.Button btnSignBitcoind;
		private System.Windows.Forms.Button btnSignPrivkey;
		private System.Windows.Forms.Button btnSendBlockchain;
		private System.Windows.Forms.Button btnSendBitcoind;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportInputsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importInputsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;


	}
}

