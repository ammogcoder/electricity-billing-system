using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Service;
using DTO;

namespace ElectricityBilling
{
    public partial class frmConsumption : Form
    {
        /*
        IMeterService meterService;     
        public frmConsumption(IMeterService meterService)
        {
            this.meterService = meterService;
            InitializeComponent();
            loadData();
        }
        */
        int month;
        int year;
        int meterID;
        
        IConsumptionService consumptionService;
        public frmConsumption(IConsumptionService consumptionService)
        {
            this.consumptionService = consumptionService;
            InitializeComponent();
            LoadData();      
        }
        
        public void LoadData()
        {
            IEnumerable<ConsumptionModel> Consumptions = consumptionService.GetConsumptions().Select(c => new ConsumptionModel
            {
                ID = c.ID,
                Month = c.Month,
                Year = c.Year,
                CurrentReading = c.CurrentReading,
                PreviousReading = c.PreviousReading,
                MeterKey = c.Meter.MeterKey,
                MeterID = c.Meter.ID,
                CustomerName = c.Meter.Customer.CustomerName,
                ConsumptionEnergy = c.ConsumptionEnergy,
                UnitPrice = c.UnitPrice
            });

            dgvConsumption.AutoGenerateColumns = false;
            dgvConsumption.DataSource = Consumptions.ToList();

            month = dtp.Value.Month;
            year = dtp.Value.Year;
            //txtUnitPrice.Text = (1000).ToString();
            txtUnitPrice.Text = string.Format("{0:0,0}", 1000);
        }

