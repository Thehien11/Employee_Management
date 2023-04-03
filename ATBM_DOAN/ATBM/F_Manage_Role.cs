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
    public partial class F_Manage_Role : Form
    {
        public F_Manage_Role()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            F_admin_menu f = new F_admin_menu();
            f.Show();
            this.Hide();
        }
    }
}
