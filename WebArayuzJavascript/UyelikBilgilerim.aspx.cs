using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebArayuzJavascript
{
    public partial class UyelikBilgilerim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Kullanici"].StringYap() == null)
                Response.Redirect("Giris.aspx");    
        }
    }
}