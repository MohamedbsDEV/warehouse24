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
    public partial class SuplierForm : Form
    {
        public SuplierForm()
        {
            InitializeComponent();
        }

        private void labelSuplierPhotos_Click(object sender, EventArgs e)
        {

        }

        private void Suplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'warehouse24DataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.warehouse24DataSet.Supplier);

        }

        private void butBackSuplier_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
