using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Product
    {
        //class bir bilgiyi değil de o nesneyi tanımlayan birden fazla bilgiyi içinde barındıran yapıdır
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyat { get; set; }
        public string Aciklama { get; set; }
        public int StokAdet { get; set; }

    }
}
