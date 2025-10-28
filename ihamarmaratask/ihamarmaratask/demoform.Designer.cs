namespace ihamarmaratask
{
	partial class demoform
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.verigiris_textbox = new System.Windows.Forms.TextBox();
			this.baslik_label = new System.Windows.Forms.Label();
			this.bilgilendirme_label = new System.Windows.Forms.Label();
			this.verigiris_button = new System.Windows.Forms.Button();
			this.yonlendirme_label = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// verigiris_textbox
			// 
			this.verigiris_textbox.BackColor = System.Drawing.SystemColors.HighlightText;
			this.verigiris_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.verigiris_textbox.Location = new System.Drawing.Point(36, 120);
			this.verigiris_textbox.Name = "verigiris_textbox";
			this.verigiris_textbox.Size = new System.Drawing.Size(295, 34);
			this.verigiris_textbox.TabIndex = 3;
			this.verigiris_textbox.Text = "Veri giriniz...";
			this.verigiris_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.verigiris_textbox_KeyPress);
			// 
			// baslik_label
			// 
			this.baslik_label.AutoSize = true;
			this.baslik_label.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.baslik_label.Location = new System.Drawing.Point(101, 18);
			this.baslik_label.Name = "baslik_label";
			this.baslik_label.Size = new System.Drawing.Size(277, 24);
			this.baslik_label.TabIndex = 4;
			this.baslik_label.Text = "Demo: İstasyon Anlık Veri Girişi";
			// 
			// bilgilendirme_label
			// 
			this.bilgilendirme_label.AutoSize = true;
			this.bilgilendirme_label.Location = new System.Drawing.Point(12, 472);
			this.bilgilendirme_label.Name = "bilgilendirme_label";
			this.bilgilendirme_label.Size = new System.Drawing.Size(424, 32);
			this.bilgilendirme_label.TabIndex = 5;
			this.bilgilendirme_label.Text = "***Normalde tabi verileri anlık olarak çekerek istasyonda göstereceğiz\r\n     ama " +
    "bu örnek özelinde bir veri girişi yapacağız.";
			// 
			// verigiris_button
			// 
			this.verigiris_button.Location = new System.Drawing.Point(356, 105);
			this.verigiris_button.Name = "verigiris_button";
			this.verigiris_button.Size = new System.Drawing.Size(124, 49);
			this.verigiris_button.TabIndex = 6;
			this.verigiris_button.Text = "Veri Yolla";
			this.verigiris_button.UseVisualStyleBackColor = true;
			this.verigiris_button.Click += new System.EventHandler(this.verigiris_button_Click);
			// 
			// yonlendirme_label
			// 
			this.yonlendirme_label.AutoSize = true;
			this.yonlendirme_label.Location = new System.Drawing.Point(33, 157);
			this.yonlendirme_label.Name = "yonlendirme_label";
			this.yonlendirme_label.Size = new System.Drawing.Size(44, 16);
			this.yonlendirme_label.TabIndex = 7;
			this.yonlendirme_label.Text = "label3";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.textBox1.Location = new System.Drawing.Point(36, 268);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(295, 34);
			this.textBox1.TabIndex = 8;
			this.textBox1.Text = "Veri giriniz...";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(33, 239);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(232, 16);
			this.label1.TabIndex = 9;
			this.label1.Text = "Eğer / lı şekilde data girmek isterseniz";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(337, 262);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(124, 49);
			this.button1.TabIndex = 10;
			this.button1.Text = "Veri Yolla";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(33, 314);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(273, 16);
			this.label2.TabIndex = 11;
			this.label2.Text = "hız/pitch/yaw/roll/enlem/boylam/irtifa/pilvoltaj";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(33, 101);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(317, 16);
			this.label3.TabIndex = 12;
			this.label3.Text = "Eğer daha modern bir şekilde data girmek isterseniz";
			// 
			// demoform
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.ClientSize = new System.Drawing.Size(519, 513);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.yonlendirme_label);
			this.Controls.Add(this.verigiris_button);
			this.Controls.Add(this.bilgilendirme_label);
			this.Controls.Add(this.baslik_label);
			this.Controls.Add(this.verigiris_textbox);
			this.Name = "demoform";
			this.Text = "demoform";
			this.Load += new System.EventHandler(this.demoform_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox verigiris_textbox;
		private System.Windows.Forms.Label baslik_label;
		private System.Windows.Forms.Label bilgilendirme_label;
		private System.Windows.Forms.Button verigiris_button;
		private System.Windows.Forms.Label yonlendirme_label;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}