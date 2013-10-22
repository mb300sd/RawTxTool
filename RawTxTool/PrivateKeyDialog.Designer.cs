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
			this.txtKey = new System.Windows.Forms.TextBox();
			this.rbWIF = new System.Windows.Forms.RadioButton();
			this.rbHEX = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter private key for signing:";
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(179, 51);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(260, 51);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// txtKey
			// 
			this.txtKey.Location = new System.Drawing.Point(12, 25);
			this.txtKey.Name = "txtKey";
			this.txtKey.Size = new System.Drawing.Size(323, 20);
			this.txtKey.TabIndex = 3;
			// 
			// rbWIF
			// 
			this.rbWIF.AutoSize = true;
			this.rbWIF.Checked = true;
			this.rbWIF.Location = new System.Drawing.Point(15, 54);
			this.rbWIF.Name = "rbWIF";
			this.rbWIF.Size = new System.Drawing.Size(45, 17);
			this.rbWIF.TabIndex = 4;
			this.rbWIF.TabStop = true;
			this.rbWIF.Text = "WIF";
			this.rbWIF.UseVisualStyleBackColor = true;
			// 
			// rbHEX
			// 
			this.rbHEX.AutoSize = true;
			this.rbHEX.Location = new System.Drawing.Point(66, 54);
			this.rbHEX.Name = "rbHEX";
			this.rbHEX.Size = new System.Drawing.Size(47, 17);
			this.rbHEX.TabIndex = 5;
			this.rbHEX.Text = "HEX";
			this.rbHEX.UseVisualStyleBackColor = true;
			// 
			// PrivateKeyDialog
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.button2;
			this.ClientSize = new System.Drawing.Size(347, 86);
			this.Controls.Add(this.rbHEX);
			this.Controls.Add(this.rbWIF);
			this.Controls.Add(this.txtKey);
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
		public System.Windows.Forms.TextBox txtKey;
		public System.Windows.Forms.RadioButton rbWIF;
		public System.Windows.Forms.RadioButton rbHEX;
	}
}