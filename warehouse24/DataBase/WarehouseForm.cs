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
    public partial class WarehouseForm : Form
    {
        public WarehouseForm()
        {
            InitializeComponent();
        }

        private void Warehouse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'warehouse24DataSet.Warehouse' table. You can move, or remove it, as needed.
            this.warehouseTableAdapter.Fill(this.warehouse24DataSet.Warehouse);

        }

        private void butBack_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
