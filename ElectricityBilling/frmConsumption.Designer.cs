namespace ElectricityBilling
{
    partial class frmConsumption
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
            this.dgvConsumption = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtBoxEnergyUsage = new System.Windows.Forms.TextBox();
            this.txtBoxCurrentReading = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxPreviousReading = new System.Windows.Forms.TextBox();
            this.txtBoxCustomerName = new System.Windows.Forms.TextBox();
            this.txtBoxCustomerID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MeterKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreviousReading = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentReading = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsumptionEnergy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumption)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsumption
            // 
            this.dgvConsumption.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsumption.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsumption.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MeterKey,
            this.CustomerName,
            this.Month2,
            this.Year2,
            this.PreviousReading,
            this.CurrentReading,
            this.ConsumptionEnergy,
            this.UnitPrice,
            this.Amount});
            this.dgvConsumption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsumption.Location = new System.Drawing.Point(0, 0);
            this.dgvConsumption.Name = "dgvConsumption";
            this.dgvConsumption.Size = new System.Drawing.Size(1327, 287);
            this.dgvConsumption.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1327, 52);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Muol Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(526, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "ប្រើប្រាស់ អគ្គីសនី";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.dtp);
            this.panel2.Controls.Add(this.txtBoxPrice);
            this.panel2.Controls.Add(this.txtUnitPrice);
            this.panel2.Controls.Add(this.txtBoxEnergyUsage);
            this.panel2.Controls.Add(this.txtBoxCurrentReading);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtBoxPreviousReading);
            this.panel2.Controls.Add(this.txtBoxCustomerName);
            this.panel2.Controls.Add(this.txtBoxCustomerID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1327, 121);
            this.panel2.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(45, 83);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Insert";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtp
            // 
            this.dtp.CustomFormat = "MM - yyyy";
            this.dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp.Location = new System.Drawing.Point(1074, 46);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(152, 26);
            this.dtp.TabIndex = 5;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Enabled = false;
            this.txtBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPrice.Location = new System.Drawing.Point(810, 46);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(152, 24);
            this.txtBoxPrice.TabIndex = 4;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(1074, 17);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(152, 24);
            this.txtUnitPrice.TabIndex = 4;
            this.txtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitPrice_KeyPress);
            this.txtUnitPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUnitPrice_KeyUp);
            // 
            // txtBoxEnergyUsage
            // 
            this.txtBoxEnergyUsage.Enabled = false;
            this.txtBoxEnergyUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEnergyUsage.Location = new System.Drawing.Point(810, 17);
            this.txtBoxEnergyUsage.Name = "txtBoxEnergyUsage";
            this.txtBoxEnergyUsage.Size = new System.Drawing.Size(152, 24);
            this.txtBoxEnergyUsage.TabIndex = 4;
            // 
            // txtBoxCurrentReading
            // 
            this.txtBoxCurrentReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCurrentReading.Location = new System.Drawing.Point(499, 46);
            this.txtBoxCurrentReading.Name = "txtBoxCurrentReading";
            this.txtBoxCurrentReading.Size = new System.Drawing.Size(209, 24);
            this.txtBoxCurrentReading.TabIndex = 3;
            this.txtBoxCurrentReading.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxCurrentReading_KeyPress);
            this.txtBoxCurrentReading.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBoxCurrentReading_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Current Reading";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(749, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1017, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1015, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Unit Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(749, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Previous Reading";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer ID/Meter ID";
            // 
            // txtBoxPreviousReading
            // 
            this.txtBoxPreviousReading.Enabled = false;
            this.txtBoxPreviousReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPreviousReading.Location = new System.Drawing.Point(499, 17);
            this.txtBoxPreviousReading.Name = "txtBoxPreviousReading";
            this.txtBoxPreviousReading.Size = new System.Drawing.Size(209, 24);
            this.txtBoxPreviousReading.TabIndex = 1;
            // 
            // txtBoxCustomerName
            // 
            this.txtBoxCustomerName.Enabled = false;
            this.txtBoxCustomerName.Font = new System.Drawing.Font("Khmer UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCustomerName.Location = new System.Drawing.Point(159, 44);
            this.txtBoxCustomerName.Name = "txtBoxCustomerName";
            this.txtBoxCustomerName.Size = new System.Drawing.Size(209, 26);
            this.txtBoxCustomerName.TabIndex = 0;
            // 
            // txtBoxCustomerID
            // 
            this.txtBoxCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCustomerID.Location = new System.Drawing.Point(159, 17);
            this.txtBoxCustomerID.Name = "txtBoxCustomerID";
            this.txtBoxCustomerID.Size = new System.Drawing.Size(209, 24);
            this.txtBoxCustomerID.TabIndex = 0;
            this.txtBoxCustomerID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBoxCustomerID_KeyUp);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvConsumption);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 173);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1327, 287);
            this.panel3.TabIndex = 3;
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
            // Month2
            // 
            this.Month2.DataPropertyName = "Month";
            this.Month2.HeaderText = "Month";
            this.Month2.Name = "Month2";
            // 
            // Year2
            // 
            this.Year2.DataPropertyName = "Year";
            this.Year2.HeaderText = "Year";
            this.Year2.Name = "Year2";
            // 
            // PreviousReading
            // 
            this.PreviousReading.DataPropertyName = "PreviousReading";
            this.PreviousReading.HeaderText = "Previous Reading";
            this.PreviousReading.Name = "PreviousReading";
            // 
            // CurrentReading
            // 
            this.CurrentReading.DataPropertyName = "CurrentReading";
            this.CurrentReading.HeaderText = "CurrentReading";
            this.CurrentReading.Name = "CurrentReading";
            // 
            // ConsumptionEnergy
            // 
            this.ConsumptionEnergy.DataPropertyName = "ConsumptionEnergy";
            this.ConsumptionEnergy.HeaderText = "Consumption";
            this.ConsumptionEnergy.Name = "ConsumptionEnergy";
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // frmConsumption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 460);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsumption";
            this.Text = "frmConsumption";
            this.Load += new System.EventHandler(this.frmConsumption_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumption)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsumption;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBoxCustomerID;
        private System.Windows.Forms.TextBox txtBoxCustomerName;
        private System.Windows.Forms.TextBox txtBoxPreviousReading;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxEnergyUsage;
        private System.Windows.Forms.TextBox txtBoxCurrentReading;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeterKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreviousReading;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentReading;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsumptionEnergy;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}