using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Esercizio
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Verifica se esiste il cookie
            if (Request.Cookies["UserInfo"] != null)
            {
                lblUsername.Text = Request.Cookies["UserInfo"].Value;
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            // Cancella il cookie
            if (Request.Cookies["UserInfo"] != null)
            {
                HttpCookie userCookie = new HttpCookie("UserInfo");
                userCookie.Expires = DateTime.Now.AddDays(-1); // Imposta scadenza nel passato per rimuovere il cookie
                Response.Cookies.Add(userCookie);
            }

            Response.Redirect("Login.aspx");
        }
    }
}