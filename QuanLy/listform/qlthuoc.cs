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
    public partial class qlthuoc : Form
    {
        Pharmacy_ManagementEntities db = new Pharmacy_ManagementEntities();
        add medadd;
        addsupplie addsup;
        public Medicine med;
        public Medical_Supplie ms;
        string option;
        public qlthuoc(string option)
        {
            InitializeComponent();
            lv_medicine.FullRowSelect = true;
            lv_medicine.MultiSelect = false;
            this.option = option;
            this.tscmb_find_category.Visible = false;
        }

        private void sốLượngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (option == "Thuốc")
                {
                    List<Medicine> list = new List<Medicine>();
                    list = db.Medicine.OrderBy(p => p.Medicine_Quantity).ToList();
                    //list = db.Medicine.OrderByDescending(p => p.Medicine_Quantity).ToList();
                    Load_List(list);
                }else
                {
                    List<Medical_Supplie> list = new List<Medical_Supplie>();
                    list = db.Medical_Supplie.OrderBy(p => p.Medical_Supplie_Quantity).ToList();
                    //list = db.Medicine.OrderByDescending(p => p.Medicine_Quantity).ToList();
                    Load_List_Supplie(list);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Notify");
            }
        }
        public void Load_List(List<Medicine> medList)
        {
            lv_medicine.Items.Clear();
            ListViewItem row;
            foreach (Medicine med in medList)
            {
                row = new ListViewItem();
                row.Text = med.Medicine_ID.ToString();
                row.SubItems.Add(med.Medicine_Name);
                row.SubItems.Add(db.Medicine_Category.Where(p => p.Medicine_Category_ID == med.Medicine_Category_ID).Select(p => p.Medicine_Category_Name).FirstOrDefault());
                //row.SubItems.Add(((double)med.Medicine_Price).ToString());
                row.SubItems.Add(string.Format("{0:0,000}", med.Medicine_Price));
                row.SubItems.Add(string.Format("{0:dd/MM/yyyy}", med.Medicine_Expired));
                row.SubItems.Add(med.Medicine_Quantity.ToString());
                row.SubItems.Add(med.Medicine_NXS);
                lv_medicine.Items.Add(row);
                
            }
        }
        public void Load_List_Supplie(List<Medical_Supplie> supList)
        {
            lv_medicine.Items.Clear();
            ListViewItem row;
            foreach(Medical_Supplie sup in supList)
            {
                row = new ListViewItem();
                row.Text = sup.Medical_Supplie_ID.ToString();
                row.SubItems.Add(sup.Medical_Supplie_Name);
                row.SubItems.Add(sup.Medical_Supplie_Quantity.ToString());
                row.SubItems.Add(string.Format("{0:0,000}",sup.Medical_Supplie_Price));
                lv_medicine.Items.Add(row);
            }
        }

        private void qlthuoc_Load(object sender, EventArgs e)
        {

            lv_medicine.View = View.Details;
            if(option== "Thuốc")
            {
                this.tscmb_find_category.Visible = true;
                lv_medicine.Columns.Add("Mã thuốc");
                lv_medicine.Columns.Add("Tên Thuốc");
                lv_medicine.Columns.Add("Loại thuốc");
                lv_medicine.Columns.Add("Giá");
                lv_medicine.Columns.Add("Hạn sử dụng");
                lv_medicine.Columns.Add("Số lượng");
                lv_medicine.Columns.Add("Nước xuất bản");
                lv_medicine.Columns[0].Width = 80;
                lv_medicine.Columns[1].Width = 250;
                lv_medicine.Columns[2].Width = 250;
                lv_medicine.Columns[3].Width = 150;
                lv_medicine.Columns[4].Width = 120;
                lv_medicine.Columns[5].Width = 90;
                lv_medicine.Columns[6].Width = 150;
                lv_medicine.Font = new Font("Tahoma", 12);
                Load_List(db.Medicine.ToList());
            }else
            {
                lv_medicine.Columns.Add("Mã vật tư");
                lv_medicine.Columns.Add("Tên vật tư");
                lv_medicine.Columns.Add("Số lượng");
                lv_medicine.Columns.Add("Giá");
                lv_medicine.Columns[0].Width = 120;
                lv_medicine.Columns[1].Width = 300;
                lv_medicine.Columns[2].Width = 150;
                lv_medicine.Columns[3].Width = 200;
                lv_medicine.Font = new Font("Tahoma", 12);
                Load_List_Supplie(db.Medical_Supplie.ToList());
            }
            var listcategory = db.Medicine_Category.ToList();
            listcategory.Insert(0, new Medicine_Category() { Medicine_Category_Name = "Tất cả" });
            tscmb_find_category.ComboBox.DataSource = listcategory;
            tscmb_find_category.ComboBox.DisplayMember = "Medicine_Category_Name";
            tscmb_find_category.ComboBox.ValueMember = "Medicine_Category_ID";

        }

        private void tsbt_add_Click(object sender, EventArgs e)
        {
            if (option == "Thuốc")
            {
                medadd = new add("Thêm", this);
                medadd.ShowDialog();
            }else
            {
                addsup = new addsupplie("Thêm", this);
                addsup.ShowDialog();
            }
        }

        private void tstb_find_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (option == "Thuốc")
                {
                    tscmb_find_category.SelectedIndex = 0;
                    List<Medicine> Lists = db.Medicine.Where(p => p.Medicine_Name.ToLower().Contains(tstb_find.Text.Trim().ToLower())).ToList();
                    Load_List(Lists);
                    if (tstb_find.Text.Trim() == "")
                        Load_List(db.Medicine.ToList()); ;
                }
                else
                {
                    List<Medical_Supplie> Lists = db.Medical_Supplie.Where(p => p.Medical_Supplie_Name.ToLower().Contains(tstb_find.Text.Trim().ToLower())).ToList();
                    Load_List_Supplie(Lists);
                    if (tstb_find.Text.Trim() == "")
                        Load_List_Supplie(db.Medical_Supplie.ToList()); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notify");
            }
        }

        private void tsbt_delete_Click(object sender, EventArgs e)
        {
            if (option == "Thuốc")
            {
                string id = "";
                if (lv_medicine.SelectedItems.Count != 0)
                    id = lv_medicine.SelectedItems[0].SubItems[0].Text;
                med = db.Medicine.Where(p => p.Medicine_ID.ToString() == id).FirstOrDefault();
                if (med == null)
                    MessageBox.Show("Xin hãy chọn thuốc!", "Thông báo");
                else
                {
                    medadd = new add("Xóa", this);
                    medadd.ShowDialog();
                }
            }
            else
            {
                string id = "";
                if (lv_medicine.SelectedItems.Count != 0)
                    id = lv_medicine.SelectedItems[0].SubItems[0].Text;
                ms = db.Medical_Supplie.Where(p => p.Medical_Supplie_ID.ToString() == id).FirstOrDefault();
                if (ms == null)
                    MessageBox.Show("Xin hãy chọn vật tư!", "Thông báo");
                else
                {
                    addsup = new addsupplie("Xóa", this);
                    addsup.ShowDialog();
                }
            }
        }

        private void tsbt_edit_Click(object sender, EventArgs e)
        {
            if (option == "Thuốc")
            {
                string id = "";
                if (lv_medicine.SelectedItems.Count != 0)
                    id = lv_medicine.SelectedItems[0].SubItems[0].Text;
                med = db.Medicine.Where(p => p.Medicine_ID.ToString() == id).FirstOrDefault();
                if (med == null)
                    MessageBox.Show("Xin hãy chọn thuốc!", "Thông báo");
                else
                {
                    medadd = new add("Sửa", this);
                    medadd.ShowDialog();
                }
            }
            else
            {
                string id = "";
                if (lv_medicine.SelectedItems.Count != 0)
                    id = lv_medicine.SelectedItems[0].SubItems[0].Text;
                ms = db.Medical_Supplie.Where(p => p.Medical_Supplie_ID.ToString() == id).FirstOrDefault();
                if (ms == null)
                    MessageBox.Show("Xin hãy chọn vật tư!", "Thông báo");
                else
                {
                    addsup = new addsupplie("Sửa", this);
                    addsup.ShowDialog();
                }
            }

        }

        private void giáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (option == "Thuốc")
                {
                    List<Medicine> list = new List<Medicine>();
                    list = db.Medicine.OrderBy(p => p.Medicine_Price).ToList();
                    // list = db.Medicine.OrderByDescending(p => p.Medicine_Price).ToList();
                    Load_List(list);
                }
                else
                {
                    List<Medical_Supplie> list = new List<Medical_Supplie>();
                    list = db.Medical_Supplie.OrderBy(p => p.Medical_Supplie_Price).ToList();
                    // list = db.Medicine.OrderByDescending(p => p.Medicine_Price).ToList();
                    Load_List_Supplie(list);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notify");
            }
        }

        private void sốLượngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (option == "Thuốc")
                {
                    List<Medicine> list = new List<Medicine>();
                    //list = db.Medicine.OrderBy(p => p.Medicine_Quantity.ToList();
                    list = db.Medicine.OrderByDescending(p => p.Medicine_Quantity).ToList();
                    Load_List(list);
                }else
                {
                    List<Medical_Supplie> list = new List<Medical_Supplie>();
                    //list = db.Medicine.OrderBy(p => p.Medicine_Quantity.ToList();
                    list = db.Medical_Supplie.OrderByDescending(p => p.Medical_Supplie_Quantity).ToList();
                    Load_List_Supplie(list);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notify");
            }
        }

        private void giáToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (option == "Thuốc")
                {
                    List<Medicine> list = new List<Medicine>();
                    // list = db.Medicine.OrderBy(p => p.Medicine_Price).ToList();
                    list = db.Medicine.OrderByDescending(p => p.Medicine_Price).ToList();
                    Load_List(list);
                }
                else
                {
                    List<Medical_Supplie> list = new List<Medical_Supplie>();
                    // list = db.Medicine.OrderBy(p => p.Medicine_Price).ToList();
                    list = db.Medical_Supplie.OrderByDescending(p => p.Medical_Supplie_Price).ToList();
                    Load_List_Supplie(list);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notify");
            }
        }

        private void tsbt_reset_Click(object sender, EventArgs e)
        {
            //List<Medicine> list = new List<Medicine>();
            if (option == "Thuốc")
            {
                Load_List(db.Medicine.ToList());
                tscmb_find_category.SelectedIndex = 0;
            }
            else
                Load_List_Supplie(db.Medical_Supplie.ToList());
        }

        private void tscmb_find_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (option == "Thuốc")
                {
                    List<Medicine> lists = new List<Medicine>();
                    if (tscmb_find_category.Text == "Tất cả")
                        lists = db.Medicine.ToList();
                    else
                    {
                        int id = db.Medicine_Category.Where(p => p.Medicine_Category_Name == tscmb_find_category.Text).Select(p => p.Medicine_Category_ID).FirstOrDefault();
                        lists = db.Medicine.Where(p => p.Medicine_Category_ID == id).ToList();

                    }
                    Load_List(lists);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notify");
            }
        }
    }
}
