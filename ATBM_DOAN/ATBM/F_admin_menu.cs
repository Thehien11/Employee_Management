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

namespace ATBM
{
    public partial class F_admin_menu : Form
    {
        public F_admin_menu()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void F_admin_menu_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void phânCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýQuyềnCủaUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Manage_User_Account f = new F_Manage_User_Account();
            f.Show();
            this.Hide();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_manage_privileges_user f = new F_manage_privileges_user();
            f.Show();
            this.Hide();
        }

        private void xemDanhSáchUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show list user tai day

            F_view_list_user f = new F_view_list_user();
            f.Show();
            this.Hide();
        }

        private void xemThôngVềQuyềnCủaUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_view_privileges_user f = new F_view_privileges_user();
            f.Show();
            this.Hide();
        }

        private void quảnLýRoleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_Manage_Role f = new F_Manage_Role();
            f.Show();
            this.Hide();
        }

        private void xemThôngTinVềQuyềnCủaRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_view_privileges_role f = new F_view_privileges_role();
            f.Show();
            this.Hide();
        }

        private void quảnLýCấpQuyềnChoRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_manage_privileges_role f = new F_manage_privileges_role();
            f.Show();
            this.Hide();
        }

        private void cấpRoleChoUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_privileges_table_user f = new F_privileges_table_user();
            f.Show();
            this.Hide();
        }

        private void quảnLýQuyềnTrênBảngChoRoelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_privileges_table_role f = new F_privileges_table_role();
            f.Show();
            this.Hide();
        }

        private void cấpRoleChoUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_grant_role_to_user f = new F_grant_role_to_user();
            f.Show();
            this.Hide();
        }
    }
}
