namespace warehouse24.DataBase
{
    partial class InvoicesForm
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
            this.butAddInvoices = new System.Windows.Forms.Button();
            this.butDeleteInvoices = new System.Windows.Forms.Button();
            this.butEditInvoices = new System.Windows.Forms.Button();
            this.labelINVOICES = new System.Windows.Forms.Label();
            this.butBackInvoices = new System.Windows.Forms.Button();
            this.dateTimePickerInvoice = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeinvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idshipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouse24DataSet = new warehouse24.warehouse24DataSet();
            this.invoicesTableAdapter = new warehouse24.warehouse24DataSetTableAdapters.InvoicesTableAdapter();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelInvoicesType = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBoxInvoicesType = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse24DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // butAddInvoices
            // 
            this.butAddInvoices.BackColor = System.Drawing.Color.Transparent;
            this.butAddInvoices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butAddInvoices.FlatAppearance.BorderSize = 0;
            this.butAddInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAddInvoices.Location = new System.Drawing.Point(393, 317);
            this.butAddInvoices.Name = "butAddInvoices";
            this.butAddInvoices.Size = new System.Drawing.Size(129, 49);
            this.butAddInvoices.TabIndex = 0;
            this.butAddInvoices.Text = "Add Invoices";
            this.butAddInvoices.UseVisualStyleBackColor = false;
            this.butAddInvoices.Click += new System.EventHandler(this.butAddInvoices_Click);
            // 
            // butDeleteInvoices
            // 
            this.butDeleteInvoices.BackColor = System.Drawing.Color.Transparent;
            this.butDeleteInvoices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butDeleteInvoices.FlatAppearance.BorderSize = 0;
            this.butDeleteInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butDeleteInvoices.Location = new System.Drawing.Point(805, 313);
            this.butDeleteInvoices.Name = "butDeleteInvoices";
            this.butDeleteInvoices.Size = new System.Drawing.Size(131, 53);
            this.butDeleteInvoices.TabIndex = 1;
            this.butDeleteInvoices.Text = "Delete Invoices";
            this.butDeleteInvoices.UseVisualStyleBackColor = false;
            // 
            // butEditInvoices
            // 
            this.butEditInvoices.BackColor = System.Drawing.Color.Transparent;
            this.butEditInvoices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butEditInvoices.FlatAppearance.BorderSize = 0;
            this.butEditInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butEditInvoices.Location = new System.Drawing.Point(611, 313);
            this.butEditInvoices.Name = "butEditInvoices";
            this.butEditInvoices.Size = new System.Drawing.Size(125, 53);
            this.butEditInvoices.TabIndex = 2;
            this.butEditInvoices.Text = "EditInvoices";
            this.butEditInvoices.UseVisualStyleBackColor = false;
            // 
            // labelINVOICES
            // 
            this.labelINVOICES.AutoSize = true;
            this.labelINVOICES.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelINVOICES.Location = new System.Drawing.Point(560, 9);
            this.labelINVOICES.Name = "labelINVOICES";
            this.labelINVOICES.Size = new System.Drawing.Size(65, 13);
            this.labelINVOICES.TabIndex = 3;
            this.labelINVOICES.Text = "INVOICES";
            // 
            // butBackInvoices
            // 
            this.butBackInvoices.BackColor = System.Drawing.Color.Transparent;
            
