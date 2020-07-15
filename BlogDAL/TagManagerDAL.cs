using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL
{
    public class TagManagerDAL
    {
        static string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        public static bool UntagPost(string tag, int postId)
        {            
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from Tbl_UntagPost where TagId="+tag+"", con);
            int count = cmd.ExecuteNonQuery();
            con.Close();
            return count > 0?true:false;           
        }

        public static int PostIsExists(int postId)
        {
            int tagId=0;
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("select TagId from Tbl_UntagPost where PostId=" + postId + "", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
              tagId = Convert.ToInt32(dr[1]);
               
            }
            dr.Close();
            return tagId;
        }
    }
}
