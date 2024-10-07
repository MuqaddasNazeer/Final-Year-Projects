using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace fyp_mid_project
{
    class StudentDB
    {
        public static  SqlConnection GetSqlConnection()
        {
            String ConnectionStr = @"Data Source=(local);Initial Catalog=Mid_Project;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionStr);
            try
            {
                con.Open(); 
            }
            catch(Exception ex)
            {
                MessageBox.Show("Connection Error!!!");
            }
            return con;
        }
        public static void AddStudent(student std)
        {
            SqlConnection con = GetSqlConnection();
            string SQL1 = "Insert into person values (@FirstName,@LastName,@Contact,@Email,@DateOfBirth,@Gender)";
            string SQL2 = "Insert into student (Id, RegistrationNo) values ((select Id from Person where FirstName = @FirstName AND LastName=@LastName AND Contact = @Contact AND Email = @Email), @RegistrationNo)";
            SqlCommand cmd = new SqlCommand(SQL1, con);
            SqlCommand cmd1 = new SqlCommand(SQL2, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd1.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.AddWithValue("@FirstName", std.FirstName);
            cmd.Parameters.AddWithValue("@LastName", std.LastName);
            cmd.Parameters.AddWithValue("@Email", std.Email);
            cmd.Parameters.AddWithValue("@Contact", std.Contact);
            cmd.Parameters.AddWithValue("@DateOfBirth", std.DateOfBirth);
            if (std.Gender == "Female")
            {
                cmd.Parameters.AddWithValue("@Gender", 1);
            }
            else if (std.Gender == "Male")
            {
                cmd.Parameters.AddWithValue("@Gender", 2);
            }
            cmd1.Parameters.AddWithValue("@FirstName", std.FirstName);
            cmd1.Parameters.AddWithValue("@LastName", std.LastName);
            cmd1.Parameters.AddWithValue("@Email", std.Email);
            cmd1.Parameters.AddWithValue("@Contact", std.Contact);
            cmd1.Parameters.AddWithValue("@RegistrationNo", std.RegistrationNo);
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Record SuccessFully Added!!!!");

        }
      /*  public static void DisplayAndSearch(string query,DataGridView dataGridView1)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
           

        }*/


    }
}
