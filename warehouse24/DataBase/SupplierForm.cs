using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warehouse24.DataBase
{
    public partial class SupplierForm : Form
    {
        public SupplierForm()
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
            // TODO: This line of code loads data into the 'warehouse24DataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.warehouse24DataSet.Supplier);
            
            // TODO: This line of code loads data into the 'warehouse24DataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.warehouse24DataSet.Supplier);

        }

        private void butBackSuplier_Click(object sender, EventArgs e)
        {
            DataBaseForm dataBase = new DataBaseForm();
            dataBase.StartPosition = FormStartPosition.CenterScreen;
            dataBase.Show();
            this.Hide();
        }

        private void butAddSupplier_Click(object sender, EventArgs e)
        {
            if (textBoxNameSupplier.Text != "" && textBoxImagePath.Text != "") 
            {
                string supplierName = textBoxNameSupplier.Text;
                string filePath = textBoxImagePath.Text;
                ORM orm = new ORM();
                orm.AddSupplier(supplierName,filePath);
                toolStripStatusLabel1.Text = supplierName +" Has Been Added!!";

            }
            

        }

        private void butImagePath_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg)|*.jpeg|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        fileContent = reader.ReadToEnd();
                    }

                    // Create a thumbnail image with the same size as pictureBoxSuplierImage
                    using (var originalImage = Image.FromFile(filePath))
                    {
                        var thumbnailImage = originalImage.GetThumbnailImage(pictureBoxSuplierImage.Width, pictureBoxSuplierImage.Height, null, IntPtr.Zero);

                        // Display the resized image in the pictureBoxSuplierImage
                        pictureBoxSuplierImage.Image = thumbnailImage;
                        textBoxImagePath.Text = filePath;
                    }
                }
            }

           
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Assuming the 'photo' column is located at index 1
                if (row.Cells[2].Value != null)
                {
                    byte[] imageBytes = (byte[])row.Cells[1].Value;

                    using (MemoryStream memoryStream = new MemoryStream(imageBytes))
                    {
                        pictureBoxSuplierImage.Image = Image.FromStream(memoryStream);
                    }
                }
                else
                {
                    pictureBoxSuplierImage.Image = null;
                }
            }
        }
    }
}
