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
            this.Close();
        }
    }
}
