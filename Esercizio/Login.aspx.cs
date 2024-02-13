using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Esercizio
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            HttpCookie userCookie = new HttpCookie("UserInfo", txtUsername.Text);
            userCookie.Expires = DateTime.Now.AddMinutes(1);
            Response.Cookies.Add(userCookie);


            Response.Redirect("HomePage.aspx");
        }
    }
}