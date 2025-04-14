namespace Proyecto_Final
{
    partial class FrmReport
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
            lstReport = new ListBox();
            btnLoadAll = new Button();
            SuspendLayout();
            // 
            // lstReport
            // 
            lstReport.FormattingEnabled = true;
            lstReport.ItemHeight = 15;
            lstReport.Location = new Point(390, 126);
            lstReport.Name = "lstReport";
            lstReport.Size = new Size(120, 94);
            lstReport.TabIndex = 0;
            // 
            // btnLoadAll
            // 
            btnLoadAll.Location = new Point(239, 162);
            btnLoadAll.Name = "btnLoadAll";
            btnLoadAll.Size = new Size(75, 23);
            btnLoadAll.TabIndex = 1;
            btnLoadAll.Text = "Cargar Todo";
            btnLoadAll.UseVisualStyleBackColor = true;
            // 
            // FrmReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoadAll);
            Controls.Add(lstReport);
            Name = "FrmReport";
            Text = "FrmReport";
            Load += FrmReport_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstReport;
        private Button btnLoadAll;
    }
}