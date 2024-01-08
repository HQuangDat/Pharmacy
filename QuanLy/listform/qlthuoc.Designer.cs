
namespace QuanLy.listform
{
    partial class qlthuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(qlthuoc));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslb_find = new System.Windows.Forms.ToolStripLabel();
            this.tstb_find = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbt_add = new System.Windows.Forms.ToolStripButton();
            this.tsbt_delete = new System.Windows.Forms.ToolStripButton();
            this.tsbt_edit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbp_tang = new System.Windows.Forms.ToolStripSplitButton();
            this.sốLượngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.sốLượngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.giáToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbt_reset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tscmb_find_category = new System.Windows.Forms.ToolStripComboBox();
            this.lv_medicine = new System.Windows.Forms.ListView();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Silver;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslb_find,
            this.tstb_find,
            this.toolStripSeparator1,
            this.tsbt_add,
            this.tsbt_delete,
            this.tsbt_edit,
            this.toolStripSeparator2,
            this.tsbp_tang,
            this.toolStripSplitButton2,
            this.toolStripSeparator3,
            this.tsbt_reset,
            this.toolStripSeparator4,
            this.tscmb_find_category});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(995, 33);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslb_find
            // 
            this.tslb_find.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tslb_find.Image = ((System.Drawing.Image)(resources.GetObject("tslb_find.Image")));
            this.tslb_find.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tslb_find.Name = "tslb_find";
            this.tslb_find.Size = new System.Drawing.Size(141, 30);
            this.tslb_find.Text = "Tìm kiếm thuốc";
            // 
            // tstb_find
            // 
            this.tstb_find.AutoSize = false;
            this.tstb_find.BackColor = System.Drawing.Color.White;
            this.tstb_find.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tstb_find.ForeColor = System.Drawing.Color.Black;
            this.tstb_find.Name = "tstb_find";
            this.tstb_find.Size = new System.Drawing.Size(200, 26);
            this.tstb_find.TextChanged += new System.EventHandler(this.tstb_find_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // tsbt_add
            // 
            this.tsbt_add.AutoSize = false;
            this.tsbt_add.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tsbt_add.Image = ((System.Drawing.Image)(resources.GetObject("tsbt_add.Image")));
            this.tsbt_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbt_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbt_add.Name = "tsbt_add";
            this.tsbt_add.Size = new System.Drawing.Size(65, 30);
            this.tsbt_add.Text = "Thêm";
            this.tsbt_add.Click += new System.EventHandler(this.tsbt_add_Click);
            // 
            // tsbt_delete
            // 
            this.tsbt_delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbt_delete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tsbt_delete.Image = ((System.Drawing.Image)(resources.GetObject("tsbt_delete.Image")));
            this.tsbt_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbt_delete.Name = "tsbt_delete";
            this.tsbt_delete.Size = new System.Drawing.Size(36, 30);
            this.tsbt_delete.Text = "Xóa";
            this.tsbt_delete.Click += new System.EventHandler(this.tsbt_delete_Click);
            // 
            // tsbt_edit
            // 
            this.tsbt_edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbt_edit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tsbt_edit.Image = ((System.Drawing.Image)(resources.GetObject("tsbt_edit.Image")));
            this.tsbt_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbt_edit.Name = "tsbt_edit";
            this.tsbt_edit.Size = new System.Drawing.Size(38, 30);
            this.tsbt_edit.Text = "Sửa";
            this.tsbt_edit.Click += new System.EventHandler(this.tsbt_edit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // tsbp_tang
            // 
            this.tsbp_tang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbp_tang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sốLượngToolStripMenuItem,
            this.giáToolStripMenuItem});
            this.tsbp_tang.Image = ((System.Drawing.Image)(resources.GetObject("tsbp_tang.Image")));
            this.tsbp_tang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbp_tang.Name = "tsbp_tang";
            this.tsbp_tang.Size = new System.Drawing.Size(32, 30);
            this.tsbp_tang.Text = "Sắp xếp tăng dần";
            // 
            // sốLượngToolStripMenuItem
            // 
            this.sốLượngToolStripMenuItem.Name = "sốLượngToolStripMenuItem";
            this.sốLượngToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.sốLượngToolStripMenuItem.Text = "Số lượng";
            this.sốLượngToolStripMenuItem.Click += new System.EventHandler(this.sốLượngToolStripMenuItem_Click);
            // 
            // giáToolStripMenuItem
            // 
            this.giáToolStripMenuItem.Name = "giáToolStripMenuItem";
            this.giáToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.giáToolStripMenuItem.Text = "Giá";
            this.giáToolStripMenuItem.Click += new System.EventHandler(this.giáToolStripMenuItem_Click);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sốLượngToolStripMenuItem1,
            this.giáToolStripMenuItem1});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(32, 30);
            this.toolStripSplitButton2.Text = "Sắp xếp";
            // 
            // sốLượngToolStripMenuItem1
            // 
            this.sốLượngToolStripMenuItem1.Name = "sốLượngToolStripMenuItem1";
            this.sốLượngToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.sốLượngToolStripMenuItem1.Text = "Số lượng";
            this.sốLượngToolStripMenuItem1.Click += new System.EventHandler(this.sốLượngToolStripMenuItem1_Click);
            // 
            // giáToolStripMenuItem1
            // 
            this.giáToolStripMenuItem1.Name = "giáToolStripMenuItem1";
            this.giáToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.giáToolStripMenuItem1.Text = "Giá";
            this.giáToolStripMenuItem1.Click += new System.EventHandler(this.giáToolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 33);
            // 
            // tsbt_reset
            // 
            this.tsbt_reset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbt_reset.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tsbt_reset.ForeColor = System.Drawing.Color.Black;
            this.tsbt_reset.Image = ((System.Drawing.Image)(resources.GetObject("tsbt_reset.Image")));
            this.tsbt_reset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbt_reset.Name = "tsbt_reset";
            this.tsbt_reset.Size = new System.Drawing.Size(60, 30);
            this.tsbt_reset.Text = "Refresh";
            this.tsbt_reset.Click += new System.EventHandler(this.tsbt_reset_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 33);
            // 
            // tscmb_find_category
            // 
            this.tscmb_find_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscmb_find_category.Name = "tscmb_find_category";
            this.tscmb_find_category.Size = new System.Drawing.Size(121, 33);
            this.tscmb_find_category.SelectedIndexChanged += new System.EventHandler(this.tscmb_find_category_SelectedIndexChanged);
            // 
            // lv_medicine
            // 
            this.lv_medicine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_medicine.HideSelection = false;
            this.lv_medicine.Location = new System.Drawing.Point(0, 33);
            this.lv_medicine.Name = "lv_medicine";
            this.lv_medicine.Size = new System.Drawing.Size(995, 579);
            this.lv_medicine.TabIndex = 1;
            this.lv_medicine.UseCompatibleStateImageBehavior = false;
            // 
            // qlthuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 612);
            this.Controls.Add(this.lv_medicine);
            this.Controls.Add(this.toolStrip1);
            this.Name = "qlthuoc";
            this.Text = "qlthuoc";
            this.Load += new System.EventHandler(this.qlthuoc_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslb_find;
        private System.Windows.Forms.ToolStripTextBox tstb_find;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbt_add;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton tsbp_tang;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem sốLượngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giáToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sốLượngToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem giáToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton tsbt_delete;
        public System.Windows.Forms.ListView lv_medicine;
        private System.Windows.Forms.ToolStripButton tsbt_edit;
        private System.Windows.Forms.ToolStripButton tsbt_reset;
        private System.Windows.Forms.ToolStripComboBox tscmb_find_category;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}