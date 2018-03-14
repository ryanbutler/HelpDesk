using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelpDesk
{
    public partial class _default : System.Web.UI.Page
    {
        #region Declarations
        HelpDesk hd = new HelpDesk();
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if
                (!IsPostBack)
                {
                    LoadCombos();
                }
        }
    

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            hd.FName = fnameTB.Text;
            hd.LName = lnameTB.Text;
            hd.Email = emailTB.Text;
            hd.Title = titleTB.Text;
            hd.SeverityId = Convert.ToInt32(ddlSeverity.SelectedValue);
            hd.StatusId = Convert.ToInt32(ddlStatus.SelectedValue);
            hd.DepartmentId = Convert.ToInt32(ddlDept.SelectedValue);
            hd.Summary = summaryTB.Text;
            hd.Save();
            phForm.Visible = false;
            phSuccess.Visible = true;
        }

        protected void LoadCombos()
        {
            List<Status> statuses = Status.GetStatuses();
            ddlStatus.DataTextField = "Statuses";
            ddlStatus.DataValueField = "StatusId";
            ddlStatus.DataSource = statuses;
            ddlStatus.DataBind();

            List<Departments> dept = Departments.GetDepartments();
            ddlDept.DataTextField = "Department";
            ddlDept.DataValueField = "DepartmentId";
            ddlDept.DataSource = dept;
            ddlDept.DataBind();

            List<Severity> sev = Severity.GetSeverity();
            ddlSeverity.DataTextField = "Severities";
            ddlSeverity.DataValueField = "SeverityId";
            ddlSeverity.DataSource = sev;
            ddlSeverity.DataBind();
        }
    }
}