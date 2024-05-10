using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warehouse24.DataBase
{
    public partial class ShipmentCompany : Form
    {
        public ShipmentCompany()
        {
            InitializeComponent();
        }

        private void ShipmentCompany_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'warehouse24DataSet._Shipment_co' table. You can move, or remove it, as needed.
            this.shipment_coTableAdapter.Fill(this.warehouse24DataSet._Shipment_co);

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
                ShipmentCompany shipmentcompany = new ShipmentCompany();
                shipmentcompany.StartPosition = FormStartPosition.CenterScreen;
                shipmentcompany.Show();
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
                ShipmentCompany shipmentcompany = new ShipmentCompany();
                shipmentcompany.StartPosition = FormStartPosition.CenterScreen;
                shipmentcompany.Show();
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
                ShipmentCompany warehouse = new ShipmentCompany();
                warehouse.StartPosition = FormStartPosition.CenterScreen;
                warehouse.Show();
                this.Close();
            }
            else
            {
                toolStripStatusLabel1.Text = "Please Add the ShipmentCompany Name and ID";
            }
        }
    }
}
