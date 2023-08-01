using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;


namespace HospitalModel
{
    public class CRUD
    {
        SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ToString());

        public void InsertIntoMgmtUserRoles(string userId, string roleId)
        {
            string query = $"insert into MgmtUserRoles (UserId,RoleId) values ('{userId}','{roleId}')";
            SqlCommand cmd = new SqlCommand(query, Con);
            Con.Open();

            cmd.ExecuteNonQuery();

            Con.Close();
        }

        public string FetchUserTypeInMgmtUsers(string Email)
        {
            string query = $"insert into MgmtUsers where Email = '{Email}'";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            string UserType = "";

            foreach (DataRow drow in dt.Rows)
            {
                UserType = (drow["UserType"]).ToString();
            }
            return UserType;
        }
    }
}
