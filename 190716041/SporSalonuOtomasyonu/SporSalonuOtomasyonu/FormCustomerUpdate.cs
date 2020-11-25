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
	public partial class FormCustomerUpdate : Form
	{
		public FormCustomerUpdate()
		{
			InitializeComponent();
		}

		CustomerDal _customerDal = new CustomerDal();

		private void FormCustomerUpdate_Load(object sender, EventArgs e)
		{
			customerLoad();
		}

		private void customerLoad()
		{
			dgvCustomerUpdate.DataSource = _customerDal.GetList();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void Guncelle()
		{
			_customerDal.CustomerUpdate(new CustomerProperties
			{
				PersonalId = Convert.ToInt32(dgvCustomerUpdate.CurrentRow.Cells[0].Value),
				Kilo = Convert.ToInt32(tbxKiloGuncelle.Text),
				Boy = Convert.ToInt32(tbxBoyGuncelle.Text),
				Kol = Convert.ToInt32(tbxKolGuncelle.Text),
				Bel = Convert.ToInt32(tbxBelGuncelle.Text),
				Gogus = Convert.ToInt32(tbxGogusGuncelle.Text),
				Kalca = Convert.ToInt32(tbxKalcaGuncelle.Text),
				Omuz = Convert.ToInt32(tbxOmuzGuncelle.Text),
			});
			MessageBox.Show("Müşteri Özellikleri Güncellendi !");
			customerLoad();
		}

		private void dgvCustomerUpdate_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			tbxKiloGuncelle.Text = Convert.ToString(dgvCustomerUpdate.CurrentRow.Cells[8].Value);
			tbxBoyGuncelle.Text = Convert.ToString(dgvCustomerUpdate.CurrentRow.Cells[9].Value);
			tbxKolGuncelle.Text = Convert.ToString(dgvCustomerUpdate.CurrentRow.Cells[10].Value);
			tbxBelGuncelle.Text = Convert.ToString(dgvCustomerUpdate.CurrentRow.Cells[11].Value);
			tbxGogusGuncelle.Text = Convert.ToString(dgvCustomerUpdate.CurrentRow.Cells[12].Value);
			tbxKalcaGuncelle.Text = Convert.ToString(dgvCustomerUpdate.CurrentRow.Cells[13].Value);
			tbxOmuzGuncelle.Text = Convert.ToString(dgvCustomerUpdate.CurrentRow.Cells[14].Value);
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			Guncelle();
			Menu menu = new Menu();
			menu.Show();
			this.Hide();
		}

		private void FormCustomerUpdate_FormClosing(object sender, FormClosingEventArgs e)
		{
			Menu menu = new Menu();
			menu.Show();
		}
	}
}
