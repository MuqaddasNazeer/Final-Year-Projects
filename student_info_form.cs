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
    public partial class Student_info : Form
    {
        public Student_info()
        {
            InitializeComponent();
        }

        private void Student_info_Load(object sender, EventArgs e)
        {

        }

        private void add_record_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void add_record_btn_Click_1(object sender, EventArgs e)
        {

           if(textBox1.Text.Trim().Length < 1)
            {
                MessageBox.Show("First Name is empty!!");
                
            }
            if (textBox4.Text.Trim().Length < 1)
            {
                MessageBox.Show("Last Name is empty!!");

            }
            if (textBox5.Text.Trim().Length < 1)
            {
                MessageBox.Show("Email is empty!!");

            }

            if (textBox6.Text.Trim().Length < 1)
            {
                MessageBox.Show("Plz Enter Contact No");

            }
            if (textBox3.Text.Trim().Length < 1)
            {
                MessageBox.Show("Enter date Of birth!");

            }
            if (comboBox1.Text.Trim().Length < 1)
            {
                MessageBox.Show("Select your gender!");

            }
            if (textBox2.Text.Trim().Length < 1)
            {
                MessageBox.Show("Reg No is empty!!");

            }
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cm = new SqlCommand("Insert into person values (@FirstName,@LastName,@Contact,@Email,@DateOfBirth,@Gender)", con);
                SqlCommand cmd = new SqlCommand("Insert into student (Id, RegistrationNo) values ((select Id from Person where FirstName = @FirstName AND LastName=@LastName AND Contact = @Contact AND Email = @Email), @RegistrationNo)", con);
                cm.Parameters.AddWithValue("@FirstName", textBox1.Text);
                cm.Parameters.AddWithValue("@LastName", textBox4.Text);
                cm.Parameters.AddWithValue("@Email", textBox5.Text);
                cm.Parameters.AddWithValue("@Contact", textBox6.Text);
                cm.Parameters.AddWithValue("@DateOfBirth", textBox3.Text);
                if (comboBox1.Text == "Female")
                {
                    cm.Parameters.AddWithValue("@Gender", 1);
                }
                else if (comboBox1.Text == "Male")
                {
                    cm.Parameters.AddWithValue("@Gender", 2);
                }
                cmd.Parameters.AddWithValue("@FirstName", textBox1.Text);
                cmd.Parameters.AddWithValue("@LastName", textBox4.Text);
                cmd.Parameters.AddWithValue("@Email", textBox5.Text);
                cmd.Parameters.AddWithValue("@Contact", textBox6.Text);
                cmd.Parameters.AddWithValue("@RegistrationNo", textBox2.Text);
                cm.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved");
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            this.Close();   
            manage_students ms = new manage_students();
            ms.ShowDialog();


           // student s = new student(textBox1.Text.Trim(), textBox4.Text.Trim(), textBox5.Text.Trim(), textBox6.Text.Trim(), textBox3.Text.Trim(), comboBox1.Text, textBox2.Text.Trim());
            //StudentDB.AddStudent(s);
        //    clear();
        }

        public void clear()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = comboBox1.Text = string.Empty;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            manage_students mf = new manage_students();
            this.Visible = false;
            mf.Show();


        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            manage_students ms = new manage_students();
            this.Visible = false;
            ms.Show();
        }

        private void ViewBtn_Click_1(object sender, EventArgs e)
        {
            manage_students ms = new manage_students();
            this.Visible = false;
            ms.Show();
        }
    }
}
