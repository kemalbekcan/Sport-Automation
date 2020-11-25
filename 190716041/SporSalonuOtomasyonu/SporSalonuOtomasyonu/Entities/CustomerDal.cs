using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuOtomasyonu.Entities
{
	public class CustomerDal
	{
		SqlConnection _connection = new SqlConnection(@"server=Lenovo\SQLEXPRESS; initial catalog = _190716041; integrated security = true;");
		//SqlCommand command = new SqlCommand("SELECT * FROM Personal_İnformation", _connection);
		public DataTable GetList()
		{
			_connection.Open();
			SqlCommand command = new SqlCommand("SELECT personalInformation.PersonalId,personalInformation.Ad,personalInformation.Soyad,personalInformation.Tel,personalInformation.Cinsiyet,personalInformation.kayitTarihi,personalInformation.bitisTarihi,personalInformation.Adres,bedenBilgileri.Kilo,bedenBilgileri.Boy,bedenBilgileri.Kol,bedenBilgileri.Bel,bedenBilgileri.Gogus,bedenBilgileri.Kalca,bedenBilgileri.Omuz FROM personalInformation INNER JOIN bedenBilgileri ON personalInformation.PersonalId = bedenBilgileri.PersonalId", _connection);
			SqlDataReader reader = command.ExecuteReader();
			DataTable dataTable = new DataTable();
			dataTable.Load(reader);
			reader.Close();
			_connection.Close();
			return dataTable;
		}

		public void CustomerAdd(Customer customer)
		{
			_connection.Open();
			SqlCommand command = new SqlCommand("INSERT INTO personalInformation (PersonalId,Ad,Soyad,Tel,Cinsiyet,kayitTarihi,bitisTarihi,Adres) values(@PersonalId,@Ad,@Soyad,@Tel,@Cinsiyet,@Kayit_Tarihi,@Bitis_Tarihi,@Adres)", _connection);
			command.Parameters.AddWithValue("@PersonalId", customer.Id);
			command.Parameters.AddWithValue("@Ad", customer.Ad);
			command.Parameters.AddWithValue("@Soyad", customer.Soyad);
			command.Parameters.AddWithValue("@Tel", customer.Tel);
			command.Parameters.AddWithValue("@Cinsiyet", customer.Cinsiyet);
			command.Parameters.AddWithValue("@Kayit_Tarihi", customer.KayitTarihi);
			command.Parameters.AddWithValue("@Bitis_Tarihi", customer.BitisTarihi);
			command.Parameters.AddWithValue("@Adres", customer.Adres);
			command.ExecuteNonQuery();
			_connection.Close();
		}
		public void CustomerProperties(CustomerProperties customerProperties)
		{
			_connection.Open();
			SqlCommand command = new SqlCommand("INSERT INTO bedenBilgileri(PersonalId,Kilo,Boy,Kol,Bel,Gogus,Kalca,Omuz) values(@PersonalId,@Kilo,@Boy,@Kol,@Bel,@Gogus,@Kalca,@Omuz)",_connection);
			command.Parameters.AddWithValue("@PersonalId", customerProperties.PersonalId);
			command.Parameters.AddWithValue("@Kilo", customerProperties.Kilo);
			command.Parameters.AddWithValue("@Boy", customerProperties.Boy);
			command.Parameters.AddWithValue("@Kol", customerProperties.Kol);
			command.Parameters.AddWithValue("@Bel", customerProperties.Bel);
			command.Parameters.AddWithValue("@Gogus", customerProperties.Gogus);
			command.Parameters.AddWithValue("@Kalca", customerProperties.Kalca);
			command.Parameters.AddWithValue("@Omuz", customerProperties.Omuz);
			command.ExecuteNonQuery();
			_connection.Close();
		}
		public void CustomerPayments(Payments payments)
		{
			_connection.Open();
			SqlCommand command = new SqlCommand("INSERT INTO Odemeler (PersonalId,Ogrenci,Odeme,Tutar) VALUES(@PersonalId,@Ogrenci,@Odeme,@tutar)",_connection);
			command.Parameters.AddWithValue("@PersonalId", payments.PersonalId);
			command.Parameters.AddWithValue("@Ogrenci", payments.Ogrenci);
			command.Parameters.AddWithValue("@Odeme", payments.Odeme);
			command.Parameters.AddWithValue("@tutar", payments.tutar);
			command.ExecuteNonQuery();
			_connection.Close();
		}

		public void CustomerDelete(Customer customer)
		{
			_connection.Open();
			SqlCommand command = new SqlCommand("DELETE FROM personalInformation where PersonalId=@PersonalId", _connection);
			command.Parameters.AddWithValue("@PersonalId", customer.Id);
			command.ExecuteNonQuery();
			_connection.Close();
		}

		public void CustomerUpdate(CustomerProperties customerProperties)
		{
			_connection.Open();
			SqlCommand command = new SqlCommand("UPDATE bedenBilgileri SET Kilo=@Kilo,Boy=@Boy,Kol=@Kol,Bel=@Bel,Gogus=@Gogus,Kalca=@Kalca,Omuz=@Omuz WHERE PersonalId=@PersonalId",_connection);
			command.Parameters.AddWithValue("@Kilo",customerProperties.Kilo);
			command.Parameters.AddWithValue("@Boy", customerProperties.Boy);
			command.Parameters.AddWithValue("@Kol", customerProperties.Kol);
			command.Parameters.AddWithValue("@Bel", customerProperties.Bel);
			command.Parameters.AddWithValue("@Gogus", customerProperties.Gogus);
			command.Parameters.AddWithValue("@Kalca", customerProperties.Kalca);
			command.Parameters.AddWithValue("@Omuz", customerProperties.Omuz);
			command.Parameters.AddWithValue("@PersonalId", customerProperties.PersonalId);
			command.ExecuteNonQuery();
			_connection.Close();
		}
	}
}
