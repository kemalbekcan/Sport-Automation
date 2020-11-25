namespace SporSalonuOtomasyonu
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbxKullaniciAdiLogin = new System.Windows.Forms.TextBox();
			this.tbxSifreLogin = new System.Windows.Forms.TextBox();
			this.btnGirisLogin = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnKayitOl = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(131, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kullanıcı Adı";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(167, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(28, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Şifre";
			// 
			// tbxKullaniciAdiLogin
			// 
			this.tbxKullaniciAdiLogin.Location = new System.Drawing.Point(214, 50);
			this.tbxKullaniciAdiLogin.Name = "tbxKullaniciAdiLogin";
			this.tbxKullaniciAdiLogin.Size = new System.Drawing.Size(96, 20);
			this.tbxKullaniciAdiLogin.TabIndex = 1;
			// 
			// tbxSifreLogin
			// 
			this.tbxSifreLogin.Location = new System.Drawing.Point(214, 83);
			this.tbxSifreLogin.Name = "tbxSifreLogin";
			this.tbxSifreLogin.PasswordChar = '*';
			this.tbxSifreLogin.Size = new System.Drawing.Size(96, 20);
			this.tbxSifreLogin.TabIndex = 2;
			// 
			// btnGirisLogin
			// 
			this.btnGirisLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGirisLogin.Location = new System.Drawing.Point(246, 138);
			this.btnGirisLogin.Name = "btnGirisLogin";
			this.btnGirisLogin.Size = new System.Drawing.Size(96, 35);
			this.btnGirisLogin.TabIndex = 4;
			this.btnGirisLogin.Text = "Giriş Yap";
			this.btnGirisLogin.UseVisualStyleBackColor = true;
			this.btnGirisLogin.Click += new System.EventHandler(this.btnGirisLogin_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(11, 41);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 83);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// btnKayitOl
			// 
			this.btnKayitOl.Location = new System.Drawing.Point(134, 138);
			this.btnKayitOl.Name = "btnKayitOl";
			this.btnKayitOl.Size = new System.Drawing.Size(96, 35);
			this.btnKayitOl.TabIndex = 3;
			this.btnKayitOl.Text = "Kayıt Ol";
			this.btnKayitOl.UseVisualStyleBackColor = true;
			this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(363, 212);
			this.Controls.Add(this.btnKayitOl);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnGirisLogin);
			this.Controls.Add(this.tbxSifreLogin);
			this.Controls.Add(this.tbxKullaniciAdiLogin);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Kullanıcı Girişi";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbxKullaniciAdiLogin;
		private System.Windows.Forms.TextBox tbxSifreLogin;
		private System.Windows.Forms.Button btnGirisLogin;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnKayitOl;
	}
}

