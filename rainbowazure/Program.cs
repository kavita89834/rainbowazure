using System;
using System.Data.SqlClient;


namespace rainbowazure
{
    internal class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader reader;
        public static string constr = "Server=tcp:kavi123.database.windows.net,1433;Initial Catalog=rainbowdb;Persist Security Info=False;User ID=kavi123;Password=Kum@12345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
         static void Main(string[] args)
        {
            try {
                con = new SqlConnection(constr);
                cmd = new SqlCommand("select * from students", con);
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("Student ID:\t \t" + reader["StudentID"]);
                    Console.WriteLine("First Name: \t" + reader["FirstName"]);
                    Console.WriteLine("Last Name: \t" + reader["LastName"]);
                    Console.WriteLine("Date Of Birth: \t" + reader["DateOfBirth"]);
                    Console.WriteLine("Gender: \t" + reader["Gender"]);
                    Console.WriteLine("Grade Level: \t" + reader["GradeLevel"]);
                    Console.WriteLine("/n");
                }
                    
            }
            catch (SqlException ex) { Console.WriteLine("Sever Error" + ex.Message); }
            catch (Exception ex) { Console.WriteLine("Error!!!" + ex.Message); }
            finally
            {
                con.Close();
                Console.ReadKey();


                Console.ReadKey();
            }
        }
    }

}


