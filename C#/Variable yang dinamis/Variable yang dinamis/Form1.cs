using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Variable_yang_dinamis
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		object[] pecahkan(List<string> daftar)
		{
			bool ada = false;
			if (daftar.Count > 0)
			{
				ada = true;
			}

			dynamic[] hasil = { ada, daftar };//dengan dynamic ataupun object, maka kita bisa menaruh 2 atau lebih tipe data yang berbeda pada sebuah array ataupun tipe data collection lainnya

			return hasil;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			List<string> coba = new List<string>();
			object[] h = pecahkan(coba);
			bool a = (bool)h[0];
			List<string> daf = (List<string>)h[1];
			Console.WriteLine("sebelum di isi = " + a.ToString());

			coba.Add("tambah saja :3");
			h = pecahkan(coba);
			a = (bool)h[0];
			daf = (List<string>)h[1];
			Console.WriteLine("sesudah di tambahkan isinya = " + a.ToString());
		}
	}
}
