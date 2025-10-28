namespace ihamarmaratask
{
	partial class Form1
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.zaman = new System.Windows.Forms.Timer(this.components);
			this.time = new System.Windows.Forms.Label();
			this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
			this.label2 = new System.Windows.Forms.Label();
			this.battery_img = new System.Windows.Forms.PictureBox();
			this.batteryy_img = new System.Windows.Forms.PictureBox();
			this.batteryyy_img = new System.Windows.Forms.PictureBox();
			this.batteryyyyy_img = new System.Windows.Forms.PictureBox();
			this.battery = new System.Windows.Forms.Label();
			this.voltaj = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.volt = new System.Windows.Forms.Timer(this.components);
			this.yaw = new System.Windows.Forms.PictureBox();
			this.roll = new System.Windows.Forms.PictureBox();
			this.pitch = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.irtifa_gosterge = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.maps_info = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.yaw_label = new System.Windows.Forms.Label();
			this.roll_label = new System.Windows.Forms.Label();
			this.pitch_label = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.hız_label = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.battery_img)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.batteryy_img)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.batteryyy_img)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.batteryyyyy_img)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.yaw)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.roll)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pitch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// zaman
			// 
			this.zaman.Interval = 200;
			this.zaman.Tick += new System.EventHandler(this.zaman_Tick);
			// 
			// time
			// 
			resources.ApplyResources(this.time, "time");
			this.time.BackColor = System.Drawing.Color.Transparent;
			this.time.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.time.Name = "time";
			// 
			// gMapControl1
			// 
			this.gMapControl1.Bearing = 0F;
			this.gMapControl1.CanDragMap = true;
			this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
			this.gMapControl1.GrayScaleMode = false;
			this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
			this.gMapControl1.LevelsKeepInMemory = 5;
			resources.ApplyResources(this.gMapControl1, "gMapControl1");
			this.gMapControl1.MarkersEnabled = true;
			this.gMapControl1.MaxZoom = 2;
			this.gMapControl1.MinZoom = 2;
			this.gMapControl1.MouseWheelZoomEnabled = true;
			this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
			this.gMapControl1.Name = "gMapControl1";
			this.gMapControl1.NegativeMode = false;
			this.gMapControl1.PolygonsEnabled = true;
			this.gMapControl1.RetryLoadTile = 0;
			this.gMapControl1.RoutesEnabled = true;
			this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
			this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
			this.gMapControl1.ShowTileGridLines = false;
			this.gMapControl1.Zoom = 0D;
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Name = "label2";
			// 
			// battery_img
			// 
			this.battery_img.Image = global::ihamarmaratask.Properties.Resources.battery_1432;
			resources.ApplyResources(this.battery_img, "battery_img");
			this.battery_img.Name = "battery_img";
			this.battery_img.TabStop = false;
			// 
			// batteryy_img
			// 
			this.batteryy_img.Image = global::ihamarmaratask.Properties.Resources.battery_1431;
			resources.ApplyResources(this.batteryy_img, "batteryy_img");
			this.batteryy_img.Name = "batteryy_img";
			this.batteryy_img.TabStop = false;
			// 
			// batteryyy_img
			// 
			this.batteryyy_img.Image = global::ihamarmaratask.Properties.Resources.battery_1430;
			resources.ApplyResources(this.batteryyy_img, "batteryyy_img");
			this.batteryyy_img.Name = "batteryyy_img";
			this.batteryyy_img.TabStop = false;
			// 
			// batteryyyyy_img
			// 
			this.batteryyyyy_img.Image = global::ihamarmaratask.Properties.Resources.battery_1429;
			resources.ApplyResources(this.batteryyyyy_img, "batteryyyyy_img");
			this.batteryyyyy_img.Name = "batteryyyyy_img";
			this.batteryyyyy_img.TabStop = false;
			// 
			// battery
			// 
			resources.ApplyResources(this.battery, "battery");
			this.battery.BackColor = System.Drawing.Color.Transparent;
			this.battery.ForeColor = System.Drawing.Color.Black;
			this.battery.Name = "battery";
			// 
			// voltaj
			// 
			resources.ApplyResources(this.voltaj, "voltaj");
			this.voltaj.BackColor = System.Drawing.Color.Transparent;
			this.voltaj.ForeColor = System.Drawing.Color.Black;
			this.voltaj.Name = "voltaj";
			this.voltaj.Click += new System.EventHandler(this.voltaj_Click);
			// 
			// button1
			// 
			resources.ApplyResources(this.button1, "button1");
			this.button1.Name = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// volt
			// 
			this.volt.Tick += new System.EventHandler(this.volt_Tick);
			// 
			// yaw
			// 
			resources.ApplyResources(this.yaw, "yaw");
			this.yaw.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.yaw.Cursor = System.Windows.Forms.Cursors.Hand;
			this.yaw.Image = global::ihamarmaratask.Properties.Resources.plane_flying_icon_icons_com_55565;
			this.yaw.Name = "yaw";
			this.yaw.TabStop = false;
			this.yaw.Paint += new System.Windows.Forms.PaintEventHandler(this.pitch_Paint);
			// 
			// roll
			// 
			resources.ApplyResources(this.roll, "roll");
			this.roll.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.roll.Cursor = System.Windows.Forms.Cursors.Hand;
			this.roll.Image = global::ihamarmaratask.Properties.Resources.airplane_icon_icons_com_68012;
			this.roll.Name = "roll";
			this.roll.TabStop = false;
			// 
			// pitch
			// 
			resources.ApplyResources(this.pitch, "pitch");
			this.pitch.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pitch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pitch.Image = global::ihamarmaratask.Properties.Resources.plane_aircraft_airplane_icon_183200;
			this.pitch.Name = "pitch";
			this.pitch.TabStop = false;
			this.pitch.Paint += new System.Windows.Forms.PaintEventHandler(this.yaw_Paint);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::ihamarmaratask.Properties.Resources.airplane_icon_icons_com_68012;
			resources.ApplyResources(this.pictureBox1, "pictureBox1");
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.TabStop = false;
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Name = "label3";
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Name = "label4";
			// 
			// irtifa_gosterge
			// 
			resources.ApplyResources(this.irtifa_gosterge, "irtifa_gosterge");
			this.irtifa_gosterge.BackColor = System.Drawing.Color.Transparent;
			this.irtifa_gosterge.Name = "irtifa_gosterge";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.irtifa_gosterge);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label4);
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Name = "panel1";
			// 
			// maps_info
			// 
			resources.ApplyResources(this.maps_info, "maps_info");
			this.maps_info.Name = "maps_info";
			this.maps_info.UseVisualStyleBackColor = true;
			this.maps_info.Click += new System.EventHandler(this.maps_info_Click);
			// 
			// label5
			// 
			resources.ApplyResources(this.label5, "label5");
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Name = "label5";
			// 
			// label6
			// 
			resources.ApplyResources(this.label6, "label6");
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Name = "label6";
			// 
			// label7
			// 
			resources.ApplyResources(this.label7, "label7");
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Name = "label7";
			// 
			// yaw_label
			// 
			resources.ApplyResources(this.yaw_label, "yaw_label");
			this.yaw_label.BackColor = System.Drawing.Color.Transparent;
			this.yaw_label.Name = "yaw_label";
			// 
			// roll_label
			// 
			resources.ApplyResources(this.roll_label, "roll_label");
			this.roll_label.BackColor = System.Drawing.Color.Transparent;
			this.roll_label.Name = "roll_label";
			// 
			// pitch_label
			// 
			resources.ApplyResources(this.pitch_label, "pitch_label");
			this.pitch_label.BackColor = System.Drawing.Color.Transparent;
			this.pitch_label.Name = "pitch_label";
			// 
			// button2
			// 
			resources.ApplyResources(this.button2, "button2");
			this.button2.Name = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
			resources.ApplyResources(this.pictureBox2, "pictureBox2");
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.TabStop = false;
			// 
			// hız_label
			// 
			resources.ApplyResources(this.hız_label, "hız_label");
			this.hız_label.BackColor = System.Drawing.Color.Black;
			this.hız_label.ForeColor = System.Drawing.Color.White;
			this.hız_label.Name = "hız_label";
			// 
			// label8
			// 
			resources.ApplyResources(this.label8, "label8");
			this.label8.BackColor = System.Drawing.Color.Black;
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Name = "label8";
			// 
			// button3
			// 
			resources.ApplyResources(this.button3, "button3");
			this.button3.Name = "button3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Form1
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.BackgroundImage = global::ihamarmaratask.Properties.Resources.soft_cloud_sky_background_blue_tone_51012_527;
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.hız_label);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.pitch_label);
			this.Controls.Add(this.roll_label);
			this.Controls.Add(this.yaw_label);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.maps_info);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pitch);
			this.Controls.Add(this.roll);
			this.Controls.Add(this.yaw);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.voltaj);
			this.Controls.Add(this.battery);
			this.Controls.Add(this.batteryyyyy_img);
			this.Controls.Add(this.batteryyy_img);
			this.Controls.Add(this.batteryy_img);
			this.Controls.Add(this.battery_img);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.gMapControl1);
			this.Controls.Add(this.time);
			this.Name = "Form1";
			this.TransparencyKey = System.Drawing.Color.OldLace;
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.battery_img)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.batteryy_img)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.batteryyy_img)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.batteryyyyy_img)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.yaw)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.roll)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pitch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Timer zaman;
		private System.Windows.Forms.Label time;
		private GMap.NET.WindowsForms.GMapControl gMapControl1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox battery_img;
		private System.Windows.Forms.PictureBox batteryy_img;
		private System.Windows.Forms.PictureBox batteryyy_img;
		private System.Windows.Forms.PictureBox batteryyyyy_img;
		private System.Windows.Forms.Label battery;
		private System.Windows.Forms.Label voltaj;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Timer volt;
		private System.Windows.Forms.PictureBox yaw;
		private System.Windows.Forms.PictureBox roll;
		private System.Windows.Forms.PictureBox pitch;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label irtifa_gosterge;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button maps_info;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label yaw_label;
		private System.Windows.Forms.Label roll_label;
		private System.Windows.Forms.Label pitch_label;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label hız_label;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button button3;
	}
}

