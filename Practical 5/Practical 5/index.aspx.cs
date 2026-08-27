using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_5
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Check login session
            if (Session["LoggedIn"] == null)
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            lblDate.Text = "Selected Date: " +
                           Calendar1.SelectedDate.ToString("dd-MM-yyyy");
        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            if (Calendar1.SelectedDate == DateTime.MinValue)
            {
                lblDate.Text = "Please select a date.";
                return;
            }

            Session["LeaveDate"] = Calendar1.SelectedDate;

            Response.Redirect("leave.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {

            Session.Clear();

            Response.Redirect("login.aspx");
        }
    }
}