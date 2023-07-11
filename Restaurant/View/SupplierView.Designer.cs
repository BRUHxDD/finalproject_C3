namespace Restaurant
{
    partial class SupplierView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtIDSup = new System.Windows.Forms.TextBox();
            this.idSup = new System.Windows.Forms.Label();
            this.txtProvinsi = new System.Windows.Forms.TextBox();
            this.txtKota = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnmJLN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnoTlpnSup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnmSup = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSupplier.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvSupplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century751 No2 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(74)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvSupplier.GridColor = System.Drawing.Color.AntiqueWhite;
            this.dgvSupplier.Location = new System.Drawing.Point(78, 42);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.RowHeadersWidth = 10;
            this.dgvSupplier.RowTemplate.Height = 40;
            this.dgvSupplier.RowTemplate.ReadOnly = true;
            this.dgvSupplier.Size = new System.Drawing.Size(581, 267);
            this.dgvSupplier.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century751 No2 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Add Supplier";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 50F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Restaurant.Properties.Resources.edit;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 70;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
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
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BackgroundImage = global::Restaurant.Properties.Resources.add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(16, 42);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 40);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtIDSup
            // 
            this.txtIDSup.Font = new System.Drawing.Font("Century751 No2 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDSup.Location = new System.Drawing.Point(78, 343);
            this.txtIDSup.Name = "txtIDSup";
            this.txtIDSup.Size = new System.Drawing.Size(132, 23);
            this.txtIDSup.TabIndex = 29;
            // 
            // idSup
            // 
            this.idSup.AutoSize = true;
            this.idSup.Font = new System.Drawing.Font("Century751 No2 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idSup.Location = new System.Drawing.Point(81, 327);
            this.idSup.Name = "idSup";
            this.idSup.Size = new System.Drawing.Size(82, 16);
            this.idSup.TabIndex = 28;
            this.idSup.Text = "ID Supplier";
            // 
            // txtProvinsi
            // 
            this.txtProvinsi.Font = new System.Drawing.Font("Century751 No2 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvinsi.Location = new System.Drawing.Point(330, 446);
            this.txtProvinsi.Name = "txtProvinsi";
            this.txtProvinsi.Size = new System.Drawing.Size(132, 23);
            this.txtProvinsi.TabIndex = 27;
            // 
            // txtKota
            // 
            this.txtKota.Font = new System.Drawing.Font("Century751 No2 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKota.Location = new System.Drawing.Point(330, 403);
            this.txtKota.Name = "txtKota";
            this.txtKota.Size = new System.Drawing.Size(132, 23);
            this.txtKota.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century751 No2 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(253, 451);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 14);
            this.label7.TabIndex = 25;
            this.label7.Text = "Provinsi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century751 No2 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(253, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 14);
            this.label6.TabIndex = 24;
            this.label6.Text = "Kota";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century751 No2 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(253, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 14);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nama Jalan";
            // 
            // txtnmJLN
            // 
            this.txtnmJLN.Font = new System.Drawing.Font("Century751 No2 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnmJLN.Location = new System.Drawing.Point(330, 360);
            this.txtnmJLN.Name = "txtnmJLN";
            this.txtnmJLN.Size = new System.Drawing.Size(132, 23);
            this.txtnmJLN.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century751 No2 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(327, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Alamat";
            // 
            // txtnoTlpnSup
            // 
            this.txtnoTlpnSup.Font = new System.Drawing.Font("Century751 No2 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnoTlpnSup.Location = new System.Drawing.Point(78, 455);
            this.txtnoTlpnSup.Name = "txtnoTlpnSup";
            this.txtnoTlpnSup.Size = new System.Drawing.Size(132, 23);
            this.txtnoTlpnSup.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century751 No2 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "No Telepon";
            // 
            // txtnmSup
            // 
            this.txtnmSup.Font = new System.Drawing.Font("Century751 No2 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnmSup.Location = new System.Drawing.Point(78, 396);
            this.txtnmSup.Name = "txtnmSup";
            this.txtnmSup.Size = new System.Drawing.Size(132, 23);
            this.txtnmSup.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century751 No2 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(81, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Nama";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(599, 399);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 30);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(508, 380);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 30);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Location = new System.Drawing.Point(673, 42);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(60, 30);
            this.btnOpen.TabIndex = 32;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(673, 89);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(60, 30);
            this.btnDel.TabIndex = 33;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(508, 425);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(60, 30);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Restaurant.Properties.Resources.wholesale;
            this.pictureBox1.InitialImage = global::Restaurant.Properties.Resources.wholesale1;
            this.pictureBox1.Location = new System.Drawing.Point(16, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // SupplierView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(224)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(756, 504);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtIDSup);
            this.Controls.Add(this.idSup);
            this.Controls.Add(this.txtProvinsi);
            this.Controls.Add(this.txtKota);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnmJLN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnoTlpnSup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnmSup);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvSupplier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SupplierView";
            this.Text = "SupplierView";
            this.Load += new System.EventHandler(this.SupplierView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.TextBox txtIDSup;
        private System.Windows.Forms.Label idSup;
        public System.Windows.Forms.TextBox txtProvinsi;
        public System.Windows.Forms.TextBox txtKota;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtnmJLN;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtnoTlpnSup;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtnmSup;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnOpen;
        public System.Windows.Forms.Button btnDel;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}