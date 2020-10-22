using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Vacation.Model;

namespace Vacation.vacationforms
{
    public partial class createacation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["log"] == null)
            {
                HttpContext.Current.Response.Redirect("~/vacationforms/login.aspx");
            }
            else
            {
                filldata(Session["user"].ToString());
            }

        }
        public void filldata(string user)
        {

            using (VactionsystemEntities db = new VactionsystemEntities())
            {
                int x = Convert.ToInt32(user);
                var use = db.Users.Where(s => s.UserId == x).FirstOrDefault();
                ////////////////////////////////////
                Label1.Text = DateTime.Now.ToString();
                TextBox1.Text = use.UserName;
                TextBox2.Text = use.postion;
                TextBox3.Text = use.department.ToString();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            VactionsystemEntities u = new VactionsystemEntities();
            int x = Convert.ToInt32(Session["user"].ToString());
            var use = u.vactioncridits.Where(s => s.userid == x).FirstOrDefault();
            if (use == null)
            { Label3.Text = "You not have vacation cridit"; }
            else
            {
                if (float.Parse(Label2.Text) <= use.cridiet)
                {
                    using (VactionsystemEntities db = new VactionsystemEntities())
                    {
                        vaction vac = new vaction();
                        vac.userid = Convert.ToInt32(Session["user"].ToString());
                        vac.duratin = Convert.ToInt32(Label2.Text);
                        vac.Returning = Convert.ToDateTime(TextBox4.Text);
                        vac.vac_from = Convert.ToDateTime(date1.Text);
                        vac.vac_to = Convert.ToDateTime(date2.Text);
                        vac.submissiondate = DateTime.Now;
                        vac.notes = TextBox5.Text;
                        db.vactions.Add(vac);
                        db.SaveChanges();
                        Label3.Text = "Done";

                    }
                    use.cridiet = (use.cridiet - float.Parse(Label2.Text));
                    // u.vactioncridits.Add(use);
                    u.SaveChanges();
                }
                else
                {
                    Label3.Text = "Vacation is more then your cridit";
                }
            }
              
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("~/vacationforms/requstview.aspx");
        }
    }
}