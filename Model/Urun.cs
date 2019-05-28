using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKAKozmetik.Model
{
   public class Urun
    {
        public int ID { get; set; }
        public string Isim { get; set; }
        public double Fiyat { get; set; }
        public int Adet { get; set; }
        public int AlinanAdet { get; set; }
        public string UrunFoto { get; set; }
        public int KategoriID { get; set; }
        public int MarkaID { get; set; }
        public string BarkodNo { get; set; }
    }
}
