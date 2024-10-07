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
    public partial class EditStudentMainForm : Form
    {
        public EditStudentMainForm()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void EditStudentMainForm_Load(object sender, EventArgs e)
        {

        }

        private void edit_record_btn_Click(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;   
            EditStudentRegNo es = new EditStudentRegNo();
            es.Visible = true;

        }
    }
}
