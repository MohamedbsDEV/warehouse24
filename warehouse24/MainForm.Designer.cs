namespace warehouse24
{
    partial class MainForm
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
            this.butExit = new System.Windows.Forms.Button();
            this.butConectDB = new System.Windows.Forms.Button();
            this.butReport = new System.Windows.Forms.Button();
            this.butInvoices = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.butDataBase = new System.Windows.Forms.Button();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butExit
            // 
            this.butExit.BackColor = System.Drawing.Color.DodgerBlue;
            this.butExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExit.ForeColor = System.Drawing.Color.Linen;
            this.butExit.Location = new System.Drawing.Point(66, 340);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(133, 30);
            this.butExit.TabIndex = 1;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = false;
            this.butExit.Click += new System.EventHandler(this.buttClose_Click);
            // 
            // butConectDB
            // 
            this.butConectDB.BackColor = System.Drawing.Color.DodgerBlue;
            this.butConectDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butConectDB.ForeColor = System.Drawing.Color.Linen;
            this.butConectDB.Location = new System.Drawing.Point(66, 12);
            this.butConectDB.Name = "butConectDB";
            this.butConectDB.Size = new System.Drawing.Size(133, 37);
            this.butConectDB.TabIndex = 0;
            this.butConectDB.Text = "Conect DB";
            this.butConectDB.UseVisualStyleBackColor = false;
            this.butConectDB.Click += new System.EventHandler(this.butConectDB_Click);
            // 
            // butReport
            // 
            this.butReport.BackColor = System.Drawing.Color.DodgerBlue;
            this.butReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butReport.ForeColor = System.Drawing.Color.Linen;
            this.butReport.Location = new System.Drawing.Point(66, 125);
            this.butReport.Name = "butReport";
            this.butReport.Size = new System.Drawing.Size(133, 37);
            this.butReport.TabIndex = 4;
            this.butReport.Text = "Reports";
            this.butReport.UseVisualStyleBackColor = false;
            this.butReport.Visible = false;
            this.butReport.Click += new System.EventHandler(this.butReport_Click);
            // 
            // butInvoices
            // 
            this.butInvoices.BackColor = System.Drawing.Color.DodgerBlue;
            this.butInvoices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butInvoices.FlatAppearance.BorderSize = 0;
            this.butInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butInvoices.ForeColor = System.Drawing.Color.Linen;
            this.butInvoices.Location = new System.Drawing.Point(66, 183);
            this.butInvoices.Name = "butInvoices";
            this.butInvoices.Size = new System.Drawing.Size(133, 41);
            this.butInvoices.TabIndex = 5;
            this.butInvoices.Text = "Invoices";
            this.butInvoices.UseVisualStyleBackColor = false;
            this.butInvoices.Visible = false;
            this.butInvoices.Click += new System.EventHandler(this.butInvoices_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 440);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(837, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // butDataBase
            // 
            this.butDataBase.BackColor = System.Drawing.Color.DodgerBlue;
            this.butDataBase.FlatAppearance.BorderSize = 0;
            this.butDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDataBase.ForeColor = System.Drawing.Color.Linen;
            this.butDataBase.Location = new System.Drawing.Point(66, 254);
            this.butDataBase.Name = "butDataBase";
            this.butDataBase.Size = new System.Drawing.Size(133, 41);
            this.butDataBase.TabIndex = 3;
            this.butDataBase.Text = "DataBase";
            this.butDataBase.UseVisualStyleBackColor = false;
            this.butDataBase.Visible = false;
            this.butDataBase.Click += new System.EventHandler(this.butDataBase_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusLabel2.Text = "Ready!!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(837, 462);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.butInvoices);
            this.Controls.Add(this.butReport);
            this.Controls.Add(this.butDataBase);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butConectDB);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button butConectDB;
        private System.Windows.Forms.Button butDataBase;
        private System.Windows.Forms.Button butReport;
        private System.Windows.Forms.Button butInvoices;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}