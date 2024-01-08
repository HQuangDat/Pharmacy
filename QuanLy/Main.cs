using System;
using QuanLy.listform;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLy;

namespace QLT
{
    public partial class Main : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        // Account
        public string userName, password;
        private const int ACC_ADMIN = 1, ACC_USER = 2; // 1 admin 2 user
        public Main instance;
        public login login;
        public Account acc;
        Pharmacy_ManagementEntities db = new Pharmacy_ManagementEntities();
        public Main()
        {
 
            InitializeComponent();
            random = new Random();
            instance = this;
        }
        #region color button
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                    pnl_title.BackColor = color;
                    btn_home.Visible = true;
                    lb_img.Visible = false;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(47, 149, 153);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                }
            }
        }
        private void Reset()
        {
            DisableButton();
            lb_title.Text = "HOME";
            pnl_title.BackColor = Color.FromArgb(47, 149, 153);
            currentButton = null;
            btn_home.Visible = false;
            lb_img.Visible = true;
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnl_main.Controls.Add(childForm);
            this.pnl_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }
        #endregion

        #region button 
        public void btn_home_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát hệ thống quản lý?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
                Application.Exit();
        }

        private void pnl_titlemouse(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lb_time.Text = DateTime.Now.ToString("HH:mm:ss");
            lb_date.Text = DateTime.Now.ToString("dddd dd/M/yyy");
        }
        //quan ly thuoc
        private void bt_ql_Click(object sender, EventArgs e)
        {
            lb_title.Text = bt_ql.Text;
            OpenChildForm(new qlthuoc("Thuốc"), sender);
            ActivateButton(sender);
        }
        private void bt_supplie_Click(object sender, EventArgs e)
        {
            lb_title.Text = bt_supplie.Text;
            OpenChildForm(new qlthuoc("Vật tư"), sender);
            ActivateButton(sender);
        }
        // quản lý loại dành cho chủ cửa hàng
        private void bt_qlloai_Click(object sender, EventArgs e)
        {
            lb_title.Text = bt_qlloai.Text;
           OpenChildForm(new qlloai(), sender);
            ActivateButton(sender);
        }
        // quản lý nhân viên
        private void bt_qlnv_Click(object sender, EventArgs e)
        {
            lb_title.Text = bt_qlnv.Text;
            OpenChildForm(new qlnv(), sender);
            ActivateButton(sender);
        }
        //thong ke
        private void bt_tk_Click(object sender, EventArgs e)
        {
            lb_title.Text = bt_tk.Text;
            OpenChildForm(new thongke(), sender);
            ActivateButton(sender);
        }


        //ban hang
        private void bt_bh_Click(object sender, EventArgs e)
        {
            lb_title.Text = bt_bh.Text;
            OpenChildForm(new QuanLy.listform.BillSell(this), sender);
            ActivateButton(sender);
        }
        #endregion

        #region login logout
        private void Admin_Account_View()
        {
            this.Visible = true;
            this.login.Visible =false;

            //instance.ShowDialog();
           // this.login.ShowDialog();

            lb_UserName_Display.Text = "Xin chào Admin," + (from ele in db.Account where ele.Account_ID == acc.Account_ID select ele.Account_DisplayName).Single().ToString()+"             ";
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đăng xuất?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Visible = false;
                login.Visible = true;

                // instance.Close();
                //this.login.ShowDialog();
                bt_qlnv.Visible = true;
                bt_tk.Visible = true;
                bt_qlloai.Visible = true;

                login.Visible = true;
                login.tb_tk.Text = "";
                login.tb_mk.Text = "";
                login.tb_tk.Focus();
            }
        }


        private void User_Account_View()
        {
            this.bt_qlnv.Visible = false;
            this.bt_tk.Visible = false;
            this.bt_qlloai.Visible = false;


            this.Visible = true;
            this.login.Visible = false;

            //instance.ShowDialog();
            //this.login.ShowDialog();

            lb_UserName_Display.Text = "Xin chào," + (from ele in db.Account where ele.Account_ID == acc.Account_ID select ele.Account_DisplayName).Single().ToString()+ "            ";

        }
        public void check_Account()
        {
            try
            {
                acc = db.Account.Where(p => p.Account_username == userName).SingleOrDefault();
                if (acc != null)
                {
                    if (password.Equals(acc.Account_password))
                    {
                        if (acc.Account_Category_ID.Equals(ACC_ADMIN))
                            Admin_Account_View();
                        else
                            User_Account_View();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không đúng", "Thông báo");
                        login.tb_mk.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập không đúng!", "Thông báo");
                    login.tb_tk.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notify");
            }
        }
        #endregion

    }
}
