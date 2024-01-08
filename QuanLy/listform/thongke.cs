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
    public partial class thongke : Form
    {
        Pharmacy_ManagementEntities db = new Pharmacy_ManagementEntities();
        public thongke()
        {
            InitializeComponent();
            lv_tk.FullRowSelect = true;
            lv_tk.MultiSelect = false;
            dtp_from.ValueChanged += Dtp_from_ValueChanged;
            dtp_to.ValueChanged += Dtp_from_ValueChanged;

        }

        private void Dtp_from_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            try
            {
                if(dtp.Name =="dtp_from")
                {
                    if (dtp_from.Value > dtp_to.Value) 
                    {
                        dtp_from.Value = (DateTime)db.Bill.OrderBy(p => p.Bill_Date).Select(p => p.Bill_Date).FirstOrDefault();
                        throw new Exception("Ngày bắt đầu không được lớn hơn ngày kết thúc");
                    }
                }
                else
                {
                    if (dtp_from.Value > dtp_to.Value)
                    {
                        dtp_to.Value = DateTime.Now;
                        throw new Exception("Ngày kết thúc không được nhỏ hơn ngày bắt đầu");
                    }
                }
                load_list(db.Statistic_Bills(dtp_from.Value, dtp_to.Value).ToList());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void thongke_Load(object sender, EventArgs e)
        {
            if (db.Bill.Count() != 0)
            {
                dtp_from.Value = (DateTime)db.Bill.OrderBy(p => p.Bill_Date).Select(p => p.Bill_Date).FirstOrDefault();
                dtp_to.Value = DateTime.Now;

                load_list(db.Statistic_Bills(dtp_from.Value, dtp_to.Value).ToList());
                lv_tk.Font = new Font("Tahoma", 12);
                lv_tk.View = View.Details;
                bt_change.Text = "Vật tư";
            }

            
        }
        private void load_list(List<Statistic_Bills_Result> list)
        {
            lv_tk.Items.Clear();
            lv_tk.Columns.Clear();
            ListViewItem row;
            bt_report.Enabled = true;

            lv_tk.Columns.Add("Mã Hóa đơn");
            lv_tk.Columns.Add("Tên nhân viên");
            lv_tk.Columns.Add("Ngày lập");
            lv_tk.Columns.Add("Tổng tiền");
            lv_tk.Columns[0].Width = 100;
            lv_tk.Columns[1].Width = 200;
            lv_tk.Columns[2].Width = 150;
            lv_tk.Columns[3].Width = 150;

            foreach (Statistic_Bills_Result b in list)
            {
                row = new ListViewItem();
                row.Text = b.Bill_ID.ToString();
                row.SubItems.Add(db.Staff.Where(p => p.Staff_ID == b.Staff_ID).Select(p => p.Staff_Name).FirstOrDefault());
                row.SubItems.Add(string.Format("{0:dd/MM/yyyy}", b.Bill_Date));
                row.SubItems.Add(string.Format("{0:0,000}",db.Bill_Create(b.Bill_ID).Sum(p=>p.Money).ToString()));
                lv_tk.Items.Add(row);
            }
        }
        
        private void bt_report_Click(object sender, EventArgs e)
        {
            string id = "";
            if (lv_tk.SelectedItems.Count != 0)
                id = lv_tk.SelectedItems[0].SubItems[0].Text;
            Bill b = db.Bill.Where(p => p.Bill_ID.ToString() == id).FirstOrDefault();
            if (b == null)
                MessageBox.Show("Xin hãy chọn hóa đơn!", "Thông báo");
            else
            {//db.Bill_Create(b.Bill_ID).Select(p => p.Money).FirstOrDefault().ToString()
                ReportForm rf = new ReportForm(b.Bill_ID, double.Parse(db.Bill_Create(b.Bill_ID).Sum(p => p.Money).ToString()));
                rf.ShowDialog();
            }
    }

        private void bt_change_Click(object sender, EventArgs e)
        {
            bt_change.Text = bt_change.Text == "Hóa đơn" ? "Vật Tư" : "Hóa đơn";
            if (bt_change.Text == "Hóa đơn")
                load_list_statistic();
            else
                load_list(db.Statistic_Bills(dtp_from.Value, dtp_to.Value).ToList());
        }

        private void load_list_statistic()
        {
            lv_tk.Items.Clear();
            lv_tk.Columns.Clear();
            ListViewItem row;
            bt_report.Enabled = false;

            lv_tk.Columns.Add("Mã vật tư");
            lv_tk.Columns.Add("Tên vật tư");
            lv_tk.Columns.Add("Số lượng");
            lv_tk.Columns.Add("Tình trạng");
            lv_tk.Columns[0].Width = 80;
            lv_tk.Columns[1].Width = 400;
            lv_tk.Columns[2].Width = 150;
            lv_tk.Columns[3].Width = 150;

            foreach (Medicine_Statistic_Result b in db.Medicine_Statistic(dtp_from.Value,dtp_to.Value))
            {

                row = new ListViewItem();
                row.Text = b.Medicine_ID.ToString();
                row.SubItems.Add(db.Medicine.Where(p=>p.Medicine_ID== b.Medicine_ID).Select(p=>p.Medicine_Name).FirstOrDefault());
                row.SubItems.Add(b.SumOfQuantity.ToString());
                if (db.Medicine.Where(p => p.Medicine_ID == b.Medicine_ID).Select(p => p.Medicine_Quantity).FirstOrDefault() == 0)
                    row.SubItems.Add("Hết hàng");
                else
                    row.SubItems.Add("Còn hàng");
                lv_tk.Items.Add(row);
            }
            foreach (Medical_Supplie_Statistic_Result b in db.Medical_Supplie_Statistic(dtp_from.Value, dtp_to.Value))
            {

                row = new ListViewItem();
                row.Text = b.Medical_Supplie_ID.ToString();
                row.SubItems.Add(db.Medical_Supplie.Where(p => p.Medical_Supplie_ID == b.Medical_Supplie_ID).Select(p => p.Medical_Supplie_Name).FirstOrDefault());
                row.SubItems.Add(b.SumOfQuantity.ToString());
                if (db.Medical_Supplie.Where(p => p.Medical_Supplie_ID == b.Medical_Supplie_ID).Select(p => p.Medical_Supplie_Quantity).FirstOrDefault() == 0)
                    row.SubItems.Add("Hết hàng");
                else
                    row.SubItems.Add("Còn hàng");
                lv_tk.Items.Add(row);
            }
        }


    }
}
