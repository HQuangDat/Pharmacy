
namespace QuanLy.listform
{
    partial class BillSell
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_delete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_add = new System.Windows.Forms.Button();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.bt_select = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tb_nv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_sum = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_temp = new System.Windows.Forms.Label();
            this.lb_idbill = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.bt_report = new System.Windows.Forms.Button();
            this.bt_newbill = new System.Windows.Forms.Button();
            this.bt_delte = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lv_bill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.bt_delete);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.bt_add);
            this.panel1.Controls.Add(this.tb_price);
            this.panel1.Controls.Add(this.bt_select);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_quantity);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_id);
            this.panel1.Controls.Add(this.cmb_type);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 100);
            this.panel1.TabIndex = 0;
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_delete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_delete.Location = new System.Drawing.Point(961, 37);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(96, 50);
            this.bt_delete.TabIndex = 13;
            this.bt_delete.Text = "Xóa";
            this.bt_delete.UseVisualStyleBackColor = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(627, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Số tiền";
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_add.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_add.Location = new System.Drawing.Point(866, 37);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(93, 50);
            this.bt_add.TabIndex = 12;
            this.bt_add.Text = "Thêm";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // tb_price
            // 
            this.tb_price.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_price.Location = new System.Drawing.Point(610, 54);
            this.tb_price.Multiline = true;
            this.tb_price.Name = "tb_price";
            this.tb_price.ReadOnly = true;
            this.tb_price.Size = new System.Drawing.Size(116, 29);
            this.tb_price.TabIndex = 12;
            // 
            // bt_select
            // 
            this.bt_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_select.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_select.Location = new System.Drawing.Point(173, 37);
            this.bt_select.Name = "bt_select";
            this.bt_select.Size = new System.Drawing.Size(88, 50);
            this.bt_select.TabIndex = 11;
            this.bt_select.Text = "Chọn hàng";
            this.bt_select.UseVisualStyleBackColor = false;
            this.bt_select.Click += new System.EventHandler(this.bt_select_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(732, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số lượng";
            // 
            // tb_quantity
            // 
            this.tb_quantity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_quantity.Location = new System.Drawing.Point(736, 54);
            this.tb_quantity.Multiline = true;
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.Size = new System.Drawing.Size(77, 29);
            this.tb_quantity.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(282, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên hàng";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_name.Location = new System.Drawing.Point(369, 54);
            this.tb_name.Multiline = true;
            this.tb_name.Name = "tb_name";
            this.tb_name.ReadOnly = true;
            this.tb_name.Size = new System.Drawing.Size(235, 27);
            this.tb_name.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(282, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã hàng";
            // 
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_id.Location = new System.Drawing.Point(369, 27);
            this.tb_id.Multiline = true;
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(46, 19);
            this.tb_id.TabIndex = 1;
            // 
            // cmb_type
            // 
            this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Location = new System.Drawing.Point(32, 54);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(117, 21);
            this.cmb_type.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loại mặt hàng";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel4.Controls.Add(this.tb_nv);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1060, 21);
            this.panel4.TabIndex = 0;
            // 
            // tb_nv
            // 
            this.tb_nv.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_nv.Location = new System.Drawing.Point(127, 0);
            this.tb_nv.Multiline = true;
            this.tb_nv.Name = "tb_nv";
            this.tb_nv.ReadOnly = true;
            this.tb_nv.Size = new System.Drawing.Size(163, 21);
            this.tb_nv.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(3, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nhân viên lập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(0, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tổng tiền";
            // 
            // tb_sum
            // 
            this.tb_sum.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_sum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_sum.Location = new System.Drawing.Point(0, 416);
            this.tb_sum.Multiline = true;
            this.tb_sum.Name = "tb_sum";
            this.tb_sum.ReadOnly = true;
            this.tb_sum.Size = new System.Drawing.Size(194, 31);
            this.tb_sum.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.lb_temp);
            this.panel2.Controls.Add(this.lb_idbill);
            this.panel2.Controls.Add(this.lb_time);
            this.panel2.Controls.Add(this.bt_report);
            this.panel2.Controls.Add(this.bt_newbill);
            this.panel2.Controls.Add(this.bt_delte);
            this.panel2.Controls.Add(this.bt_save);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tb_sum);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(866, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 447);
            this.panel2.TabIndex = 1;
            // 
            // lb_temp
            // 
            this.lb_temp.AutoSize = true;
            this.lb_temp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_temp.Location = new System.Drawing.Point(117, 100);
            this.lb_temp.Name = "lb_temp";
            this.lb_temp.Size = new System.Drawing.Size(47, 19);
            this.lb_temp.TabIndex = 19;
            this.lb_temp.Text = "temp";
            // 
            // lb_idbill
            // 
            this.lb_idbill.AutoSize = true;
            this.lb_idbill.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_idbill.Location = new System.Drawing.Point(12, 100);
            this.lb_idbill.Name = "lb_idbill";
            this.lb_idbill.Size = new System.Drawing.Size(105, 19);
            this.lb_idbill.TabIndex = 18;
            this.lb_idbill.Text = "Mã hóa đơn:";
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Location = new System.Drawing.Point(28, 3);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(35, 13);
            this.lb_time.TabIndex = 17;
            this.lb_time.Text = "label8";
            // 
            // bt_report
            // 
            this.bt_report.BackColor = System.Drawing.Color.Crimson;
            this.bt_report.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_report.Location = new System.Drawing.Point(2, 232);
            this.bt_report.Name = "bt_report";
            this.bt_report.Size = new System.Drawing.Size(189, 50);
            this.bt_report.TabIndex = 16;
            this.bt_report.Text = "In hóa đơn";
            this.bt_report.UseVisualStyleBackColor = false;
            this.bt_report.Click += new System.EventHandler(this.bt_report_Click);
            // 
            // bt_newbill
            // 
            this.bt_newbill.BackColor = System.Drawing.Color.AntiqueWhite;
            this.bt_newbill.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_newbill.Location = new System.Drawing.Point(31, 19);
            this.bt_newbill.Name = "bt_newbill";
            this.bt_newbill.Size = new System.Drawing.Size(138, 50);
            this.bt_newbill.TabIndex = 15;
            this.bt_newbill.Text = "Tạo hóa đơn mới";
            this.bt_newbill.UseVisualStyleBackColor = false;
            this.bt_newbill.Click += new System.EventHandler(this.bt_newbill_Click);
            // 
            // bt_delte
            // 
            this.bt_delte.BackColor = System.Drawing.Color.LightCoral;
            this.bt_delte.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_delte.Location = new System.Drawing.Point(101, 176);
            this.bt_delte.Name = "bt_delte";
            this.bt_delte.Size = new System.Drawing.Size(93, 50);
            this.bt_delte.TabIndex = 14;
            this.bt_delte.Text = "Xóa hóa đơn";
            this.bt_delte.UseVisualStyleBackColor = false;
            this.bt_delte.Click += new System.EventHandler(this.bt_delte_Click);
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.bt_save.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_save.Location = new System.Drawing.Point(0, 176);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(93, 50);
            this.bt_save.TabIndex = 13;
            this.bt_save.Text = "Lưu hóa đơn";
            this.bt_save.UseVisualStyleBackColor = false;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lv_bill);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(866, 447);
            this.panel3.TabIndex = 2;
            // 
            // lv_bill
            // 
            this.lv_bill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lv_bill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_bill.HideSelection = false;
            this.lv_bill.Location = new System.Drawing.Point(0, 0);
            this.lv_bill.Name = "lv_bill";
            this.lv_bill.Size = new System.Drawing.Size(866, 447);
            this.lv_bill.TabIndex = 0;
            this.lv_bill.UseCompatibleStateImageBehavior = false;
            this.lv_bill.View = System.Windows.Forms.View.Details;
            this.lv_bill.Click += new System.EventHandler(this.lv_bill_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã vật phẩm";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên vật phẩm";
            this.columnHeader2.Width = 237;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá";
            this.columnHeader4.Width = 199;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tổng giá";
            this.columnHeader5.Width = 209;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BillSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 547);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BillSell";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lv_bill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_sum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_quantity;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_nv;
        private System.Windows.Forms.Button bt_select;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_report;
        private System.Windows.Forms.Button bt_newbill;
        private System.Windows.Forms.Button bt_delte;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_temp;
        private System.Windows.Forms.Label lb_idbill;
    }
}