using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using warehouse24.Models.Classes;
using warehouse24.Models.ORM;

namespace warehouse24.Invoices
{
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();
            ShowComboBoxItems();
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.Show();
                this.Close();
            }
        }

        private void comboBoxFromWarhouse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ShowComboBoxItems() 
        {
            //ORM 
            ORM orm = new ORM();
            //Show Goods List 
            List<Goods> goodsList = orm.SelectGoodsNames();
            foreach (Goods good in goodsList) 
            {
                comboBoxGoods.Items.Add(good);
            }
            
            //Show Warehouse List
            List<FromWarehouse> warehousesList = orm.SelectWarehouseNames();
            foreach (FromWarehouse warehouse in warehousesList) 
            {
                comboBoxFromWarhouse.Items.Add(warehouse);
            }
            


        }

        private void butInvoice_Click(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();
            FromWarehouse fromWarehouse = new FromWarehouse();
            Goods goods = new Goods();
            goods = (Goods)comboBoxGoods.SelectedItem;  
            ToConsumer toConsumer = new ToConsumer();
            Shippment shippment = new Shippment();
            ShippmentCompany company = new ShippmentCompany();
            company = (ShippmentCompany)comboBoxShippmentCom.SelectedItem;
            shippment.Company = company;
            toConsumer.Name = textBoxConsumerName.Text;
            fromWarehouse = (FromWarehouse)comboBoxFromWarhouse.SelectedItem;
            toConsumer.Id = -1;
            toConsumer.Name = textBoxConsumerName.Text;

            invoice.Id = -1;
            invoice.DateTime = dateTimePickerTimeShippment.Value;
            invoice.FromWarehouses = fromWarehouse;
            invoice.ToConsumer = toConsumer;
            invoice.TypeInvoices = textBoxTypeOfInvoices.Text;
            invoice.Shipment = shippment; 
            invoice.Goods = goods;


        }
    }
}
