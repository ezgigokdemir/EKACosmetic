using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKAKozmetik.Model
{
    public class Uye
    {
        public int ID { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Sifre { get; set; }
        public string Adres { get; set; }
        public string KartNo { get; set; }
    }
}
