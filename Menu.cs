using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManajemenProduk
{
    class Menu
    {
        List<Produk> Produks = new List<Produk>();
        protected int umur;
        protected int select;
        protected string namaproduk;
        protected int hargaproduk;
        protected int indeks;
        protected int jumlah;

        public Menu()
        {
            Produks.Add(new Produk("NVIDIA GeForce 720M", 1200000));
            Produks.Add(new Produk("NVIDIA GeForce 920M", 5200000));
            Produks.Add(new Produk("NVIDIA GeForce 1020M", 7200000));
        }

        public void TampilMenu()
        {

            Console.WriteLine("~~ Program Manajemen Produk ~~");
            Console.WriteLine("Diskon 50% untuk Pembelian diatas 5 Juta Rupiah");
            Console.Write("Masukan Umur Anda: ");
            try
            {
                umur = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error! Masukan Anda Tidak Valid");
            }
            cekUmur(umur);

            Console.WriteLine("---MENU---");
            Console.WriteLine("Pilih Operasi yang akan dijalankan: \n" +
                "1. Menampilkan Produk \n" +
                "2. Menambahkan Produk \n" +
                "3. Menghapus Produk \n" +
                "4. Menampilkan Total Produk yang Ada \n" +
                "5. Pembelian Produk");

            Console.WriteLine("Masukan Pilihan: ");
            try
            {
                select = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                if (e is FormatException)
                {
                    Console.WriteLine("ERROR!!!");
                    Console.WriteLine("Masukan Harus Berupa INT ! \n");
                }
            }
            if (select > 5)
            {
                throw new FormatException("Masukan Tidak Sesuai dengan Menu");
            }
            //Console.ReadKey();
            Console.Clear();

            switch(select)
            {
                case 1://MENAMPILKAN PRODUK
                    TampilProduk();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2://MENAMBAH PRODUK
                    TampilProduk();
                    Console.WriteLine("Masukan Nama Produk Baru: ");
                    namaproduk = Console.ReadLine();
                    Console.WriteLine("Masukan Harga Produk Baru: ");
                    hargaproduk = Convert.ToInt32(Console.ReadLine());
                    TambahProduk(namaproduk,hargaproduk);
                    TampilProduk();
                    break;
                case 3://MENGHAPUS PRODUK
                    TampilProduk();
                    Console.WriteLine("Masukan Indeks Produk Yang akan Dihapus: ");
                    indeks = Convert.ToInt32(Console.ReadLine());
                    HapusProduk(indeks);
                    Console.Clear();
                    TampilProduk();
                    break;
                case 4://Menghitung Jumlah Produk
                    Console.WriteLine($"Jumlah Produk Saat Ini: {Produks.Count()}\n");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 5://PEMBELIAN PRODUK
                    Console.WriteLine("Masukan Index Produk yang Ingin Dibeli:");
                    indeks = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Masukan Jumlah Produk yang Ingin Dibeli:");
                    jumlah = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Total belanjaan Anda Adalah: {PembelianProduk(indeks, jumlah)}");
                    Console.ReadKey();
                    Console.Clear();
                    break;

            }

        }

        protected void cekUmur(int umur)
        {
            if (umur < 20)
            {
                throw new Exception("Kamu Belum Cukup Umur! - Process Terminated! \n");
            }
            else
                Console.WriteLine("Anda Sudah Cukup Umur");
        }

        protected void TampilProduk()
        {
            Console.WriteLine("~~~LIST PRODUK~~~");
            foreach (Produk p in Produks)
            {
                Console.WriteLine($"- Nama Produk: {p.NamaProduk} Harga: {p.HargaProduk}");
            }
        }

        protected void TambahProduk(string namaproduk, int hargaproduk)
        {
            Produks.Add(new Produk(namaproduk,hargaproduk));
        }
        
        protected void HapusProduk(int index)
        {
            Produks.RemoveAt(index);
        }

        protected double PembelianProduk(int index, int jumlah)
        {
            double harga=0.0;
            double total;

            for (int i = 0; i < Produks.Count(); i++)
            {
                foreach (Produk produk in Produks)
                {
                    if (indeks == i)
                    {
                        harga = produk.HargaProduk;
                    }
                }
            }
            double hargaSD = jumlah * harga;

            if (hargaSD >= 5000000)
            {
                total = hargaSD * 0.5;
            }
            else
                total = hargaSD;

            return total;
        }

    }
}
