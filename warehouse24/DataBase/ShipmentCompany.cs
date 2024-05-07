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

        }

        private void butDeleteShipmentCompany_Click(object sender, EventArgs e)
        {

        }
    }
}
