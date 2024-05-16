using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using warehouse24.Models.ORM;

namespace warehouse24.DataBase
{
    public partial class ShipmentCompanyForm : Form
    {
        public ShipmentCompanyForm()
        {
            InitializeComponent();
        }

        private void ShipmentCompany_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'warehouse24DataSet._Shipment_co' table. You can move, or remove it, as needed.
            this.shipment_coTableAdapter.Fill(this.warehouse24DataSet.Shipment_co);

        }

        private void butBack_Click(object sender, EventArgs e)
        {
            DataBaseForm dataBase = new DataBaseForm();
            dataBase.StartPosition = FormStartPosition.CenterScreen;
            dataBase.Show();
            this.Hide();
        }

        private void butAddShipmentCompany_Click(object sender, EventArgs e)
        {
            if (textBoxNameShipmentCompany.Text != "")
            {
                string newshipmentcompanyName = textBoxNameShipmentCompany.Text;

                ORM orm = new ORM();
                orm.AddWareHouse(newshipmentcompanyName);
                toolStripStatusLabel1.Text = newshipmentcompanyName + "HaS BEEN ADD";
                ShipmentCompanyForm shipmentcompany = new ShipmentCompanyForm();
                shipmentcompany.StartPosition = FormStartPosition.CenterScreen;
                shipmentcompany.Show();
                this.shipment_coTableAdapter.Fill(this.warehouse24DataSet.Shipment_co);
                this.Close();
            }
            else
            {
                toolStripStatusLabel1.Text = "Please Add the WareHouse Name";
            }
        }

        private void butDeleteShipmentCompany_Click(object sender, EventArgs e)
        {
            if (butDeleteShipmentCompany.Text != "")
            {
                string newshipmentcompanyName = butDeleteShipmentCompany.Text;

                ORM orm = new ORM();
                orm.DeleteWareHouse(newshipmentcompanyName);
                toolStripStatusLabel1.Text = newshipmentcompanyName + "HaS BEEN Deleted";
                ShipmentCompanyForm shipmentcompany = new ShipmentCompanyForm();
                shipmentcompany.StartPosition = FormStartPosition.CenterScreen;
                shipmentcompany.Show();
                this.shipment_coTableAdapter.Fill(this.warehouse24DataSet.Shipment_co);
                this.Close();
               
            }
            else
            {
                toolStripStatusLabel1.Text = "Please Add the ShipmentCompany Name That you want to Delete ";
            }
        }

        private void butEditShipmentCompany_Click(object sender, EventArgs e)
        {
            if (textBoxNameShipmentCompany.Text != "" && (int)numericUpDownId.Value != 0)
            {
                string newshipmentcompanyName = textBoxNameShipmentCompany.Text;
                int idshipmentcompany = (int)numericUpDownId.Value;
                ORM orm = new ORM();
                orm.EditShipmentCompany(idshipmentcompany, newshipmentcompanyName);
                toolStripStatusLabel1.Text = newshipmentcompanyName + "HaS BEEN Edit";
                ShipmentCompanyForm warehouse = new ShipmentCompanyForm();
                warehouse.StartPosition = FormStartPosition.CenterScreen;
                warehouse.Show();
                this.shipment_coTableAdapter.Fill(this.warehouse24DataSet.Shipment_co);
                this.Close();
            }
            else
            {
                toolStripStatusLabel1.Text = "Please Add the ShipmentCompany Name and ID";
            }
        }
    }
}
