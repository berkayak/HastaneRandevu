namespace HastaneForm
{
    partial class RandevuAl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandevuAl));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.cbCinsiyet = new System.Windows.Forms.ComboBox();
            this.gbHastaBilgileri = new System.Windows.Forms.GroupBox();
            this.gbHastaneSecim = new System.Windows.Forms.GroupBox();
            this.cbPoliklinik = new System.Windows.Forms.ComboBox();
            this.cbHastane = new System.Windows.Forms.ComboBox();
            this.cbIlce = new System.Windows.Forms.ComboBox();
            this.cbIl = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbSaatSecim = new System.Windows.Forms.GroupBox();
            this.lbUygunSaatler = new System.Windows.Forms.ListBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnBilgi = new System.Windows.Forms.Button();
            this.lblRandevuTarihi = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gbHastaBilgileri.SuspendLayout();
            this.gbHastaneSecim.SuspendLayout();
            this.gbSaatSecim.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "e-Mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Doğum Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cinsiyet:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(126, 33);
            this.txtAd.MaxLength = 50;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 1;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(126, 79);
            this.txtSoyad.MaxLength = 50;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 2;
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyad_KeyPress);
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(126, 125);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(100, 20);
            this.txtTC.TabIndex = 3;
            this.txtTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTC_KeyPress);
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(126, 171);
            this.txtEMail.MaxLength = 50;
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(100, 20);
            this.txtEMail.TabIndex = 4;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDogumTarihi.Location = new System.Drawing.Point(126, 220);
            this.dtpDogumTarihi.MaxDate = new System.DateTime(2015, 12, 31, 0, 0, 0, 0);
            this.dtpDogumTarihi.MinDate = new System.DateTime(1850, 1, 1, 0, 0, 0, 0);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(100, 20);
            this.dtpDogumTarihi.TabIndex = 5;
            this.dtpDogumTarihi.Value = new System.DateTime(2015, 12, 31, 0, 0, 0, 0);
            this.dtpDogumTarihi.CloseUp += new System.EventHandler(this.dtpDogumTarihi_CloseUp);
            // 
            // cbCinsiyet
            // 
            this.cbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCinsiyet.FormattingEnabled = true;
            this.cbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cbCinsiyet.Location = new System.Drawing.Point(126, 266);
            this.cbCinsiyet.Name = "cbCinsiyet";
            this.cbCinsiyet.Size = new System.Drawing.Size(100, 21);
            this.cbCinsiyet.TabIndex = 6;
            // 
            // gbHastaBilgileri
            // 
            this.gbHastaBilgileri.Controls.Add(this.cbCinsiyet);
            this.gbHastaBilgileri.Controls.Add(this.label1);
            this.gbHastaBilgileri.Controls.Add(this.dtpDogumTarihi);
            this.gbHastaBilgileri.Controls.Add(this.label2);
            this.gbHastaBilgileri.Controls.Add(this.txtEMail);
            this.gbHastaBilgileri.Controls.Add(this.label3);
            this.gbHastaBilgileri.Controls.Add(this.txtTC);
            this.gbHastaBilgileri.Controls.Add(this.label4);
            this.gbHastaBilgileri.Controls.Add(this.txtSoyad);
            this.gbHastaBilgileri.Controls.Add(this.label5);
            this.gbHastaBilgileri.Controls.Add(this.txtAd);
            this.gbHastaBilgileri.Controls.Add(this.label6);
            this.gbHastaBilgileri.Location = new System.Drawing.Point(28, 29);
            this.gbHastaBilgileri.Name = "gbHastaBilgileri";
            this.gbHastaBilgileri.Size = new System.Drawing.Size(295, 330);
            this.gbHastaBilgileri.TabIndex = 14;
            this.gbHastaBilgileri.TabStop = false;
            this.gbHastaBilgileri.Text = "Hasta Bilgileri";
            // 
            // gbHastaneSecim
            // 
            this.gbHastaneSecim.Controls.Add(this.cbPoliklinik);
            this.gbHastaneSecim.Controls.Add(this.cbHastane);
            this.gbHastaneSecim.Controls.Add(this.cbIlce);
            this.gbHastaneSecim.Controls.Add(this.cbIl);
            this.gbHastaneSecim.Controls.Add(this.label10);
            this.gbHastaneSecim.Controls.Add(this.label9);
            this.gbHastaneSecim.Controls.Add(this.label8);
            this.gbHastaneSecim.Controls.Add(this.label7);
            this.gbHastaneSecim.Location = new System.Drawing.Point(368, 29);
            this.gbHastaneSecim.Name = "gbHastaneSecim";
            this.gbHastaneSecim.Size = new System.Drawing.Size(303, 217);
            this.gbHastaneSecim.TabIndex = 15;
            this.gbHastaneSecim.TabStop = false;
            this.gbHastaneSecim.Text = "Hastane Seçim";
            // 
            // cbPoliklinik
            // 
            this.cbPoliklinik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPoliklinik.FormattingEnabled = true;
            this.cbPoliklinik.Location = new System.Drawing.Point(119, 175);
            this.cbPoliklinik.Name = "cbPoliklinik";
            this.cbPoliklinik.Size = new System.Drawing.Size(101, 21);
            this.cbPoliklinik.TabIndex = 10;
            this.cbPoliklinik.SelectedIndexChanged += new System.EventHandler(this.cbPoliklinik_SelectedIndexChanged);
            // 
            // cbHastane
            // 
            this.cbHastane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHastane.FormattingEnabled = true;
            this.cbHastane.Location = new System.Drawing.Point(119, 129);
            this.cbHastane.Name = "cbHastane";
            this.cbHastane.Size = new System.Drawing.Size(101, 21);
            this.cbHastane.TabIndex = 9;
            this.cbHastane.SelectedIndexChanged += new System.EventHandler(this.cbHastane_SelectedIndexChanged);
            this.cbHastane.SelectedValueChanged += new System.EventHandler(this.cbHastane_SelectedValueChanged);
            // 
            // cbIlce
            // 
            this.cbIlce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIlce.FormattingEnabled = true;
            this.cbIlce.Location = new System.Drawing.Point(119, 79);
            this.cbIlce.Name = "cbIlce";
            this.cbIlce.Size = new System.Drawing.Size(101, 21);
            this.cbIlce.TabIndex = 8;
            this.cbIlce.SelectedIndexChanged += new System.EventHandler(this.cbIlce_SelectedIndexChanged);
            this.cbIlce.SelectedValueChanged += new System.EventHandler(this.cbIlce_SelectedValueChanged);
            // 
            // cbIl
            // 
            this.cbIl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIl.FormattingEnabled = true;
            this.cbIl.Location = new System.Drawing.Point(119, 37);
            this.cbIl.Name = "cbIl";
            this.cbIl.Size = new System.Drawing.Size(101, 21);
            this.cbIl.TabIndex = 7;
            this.cbIl.SelectedIndexChanged += new System.EventHandler(this.cbIl_SelectedIndexChanged);
            this.cbIl.SelectedValueChanged += new System.EventHandler(this.cbIl_SelectedValueChanged);
            this.cbIl.Click += new System.EventHandler(this.cbIl_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Poliklinik";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Hastane:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "İlçe:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "İl:";
            // 
            // gbSaatSecim
            // 
            this.gbSaatSecim.Controls.Add(this.lbUygunSaatler);
            this.gbSaatSecim.Location = new System.Drawing.Point(714, 29);
            this.gbSaatSecim.Name = "gbSaatSecim";
            this.gbSaatSecim.Size = new System.Drawing.Size(92, 301);
            this.gbSaatSecim.TabIndex = 17;
            this.gbSaatSecim.TabStop = false;
            this.gbSaatSecim.Text = "Saat Seçimi";
            // 
            // lbUygunSaatler
            // 
            this.lbUygunSaatler.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUygunSaatler.FormattingEnabled = true;
            this.lbUygunSaatler.ItemHeight = 19;
            this.lbUygunSaatler.Items.AddRange(new object[] {
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30"});
            this.lbUygunSaatler.Location = new System.Drawing.Point(20, 19);
            this.lbUygunSaatler.Name = "lbUygunSaatler";
            this.lbUygunSaatler.Size = new System.Drawing.Size(58, 270);
            this.lbUygunSaatler.TabIndex = 11;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.Location = new System.Drawing.Point(714, 336);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(92, 45);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnBilgi
            // 
            this.btnBilgi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBilgi.BackgroundImage")));
            this.btnBilgi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBilgi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBilgi.Location = new System.Drawing.Point(678, 41);
            this.btnBilgi.Name = "btnBilgi";
            this.btnBilgi.Size = new System.Drawing.Size(30, 30);
            this.btnBilgi.TabIndex = 18;
            this.btnBilgi.UseVisualStyleBackColor = true;
            this.btnBilgi.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRandevuTarihi
            // 
            this.lblRandevuTarihi.AutoSize = true;
            this.lblRandevuTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRandevuTarihi.Location = new System.Drawing.Point(484, 283);
            this.lblRandevuTarihi.Name = "lblRandevuTarihi";
            this.lblRandevuTarihi.Size = new System.Drawing.Size(47, 16);
            this.lblRandevuTarihi.TabIndex = 19;
            this.lblRandevuTarihi.Text = "-Tarih-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(365, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Randevu Tarihi:";
            // 
            // RandevuAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 404);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblRandevuTarihi);
            this.Controls.Add(this.btnBilgi);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.gbSaatSecim);
            this.Controls.Add(this.gbHastaneSecim);
            this.Controls.Add(this.gbHastaBilgileri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RandevuAl";
            this.Text = "RandevuAl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RandevuAl_FormClosing);
            this.Load += new System.EventHandler(this.RandevuAl_Load);
            this.gbHastaBilgileri.ResumeLayout(false);
            this.gbHastaBilgileri.PerformLayout();
            this.gbHastaneSecim.ResumeLayout(false);
            this.gbHastaneSecim.PerformLayout();
            this.gbSaatSecim.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.ComboBox cbCinsiyet;
        private System.Windows.Forms.GroupBox gbHastaBilgileri;
        private System.Windows.Forms.GroupBox gbHastaneSecim;
        private System.Windows.Forms.ComboBox cbPoliklinik;
        private System.Windows.Forms.ComboBox cbHastane;
        private System.Windows.Forms.ComboBox cbIlce;
        private System.Windows.Forms.ComboBox cbIl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbSaatSecim;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ListBox lbUygunSaatler;
        private System.Windows.Forms.Button btnBilgi;
        private System.Windows.Forms.Label lblRandevuTarihi;
        private System.Windows.Forms.Label label11;
    }
}