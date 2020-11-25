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
	public partial class CustomerDelete : Form
	{
		public CustomerDelete()
		{
			InitializeComponent();
		}
		CustomerDal _customerDal = new CustomerDal();
		private void CustomerDelete_Load(object sender, EventArgs e)
		{
			customerLoad();
		}

		private void customerLoad()
		{
			dgvCustomerDelete.DataSource = _customerDal.GetList();
		}

		private void dgvCustomerDelete_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void customerDelete()
		{
			_customerDal.CustomerDelete(new Customer
			{
				Id = Convert.ToInt32(dgvCustomerDelete.CurrentRow.Cells[0].Value),
			});
		}

		private void btnCustomerDelete_Click(object sender, EventArgs e)
		{
			customerDelete();
			customerLoad();
			MessageBox.Show("Müşteri Silindi !!");
			Menu menu = new Menu();
			menu.Show();
			this.Hide();

		}

		private void CustomerDelete_FormClosing(object sender, FormClosingEventArgs e)
		{
			Menu menu = new Menu();
			menu.Show();
		}
	}
}
