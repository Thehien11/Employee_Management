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
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ATBM
{
    public partial class F_view_list_user : Form
    {
        public F_view_list_user()
        {
            InitializeComponent();
        }

        public string _connectionString;


        private void connect_db()
        {
            OracleConnection con = new OracleConnection(@_connectionString);
            con.Open();
            string sql = "SELECT * FROM DBA_USERS";  // lay het du lieu trong bang sinh vien
            OracleCommand com = new OracleCommand(sql, con); //bat dau truy van
            com.CommandType = CommandType.Text;
            OracleDataAdapter adp = new OracleDataAdapter(com);
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            adp.Fill(dt);  // đổ dữ liệu vào kho
            //con.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }
        private void F_view_list_user_Load(object sender, EventArgs e)
        {
            connect_db();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
