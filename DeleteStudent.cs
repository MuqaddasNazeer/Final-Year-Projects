using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fyp_mid_project
{
    public partial class DeleteStudent : Form
    {
        public DeleteStudent()
        {
            InitializeComponent();
        }

        private void delete_student_btn_Click(object sender, EventArgs e)
        {
            

        }

        private void delete_student_btn_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim().Length < 1)
            {
                MessageBox.Show("Enter Registration No of Student whose reocrd you want to delete!!");
            }
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Delete Student Where RegistrationNo = @RegistrationNo \n Delete Person From Person where Id <> (select ID from Student)", con);
                cmd.Parameters.AddWithValue("@RegistrationNo", textBox2.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully!");
                this.Visible = false;
                manage_students ms = new manage_students();
                ms.Show();
            }
            catch (Exception ex) { 
                MessageBox.Show("Plz Write Correct Reg No");    
            }
               

           /* var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Delete person Where Id=@Id)", con);
            cmd.Parameters.AddWithValue("@Id", (textBox2.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted Successfully!");
            this.Visible = false;
            manage_students ms = new manage_students();
            ms.Show(); */
        }

        private void backbtn_Click(object sender, EventArgs e)
        {

        }

        private void backbtn_Click_1(object sender, EventArgs e)
        {
            this.Visible=false; 
            manage_students ms = new manage_students();
            ms.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deletepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void delete_lbl_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
