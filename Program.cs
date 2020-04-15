using System;

namespace ResponsiPemrograman2884
{
    class Program
    {
        static void Main(string[] args)
        {
            var karyawan1 = new Karyawan("190302123", "Paijo", 300000);
            var karyawan2 = new Karyawan("190302124", "Jono", 200000);

            Console.WriteLine("No Nik/Nama\t\tGaji Bulanan");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1. "+karyawan1.Nik+" "+karyawan1.Nama+"\t"+karyawan1.GajiBulanan);
            Console.WriteLine("2. "+karyawan2.Nik+" "+karyawan2.Nama+"\t"+karyawan2.GajiBulanan);
            
            int gb1;
            int gb2;

            gb1 = (karyawan1.GajiBulanan)+(10 * karyawan1.GajiBulanan / 100);
            gb2 = (karyawan2.GajiBulanan)+(10 * karyawan2.GajiBulanan / 100);
            Console.WriteLine("\n\nAsyiiiiik kenaikan gaji 10%!!");
            Console.WriteLine("\nNo Nik/Nama\t\tGaji Bulanan");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1. "+karyawan1.Nik+" "+karyawan1.Nama+"\t"+gb1);
            Console.WriteLine("2. "+karyawan2.Nik+" "+karyawan2.Nama+"\t"+gb2);

        }
    }
}
