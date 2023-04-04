
namespace ATBM
{
    partial class F_admin_menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.phânCôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemDanhSáchUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemThôngVềQuyềnCủaUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýQuyềnCủaUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cấpRoleChoUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cấpRoleChoUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemThôngTinVềQuyềnCủaRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýRoleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýCấpQuyềnChoRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýQuyềnTrênBảngChoRoelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 497);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phânCôngToolStripMenuItem,
            this.quảnLýRoleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(929, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // phânCôngToolStripMenuItem
            // 
            this.phânCôngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemDanhSáchUserToolStripMenuItem,
            this.xemThôngVềQuyềnCủaUserToolStripMenuItem,
            this.quảnLýQuyềnCủaUserToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.cấpRoleChoUserToolStripMenuItem,
            this.cấpRoleChoUserToolStripMenuItem1});
            this.phânCôngToolStripMenuItem.Name = "phânCôngToolStripMenuItem";
            this.phânCôngToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.phânCôngToolStripMenuItem.Text = "Quản lý User";
            this.phânCôngToolStripMenuItem.Click += new System.EventHandler(this.phânCôngToolStripMenuItem_Click);
            // 
            // xemDanhSáchUserToolStripMenuItem
            // 
            this.xemDanhSáchUserToolStripMenuItem.Name = "xemDanhSáchUserToolStripMenuItem";
            this.xemDanhSáchUserToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.xemDanhSáchUserToolStripMenuItem.Text = "Xem danh sách User";
            this.xemDanhSáchUserToolStripMenuItem.Click += new System.EventHandler(this.xemDanhSáchUserToolStripMenuItem_Click);
            // 
            // xemThôngVềQuyềnCủaUserToolStripMenuItem
            // 
            this.xemThôngVềQuyềnCủaUserToolStripMenuItem.Name = "xemThôngVềQuyềnCủaUserToolStripMenuItem";
            this.xemThôngVềQuyềnCủaUserToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.xemThôngVềQuyềnCủaUserToolStripMenuItem.Text = "Xem thông tin về quyền của User";
            this.xemThôngVềQuyềnCủaUserToolStripMenuItem.Click += new System.EventHandler(this.xemThôngVềQuyềnCủaUserToolStripMenuItem_Click);
            // 
            // quảnLýQuyềnCủaUserToolStripMenuItem
            // 
            this.quảnLýQuyềnCủaUserToolStripMenuItem.Name = "quảnLýQuyềnCủaUserToolStripMenuItem";
            this.quảnLýQuyềnCủaUserToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.quảnLýQuyềnCủaUserToolStripMenuItem.Text = "Quản lý tài khoản User";
            this.quảnLýQuyềnCủaUserToolStripMenuItem.Click += new System.EventHandler(this.quảnLýQuyềnCủaUserToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.quảnLýToolStripMenuItem.Text = "Quản lý quyền hệ thống cho User";
            this.quảnLýToolStripMenuItem.Click += new System.EventHandler(this.quảnLýToolStripMenuItem_Click);
            // 
            // cấpRoleChoUserToolStripMenuItem
            // 
            this.cấpRoleChoUserToolStripMenuItem.Name = "cấpRoleChoUserToolStripMenuItem";
            this.cấpRoleChoUserToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.cấpRoleChoUserToolStripMenuItem.Text = "Quản lý quyền trên bảng cho User";
            this.cấpRoleChoUserToolStripMenuItem.Click += new System.EventHandler(this.cấpRoleChoUserToolStripMenuItem_Click);
            // 
            // cấpRoleChoUserToolStripMenuItem1
            // 
            this.cấpRoleChoUserToolStripMenuItem1.Name = "cấpRoleChoUserToolStripMenuItem1";
            this.cấpRoleChoUserToolStripMenuItem1.Size = new System.Drawing.Size(315, 26);
            this.cấpRoleChoUserToolStripMenuItem1.Text = "Cấp Role cho User";
            this.cấpRoleChoUserToolStripMenuItem1.Click += new System.EventHandler(this.cấpRoleChoUserToolStripMenuItem1_Click);
            // 
            // quảnLýRoleToolStripMenuItem
            // 
            this.quảnLýRoleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemThôngTinVềQuyềnCủaRoleToolStripMenuItem,
            this.quảnLýRoleToolStripMenuItem1,
            this.quảnLýCấpQuyềnChoRoleToolStripMenuItem,
            this.quảnLýQuyềnTrênBảngChoRoelToolStripMenuItem});
            this.quảnLýRoleToolStripMenuItem.Name = "quảnLýRoleToolStripMenuItem";
            this.quảnLýRoleToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.quảnLýRoleToolStripMenuItem.Text = "Quản Lý Role";
            // 
            // xemThôngTinVềQuyềnCủaRoleToolStripMenuItem
            // 
            this.xemThôngTinVềQuyềnCủaRoleToolStripMenuItem.Name = "xemThôngTinVềQuyềnCủaRoleToolStripMenuItem";
            this.xemThôngTinVềQuyềnCủaRoleToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.xemThôngTinVềQuyềnCủaRoleToolStripMenuItem.Text = "Xem thông tin về quyền của Role";
            this.xemThôngTinVềQuyềnCủaRoleToolStripMenuItem.Click += new System.EventHandler(this.xemThôngTinVềQuyềnCủaRoleToolStripMenuItem_Click);
            // 
            // quảnLýRoleToolStripMenuItem1
            // 
            this.quảnLýRoleToolStripMenuItem1.Name = "quảnLýRoleToolStripMenuItem1";
            this.quảnLýRoleToolStripMenuItem1.Size = new System.Drawing.Size(316, 26);
            this.quảnLýRoleToolStripMenuItem1.Text = "Quản lý Role";
            this.quảnLýRoleToolStripMenuItem1.Click += new System.EventHandler(this.quảnLýRoleToolStripMenuItem1_Click);
            // 
            // quảnLýCấpQuyềnChoRoleToolStripMenuItem
            // 
            this.quảnLýCấpQuyềnChoRoleToolStripMenuItem.Name = "quảnLýCấpQuyềnChoRoleToolStripMenuItem";
            this.quảnLýCấpQuyềnChoRoleToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.quảnLýCấpQuyềnChoRoleToolStripMenuItem.Text = "Quản lý quyền hệ thống cho Role";
            this.quảnLýCấpQuyềnChoRoleToolStripMenuItem.Click += new System.EventHandler(this.quảnLýCấpQuyềnChoRoleToolStripMenuItem_Click);
            // 
            // quảnLýQuyềnTrênBảngChoRoelToolStripMenuItem
            // 
            this.quảnLýQuyềnTrênBảngChoRoelToolStripMenuItem.Name = "quảnLýQuyềnTrênBảngChoRoelToolStripMenuItem";
            this.quảnLýQuyềnTrênBảngChoRoelToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.quảnLýQuyềnTrênBảngChoRoelToolStripMenuItem.Text = "Quản lý quyền trên bảng cho Role";
            this.quảnLýQuyềnTrênBảngChoRoelToolStripMenuItem.Click += new System.EventHandler(this.quảnLýQuyềnTrênBảngChoRoelToolStripMenuItem_Click);
            // 
            // F_admin_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 532);
            this.Controls.Add(this.panel1);
            this.Name = "F_admin_menu";
            this.Text = "Admin Page";
            this.Load += new System.EventHandler(this.F_admin_menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem phânCôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýRoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemDanhSáchUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemThôngVềQuyềnCủaUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýQuyềnCủaUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cấpRoleChoUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemThôngTinVềQuyềnCủaRoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýRoleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýCấpQuyềnChoRoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cấpRoleChoUserToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýQuyềnTrênBảngChoRoelToolStripMenuItem;
    }
}