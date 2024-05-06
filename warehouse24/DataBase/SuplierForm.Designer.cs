namespace warehouse24.DataBase
{
    partial class SuplierForm
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
            this.labelSuplierPhotos = new System.Windows.Forms.Label();
            this.warehouse24DataSet = new warehouse24.warehouse24DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierTableAdapter = new warehouse24.warehouse24DataSetTableAdapters.SupplierTableAdapter();
            this.butImagePath = new System.Windows.Forms.Button();
            this.butSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBoxImagePath = new System.Windows.Forms.TextBox();
            this.textBoxNameSuplir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxSuplierImage = new System.Windows.Forms.PictureBox();
            this.butEditSuplier = new System.Windows.Forms.Button();
            this.butDeleteSuplier = new System.Windows.Forms.Button();
            this.butAddSuplier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse24DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSuplierImage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSUPLIER
            // 
            this.labelSUPLIER.AutoSize = true;
            this.labelSUPLIER.BackColor = System.Drawing.Color.Transparent;
            this.labelSUPLIER.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSUPLIER.Location = new System.Drawing.Point(511, 9);
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
            this.butBackSuplier.Location = new System.Drawing.Point(12, 394);
            this.butBackSuplier.Name = "butBackSuplier";
            this.butBackSuplier.Size = new System.Drawing.Size(75, 23);
            this.butBackSuplier.TabIndex = 4;
            this.butBackSuplier.Text = "Back";
            this.butBackSuplier.UseVisualStyleBackColor = false;
            this.butBackSuplier.Click += new System.EventHandler(this.butBackSuplier_Click);
            // 
            // labelSuplierPhotos
            // 
            this.labelSuplierPhotos.AutoSize = true;
            this.labelSuplierPhotos.BackColor = System.Drawing.Color.Transparent;
            this.labelSuplierPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuplierPhotos.Location = new System.Drawing.Point(725, 9);
            this.labelSuplierPhotos.Name = "labelSuplierPhotos";
            this.labelSuplierPhotos.Size = new System.Drawing.Size(126, 20);
            this.labelSuplierPhotos.TabIndex = 8;
            this.labelSuplierPhotos.Text = "Suplier Photos";
            this.labelSuplierPhotos.Click += new System.EventHandler(this.labelSuplierPhotos_Click);
            // 
            // warehouse24DataSet
            // 
            this.warehouse24DataSet.DataSetName = "warehouse24DataSet";
            this.warehouse24DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.supplierBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, -3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(469, 267);
            this.dataGridView1.TabIndex = 9;
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
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // butImagePath
            // 
            this.butImagePath.BackColor = System.Drawing.Color.Transparent;
            this.butImagePath.Location = new System.Drawing.Point(649, 244);
            this.butImagePath.Name = "butImagePath";
            this.butImagePath.Size = new System.Drawing.Size(84, 23);
            this.butImagePath.TabIndex = 10;
            this.butImagePath.Text = "Import Image ";
            this.butImagePath.UseVisualStyleBackColor = false;
            // 
            // butSearch
            // 
            this.butSearch.BackColor = System.Drawing.Color.Transparent;
            this.butSearch.Location = new System.Drawing.Point(27, 296);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(75, 23);
            this.butSearch.TabIndex = 11;
            this.butSearch.Text = "Search";
            this.butSearch.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(181, 299);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(246, 20);
            this.textBoxSearch.TabIndex = 12;
            // 
            // textBoxImagePath
            // 
            this.textBoxImagePath.Location = new System.Drawing.Point(759, 244);
            this.textBoxImagePath.Name = "textBoxImagePath";
            this.textBoxImagePath.Size = new System.Drawing.Size(168, 20);
            this.textBoxImagePath.TabIndex = 13;
            // 
            // textBoxNameSuplir
            // 
            this.textBoxNameSuplir.Location = new System.Drawing.Point(181, 338);
            this.textBoxNameSuplir.Name = "textBoxNameSuplir";
            this.textBoxNameSuplir.Size = new System.Drawing.Size(246, 20);
            this.textBoxNameSuplir.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Suplier Name";
            // 
            // pictureBoxSuplierImage
            // 
            this.pictureBoxSuplierImage.Location = new System.Drawing.Point(649, 32);
            this.pictureBoxSuplierImage.Name = "pictureBoxSuplierImage";
            this.pictureBoxSuplierImage.Size = new System.Drawing.Size(239, 175);
            this.pictureBoxSuplierImage.TabIndex = 7;
            this.pictureBoxSuplierImage.TabStop = false;
            // 
            // butEditSuplier
            // 
            this.butEditSuplier.BackColor = System.Drawing.Color.Transparent;
            this.butEditSuplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butEditSuplier.FlatAppearance.BorderSize = 0;
            this.butEditSuplier.Location = new System.Drawing.Point(649, 352);
            this.butEditSuplier.Name = "butEditSuplier";
            this.butEditSuplier.Size = new System.Drawing.Size(87, 47);
            this.butEditSuplier.TabIndex = 2;
            this.butEditSuplier.Text = "Edit Suplier";
            this.butEditSuplier.UseVisualStyleBackColor = false;
            // 
            // butDeleteSuplier
            // 
            this.butDeleteSuplier.BackColor = System.Drawing.Color.Transparent;
            this.butDeleteSuplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butDeleteSuplier.FlatAppearance.BorderSize = 0;
            this.butDeleteSuplier.Location = new System.Drawing.Point(790, 352);
            this.butDeleteSuplier.Name = "butDeleteSuplier";
            this.butDeleteSuplier.Size = new System.Drawing.Size(98, 47);
            this.butDeleteSuplier.TabIndex = 1;
            this.butDeleteSuplier.Text = "Delete Suplier";
            this.butDeleteSuplier.UseVisualStyleBackColor = false;
            // 
            // butAddSuplier
            // 
            this.butAddSuplier.BackColor = System.Drawing.Color.Transparent;
            this.butAddSuplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butAddSuplier.FlatAppearance.BorderSize = 0;
            this.butAddSuplier.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.butAddSuplier.Location = new System.Drawing.Point(515, 352);
            this.butAddSuplier.Name = "butAddSuplier";
            this.butAddSuplier.Size = new System.Drawing.Size(83, 47);
            this.butAddSuplier.TabIndex = 0;
            this.butAddSuplier.Text = "Add Suplier";
            this.butAddSuplier.UseVisualStyleBackColor = false;
            // 
            // SuplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 429);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNameSuplir);
            this.Controls.Add(this.textBoxImagePath);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.butImagePath);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelSuplierPhotos);
            this.Controls.Add(this.pictureBoxSuplierImage);
            this.Controls.Add(this.butBackSuplier);
            this.Controls.Add(this.labelSUPLIER);
            this.Controls.Add(this.butEditSuplier);
            this.Controls.Add(this.butDeleteSuplier);
            this.Controls.Add(this.butAddSuplier);
            this.Name = "SuplierForm";
            this.Text = "Suplier";
            this.Load += new System.EventHandler(this.Suplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.warehouse24DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSuplierImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAddSuplier;
        private System.Windows.Forms.Button butDeleteSuplier;
        private System.Windows.Forms.Button butEditSuplier;
        private System.Windows.Forms.Label labelSUPLIER;
        private System.Windows.Forms.Button butBackSuplier;
        private System.Windows.Forms.PictureBox pictureBoxSuplierImage;
        private System.Windows.Forms.Label labelSuplierPhotos;
        private warehouse24DataSet warehouse24DataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private warehouse24DataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button butImagePath;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBoxImagePath;
        private System.Windows.Forms.TextBox textBoxNameSuplir;
        private System.Windows.Forms.Label label1;
    }
}