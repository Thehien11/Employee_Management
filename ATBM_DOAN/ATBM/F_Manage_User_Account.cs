using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBM
{
    public partial class F_Manage_User_Account : Form
    {
        public F_Manage_User_Account()
        {
            InitializeComponent();
        }

        private void F_Manage_User_Account_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            F_admin_menu f = new F_admin_menu();
            f.Show();
            this.Hide();
        }
    }
}
