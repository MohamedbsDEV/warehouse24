using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using warehouse24.DataBase;

namespace warehouse24
{
    public partial class DataBaseForm : Form
    {
        public DataBaseForm()
        {
            InitializeComponent();
        }

        private void DataBase_Load(object sender, EventArgs e)
        {
            
        }

        private void butConsumer_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(ConsumerForm));

        }

        private void butGoods_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(GoodsForm));
        }

        
        private void butShipment_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(ShipmentForm));
        }

        private void butWareHouse_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(WarehouseForm));
        }

        private void butSuplier_Click(object sender, EventArgs e)
        {
            //call show windows method 
            ShowForm(typeof(SupplierForm));
        }

        private void butShipmentCom_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(ShipmentCompany));
        }

        //methode to show window
        private void ShowForm(Type window)
        {
            object instance = Activator.CreateInstance(window);
            Form form = (Form)instance;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
            this.Hide();
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.Show();
                this.Close();
            }
        }
    }
}
