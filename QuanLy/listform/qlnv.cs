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
    public partial class qlnv : Form
    {   
        InforNV ifnv;
        public Staff sta;
        Pharmacy_ManagementEntities db = new Pharmacy_ManagementEntities();
        public qlnv()
        {
            InitializeComponent();
            lv_staff.FullRowSelect = true;
            lv_staff.MultiSelect = false;
            lv_staff.Font = new Font("Tahoma", 12);
        }

        private void qlnv_Load(object sender, EventArgs e)
        {
            load_list(db.Staff.ToList());
            var listcategory = db.Staff_Category.ToList();
            listcategory.Insert(0, new Staff_Category() { Staff_Category_Name = "Tất cả" });
            cmb_staff_category.DataSource = listcategory;
            cmb_staff_category.DisplayMember = "Staff_Category_Name";
            cmb_staff_category.ValueMember = "Staff_Category_ID";
        }
        public void load_list(List<Staff> list)
        {
            lv_staff.Items.Clear();
            ListViewItem row;
            foreach (Staff staf in list)
            {
                row = new ListViewItem();
                row.Text = staf.Staff_ID.ToString();
                row.SubItems.Add(staf.Staff_Name);
                row.SubItems.Add(staf.Staff_Phone.ToString());
                row.SubItems.Add(staf.Staff_Address);
                row.SubItems.Add(string.Format("{0:0,000}",staf.Staff_Salary));
                row.SubItems.Add(db.Staff_Category.Where(p => p.Staff_Category_ID == staf.Staff_Category_ID).Select(p => p.Staff_Category_Name).FirstOrDefault());
                row.SubItems.Add(db.Account.Where(p => p.Staff_ID == staf.Staff_ID).Select(p => p.Account_username).FirstOrDefault());
                lv_staff.Items.Add(row);
            }
        }

        private void cmb_staff_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            // cmb_staff_category.DataSource = db.Staff_Category.Select(p=>p.Staff_Category_Name).ToList();
            try
            {
                List<Staff> Lists = db.Staff.Where(p => p.Staff_Category_ID.ToString().Contains(cmb_staff_category.SelectedIndex.ToString())).ToList();
                load_list(Lists);
                if (cmb_staff_category.SelectedIndex.ToString() == "0")
                    load_list(db.Staff.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notify");
            }

        }

        private void tb_find_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cmb_staff_category.SelectedIndex = 0;
                    List<Staff> Lists = db.Staff.Where(p => p.Staff_Name.ToLower().Contains(tb_find.Text.Trim().ToLower())).ToList();
                    load_list(Lists);
                if (tb_find.Text.Trim() == "")
                    load_list(db.Staff.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notify");
            }
        }

        private void bt_viewinfor_Click(object sender, EventArgs e)
        {
            string id = "";
            if (lv_staff.SelectedItems.Count != 0)
                id = lv_staff.SelectedItems[0].SubItems[0].Text;
            sta = db.Staff.Where(p => p.Staff_ID.ToString() == id).FirstOrDefault();
            if (sta == null)
                MessageBox.Show("Xin hãy chọn 1 nhân viên!", "Thông báo");
            else
            {
                ifnv = new InforNV("Chỉnh sửa", this);
                ifnv.ShowDialog();
            }
        }

        private void bt_staffadd_Click(object sender, EventArgs e)
        {
            ifnv = new InforNV("Thêm", this);
            ifnv.ShowDialog();
        }
    }
}
