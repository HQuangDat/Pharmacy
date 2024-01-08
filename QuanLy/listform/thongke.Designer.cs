
namespace QuanLy.listform
{
    partial class thongke
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.bt_report = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lv_tk = new System.Windows.Forms.ListView();
            this.bt_change = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_change);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtp_to);
            this.panel1.Controls.Add(this.dtp_from);
            this.panel1.Controls.Add(this.bt_report);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 52);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(242, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đến";
            // 
            // dtp_to
            // 
            this.dtp_to.Location = new System.Drawing.Point(313, 11);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(200, 20);
            this.dtp_to.TabIndex = 2;
            // 
            // dtp_from
            // 
            this.dtp_from.Location = new System.Drawing.Point(12, 11);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(200, 20);
            this.dtp_from.TabIndex = 1;
            // 
            // bt_report
            // 
            this.bt_report.BackColor = System.Drawing.Color.Orange;
            this.bt_report.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_report.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_report.Location = new System.Drawing.Point(911, 0);
            this.bt_report.Name = "bt_report";
            this.bt_report.Size = new System.Drawing.Size(113, 52);
            this.bt_report.TabIndex = 0;
            this.bt_report.Text = "Xem hóa đơn";
            this.bt_report.UseVisualStyleBackColor = false;
            this.bt_report.Click += new System.EventHandler(this.bt_report_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lv_tk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 398);
            this.panel2.TabIndex = 1;
            // 
            // lv_tk
            // 
            this.lv_tk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_tk.HideSelection = false;
            this.lv_tk.Location = new System.Drawing.Point(0, 0);
            this.lv_tk.Name = "lv_tk";
            this.lv_tk.Size = new System.Drawing.Size(1024, 398);
            this.lv_tk.TabIndex = 0;
            this.lv_tk.UseCompatibleStateImageBehavior = false;
            this.lv_tk.View = System.Windows.Forms.View.Details;
            // 
            // bt_change
            // 
            this.bt_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_change.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_change.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_change.Location = new System.Drawing.Point(798, 0);
            this.bt_change.Name = "bt_change";
            this.bt_change.Size = new System.Drawing.Size(113, 52);
            this.bt_change.TabIndex = 4;
            this.bt_change.Text = "Vật tư";
            this.bt_change.UseVisualStyleBackColor = false;
            this.bt_change.Click += new System.EventHandler(this.bt_change_Click);
            // 
            // thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "thongke";
            this.ShowIcon = false;
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.thongke_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lv_tk;
        private System.Windows.Forms.Button bt_report;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.Button bt_change;
    }
}