namespace warehouse24.DataBase
{
    partial class SupplierForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelSUPLIER = new System.Windows.Forms.Label();
            this.butBackSuplier = new System.Windows.Forms.Button();
            this.labelSupplierPhotos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouse24DataSet = new warehouse24.warehouse24DataSet();
            this.butImagePath = new System.Windows.Forms.Button();
            this.butSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBoxImagePath = new System.Windows.Forms.TextBox();
            this.textBoxNameSupplier = new System.Windows.Forms.TextBox();
            this.labelSupplier = new System.Windows.Forms.Label();
            this.pictureBoxSuplierImage = new System.Windows.Forms.PictureBox();
            this.butEditSupplier = new System.Windows.Forms.Button();
            this.butDeleteSupplier = new System.Windows.Forms.Button();
            this.butAddSupplier = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.supplierTableAdapter = new warehouse24.warehouse24DataSetTableAdapters.SupplierTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse24DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSuplierImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSUPLIER
            // 
            this.labelSUPLIER.AutoSize = true;
            this.labelSUPLIER.BackColor = System.Drawing.Color.Transparent;
            this.labelSUPLIER.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSUPLIER.Location = new System.Drawing.Point(12, 9);
            this.labelSUPLIER.Name = "labelSUPLIER";
            this.labelSUPLIER.Size = new System.Drawing.Size(86, 20);
            this.labelSUPLIER.TabIndex = 3;
            this.labelSUPLIER.Text = "SUPLIER";
            // 
            // butBackSuplier
            // 
            this.butBackSuplier.BackColor = System.Drawing.Color.Transparent;
            this.butBackSuplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butBackSuplier.FlatAppearance.BorderSize = 0;
            this.butBackSuplier.Location = new System.Drawing.Point(16, 390);
            this.butBackSuplier.Name = "butBackSuplier";
            this.butBackSuplier.Size = new System.Drawing.Size(135, 31);
            this.butBackSuplier.TabIndex = 4;
            this.butBackSuplier.Text = "Back";
            this.butBackSuplier.UseVisualStyleBackColor = false;
            this.butBackSuplier.Click += new System.EventHandler(this.butBackSuplier_Click);
            // 
            // labelSupplierPhotos
            // 
            this.labelSupplierPhotos.AutoSize = true;
            this.labelSupplierPhotos.BackColor = System.Drawing.Color.Transparent;
            this.labelSupplierPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupplierPhotos.Location = new System.Drawing.Point(725, 60);
            this.labelSupplierPhotos.Name = "labelSupplierPhotos";
            this.labelSupplierPhotos.Size = new System.Drawing.Size(136, 20);
            this.labelSupplierPhotos.TabIndex = 8;
            this.labelSupplierPhotos.Text = "Supplier Photos";
            this.labelSupplierPhotos.Click += new System.EventHandler(this.labelSuplierPhotos_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.supplierBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(469, 267);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.warehouse24DataSet;
            // 
            // warehouse24DataSet
            // 
            this.warehouse24DataSet.DataSetName = "warehouse24DataSet";
            this.warehouse24DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // butImagePath
            // 
            this.butImagePath.BackColor = System.Drawing.Color.Transparent;
            this.butImagePath.Location = new System.Drawing.Point(539, 264);
            this.butImagePath.Name = "butImagePath";
            this.butImagePath.Size = new System.Drawing.Size(97, 23);
            this.butImagePath.TabIndex = 10;
            this.butImagePath.Text = "Import Image ";
            this.butImagePath.UseVisualStyleBackColor = false;
            this.butImagePath.Click += new System.EventHandler(this.butImagePath_Click);
            // 
            // butSearch
            // 
            this.butSearch.BackColor = System.Drawing.Color.Transparent;
            this.butSearch.Location = new System.Drawing.Point(9, 40);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(142, 23);
            this.butSearch.TabIndex = 11;
            this.butSearch.Text = "Search";
            this.butSearch.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(163, 43);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(313, 20);
            this.textBoxSearch.TabIndex = 12;
            // 
            // textBoxImagePath
            // 
            this.textBoxImagePath.Location = new System.Drawing.Point(649, 266);
            this.textBoxImagePath.Name = "textBoxImagePath";
            this.textBoxImagePath.Size = new System.Drawing.Size(239, 20);
            this.textBoxImagePath.TabIndex = 13;
            // 
            // textBoxNameSupplier
            // 
            this.textBoxNameSupplier.Location = new System.Drawing.Point(649, 306);
            this.textBoxNameSupplier.Name = "textBoxNameSupplier";
            this.textBoxNameSupplier.Size = new System.Drawing.Size(246, 20);
            this.textBoxNameSupplier.TabIndex = 14;
            // 
            // labelSupplier
            // 
            this.labelSupplier.AutoSize = true;
            this.labelSupplier.BackColor = System.Drawing.Color.Transparent;
            this.labelSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupplier.Location = new System.Drawing.Point(539, 306);
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new System.Drawing.Size(105, 18);
            this.labelSupplier.TabIndex = 15;
            this.labelSupplier.Text = "Supplier Name";
            // 
            // pictureBoxSuplierImage
            // 
            this.pictureBoxSuplierImage.Location = new System.Drawing.Point(649, 83);
            this.pictureBoxSuplierImage.Name = "pictureBoxSuplierImage";
            this.pictureBoxSuplierImage.Size = new System.Drawing.Size(239, 175);
            this.pictureBoxSuplierImage.TabIndex = 7;
            this.pictureBoxSuplierImage.TabStop = false;
            // 
            // butEditSupplier
            // 
            this.butEditSupplier.BackColor = System.Drawing.Color.Transparent;
            this.butEditSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butEditSupplier.FlatAppearance.BorderSize = 0;
            this.butEditSupplier.Location = new System.Drawing.Point(649, 352);
            this.butEditSupplier.Name = "butEditSupplier";
            this.butEditSupplier.Size = new System.Drawing.Size(87, 47);
            this.butEditSupplier.TabIndex = 2;
            this.butEditSupplier.Text = "Edit Supplier";
            this.butEditSupplier.UseVisualStyleBackColor = false;
            // 
            // butDeleteSupplier
            // 
            this.butDeleteSupplier.BackColor = System.Drawing.Color.Transparent;
            this.butDeleteSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butDeleteSupplier.FlatAppearance.BorderSize = 0;
            this.butDeleteSupplier.Location = new System.Drawing.Point(790, 352);
            this.butDeleteSupplier.Name = "butDeleteSupplier";
            this.butDeleteSupplier.Size = new System.Drawing.Size(98, 47);
            this.butDeleteSupplier.TabIndex = 1;
            this.butDeleteSupplier.Text = "Delete Supplier";
            this.butDeleteSupplier.UseVisualStyleBackColor = false;
            // 
            // butAddSupplier
            // 
            this.butAddSupplier.BackColor = System.Drawing.Color.Transparent;
            this.butAddSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butAddSupplier.FlatAppearance.BorderSize = 0;
            this.butAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.butAddSupplier.Location = new System.Drawing.Point(515, 352);
            this.butAddSupplier.Name = "butAddSupplier";
            this.butAddSupplier.Size = new System.Drawing.Size(83, 47);
            this.butAddSupplier.TabIndex = 0;
            this.butAddSupplier.Text = "Add Supplier";
            this.butAddSupplier.UseVisualStyleBackColor = false;
            this.butAddSupplier.Click += new System.EventHandler(this.butAddSupplier_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(29, 352);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 16;
            this.labelId.Text = "Id";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(62, 350);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown1.TabIndex = 17;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 446);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(939, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Read!!";
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 468);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelSupplier);
            this.Controls.Add(this.textBoxNameSupplier);
            this.Controls.Add(this.textBoxImagePath);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.butImagePath);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelSupplierPhotos);
            this.Controls.Add(this.pictureBoxSuplierImage);
            this.Controls.Add(this.butBackSuplier);
            this.Controls.Add(this.labelSUPLIER);
            this.Controls.Add(this.butEditSupplier);
            this.Controls.Add(this.butDeleteSupplier);
            this.Controls.Add(this.butAddSupplier);
            this.Name = "SupplierForm";
            this.Text = "Suplier";
            this.Load += new System.EventHandler(this.Suplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse24DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSuplierImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAddSupplier;
        private System.Windows.Forms.Button butDeleteSupplier;
        private System.Windows.Forms.Button butEditSupplier;
        private System.Windows.Forms.Label labelSUPLIER;
        private System.Windows.Forms.Button butBackSuplier;
        private System.Windows.Forms.PictureBox pictureBoxSuplierImage;
        private System.Windows.Forms.Label labelSupplierPhotos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butImagePath;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBoxImagePath;
        private System.Windows.Forms.TextBox textBoxNameSupplier;
        private System.Windows.Forms.Label labelSupplier;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private warehouse24DataSet warehouse24DataSet;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private warehouse24DataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}