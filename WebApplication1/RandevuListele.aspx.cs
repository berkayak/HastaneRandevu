using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common.Models;
using Business;

namespace WebApplication1
{
    public partial class RandevuListele : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               GetLists listeler = new GetLists();
               GridView1.DataSource = listeler.RandevularıListele(DateTime.Now.AddDays(-7), DateTime.Now.AddDays(7));
               GridView1.DataBind();
            }
        }

        protected void btnAra_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length == 11)
            {
                GetLists listeler = new GetLists();
                GridView1.DataSource = listeler.RandevularıListele(TextBox1.Text);
                GridView1.DataBind();
            }
            else
            {
                GetLists listeler = new GetLists();
                GridView1.DataSource = listeler.RandevularıListele(DateTime.Now.AddDays(-7), DateTime.Now.AddDays(7));
                GridView1.DataBind();
            }
        }
    }
}