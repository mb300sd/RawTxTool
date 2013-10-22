namespace RawTxTool
{
	partial class BitcoindDialog
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
			this.txtHost = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(363, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Could not get rpc information from bitcoin.conf. Please enter rpc information.";
			// 
			// txtHost
			// 
			this.txtHost.Location = new System.Drawing.Point(51, 35);
			this.txtHost.Name = "txtHost";
			this.txtHost.Size = new System.Drawing.Size(324, 20);
			this.txtHost.TabIndex = 1;
			this.txtHost.Text = "127.0.0.1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Host:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Port:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 90);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "User:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 116);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(33, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Pass:";
			// 
			// txtPort
			// 
			this.txtPort.Location = new System.Drawing.Point(51, 61);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(324, 20);
			this.txtPort.TabIndex = 6;
			this.txtPort.Text = "8332";
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(51, 87);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(324, 20);
			this.txtUser.TabIndex = 7;
			// 
			// txtPass
			// 
			this.txtPass.Location = new System.Drawing.Point(51, 113);
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(324, 20);
			this.txtPass.TabIndex = 8;
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(219, 139);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(300, 139);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 10;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// BitcoindDialog
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.button2;
			this.ClientSize = new System.Drawing.Size(387, 174);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.txtPort);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtHost);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "BitcoindDialog";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		public System.Windows.Forms.TextBox txtHost;
		public System.Windows.Forms.TextBox txtPort;
		public System.Windows.Forms.TextBox txtUser;
		public System.Windows.Forms.TextBox txtPass;
	}
}