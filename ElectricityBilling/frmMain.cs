using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Practices.Unity;
using Service;
using DTO;
using DAL;
using System.Threading;

namespace ElectricityBilling
{
    public partial class frmMain : Form
    {
        Image closeImage, closeImageAct;
        public frmMain()
        {
            Thread t = new Thread(new ThreadStart(StartFormSplashScreen));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
            //tabInit();
        }
        /*
        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnityContainer container = new UnityContainer();
            container.RegisterType<IDbContext, IoCDbContext>();
            container.RegisterType<IRepository<Customer>, Repository<Customer>>();
            container.RegisterType<ICustomerService, CustomerService>();
            frmCustomer frm = container.Resolve<frmCustomer>();

            //frmCustomer frm = new frmCustomer();
            frm.Show();
        }
        */
        private void AddTabPage(Form frm, string tabName)
        {
            //int t = KTFormTonTai(frm);
            int t = KTFormTonTai(tabName);
            if (t >= 0) // frm da dc mo
            {
                // neu tap da dc chon
                if (tabControl1.SelectedTab == tabControl1.TabPages[t])
                    MessageBox.Show("Tap \"" + tabName + "\" is opening!");
                //MessageBox.Show("Tap \"" + frm.Text.Trim() + "\" is opening!");
                else
                    tabControl1.SelectedTab = tabControl1.TabPages[t];
            }
            else // them 
            {
                //TabPage newTab = new TabPage(frm.Text.Trim());
                TabPage newTab = new TabPage(tabName);
                tabControl1.TabPages.Add(newTab);
                frm.TopLevel = false;
                frm.Parent = newTab;
                tabControl1.SelectedTab = tabControl1.TabPages[tabControl1.TabCount - 1];
                frm.Show();
                frm.Dock = DockStyle.Fill;

            }
        }
        /*
        private int KTFormTonTai(Form frm)
        {
            for (int i = 0; i < tabControl1.TabCount; i++)
                if (tabControl1.TabPages[i].Text == frm.Text.Trim())
                    return i;
            return -1;
        }
        */

        private int KTFormTonTai(string tabName)
        {
            for (int i = 0; i < tabControl1.TabCount; i++)
                if (tabControl1.TabPages[i].Text == tabName.Trim())
                    return i;
            return -1;
        }
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            // minh viet san, khoi mat thoi gian
            Rectangle rect = tabControl1.GetTabRect(e.Index);
            Rectangle imageRec = new Rectangle(rect.Right - closeImage.Width,
                rect.Top + (rect.Height - closeImage.Height) / 2,
                closeImage.Width, closeImage.Height);
            // tang size rect
            rect.Size = new Size(rect.Width + 20, 38);

            Font f;
            Brush br = Brushes.Black;
            StringFormat strF = new StringFormat(StringFormat.GenericDefault);
            // neu tab dang duoc chon
            if (tabControl1.SelectedTab == tabControl1.TabPages[e.Index])
            {
                // hinh mau do, hinh nay them tu properti
                e.Graphics.DrawImage(closeImageAct, imageRec);
                f = new Font("Arial", 10, FontStyle.Bold);
                // Ten tabPage
                e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text,
                    f, br, rect, strF);
            }
            else
            {
                // Tap dang mo, nhung ko dc chon, hinh mau den
                e.Graphics.DrawImage(closeImage, imageRec);
                f = new Font("Arial", 9, FontStyle.Regular);
                // Ten tabPage
                e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text,
                    f, br, rect, strF);
            }
        }

        private void tsBtnCustomer_Click(object sender, EventArgs e)
        {
            UnityContainer container = new UnityContainer();
            container.RegisterType<IDbContext, IoCDbContext>();
            container.RegisterType<IRepository<Meter>, Repository<Meter>>();
            container.RegisterType<IRepository<Customer>, Repository<Customer>>();
            container.RegisterType<ICustomerService, CustomerService>();

            container.RegisterType<IRepository<Consumption>, Repository<Consumption>>();
            container.RegisterType<IConsumptionService, ConsumptionService>();

            frmCustomer frm = container.Resolve<frmCustomer>();
            AddTabPage(frm, "Customers");
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            // Su kien click dong tabpage
            for (int i = 0; i < tabControl1.TabCount; i++)
            {
                // giong o DrawItem
                Rectangle rect = tabControl1.GetTabRect(i);
                Rectangle imageRec = new Rectangle(rect.Right - closeImage.Width,
                    rect.Top + (rect.Height - closeImage.Height) / 2,
                    closeImage.Width, closeImage.Height);

                if (imageRec.Contains(e.Location))
                    tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Size mysize = new System.Drawing.Size(18, 18); // co anh chen vao
            Bitmap bt = new Bitmap(Properties.Resources.close);
            // anh nay ban dau minh da them vao
            Bitmap btm = new Bitmap(bt, mysize);
            closeImageAct = btm;
            //
            //
            Bitmap bt2 = new Bitmap(Properties.Resources.closeBlack);
            // anh nay ban dau minh da them vao
            Bitmap btm2 = new Bitmap(bt2, mysize);
            closeImage = btm2;
            tabControl1.Padding = new Point(30);
        }

        private void tsBtnExit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            if (MessageBox.Show("Do you want to exit?", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Application.Exit();
        }

        private void tsBtnElectricity_Click(object sender, EventArgs e)
        {
            UnityContainer container = new UnityContainer();
            container.RegisterType<IDbContext, IoCDbContext>();
            container.RegisterType<IRepository<Meter>, Repository<Meter>>();
            container.RegisterType<IRepository<Customer>, Repository<Customer>>();
            container.RegisterType<IRepository<Consumption>, Repository<Consumption>>();
            container.RegisterType<IConsumptionService, ConsumptionService>();
            container.RegisterType<IMeterService, MeterService>();

            frmConsumption frm = container.Resolve<frmConsumption>();
            AddTabPage(frm, "Consumpion");
        }

        private void stBtnInvoice_Click(object sender, EventArgs e)
        {
            UnityContainer container = new UnityContainer();
            container.RegisterType<IDbContext, IoCDbContext>();
            container.RegisterType<IRepository<Meter>, Repository<Meter>>();
            container.RegisterType<IRepository<Customer>, Repository<Customer>>();
            container.RegisterType<ICustomerService, CustomerService>();

            container.RegisterType<IRepository<Consumption>, Repository<Consumption>>();
            container.RegisterType<IConsumptionService, ConsumptionService>();

            frmInvoice frm = container.Resolve<frmInvoice>();
            AddTabPage(frm, "Invoices");

            //frmInvoice frm = new frmInvoice();
            //AddTabPage(frm);
        }

        private void tsBtnProfile_Click(object sender, EventArgs e)
        {
            /*
            UnityContainer container = new UnityContainer();
            container.RegisterType<IDbContext, IoCDbContext>();
            container.RegisterType<IRepository<Meter>, Repository<Meter>>();
            container.RegisterType<IRepository<Customer>, Repository<Customer>>();
            container.RegisterType<IRepository<Consumption>, Repository<Consumption>>();
            container.RegisterType<IConsumptionService, ConsumptionService>();

            frmProfile frm = container.Resolve<frmProfile>();
            AddTabPage(frm , "About");
            */
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        public void StartFormSplashScreen()
        {
            Application.Run(new frmSplashScreen());
            
        }

    }
}
