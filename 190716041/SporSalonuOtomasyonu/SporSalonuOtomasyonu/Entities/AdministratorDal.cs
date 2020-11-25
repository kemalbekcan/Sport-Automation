using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporSalonuOtomasyonu.Entities
{
	public class AdministratorDal
	{
		SqlConnection _connection = new SqlConnection(@"server =Lenovo\SQLEXPRESS; initial catalog = _190716041; integrated security = true;");

		public DataTable GetList()
		{
			_connection.Open();
			SqlCommand command = new SqlCommand("SELECT * FROM Yonetici",_connection);
			SqlDataReader reader = command.ExecuteReader();
			DataTable dataTable = new DataTable();
			dataTable.Load(reader);
			reader.Close();
			_connection.Close();
			return dataTable;
		}

		public bool Giris(Administrator administrator)
		{

			_connection.Open();
			SqlCommand command = new SqlCommand("SELECT * FROM Yonetici where kullaniciAdi = @KullaniciAdi and Sifre = @Sifre", _connection);
			command.Parameters.AddWithValue("@KullaniciAdi", administrator.KullaniciAdi);
			command.Parameters.AddWithValue("@Sifre", administrator.Sifre);
			//command.ExecuteNonQuery();
			SqlDataReader reader = command.ExecuteReader();
			if (reader.Read())
			{
				_connection.Close();
				return true;
			}
			else
			{
				_connection.Close();
				return false;
			}


		}
		
		public void YoneticiEkle(Administrator administrator)
		{
			_connection.Open();
			SqlCommand command = new SqlCommand("INSERT INTO Yonetici(kullaniciAdi,Sifre) VALUES(@KullaniciAdi,@Sifre)",_connection);
			command.Parameters.AddWithValue("@KullaniciAdi",administrator.KullaniciAdi);
			command.Parameters.AddWithValue("@Sifre", administrator.Sifre);
			command.ExecuteNonQuery();
			_connection.Close();
		}
	}
	
}
