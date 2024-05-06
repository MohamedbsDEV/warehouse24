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
    public partial class ConsumerForm : Form
    {
        public ConsumerForm()
        {
            InitializeComponent();
        }

        private void labelCONSUMER_Click(object sender, EventArgs e)
        {

        }

        private void Consumer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'warehouse24DataSet.Consumer' table. You can move, or remove it, as needed.
            this.consumerTableAdapter.Fill(this.warehouse24DataSet.Consumer);

        }

        private void butBackConsu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
