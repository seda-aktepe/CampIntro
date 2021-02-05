using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class Urun
    {
        //property - özellik ; ürünün id, adi, fiyati gibi özellikleri
        // public int MyProperty { get; set; } //prop ile kısayoldan yap
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }
    }
}
