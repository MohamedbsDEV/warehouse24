using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using warehouse24.Models.Classes;

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
            
            // TODO: This line of code loads data into the 'warehouse24DataSet.Warehouse' table. You can move, or remove it, as needed.
            this.warehouseTableAdapter.Fill(this.warehouse24DataSet.Warehouse);

        }

        private void butBack_Click(object sender, EventArgs e)
        {
            DataBaseForm dataBase = new DataBaseForm();
            dataBase.StartPosition = FormStartPosition.CenterScreen;
            dataBase.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            ORM orm = new ORM();
            List<Warehouse> warehouses = orm.GetWarehouse();
            string searchText = textBoxSearch.Text;
            List<Warehouse> searchResults = new List<Warehouse>();

            foreach (Warehouse warehouse in warehouses)
            {
                if (warehouse.Name.StartsWith(searchText))
                {
                    searchResults.Add(warehouse);
                }
            }
       
            dataGridView1.DataSource = searchResults;
        }

        private void butAddWareHouse_Click(object sender, EventArgs e)
        {
            if (textBoxNameWareHouse.Text != "")
            {
                string newWareHouseName = textBoxNameWareHouse.Text;

                ORM orm = new ORM();
                orm.AddWareHouse(newWareHouseName);
                toolStripStatusLabel1.Text = newWareHouseName + "HaS BEEN ADD";
                WarehouseForm warehouse = new WarehouseForm();
                warehouse.StartPosition = FormStartPosition.CenterScreen;
                warehouse.Show();
                this.Close();
            }
            else 
            {
                toolStripStatusLabel1.Text = "Please Add the WareHouse Name";
            }
            
        }

        private void butdeleteWareHouse_Click(object sender, EventArgs e)
        {
            if (textBoxNameWareHouse.Text != "")
            {
                string newWareHouseName = textBoxNameWareHouse.Text;

                ORM orm = new ORM();
                orm.DeleteWareHouse(newWareHouseName);
                toolStripStatusLabel1.Text = newWareHouseName + "HaS BEEN Deleted";
                WarehouseForm warehouse = new WarehouseForm();
                warehouse.StartPosition = FormStartPosition.CenterScreen;
                warehouse.Show();
                this.Close();
            }
            else
            {
                toolStripStatusLabel1.Text = "Please Delete the WareHouse Name";
            }

        }
    }
    
}
