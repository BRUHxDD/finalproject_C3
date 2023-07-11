namespace Restaurant.View
{
    partial class BhnBakuView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvIng = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.nmrcStk = new System.Windows.Forms.NumericUpDown();
            this.txtKDBhn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnmBhn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.btnDel1 = new System.Windows.Forms.Button();
            this.btnOpen1 = new System.Windows.Forms.Button();
            this.dgvSupply = new System.Windows.Forms.DataGridView();
            this.id_Spl = new System.Windows.Forms.Label();
            this.kd_Bahan = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTByr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tglSupp = new System.Windows.Forms.DateTimePicker();
            this.txtKdSupp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtJmlh = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnUpdate1 = new System.Windows.Forms.Button();
            this.btnClear1 = new System.Windows.Forms.Button();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxnmBhn = new System.Windows.Forms.ComboBox();
            this.cbxnmSup = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIng)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcStk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupply)).BeginInit();
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
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BackgroundImage = global::Restaurant.Properties.Resources.add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(12, 42);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 30);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = global::Restaurant.Properties.Resources.food;
            this.pictureBox2.InitialImage = global::Restaurant.Properties.Resources.wholesale1;
            this.pictureBox2.Location = new System.Drawing.Point(10, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century751 No2 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 22);
            this.label2.TabIndex = 36;
            this.label2.Text = "Add Ingridients";
            // 
            // dgvIng
            // 
            this.dgvIng.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIng.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvIng.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century751 No2 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(74)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIng.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvIng.GridColor = System.Drawing.Color.AntiqueWhite;
            this.dgvIng.Location = new System.Drawing.Point(48, 42);
            this.dgvIng.Name = "dgvIng";
            this.dgvIng.RowHeadersWidth = 10;
            this.dgvIng.RowTemplate.Height = 40;
            this.dgvIng.RowTemplate.ReadOnly = true;
            this.dgvIng.Size = new System.Drawing.Size(225, 209);
            this.dgvIng.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Controls.Add(this.nmrcStk);
            this.panel1.Controls.Add(this.txtKDBhn);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtnmBhn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvIng);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 506);
            this.panel1.TabIndex = 39;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(192, 418);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(50, 25);
            this.btnUpdate.TabIndex = 51;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(151, 458);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 25);
            this.btnClear.TabIndex = 50;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(108, 418);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 25);
            this.btnSave.TabIndex = 49;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(287, 90);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(50, 25);
            this.btnDel.TabIndex = 48;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Location = new System.Drawing.Point(287, 48);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(50, 25);
            this.btnOpen.TabIndex = 47;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            // 
            // nmrcStk
            // 
            this.nmrcStk.Location = new System.Drawing.Point(151, 364);
            this.nmrcStk.Name = "nmrcStk";
            this.nmrcStk.Size = new System.Drawing.Size(49, 20);
            this.nmrcStk.TabIndex = 46;
            this.nmrcStk.ValueChanged += new System.EventHandler(this.nmrcStk_ValueChanged);
            // 
            // txtKDBhn
            // 
            this.txtKDBhn.Font = new System.Drawing.Font("Century751 No2 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKDBhn.Location = new System.Drawing.Point(151, 265);
            this.txtKDBhn.Name = "txtKDBhn";
            this.txtKDBhn.Size = new System.Drawing.Size(160, 23);
            this.txtKDBhn.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century751 No2 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 44;
            this.label8.Text = "Kode Bahan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century751 No2 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Stock";
            // 
            // txtnmBhn
            // 
            this.txtnmBhn.Font = new System.Drawing.Font("Century751 No2 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnmBhn.Location = new System.Drawing.Point(151, 316);
            this.txtnmBhn.Name = "txtnmBhn";
            this.txtnmBhn.Size = new System.Drawing.Size(160, 23);
            this.txtnmBhn.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century751 No2 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nama Bahan";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(343, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 506);
            this.panel2.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Restaurant.Properties.Resources.wholesale;
            this.pictureBox1.InitialImage = global::Restaurant.Properties.Resources.wholesale1;
            this.pictureBox1.Location = new System.Drawing.Point(347, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century751 No2 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 22);
            this.label4.TabIndex = 40;
            this.label4.Text = "Add Data Supply";
            // 
            // btnAdd1
            // 
            this.btnAdd1.AutoSize = true;
            this.btnAdd1.BackColor = System.Drawing.Color.White;
            this.btnAdd1.BackgroundImage = global::Restaurant.Properties.Resources.add;
            this.btnAdd1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd1.FlatAppearance.BorderSize = 0;
            this.btnAdd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd1.Location = new System.Drawing.Point(351, 42);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(30, 30);
            this.btnAdd1.TabIndex = 49;
            this.btnAdd1.UseVisualStyleBackColor = false;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // btnDel1
            // 
            this.btnDel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            this.btnDel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel1.FlatAppearance.BorderSize = 0;
            this.btnDel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDel1.ForeColor = System.Drawing.Color.White;
            this.btnDel1.Location = new System.Drawing.Point(685, 90);
            this.btnDel1.Name = "btnDel1";
            this.btnDel1.Size = new System.Drawing.Size(50, 25);
            this.btnDel1.TabIndex = 52;
            this.btnDel1.Text = "Delete";
            this.btnDel1.UseVisualStyleBackColor = false;
            this.btnDel1.Click += new System.EventHandler(this.btnDel1_Click);
            // 
            // btnOpen1
            // 
            this.btnOpen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            this.btnOpen1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen1.FlatAppearance.BorderSize = 0;
            this.btnOpen1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpen1.ForeColor = System.Drawing.Color.White;
            this.btnOpen1.Location = new System.Drawing.Point(685, 47);
            this.btnOpen1.Name = "btnOpen1";
            this.btnOpen1.Size = new System.Drawing.Size(50, 25);
            this.btnOpen1.TabIndex = 51;
            this.btnOpen1.Text = "Open";
            this.btnOpen1.UseVisualStyleBackColor = false;
            // 
            // dgvSupply
            // 
            this.dgvSupply.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSupply.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvSupply.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century751 No2 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(74)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupply.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSupply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvSupply.GridColor = System.Drawing.Color.AntiqueWhite;
            this.dgvSupply.Location = new System.Drawing.Point(389, 43);
            this.dgvSupply.Name = "dgvSupply";
            this.dgvSupply.RowHeadersWidth = 10;
            this.dgvSupply.RowTemplate.Height = 40;
            this.dgvSupply.RowTemplate.ReadOnly = true;
            this.dgvSupply.Size = new System.Drawing.Size(325, 209);
            this.dgvSupply.TabIndex = 50;
            // 
            // id_Spl
            // 
            this.id_Spl.AutoSize = true;
            this.id_Spl.Font = new System.Drawing.Font("Century751 No2 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_Spl.Location = new System.Drawing.Point(528, 380);
            this.id_Spl.Name = "id_Spl";
            this.id_Spl.Size = new System.Drawing.Size(47, 16);
            this.id_Spl.TabIndex = 64;
            this.id_Spl.Text = "id_Spl";
            // 
            // kd_Bahan
            // 
            this.kd_Bahan.AutoSize = true;
            this.kd_Bahan.Font = new System.Drawing.Font("Century751 No2 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kd_Bahan.Location = new System.Drawing.Point(528, 328);
            this.kd_Bahan.Name = "kd_Bahan";
            this.kd_Bahan.Size = new System.Drawing.Size(73, 16);
            this.kd_Bahan.TabIndex = 63;
            this.kd_Bahan.Text = "kd_Bahan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century751 No2 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(377, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 14);
            this.label6.TabIndex = 62;
            this.label6.Text = "ID Supplier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century751 No2 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(377, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 14);
            this.label5.TabIndex = 61;
            this.label5.Text = "Kode Bahan";
            // 
            // txtTByr
            // 
            this.txtTByr.Font = new System.Drawing.Font("Century751 No2 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTByr.Location = new System.Drawing.Point(531, 470);
            this.txtTByr.Name = "txtTByr";
            this.txtTByr.Size = new System.Drawing.Size(132, 21);
            this.txtTByr.TabIndex = 60;
            this.txtTByr.TextChanged += new System.EventHandler(this.txtTByr_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century751 No2 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(377, 473);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 14);
            this.label7.TabIndex = 59;
            this.label7.Text = "Total Bayar";
            // 
            // tglSupp
            // 
            this.tglSupp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tglSupp.Location = new System.Drawing.Point(531, 405);
            this.tglSupp.Name = "tglSupp";
            this.tglSupp.Size = new System.Drawing.Size(132, 20);
            this.tglSupp.TabIndex = 58;
            // 
            // txtKdSupp
            // 
            this.txtKdSupp.Font = new System.Drawing.Font("Century751 No2 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKdSupp.Location = new System.Drawing.Point(531, 270);
            this.txtKdSupp.Name = "txtKdSupp";
            this.txtKdSupp.Size = new System.Drawing.Size(132, 23);
            this.txtKdSupp.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century751 No2 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(377, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 14);
            this.label9.TabIndex = 56;
            this.label9.Text = "Kode Supply";
            // 
            // txtJmlh
            // 
            this.txtJmlh.Font = new System.Drawing.Font("Century751 No2 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJmlh.Location = new System.Drawing.Point(531, 437);
            this.txtJmlh.Name = "txtJmlh";
            this.txtJmlh.Size = new System.Drawing.Size(72, 21);
            this.txtJmlh.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century751 No2 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(377, 442);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 14);
            this.label10.TabIndex = 54;
            this.label10.Text = "Jumlah";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century751 No2 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(377, 408);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 14);
            this.label11.TabIndex = 53;
            this.label11.Text = "Tanggal Supply";
            // 
            // btnUpdate1
            // 
            this.btnUpdate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            this.btnUpdate1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate1.FlatAppearance.BorderSize = 0;
            this.btnUpdate1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate1.ForeColor = System.Drawing.Color.White;
            this.btnUpdate1.Location = new System.Drawing.Point(685, 360);
            this.btnUpdate1.Name = "btnUpdate1";
            this.btnUpdate1.Size = new System.Drawing.Size(50, 25);
            this.btnUpdate1.TabIndex = 54;
            this.btnUpdate1.Text = "Update";
            this.btnUpdate1.UseVisualStyleBackColor = false;
            this.btnUpdate1.Click += new System.EventHandler(this.btnUpdate1_Click);
            // 
            // btnClear1
            // 
            this.btnClear1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            this.btnClear1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear1.FlatAppearance.BorderSize = 0;
            this.btnClear1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear1.ForeColor = System.Drawing.Color.White;
            this.btnClear1.Location = new System.Drawing.Point(685, 396);
            this.btnClear1.Name = "btnClear1";
            this.btnClear1.Size = new System.Drawing.Size(50, 25);
            this.btnClear1.TabIndex = 53;
            this.btnClear1.Text = "Clear";
            this.btnClear1.UseVisualStyleBackColor = false;
            this.btnClear1.Click += new System.EventHandler(this.btnClear1_Click);
            // 
            // btnSave1
            // 
            this.btnSave1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            this.btnSave1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave1.FlatAppearance.BorderSize = 0;
            this.btnSave1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave1.ForeColor = System.Drawing.Color.White;
            this.btnSave1.Location = new System.Drawing.Point(685, 318);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(50, 25);
            this.btnSave1.TabIndex = 52;
            this.btnSave1.Text = "Save";
            this.btnSave1.UseVisualStyleBackColor = false;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century751 No2 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(377, 301);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 14);
            this.label12.TabIndex = 52;
            this.label12.Text = "Nama Bahan";
            // 
            // cbxnmBhn
            // 
            this.cbxnmBhn.FormattingEnabled = true;
            this.cbxnmBhn.Location = new System.Drawing.Point(531, 299);
            this.cbxnmBhn.Name = "cbxnmBhn";
            this.cbxnmBhn.Size = new System.Drawing.Size(132, 21);
            this.cbxnmBhn.TabIndex = 65;
            this.cbxnmBhn.SelectedIndexChanged += new System.EventHandler(this.cbxnmBhn_SelectedIndexChanged);
            // 
            // cbxnmSup
            // 
            this.cbxnmSup.FormattingEnabled = true;
            this.cbxnmSup.Location = new System.Drawing.Point(531, 353);
            this.cbxnmSup.Name = "cbxnmSup";
            this.cbxnmSup.Size = new System.Drawing.Size(132, 21);
            this.cbxnmSup.TabIndex = 67;
            this.cbxnmSup.SelectedIndexChanged += new System.EventHandler(this.cbxnmSup_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century751 No2 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(377, 357);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 14);
            this.label13.TabIndex = 66;
            this.label13.Text = "Nama Supplier";
            // 
            // BhnBakuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(224)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(798, 506);
            this.Controls.Add(this.dgvSupply);
            this.Controls.Add(this.cbxnmSup);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbxnmBhn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnUpdate1);
            this.Controls.Add(this.btnClear1);
            this.Controls.Add(this.id_Spl);
            this.Controls.Add(this.btnSave1);
            this.Controls.Add(this.kd_Bahan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTByr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKdSupp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tglSupp);
            this.Controls.Add(this.btnAdd1);
            this.Controls.Add(this.btnDel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnOpen1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtJmlh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BhnBakuView";
            this.Text = "BhnBakuView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIng)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcStk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupply)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        public System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvIng;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nmrcStk;
        private System.Windows.Forms.TextBox txtKDBhn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnmBhn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnDel;
        public System.Windows.Forms.Button btnOpen;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd1;
        public System.Windows.Forms.Button btnDel1;
        public System.Windows.Forms.Button btnOpen1;
        private System.Windows.Forms.DataGridView dgvSupply;
        private System.Windows.Forms.Label id_Spl;
        private System.Windows.Forms.Label kd_Bahan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTByr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker tglSupp;
        private System.Windows.Forms.TextBox txtKdSupp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtJmlh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button btnUpdate1;
        public System.Windows.Forms.Button btnClear1;
        public System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxnmBhn;
        private System.Windows.Forms.ComboBox cbxnmSup;
        private System.Windows.Forms.Label label13;
    }
}