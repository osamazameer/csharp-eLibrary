using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bll;
using approps;

namespace E_lib
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            userbll ubll = new userbll();
            User U = new User();
            U.Name = txtName.Text;
            U.Rollno = Convert.ToInt32(txtRollNo.Text);
            U.Password = txtPassword.Text;
            U.Username= txtUsername.Text;
            U.Email = txtEmail.Text;
            if (ubll.adduserBll(U))
            {
                Response.Write("<script>alert('You can Login Now.')</script>");
            }
            else
            {
                Response.Write("<script>alert('Error in Registeration Try Later.')</script>");
            }
        }
    }
}