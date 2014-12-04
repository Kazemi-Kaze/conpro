using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conpro
{
     static class sqlcn
    {
         
          // static string connectionString = "Data Source=(localdb)\\ProjectsV12;Initial Catalog=Database1;Integrated Security=True";
           // SqlConnection conn = new SqlConnection(connectionString);


         public static DataTable GetSampleData()
         {
             SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV12;Initial Catalog=Database1;Integrated Security=True");
             SqlCommand cmd = new SqlCommand("Select * from users", connection);
             SqlDataAdapter da = new SqlDataAdapter(cmd);
             DataSet ds = new DataSet();

             try
             {
                 connection.Open();
                 da.Fill(ds);
             }
          
             finally
             {
                 if (connection.State == System.Data.ConnectionState.Open)
                     connection.Close();
             }

             return ds.Tables[0];
         }
         
    }
}
