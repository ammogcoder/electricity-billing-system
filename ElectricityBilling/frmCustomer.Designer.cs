namespace ElectricityBilling
{
    partial class frmCustomer
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
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.ID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeterKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.txtBoxPrevReading1 = new System.Windows.Forms.TextBox();
            this.txtBoxReading = new System.Windows.Forms.TextBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.txtBoxCustomerName = new System.Windows.Forms.TextBox();
            this.txtBoxCustomerID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBoxUnitPrice2 = new System.Windows.Forms.TextBox();
            this.btnUpdateDetail = new System.Windows.Forms.Button();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.txtBoxPrevReading = new System.Windows.Forms.TextBox();
            this.txtBoxReading2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.ID3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentReading = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreviousReading = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Energy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID2,
            this.No,
            this.MeterKey,
            this.CustomerName});
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomer.Location = new System.Drawing.Point(0, 132);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(725, 255);
            this.dgvCustomer.TabIndex = 0;
            this.dgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentClick);
            // 
            // ID2
            // 
            this.ID2.DataPropertyName = "ID";
            this.ID2.HeaderText = "ID";
            this.ID2.Name = "ID2";
            // 
            // No
            // 
            this.No.DataPropertyName = "No";
            this.No.HeaderText = "No";
            this.No.Name = "No";
            // 
            // MeterKey
            // 
            this.MeterKey.DataPropertyName = "MeterKey";
            this.MeterKey.HeaderText = "Customer ID";
            this.MeterKey.Name = "MeterKey";
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1253, 65);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Muol Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(548, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "អតិថិជន";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtFilter);
            this.panel2.Controls.Add(this.txtBoxPrevReading1);
            this.panel2.Controls.Add(this.txtBoxReading);
            this.panel2.Controls.Add(this.dtp);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAddNew);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtBoxUnitPrice);
            this.panel2.Controls.Add(this.txtBoxCustomerName);
            this.panel2.Controls.Add(this.txtBoxCustomerID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(725, 132);
            this.panel2.TabIndex = 2;
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(554, 72);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(150, 26);
            this.txtFilter.TabIndex = 9;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // txtBoxPrevReading1
            // 
            this.txtBoxPrevReading1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPrevReading1.Location = new System.Drawing.Point(333, 40);
            this.txtBoxPrevReading1.Name = "txtBoxPrevReading1";
            this.txtBoxPrevReading1.Size = new System.Drawing.Size(150, 26);
            this.txtBoxPrevReading1.TabIndex = 8;
            this.txtBoxPrevReading1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxReading_KeyPress);
            // 
            // txtBoxReading
            // 
            this.txtBoxReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxReading.Location = new System.Drawing.Point(333, 10);
            this.txtBoxReading.Name = "txtBoxReading";
            this.txtBoxReading.Size = new System.Drawing.Size(150, 26);
            this.txtBoxReading.TabIndex = 8;
            this.txtBoxReading.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxReading_KeyPress);
            // 
            // dtp
            // 
            this.dtp.CustomFormat = "MM - yyyy";
            this.dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp.Location = new System.Drawing.Point(333, 70);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(150, 26);
            this.dtp.TabIndex = 7;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(431, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(269, 100);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Edit";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(350, 100);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 3;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(188, 100);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Unit Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Customer Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(511, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Search";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(244, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Previous Reading";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Current Reading";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "From Month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer ID";
            // 
            // txtBoxUnitPrice
            // 
            this.txtBoxUnitPrice.Font = new System.Drawing.Font("Khmer UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUnitPrice.Location = new System.Drawing.Point(87, 70);
            this.txtBoxUnitPrice.Name = "txtBoxUnitPrice";
            this.txtBoxUnitPrice.Size = new System.Drawing.Size(146, 26);
            this.txtBoxUnitPrice.TabIndex = 0;
            // 
            // txtBoxCustomerName
            // 
            this.txtBoxCustomerName.Font = new System.Drawing.Font("Khmer UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCustomerName.Location = new System.Drawing.Point(87, 39);
            this.txtBoxCustomerName.Name = "txtBoxCustomerName";
            this.txtBoxCustomerName.Size = new System.Drawing.Size(146, 26);
            this.txtBoxCustomerName.TabIndex = 0;
            // 
            // txtBoxCustomerID
            // 
            this.txtBoxCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCustomerID.Location = new System.Drawing.Point(87, 11);
            this.txtBoxCustomerID.Name = "txtBoxCustomerID";
            this.txtBoxCustomerID.Size = new System.Drawing.Size(146, 24);
            this.txtBoxCustomerID.TabIndex = 0;
            this.txtBoxCustomerID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxCustomerID_KeyPress);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.splitContainer1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1253, 387);
            this.panel3.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvCustomer);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.dgvDetail);
            this.splitContainer1.Size = new System.Drawing.Size(1253, 387);
            this.splitContainer1.SplitterDistance = 725;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.txtBoxUnitPrice2);
            this.panel4.Controls.Add(this.btnUpdateDetail);
            this.panel4.Controls.Add(this.dtp2);
            this.panel4.Controls.Add(this.txtBoxPrevReading);
            this.panel4.Controls.Add(this.txtBoxReading2);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(524, 107);
            this.panel4.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(243, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Unit Price";
            // 
            // txtBoxUnitPrice2
            // 
            this.txtBoxUnitPrice2.Font = new System.Drawing.Font("Khmer UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUnitPrice2.Location = new System.Drawing.Point(312, 46);
            this.txtBoxUnitPrice2.Name = "txtBoxUnitPrice2";
            this.txtBoxUnitPrice2.Size = new System.Drawing.Size(146, 26);
            this.txtBoxUnitPrice2.TabIndex = 4;
            // 
            // btnUpdateDetail
            // 
            this.btnUpdateDetail.Location = new System.Drawing.Point(18, 78);
            this.btnUpdateDetail.Name = "btnUpdateDetail";
            this.btnUpdateDetail.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateDetail.TabIndex = 3;
            this.btnUpdateDetail.Text = "Update";
            this.btnUpdateDetail.UseVisualStyleBackColor = true;
            this.btnUpdateDetail.Click += new System.EventHandler(this.btnUpdateDetail_Click);
            // 
            // dtp2
            // 
            this.dtp2.CustomFormat = "MM-yyyy";
            this.dtp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp2.Location = new System.Drawing.Point(312, 15);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(146, 26);
            this.dtp2.TabIndex = 2;
            this.dtp2.ValueChanged += new System.EventHandler(this.dtp2_ValueChanged);
            // 
            // txtBoxPrevReading
            // 
            this.txtBoxPrevReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPrevReading.Location = new System.Drawing.Point(105, 47);
            this.txtBoxPrevReading.Name = "txtBoxPrevReading";
            this.txtBoxPrevReading.Size = new System.Drawing.Size(132, 26);
            this.txtBoxPrevReading.TabIndex = 1;
            this.txtBoxPrevReading.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxReading2_KeyPress);
            // 
            // txtBoxReading2
            // 
            this.txtBoxReading2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxReading2.Location = new System.Drawing.Point(105, 15);
            this.txtBoxReading2.Name = "txtBoxReading2";
            this.txtBoxReading2.Size = new System.Drawing.Size(132, 26);
            this.txtBoxReading2.TabIndex = 1;
            this.txtBoxReading2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxReading2_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Previous Reading";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Current Reading";
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID3,
            this.Month3,
            this.Year3,
            this.CurrentReading,
            this.PreviousReading,
            this.Energy,
            this.UnitPrice2,
            this.Date});
            this.dgvDetail.Location = new System.Drawing.Point(0, 107);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetail.Size = new System.Drawing.Size(524, 280);
            this.dgvDetail.TabIndex = 0;
            this.dgvDetail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvDetail_MouseClick);
            // 
            // ID3
            // 
            this.ID3.DataPropertyName = "ID";
            this.ID3.HeaderText = "ID";
            this.ID3.Name = "ID3";
            // 
            // Month3
            // 
            this.Month3.DataPropertyName = "Month";
            this.Month3.HeaderText = "Month";
            this.Month3.Name = "Month3";
            // 
            // Year3
            // 
            this.Year3.DataPropertyName = "Year";
            this.Year3.HeaderText = "Year";
            this.Year3.Name = "Year3";
            // 
            // CurrentReading
            // 
            this.CurrentReading.DataPropertyName = "CurrentReading";
            this.CurrentReading.HeaderText = "Current Reading";
            this.CurrentReading.Name = "CurrentReading";
            // 
            // PreviousReading
            // 
            this.PreviousReading.DataPropertyName = "PreviousReading";
            this.PreviousReading.HeaderText = "Previous Reading";
            this.PreviousReading.Name = "PreviousReading";
            // 
            // Energy
            // 
            this.Energy.DataPropertyName = "ConsumptionEnergy";
            this.Energy.HeaderText = "Energy";
            this.Energy.Name = "Energy";
            // 
            // UnitPrice2
            // 
            this.UnitPrice2.DataPropertyName = "UnitPrice";
            this.UnitPrice2.HeaderText = "Unit Price";
            this.UnitPrice2.Name = "UnitPrice2";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 452);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCustomer";
            this.Text = "frmCustomer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxCustomerName;
        private System.Windows.Forms.TextBox txtBoxCustomerID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxReading;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtBoxReading2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUpdateDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeterKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxPrevReading;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxPrevReading1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBoxUnitPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBoxUnitPrice2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentReading;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreviousReading;
        private System.Windows.Forms.DataGridViewTextBoxColumn Energy;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}