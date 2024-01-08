using QLT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLy.listform
{

    public partial class InforNV : Form
    {
        public Main mains;
        qlnv ql;
        string view;
        //Account acc;
        Pharmacy_ManagementEntities db = new Pharmacy_ManagementEntities();
        public InforNV(string view,qlnv ql)
        {
            InitializeComponent();
            this.ql = ql;
            this.view = view;


        }

        private void InforNV_Load(object sender, EventArgs e)
        {
            //var listcategory = db.Staff_Category.ToList();
            //listcategory.Insert(0, new Staff_Category() { Staff_Category_Name = "Tất cả" });
            cmb_staff_category.DataSource = db.Staff_Category.ToList();
            cmb_staff_category.DisplayMember = "Staff_Category_Name";
            cmb_staff_category.ValueMember = "Staff_Category_ID";

            cmb_account_category.DataSource = db.Account_Category.ToList();
            cmb_account_category.DisplayMember = "Account_Category_Name";
            cmb_account_category.ValueMember = "Account_Category_ID";
            viewtype();
        }
        private void viewtype()
        {
            if (view == "Chỉnh sửa")
            {
                this.AcceptButton = this.bt_save;
                bt_add.Visible = false;

                tb_name.Text = ql.sta.Staff_Name;
                tb_diachi.Text = ql.sta.Staff_Address;
                tb_phone.Text = ql.sta.Staff_Phone;
                tb_salary.Text = string.Format("{0:0,000}", ql.sta.Staff_Salary);
                this.cmb_staff_category.Text = db.Staff_Category.Where(p=>p.Staff_Category_ID == ql.sta.Staff_Category_ID).Select(p=>p.Staff_Category_Name).FirstOrDefault().ToString();

                Account acc = db.Account.Where(p => p.Staff_ID == ql.sta.Staff_ID).FirstOrDefault();
                if (acc != null)
                {
                    tb_viewname.Text = db.Account.Where(p => p.Staff_ID == ql.sta.Staff_ID).Select(p => p.Account_DisplayName).FirstOrDefault().ToString();
                    tb_username.Text = db.Account.Where(p => p.Staff_ID == ql.sta.Staff_ID).Select(p => p.Account_username).FirstOrDefault().ToString();
                    tb_password.Text = db.Account.Where(p => p.Staff_ID == ql.sta.Staff_ID).Select(p => p.Account_password).FirstOrDefault().ToString();
                    string temp = db.Account.Where(p => p.Staff_ID == ql.sta.Staff_ID).Select(p => p.Account_Category_ID).FirstOrDefault().ToString();
                    cmb_account_category.Text = db.Account_Category.Where(p => p.Account_Category_ID.ToString() == temp).Select(p => p.Account_Category_Name).FirstOrDefault().ToString();
                }
                else
                {
                    tb_viewname.Text = "";
                    tb_username.Text = "";
                    tb_password.Text = "";
                    this.cmb_staff_category.Text = "";
                }
            }
            if(view == "Thêm")
            {
                this.AcceptButton = this.bt_add;
                bt_save.Visible = false;
                bt_delete.Visible = false;
               // groupBox2.Visible = false;
            }

        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            try
            {

                Staff find = db.Staff.Where(p => p.Staff_ID.ToString() == ql.sta.Staff_ID.ToString()).SingleOrDefault();
                Account fa = db.Account.Where(p => p.Staff_ID == ql.sta.Staff_ID).SingleOrDefault();
                if (find != null && fa!=null)
                {
                    decimal temp_price;
                    if (tb_name.Text.Trim() == "")
                        throw new Exception("Xin hãy nhập tên!");
                    if (!decimal.TryParse(tb_salary.Text.Trim(), out temp_price))
                        throw new Exception("Xin hãy nhập lương là số!");
                    if (temp_price < 0)
                    {
                        tb_salary.Text = "";
                        throw new Exception("Vui lòng nhập lương >= 0!");
                    }
                    find.Staff_Name = tb_name.Text.Trim();
                    find.Staff_Address = tb_diachi.Text.Trim();
                    find.Staff_Phone = tb_phone.Text.Trim();
                    find.Staff_Salary = temp_price;
                    find.Staff_Category_ID = int.Parse(cmb_staff_category.SelectedValue.ToString());

                    if (tb_viewname.Text.Trim() == "")
                        throw new Exception("Không thể bỏ trống tên hiển thị!");
                    if (tb_username.Text.Trim() == "")
                        throw new Exception("Không thể bỏ trống tên tài khoản");
                    if (tb_password.Text.Trim() == "")
                        throw new Exception("Không thể bỏ trống mật khẩu!");

                    if (db.Account.Where(p => p.Staff_ID == ql.sta.Staff_ID).Select(p => p.Account_username).FirstOrDefault() == "admin") // tài khoản gốc
                    {
                        if (cmb_account_category.Text == "User")
                            MessageBox.Show("Đây là tài khoản gốc không thể chỉnh quyền xuống user !");
                        else
                        {   if (tb_username.Text != "admin")
                            {
                                MessageBox.Show("Tên tài khoản không thể đổi !");
                                tb_username.Text = "admin";
                            }
                            else  // admin save 
                            {
                                fa.Account_DisplayName = tb_viewname.Text.Trim();
                                fa.Account_password = tb_password.Text.Trim();
                                MessageBox.Show("Lưu thành công!", "Notify");
                                db.SaveChanges();
                                this.Close();
                                ql.load_list(db.Staff.ToList());
                            }
                        }
                    }else  // tk bt ql, nv
                        {
                       
                            fa.Account_DisplayName = tb_viewname.Text.Trim();
                            fa.Account_username = tb_username.Text.Trim();
                            fa.Account_password = tb_password.Text.Trim();
                            fa.Account_Category_ID = int.Parse(cmb_account_category.SelectedValue.ToString());
                       // if (db.Account.Where(p => p.Account_username.ToLower().Trim() == tb_username.Text.ToLower().Trim()).FirstOrDefault() == null)
                        {
                            MessageBox.Show("Lưu thành công!", "Notify");
                            db.SaveChanges();
                            this.Close();
                            ql.load_list(db.Staff.ToList());
                        }
                       // else
                       // {
                         //   MessageBox.Show("Đã tồn tại tên tài khoản này!", "Thông báo");
                          //  tb_username.Text = "";
                      //  }
                         
                    }
                }
                else // chua co tk
                {
                    if(find != null && fa == null)
                    {
                        Account faa = new Account();
                        faa.Account_DisplayName = tb_viewname.Text.Trim();
                        faa.Account_username = tb_username.Text.Trim();
                        faa.Account_password = tb_password.Text.Trim();
                        faa.Account_Category_ID = int.Parse(cmb_account_category.SelectedValue.ToString());
                        faa.Staff_ID = ql.sta.Staff_ID;
                        if (db.Account.Where(p => p.Account_username.ToLower().Trim() == tb_username.Text.ToLower().Trim()).FirstOrDefault() == null)
                        {
                            MessageBox.Show("Lưu thành công!", "Notify");
                            db.Account.Add(faa);
                            db.SaveChanges();
                            this.Close();
                            ql.load_list(db.Staff.ToList());
                        }
                        else
                        {
                            MessageBox.Show("Đã tồn tại tên tài khoản này!", "Thông báo");
                            tb_username.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notify");
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            ql.load_list(db.Staff.ToList());
        }

        private void bt_add_Click(object sender, EventArgs e)
        { 
            try
            {
                Staff find = db.Staff.FirstOrDefault(p => (p.Staff_Name.Trim().ToLower() == tb_name.Text.Trim().ToLower()) && (p.Staff_Phone.ToLower() == tb_phone.Text.Trim().ToLower()));
                if (find == null)
                {
                    decimal temp_salary;
                    if(!decimal.TryParse(tb_salary.Text,out temp_salary))
                        throw new Exception("Vui lòng nhập số");
                    find = new Staff();
                    find.Staff_Name = tb_name.Text.Trim();
                    find.Staff_Address = tb_diachi.Text.Trim();
                    find.Staff_Phone = tb_phone.Text.Trim();
                    find.Staff_Salary = temp_salary;
                    find.Staff_Category_ID =int.Parse(cmb_staff_category.SelectedValue.ToString());

                    if (db.Account.Where(p => p.Account_username.ToLower().Trim() == tb_username.Text.ToLower().Trim()).FirstOrDefault() == null)
                    {
                        //groupBox2.Visible = true;
                        db.Staff.Add(find);
                        db.SaveChanges();

                        Account acc = new Account();
                        acc.Account_username = tb_username.Text.Trim();
                        acc.Account_password = tb_password.Text.Trim();
                        acc.Account_DisplayName = tb_viewname.Text.Trim();
                        acc.Account_Category_ID = int.Parse(cmb_account_category.SelectedValue.ToString());
                        int temp = db.Staff.Where(p => (p.Staff_Name.Trim().ToLower() == tb_name.Text.Trim().ToLower()) && (p.Staff_Phone.ToLower() == tb_phone.Text.Trim().ToLower())).Select(p => p.Staff_ID).FirstOrDefault();
                        acc.Staff_ID = temp;
                        if (tb_username.Text != "" || tb_password.Text != "")
                        {
                                MessageBox.Show("Lưu thành công!", "Notify");
                                db.Account.Add(acc);
                                db.SaveChanges();
                                this.Close();
                                ql.load_list(db.Staff.ToList());
                        }
                        else {
                            MessageBox.Show("Vui lòng nhập tên tài khoản hoặc mật khẩu !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đã tồn tại tên tài khoản này!", "Thông báo");
                        tb_username.Text = "";
                    }

                    ///
                }
                else MessageBox.Show("Đã tồn tại nhân viên này này", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notify");
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            try
            {
                Staff md = new Staff();
                Account acc = new Account();
               // Bill bi = new Bill();
               // int temp = db.Bill.Where(p => p.Staff_ID == ql.sta.Staff_ID).Select(p => p.Bill_ID).FirstOrDefault();
                //bi = db.Bill.Where(p=>p.Bill_ID==temp).SingleOrDefault();
                if(db.Bill.Where(p=>p.Staff_ID== ql.sta.Staff_ID).Count() == 0)
                {

                    md = db.Staff.Where(p => p.Staff_ID == ql.sta.Staff_ID).SingleOrDefault();
                    acc = db.Account.Where(p => p.Staff_ID == ql.sta.Staff_ID).SingleOrDefault();
                    if (MessageBox.Show("Bạn muốn xóa?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        db.Staff.Remove(md);
                        db.Account.Remove(acc);
                        db.SaveChanges();
                        MessageBox.Show("Xóa thành công!", "Notify");
                        this.Close();
                        ql.load_list(db.Staff.ToList());
                    }
                    else
                        return;
                }
                 else
                    MessageBox.Show("Không thể xóa vì đang tồn tại bill tên nhân viên này!", "Thông báo");
                ql.load_list(db.Staff.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notify");
            }
        }
    }
}
