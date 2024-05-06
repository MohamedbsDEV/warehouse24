using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace warehouse24.Invoices
{
    public partial class InvoiceWindow : Form
    {
        public InvoiceWindow()
        {
            InitializeComponent();
        }
       
       
        private void buttBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
            if (mainForm != null)
            {
                mainForm.Show();
                this.Close();
            }
        }
    }
}
