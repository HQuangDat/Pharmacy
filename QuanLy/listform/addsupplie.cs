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
    public partial class addsupplie : Form
    {
        qlthuoc ql;
        Pharmacy_ManagementEntities db = new Pharmacy_ManagementEntities();
        string view;
        public addsupplie(string view, qlthuoc ql)
        {
            InitializeComponent();
            this.view = view;
            this.ql = ql;
            ViewType();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            try
            {
                Medical_Supplie find = db.Medical_Supplie.FirstOrDefault(p => p.Medical_Supplie_Name.Trim().ToLower() == tb_name.Text.Trim().ToLower());
                if (find == null)
                {
                    find = new Medical_Supplie();
                    int temp_Quantity;
                    decimal temp_price;
                    if (tb_name.Text.Trim() == "")
                        throw new Exception("Xin hãy nhập tên!");
                    if (!int.TryParse(tb_quantity.Text.Trim(), out temp_Quantity))
                        throw new Exception("Xin hãy nhập số lượng là số!");
                    if (!decimal.TryParse(tb_price.Text.Trim(), out temp_price))
                        throw new Exception("Xin hãy nhập giá là số!");
                    if (temp_price < 0)
                        throw new Exception("Xin hãy nhập giá là số dương!");
                    if (temp_Quantity < 0)
                        throw new Exception("Xin hãy nhập số lượng là số dương!");
                    find.Medical_Supplie_Name = tb_name.Text.Trim();
                    find.Medical_Supplie_Quantity = temp_Quantity;
                    find.Medical_Supplie_Price = temp_price;
                    db.Medical_Supplie.Add(find);
                    db.SaveChanges();
                    MessageBox.Show("Thêm thành công!", "Notify");
                    this.Close();
                    ql.Load_List_Supplie(db.Medical_Supplie.ToList());
                }
                else MessageBox.Show("Đã tồn tại vật tư này", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notify");
            }
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            try
            {
                Medical_Supplie find = db.Medical_Supplie.Where(p => p.Medical_Supplie_ID.ToString() == ql.ms.Medical_Supplie_ID.ToString()).SingleOrDefault();
                if (find != null)
                {
                    //find = new Medical_Supplie();
                    int temp_Quantity;
                    decimal temp_price;
                    if (tb_name.Text.Trim() == "")
                        throw new Exception("Xin hãy nhập tên!");
                    if (!int.TryParse(tb_quantity.Text.Trim(), out temp_Quantity))
                        throw new Exception("Xin hãy nhập số lượng là số!");
                    if (!decimal.TryParse(tb_price.Text.Trim(), out temp_price))
                        throw new Exception("Xin hãy nhập giá là số!");
                    if (temp_price < 0)
                        throw new Exception("Xin hãy nhập giá là số dương!");
                    if (temp_Quantity < 0)
                        throw new Exception("Xin hãy nhập số lượng là số dương!");
                    find.Medical_Supplie_Name = tb_name.Text.Trim();
                    find.Medical_Supplie_Quantity = temp_Quantity;
                    find.Medical_Supplie_Price = temp_price;
                    //db.Medical_Supplie.Add(find);
                    db.SaveChanges();
                    MessageBox.Show("Sửa thành công!", "Notify");
                    this.Close();
                    ql.Load_List_Supplie(db.Medical_Supplie.ToList());
                }
                else MessageBox.Show("Đã tồn tại vật tư này", "Thông báo");
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
                Medical_Supplie md = new Medical_Supplie();
                //Medical_Supplie find  = db.Medical_Supplie.Where(p => p.Medical_Supplie_ID.ToString() == ql.ms.Medical_Supplie_ID.ToString()).SingleOrDefault();
                md = db.Medical_Supplie.Where(p => p.Medical_Supplie_Name.ToLower() == tb_name.Text.Trim().ToLower()).SingleOrDefault();
                if (db.Bill_Supplie.Where(p=>p.Medical_Supplie_ID == md.Medical_Supplie_ID).Count()==0) {
                    if (MessageBox.Show("Bạn muốn xóa?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        db.Medical_Supplie.Remove(md);
                        db.SaveChanges();
                        MessageBox.Show("Xóa thành công!", "Notify");
                        tb_name.Text = "";
                        tb_price.Text = "";
                        tb_quantity.Text = "";
                        this.Close();
                        ql.Load_List_Supplie(db.Medical_Supplie.ToList());
                    }
                    else return;
                }
                else MessageBox.Show("Không thể xóa vì đang có bill sử dụng vật phẩm này!", "Thông báo");
                ql.Load_List_Supplie(db.Medical_Supplie.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notify");
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            ql.Load_List_Supplie(db.Medical_Supplie.ToList());
        }
        private void ViewType()
        {
            if (view == "Thêm")
            {
                bt_delete.Visible = false;
                bt_edit.Visible = false;

                tb_name.Text = "";
                tb_quantity.Text = "";
                tb_price.Text = "";
            }
            else if (view == "Xóa")
            {
                bt_add.Visible = false;
                bt_edit.Visible = false;

                tb_name.Text = ql.ms.Medical_Supplie_Name;
                tb_quantity.Text = ql.ms.Medical_Supplie_Quantity.ToString();
                tb_price.Text = string.Format("{0:0,000}",ql.ms.Medical_Supplie_Price);

                // lb_idget.Text = ql.med.Medicine_ID.ToString();
                tb_name.ReadOnly = true;
                tb_price.ReadOnly = true;
                tb_quantity.ReadOnly = true;

            }
            else if (view == "Sửa")
            {
                bt_add.Visible = false;
                bt_delete.Visible = false;

                tb_name.Text = ql.ms.Medical_Supplie_Name;
                tb_quantity.Text = ql.ms.Medical_Supplie_Quantity.ToString();
                tb_price.Text = string.Format("{0:0,000}", ql.ms.Medical_Supplie_Price);

            }
        }
        }
}
