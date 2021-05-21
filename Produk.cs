using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManajemenProduk
{
    class Produk
    {
        public String NamaProduk { get; set; }
        public int HargaProduk { get; set; }
        public Produk(string namaproduk, int hargaproduk)
        {
            NamaProduk = namaproduk;
            HargaProduk = hargaproduk;
        }
    }
}
