namespace Restaurant.View
{
    partial class StaffView
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
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStaffCashier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStafWaiter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStaffChef = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 50F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Restaurant.Properties.Resources.edit;
            this.dataGridViewImageColumn1.MinimumWidth = 70;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 70;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.FillWeight = 50F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Restaurant.Properties.Resources.delete;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 70;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century751 No2 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Staff List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(74)))), ((int)(((byte)(57)))));
            this.label3.Font = new System.Drawing.Font("Century751 No2 BT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(111)))));
            this.label3.Location = new System.Drawing.Point(536, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Cashier";
            // 
            // btnStaffCashier
            // 
            this.btnStaffCashier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(74)))), ((int)(((byte)(57)))));
            this.btnStaffCashier.BackgroundImage = global::Restaurant.Properties.Resources.clerk;
            this.btnStaffCashier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStaffCashier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaffCashier.Location = new System.Drawing.Point(498, 168);
            this.btnStaffCashier.Name = "btnStaffCashier";
            this.btnStaffCashier.Size = new System.Drawing.Size(150, 160);
            this.btnStaffCashier.TabIndex = 28;
            this.btnStaffCashier.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnStaffCashier.UseVisualStyleBackColor = false;
            this.btnStaffCashier.Click += new System.EventHandler(this.btnStaffCashier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(74)))), ((int)(((byte)(57)))));
            this.label1.Font = new System.Drawing.Font("Century751 No2 BT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(111)))));
            this.label1.Location = new System.Drawing.Point(328, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Waiter";
            // 
            // btnStafWaiter
            // 
            this.btnStafWaiter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(74)))), ((int)(((byte)(57)))));
            this.btnStafWaiter.BackgroundImage = global::Restaurant.Properties.Resources.waiter;
            this.btnStafWaiter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStafWaiter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStafWaiter.Location = new System.Drawing.Point(286, 168);
            this.btnStafWaiter.Name = "btnStafWaiter";
            this.btnStafWaiter.Size = new System.Drawing.Size(150, 160);
            this.btnStafWaiter.TabIndex = 26;
            this.btnStafWaiter.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnStafWaiter.UseVisualStyleBackColor = false;
            this.btnStafWaiter.Click += new System.EventHandler(this.btnStafWaiter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(74)))), ((int)(((byte)(57)))));
            this.label4.Font = new System.Drawing.Font("Century751 No2 BT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(111)))));
            this.label4.Location = new System.Drawing.Point(129, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Chef";
            // 
            // btnStaffChef
            // 
            this.btnStaffChef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(74)))), ((int)(((byte)(57)))));
            this.btnStaffChef.BackgroundImage = global::Restaurant.Properties.Resources.chef;
            this.btnStaffChef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStaffChef.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaffChef.Location = new System.Drawing.Point(82, 168);
            this.btnStaffChef.Name = "btnStaffChef";
            this.btnStaffChef.Size = new System.Drawing.Size(150, 160);
            this.btnStaffChef.TabIndex = 24;
            this.btnStaffChef.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnStaffChef.UseVisualStyleBackColor = false;
            this.btnStaffChef.Click += new System.EventHandler(this.btnStaffChef_Click);
            // 
            // StaffView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(224)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(756, 504);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStaffCashier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStafWaiter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStaffChef);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffView";
            this.Text = "StaffView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStaffCashier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStafWaiter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStaffChef;
    }
}