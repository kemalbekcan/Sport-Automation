using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SporSalonuOtomasyonu.Entities
{
	public class CustomerExpiredDal
	{
		SqlConnection _connection = new SqlConnection(@"server=Lenovo\SQLEXPRESS; initial catalog = _190716041; integrated security = true;");
		public DataTable GetListExpired()
		{
			_connection.Open();
			SqlCommand command = new SqlCommand("SELECT * FROM personalInformation where convert(date,bitisTarihi)<convert(date,getdate())", _connection);
			SqlDataReader reader = command.ExecuteReader();
			DataTable dataTable = new DataTable();
			dataTable.Load(reader);
			reader.Close();
			_connection.Close();
			return dataTable;
		}

		public void CustomerExpiredAdd(Customer customer)
		{
			_connection.Open();
			SqlCommand command = new SqlCommand("INSERT INTO personalInformation (Ad,Soyad,Tel,Cinsiyet,kayitTarihi,bitisTarihi,Adres) values(@Ad,@Soyad,@Tel,@Cinsiyet,@Kayit_Tarihi,@Bitis_Tarihi,@Adres)", _connection);
			command.Parameters.AddWithValue("@Ad", customer.Ad);
			command.Parameters.AddWithValue("@Soyad", customer.Soyad);
			command.Parameters.AddWithValue("@Tel", customer.Tel);
			command.Parameters.AddWithValue("@Cinsiyet", customer.Cinsiyet);
			
			command.Parameters.AddWithValue("@Bitis_Tarihi", customer.BitisTarihi);
			command.Parameters.AddWithValue("@Adres", customer.Adres);
			command.ExecuteNonQuery();
			_connection.Close();
		}
	}
}
