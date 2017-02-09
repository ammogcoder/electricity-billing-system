using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using Model;
using Service;

namespace ElectricityBilling
{
    public partial class frmInvoice : Form
    {
        private ICustomerService customerService;
        private IConsumptionService consumptionService;

        public frmInvoice(ICustomerService customerService, IConsumptionService consumptionService)
        {
            this.customerService = customerService;
            this.consumptionService = consumptionService;
            InitializeComponent();
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
           
            this.rpReceipt.RefreshReport();
        }

        private void btnLoad_Click(object sender, EventArgs e)
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
                UnitPrice = c.UnitPrice,
                Date = c.Date
            });
            /*
            var result = from con in Consumptions
                         where con.Month >= Convert.ToInt16(dtpFromDate.Value.Month) 
                         && con.Month <= Convert.ToInt16(dtpToDate.Value.Month)
                         && con.Year >= Convert.ToInt16(dtpFromDate.Value.Year)
                         && con.Year <= Convert.ToInt16(dtpToDate.Value.Year)
                         select con;
            */
            //string fromDate = dtpFromDate.Value.Year.ToString() + "-" + dtpFromDate.Value.Month.ToString() + "-" + dtpFromDate.Value.Day.ToString();
            var fromDate = new DateTime(dtpFromDate.Value.Year, dtpFromDate.Value.Month, dtpFromDate.Value.Day);
            //string toDate = dtpToDate.Value.Year.ToString() + "-" + dtpToDate.Value.Month.ToString() + "-" + dtpToDate.Value.Day.ToString();
            var toDate = new DateTime(dtpToDate.Value.Year, dtpToDate.Value.Month, dtpToDate.Value.Day);
            var result = from con in Consumptions
                         where con.Date >= fromDate && con.Date <= toDate
                         select con;
            ConsumptionModelBindingSource.DataSource = result.ToList();
            //ConsumptionModelBindingSource.DataSource = Consumptions.ToList();
            //Convert.ToDateTime(fromDate) && con.Date <= Convert.ToDateTime(toDate)
            
            this.rpReceipt.RefreshReport();

        }

    }
}
