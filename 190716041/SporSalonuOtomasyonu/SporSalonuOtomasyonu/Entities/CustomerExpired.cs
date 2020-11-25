using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporSalonuOtomasyonu.Entities
{
	public class CustomerExpired
	{
		public int Id { get; set; }
		public string Ad { get; set; }
		public string Soyad { get; set; }
		public long Tel { get; set; }
		public string Cinsiyet { get; set; }
		public DateTime BitisTarihi { get; set; }
		public string Adres { get; set; }
	}
}
