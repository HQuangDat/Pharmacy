using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QuanLy.listform
{
    public partial class ReportForm : Form
    {
        int billid;
        double money;
        Pharmacy_ManagementEntities db = new Pharmacy_ManagementEntities();
        public ReportForm(int billid, double money)
        {
            InitializeComponent();
            this.billid = billid;
            this.money = money;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            this.rpviewer.LocalReport.ReportPath = "../../listform/ReportPharmacyManagements.rdlc";
            List<Bill_Create_Result> result = db.Bill_Create(billid).ToList();
            this.rpviewer.LocalReport.DataSources.Clear();
            this.rpviewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetBill",result));

            ReportParameter[] param = new ReportParameter[4];

            int getid = int.Parse(db.Bill.Where(p => p.Bill_ID == billid).Select(p => p.Staff_ID).FirstOrDefault().ToString());

            param[0] = new ReportParameter("Ngayin",string.Format("{0:dd/MM/yyyy}",db.Bill.Where(p=>p.Bill_ID == billid).Select(p=>p.Bill_Date).FirstOrDefault()));
            param[1] = new ReportParameter("TenNV", db.Staff.Where(p => p.Staff_ID == getid).Select(p => p.Staff_Name).FirstOrDefault());
            param[2] = new ReportParameter("idhoadon", db.Bill.Where(p => p.Bill_ID == billid).Select(p => p.Bill_ID).FirstOrDefault().ToString());
            param[3] = new ReportParameter("sumbill", string.Format("{0:0,000}",money.ToString()));
            this.rpviewer.LocalReport.SetParameters(param);
            this.rpviewer.RefreshReport();
        }
    }
}
