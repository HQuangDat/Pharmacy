
namespace QuanLy.listform
{
    partial class qlnv
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_staffadd = new System.Windows.Forms.Button();
            this.bt_viewinfor = new System.Windows.Forms.Button();
            this.cmb_staff_category = new System.Windows.Forms.ComboBox();
            this.tb_find = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lv_staff = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.bt_staffadd);
            this.panel1.Controls.Add(this.bt_viewinfor);
            this.panel1.Controls.Add(this.cmb_staff_category);
            this.panel1.Controls.Add(this.tb_find);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 38);
            this.panel1.TabIndex = 2;
            // 
            // bt_staffadd
            // 
            this.bt_staffadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_staffadd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_staffadd.Location = new System.Drawing.Point(759, 5);
            this.bt_staffadd.Name = "bt_staffadd";
            this.bt_staffadd.Size = new System.Drawing.Size(127, 30);
            this.bt_staffadd.TabIndex = 4;
            this.bt_staffadd.Text = "Thêm nhân viên";
            this.bt_staffadd.UseVisualStyleBackColor = false;
            this.bt_staffadd.Click += new System.EventHandler(this.bt_staffadd_Click);
            // 
            // bt_viewinfor
            // 
            this.bt_viewinfor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_viewinfor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_viewinfor.Location = new System.Drawing.Point(566, 5);
            this.bt_viewinfor.Name = "bt_viewinfor";
            this.bt_viewinfor.Size = new System.Drawing.Size(187, 30);
            this.bt_viewinfor.TabIndex = 3;
            this.bt_viewinfor.Text = "Xem thông tin nhân viên";
            this.bt_viewinfor.UseVisualStyleBackColor = false;
            this.bt_viewinfor.Click += new System.EventHandler(this.bt_viewinfor_Click);
            // 
            // cmb_staff_category
            // 
            this.cmb_staff_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_staff_category.FormattingEnabled = true;
            this.cmb_staff_category.Location = new System.Drawing.Point(426, 9);
            this.cmb_staff_category.Name = "cmb_staff_category";
            this.cmb_staff_category.Size = new System.Drawing.Size(121, 21);
            this.cmb_staff_category.TabIndex = 2;
            this.cmb_staff_category.SelectedIndexChanged += new System.EventHandler(this.cmb_staff_category_SelectedIndexChanged);
            // 
            // tb_find
            // 
            this.tb_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_find.Location = new System.Drawing.Point(161, 7);
            this.tb_find.Multiline = true;
            this.tb_find.Name = "tb_find";
            this.tb_find.Size = new System.Drawing.Size(239, 25);
            this.tb_find.TabIndex = 1;
            this.tb_find.TextChanged += new System.EventHandler(this.tb_find_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm theo tên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lv_staff);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(898, 412);
            this.panel2.TabIndex = 3;
            // 
            // lv_staff
            // 
            this.lv_staff.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lv_staff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_staff.HideSelection = false;
            this.lv_staff.Location = new System.Drawing.Point(0, 0);
            this.lv_staff.Name = "lv_staff";
            this.lv_staff.Size = new System.Drawing.Size(898, 412);
            this.lv_staff.TabIndex = 0;
            this.lv_staff.UseCompatibleStateImageBehavior = false;
            this.lv_staff.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã NV";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên nhân viên";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số điện thoại";
            this.columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Địa chỉ";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Lương";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Loại nhân viên";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tài khoản";
            this.columnHeader7.Width = 120;
            // 
            // qlnv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "qlnv";
            this.Text = "qlnv";
            this.Load += new System.EventHandler(this.qlnv_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_find;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lv_staff;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button bt_viewinfor;
        public System.Windows.Forms.ComboBox cmb_staff_category;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button bt_staffadd;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}