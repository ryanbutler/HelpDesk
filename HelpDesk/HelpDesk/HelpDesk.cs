using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
namespace HelpDesk
{
    public class HelpDesk
    {
        #region Declarations
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public int StatusId { get; set; }
        public string Summary { get; set; }
        public int SeverityId { get; set; }
        public int DepartmentId { get; set; }
        #endregion

        #region Methods
        public void Save()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["hd"].ConnectionString);
            SqlCommand cmd = new SqlCommand("spInsertHelpDeskTicket", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parameterFName = new SqlParameter("@FName", SqlDbType.VarChar, 50);
            parameterFName.Value = FName;
            cmd.Parameters.Add(parameterFName);
            SqlParameter parameterLName = new SqlParameter("@LName", SqlDbType.VarChar, 50);
            parameterLName.Value = LName;
            cmd.Parameters.Add(parameterLName);
            SqlParameter parameterEmail = new SqlParameter("@Email", SqlDbType.VarChar, 50);
            parameterEmail.Value = Email;
            cmd.Parameters.Add(parameterEmail);
            SqlParameter parameterTitle = new SqlParameter("@Title", SqlDbType.VarChar, 50);
            parameterTitle.Value = Title;
            cmd.Parameters.Add(parameterTitle);
            SqlParameter parameterSeverityId = new SqlParameter("@SeverityID", SqlDbType.Int);
            parameterSeverityId.Value = SeverityId;
            cmd.Parameters.Add(parameterSeverityId);
            SqlParameter parameterStatusId = new SqlParameter("@StatusID", SqlDbType.Int);
            parameterStatusId.Value = StatusId;
            cmd.Parameters.Add(parameterStatusId);
            SqlParameter parameterDepartmentId = new SqlParameter("@DepartmentID", SqlDbType.Int);
            parameterDepartmentId.Value = DepartmentId;
            cmd.Parameters.Add(parameterDepartmentId);
            SqlParameter parameterSummary = new SqlParameter("@Summary", SqlDbType.VarChar, 250);
            parameterSummary.Value = Summary;
            cmd.Parameters.Add(parameterSummary);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString());
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }
        #endregion
    }
}