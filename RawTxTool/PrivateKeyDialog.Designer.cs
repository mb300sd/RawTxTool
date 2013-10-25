namespace RawTxTool
{
	partial class PrivateKeyDialog
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
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.txtKey0 = new System.Windows.Forms.TextBox();
			this.rbWIF = new System.Windows.Forms.RadioButton();
			this.rbHEX = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.txtKey1 = new System.Windows.Forms.TextBox();
			this.txtKey2 = new System.Windows.Forms.TextBox();
			this.txtKey3 = new System.Windows.Forms.TextBox();
			this.txtKey4 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtRedeemScript = new System.Windows.Forms.TextBox();
			this.cbP2SH = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(146, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Enter private keys for signing:";
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(282, 230);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 12;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(363, 230);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 13;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// txtKey0
			// 
			this.txtKey0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtKey0.Location = new System.Drawing.Point(12, 61);
			this.txtKey0.Name = "txtKey0";
			this.txtKey0.Size = new System.Drawing.Size(426, 20);
			this.txtKey0.TabIndex = 5;
			// 
			// rbWIF
			// 
			this.rbWIF.AutoSize = true;
			this.rbWIF.Checked = true;
			this.rbWIF.Location = new System.Drawing.Point(12, 25);
			this.rbWIF.Name = "rbWIF";
			this.rbWIF.Size = new System.Drawing.Size(45, 17);
			this.rbWIF.TabIndex = 1;
			this.rbWIF.TabStop = true;
			this.rbWIF.Text = "WIF";
			this.rbWIF.UseVisualStyleBackColor = true;
			// 
			// rbHEX
			// 
			this.rbHEX.AutoSize = true;
			this.rbHEX.Location = new System.Drawing.Point(63, 25);
			this.rbHEX.Name = "rbHEX";
			this.rbHEX.Size = new System.Drawing.Size(47, 17);
			this.rbHEX.TabIndex = 2;
			this.rbHEX.Text = "HEX";
			this.rbHEX.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Key type:";
			// 
			// txtKey1
			// 
			this.txtKey1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtKey1.Location = new System.Drawing.Point(12, 87);
			this.txtKey1.Name = "txtKey1";
			this.txtKey1.Size = new System.Drawing.Size(426, 20);
			this.txtKey1.TabIndex = 6;
			// 
			// txtKey2
			// 
			this.txtKey2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtKey2.Location = new System.Drawing.Point(12, 113);
			this.txtKey2.Name = "txtKey2";
			this.txtKey2.Size = new System.Drawing.Size(426, 20);
			this.txtKey2.TabIndex = 7;
			// 
			// txtKey3
			// 
			this.txtKey3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtKey3.Location = new System.Drawing.Point(12, 139);
			this.txtKey3.Name = "txtKey3";
			this.txtKey3.Size = new System.Drawing.Size(426, 20);
			this.txtKey3.TabIndex = 8;
			// 
			// txtKey4
			// 
			this.txtKey4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtKey4.Location = new System.Drawing.Point(12, 165);
			this.txtKey4.Name = "txtKey4";
			this.txtKey4.Size = new System.Drawing.Size(426, 20);
			this.txtKey4.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 188);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Redeem Script:";
			// 
			// txtRedeemScript
			// 
			this.txtRedeemScript.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtRedeemScript.Enabled = false;
			this.txtRedeemScript.Location = new System.Drawing.Point(12, 204);
			this.txtRedeemScript.Name = "txtRedeemScript";
			this.txtRedeemScript.Size = new System.Drawing.Size(426, 20);
			this.txtRedeemScript.TabIndex = 11;
			// 
			// cbP2SH
			// 
			this.cbP2SH.AutoSize = true;
			this.cbP2SH.Location = new System.Drawing.Point(384, 25);
			this.cbP2SH.Name = "cbP2SH";
			this.cbP2SH.Size = new System.Drawing.Size(54, 17);
			this.cbP2SH.TabIndex = 3;
			this.cbP2SH.Text = "P2SH";
			this.cbP2SH.UseVisualStyleBackColor = true;
			this.cbP2SH.CheckedChanged += new System.EventHandler(this.cbP2SH_CheckedChanged);
			// 
			// PrivateKeyDialog
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.button2;
			this.ClientSize = new System.Drawing.Size(450, 265);
			this.Controls.Add(this.cbP2SH);
			this.Controls.Add(this.txtRedeemScript);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtKey4);
			this.Controls.Add(this.txtKey3);
			this.Controls.Add(this.txtKey2);
			this.Controls.Add(this.txtKey1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.rbHEX);
			this.Controls.Add(this.rbWIF);
			this.Controls.Add(this.txtKey0);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PrivateKeyDialog";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		public System.Windows.Forms.TextBox txtKey0;
		public System.Windows.Forms.RadioButton rbWIF;
		public System.Windows.Forms.RadioButton rbHEX;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox txtKey1;
		public System.Windows.Forms.TextBox txtKey2;
		public System.Windows.Forms.TextBox txtKey3;
		public System.Windows.Forms.TextBox txtKey4;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.TextBox txtRedeemScript;
		public System.Windows.Forms.CheckBox cbP2SH;
	}
}