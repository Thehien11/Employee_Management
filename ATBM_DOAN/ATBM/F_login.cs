using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace ATBM
{
    public partial class F_login : Form
    {
        public string connectionString;
        public F_login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {//để đăng nhập sys trên oracle thì trên đây phải nhập là system !!!!!!
            try
            {

                connectionString = "uid=" + texb_dangnhap.Text + ";password=" + texb_pass.Text;
                OracleConnection con = new OracleConnection(@connectionString);
                con.Open();
                F_admin_menu f = new F_admin_menu();
                f._connectionString = connectionString;
                f.Show();
                con.Close();

                this.Hide();

            }
                
            catch
            {
                MessageBox.Show("Sai mật khẩu hoặc tài khoản", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void F_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn muốn thoát chương trình ?","Thông báo",MessageBoxButtons.OKCancel) !=System.Windows.Forms.DialogResult.OK)
             {
                e.Cancel = true;
            }

        }

        private void texb_dangnhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void texb_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_dangnhap_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
