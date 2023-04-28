using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FinalProject.Classes
{
    class DBSql:DbAccess
    {
        private static string conString;
        private static DBSql instance;

      
        private DBSql(string conString) : base(conString)
        { }
      
      
        public static DBSql Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DBSql(conString);// Connection string from DBSQL
                }
                return instance;
            }
        }
        public static string ConnectionString
        {
            get { return conString; }
            set
            {
                conString = @"Server=" + value + ";Database=fnalproject;Uid=root;Pwd=;"; // Change Here for diff data base.
            }
        }
        public bool insert_Worker_To_Data_Base(Worker w)
        // Function to insert the worker data to the database.
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string cmdStr = "INSERT INTO Worker (Worker_Id, Worker_Name, LastName, Birthday,Slary, Role,Stat,pass) VALUES (@Worker_Id, @Worker_Name,@LastName,@Birthday,@Slary,@Role,@Stat,@pass)";
            using (SqlCommand command = new SqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@Worker_Id", w.id);
                command.Parameters.AddWithValue("@Worker_Name", w.F_Name);
                command.Parameters.AddWithValue("@LastName", w.L_Name);
                command.Parameters.AddWithValue("@Birthday", w.age);
                command.Parameters.AddWithValue("@Slary", w.Sal);
                command.Parameters.AddWithValue("@Role", w.Role);
                command.Parameters.AddWithValue("@Stat", w.sts);
                command.Parameters.AddWithValue("@pass", w.pswrd);
                try
                {
                    base.ExecuteSimpleQuery(command);
                }
                catch
                {
                    return false;
                }
            }
            con.Close();
            return true;
        }

    }
}
