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
    public partial class listitem : Form
    {
        Pharmacy_ManagementEntities db = new Pharmacy_ManagementEntities();
        BillSell bill;
        string option;
        public listitem(string option, BillSell bill)
        {
            InitializeComponent();
            this.option = option;
            this.bill = bill;
            lv_select.FullRowSelect = true;
            lv_select.MultiSelect = false;
            lv_select.Font = new Font("Tahoma", 12);
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_find_TextChanged(object sender, EventArgs e)
        {
            if (option == "Thuốc")
            {
                List<Medicine> md = db.Medicine.Where(p => p.Medicine_Name.ToLower().Contains(tb_find.Text.Trim().ToLower())).ToList();
                Load_List(md);
                if (tb_find.Text.Trim() == "")
                    Load_List(db.Medicine.ToList());
            }
            else
            {
                List<Medical_Supplie> md = db.Medical_Supplie.Where(p => p.Medical_Supplie_Name.ToLower().Contains(tb_find.Text.Trim().ToLower())).ToList();
                Load_List_Sup(md);
                if (tb_find.Text.Trim() == "")
                    Load_List_Sup(db.Medical_Supplie.ToList());
            }
        }

        private void listitem_Load(object sender, EventArgs e)
        {
            if (option == "Thuốc")
            {
                Load_List(db.Medicine.ToList());
            }
            else Load_List_Sup(db.Medical_Supplie.ToList());
        }
        private void Load_List(List<Medicine> list)
        {
            lv_select.Items.Clear();
            ListViewItem row;
            foreach (Medicine ele in list)
            {
                row = new ListViewItem();
                row.Text = ele.Medicine_ID.ToString();
                row.SubItems.Add(ele.Medicine_Name);
                row.SubItems.Add(ele.Medicine_Quantity.ToString());
                row.SubItems.Add(string.Format("{0:0,000}", ele.Medicine_Price));
                lv_select.Items.Add(row);
            }
        }
        private void Load_List_Sup(List<Medical_Supplie> list)
        {
            lv_select.Items.Clear();
            ListViewItem row;
            foreach (Medical_Supplie ele in list)
            {
                row = new ListViewItem();
                row.Text = ele.Medical_Supplie_ID.ToString();
                row.SubItems.Add(ele.Medical_Supplie_Name);
                row.SubItems.Add(ele.Medical_Supplie_Quantity.ToString());
                row.SubItems.Add(string.Format("{0:0,000}", ele.Medical_Supplie_Price));
                lv_select.Items.Add(row);
            }
        }

        private void lv_select_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                if (option == "Thuốc")
                {
                    Medicine md = new Medicine();
                    if (lv_select.SelectedItems.Count == 0)
                        throw new Exception("Xin hãy chọn 1 mặt hàng!");
                    string md_ID = lv_select.SelectedItems[0].SubItems[0].Text;
                    md = db.Medicine.Where(p => p.Medicine_ID.ToString() == md_ID).FirstOrDefault();
                    bill.tb_id.Text = md.Medicine_ID.ToString();
                    bill.tb_name.Text = md.Medicine_Name;
                    bill.tb_price.Text = string.Format("{0:0,000}", md.Medicine_Price);
                    this.Close();
                }
                else
                {
                    Medical_Supplie md = new Medical_Supplie();
                    if (lv_select.SelectedItems.Count == 0)
                        throw new Exception("Xin hãy chọn 1 mặt hàng!");
                    string md_ID = lv_select.SelectedItems[0].SubItems[0].Text;
                    md = db.Medical_Supplie.Where(p => p.Medical_Supplie_ID.ToString() == md_ID).FirstOrDefault();
                    bill.tb_id.Text = md.Medical_Supplie_ID.ToString();
                    bill.tb_name.Text = md.Medical_Supplie_Name;
                    bill.tb_price.Text = string.Format("{0:0,000}", md.Medical_Supplie_Price);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notify");
            }
        }
    }
}
