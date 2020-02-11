using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SqlQueryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string connstring = "Data Source=(gold-pen\SQLEXPRESSMES);InitialCatalog = MES_Project; Integrated Security = True";
            string queryString = "Select * from FactSCH1_Kotly1";
            using (SqlConnection dbconn = new SqlConnection(connstring))
            {
                SqlCommand command = new SqlCommand(queryString, dbconn);
                dbconn.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(String.Format("{0} {1} {2} {3}", reader[0],
                        reader[1], reader[2], reader[3]));
                    }
                }
                finally
                {
                    reader.Close();
                }
            }
        }
    }
}
