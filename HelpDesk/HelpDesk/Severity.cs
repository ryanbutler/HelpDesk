using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
namespace HelpDesk
{
    public class Severity
    {
        #region Declarations
        public int SeverityId { get; set; }
        public string Severities { get; set; }
        #endregion

        #region Methods
        public static List<Severity> GetSeverity()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["hd"].ConnectionString);
            SqlCommand cmd = new SqlCommand("spHelpDeskGetSeverities", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            List<Severity> list = new List<Severity>();
            try
            {
                Severity s = new Severity();
                s.SeverityId = 0;
                s.Severities = "--select one--";
                list.Add(s);
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Severity severity = new Severity();
                    severity.SeverityId = Convert.ToInt32(rdr["SeverityId"]);
                    severity.Severities = rdr["Severity"].ToString();
                    list.Add(severity);
                }
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
            return list;
        }
        #endregion
    }
}