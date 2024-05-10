namespace warehouse24.DataBase
{
    partial class WarehouseForm
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
            this.butAddWareHouse = new System.Windows.Forms.Button();
            this.butdeleteWareHouse = new System.Windows.Forms.Button();
            this.butEditWareHouse = new System.Windows.Forms.Button();
            this.labelWAREHOUSE = new System.Windows.Forms.Label();
            this.butBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouse24DataSet = new warehouse24.warehouse24DataSet();
            this.textBoxWareHouseName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.butSearch = new System.Windows.Forms.Button();
            this.warehouseTableAdapter = new warehouse24.warehouse24DataSetTableAdapters.WarehouseTableAdapter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse24DataSet)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).BeginInit();
            this.SuspendLayout();
            // 
            // butAddWareHouse
            // 
            this.butAddWareHouse.BackColor = System.Drawing.Color.Transparent;
            this.butAddWareHouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butAddWareHouse.FlatAppearance.BorderSize = 0;
            this.butAddWareHouse.Location = new System.Drawing.Point(12, 342);
            this.butAddWareHouse.Name = "butAddWareHouse";
            this.butAddWareHouse.Size = new System.Drawing.Size(124, 35);
            this.butAddWareHouse.TabIndex = 0;
            this.butAddWareHouse.Text = "Add WareHouse";
            this.butAddWareHouse.UseVisualStyleBackColor = false;
            this.butAddWareHouse.Click += new System.EventHandler(this.butAddWareHouse_Click);
            // 
            // butdeleteWareHouse
            // 
            this.butdeleteWareHouse.BackColor = System.Drawing.Color.Transparent;
            this.butdeleteWareHouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butdeleteWareHouse.FlatAppearance.BorderSize = 0;
            this.butdeleteWareHouse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.butdeleteWareHouse.Location = new System.Drawing.Point(293, 342);
            this.butdeleteWareHouse.Name = "butdeleteWareHouse";
            this.butdeleteWareHouse.Size = new System.Drawing.Size(123, 35);
            this.butdeleteWareHouse.TabIndex = 1;
            this.butdeleteWareHouse.Text = "Delete WareHouse";
            this.butdeleteWareHouse.UseVisualStyleBackColor = false;
            this.butdeleteWareHouse.Click += new System.EventHandler(this.butdeleteWareHouse_Click);
            // 
            // butEditWareHouse
            // 
            this.butEditWareHouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butEditWareHouse.FlatAppearance.BorderSize = 0;
            this.butEditWareHouse.Location = new System.Drawing.Point(151, 342);
            this.butEditWareHouse.Name = "butEditWareHouse";
            this.butEditWareHouse.Size = new System.Drawing.Size(123, 35);
            this.butEditWareHouse.TabIndex = 2;
            this.butEditWareHouse.Text = "Edit WareHouse";
            this.butEditWareHouse.UseVisualStyleBackColor = true;
            this.butEditWareHouse.Click += new System.EventHandler(this.butEditWareHouse_Click);
            // 
            // labelWAREHOUSE
            // 
            this.labelWAREHOUSE.AutoSize = true;
            this.labelWAREHOUSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWAREHOUSE.Location = new System.Drawing.Point(12, 9);
            this.labelWAREHOUSE.Name = "labelWAREHOUSE";
            this.labelWAREHOUSE.Size = new System.Drawing.Size(87, 13);
            this.labelWAREHOUSE.TabIndex = 3;
            this.labelWAREHOUSE.Text = "WAREHOUSE";
            // 
            // butBack
            // 
            this.butBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butBack.FlatAppearance.BorderSize = 0;
            this.butBack.Location = new System.Drawing.Point(15, 418);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(95, 25);
            this.butBack.TabIndex = 4;
            this.butBack.Text = "Back";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.warehouseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(404, 193);
            this.dataGridView1.TabIndex = 7;
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
            // warehouseBindingSource
            // 
            this.warehouseBindingSource.DataMember = "Warehouse";
            this.warehouseBindingSource.DataSource = this.warehouse24DataSet;
            // 
            // warehouse24DataSet
            // 
            this.warehouse24DataSet.DataSetName = "warehouse24DataSet";
            this.warehouse24DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxWareHouseName
            // 
            this.textBoxWareHouseName.Location = new System.Drawing.Point(131, 316);
            this.textBoxWareHouseName.Name = "textBoxWareHouseName";
            this.textBoxWareHouseName.Size = new System.Drawing.Size(216, 20);
            this.textBoxWareHouseName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "WareHouse Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(166, 54);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(250, 20);
            this.textBoxSearch.TabIndex = 18;
            // 
            // butSearch
            // 
            this.butSearch.BackColor = System.Drawing.Color.Transparent;
            this.butSearch.Location = new System.Drawing.Point(12, 51);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(142, 23);
            this.butSearch.TabIndex = 17;
            this.butSearch.Text = "Search";
            this.butSearch.UseVisualStyleBackColor = false;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // warehouseTableAdapter
            // 
            this.warehouseTableAdapter.ClearBeforeFill = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 454);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(475, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLabel1.Text = "Read!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Id";
            // 
            // numericUpDownId
            // 
            this.numericUpDownId.Location = new System.Drawing.Point(131, 291);
            this.numericUpDownId.Name = "numericUpDownId";
            this.numericUpDownId.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownId.TabIndex = 21;
            // 
            // WarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(475, 476);
            this.Controls.Add(this.numericUpDownId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxWareHouseName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.labelWAREHOUSE);
            this.Controls.Add(this.butEditWareHouse);
            this.Controls.Add(this.butdeleteWareHouse);
            this.Controls.Add(this.butAddWareHouse);
            this.Name = "WarehouseForm";
            this.Text = "Warehouse";
            this.Load += new System.EventHandler(this.Warehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse24DataSet)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAddWareHouse;
        private System.Windows.Forms.Button butdeleteWareHouse;
        private System.Windows.Forms.Button butEditWareHouse;
        private System.Windows.Forms.Label labelWAREHOUSE;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxWareHouseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button butSearch;
        private warehouse24DataSet warehouse24DataSet;
        private System.Windows.Forms.BindingSource warehouseBindingSource;
        private warehouse24DataSetTableAdapters.WarehouseTableAdapter warehouseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownId;
    }
}