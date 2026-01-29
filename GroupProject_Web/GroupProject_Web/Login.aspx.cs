using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GroupProject_Web.ServiceReference1;
using HashPass;
namespace GroupProject_Web
{
    public partial class Login : System.Web.UI.Page
    {

        Service1Client sr = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
           /* var hashed = Secrecy.HashPassword(password.Value);
            var tempUser = sr.Login(name.Value, hashed);
            if (tempUser != null)
            {
                Session["UName"] = tempUser.Username.ToString();
                Session["UType"] = tempUser.UserType.ToString();
                Session["UID"] = tempUser.Id.ToString();
                Response.Redirect("Home.aspx");
            }*/
        }
    }
}