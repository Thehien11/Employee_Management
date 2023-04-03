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
    public partial class F_grant_role_to_user : Form
    {
        public F_grant_role_to_user()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            F_admin_menu f = new F_admin_menu();
            f.Show();
            this.Hide();
        }
    }
}
