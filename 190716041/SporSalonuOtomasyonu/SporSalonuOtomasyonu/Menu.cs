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
	public partial class Menu : Form
	{
		public Menu()
		{
			InitializeComponent();
		}
		CustomerDal _customerDal = new CustomerDal();
		FormCustomerAdd _customerAdd = new FormCustomerAdd();

		PaymentsDal _paymentsDal = new PaymentsDal();
		private void Menu_Load(object sender, EventArgs e)
		{
			
			Listele();

			customerPaymentsLoad();

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void Listele()
		{
			dgvEnrollees.DataSource = _customerDal.GetList();

			dgvCustomerExpired.DataSource = _customerExpired.GetListExpired();
		}

		private void btnCustomerAdd_Click_1(object sender, EventArgs e)
		{
			FormCustomerAdd customerAdd = new FormCustomerAdd();
			customerAdd.Show();
			this.Hide();
		}

		private void btnCustomerDelete_Click(object sender, EventArgs e)
		{
			CustomerDelete();
		}

		private void CustomerDelete()
		{
			CustomerDelete customerDelete = new CustomerDelete();
			customerDelete.Show();
			this.Close();
		}

		private void btnCustomerUpdate_Click(object sender, EventArgs e)
		{
			FormCustomerUpdate();
		}

		private void FormCustomerUpdate()
		{
			FormCustomerUpdate customerUpdate = new FormCustomerUpdate();
			customerUpdate.Show();
			this.Hide();
		}
		CustomerExpiredDal _customerExpired = new CustomerExpiredDal();
		private void button4_Click(object sender, EventArgs e)
		{

			_customerExpired.CustomerExpiredAdd(new Customer
			{
				Ad = Convert.ToString(dgvCustomerExpired.CurrentRow.Cells[1].Value),
				Soyad = Convert.ToString(dgvCustomerExpired.CurrentRow.Cells[2].Value),
				Tel = Convert.ToInt64(dgvCustomerExpired.CurrentRow.Cells[3].Value),
				Cinsiyet = Convert.ToString(dgvCustomerExpired.CurrentRow.Cells[4].Value),
				KayitTarihi = Convert.ToDateTime(dgvCustomerExpired.CurrentRow.Cells[5].Value),
				BitisTarihi = Convert.ToDateTime(dgvCustomerExpired.CurrentRow.Cells[6].Value),
				Adres = Convert.ToString(dgvCustomerExpired.CurrentRow.Cells[7].Value),
			});
			


			_customerDal.CustomerDelete(new Customer
			{
				Id = Convert.ToInt32(dgvEnrollees.CurrentRow.Cells[0].Value),
			});
			

		}

		private void customerPaymentsLoad()
		{
			btnCustomerDelete.DataSource = _paymentsDal.GetAllDataTable();
		}
	}
}
