using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLT
{
    public partial class login : Form
    {
        private Main main;

        public login()
        {
            InitializeComponent();
           // main = new Main();
            //main.instance.Visible = false;
        }
        #region time kéo
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_time.Text = DateTime.Now.ToString("HH:mm:ss");
            lb_date.Text = DateTime.Now.ToString("dddd dd/M/yyy");
        }
        #endregion
        #region enter leave
        private void tb_tk_Enter(object sender, EventArgs e)
        {
            if(tb_tk.Text== "Tài khoản")
            {
                tb_tk.Text = "";
                tb_tk.ForeColor = Color.White;
            }
        }

        private void tb_tk_Leave(object sender, EventArgs e)
        {
            if (tb_tk.Text == "")
            {
                tb_tk.Text = "Tài khoản";
                tb_tk.ForeColor = Color.DimGray;
            }
        }

        private void tb_mk_Enter(object sender, EventArgs e)
        {
            if (tb_mk.Text == "Mật khẩu")
            {
                tb_mk.Text = "";
                tb_mk.ForeColor = Color.White;
                tb_mk.UseSystemPasswordChar = true;

            }
        }

        private void tb_mk_Leave(object sender, EventArgs e)
        {
            if (tb_mk.Text == "")
            {
                tb_mk.Text = "Mật khẩu";
                tb_mk.ForeColor = Color.DimGray;
                tb_mk.UseSystemPasswordChar = false;
            }
        }
        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát đăng nhập của hệ thống ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            Application.Exit();
        }
      
        private void bt_hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }
        #endregion
        private void btn_login_Click(object sender, EventArgs e)
        {
            main = new Main();
            main.instance.userName = tb_tk.Text.Trim();
            main.instance.password = tb_mk.Text.Trim();
            main.instance.login = this;
            main.instance.check_Account();
        }

    }
}
