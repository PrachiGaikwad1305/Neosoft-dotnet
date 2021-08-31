using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDataADO
{
    public class DisconnectedArchitecture
    {
        public static DataRowCollection GetCats(string conStr, string query, out SqlConnection connection, out SqlDataAdapter da, out DataSet ds)
        {
            using (connection= new SqlConnection(conStr))
            {
                da = new SqlDataAdapter(query, connection);// opens sql connection, fire the query, executes the query and get results
                ds = new DataSet();//to hold data from db
                int rows=da.Fill(ds, "Cats");
                if (rows != 0)
                {
                    return ds.Tables["Cats"].Rows;
                }
                else
                    throw new NullReferenceException();
            }
        }

        public static void UpdateCats(string conStr, int id,string name, out SqlConnection connection, out SqlDataAdapter da, out DataSet ds)
        {
            using (connection = new SqlConnection(conStr))
            {
                string query = "Select * from Cats";
                da = new SqlDataAdapter(query, connection);// opens sql connection, fire the query, executes the query and get results
                ds = new DataSet();//to hold data from db
                SqlCommandBuilder sb = new SqlCommandBuilder(da);
                da.Fill(ds,"Cats");
                DataTable dt = ds.Tables["Cats"];
                var data = ds.Tables["Cats"].Rows;
                foreach (DataRow row in data)
                {
                    if (Convert.ToInt32(row["Id"]) ==id)
                    {
                        dt.Rows[0]["Name"] = name;
                    }
                }
                try
                {
                    int result = da.Update(ds, "Cats");
                    if (result > 0)
                        Console.WriteLine("Success");
                    else
                        Console.WriteLine("Failed");
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }




            }
        }






    }
}
