using System;
using System.Collections.Generic;
using System.Windows.Forms;
using warehouse24.Models.ORM;
using warehouse24.Models.Classes;

namespace warehouse24.DataBase
{
    public partial class ShippmentForm : Form
    {
        public ShippmentForm()
        {
            InitializeComponent();
            ShowCompoBoxItems();
        }

        private void Shipment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'warehouse24DataSet.Shipment' table. You can move, or remove it, as needed.
            this.shipmentTableAdapter.Fill(this.warehouse24DataSet.Shipment);

        }

        private void butBack_Click(object sender, EventArgs e)
        {
            DataBaseForm dataBase = new DataBaseForm();
            dataBase.StartPosition = FormStartPosition.CenterScreen;
            dataBase.Show();
            this.Hide();
        }

        private void butAddShipment_Click(object sender, EventArgs e)
        {
            if (textBoxShippmentName.Text != "" &&
                (float)numericUpDownTariff.Value != 0 &&
                (float)numericUpDownCost.Value != 0 &&
                dateTimePickerTimeShippment.Value != null)
            {
                string newShippmenteName = textBoxShippmentName.Text;

                float Newtariff = (float)numericUpDownTariff.Value;
                float Cost = (float)numericUpDownCost.Value;
                DateTime Time = dateTimePickerTimeShippment.Value;
                ORM orm = new ORM();
                orm.AddShippment(newShippmenteName, Newtariff, Cost, Time);
                toolStripStatusLabel1.Text = newShippmenteName + "HaS BEEN ADD";
                ShippmentForm shippment = new ShippmentForm();
                shippment.StartPosition = FormStartPosition.CenterScreen;
                shippment.Show();
                this.shipmentTableAdapter.Fill(this.warehouse24DataSet.Shipment);
                this.Close();
            }
            else
            {
                toolStripStatusLabel1.Text = "Please Add the Shipment Name";
            }

        }

        private void butDeletShippment_Click(object sender, EventArgs e)
        {

            if (textBoxShippmentName.Text != "")
            {
                string newshippmentName = textBoxShippmentName.Text;

                ORM orm = new ORM();
                orm.DeleteShippment(newshippmentName);
                toolStripStatusLabel1.Text = newshippmentName + "HaS BEEN Deleted";
                ShippmentForm shippment = new ShippmentForm();
                shippment.StartPosition = FormStartPosition.CenterScreen;
                shippment.Show();
                this.shipmentTableAdapter.Fill(this.warehouse24DataSet.Shipment);
                this.Close();
            }
            else
            {
                toolStripStatusLabel1.Text = "Please Add the Shippment Name That you want to Delete ";
            }

        }

        private void butEditShippment_Click(object sender, EventArgs e)
        {
            if (textBoxShippmentName.Text != "" && (int)numericUpDownId.Value != 0 && (float)numericUpDownTariff.Value != 0
                && (float)numericUpDownCost.Value != 0 && dateTimePickerTimeShippment.Value != null)
            {
                string newshippmentName = textBoxShippmentName.Text;
                int idshippment = (int)numericUpDownId.Value;
                float newtariff = (float)numericUpDownTariff.Value;
                float newcost = (float)numericUpDownCost.Value;
                int newid_com = (int)numericUpDownId.Value;
                DateTime newtimeshippment = dateTimePickerTimeShippment.Value;
                ORM orm = new ORM();
                orm.EditShippment(idshippment, newshippmentName, newtariff, newcost, newtimeshippment, newid_com);
                toolStripStatusLabel1.Text = newshippmentName + "HaS BEEN Edit";
                ShippmentForm shippment = new ShippmentForm();
                shippment.StartPosition = FormStartPosition.CenterScreen;
                shippment.Show();
                this.shipmentTableAdapter.Fill(this.warehouse24DataSet.Shipment);
                this.Close();
            }
            else
            {
                toolStripStatusLabel1.Text = "Please Add the Shippment Name and ID";
            }
        }

        private void ShowCompoBoxItems() 
        {
            ORM orm = new ORM();
            List<ShippmentCompany> companies = new List<ShippmentCompany>();
            companies = orm.SelectCompanyNames();
            comboBoxComID.DataSource = companies;

        }
        private void comboBoxComID_SelectedIndexChanged(object sender, EventArgs e)
        {
               

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxShippmentName_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
    

  

