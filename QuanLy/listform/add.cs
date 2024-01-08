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
    public partial class add : Form
    {
        qlthuoc ql;
        Pharmacy_ManagementEntities db = new Pharmacy_ManagementEntities();
        string view;
        public add(string view,qlthuoc ql)
        {
            InitializeComponent();
            this.view = view;
            this.ql = ql;
            ViewType();
        }

        private void bt_add_medicine_Click(object sender, EventArgs e)
        {
            try
            {

                Medicine find = db.Medicine.FirstOrDefault(p => p.Medicine_Name.Trim().ToLower() == tb_name.Text.Trim().ToLower());
                if (find == null)
                {
                   find = new Medicine();
                    checkmedicine(find);
                    db.Medicine.Add(find);
                    db.SaveChanges();
                    MessageBox.Show("Thêm thành công!", "Notify");
                    this.Close();
                    ql.Load_List(db.Medicine.ToList());
                }
                else MessageBox.Show("Đã tồn tại thuốc này", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notify");
            }
        }


        private void bt_edit_medicine_Click(object sender, EventArgs e)
        {
            try
            {
               
                Medicine find = db.Medicine.Where(p => p.Medicine_ID.ToString() == ql.med.Medicine_ID.ToString()).SingleOrDefault();

                if (find != null)
                {
                   // find = new Medicine();
                    int temp_Quantity;
                    decimal temp_price;
                    if (tb_name.Text.Trim() == "")
                        throw new Exception("Xin hãy nhập tên!");
                    if (!int.TryParse(tb_quantity.Text.Trim(), out temp_Quantity))
                        throw new Exception("Xin hãy nhập số lượng là số!");
                    if (!decimal.TryParse(tb_price.Text.Trim(), out temp_price))
                        throw new Exception("Xin hãy nhập giá là số!");
                    if(temp_price < 0)
                        throw new Exception("Xin hãy nhập giá là số dương!");
                    if (temp_Quantity <0)
                        throw new Exception("Xin hãy nhập số lượng là số dương!");
                    find.Medicine_Name = tb_name.Text.Trim();
                    find.Medicine_Category_ID = int.Parse(cmb_category.SelectedValue.ToString());
                    find.Medicine_Quantity = temp_Quantity;
                    find.Medicine_Expired = DateTime.Parse(tb_hsd.Text);
                    find.Medicine_Price = temp_price;
                    find.Medicine_NXS = tb_nsx.Text.Trim();
                   // db.Medicine.Add(find);
                    db.SaveChanges();
                    MessageBox.Show("Lưu thành công!", "Notify");
                    this.Close();
                    ql.Load_List(db.Medicine.ToList());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notify");
            }
        }

        private void bt_delete_medicine_Click(object sender, EventArgs e)
        {
            try
            {
                Medicine md = new Medicine();
                md = db.Medicine.Where(p => p.Medicine_Name.ToLower() == tb_name.Text.Trim().ToLower()).SingleOrDefault();
                if (db.Bill_Medicine.Where(p=>p.Medicine_ID==md.Medicine_ID).Count()==0)
                {
                    //Medicine find = db.Medicine.Where(p => p.Medicine_ID.ToString() == ql.med.Medicine_ID.ToString()).SingleOrDefault();
                   
                    if (MessageBox.Show("Bạn muốn xóa?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        db.Medicine.Remove(md);
                        db.SaveChanges();
                        MessageBox.Show("Xóa thành công!", "Notify");
                        tb_name.Text = "";
                        tb_nsx.Text = "";
                        tb_price.Text = "";
                        tb_quantity.Text = "";
                        //cmb_category.SelectedValue = 1;
                        this.Close();
                        ql.Load_List(db.Medicine.ToList());
                    }
                    else return;
                }else
                    MessageBox.Show("Không thể xóa vì đang có bill sử dụng thuốc này!", "Thông báo");
                ql.Load_List(db.Medicine.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notify");
            }
        }
    //exit
    private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ql.Load_List(db.Medicine.ToList());
        }

        private void add_Load(object sender, EventArgs e)
        {

            List<Medicine_Category> listcategory = db.Medicine_Category.ToList();
            categorycmb(listcategory);
        }
        private void checkmedicine(Medicine md)
        {
            int temp_Quantity;
            decimal temp_price;
            DateTime temp_expired;
            if (tb_name.Text.Trim() == "")
                throw new Exception("Xin hãy nhập tên!");

            if (!int.TryParse(tb_quantity.Text.Trim(), out temp_Quantity))
                throw new Exception("Xin hãy nhập số lượng là số!");

            if (!decimal.TryParse(tb_price.Text.Trim(), out temp_price))
                throw new Exception("Xin hãy nhập giá là số!");

            if (!DateTime.TryParse(tb_hsd.Text.Trim(), out temp_expired))
                throw new Exception("Xin hãy nhập ngày dưới dạng dd/mm/yy!");
            if (temp_price < 0)
                throw new Exception("Xin hãy nhập giá là số dương!");
            if (temp_Quantity < 0)
                throw new Exception("Xin hãy nhập số lượng là số dương!");
            md.Medicine_Name = tb_name.Text.Trim();
            md.Medicine_Category_ID = int.Parse(cmb_category.SelectedValue.ToString());
            md.Medicine_Quantity = temp_Quantity;
            md.Medicine_Expired = temp_expired;
            md.Medicine_Price = temp_price;
            md.Medicine_NXS = tb_nsx.Text.Trim();
        }
        private void categorycmb(List<Medicine_Category> listcategory)
        {
            this.cmb_category.DataSource = listcategory;
            this.cmb_category.DisplayMember = "Medicine_Category_Name";
            this.cmb_category.ValueMember = "Medicine_Category_ID";
        }
        private void ViewType()
        {
            if (view == "Thêm")
            {
                bt_delete_medicine.Visible = false;
                bt_edit_medicine.Visible = false;
                lb_idget.Visible = false;

                tb_name.Text = "";
                cmb_category.SelectedValue = 1;
                tb_quantity.Text = "";
                tb_hsd.Text = "";
                tb_price.Text = "";
                tb_nsx.Text = "";
            }
            else if (view == "Xóa")
            {
                lb_idget.Visible = false;
                bt_add_medicine.Visible = false;
                bt_edit_medicine.Visible = false;

                tb_name.Text = ql.med.Medicine_Name;
                cmb_category.SelectedValue = ql.med.Medicine_Category_ID;
                tb_quantity.Text = ql.med.Medicine_Quantity.ToString();
                tb_hsd.Text = string.Format("{0:dd/MM/yyyy}", ql.med.Medicine_Expired);
                tb_price.Text = string.Format("{0:0,000}", ql.med.Medicine_Price);
                tb_nsx.Text = ql.med.Medicine_NXS;

               // lb_idget.Text = ql.med.Medicine_ID.ToString();
                tb_name.ReadOnly = true;
                tb_hsd.ReadOnly = true;
                tb_nsx.ReadOnly = true;
                tb_price.ReadOnly = true;
                tb_quantity.ReadOnly = true;

            }
            else if(view == "Sửa")
            {
                lb_idget.Visible = false;
                bt_add_medicine.Visible = false;
                bt_delete_medicine.Visible = false;

               // lb_idget.Text = ql.med.Medicine_ID.ToString();
                tb_name.Text = ql.med.Medicine_Name;
                cmb_category.SelectedValue = ql.med.Medicine_Category_ID;
                tb_quantity.Text = ql.med.Medicine_Quantity.ToString();
                tb_hsd.Text = string.Format("{0:dd/MM/yyyy}", ql.med.Medicine_Expired);
                tb_price.Text = string.Format("{0:0,000}", ql.med.Medicine_Price);
                tb_nsx.Text = ql.med.Medicine_NXS;

            }
        }
    }
}
