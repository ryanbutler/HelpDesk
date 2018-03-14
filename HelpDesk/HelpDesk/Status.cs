using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
namespace HelpDesk
{
    public class Status
    {
        #region Declarations
        public int StatusId { get; set; }
        public string Statuses { get; set; }
        #endregion

        #region Methods
        public static List<Status> GetStatuses()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["hd"].ConnectionString);
            SqlCommand cmd = new SqlCommand("spHelpDeskGetStatuses", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            List<Status> list = new List<Status>();
            try
            {
                Status s = new Status();
                s.StatusId = 0;
                s.Statuses = "--select one--";
                list.Add(s);
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Status statuses = new Status();
                    statuses.StatusId = Convert.ToInt32(rdr["StatusId"]);
                    statuses.Statuses = rdr["Status"].ToString();
                    list.Add(statuses);
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