            this.butBackInvoices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butBackInvoices.FlatAppearance.BorderSize = 0;
            this.butBackInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butBackInvoices.Location = new System.Drawing.Point(12, 343);
            this.butBackInvoices.Name = "butBackInvoices";
            this.butBackInvoices.Size = new System.Drawing.Size(75, 23);
            this.butBackInvoices.TabIndex = 4;
            this.butBackInvoices.UseVisualStyleBackColor = false;
            this.butBackInvoices.Click += new System.EventHandler(this.butBackInvoices_Click);
            // 
            // dateTimePickerInvoice
            // 
            this.dateTimePickerInvoice.Location = new System.Drawing.Point(725, 64);
            this.dateTimePickerInvoice.Name = "dateTimePickerInvoice";
            this.dateTimePickerInvoice.Size = new System.Drawing.Size(232, 20);
            this.dateTimePickerInvoice.TabIndex = 5;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(689, 64);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(30, 13);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "Date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.fromDataGridViewTextBoxColumn,
            this.toDataGridViewTextBoxColumn,
            this.typeinvoDataGridViewTextBoxColumn,
            this.idshipDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.invoicesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 244);
            this.dataGridView1.TabIndex = 11;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // fromDataGridViewTextBoxColumn
            // 
            this.fromDataGridViewTextBoxColumn.DataPropertyName = "from";
            this.fromDataGridViewTextBoxColumn.HeaderText = "from";
            this.fromDataGridViewTextBoxColumn.Name = "fromDataGridViewTextBoxColumn";
            // 
            // toDataGridViewTextBoxColumn
            // 
            this.toDataGridViewTextBoxColumn.DataPropertyName = "to";
            this.toDataGridViewTextBoxColumn.HeaderText = "to";
            this.toDataGridViewTextBoxColumn.Name = "toDataGridViewTextBoxColumn";
            // 
            // typeinvoDataGridViewTextBoxColumn
            // 
            this.typeinvoDataGridViewTextBoxColumn.DataPropertyName = "type_invo";
            this.typeinvoDataGridViewTextBoxColumn.HeaderText = "type_invo";
            this.typeinvoDataGridViewTextBoxColumn.Name = "typeinvoDataGridViewTextBoxColumn";
            // 
            // idshipDataGridViewTextBoxColumn
            // 
            this.idshipDataGridViewTextBoxColumn.DataPropertyName = "id_ship";
            this.idshipDataGridViewTextBoxColumn.HeaderText = "id_ship";
            this.idshipDataGridViewTextBoxColumn.Name = "idshipDataGridViewTextBoxColumn";
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "Invoices";
            this.invoicesBindingSource.DataSource = this.warehouse24DataSet;
            // 
            // warehouse24DataSet
            // 
            this.warehouse24DataSet.DataSetName = "warehouse24DataSet";
            this.warehouse24DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(689, 113);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(30, 13);
            this.labelFrom.TabIndex = 12;
            this.labelFrom.Text = "From";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(689, 152);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(20, 13);
            this.labelTo.TabIndex = 13;
            this.labelTo.Text = "To";
            // 
            // labelInvoicesType
            // 
            this.labelInvoicesType.AutoSize = true;
            this.labelInvoicesType.Location = new System.Drawing.Point(662, 192);
            this.labelInvoicesType.Name = "labelInvoicesType";
            this.labelInvoicesType.Size = new System.Drawing.Size(74, 13);
            this.labelInvoicesType.TabIndex = 14;
            this.labelInvoicesType.Text = "Invoices Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(739, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(739, 149);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(217, 21);
            this.comboBox2.TabIndex = 16;
            // 
            // textBoxInvoicesType
            // 
            this.textBoxInvoicesType.Location = new System.Drawing.Point(739, 189);
            this.textBoxInvoicesType.Name = "textBoxInvoicesType";
            this.textBoxInvoicesType.Size = new System.Drawing.Size(218, 20);
            this.textBoxInvoicesType.TabIndex = 17;
            // 
            // InvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 378);
            this.Controls.Add(this.textBoxInvoicesType);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelInvoicesType);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dateTimePickerInvoice);
            this.Controls.Add(this.butBackInvoices);
            this.Controls.Add(this.labelINVOICES);
            this.Controls.Add(this.butEditInvoices);
            this.Controls.Add(this.butDeleteInvoices);
            this.Controls.Add(this.butAddInvoices);
            this.Name = "InvoicesForm";
            this.Text = "Invoices";
            this.Load += new System.EventHandler(this.Invoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse24DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAddInvoices;
        private System.Windows.Forms.Button butDeleteInvoices;
        private System.Windows.Forms.Button butEditInvoices;
        private System.Windows.Forms.Label labelINVOICES;
        private System.Windows.Forms.Button butBackInvoices;
        private System.Windows.Forms.DateTimePicker dateTimePickerInvoice;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private warehouse24DataSet warehouse24DataSet;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private warehouse24DataSetTableAdapters.InvoicesTableAdapter invoicesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeinvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idshipDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelInvoicesType;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBoxInvoicesType;
    }
}