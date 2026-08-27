using System;

namespace Practical_5
{
    public partial class leave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedIn"] == null)
            {
                Response.Redirect("login.aspx");
            }

            if (!IsPostBack)
            {
                if (Session["LeaveDate"] != null)
                {
                    DateTime leaveDate =
                        (DateTime)Session["LeaveDate"];

                    lblDate.Text =
                        leaveDate.ToString("dd-MM-yyyy");
                }
                else
                {
                    Response.Redirect("index.aspx");
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Session["LeaveDate"] == null)
            {
                Response.Redirect("index.aspx");
                return;
            }

            DateTime leaveDate =
                (DateTime)Session["LeaveDate"];

            resultName.Text =
                Server.HtmlEncode(txtName.Text);

            resultDate.Text =
                leaveDate.ToString("dd-MM-yyyy");

            resultLeaveType.Text =
                Server.HtmlEncode(ddlLeaveType.SelectedValue);

            resultReason.Text =
                Server.HtmlEncode(txtReason.Text);

            resultWorkLoad.Text =
                Server.HtmlEncode(txtWorkLoad.Text);

            pnlResult.Visible = true;
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {

            Session.Clear();

            Response.Redirect("login.aspx");
        }
    }
}