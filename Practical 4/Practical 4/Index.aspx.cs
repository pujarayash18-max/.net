using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_4
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
            {
                pnlResult.Visible = false;
                return;
            }

            lblStudentName.Text = txtStudentName.Text;
            lblEnrollment.Text = txtEnrollment.Text;
            lblAge.Text = TextBox1.Text;
            lblPassword.Text = TextBox2.Text;
            lblConfirmPassword.Text = TextBox3.Text;
            lblEmail.Text = txtEmail.Text;
            lblMobile.Text = txtMobile.Text;
            lblDepartment.Text = ddlDepartment.SelectedItem.Text;
            lblGender.Text = rblGender.SelectedItem.Text;

            string events = "";

            if (CheckBox1.Checked)
                events += CheckBox1.Text + ", ";

            if (CheckBox2.Checked)
                events += CheckBox2.Text + ", ";

            if (CheckBox3.Checked)
                events += CheckBox3.Text + ", ";

            if (events.EndsWith(", "))
                events = events.Substring(0, events.Length - 2);

            lblEvent.Text = events;

            if (Calendar1.SelectedDate != DateTime.MinValue)
                lblDate.Text = Calendar1.SelectedDate.ToShortDateString();
            else
                lblDate.Text = "No Date Selected";

            pnlResult.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void cvEvent_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = CheckBox1.Checked ||
                           CheckBox2.Checked ||
                           CheckBox3.Checked;
        }

        protected void cvDate_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = Calendar1.SelectedDate != DateTime.MinValue;
        }
        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentName.Text = "";
            txtEnrollment.Text = "";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            txtEmail.Text = "";
            txtMobile.Text = "";
            ddlDepartment.SelectedIndex = 0;
            rblGender.ClearSelection();

            CheckBox1.Checked = false;
            CheckBox2.Checked = false;
            CheckBox3.Checked = false;

            Calendar1.SelectedDates.Clear();

            pnlResult.Visible = false;
            lblStudentName.Text = "";
            lblEnrollment.Text = "";
            lblAge.Text = "";
            lblPassword.Text = "";
            lblConfirmPassword.Text = "";
            lblEmail.Text = "";
            lblMobile.Text = "";
            lblDepartment.Text = "";
            lblGender.Text = "";
            lblEvent.Text = "";
            lblDate.Text = "";

            Page.Validate();
        }
    }
}