namespace warehouse24.ReportsWindows
{
    partial class ReportsForm
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
            this.buttBack = new System.Windows.Forms.Button();
            this.butBringGoods = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttBack
            // 
            this.buttBack.Location = new System.Drawing.Point(12, 393);
            this.buttBack.Name = "buttBack";
            this.buttBack.Size = new System.Drawing.Size(103, 21);
            this.buttBack.TabIndex = 0;
            this.buttBack.Text = "Back";
            this.buttBack.UseVisualStyleBackColor = true;
            this.buttBack.Click += new System.EventHandler(this.buttBack_Click);
            // 
            // butBringGoods
            // 
            this.butBringGoods.Location = new System.Drawing.Point(10, 312);
            this.butBringGoods.Name = "butBringGoods";
            this.butBringGoods.Size = new System.Drawing.Size(105, 23);
            this.butBringGoods.TabIndex = 1;
            this.butBringGoods.Text = "Bring Goods";
            this.butBringGoods.UseVisualStyleBackColor = true;
            this.butBringGoods.Click += new System.EventHandler(this.butPrint_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butBringGoods);
            this.Controls.Add(this.buttBack);
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttBack;
        private System.Windows.Forms.Button butBringGoods;
    }
}