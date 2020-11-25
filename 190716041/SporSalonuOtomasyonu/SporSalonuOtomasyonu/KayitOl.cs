using SporSalonuOtomasyonu.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuOtomasyonu
{
	public partial class KayitOl : Form
	{
		public KayitOl()
		{
			InitializeComponent();
		}

		AdministratorDal _administratorDal = new AdministratorDal();
		private void btnKayitOl_Click(object sender, EventArgs e)
		{
			_administratorDal.YoneticiEkle(new Administrator
			{
				KullaniciAdi = tbxKullaniciAdiKayitOl.Text,
				Sifre = tbxSifreKayitOl.Text
			});
			MessageBox.Show("Kayıt Olundu");
			Form1 form1 = new Form1();
			form1.Show();
			this.Hide();
		}

		private void KayitOl_Load(object sender, EventArgs e)
		{
			pcbKayitOl.ImageLocation = "C:\\Users\\LENOVO\\Desktop\\Demo\\SporSalonuOtomasyonu\\SporSalonuOtomasyonu\\image\\kayitol.png";
		}

		private void KayitOl_FormClosing(object sender, FormClosingEventArgs e)
		{
			Form1 girisyap = new Form1();
			girisyap.Show();
		}
	}
}
