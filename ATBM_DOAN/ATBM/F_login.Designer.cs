﻿
namespace ATBM
{
    partial class F_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_login));
            this.Login = new System.Windows.Forms.Panel();
            this.texb_dangnhap = new System.Windows.Forms.TextBox();
            this.lb_dangnhap = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.texb_pass = new System.Windows.Forms.TextBox();
            this.lb_pass = new System.Windows.Forms.Label();
            this.bt_login = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Login.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Controls.Add(this.texb_dangnhap);
            this.Login.Controls.Add(this.lb_dangnhap);
            this.Login.Location = new System.Drawing.Point(30, 182);
            this.Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(507, 56);
            this.Login.TabIndex = 0;
            this.Login.Tag = "";
            this.Login.Paint += new System.Windows.Forms.PaintEventHandler(this.Login_Paint);
            // 
            // texb_dangnhap
            // 
            this.texb_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texb_dangnhap.Location = new System.Drawing.Point(139, 14);
            this.texb_dangnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.texb_dangnhap.Name = "texb_dangnhap";
            this.texb_dangnhap.Size = new System.Drawing.Size(333, 27);
            this.texb_dangnhap.TabIndex = 1;
            this.texb_dangnhap.TextChanged += new System.EventHandler(this.texb_dangnhap_TextChanged);
            // 
            // lb_dangnhap
            // 
            this.lb_dangnhap.AutoSize = true;
            this.lb_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dangnhap.Location = new System.Drawing.Point(20, 14);
            this.lb_dangnhap.Name = "lb_dangnhap";
            this.lb_dangnhap.Size = new System.Drawing.Size(94, 20);
            this.lb_dangnhap.TabIndex = 0;
            this.lb_dangnhap.Text = "Username";
            this.lb_dangnhap.Click += new System.EventHandler(this.lb_dangnhap_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.texb_pass);
            this.panel2.Controls.Add(this.lb_pass);
            this.panel2.Location = new System.Drawing.Point(30, 265);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(507, 52);
            this.panel2.TabIndex = 1;
            // 
            // texb_pass
            // 
            this.texb_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texb_pass.Location = new System.Drawing.Point(139, 16);
            this.texb_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.texb_pass.Name = "texb_pass";
            this.texb_pass.Size = new System.Drawing.Size(333, 27);
            this.texb_pass.TabIndex = 2;
            this.texb_pass.UseSystemPasswordChar = true;
            this.texb_pass.TextChanged += new System.EventHandler(this.texb_pass_TextChanged);
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pass.Location = new System.Drawing.Point(20, 16);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(91, 20);
            this.lb_pass.TabIndex = 0;
            this.lb_pass.Text = "Password";
            // 
            // bt_login
            // 
            this.bt_login.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_login.Location = new System.Drawing.Point(132, 367);
            this.bt_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(127, 43);
            this.bt_login.TabIndex = 3;
            this.bt_login.Text = "Login";
            this.bt_login.UseVisualStyleBackColor = false;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_Exit.Location = new System.Drawing.Point(313, 367);
            this.bt_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(128, 43);
            this.bt_Exit.TabIndex = 4;
            this.bt_Exit.Text = "Exit";
            this.bt_Exit.UseVisualStyleBackColor = false;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(237, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 114);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // F_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 446);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Login);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "F_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F_login_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Login;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_dangnhap;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.TextBox texb_dangnhap;
        private System.Windows.Forms.TextBox texb_pass;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

