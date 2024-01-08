
namespace QuanLy.listform
{
    partial class qlloai
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
            this.dgv_category = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_edit = new System.Windows.Forms.Button();
            this.lb_idshow = new System.Windows.Forms.TextBox();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_addedit = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_category
            // 
            this.dgv_category.AllowUserToAddRows = false;
            this.dgv_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_category.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv_category.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_category.Location = new System.Drawing.Point(0, 128);
            this.dgv_category.Name = "dgv_category";
            this.dgv_category.Size = new System.Drawing.Size(800, 322);
            this.dgv_category.TabIndex = 0;
            this.dgv_category.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_category_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "Mã loại";
            this.Column1.Name = "Column1";
            this.Column1.Width = 66;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Tên loại";
            this.Column2.Name = "Column2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_edit);
            this.groupBox1.Controls.Add(this.lb_idshow);
            this.groupBox1.Controls.Add(this.bt_delete);
            this.groupBox1.Controls.Add(this.bt_addedit);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.lb_name);
            this.groupBox1.Controls.Add(this.lb_id);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 204);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // bt_edit
            // 
            this.bt_edit.Location = new System.Drawing.Point(422, 166);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(162, 32);
            this.bt_edit.TabIndex = 6;
            this.bt_edit.Text = "Sửa";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // lb_idshow
            // 
            this.lb_idshow.Location = new System.Drawing.Point(142, 44);
            this.lb_idshow.Name = "lb_idshow";
            this.lb_idshow.ReadOnly = true;
            this.lb_idshow.Size = new System.Drawing.Size(318, 25);
            this.lb_idshow.TabIndex = 5;
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(590, 166);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(162, 32);
            this.bt_delete.TabIndex = 4;
            this.bt_delete.Text = "Xóa";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_addedit
            // 
            this.bt_addedit.Location = new System.Drawing.Point(254, 166);
            this.bt_addedit.Name = "bt_addedit";
            this.bt_addedit.Size = new System.Drawing.Size(162, 32);
            this.bt_addedit.TabIndex = 2;
            this.bt_addedit.Text = "Thêm";
            this.bt_addedit.UseVisualStyleBackColor = true;
            this.bt_addedit.Click += new System.EventHandler(this.bt_addedit_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(142, 104);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(318, 25);
            this.tb_name.TabIndex = 3;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.ForeColor = System.Drawing.Color.Black;
            this.lb_name.Location = new System.Drawing.Point(71, 107);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(65, 18);
            this.lb_name.TabIndex = 1;
            this.lb_name.Text = "Tên loại";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.ForeColor = System.Drawing.Color.Black;
            this.lb_id.Location = new System.Drawing.Point(78, 51);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(58, 18);
            this.lb_id.TabIndex = 0;
            this.lb_id.Text = "Mã loại";
            // 
            // qlloai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_category);
            this.Name = "qlloai";
            this.Text = "Loại Thuốc";
            this.Load += new System.EventHandler(this.qlloai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_category;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_addedit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox lb_idshow;
        private System.Windows.Forms.Button bt_edit;
    }
}