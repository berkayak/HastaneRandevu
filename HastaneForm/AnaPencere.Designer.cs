namespace HastaneForm
{
    partial class AnaPencere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaPencere));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevularıGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem,
            this.ekleToolStripMenuItem});
            resources.ApplyResources(this.msMenu, "msMenu");
            this.msMenu.Name = "msMenu";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randevuAlToolStripMenuItem,
            this.randevularıGörüntüleToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            resources.ApplyResources(this.işlemlerToolStripMenuItem, "işlemlerToolStripMenuItem");
            // 
            // randevuAlToolStripMenuItem
            // 
            this.randevuAlToolStripMenuItem.Name = "randevuAlToolStripMenuItem";
            resources.ApplyResources(this.randevuAlToolStripMenuItem, "randevuAlToolStripMenuItem");
            this.randevuAlToolStripMenuItem.Click += new System.EventHandler(this.randevuAlToolStripMenuItem_Click);
            // 
            // randevularıGörüntüleToolStripMenuItem
            // 
            this.randevularıGörüntüleToolStripMenuItem.Name = "randevularıGörüntüleToolStripMenuItem";
            resources.ApplyResources(this.randevularıGörüntüleToolStripMenuItem, "randevularıGörüntüleToolStripMenuItem");
            this.randevularıGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.randevularıGörüntüleToolStripMenuItem_Click);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaneToolStripMenuItem,
            this.poliklinikToolStripMenuItem,
            this.doktorToolStripMenuItem});
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            resources.ApplyResources(this.ekleToolStripMenuItem, "ekleToolStripMenuItem");
            // 
            // hastaneToolStripMenuItem
            // 
            this.hastaneToolStripMenuItem.Name = "hastaneToolStripMenuItem";
            resources.ApplyResources(this.hastaneToolStripMenuItem, "hastaneToolStripMenuItem");
            this.hastaneToolStripMenuItem.Click += new System.EventHandler(this.hastaneToolStripMenuItem_Click);
            // 
            // poliklinikToolStripMenuItem
            // 
            this.poliklinikToolStripMenuItem.Name = "poliklinikToolStripMenuItem";
            resources.ApplyResources(this.poliklinikToolStripMenuItem, "poliklinikToolStripMenuItem");
            this.poliklinikToolStripMenuItem.Click += new System.EventHandler(this.poliklinikToolStripMenuItem_Click);
            // 
            // doktorToolStripMenuItem
            // 
            this.doktorToolStripMenuItem.Name = "doktorToolStripMenuItem";
            resources.ApplyResources(this.doktorToolStripMenuItem, "doktorToolStripMenuItem");
            this.doktorToolStripMenuItem.Click += new System.EventHandler(this.doktorToolStripMenuItem_Click);
            // 
            // AnaPencere
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.msMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenu;
            this.Name = "AnaPencere";
            this.ShowIcon = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaPencere_FormClosing);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevularıGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poliklinikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorToolStripMenuItem;
    }
}

