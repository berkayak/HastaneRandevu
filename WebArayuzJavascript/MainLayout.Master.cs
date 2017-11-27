using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebArayuzJavascript
{
    public partial class MainLayout : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [System.Web.Services.WebMethod(EnableSession=true)]
        public static void CikisYap()
        {
            HttpContext.Current.Session.Abandon();
        }

        protected void btnCikis_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Giris.aspx");
        }
    }
}