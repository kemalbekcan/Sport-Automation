using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporSalonuOtomasyonu.Entities
{
	public class Payments
	{
		public int PersonalId { get; set; }

		public string Ogrenci { get; set; }

		public string Odeme { get; set; }

		public int tutar { get; set; }
	}
}
