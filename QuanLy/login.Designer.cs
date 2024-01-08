
namespace QLT
{
    partial class login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_date = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_tk = new System.Windows.Forms.TextBox();
            this.tb_mk = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_hide = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lb_date);
            this.panel1.Controls.Add(this.lb_time);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 489);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.login_MouseDown);
            // 
            // label4
            // 
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 172);
            this.label4.TabIndex = 2;
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_date.Location = new System.Drawing.Point(38, 76);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(46, 17);
            this.lb_date.TabIndex = 1;
            this.lb_date.Text = "label4";
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_time.Location = new System.Drawing.Point(53, 51);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(70, 25);
            this.lb_time.TabIndex = 0;
            this.lb_time.Text = "label3";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(291, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 2);
            this.label1.TabIndex = 1;
            this.label1.Text = "__________________________________________";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(291, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(416, 2);
            this.label2.TabIndex = 2;
            this.label2.Text = "__________________________________________";
            // 
            // tb_tk
            // 
            this.tb_tk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tb_tk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_tk.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_tk.ForeColor = System.Drawing.Color.DimGray;
            this.tb_tk.Location = new System.Drawing.Point(291, 153);
            this.tb_tk.Name = "tb_tk";
            this.tb_tk.Size = new System.Drawing.Size(416, 22);
            this.tb_tk.TabIndex = 3;
            this.tb_tk.Text = "Tài khoản";
            this.tb_tk.Enter += new System.EventHandler(this.tb_tk_Enter);
            this.tb_tk.Leave += new System.EventHandler(this.tb_tk_Leave);
            // 
            // tb_mk
            // 
            this.tb_mk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tb_mk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_mk.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_mk.ForeColor = System.Drawing.Color.DimGray;
            this.tb_mk.Location = new System.Drawing.Point(291, 208);
            this.tb_mk.Name = "tb_mk";
            this.tb_mk.Size = new System.Drawing.Size(416, 22);
            this.tb_mk.TabIndex = 4;
            this.tb_mk.Text = "Mật khẩu";
            this.tb_mk.AcceptsTabChanged += new System.EventHandler(this.btn_login_Click);
            this.tb_mk.Enter += new System.EventHandler(this.tb_mk_Enter);
            this.tb_mk.Leave += new System.EventHandler(this.tb_mk_Leave);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.DimGray;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Location = new System.Drawing.Point(363, 331);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(250, 40);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            this.btn_login.Enter += new System.EventHandler(this.btn_login_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bt_exit
            // 
            this.bt_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_exit.FlatAppearance.BorderSize = 0;
            this.bt_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_exit.Image = ((System.Drawing.Image)(resources.GetObject("bt_exit.Image")));
            this.bt_exit.Location = new System.Drawing.Point(771, 0);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(26, 23);
            this.bt_exit.TabIndex = 6;
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_hide
            // 
            this.bt_hide.FlatAppearance.BorderSize = 0;
            this.bt_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_hide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_hide.Image = ((System.Drawing.Image)(resources.GetObject("bt_hide.Image")));
            this.bt_hide.Location = new System.Drawing.Point(739, 0);
            this.bt_hide.Name = "bt_hide";
            this.bt_hide.Size = new System.Drawing.Size(26, 23);
            this.bt_hide.TabIndex = 7;
            this.bt_hide.UseVisualStyleBackColor = true;
            this.bt_hide.Click += new System.EventHandler(this.bt_hide_Click);
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(411, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 50);
            this.label3.TabIndex = 8;
            this.label3.Text = "Login";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CancelButton = this.bt_exit;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_hide);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_mk);
            this.Controls.Add(this.tb_tk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "login";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.login_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tb_tk;
        public System.Windows.Forms.TextBox tb_mk;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Button bt_hide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}