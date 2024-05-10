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
    public partial class ShippmentForm : Form
    {
        public ShippmentForm()
        {
            InitializeComponent();
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
                if (textBoxShippmentName.Text != "")
                {
                    string newShippmenteName = textBoxShippmentName.Text;

                    ORM orm = new ORM();
                    orm.AddShippment(newShippmenteName);
                    toolStripStatusLabel1.Text = newShippmenteName + "HaS BEEN ADD";
                    ShippmentForm shippment = new ShippmentForm();
                    shippment.StartPosition = FormStartPosition.CenterScreen;
                    shippment.Show();
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
                    this.Close();
                }
                else
                {
                    toolStripStatusLabel1.Text = "Please Add the Shippment Name That you want to Delete ";
                }

            }
        private void butEditShippment_Click(object sender, EventArgs e)
        {
            if (textBoxShippmentName.Text != "" && (int)numericUpDownId.Value != 0)
            {
                string newshippmentName = textBoxShippmentName.Text;
                int idshipment = (int)numericUpDownId.Value;
                ORM orm = new ORM();
                orm.EditShippment(idshippment, newshippmentName);
                toolStripStatusLabel1.Text = newshippmentName + "HaS BEEN Edit";
                ShippmentForm shippment = new ShippmentForm();
                shippment.StartPosition = FormStartPosition.CenterScreen;
                shippment.Show();
                this.Close();
            }
            else
            {
                toolStripStatusLabel1.Text = "Please Add the Shippment Name and ID";
            }
        }

     
    }
}
  

