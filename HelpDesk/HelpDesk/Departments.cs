using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
namespace HelpDesk
{
    public class Departments
    {   
        #region Declarations
        public int DepartmentId { get; set; }
        public string Department { get; set; }
        #endregion

        #region Methods
        public static List<Departments> GetDepartments()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["hd"].ConnectionString);
            SqlCommand cmd = new SqlCommand("spHelpDeskGetDepartments", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            List<Departments> list = new List<Departments>();
            try
            {
                Departments d = new Departments();
                d.DepartmentId = 0;
                d.Department = "--select one--";
                list.Add(d);
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Departments departments = new Departments();
                    departments.DepartmentId = Convert.ToInt32(rdr["DepartmentId"]);
                    departments.Department = rdr["Department"].ToString();
                    list.Add(departments);
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