        private void txtBoxCustomerID_KeyUp(object sender, KeyEventArgs e)
        {
            txtBoxEnergyUsage.Clear();
            txtBoxPrice.Clear();
            txtBoxCurrentReading.Clear();
            string key ="";
            key = txtBoxCustomerID.Text; 

            try
            {
                var consumptions = consumptionService.GetConsumptions().ToList();
                var value = from c in consumptions where c.Meter.MeterKey == key select c;

                if (value.LastOrDefault() != null)
                {
                    txtBoxPreviousReading.Text = value.Select(x => x.CurrentReading).Last().ToString();
                    txtBoxCustomerName.Text = value.Select(x => x.Meter.Customer.CustomerName).Last().ToString();
                    txtBoxCustomerID.BackColor = Color.CornflowerBlue;
                    meterID = Convert.ToInt16(value.Select(x => x.MeterID).Last().ToString());
                    //textBox1.Text = value.Select(x => x.MeterID).Last().ToString();
                }
                else
                {
                    //MessageBox.Show("Id not match! Please enter again!", "Error!", MessageBoxButtons.OK);
                    txtBoxCustomerID.BackColor = Color.Red;
                    //txtBoxCustomerID.Clear();
                    txtBoxCustomerName.Clear();
                    txtBoxPreviousReading.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Invalid! Try again!9999", "Error!", MessageBoxButtons.OK);
            }

        }

        private void txtBoxCurrentReading_KeyUp(object sender, KeyEventArgs e)
        {
            Int64 currentReading = 0;
            Int64 previousReading = 0;
            Int64 totalPrice = 0;
            Int64 energyUsage = 0;
            Int64 unitPrice = 0;
            try
            {
                if (txtBoxCurrentReading.Text != "" && txtUnitPrice.Text !="")
                {
                    bool currReading = Int64.TryParse(txtBoxCurrentReading.Text, out currentReading);
                    if (currReading)
                    {
                        //currentReading = Convert.ToInt64(txtBoxCurrentReading.Text);
                        previousReading = Convert.ToInt64(txtBoxPreviousReading.Text);

                        unitPrice = Convert.ToInt64(txtUnitPrice.Text.Replace(",", ""));

                        energyUsage = currentReading - previousReading;

                        txtBoxEnergyUsage.Text = energyUsage.ToString();
                        totalPrice = energyUsage * unitPrice;
                        txtBoxPrice.Text = string.Format("{0:0,0}", totalPrice);
                    }
                    else
                    {
                        MessageBox.Show("Invalid currend Reading number!", "Error!", MessageBoxButtons.OK);
                        txtBoxCurrentReading.Clear();
                    }
                    
                }
                else
                {
                    txtBoxEnergyUsage.Clear();
                    txtBoxPrice.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Invalid! Try again!", "Error!", MessageBoxButtons.OK);
            }
  
        }
        // validate number input
        private void txtBoxCurrentReading_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch !=8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string dateConsumption = month.ToString() + "-" + year.ToString();
            if (txtBoxCustomerID.Text!="" && txtBoxCurrentReading.Text!="")
            {
                int amount = Convert.ToInt32(txtBoxPrice.Text.Replace(",",""));
                if (amount>=0)
                {
                    Consumption consumptionEntity = new Consumption
                    {
                        Month = month,
                        Year = year,

                        CurrentReading = Convert.ToInt32(txtBoxCurrentReading.Text),
                        PreviousReading = Convert.ToInt32(txtBoxPreviousReading.Text),
                        MeterID = meterID,
                        ConsumptionEnergy = Convert.ToInt32(txtBoxEnergyUsage.Text),
                        UnitPrice = Convert.ToInt32(txtUnitPrice.Text.Replace(",", "")),
                        Date = Convert.ToDateTime(dateConsumption)
                    };

                    consumptionService.InsertConsumption(consumptionEntity);

                    if (consumptionEntity.ID > 0)
                    {
                        LoadData();
                        TotalAmount();

                        txtBoxCustomerID.Clear();
                        txtBoxCurrentReading.Clear();
                        txtBoxCustomerName.Clear();
                        txtBoxEnergyUsage.Clear();
                        txtBoxPreviousReading.Clear();
                        //txtUnitPrice.Clear();
                        txtBoxPrice.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Total Amount cannot be negative", "Error!", MessageBoxButtons.OK);
                }
                
            }
            else
            {
                MessageBox.Show("Customer ID and Current Reading cannot be empty!", "Error!", MessageBoxButtons.OK);
            }
            
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            month = dtp.Value.Month;
            year = dtp.Value.Year;
        }

        private void TotalAmount()
        {
            for (int i = 0; i < dgvConsumption.Rows.Count; i++)
            {
                int amount = Convert.ToInt16(dgvConsumption["ConsumptionEnergy", i].Value.ToString()) * Convert.ToInt16(dgvConsumption["UnitPrice", i].Value.ToString());
                dgvConsumption["Amount", i].Value = string.Format("{0:0,0}", amount);
            }
        }

        private void frmConsumption_Load(object sender, EventArgs e)
        {
            TotalAmount();

            var month = DateTime.Now.AddMonths(-1);
            dtp.Value = month;
        }

        private void txtUnitPrice_KeyUp(object sender, KeyEventArgs e)
        {

            Int64 currentReading = 0;
            Int64 previousReading = 0;
            Int64 totalPrice = 0;
            Int64 energyUsage = 0;
            Int64 unitPrice = 0;
            try
            {
                if (txtBoxCurrentReading.Text != "" && txtUnitPrice.Text != "")
                {
                    bool currReading = Int64.TryParse(txtBoxCurrentReading.Text, out currentReading);
                    if (currReading)
                    {
                        //currentReading = Convert.ToInt64(txtBoxCurrentReading.Text);
                        previousReading = Convert.ToInt64(txtBoxPreviousReading.Text);

                        unitPrice = Convert.ToInt64(txtUnitPrice.Text.Replace(",", ""));

                        energyUsage = currentReading - previousReading;

                        txtBoxEnergyUsage.Text = energyUsage.ToString();
                        totalPrice = energyUsage * unitPrice;
                        txtBoxPrice.Text = string.Format("{0:0,0}", totalPrice);
                    }
                    else
                    {
                        MessageBox.Show("Invalid currend Reading number!", "Error!", MessageBoxButtons.OK);
                        txtBoxCurrentReading.Clear();
                    }
                    
                }
                else
                {
                    txtBoxEnergyUsage.Clear();
                    txtBoxPrice.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Invalid! Try again!", "Error!", MessageBoxButtons.OK);
            }

        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
