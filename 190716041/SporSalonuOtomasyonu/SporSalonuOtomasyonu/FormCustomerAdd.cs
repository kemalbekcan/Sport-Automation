using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SporSalonuOtomasyonu.Entities;

namespace SporSalonuOtomasyonu
{
	public partial class FormCustomerAdd : Form
	{
		public FormCustomerAdd()
		{
			InitializeComponent();
		}
		CustomerDal _customerDal = new CustomerDal();

		private void FormCustomerAdd_Load(object sender, EventArgs e)
		{
			ComboboxListele();
			Ogrenci();
			Odeme();
			
		}

		private void btnCustomerAdd_Click(object sender, EventArgs e)
		{

			Ekle();
			MüsteriOzellikEkle();
			FiyatEkle();
			Menu menu = new Menu();
			menu.Show();
			this.Hide();
			
		}

		private void Listele()
		{
			_customerDal.GetList();
		}

		private void Ogrenci()
		{
			string[] ogrenci = new[] { "Evet", "Hayır" };
			cbxOgrenci.Items.AddRange(ogrenci);
			cbxOgrenci.SelectedIndex = 1;
		}
		private void Odeme()
		{
			string[] odeme = new[] { "Peşin", "Taksit" };
			cbxOdeme.Items.AddRange(odeme);
			cbxOdeme.SelectedIndex = 0;
		}

		private void ComboboxListele()
		{
			string[] Cinsiyet = new[] { "belirtmek istemiyorum","erkek", "kadın" };
			cbxGenderAdd.Items.AddRange(Cinsiyet);
			cbxGenderAdd.SelectedIndex = 0;
		}

		private void Ekle()
		{
			_customerDal.CustomerAdd(new Customer
			{
				Id = Convert.ToInt32(tbxPersonalIdInformation.Text),
				Ad = tbxPersonalInformationFirstNameAdd.Text,
				Soyad = tbxPersonalInformationLastNameAdd.Text,
				Tel = Convert.ToInt64(tbxPersonalInformationTelAdd.Text),
				Cinsiyet = cbxGenderAdd.Text,
				KayitTarihi = Convert.ToDateTime(dtpPersonalInformationKayitTarihi.Text),
				BitisTarihi = Convert.ToDateTime(dtpPersonalInformationBitisTarihi.Text),
				Adres = rtbPersonalInformationAdress.Text,
			});
			MessageBox.Show("Müşteri Eklendi !!");
		}

		private void MüsteriOzellikEkle()
		{
			_customerDal.CustomerProperties(new CustomerProperties
			{
				PersonalId = Convert.ToInt32(tbxPersonalIdInformation.Text),
				Kilo = Convert.ToInt32(tbxKilo.Text),
				Boy = Convert.ToInt32(tbxBoy.Text),
				Kol = Convert.ToInt32(tbxKol.Text),
				Bel = Convert.ToInt32(tbxBel.Text),
				Gogus = Convert.ToInt32(tbxGögüs.Text),
				Kalca = Convert.ToInt32(tbxKalca.Text),
				Omuz = Convert.ToInt32(tbxOmuz.Text),



			});
		}
		private void FiyatEkle()
		{
			_customerDal.CustomerPayments(new Payments
			{
				PersonalId = Convert.ToInt32(tbxPersonalIdInformation.Text),
				Ogrenci = Convert.ToString(cbxOgrenci.Text),
				Odeme = Convert.ToString(cbxOdeme.Text),
				tutar = Convert.ToInt32(lblFiyatGoster.Text),
			});
		}


		private void btnFiyatHesapla_Click(object sender, EventArgs e)
		{
			int baslangicTarihi, bitisTarihi;
			baslangicTarihi = Convert.ToInt32(dtpPersonalInformationKayitTarihi.Value.Day);
			bitisTarihi = Convert.ToInt32(dtpPersonalInformationBitisTarihi.Value.Day);
			TimeSpan gunfarki = dtpPersonalInformationBitisTarihi.Value.Subtract(dtpPersonalInformationKayitTarihi.Value);
			int ata = 0;
			ata = Convert.ToInt32(gunfarki.TotalDays);
			lblFiyatGoster.Text = gunfarki.Days.ToString();
			int süre = 0;
			süre = bitisTarihi - baslangicTarihi;
			int fiyat = 0;
			fiyat = Convert.ToInt32(tbxGunlukFiyat.Text);
			int hesapla = 0;
			if (cbxOgrenci.Text == "Evet")
			{
				hesapla = ata * fiyat / 2;
				lblFiyatGoster.Text = Convert.ToString(hesapla);
			}
			else
			{
				hesapla = ata * fiyat;
				lblFiyatGoster.Text = Convert.ToString(hesapla);
			}

		}
		SqlConnection _connection = new SqlConnection(@"server=LAPTOP-C95CRFGG\SQLEXPRESS; initial catalog = gym; integrated security = true;");
		public DataTable bitmisSüre()
		{
			int baslangicTarihi, bitisTarihi;
			baslangicTarihi = Convert.ToInt32(dtpPersonalInformationKayitTarihi.Value.Day);
			bitisTarihi = Convert.ToInt32(dtpPersonalInformationBitisTarihi.Value.Day);

			if (baslangicTarihi > bitisTarihi)
			{

				_connection.Open();
				SqlCommand command = new SqlCommand("SELECT * FROM personalInformation", _connection);
				SqlDataReader reader = command.ExecuteReader();
				DataTable dataTable = new DataTable();
				dataTable.Load(reader);
				reader.Close();
				_connection.Close();
				return dataTable;
			}
			else
			{
				_connection.Open();
				SqlCommand command = new SqlCommand("SELECT * FROM personalInformation", _connection);
				SqlDataReader reader = command.ExecuteReader();
				DataTable dataTable = new DataTable();
				dataTable.Load(reader);
				reader.Close();
				_connection.Close();
				return dataTable;
			}


		}

		private void button1_Click(object sender, EventArgs e)
		{
			
		}

		private void button3_Click(object sender, EventArgs e)
		{
			
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void FormCustomerAdd_FormClosing(object sender, FormClosingEventArgs e)
		{
			Menu menu = new Menu();
			menu.Show();
		}
	}
}
