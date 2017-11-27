using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;


namespace HastaneForm
{
    public partial class RandevularıGoruntule : Form
    {
        public RandevularıGoruntule()
        {
            InitializeComponent();
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormExtensions.SadeceRakam(sender, e);
        }

        private void RandevularıGoruntule_Load(object sender, EventArgs e)
        {
            GetLists wk = new GetLists();
            dgvRandevular.DataSource = wk.RandevularıListele(DateTime.Now.Date, DateTime.Today.AddDays(7));            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTC.Text == "")
            {
                GetLists wk = new GetLists();
                dgvRandevular.DataSource = wk.RandevularıListele(dtpBaslangic.Value, dtpBitis.Value);                
            }
            else if (txtTC.Text.Length == 11)
            {
                GetLists wk = new GetLists();
                dgvRandevular.DataSource = wk.RandevularıListele(txtTC.Text);
            }
            txtTC.Text = "";
        }

        private void RandevularıGoruntule_ResizeEnd(object sender, EventArgs e)
        {
            dgvRandevular.Width = this.Width - 40;
        }

    }
}
