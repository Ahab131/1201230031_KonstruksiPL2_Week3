// KodeBuah.cs
using System;
using System.Collections.Generic;

public class KodeBuah
{
    private static readonly Dictionary<string, string> kodeBuahMap = new Dictionary<string, string>
    {
        {"Apel", "A00"},
        {"Aprikot", "B00"},
        {"Alpukat", "C00"},
        {"Pisang", "D00"},
        {"Paprika", "E00"},
        {"Blackberry", "F00"},
        {"Ceri", "H00"},
        {"Kelapa", "I00"},
        {"Jagung", "J00"},
        {"Kurma", "K00"},
        {"Durian", "L00"},
        {"Anggur", "M00"},
        {"Melon", "N00"},
        {"Semangka", "O00"}
    };

    // Method untuk mendapatkan kode buah
    public static string GetKodeBuah(string namaBuah)
    {
        return kodeBuahMap.TryGetValue(namaBuah, out string kode) ? kode : "Kode tidak ditemukan";
    }

    // Main method untuk pengujian
    public static void Main(string[] args)
    {
        Console.WriteLine("Kode Buah Apel: " + GetKodeBuah("Apel"));
        Console.WriteLine("Kode Buah Durian: " + GetKodeBuah("Durian"));
        Console.WriteLine("Kode Buah Mangga: " + GetKodeBuah("Mangga")); // Buah yang tidak ada di tabel
    }
}
