using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;
using DTO;
using DAL;
using Model;

namespace ElectricityBilling
{
    enum status { View, Insert, Update, Delete};
    public partial class frmCustomer : Form
    {
        status STATUS = status.View;
        int id;
        int month;
        int year;

        int idDetail;
        int month2;
        int year2;

        private ICustomerService customerService;
        private IConsumptionService consumptionService;
        
        public frmCustomer(ICustomerService customerService, IConsumptionService consumptionService)
        {
            this.customerService = customerService;
            this.consumptionService = consumptionService;

            InitializeComponent();

            LoadData();

            txtBoxUnitPrice.Text = string.Format("{0:0,0}", 1000);
            //txtBoxUnitPrice2.Text = string.Format("{0:0,0}", 1000);
        }
        
        private void FillNo()
        {
            for (int i = 1; i <= dgvCustomer.Rows.Count; i++)
                dgvCustomer[1, i - 1].Value = (i < 10 ? "0" + i : i.ToString());
        }
        public void LoadData()
        {
            var Customers = GetData();
            dgvCustomer.AutoGenerateColumns = false;
            dgvCustomer.DataSource = Customers.ToList();
            
            // button initial
            btnAddNew.Enabled = true;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnAddNew.Enabled = true;
            // assign date - month - year
            month = dtp.Value.Month;
            year = dtp.Value.Year;


            // assing date - mont - year in detail gridview
            month = dtp2.Value.Month;
            year = dtp2.Value.Year;
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (STATUS ==status.Update || STATUS == status.View)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvCustomer.Rows[e.RowIndex];
                    txtBoxCustomerID.Text = row.Cells["MeterKey"].Value.ToString();
                    txtBoxCustomerName.Text = row.Cells["CustomerName"].Value.ToString();
                    id = Convert.ToInt16(row.Cells["ID2"].Value.ToString());

                    PassData2dgvDeail();

                    //CalculatePowerConsumption();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(STATUS == status.Insert)
            {
                if (txtBoxCustomerID.Text != "" && txtBoxCustomerName.Text != "" && txtBoxUnitPrice.Text!="" && txtBoxReading.Text!="" && txtBoxPrevReading1.Text!="")
                {
                    int previousReading = 0;
                    int currentReading = 0;
                    bool n1 = Int32.TryParse(txtBoxPrevReading1.Text, out previousReading);
                    bool n2 = Int32.TryParse(txtBoxReading.Text, out currentReading);
                    if (n1 && n2 && (previousReading < currentReading))
                    {
                        Customer customerEntity = new Customer
                        {
                            CustomerKey = txtBoxCustomerID.Text,
                            CustomerName = txtBoxCustomerName.Text,
                            Meter = new Meter
                            {
                                MeterKey = txtBoxCustomerID.Text
                            }

                        };

                        customerService.InsertCustomer(customerEntity);
                        if (customerEntity.ID > 0)
                        {
                            string dateConsumption = month.ToString() + "-" + year.ToString();
                            // insert new consumption
                            Consumption consumptionEntity = new Consumption
                            {
                                Month = month,
                                Year = year,
                                CurrentReading = Convert.ToInt16(txtBoxReading.Text),
                                PreviousReading = Convert.ToInt16(txtBoxPrevReading1.Text),
                                MeterID = customerEntity.ID,
                                ConsumptionEnergy = Convert.ToInt16(txtBoxReading.Text) - Convert.ToInt16(txtBoxPrevReading1.Text),
                                UnitPrice = Convert.ToInt16(txtBoxUnitPrice.Text.Replace(",", "")),
                                Date = Convert.ToDateTime(dateConsumption)
                            };
                            consumptionService.InsertConsumption(consumptionEntity);
                            // load gridview
                            LoadData();

                            PassData2dgvDeail();

                            // clear text box
                            txtBoxCustomerID.Clear();
                            txtBoxCustomerName.Clear();
                            txtBoxReading.Clear();

                            FillNo();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Current Reading must be greater thang Previous Reading", "Error!", MessageBoxButtons.OK);
                    }

                                                      
                }
                else
                {
                    MessageBox.Show("Customer name or Customer Id cannot be emptpy!", "Error!", MessageBoxButtons.OK);
                }
            }

            if(STATUS == status.Update)
            {
                if(txtBoxCustomerID.Text !="" && txtBoxCustomerName.Text != "")
                {
                    Customer customerEntity = customerService.GetCustomer(id);
                    customerEntity.CustomerKey = txtBoxCustomerID.Text;
                    customerEntity.CustomerName = txtBoxCustomerName.Text;
                    customerEntity.Meter.MeterKey = txtBoxCustomerID.Text;
                    customerService.UpdateCustomer(customerEntity);
                    if (customerEntity.ID > 0)
                    {
                        LoadData();
                        FillNo();
                    }
                }
                else
                {
                    MessageBox.Show("Customer name or Customer Id cannot be emptpy!", "Error!", MessageBoxButtons.OK);
                }
                
            }
           
        }

        private void PassData2dgvDeail()
        {
            var cons = consumptionService.GetConsumptions().ToList();
            var getById = from cus in cons where cus.MeterID == id select cus;

            dgvDetail.AutoGenerateColumns = false;
            dgvDetail.DataSource = getById.ToList();
        }
        /*
        private void CalculatePowerConsumption()
        {
            for (int i = 1; i <= dgvDetail.Rows.Count; i++)
            {

                if (i == 1)
                {
                    double value1 = Convert.ToDouble(dgvDetail["CurrentReading", i - 1].Value.ToString());
                    dgvDetail["Energy", i - 1].Value = value1.ToString();
                }

                if (i > 1)
                {
                    double value2 = Convert.ToDouble(dgvDetail["CurrentReading", i - 2].Value.ToString());
                    double value3 = Convert.ToDouble(dgvDetail["CurrentReading", i - 1].Value.ToString());
                    dgvDetail["Energy", i - 1].Value = (value3 - value2).ToString();
                }

            }
        }
        */

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            STATUS = status.Insert;

            txtBoxCustomerID.Clear();
            txtBoxCustomerName.Clear();

            btnAddNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            ChangeTxtboxState();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            STATUS = status.View;

            txtBoxCustomerID.Clear();
            txtBoxCustomerName.Clear();

            btnAddNew.Enabled = true;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnAddNew.Enabled = true;

            ChangeTxtboxState();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            STATUS = status.Update;

            //txtBoxCustomerID.Clear();
            //txtBoxCustomerName.Clear();

            btnAddNew.Enabled = false;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnAddNew.Enabled = false;

            ChangeTxtboxState();
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            month = dtp.Value.Month;
            year = dtp.Value.Year;
        }


