﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mobil mobil1 = new Mobil();
            mobil1.warna = "Hijau";
            mobil1.JumlahPintu = 4;
            mobil1.merk = "Merkedel";
            mobil1.model = "Mercedel Benz Aventini";
            mobil1.TahunKeluar = 2050;

            mobil1.Gas("200 km/h");
            mobil1.Klakson("Tititititit");
            mobil1.TampilkanInfo();

            Console.WriteLine("\n");
            Console.WriteLine("=======================================");

            Console.ReadLine();
        }
    }
}
