using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ihamarmaratask
{
	public partial class demoform : Form
	{
		public demoform()
		{
			InitializeComponent();
		}
		int a = 0;
		public string hiz { get; set; }
		public string pichaci { get; set; }
		public string yawaci { get; set; }
		public string rollaci { get; set; }
		public string enlem { get; set; }
		public string boylam { get; set; }
		public string pilvoltaj { get; set; }
		public string irtifa { get; set; }

		private void verigiris_textbox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				verigiris_button_Click(sender, e);
				e.Handled = true;
			}
		}

		private void demoform_Load(object sender, EventArgs e)
		{
			yonlendirme_label.Text = "Lütfen ilk bilgi olarak uçuş hızını giriniz (m/s)";
			
		}

		private void verigiris_button_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(verigiris_textbox.Text))
			{
				MessageBox.Show("Lütfen bir değer giriniz!", "Uyarı",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (a == 0)
			{
				hiz = verigiris_textbox.Text;
				yonlendirme_label.Text = "Lütfen yaw açısını giriniz (derece)";
				a++;
				verigiris_textbox.Text = "";
			}
			else if (a == 1)
			{
				pichaci = verigiris_textbox.Text;
				yonlendirme_label.Text = "Lütfen pitch açısını giriniz (derece)";
				a++;
				verigiris_textbox.Text = "";

			}
			else if (a == 2)
			{
				yawaci = verigiris_textbox.Text;
				yonlendirme_label.Text = "Lütfen roll açısını giriniz (derece)";
				a++;
				verigiris_textbox.Text = "";

			}
			else if (a == 3)
			{
				rollaci = verigiris_textbox.Text;
				yonlendirme_label.Text = "Lütfen enlem bilgisini giriniz (örnek değer 45,00343 derece)";
				a++;
				verigiris_textbox.Text = "";
			}
			else if (a == 4)
			{
				enlem = verigiris_textbox.Text;
				yonlendirme_label.Text = "Lütfen boylam bilgisini giriniz (örnek değer 45,00343 derece)";
				a++;
				verigiris_textbox.Text = "";
			}
			else if (a == 5)
			{
				boylam = verigiris_textbox.Text;
				yonlendirme_label.Text = "Lütfen irtifa bilgisini giriniz (m)";
				a++;
				verigiris_textbox.Text = "";
			}
			else if (a == 6)
			{
				irtifa = verigiris_textbox.Text;
				yonlendirme_label.Text = "Lütfen pil voltaj bilgisini giriniz (volt 0-12)";
				a++;	
				verigiris_textbox.Text = "";
			}
			else if (a == 7)
			{
				pilvoltaj = verigiris_textbox.Text;
//				totalveri = hiz + "/" + pichaci + "/" + yawaci + "/" + rollaci + "/" + enlem + "/" + boylam + "/" + irtifa + "/" + pilvoltaj;
				yonlendirme_label.Text = "Tüm Veriler Girildi !";
				//MessageBox.Show(totalveri);
				MessageBox.Show("Giriş başarılı! Bu formu kapatabilirsiniz");
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBox1.Text))
			{
				MessageBox.Show("Lütfen veri giriniz!", "Uyarı",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string topluVeri = textBox1.Text;
			string[] parcalar = topluVeri.Split('/');

			if (parcalar.Length != 8)
			{
				MessageBox.Show("Veri formatı hatalı! 8 değer girmelisiniz.\nFormat: hız/pitch/yaw/roll/enlem/boylam/irtifa/pilvoltaj",
					"Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			try
			{
				hiz = parcalar[0].Trim();
				pichaci = parcalar[1].Trim();
				yawaci = parcalar[2].Trim();
				rollaci = parcalar[3].Trim();
				enlem = parcalar[4].Trim();
				boylam = parcalar[5].Trim();
				irtifa = parcalar[6].Trim();
				pilvoltaj = parcalar[7].Trim();

				a = 7; // Tüm veriler girildi olarak işaretle
				label2.Text = "Tüm Veriler Girildi (Toplu Giriş)!";

				MessageBox.Show($"Veriler başarıyla yüklendi:\n\n" +
					$"Hız: {hiz} m/s\n" +
					$"Pitch: {pichaci}°\n" +
					$"Yaw: {yawaci}°\n" +
					$"Roll: {rollaci}°\n" +
					$"Enlem: {enlem}°\n" +
					$"Boylam: {boylam}°\n" +
					$"İrtifa: {irtifa} m\n" +
					$"Pil Voltaj: {pilvoltaj} V",
					"Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show("Giriş başarılı! Bu formu kapatabilirsiniz");


				textBox1.Text = "";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Veri işlenirken hata oluştu: " + ex.Message,
					"Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
