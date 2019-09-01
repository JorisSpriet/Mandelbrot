using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encoder = System.Drawing.Imaging.Encoder;

namespace MandelBrotParallel
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var power = double.Parse(fromPower.Text);


			Launch(power);
		}

		private void Launch(double p, int? n = null)
		{


			var w = Convert.ToDouble(panel1.Width);
			var h = Convert.ToDouble(panel1.Height);
			var rh = 3.0 / h;

			Graphics g = null;
			Bitmap bm = null;
			var save = n.HasValue;
			if (!save)
				g = panel1.CreateGraphics();
			else
			{
				bm = new Bitmap(1080, 1080, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

				w = h = 1080d;
				rh = 3.0 / 1080d;
				g = Graphics.FromImage(bm);
			}
			g.Clear(Color.White);

			var hdc = g.GetHdc();

			for (int x = 0; x < w; x++)
			{
				for (int y = 0; y < h; y++)
				{

					var a = 1.0 - (w - (double)x) * rh;

					var b = 1.5 - ((double)y) * rh;

					var z = new complex(a, b);

					var r = Iterate(z, p);
					if (r)
						GDI.SetPixel(hdc, x, y, 0x00000000);
				}
			}
			g.ReleaseHdc(hdc);


			g.DrawString(p.ToString("0.000"), SystemFonts.DefaultFont, Brushes.Black, 50, 50);

			if (save)
			{
				bm.Save($@"d:\brol\mb\mb{n.Value.ToString("d4")}.png", ImageFormat.Png);

				Invoke(new MethodInvoker(delegate
				{

					var g2 = panel1.CreateGraphics();
					g2.DrawImage(bm, new Point(0, 0));
					g2.Dispose();
					bm.Dispose();
				}));


			}
			g.Dispose();

		}


		private bool Iterate(complex c, double p)
		{
			var z = new complex(.0d, .0d);

			for (int i = 0; i < 50; i++)
			{
				var r = (polar)z;
				r = r.Pow(p);
				z = (complex)r + c;
				if (z.Abs2() > 4.0d) return false;
			}

			return z.Abs2() < 4.0d;

		}

		public class GDI
		{
			[System.Runtime.InteropServices.DllImport("gdi32.dll")]
			internal static extern bool SetPixel(IntPtr hdc, int X, int Y, uint crColor);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			panel1.Invalidate();
		}

		private async void button3_Click(object sender, EventArgs e)
		{
			var start = double.Parse(fromPower.Text);
			var end = double.Parse(toPower.Text);
			var n = (double)int.Parse(steps.Text);
			var inc = (end - start) / n;
			var p = start;
			var t = 0;

			button3.Enabled = false;

			await Task.Run(() =>
			{
				do
				{
					Launch(p, t++);
					p += inc;
				} while (p <= end+.001d);
			});

			button3.Enabled = true;
		}		
	}

	public class complex
	{
		public double x;
		public double y;

		public complex(double a, double b)
		{
			x = a;
			y = b;
		}

		public static complex operator *(complex z1, complex z2)
		{
			var a = z1.x * z2.x - z1.y * z2.y;
			var b = z1.x * z2.y + z1.y * z2.x;
			return new complex(a, b);
		}

		public static complex operator +(complex z1, complex z2)
		{
			return new complex(z1.x + z2.x, z1.y + z2.y);
		}

		public double Abs2()
		{
			return x * x + y * y;
		}
	}

	public class polar
	{
		public double r;
		public double th;

		public polar(double a, double b)
		{
			r = a;
			th = b;
		}

		public static explicit operator polar(complex z)
		{
			var r = Math.Sqrt(z.Abs2());
			double th;
			if (z.y == 0d) th = Math.PI / 2.0d;
			else th = Math.Atan2(z.y, z.x);
			return new polar(r, th);
		}

		public static explicit operator complex(polar z)
		{
			var a = z.r * Math.Cos(z.th);
			var b = z.r * Math.Sin(z.th);
			return new complex(a, b);

		}



		public polar Pow(double z)
		{
			return new polar(Math.Pow(r, z), z * th);
		}
	}
}
