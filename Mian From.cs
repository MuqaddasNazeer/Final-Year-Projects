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
    public partial class Mian_From : Form
    {
        public Mian_From()
        {
            InitializeComponent();
        }

        private void st_lbl_Click(object sender, EventArgs e)
        {

        }

        private void manag_student_btn_Click(object sender, EventArgs e)
        {
           // Student_info   si = new Student_info();
           manage_students si = new manage_students();
            this.Visible = false;
            si.Visible = true;  
        }
    }
}
