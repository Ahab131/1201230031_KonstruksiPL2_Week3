using System;

// Enum untuk mendefinisikan state karakter
enum Posisi
{
	Berdiri,
	Jongkok,
	Tengkurap,
	Terbang
}

class PosisiKarakterGame
{
	private Posisi posisiSaatIni;
	private int nim;

	public PosisiKarakterGame(int nim)
	{
		this.posisiSaatIni = Posisi.Berdiri; // State awal
		this.nim = nim;
	}

	public void TekanTombolS()
	{
		Console.WriteLine("TombolS ditekan");

		if (nim % 3 == 0)
		{
			Console.WriteLine("tombol arah bawah ditekan");
		}

		switch (posisiSaatIni)
		{
			case Posisi.Berdiri:
				UbahPosisi(Posisi.Jongkok);
				break;
			case Posisi.Jongkok:
				UbahPosisi(Posisi.Tengkurap);
				break;
			case Posisi.Terbang:
				UbahPosisi(Posisi.Jongkok);
				break;
		}
	}

	public void TekanTombolW()
	{
		Console.WriteLine("TombolW ditekan");

		if (nim % 3 == 0)
		{
			Console.WriteLine("tombola rah atas ditekan");
		}

		switch (posisiSaatIni)
		{
			case Posisi.Jongkok:
				UbahPosisi(Posisi.Berdiri);
				break;
			case Posisi.Tengkurap:
				UbahPosisi(Posisi.Jongkok);
				break;
			case Posisi.Berdiri:
				UbahPosisi(Posisi.Terbang);
				break;
		}
	}

	public void TekanTombolX()
	{
		Console.WriteLine("TombolX ditekan");
		if (posisiSaatIni == Posisi.Jongkok)
		{
			UbahPosisi(Posisi.Terbang);
		}
	}

	private void UbahPosisi(Posisi posisiBaru)
	{
		if (posisiSaatIni == Posisi.Terbang && posisiBaru == Posisi.Jongkok && nim % 3 == 2)
		{
			Console.WriteLine("posisi landing");
		}

		if (posisiSaatIni == Posisi.Berdiri && posisiBaru == Posisi.Terbang && nim % 3 == 2)
		{
			Console.WriteLine("posisi take off");
		}

		posisiSaatIni = posisiBaru;
		Console.WriteLine($"Posisi berubah menjadi {posisiSaatIni}");

		if (posisiSaatIni == Posisi.Berdiri && nim % 3 == 1)
		{
			Console.WriteLine("posisi standby");
		}

		if (posisiSaatIni == Posisi.Tengkurap && nim % 3 == 1)
		{
			Console.WriteLine("posisi istirahat");
		}
	}

	public void SimulasiPerubahan()
	{
		TekanTombolS(); // Berdiri -> Jongkok
		TekanTombolS(); // Jongkok -> Tengkurap
		TekanTombolW(); // Tengkurap -> Jongkok
		TekanTombolW(); // Jongkok -> Berdiri
		TekanTombolW(); // Berdiri -> Terbang
		TekanTombolS(); // Terbang -> Jongkok
		TekanTombolX(); // Jongkok -> Terbang
	}
}

class Program
{
	static void Main(string[] args)
	{
		int nim = 123456; // Ganti dengan NIM Anda

		PosisiKarakterGame karakter = new PosisiKarakterGame(nim);
		karakter.SimulasiPerubahan();
	}
}