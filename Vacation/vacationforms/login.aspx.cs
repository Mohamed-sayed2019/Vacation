using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Vacation.Model;

namespace Vacation.vacationforms
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = TextBox1.Text;
            string password = TextBox2.Text;
            if (username == "")
            {
                Label1.Text = "insert username";
            }
            else
            {
                if (password == "")
                {
                    Label1.Text = "insert username";
                }
                else 
                {
                    using (VactionsystemEntities db = new VactionsystemEntities())
                    {
                        var log = db.Users.Where(u => u.user_name == username && u.password == password).FirstOrDefault();
                       
                        if (log == null)
                        {
                            HttpContext.Current.Response.Redirect("~/vacationforms/login.aspx");
                            Label1.Text = "";
                        }
                        else 
                        {
                            Session["log"] = log.userrole;
                            Session["user"] = log.UserId;
                            HttpContext.Current.Response.Redirect("~/vacationforms/createacation.aspx");
                            Label1.Text = "";
                        }
                        
                    }

                }
            }
           
        }

        
    }
}