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
    public partial class SearchStudentRegNo : Form
    {
        public SearchStudentRegNo()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            manage_students ms = new manage_students();
            ms.Show();
        }

        private void search_student_btn_Click(object sender, EventArgs e)
        {
            this.Visible=false; 
            SerchedStudentViewForm serchedStudentViewForm = new SerchedStudentViewForm();
            serchedStudentViewForm.Show();
        }
    }
}
