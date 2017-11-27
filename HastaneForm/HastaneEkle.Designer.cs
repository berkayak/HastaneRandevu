namespace HastaneForm
{
    partial class HastaneEkle
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
            this.txtHastaneAdi = new System.Windows.Forms.TextBox();
            this.cbIl = new System.Windows.Forms.ComboBox();
            this.cbIlce = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lbHastaneler = new System.Windows.Forms.ListBox();
            this.cmHastanelerMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seçileniSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçileniDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cmHastanelerMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İl Seçin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "İlçe Seçin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hastane Adı:";
            // 
            // txtHastaneAdi
            // 
            this.txtHastaneAdi.Location = new System.Drawing.Point(104, 94);
            this.txtHastaneAdi.MaxLength = 50;
            this.txtHastaneAdi.Name = "txtHastaneAdi";
            this.txtHastaneAdi.Size = new System.Drawing.Size(121, 20);
            this.txtHastaneAdi.TabIndex = 3;
            this.txtHastaneAdi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHastaneAdi_KeyDown);
            // 
            // cbIl
            // 
            this.cbIl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIl.FormattingEnabled = true;
            this.cbIl.Location = new System.Drawing.Point(104, 26);
            this.cbIl.Name = "cbIl";
            this.cbIl.Size = new System.Drawing.Size(121, 21);
            this.cbIl.TabIndex = 1;
            this.cbIl.SelectedIndexChanged += new System.EventHandler(this.cbIl_SelectedIndexChanged);
            // 
            // cbIlce
            // 
            this.cbIlce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIlce.FormattingEnabled = true;
            this.cbIlce.Location = new System.Drawing.Point(104, 60);
            this.cbIlce.Name = "cbIlce";
            this.cbIlce.Size = new System.Drawing.Size(121, 21);
            this.cbIlce.TabIndex = 2;
            this.cbIlce.SelectedIndexChanged += new System.EventHandler(this.cbIlce_SelectedIndexChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(104, 130);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(121, 23);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lbHastaneler
            // 
            this.lbHastaneler.ContextMenuStrip = this.cmHastanelerMenu;
            this.lbHastaneler.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHastaneler.FormattingEnabled = true;
            this.lbHastaneler.ItemHeight = 19;
            this.lbHastaneler.Location = new System.Drawing.Point(253, 26);
            this.lbHastaneler.Name = "lbHastaneler";
            this.lbHastaneler.Size = new System.Drawing.Size(174, 156);
            this.lbHastaneler.TabIndex = 9;
            // 
            // cmHastanelerMenu
            // 
            this.cmHastanelerMenu.BackColor = System.Drawing.Color.FloralWhite;
            this.cmHastanelerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seçileniSilToolStripMenuItem,
            this.seçileniDüzenleToolStripMenuItem,
            this.poliklinikEkleToolStripMenuItem});
            this.cmHastanelerMenu.Name = "cmHastanelerMenu";
            this.cmHastanelerMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmHastanelerMenu.Size = new System.Drawing.Size(165, 92);
            // 
            // seçileniSilToolStripMenuItem
            // 
            this.seçileniSilToolStripMenuItem.Name = "seçileniSilToolStripMenuItem";
            this.seçileniSilToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.seçileniSilToolStripMenuItem.Text = "Seçileni Sil";
            this.seçileniSilToolStripMenuItem.Click += new System.EventHandler(this.seçileniSilToolStripMenuItem_Click);
            // 
            // seçileniDüzenleToolStripMenuItem
            // 
            this.seçileniDüzenleToolStripMenuItem.Name = "seçileniDüzenleToolStripMenuItem";
            this.seçileniDüzenleToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.seçileniDüzenleToolStripMenuItem.Text = "Seçileni Düzenle";
            this.seçileniDüzenleToolStripMenuItem.Click += new System.EventHandler(this.seçileniDüzenleToolStripMenuItem_Click);
            // 
            // poliklinikEkleToolStripMenuItem
            // 
            this.poliklinikEkleToolStripMenuItem.Name = "poliklinikEkleToolStripMenuItem";
            this.poliklinikEkleToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.poliklinikEkleToolStripMenuItem.Text = "Seçilene Pol. Ekle";
            this.poliklinikEkleToolStripMenuItem.Click += new System.EventHandler(this.poliklinikEkleToolStripMenuItem_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.Location = new System.Drawing.Point(104, 168);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(121, 23);
            this.btnGuncelle.TabIndex = 10;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // HastaneEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 209);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.lbHastaneler);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cbIlce);
            this.Controls.Add(this.cbIl);
            this.Controls.Add(this.txtHastaneAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HastaneEkle";
            this.Text = "HastaneEkle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HastaneEkle_FormClosing);
            this.Load += new System.EventHandler(this.HastaneEkle_Load);
            this.cmHastanelerMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHastaneAdi;
        private System.Windows.Forms.ComboBox cbIl;
        private System.Windows.Forms.ComboBox cbIlce;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ListBox lbHastaneler;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ContextMenuStrip cmHastanelerMenu;
        private System.Windows.Forms.ToolStripMenuItem seçileniSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçileniDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poliklinikEkleToolStripMenuItem;
    }
}