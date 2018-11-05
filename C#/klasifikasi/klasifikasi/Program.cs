using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace klasifikasi
{

	class Jurusan
	{
		Siswa[] daftarSiswa = new Siswa[0];
		public string nama;

		public Jurusan(string namanya)//merupakan inisial dari classnya
		{
			nama = namanya;
		}

		public void tambah(Siswa siswa)
		{
			//daftarSiswa.Add(siswa);
			Siswa[] temp = new Siswa[daftarSiswa.Length + 1];
			for (int i = 0; i < daftarSiswa.Length; i++)
			{
				temp[i] = daftarSiswa[i];
			}
			temp[daftarSiswa.Length] = siswa;
			daftarSiswa = temp;

		}

		public void hapus(Siswa siswa)
		{
			if (daftarSiswa.Contains(siswa))
			{
				Siswa[] temp = new Siswa[daftarSiswa.Length - 1];
				int n = 0;
				for (int i = 0; i < daftarSiswa.Length; i++)
				{
					if (daftarSiswa[i] != siswa)
					{
						temp[n] = daftarSiswa[i];
						n++;
					}
				}
				daftarSiswa = temp;
			}
			else
			{
				Console.WriteLine("The item that you request is not exist");
			}

		}

		public void hapusDi(int indeks)
		{
			if (indeks > -1 && indeks < daftarSiswa.Length - 1)
			{
				Siswa[] temp = new Siswa[daftarSiswa.Length - 1];
				int n = 0;
				for (int i = 0; i < daftarSiswa.Length; i++)
				{
					temp[n] = daftarSiswa[i];
					n++;
				}

				daftarSiswa = temp;
			}
			else
			{
				Console.WriteLine("Error, the indeks is not valid");
			}
		}

		public Siswa getSiswa(int index)
		{
			return daftarSiswa[index];
		}
	}

	class Siswa
	{
		public string nama;
		public Jurusan jurusan;
		public int kelas = 1;
	}

	class Program
	{
		static void Main(string[] args)
		{
			// The code provided will print ‘Hello World’ to the console.
			// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

			Jurusan elektronika = new Jurusan("Elektronika");

			Siswa ryan = new Siswa();
			ryan.nama = "Ryan";
			ryan.kelas = 2;
			ryan.jurusan = elektronika;
			elektronika.tambah(ryan);

			Siswa robert = new Siswa();
			robert.nama = "Robert";
			robert.kelas = 3;
			robert.jurusan = elektronika;
			elektronika.tambah(robert);


			Console.WriteLine(elektronika.getSiswa(1).kelas);
			Console.ReadKey();

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
