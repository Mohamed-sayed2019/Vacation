using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Vacation.Model;

namespace Vacation.vacationforms
{
    public partial class requstview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (VactionsystemEntities db = new VactionsystemEntities())
            {
                int x = Convert.ToInt32(Session["user"].ToString());
                //var getrequst = db.vactions.Where(u => u.User.parent == x || u.userid == x).ToList();
                var getrequst = (from a in db.vactions join b in db.Users on a.userid equals b.UserId where a.User.parent == x || a.userid == x select new 
                { b.UserName, a.vac_from,a.vac_to,a.Returning,a.duratin,a.submissiondate}).ToList() ;

                GridView1.DataSource = getrequst;
                GridView1.DataBind();

            }
        }
    }
}