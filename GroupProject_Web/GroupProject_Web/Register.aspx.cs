using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HashPass;
using GroupProject_Web.ServiceReference1;

namespace GroupProject_Web
{
    public partial class Register : System.Web.UI.Page
    {
        Service1Client SR = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            /*if (Session["UType"] != null)
            {
                if (Session["UType"].ToString() != "Customer")
                {
                    typeTab.Visible = true;
                }
            }*/


        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (password1.Value == password2.Value)
            {
                var hashed = Secrecy.HashPassword(password1.Value);
                DateTime dob = default;
                if (contact_form_date.Value != "")
                {
                    dob = Convert.ToDateTime(contact_form_date.Value);
                }
                var newUser = new SysUser()
                {
                    Username = contact_form_name.Value,
                    Email = contact_form_email.Value,
                    Phone = contact_form_phone.Value,
                    Dateofbirth = dob,
                    Password = hashed,
                    RegDate = DateTime.Now,
                    UserType = type.Value
                };
                int result = SR.UserReg(newUser);
                if (result == 1)
                {
                    Response.Redirect("Login.aspx");
                }
                else if (result == 0)
                {
                    error.Text = "User already exists.";
                }
            }
            else
            {
                error.Text = "Passwords do not match.";
            }
        }
    }


}