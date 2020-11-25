using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SporSalonuOtomasyonu.Entities;

namespace SporSalonuOtomasyonu
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		AdministratorDal _administratorDal = new AdministratorDal();
		private void Form1_Load(object sender, EventArgs e)
		{
			pictureBox1.ImageLocation = "C:\\Users\\LENOVO\\Desktop\\Demo\\SporSalonuOtomasyonu\\SporSalonuOtomasyonu\\image\\keys.png";
			Listele();
		}

		private void Listele()
		{
			_administratorDal.GetList();
		}

		private void btnGirisLogin_Click(object sender, EventArgs e)
		{
			bool girisislemi = _administratorDal.Giris(new Administrator
			{
				KullaniciAdi = tbxKullaniciAdiLogin.Text,
				Sifre = tbxSifreLogin.Text,
			});
			if (girisislemi)
			{
				MessageBox.Show("Giriş Başarılı");
				Menu menu = new Menu();
				menu.Show();
				this.Hide();
			}

			else if (girisislemi == false)
			{
				MessageBox.Show("Yanlış giriş yaptınız");
			}

		}

		private void btnKayitOl_Click(object sender, EventArgs e)
		{
			KayitOl kayitOl = new KayitOl();
			kayitOl.Show();
			this.Hide();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
