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
    public partial class InvoicesForm : Form
    {
        public InvoicesForm()
        {
            InitializeComponent();
        }

        private void butAddInvoices_Click(object sender, EventArgs e)
        {

        }

        private void Invoices_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'warehouse24DataSet.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.warehouse24DataSet.Invoices);

        }

        private void butBackInvoices_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
