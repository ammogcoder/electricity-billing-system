namespace ElectricityBilling
{
    partial class frmMain
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnProfile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnCustomer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnElectricity = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.stBtnInvoice = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnExit = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 396);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(737, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tsBtnCustomer,
            this.toolStripSeparator2,
            this.tsBtnElectricity,
            this.toolStripSeparator3,
            this.stBtnInvoice,
            this.tsBtnProfile,
            this.toolStripSeparator4,
            this.tsBtnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(737, 71);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnProfile
            // 
            this.tsBtnProfile.Image = global::ElectricityBilling.Properties.Resources.profile;
            this.tsBtnProfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnProfile.Margin = new System.Windows.Forms.Padding(2);
            this.tsBtnProfile.Name = "tsBtnProfile";
            this.tsBtnProfile.Size = new System.Drawing.Size(52, 67);
            this.tsBtnProfile.Text = "About";
            this.tsBtnProfile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsBtnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnProfile.Click += new System.EventHandler(this.tsBtnProfile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 71);
            // 
            // tsBtnCustomer
            // 
            this.tsBtnCustomer.Image = global::ElectricityBilling.Properties.Resources.customer;
            this.tsBtnCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.tsBtnCustomer.Name = "tsBtnCustomer";
            this.tsBtnCustomer.Size = new System.Drawing.Size(68, 67);
            this.tsBtnCustomer.Text = "Customers";
            this.tsBtnCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsBtnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnCustomer.Click += new System.EventHandler(this.tsBtnCustomer_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 71);
            // 
            // tsBtnElectricity
            // 
            this.tsBtnElectricity.Image = global::ElectricityBilling.Properties.Resources.money;
            this.tsBtnElectricity.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsBtnElectricity.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnElectricity.Margin = new System.Windows.Forms.Padding(2);
            this.tsBtnElectricity.Name = "tsBtnElectricity";
            this.tsBtnElectricity.Size = new System.Drawing.Size(62, 67);
            this.tsBtnElectricity.Text = "Electricity";
            this.tsBtnElectricity.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsBtnElectricity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnElectricity.Click += new System.EventHandler(this.tsBtnElectricity_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 71);
            // 
            // stBtnInvoice
            // 
            this.stBtnInvoice.Image = global::ElectricityBilling.Properties.Resources.invoice;
            this.stBtnInvoice.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stBtnInvoice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stBtnInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.stBtnInvoice.Name = "stBtnInvoice";
            this.stBtnInvoice.Size = new System.Drawing.Size(54, 67);
            this.stBtnInvoice.Text = "Invoices";
            this.stBtnInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.stBtnInvoice.Click += new System.EventHandler(this.stBtnInvoice_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 71);
            // 
            // tsBtnExit
            // 
            this.tsBtnExit.Image = global::ElectricityBilling.Properties.Resources.exit;
            this.tsBtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnExit.Margin = new System.Windows.Forms.Padding(2);
            this.tsBtnExit.Name = "tsBtnExit";
            this.tsBtnExit.Size = new System.Drawing.Size(52, 67);
            this.tsBtnExit.Text = "Exit";
            this.tsBtnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsBtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnExit.Click += new System.EventHandler(this.tsBtnExit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 25);
            this.tabControl1.Location = new System.Drawing.Point(0, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(737, 325);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 418);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Electricity Billing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnProfile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnCustomer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnElectricity;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton stBtnInvoice;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsBtnExit;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

