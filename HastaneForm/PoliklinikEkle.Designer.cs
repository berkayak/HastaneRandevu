namespace HastaneForm
{
    partial class PoliklinikEkle
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
            this.cbIl = new System.Windows.Forms.ComboBox();
            this.cbIlce = new System.Windows.Forms.ComboBox();
            this.cbHastane = new System.Windows.Forms.ComboBox();
            this.txtPoliklinikAdi = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lbPoliklinikler = new System.Windows.Forms.ListBox();
            this.cmPolikliniklerMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seçileniSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçileniDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cmPolikliniklerMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Il Seçin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ilce Seçin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hastane Secçin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Poliklinik Adı:";
            // 
            // cbIl
            // 
            this.cbIl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIl.FormattingEnabled = true;
            this.cbIl.Location = new System.Drawing.Point(126, 23);
            this.cbIl.Name = "cbIl";
            this.cbIl.Size = new System.Drawing.Size(121, 21);
            this.cbIl.TabIndex = 1;
            this.cbIl.SelectedIndexChanged += new System.EventHandler(this.cbIl_SelectedIndexChanged);
            // 
            // cbIlce
            // 
            this.cbIlce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIlce.FormattingEnabled = true;
            this.cbIlce.Location = new System.Drawing.Point(126, 57);
            this.cbIlce.Name = "cbIlce";
            this.cbIlce.Size = new System.Drawing.Size(121, 21);
            this.cbIlce.TabIndex = 2;
            this.cbIlce.SelectedIndexChanged += new System.EventHandler(this.cbIlce_SelectedIndexChanged);
            // 
            // cbHastane
            // 
            this.cbHastane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHastane.FormattingEnabled = true;
            this.cbHastane.Location = new System.Drawing.Point(126, 91);
            this.cbHastane.Name = "cbHastane";
            this.cbHastane.Size = new System.Drawing.Size(121, 21);
            this.cbHastane.TabIndex = 3;
            this.cbHastane.SelectedIndexChanged += new System.EventHandler(this.cbHastane_SelectedIndexChanged);
            // 
            // txtPoliklinikAdi
            // 
            this.txtPoliklinikAdi.Location = new System.Drawing.Point(126, 125);
            this.txtPoliklinikAdi.Name = "txtPoliklinikAdi";
            this.txtPoliklinikAdi.Size = new System.Drawing.Size(121, 20);
            this.txtPoliklinikAdi.TabIndex = 4;
            this.txtPoliklinikAdi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPoliklinikAdi_KeyDown);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(126, 161);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(121, 23);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lbPoliklinikler
            // 
            this.lbPoliklinikler.ContextMenuStrip = this.cmPolikliniklerMenu;
            this.lbPoliklinikler.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPoliklinikler.FormattingEnabled = true;
            this.lbPoliklinikler.ItemHeight = 19;
            this.lbPoliklinikler.Location = new System.Drawing.Point(266, 26);
            this.lbPoliklinikler.Name = "lbPoliklinikler";
            this.lbPoliklinikler.Size = new System.Drawing.Size(131, 175);
            this.lbPoliklinikler.TabIndex = 6;
            // 
            // cmPolikliniklerMenu
            // 
            this.cmPolikliniklerMenu.BackColor = System.Drawing.Color.FloralWhite;
            this.cmPolikliniklerMenu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmPolikliniklerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seçileniSilToolStripMenuItem,
            this.seçileniDüzenleToolStripMenuItem});
            this.cmPolikliniklerMenu.Name = "cmHastanelerMenu";
            this.cmPolikliniklerMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmPolikliniklerMenu.Size = new System.Drawing.Size(167, 70);
            // 
            // seçileniSilToolStripMenuItem
            // 
            this.seçileniSilToolStripMenuItem.Name = "seçileniSilToolStripMenuItem";
            this.seçileniSilToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.seçileniSilToolStripMenuItem.Text = "Seçileni Sil";
            this.seçileniSilToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.seçileniSilToolStripMenuItem.Click += new System.EventHandler(this.seçileniSilToolStripMenuItem_Click);
            // 
            // seçileniDüzenleToolStripMenuItem
            // 
            this.seçileniDüzenleToolStripMenuItem.Name = "seçileniDüzenleToolStripMenuItem";
            this.seçileniDüzenleToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.seçileniDüzenleToolStripMenuItem.Text = "Seçileni Düzenle";
            this.seçileniDüzenleToolStripMenuItem.Click += new System.EventHandler(this.seçileniDüzenleToolStripMenuItem_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.Location = new System.Drawing.Point(126, 199);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(121, 23);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // PoliklinikEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 234);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.lbPoliklinikler);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtPoliklinikAdi);
            this.Controls.Add(this.cbHastane);
            this.Controls.Add(this.cbIlce);
            this.Controls.Add(this.cbIl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PoliklinikEkle";
            this.Text = "PoliklinikEkle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PoliklinikEkle_FormClosing);
            this.Load += new System.EventHandler(this.PoliklinikEkle_Load);
            this.cmPolikliniklerMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbIl;
        private System.Windows.Forms.ComboBox cbIlce;
        private System.Windows.Forms.ComboBox cbHastane;
        private System.Windows.Forms.TextBox txtPoliklinikAdi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ListBox lbPoliklinikler;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ContextMenuStrip cmPolikliniklerMenu;
        private System.Windows.Forms.ToolStripMenuItem seçileniSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçileniDüzenleToolStripMenuItem;
    }
}