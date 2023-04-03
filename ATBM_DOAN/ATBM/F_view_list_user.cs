using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using ATBM;


namespace ATBM
{
    public partial class F_view_list_user : Form
    {
        public F_view_list_user()
        {
            InitializeComponent();
        }

        private void F_view_list_user_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_admin_menu f = new F_admin_menu();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            OracleDataAdapter adp = new OracleDataAdapter("SELECT * FROM dba_sys_privs", con);
            */
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
