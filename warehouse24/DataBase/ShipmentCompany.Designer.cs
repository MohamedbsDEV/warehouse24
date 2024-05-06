namespace warehouse24.DataBase
{
    partial class ShipmentCompany
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
            this.butAddShipmentCompany = new System.Windows.Forms.Button();
            this.butEditShipmentCompany = new System.Windows.Forms.Button();
            this.butDeleteShipmentCompany = new System.Windows.Forms.Button();
            this.butBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipmentcoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouse24DataSet = new warehouse24.warehouse24DataSet();
            this.shipment_coTableAdapter = new warehouse24.warehouse24DataSetTableAdapters.Shipment_coTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNameShipmentCompany = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentcoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse24DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // butAddShipmentCompany
            // 
            this.butAddShipmentCompany.BackColor = System.Drawing.Color.Transparent;
            this.butAddShipmentCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butAddShipmentCompany.FlatAppearance.BorderSize = 0;
            this.butAddShipmentCompany.Location = new System.Drawing.Point(14, 365);
            this.butAddShipmentCompany.Name = "butAddShipmentCompany";
            this.butAddShipmentCompany.Size = new System.Drawing.Size(183, 29);
            this.butAddShipmentCompany.TabIndex = 0;
            this.butAddShipmentCompany.Text = "Add Shipment Company";
            this.butAddShipmentCompany.UseVisualStyleBackColor = false;
            // 
            // butEditShipmentCompany
            // 
            this.butEditShipmentCompany.BackColor = System.Drawing.Color.Transparent;
            this.butEditShipmentCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butEditShipmentCompany.FlatAppearance.BorderSize = 0;
            this.butEditShipmentCompany.Location = new System.Drawing.Point(12, 437);
            this.butEditShipmentCompany.Name = "butEditShipmentCompany";
            this.butEditShipmentCompany.Size = new System.Drawing.Size(183, 29);
            this.butEditShipmentCompany.TabIndex = 1;
            this.butEditShipmentCompany.Text = "EditShipmentCompany";
            this.butEditShipmentCompany.UseVisualStyleBackColor = false;
            // 
            // butDeleteShipmentCompany
            // 
            this.butDeleteShipmentCompany.BackColor = System.Drawing.Color.Transparent;
            this.butDeleteShipmentCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butDeleteShipmentCompany.FlatAppearance.BorderSize = 0;
            this.butDeleteShipmentCompany.Location = new System.Drawing.Point(12, 401);
            this.butDeleteShipmentCompany.Name = "butDeleteShipmentCompany";
            this.butDeleteShipmentCompany.Size = new System.Drawing.Size(183, 30);
            this.butDeleteShipmentCompany.TabIndex = 2;
            this.butDeleteShipmentCompany.Text = "Delete Shipment Company";
            this.butDeleteShipmentCompany.UseVisualStyleBackColor = false;
            // 
            // butBack
            // 
            this.butBack.BackColor = System.Drawing.Color.Transparent;
            this.butBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butBack.FlatAppearance.BorderSize = 0;
            this.butBack.Location = new System.Drawing.Point(25, 488);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(98, 23);
            this.butBack.TabIndex = 3;
            this.butBack.Text = "Back";
            this.butBack.UseVisualStyleBackColor = false;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.shipmentcoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(376, 255);
            this.dataGridView1.TabIndex = 4;
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
            // shipmentcoBindingSource
            // 
            this.shipmentcoBindingSource.DataMember = "Shipment-co";
            this.shipmentcoBindingSource.DataSource = this.warehouse24DataSet;
            // 
            // warehouse24DataSet
            // 
            this.warehouse24DataSet.DataSetName = "warehouse24DataSet";
            this.warehouse24DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shipment_coTableAdapter
            // 
            this.shipment_coTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name Shipment Company";
            // 
            // textBoxNameShipmentCompany
            // 
            this.textBoxNameShipmentCompany.Location = new System.Drawing.Point(146, 325);
            this.textBoxNameShipmentCompany.Name = "textBoxNameShipmentCompany";
            this.textBoxNameShipmentCompany.Size = new System.Drawing.Size(242, 20);
            this.textBoxNameShipmentCompany.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = " Shipment Company";
            // 
            // ShipmentCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 571);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNameShipmentCompany);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.butDeleteShipmentCompany);
            this.Controls.Add(this.butEditShipmentCompany);
            this.Controls.Add(this.butAddShipmentCompany);
            this.Name = "ShipmentCompany";
            this.Text = "ShipmentCompany";
            this.Load += new System.EventHandler(this.ShipmentCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentcoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse24DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAddShipmentCompany;
        private System.Windows.Forms.Button butEditShipmentCompany;
        private System.Windows.Forms.Button butDeleteShipmentCompany;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private warehouse24DataSet warehouse24DataSet;
        private System.Windows.Forms.BindingSource shipmentcoBindingSource;
        private warehouse24DataSetTableAdapters.Shipment_coTableAdapter shipment_coTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNameShipmentCompany;
        private System.Windows.Forms.Label label2;
    }
}