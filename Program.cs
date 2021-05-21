using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManajemenProduk
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu M1 = new Menu();
            while (true)
            {
                M1.TampilMenu();
            }

        }
        /*Prosedural
        private static void Menu()
        {
            //Deklarasi Variabel
            int total = 0;
            int select = 0;
            List<String> cari = new List<string>();
            List<String> listProduk = new List<string>();
            List<int> listHarga = new List<int>();

            //Isi Data ke List
            isiProduk(listProduk);
            isiHarga(listHarga);
            int umur = 0;

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
                if (e is FormatException )
                {
                    Console.WriteLine("ERROR!!!");
                    Console.WriteLine("Masukan Harus Berupa INT ! \n");
                }
            }
            if (select > 5)
            {
               throw new FormatException("Masukan Tidak Sesuai dengan Menu");
            }

            switch (select)
            {
                case 1: //Menampilkan Produk
                    tampilkanProduk(listProduk, listHarga);
                    break;

                case 2: //Menambah Produk Ke dalam List Produk
                    Console.WriteLine("Masukan Nama Produk Baru: ");
                    String tambah = Console.ReadLine();
                    Console.WriteLine("Masukan Harga Produk Baru: ");
                    int tHarga = 0;
                    try
                    {
                        tHarga = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException e)
                    {

                        Console.WriteLine("ERROR!!!");
                        Console.WriteLine("Inputan Harus Berupa INT!");
                    }
                    tambahkanProduk(listProduk,listHarga, tambah, tHarga);
                    tampilkanProduk(listProduk, listHarga);
                    break;

                case 3://Menghapus Produk di dalam List Produk
                    int index = 0;
                    Console.WriteLine("Masukan Index Produk yang Ingin dihapus: ");
                    index = Convert.ToInt32(Console.ReadLine());
                    hapusProduk(listProduk, listHarga, index);
                    tampilkanProduk(listProduk, listHarga);
                    break;

                case 4://Menampilkan Total Jumlah Produk
                    Console.WriteLine("Jumlah Produk yang Ada : " + (total = totalJumlahProduk(listProduk)));
                    break;

                case 5://Pembelian Produk
                    int jumlah = 0;
                    int pilihan = 0;
                    tampilkanProduk(listProduk, listHarga);
                    Console.WriteLine("Masukan Index Barang yang akan dibeli: ");
                    try
                    {
                        pilihan = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (IndexOutOfRangeException e)
                    {

                        Console.WriteLine("ERROR!!!");
                        Console.WriteLine("Index Tidak Ada di Dalam List");
                    }

                    Console.WriteLine("Masukan Jumlah Barang: ");
                    try
                    {
                        jumlah = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("ERROR!!!");
                        Console.WriteLine("Inputan Harus Berupa INT!");
                    }
                    Console.WriteLine("Jumlah Pembelian adalah : "+ pembelianProduk(listHarga, pilihan, jumlah) + "\n");
                    break;
            }
        }

        private static void isiHarga(List<int> listHarga)
        {
            listHarga.Add(3200000);
            listHarga.Add(8200000);
            listHarga.Add(5200000);
            listHarga.Add(10200000);
        }

        private static void isiProduk(List<string> listProduk)
        {
            listProduk.Add("NVIDIA GeFORCE 960X");
            listProduk.Add("NVIDIA GeFORCE 1080X");
            listProduk.Add("NVIDIA GeFORCE 960M");
            listProduk.Add("NVIDIA GeFORCE 1080M");
        }

        private static void tampilkanProduk(List<String>NamaProduk, List<int>hargaProduk)
        {
            Console.WriteLine("\nDaftar Produk Yang Tersedia: ");
            for (int i= 0; i < NamaProduk.Count; i++)
            {
                Console.WriteLine(i +" "+ NamaProduk[i] + " RP." + hargaProduk[i]);
            }
            Console.WriteLine("\n");
        }

        private static void tambahkanProduk(List<String>NamaProduk, List<int>hargaProduk, String tambahString, int tambahHarga)
        {
            NamaProduk.Add(tambahString);
            hargaProduk.Add(tambahHarga);

        }
        
        private static void hapusProduk(List<String>NamaProduk, List<int>hargaProduk, int index)
        {
            try
            {
                NamaProduk.RemoveAt(index);
                hargaProduk.RemoveAt(index);
            }
            catch (Exception)
            {

                Console.WriteLine("ERROR!!!");
                Console.WriteLine("Index Diluar Range !!!");
            }

        }

        private static int totalJumlahProduk(List<String> daftarProduk)
        {
            int total = 0;
            for (int i = 0; i <= daftarProduk.Count; i++)
            {
                total = +i;
            }
            return total;
        }

        private static double pembelianProduk(List<int>daftarHarga, int pilihan, int nBarang)
        {
            double harga = 0;
            for (int i = 0; i < daftarHarga.Count; i++)
            {
                if (pilihan == i)
                {
                    harga = daftarHarga[i];
                }
            }
            double hargaSD = harga * nBarang;
            double total = 0.0d;

            if (hargaSD >= 5000000)
            {
                total = hargaSD * 0.5;
            }
            else
                total = hargaSD;

            return total;
                
        }

        private static void cekUmur(int umur)
        {
            if (umur < 20)
            {
                throw new Exception("Kamu Belum Cukup Umur! - Process Terminated! \n");
            }
            else
                Console.WriteLine("Anda Sudah Cukup Umur");
        }*/
    }
}
