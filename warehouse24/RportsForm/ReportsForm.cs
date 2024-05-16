using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warehouse24.ReportsWindows
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()

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

        private void butPrint_Click(object sender, EventArgs e)
        {

        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
