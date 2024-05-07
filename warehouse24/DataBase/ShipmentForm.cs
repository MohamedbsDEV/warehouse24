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
    public partial class ShipmentForm : Form
    {
        public ShipmentForm()
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
                    ShipmentForm shippment = new ShipmentForm();
                    shippment.StartPosition = FormStartPosition.CenterScreen;
                    shippment.Show();
                    this.Close();
                }
                else
                {
                    toolStripStatusLabel1.Text = "Please Add the Shipment Name";
                }

            }
        }
    }

