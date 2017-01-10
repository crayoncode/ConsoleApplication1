using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connection = "Data Source=(local);Initial Catalog=Student;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connection);
            //SqlCommand command = conn.CreateCommand();
            //command.CommandText = "select * from Person";
            //conn.Open();
            //command.ExecuteNonQuery();
            //conn.Close();
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Person", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            conn.Close();
            Console.ReadKey();
        }
    }
}
