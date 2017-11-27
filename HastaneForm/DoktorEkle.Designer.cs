namespace HastaneForm
{
    partial class DoktorEkle
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbIl = new System.Windows.Forms.ComboBox();
            this.cbIlce = new System.Windows.Forms.ComboBox();
            this.cbHastane = new System.Windows.Forms.ComboBox();
            this.cbPoliklinik = new System.Windows.Forms.ComboBox();
            this.txtDoktorAdi = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtDoktorSoyadi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvDoktorlar = new System.Windows.Forms.DataGridView();
            this.cmDoktorlarMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seçileniSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçileniDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoktorlar)).BeginInit();
            this.cmDoktorlarMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İl:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "İlçe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hastane:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Poliklinik:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Doktor Adı:";
            // 
            // cbIl
            // 
            this.cbIl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIl.FormattingEnabled = true;
            this.cbIl.Location = new System.Drawing.Point(122, 9);
            this.cbIl.Name = "cbIl";
            this.cbIl.Size = new System.Drawing.Size(121, 21);
            this.cbIl.TabIndex = 0;
            this.cbIl.SelectedValueChanged += new System.EventHandler(this.cbIl_SelectedValueChanged);
            this.cbIl.Click += new System.EventHandler(this.cbIl_Click);
            // 
            // cbIlce
            // 
            this.cbIlce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIlce.FormattingEnabled = true;
            this.cbIlce.Location = new System.Drawing.Point(122, 43);
            this.cbIlce.Name = "cbIlce";
            this.cbIlce.Size = new System.Drawing.Size(121, 21);
            this.cbIlce.TabIndex = 1;
            this.cbIlce.SelectedValueChanged += new System.EventHandler(this.cbIlce_SelectedValueChanged);
            // 
            // cbHastane
            // 
            this.cbHastane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHastane.FormattingEnabled = true;
            this.cbHastane.Location = new System.Drawing.Point(122, 77);
            this.cbHastane.Name = "cbHastane";
            this.cbHastane.Size = new System.Drawing.Size(121, 21);
            this.cbHastane.TabIndex = 2;
            this.cbHastane.SelectedValueChanged += new System.EventHandler(this.cbHastane_SelectedValueChanged);
            // 
            // cbPoliklinik
            // 
            this.cbPoliklinik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPoliklinik.FormattingEnabled = true;
            this.cbPoliklinik.Location = new System.Drawing.Point(122, 111);
            this.cbPoliklinik.Name = "cbPoliklinik";
            this.cbPoliklinik.Size = new System.Drawing.Size(121, 21);
            this.cbPoliklinik.TabIndex = 3;
            this.cbPoliklinik.SelectedValueChanged += new System.EventHandler(this.cbPoliklinik_SelectedValueChanged);
            // 
            // txtDoktorAdi
            // 
            this.txtDoktorAdi.Location = new System.Drawing.Point(122, 145);
            this.txtDoktorAdi.Name = "txtDoktorAdi";
            this.txtDoktorAdi.Size = new System.Drawing.Size(121, 20);
            this.txtDoktorAdi.TabIndex = 4;
            this.txtDoktorAdi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDoktorAdi_KeyDown);
            this.txtDoktorAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.Location = new System.Drawing.Point(122, 213);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(121, 26);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtDoktorSoyadi
            // 
            this.txtDoktorSoyadi.Location = new System.Drawing.Point(122, 178);
            this.txtDoktorSoyadi.Name = "txtDoktorSoyadi";
            this.txtDoktorSoyadi.Size = new System.Drawing.Size(121, 20);
            this.txtDoktorSoyadi.TabIndex = 5;
            this.txtDoktorSoyadi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDoktorSoyadi_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Doktor Soyadı:";
            // 
            // dgvDoktorlar
            // 
            this.dgvDoktorlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoktorlar.ContextMenuStrip = this.cmDoktorlarMenu;
            this.dgvDoktorlar.Location = new System.Drawing.Point(269, 12);
            this.dgvDoktorlar.MultiSelect = false;
            this.dgvDoktorlar.Name = "dgvDoktorlar";
            this.dgvDoktorlar.ReadOnly = true;
            this.dgvDoktorlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoktorlar.Size = new System.Drawing.Size(182, 186);
            this.dgvDoktorlar.TabIndex = 14;
            // 
            // cmDoktorlarMenu
            // 
            this.cmDoktorlarMenu.BackColor = System.Drawing.Color.FloralWhite;
            this.cmDoktorlarMenu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmDoktorlarMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seçileniSilToolStripMenuItem,
            this.seçileniDüzenleToolStripMenuItem});
            this.cmDoktorlarMenu.Name = "cmHastanelerMenu";
            this.cmDoktorlarMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmDoktorlarMenu.Size = new System.Drawing.Size(167, 48);
            // 
            // seçileniSilToolStripMenuItem
            // 
            this.seçileniSilToolStripMenuItem.Name = "seçileniSilToolStripMenuItem";
            this.seçileniSilToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.seçileniSilToolStripMenuItem.Text = "Seçileni Sil";
            this.seçileniSilToolStripMenuItem.Click += new System.EventHandler(this.seçileniSilToolStripMenuItem_Click);
            // 
            // seçileniDüzenleToolStripMenuItem
            // 
            this.seçileniDüzenleToolStripMenuItem.Name = "seçileniDüzenleToolStripMenuItem";
            this.seçileniDüzenleToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.seçileniDüzenleToolStripMenuItem.Text = "Seçileni Düzenle";
            this.seçileniDüzenleToolStripMenuItem.Click += new System.EventHandler(this.seçileniDüzenleToolStripMenuItem_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(269, 213);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(182, 26);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // DoktorEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 253);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dgvDoktorlar);
            this.Controls.Add(this.txtDoktorSoyadi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtDoktorAdi);
            this.Controls.Add(this.cbPoliklinik);
            this.Controls.Add(this.cbHastane);
            this.Controls.Add(this.cbIlce);
            this.Controls.Add(this.cbIl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DoktorEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DoktorEkle";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoktorEkle_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoktorlar)).EndInit();
            this.cmDoktorlarMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbIl;
        private System.Windows.Forms.ComboBox cbIlce;
        private System.Windows.Forms.ComboBox cbHastane;
        private System.Windows.Forms.ComboBox cbPoliklinik;
        private System.Windows.Forms.TextBox txtDoktorAdi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtDoktorSoyadi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvDoktorlar;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ContextMenuStrip cmDoktorlarMenu;
        private System.Windows.Forms.ToolStripMenuItem seçileniSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçileniDüzenleToolStripMenuItem;
    }
}