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
    public partial class qlloai : Form
    {
        Pharmacy_ManagementEntities db = new Pharmacy_ManagementEntities();
        public qlloai()
        {
            InitializeComponent();
        }

        private void qlloai_Load(object sender, EventArgs e)
        {
            List<Medicine_Category> listcategory = db.Medicine_Category.ToList();
            BindGrid(listcategory);
            dgv_category.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void BindGrid(List<Medicine_Category> list)
        {
            dgv_category.Rows.Clear();
            foreach (Medicine_Category item in list)
            {
                int index = dgv_category.Rows.Add();
                dgv_category.Rows[index].Cells[0].Value = item.Medicine_Category_ID;
                dgv_category.Rows[index].Cells[1].Value = item.Medicine_Category_Name;
            }
        }

        private void bt_addedit_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_name.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                Medicine_Category find = db.Medicine_Category.FirstOrDefault(p => p.Medicine_Category_Name == tb_name.Text.Trim());
                if (find == null)
                {
                    find = new Medicine_Category();
                    find.Medicine_Category_Name = tb_name.Text;
                    db.Medicine_Category.Add(find);
                    db.SaveChanges();
                    MessageBox.Show("Thêm thành công!");
                }
               
                BindGrid(db.Medicine_Category.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            Medicine_Category mc = new Medicine_Category();
           // string temp = dgv_category.SelectedRows[0].Cells[0].Value.ToString();
            mc = db.Medicine_Category.Where(p => p.Medicine_Category_ID.ToString() == lb_idshow.Text).SingleOrDefault();
            if (mc.Medicine.Count == 0)
            {
                DialogResult result = MessageBox.Show("Bạn muốn xóa loại này?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    db.Medicine_Category.Remove(mc);
                    db.SaveChanges();
                    lb_idshow.Text = "";
                    tb_name.Text = "";

                }
                else
                    return;
            }
            else
                MessageBox.Show("Không thể xóa vì đang có Thuốc loại này!", "Thông báo");
            BindGrid(db.Medicine_Category.ToList());
        }

        private void dgv_category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dgv_category.Rows[e.RowIndex].Cells[0].Value.ToString());
            Medicine_Category find = db.Medicine_Category.FirstOrDefault(p => p.Medicine_Category_ID == id);
            if (find != null)
            {
                lb_idshow.Text = find.Medicine_Category_ID.ToString();
                tb_name.Text = find.Medicine_Category_Name;

            }
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == "")
                throw new Exception("Vui lòng nhập đầy đủ thông tin");
            Medicine_Category find = db.Medicine_Category.FirstOrDefault(p => p.Medicine_Category_ID.ToString() == lb_idshow.Text);
            if (find != null)
                find.Medicine_Category_Name = tb_name.Text;
            db.SaveChanges();
            MessageBox.Show("Sửa thành công!");
            BindGrid(db.Medicine_Category.ToList());
        }

    }
}
