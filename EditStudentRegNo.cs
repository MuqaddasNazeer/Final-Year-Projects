using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fyp_mid_project
{
    public partial class EditStudentRegNo : Form
    {
        public EditStudentRegNo()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
      
       
    
        private void Edit_student_btn_Click(object sender, EventArgs e)
        {
            
            EditStudentMainForm ms = new EditStudentMainForm();
            this.Visible = false;
            ms.Show();
        }

        private void editTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            manage_students ms = new manage_students();
            ms.Show();
        }
    }
}
