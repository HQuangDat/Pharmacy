using QLT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy.listform
{
    public partial class BillSell : Form
    {
        Main main;
        Pharmacy_ManagementEntities db = new Pharmacy_ManagementEntities();
        public BillSell(Main main)
        {
            InitializeComponent();
            this.main = main;
            lv_bill.FullRowSelect = true;
            lv_bill.MultiSelect = false;
            lv_bill.Font = new Font("Tahoma", 12);
            lb_temp.Visible = false;
            lb_idbill.Visible = false;
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            cmb_type.Items.Add("Thuốc");
            cmb_type.Items.Add("Vật dụng y tế");
            cmb_type.SelectedIndex = 0;
            tb_nv.Text = db.Staff.Where(p => p.Staff_ID == main.acc.Staff_ID).Select(p => p.Staff_Name).FirstOrDefault();
        }

        private void bt_select_Click(object sender, EventArgs e)
        {
            listitem li = new listitem(cmb_type.Text,this);
            li.ShowDialog();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem lvi;
                int temp_Quantity = 0;
                if (!int.TryParse(tb_quantity.Text.Trim(), out temp_Quantity))
                {
                    tb_quantity.Text = "";
                    throw new Exception("Xin hãy nhập số lượng");
                }
                else
                {
                    if (temp_Quantity <= 0)
                    {
                        tb_quantity.Text = "";
                        throw new Exception("Xin hãy nhập lại số lượng!");
                    }
                    if (lv_bill.Items.Count == 0)
                    {
                        lvi = new ListViewItem();
                        lvi.Text = tb_id.Text;
                        lvi.SubItems.Add(tb_name.Text);
                        lvi.SubItems.Add(tb_quantity.Text);
                        lvi.SubItems.Add(string.Format("{0:0,000}",tb_price.Text));
                        lvi.SubItems.Add(string.Format("{0:0,000}",(int.Parse(tb_quantity.Text) * double.Parse(tb_price.Text))));
                        if(cmb_type.Text== "Thuốc")
                            if (int.Parse(db.Medicine.Where(p => p.Medicine_Name.ToLower() == tb_name.Text.ToLower()).Select(p => p.Medicine_Quantity).FirstOrDefault().ToString()) < int.Parse(tb_quantity.Text))
                            {
                            tb_quantity.Text = "";
                            MessageBox.Show("Số lượng quá lớn hoặc đã hết hàng vui lòng chọn loại hàng khác!");
                        }
                        else 
                        { 
                            lv_bill.Items.Add(lvi);
                        }
                        if(cmb_type.Text== "Vật dụng y tế")
                            if (int.Parse(db.Medical_Supplie.Where(p => p.Medical_Supplie_Name.ToLower() == tb_name.Text.ToLower()).Select(p => p.Medical_Supplie_Quantity).FirstOrDefault().ToString()) < int.Parse(tb_quantity.Text))
                            {
                            tb_quantity.Text = "";
                                MessageBox.Show("Số lượng quá lớn hoặc đã hết hàng vui lòng chọn loại hàng khác!");
                            }
                        else
                        {
                            lv_bill.Items.Add(lvi);
                        }
                    }
                    else
                    {
                        int temp = checkid(tb_name.Text);
                            if (temp != -1)
                            {
                            if (cmb_type.Text == "Thuốc")
                                if (int.Parse(db.Medicine.Where(p => p.Medicine_Name.ToLower() == tb_name.Text.ToLower()).Select(p => p.Medicine_Quantity).FirstOrDefault().ToString()) < int.Parse(tb_quantity.Text))
                                {
                                    tb_quantity.Text = "";
                                    MessageBox.Show("Số lượng quá lớn hoặc đã hết hàng vui lòng chọn loại hàng khác!");
                                }
                                else
                                {
                                    lv_bill.Items[temp].SubItems[2].Text = tb_quantity.Text;
                                    lv_bill.Items[temp].SubItems[4].Text = string.Format("{0:0,000}", (int.Parse(tb_quantity.Text) * double.Parse(tb_price.Text)));
                                }
                            if (cmb_type.Text == "Vật dụng y tế")
                                if (int.Parse(db.Medical_Supplie.Where(p => p.Medical_Supplie_Name.ToLower() == tb_name.Text.ToLower()).Select(p => p.Medical_Supplie_Quantity).FirstOrDefault().ToString()) < int.Parse(tb_quantity.Text))
                                {
                                    tb_quantity.Text = "";
                                    MessageBox.Show("Số lượng quá lớn hoặc đã hết hàng vui lòng chọn loại hàng khác!");
                                }
                                else
                                {
                                    lv_bill.Items[temp].SubItems[2].Text = tb_quantity.Text;
                                    lv_bill.Items[temp].SubItems[4].Text = string.Format("{0:0,000}", (int.Parse(tb_quantity.Text) * double.Parse(tb_price.Text)));
                                }
                        }
                            else
                            {
                                    lvi = new ListViewItem();
                                    lvi.Text = tb_id.Text;
                                    lvi.SubItems.Add(tb_name.Text);
                                    lvi.SubItems.Add(tb_quantity.Text);
                                    lvi.SubItems.Add(string.Format("{0:0,000}", tb_price.Text));
                                    lvi.SubItems.Add(string.Format("{0:0,000}", (int.Parse(tb_quantity.Text) * double.Parse(tb_price.Text))));
                            if (cmb_type.Text == "Thuốc")
                                if (int.Parse(db.Medicine.Where(p => p.Medicine_Name.ToLower() == tb_name.Text.ToLower()).Select(p => p.Medicine_Quantity).FirstOrDefault().ToString()) < int.Parse(tb_quantity.Text))
                                {
                                    tb_quantity.Text = "";
                                    MessageBox.Show("Số lượng quá lớn hoặc đã hết hàng vui lòng chọn loại hàng khác!");
                                }
                                else
                                {
                                    lv_bill.Items.Add(lvi);
                                }
                            if (cmb_type.Text == "Vật dụng y tế")
                                if (int.Parse(db.Medical_Supplie.Where(p => p.Medical_Supplie_Name.ToLower() == tb_name.Text.ToLower()).Select(p => p.Medical_Supplie_Quantity).FirstOrDefault().ToString()) < int.Parse(tb_quantity.Text))
                                {
                                    tb_quantity.Text = "";
                                    MessageBox.Show("Số lượng quá lớn hoặc đã hết hàng vui lòng chọn loại hàng khác!");
                                }
                                else
                                {
                                    lv_bill.Items.Add(lvi);
                                }
                        }    
                    }
                }
                tb_id.Text = "";
                tb_name.Text = "";
                tb_price.Text = "";
                tb_quantity.Text = "";
                SumOfMoney();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notify");
            }
        }

        private void SumOfMoney()
        {
            float tien = 0f;
            foreach (ListViewItem ele in lv_bill.Items)
            {
                tien += float.Parse(ele.SubItems[4].Text);

            }
            tb_sum.Text = string.Format("{0:0,000}",tien);
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            int index = checkid(tb_name.Text);
            if (index == -1)
                MessageBox.Show("Không tồn hàng này !", "Thông báo");
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    lv_bill.Items[index].Remove();
                    tb_id.Text = "";
                    tb_name.Text = "";
                    tb_price.Text = "";
                    tb_quantity.Text = "";
                    SumOfMoney();
                }
            }
        }

        private void lv_bill_Click(object sender, EventArgs e)
        {
            ListViewItem row = (ListViewItem)lv_bill.SelectedItems[0];
            tb_id.Text = row.SubItems[0].Text;
            tb_name.Text= row.SubItems[1].Text;
            tb_price.Text = row.SubItems[3].Text;
            tb_quantity.Text = row.SubItems[2].Text;
        }
        private int checkid(string id)
        {
            for (int i = 0; i < lv_bill.Items.Count; i++)
            {
                if (lv_bill.Items[i].SubItems[1].Text == tb_name.Text.Trim())
                {
                    return i;
                }
            }
            return -1;
        }

        private void bt_newbill_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc làm mới hóa đơn?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                lv_bill.Items.Clear();
                tb_id.Text = "";
                tb_name.Text = "";
                tb_price.Text = "";
                tb_quantity.Text = "";
                lb_temp.Text = "temp";
                lb_idbill.Visible = false;
                lb_temp.Visible = false;
                SumOfMoney();
            }
            return;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_time.Text= DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            try {
                Bill bi = new Bill();
                Medicine md;
                Medical_Supplie ms;
                Bill_Medicine bm;
                Bill_Supplie bs;
                //add data
                if (lv_bill.Items.Count == 0)
                    throw new Exception("Vui lòng chọn vật phẩm để lưu");
                bi.Staff_ID = main.acc.Staff_ID;
                bi.Bill_Date = DateTime.Now;
                db.Bill.Add(bi);
                db.SaveChanges();

                for(int i = 0; i < lv_bill.Items.Count; i++)
                {
                    string name = lv_bill.Items[i].SubItems[1].Text;
                    if(db.Medicine.Where(p=>p.Medicine_Name ==name).Count()   !=0)
                    {
                        md = (db.Medicine.Where(p => p.Medicine_Name == name)).FirstOrDefault();
                        bm = new Bill_Medicine();

                        bm.Bill_ID = bi.Bill_ID;
                        bm.Medicine_ID = db.Medicine.Where(p => p.Medicine_Name == name).Select(p => p.Medicine_ID).FirstOrDefault();
                        bm.Bill_Medicine_Quantity = int.Parse(lv_bill.Items[i].SubItems[2].Text);
                        db.Bill_Medicine.Add(bm);

                        md.Medicine_Quantity -= int.Parse(lv_bill.Items[i].SubItems[2].Text);
                        db.Medicine.AddOrUpdate(md);
                    }
                    else
                    {
                        bs = new Bill_Supplie();
                        ms = (db.Medical_Supplie.Where(p => p.Medical_Supplie_Name == name)).FirstOrDefault();

                        bs.Bill_ID = bi.Bill_ID;
                        bs.Medical_Supplie_ID = db.Medical_Supplie.Where(p => p.Medical_Supplie_Name == name).Select(p => p.Medical_Supplie_ID).FirstOrDefault();
                        bs.Bill_Supplie_Quantity = int.Parse(lv_bill.Items[i].SubItems[2].Text);
                        db.Bill_Supplie.Add(bs);

                        ms.Medical_Supplie_Quantity -= int.Parse(lv_bill.Items[i].SubItems[2].Text);
                        db.Medical_Supplie.AddOrUpdate(ms);
                    }
                }
                db.SaveChanges();
                lb_temp.Visible = true;
                lb_idbill.Visible = true;
                lb_temp.Text = bi.Bill_ID.ToString();
                MessageBox.Show("Lưu thành công");
                tb_id.Text = "";
                tb_name.Text = "";
                tb_price.Text = "";
                tb_quantity.Text = "";
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Notify");
            }

        }

        private void bt_delte_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.Bill.Where(p => p.Bill_ID.ToString() == lb_temp.Text).Count() == 0)
                {
                    throw new Exception("Không tồn tại hóa đơn !");
                }
                else
                {
                    if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                        return;
                    else
                    {
                        Bill id = db.Bill.Where(p => p.Bill_ID.ToString() == lb_temp.Text).FirstOrDefault();
                        List<Bill_Medicine> bm = db.Bill_Medicine.Where(p => p.Bill_ID == id.Bill_ID).ToList();
                        List<Bill_Supplie> bs = db.Bill_Supplie.Where(p => p.Bill_ID == id.Bill_ID).ToList();
                        foreach(Bill_Medicine ele in bm)
                        {
                            db.Bill_Medicine.Remove(ele);
                        }
                        foreach (Bill_Supplie ele in bs)
                        {
                            db.Bill_Supplie.Remove(ele);
                        }
                        db.Bill.Remove(id);
                        db.SaveChanges();
                        MessageBox.Show("Xóa thành công");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_report_Click(object sender, EventArgs e)
        {
            if (db.Bill.Where(p => p.Bill_ID.ToString() == lb_temp.Text).Count() == 0)
            {
                MessageBox.Show("Vui lòng lưu hóa đơn hoặc không tồn tại hóa đơn này"); 
            }
            else
            {
                //MessageBox.Show("Vui lòng lưu hóa đơn hoặc không tồn tại hóa đơn này",lb_temp.Text);
                ReportForm rf = new ReportForm(int.Parse(lb_temp.Text),double.Parse(tb_sum.Text));
                rf.ShowDialog();
            }
        }



        //public void load_list()
    }
}
