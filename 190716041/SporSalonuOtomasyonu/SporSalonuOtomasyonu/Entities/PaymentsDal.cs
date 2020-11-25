using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporSalonuOtomasyonu.Entities
{
	public class PaymentsDal
	{
		SqlConnection _connection = new SqlConnection(@"server = Lenovo\SQLEXPRESS; initial catalog= _190716041; integrated security = true");

		public DataTable GetAllDataTable()
		{
			_connection.Open();
			SqlCommand command = new SqlCommand("SELECT personalInformation.Ad,personalInformation.Soyad, Odemeler.Ogrenci,Odemeler.Odeme,Odemeler.Tutar from personalInformation INNER JOIN Odemeler ON personalInformation.PersonalId = Odemeler.PersonalId ", _connection);
			SqlDataReader reader = command.ExecuteReader();
			DataTable dataTable = new DataTable();
			dataTable.Load(reader);
			reader.Close();
			_connection.Close();
			return dataTable;
		}
	}
}
