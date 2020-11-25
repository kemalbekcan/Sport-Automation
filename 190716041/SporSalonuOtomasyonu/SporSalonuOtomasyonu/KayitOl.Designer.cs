namespace SporSalonuOtomasyonu
{
	partial class KayitOl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayitOl));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbxKullaniciAdiKayitOl = new System.Windows.Forms.TextBox();
			this.tbxSifreKayitOl = new System.Windows.Forms.TextBox();
			this.btnKayitOl = new System.Windows.Forms.Button();
			this.pcbKayitOl = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pcbKayitOl)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(192, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kullanıcı Adı";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(192, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(28, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Şifre";
			// 
			// tbxKullaniciAdiKayitOl
			// 
			this.tbxKullaniciAdiKayitOl.Location = new System.Drawing.Point(262, 23);
			this.tbxKullaniciAdiKayitOl.Name = "tbxKullaniciAdiKayitOl";
			this.tbxKullaniciAdiKayitOl.Size = new System.Drawing.Size(100, 20);
			this.tbxKullaniciAdiKayitOl.TabIndex = 2;
			// 
			// tbxSifreKayitOl
			// 
			this.tbxSifreKayitOl.Location = new System.Drawing.Point(262, 62);
			this.tbxSifreKayitOl.Name = "tbxSifreKayitOl";
			this.tbxSifreKayitOl.PasswordChar = '*';
			this.tbxSifreKayitOl.Size = new System.Drawing.Size(100, 20);
			this.tbxSifreKayitOl.TabIndex = 3;
			// 
			// btnKayitOl
			// 
			this.btnKayitOl.Location = new System.Drawing.Point(262, 105);
			this.btnKayitOl.Name = "btnKayitOl";
			this.btnKayitOl.Size = new System.Drawing.Size(100, 33);
			this.btnKayitOl.TabIndex = 4;
			this.btnKayitOl.Text = "Kayıt Ol";
			this.btnKayitOl.UseVisualStyleBackColor = true;
			this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
			// 
			// pcbKayitOl
			// 
			this.pcbKayitOl.Location = new System.Drawing.Point(12, 12);
			this.pcbKayitOl.Name = "pcbKayitOl";
			this.pcbKayitOl.Size = new System.Drawing.Size(153, 126);
			this.pcbKayitOl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pcbKayitOl.TabIndex = 5;
			this.pcbKayitOl.TabStop = false;
			// 
			// KayitOl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(397, 161);
			this.Controls.Add(this.pcbKayitOl);
			this.Controls.Add(this.btnKayitOl);
			this.Controls.Add(this.tbxSifreKayitOl);
			this.Controls.Add(this.tbxKullaniciAdiKayitOl);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "KayitOl";
			this.Text = "Kayıt Ol";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KayitOl_FormClosing);
			this.Load += new System.EventHandler(this.KayitOl_Load);
			((System.ComponentModel.ISupportInitialize)(this.pcbKayitOl)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbxKullaniciAdiKayitOl;
		private System.Windows.Forms.TextBox tbxSifreKayitOl;
		private System.Windows.Forms.Button btnKayitOl;
		private System.Windows.Forms.PictureBox pcbKayitOl;
	}
}