using System;

public class Karyawan
{
    public Karyawan (string nik, string nama, int Gaji)
    {
        Nik = nik;
        Nama = nama;
        GajiBulanan = Gaji;

        if (GajiBulanan<0)
        {
            Console.WriteLine("Maaf, isilah dengan benar");
        } else {
            GajiBulanan = Gaji;
        }
    }
    public string Nik { get; set; }
    public string Nama { get; set; }
    public int GajiBulanan { get; set; }
}