        private void dgvDetail_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvDetail.Rows.Count>0)
            {
                txtBoxReading2.Text = dgvDetail.SelectedRows[0].Cells[3].Value.ToString();
                txtBoxPrevReading.Text = dgvDetail.SelectedRows[0].Cells[4].Value.ToString();
                dtp2.Text = dgvDetail.SelectedRows[0].Cells[1].Value.ToString() + "-" + dgvDetail.SelectedRows[0].Cells[2].Value.ToString();
                string UnitPrice = dgvDetail.SelectedRows[0].Cells[6].Value.ToString();
                txtBoxUnitPrice2.Text = string.Format("{0:0,0}", Convert.ToInt16(UnitPrice));
                idDetail = Convert.ToInt16(dgvDetail.SelectedRows[0].Cells[0].Value.ToString());
            } 
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            dgvCustomer.Columns[0].Visible = false;
            FillNo();
            //Hide ID field in Dagridview
            dgvDetail.Columns[0].Visible = false;

            ChangeTxtboxState();
            var month = DateTime.Now.AddMonths(-1);
            dtp.Value = month;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            var Customers = GetData();
            DataView DV = new DataView(Customers.AsDataTable());
            DV.RowFilter = string.Format("MeterKey LIKE '%{0}%'", txtFilter.Text);
            dgvCustomer.DataSource = DV;

            FillNo();
        }

        private IEnumerable<CustomerModel> GetData()
        {
            IEnumerable<CustomerModel> Customers = customerService.GetCustomers().Select(c => new CustomerModel
            {
                ID = c.ID,
                CustomerName = c.CustomerName,
                MeterKey = c.Meter.MeterKey
            });
            return Customers;
        }

        private void btnUpdateDetail_Click(object sender, EventArgs e)
        {
            
            if (txtBoxReading2.Text != "" && txtBoxPrevReading.Text != "")
            {
                int currentReading = 0;
                int prevReading = 0;
                bool n1 = Int32.TryParse(txtBoxReading2.Text, out currentReading);
                bool n2 = Int32.TryParse(txtBoxPrevReading.Text, out prevReading);

                string dateConsumption = month2.ToString() + "-" + year2.ToString();

                if(n1 && n2 && (prevReading < currentReading))
                {
                    var consumptionEntity = consumptionService.GetConsumption(idDetail);
                    consumptionEntity.Month = month2;
                    consumptionEntity.Year = year2;
                    consumptionEntity.CurrentReading = Convert.ToInt16(txtBoxReading2.Text);
                    consumptionEntity.PreviousReading = Convert.ToInt16(txtBoxPrevReading.Text);
                    consumptionEntity.ConsumptionEnergy = Convert.ToInt16(txtBoxReading2.Text) - Convert.ToInt16(txtBoxPrevReading.Text);
                    consumptionEntity.UnitPrice = Convert.ToInt16(txtBoxUnitPrice2.Text.Replace(",", ""));
                    consumptionEntity.Date = Convert.ToDateTime(dateConsumption);
                    consumptionService.UpdateConsumption(consumptionEntity);
                    if (consumptionEntity.ID > 0)
                    {
                        PassData2dgvDeail();
                        //CalculatePowerConsumption();
                    }
                }
                else
                {
                    MessageBox.Show("Previous Reading must be less than Current Reading", "Error");
                }
                
            }
        }

        private void dtp2_ValueChanged(object sender, EventArgs e)
        {
            month2 = dtp2.Value.Month;
            year2 = dtp2.Value.Year;
        }

        private void txtBoxReading_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtBoxReading.MaxLength = 5;
            txtBoxPrevReading1.MaxLength = 5;
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }

        private void txtBoxReading2_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtBoxReading2.MaxLength = 5;
            txtBoxPrevReading.MaxLength = 5;
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtBoxCustomerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtBoxCustomerID.MaxLength = 10;
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            //Keys Enumeration
        }

        private void ChangeTxtboxState()
        {
            if(STATUS == status.View)
            {
                txtBoxCustomerID.Enabled = false;
                txtBoxCustomerName.Enabled = false;
                txtBoxReading.Enabled = false;
                txtBoxPrevReading1.Enabled = false;
                txtBoxUnitPrice.Enabled = false;
                dtp.Enabled = false;
            }else
            {
                txtBoxCustomerID.Enabled = true;
                txtBoxCustomerName.Enabled = true;
                txtBoxReading.Enabled = true;
                txtBoxPrevReading1.Enabled = true;
                txtBoxUnitPrice.Enabled = true;
                dtp.Enabled = true;
            }
        }
    }
}
