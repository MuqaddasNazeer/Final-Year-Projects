using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fyp_mid_project
{
    public partial class manage_students : Form
    {
        public manage_students()
        {
            InitializeComponent();
            dataGridView1.ForeColor = Color.Black;
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select RegistrationNo,FirstName,LastName,DateOfBirth,Gender, Email ,Contact from student join person on student.id=person.id", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

       
        private void addstudentBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Student_info si = new Student_info();   
            si.Visible = true;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DeleteStudent ds = new DeleteStudent();
            ds.Show();
           
        }

        private void BackBtn_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Mian_From mf = new Mian_From();
            mf.Visible = true;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
           this.Visible = false;
           EditStudentRegNo mf = new EditStudentRegNo();
           mf.Visible = true;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            this.Visible=false; 
            SearchStudentRegNo ss= new SearchStudentRegNo();    
            ss.Visible = true;
        }
    }
}
