using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bll;
using approps;
using System.Data;

namespace E_lib
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            userbll ubll = new userbll();
            User U = new User();
            U.Rollno = Convert.ToInt32(txtRollNo.Text);
            U.Password = txtPassword.Text;
            DataTable dt = ubll.searchuserbll(U);
            if (dt != null)
            {
                if (txtPassword.Text.Equals(dt.Rows[0]["password"].ToString()))
                {
                    Session["rollno"] = Convert.ToInt32(txtRollNo.Text);
                    //Server.Transfer("HomeForm.aspx");
                    Response.Redirect("HomeForm.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Incorrect Password');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Not Registered');</script>");
            }
        }
    }
}