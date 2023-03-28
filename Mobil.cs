using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum02
{
    internal class Mobil
    {
        public string warna;
        public int JumlahPintu;
        public string merk;
        public string model;
        public int TahunKeluar;

        public void Gas(string Kecepatan)
        {
            Console.WriteLine("Mobil {0} berjalan dengan kecepatan {1}", model, Kecepatan);
        }
        public void Klakson(string suara)
        {
            Console.WriteLine("Dengan Suara Klakson {0}", suara);
        }
        public void TampilkanInfo()
        {
            Console.WriteLine("Mobil saya berwarna {0}, merek {1}, model {2}, keluaran tahun {3}, dengan jumlah pintu sebanyak {4}", warna, merk, model, TahunKeluar, JumlahPintu);
        }
    }
}
