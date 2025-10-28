using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Microsoft.Ajax.Utilities;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ihamarmaratask
{
	public partial class Form1 : Form
	{
		private GMapOverlay markersOverlay;

		public Form1()
		{
			InitializeComponent();
		}
		//double batteryVoltage = 10.223;
		//decimal enlem = 40.879326m;
		//decimal boylam = 29.258135m;
		//int RollAci = 11;
		//int YawAci = 45;
		//int irtifa = 1500;
		//int PitchAci = 10;
		int RollAci = 0;
		int YawAci = 20;
		decimal enlem;
		decimal boylam;
		int irtifa;
		int PitchAci = 0;//burada değişken isimlerinin karıştırarak yazmışım tüm kodda sonra buna uyarak devam ettim.
		int hiz;
		double batteryVoltage;
		//fotoğraftan dolayı her değere 10 eklenmesi lazımdır hocam
		private void Form1_Load(object sender, EventArgs e)
		{
			
			demoform demo = new demoform();
			demo.ShowDialog();
			RollAci += Convert.ToInt32(demo.rollaci);
			YawAci += Convert.ToInt32(demo.yawaci);
			enlem = Convert.ToDecimal(demo.enlem);
			boylam = Convert.ToDecimal(demo.boylam);

			irtifa = Convert.ToInt32(demo.irtifa);
			PitchAci += Convert.ToInt32(demo.pichaci);
			hiz = Convert.ToInt32(demo.hiz);
			batteryVoltage = Convert.ToDouble(demo.pilvoltaj);
			yaw_label.Text = PitchAci.ToString() + "°";
			roll_label.Text = RollAci.ToString() + "°";
			pitch_label.Text = (YawAci-20).ToString() + "°";//resmin şeklinden dolayı 20 çıkarıyorum
			hız_label.Text = hiz.ToString();
			irtifa_gosterge.Text = irtifa.ToString() + " m";
			voltaj.Text = batteryVoltage.ToString();
			if (batteryVoltage >= 10 || batteryVoltage <= 12)
			{
				batteryyyyy_img.Visible = true;
				batteryyy_img.Visible = false;
				batteryy_img.Visible = false;
				battery_img.Visible = false;
			}
			else if (batteryVoltage >= 8.0 && batteryVoltage < 12.0)
			{
				batteryyyyy_img.Visible = false;
				batteryyy_img.Visible = true;
				batteryy_img.Visible = false;
				battery_img.Visible = false;

			}
			else if (batteryVoltage > 4.0 && batteryVoltage < 8.0)
			{
				batteryyyyy_img.Visible = false;
				batteryyy_img.Visible = false;
				batteryy_img.Visible = true;
				battery_img.Visible = false;
			}
			else
			{
				batteryyyyy_img.Visible = false;
				batteryyy_img.Visible = false;
				batteryy_img.Visible = false;
				battery_img.Visible = true;
			}
			yaw.Paint += pitch_Paint;
			roll.Paint += roll_Paint;
			pitch.Paint += yaw_Paint;
			volt.Start();//bu ilerde işe yarayacak anlık olarak veriyi güncellemek için
			zaman.Start();

			InitializeMap();
			try
			{
				double lat = Convert.ToDouble(enlem);
				double lon = Convert.ToDouble(boylam);
				UpdateMapLocation(lat, lon);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Konum verisi okunamadı: " + ex.Message);
			}
			YawAci = (YawAci / 2);
			PitchAci = (PitchAci / 2);
		}

		private void InitializeMap()
		{
			gMapControl1.MapProvider = GMapProviders.OpenStreetMap;
			gMapControl1.Position = new PointLatLng((double)enlem, (double)boylam);
			gMapControl1.MinZoom = 2;
			gMapControl1.MaxZoom = 18;
			gMapControl1.Zoom = 20;
			gMapControl1.DragButton = MouseButtons.Left;
			gMapControl1.ShowCenter = false;
			markersOverlay = new GMapOverlay("markers");
			gMapControl1.Overlays.Add(markersOverlay);
		}

		private void UpdateMapLocation(double lat, double lon)
		{
			PointLatLng point = new PointLatLng(lat, lon);
			gMapControl1.Position = point;
			markersOverlay.Markers.Clear();
			GMarkerGoogle marker = new GMarkerGoogle(point, GMarkerGoogleType.red_pushpin)
			{
				ToolTipText = $"UAV Konumu\nEnlem: {lat:F6}°\nBoylam: {lon:F6}°",
				ToolTipMode = MarkerTooltipMode.Always
			};
			markersOverlay.Markers.Add(marker);
		}

		private void zaman_Tick(object sender, EventArgs e)
		{
			time.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
		}

		private void batteryvoid_img_Paint(object sender, PaintEventArgs e)
		{
			PictureBox pb = sender as PictureBox;
			if (pb.Image == null) return;
			int x = (pb.Width - pb.Image.Width) / 2;
			int y = (pb.Height - pb.Image.Height) / 2;
			e.Graphics.DrawImage(pb.Image, x, y, pb.Image.Width, pb.Image.Height);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("aklımda referans voltaj değerleri olmadığından 0-12 arası bir sayı seçtirip o sayıya göre resmin değişmesini sağladım", "Voltaj Hakkında", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void volt_Tick(object sender, EventArgs e)
		{
			voltaj.Text = batteryVoltage.ToString();
			switch (batteryVoltage)
			{
				case double n when (n >= 12.0):
					batteryyyyy_img.Visible = true;
					batteryyy_img.Visible = false;
					batteryy_img.Visible = false;
					battery_img.Visible = false;
					break;
				case double n when (n >= 8.0 && n < 12.0):
					batteryyyyy_img.Visible = false;
					batteryyy_img.Visible = true;
					batteryy_img.Visible = false;
					battery_img.Visible = false;
					break;
				case double n when (n > 4.0 && n < 8.0):
					batteryyyyy_img.Visible = false;
					batteryyy_img.Visible = false;
					batteryy_img.Visible = true;
					battery_img.Visible = false;
					break;
				default:
					batteryyyyy_img.Visible = false;
					batteryyy_img.Visible = false;
					batteryy_img.Visible = false;
					battery_img.Visible = true;
					break;
			}
		}


		private void roll_Paint(object sender, PaintEventArgs e)
		{
			PictureBox pb = sender as PictureBox;
			if (pb.Image == null) return;

			Graphics g = e.Graphics;
			g.Clear(pb.BackColor);
			g.SmoothingMode = SmoothingMode.HighQuality;
			g.InterpolationMode = InterpolationMode.HighQualityBicubic;

			float centerX = pb.Width / 2f;
			float centerY = pb.Height / 2f;

			g.TranslateTransform(centerX, centerY);
			g.RotateTransform(RollAci); // RollAci değişkenini kullanıyor
			g.TranslateTransform(-centerX, -centerY);

			float x = (pb.Width - pb.Image.Width) / 2f;
			float y = (pb.Height - pb.Image.Height) / 2f;
			g.DrawImage(pb.Image, x, y, pb.Image.Width, pb.Image.Height);
		}

		private void pitch_Paint(object sender, PaintEventArgs e)
		{
			PictureBox pb = sender as PictureBox;
			if (pb.Image == null) return;

			Graphics g = e.Graphics;
			g.Clear(pb.BackColor);
			g.SmoothingMode = SmoothingMode.HighQuality;
			g.InterpolationMode = InterpolationMode.HighQualityBicubic;

			float centerX = pb.Width / 2f;
			float centerY = pb.Height / 2f;

			g.TranslateTransform(centerX, centerY);
			g.RotateTransform(PitchAci); //burada değişken isimlerinin karıştırarak yazmışım tüm kodda sonra buna uyarak devam ettim.
			g.TranslateTransform(-centerX, -centerY);

			float x = (pb.Width - pb.Image.Width) / 2f;
			float y = (pb.Height - pb.Image.Height) / 2f;
			g.DrawImage(pb.Image, x, y, pb.Image.Width, pb.Image.Height);
		}

		private void yaw_Paint(object sender, PaintEventArgs e)
		{
			PictureBox pb = sender as PictureBox;
			if (pb.Image == null) return;

			Graphics g = e.Graphics;
			g.Clear(pb.BackColor);
			g.SmoothingMode = SmoothingMode.HighQuality;
			g.InterpolationMode = InterpolationMode.HighQualityBicubic;

			float centerX = pb.Width / 2f;
			float centerY = pb.Height / 2f;

			g.TranslateTransform(centerX, centerY);
			g.RotateTransform(YawAci);
			g.TranslateTransform(-centerX, -centerY);

			float x = (pb.Width - pb.Image.Width) / 2f;
			float y = (pb.Height - pb.Image.Height) / 2f;
			g.DrawImage(pb.Image, x, y, pb.Image.Width, pb.Image.Height);
		}

		private void maps_info_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Normalde burada ihadan gelen anlık veri timer ile düzenli olarak yazdıracak", "Harita Hakkında", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}

		private void voltaj_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Uçağın burnu 0 dereceye bakıyor ve + ve - trigonometrideki kurallarla aynı", "Açılar Hakkında", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}

		private void button3_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Normalde bu değerler timer ile düzenli olarak güncellenecek", "Hız Hakkında", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}
	}
}