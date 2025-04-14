
namespace Proyecto_Final
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStudents = new Button();
            btnCourses = new Button();
            btnGrades = new Button();
            btnReport = new Button();
            SuspendLayout();
            // 
            // btnStudents
            // 
            btnStudents.Location = new Point(81, 183);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(129, 23);
            btnStudents.TabIndex = 0;
            btnStudents.Text = "Registrar Estudiante";
            btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);

            // 
            // btnCourses
            // 
            btnCourses.Location = new Point(236, 183);
            btnCourses.Name = "btnCourses";
            btnCourses.Size = new Size(96, 23);
            btnCourses.TabIndex = 1;
            btnCourses.Text = "Registrar Curso";
            btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);

            // 
            // btnGrades
            // 
            btnGrades.Location = new Point(361, 183);
            btnGrades.Name = "btnGrades";
            btnGrades.Size = new Size(90, 23);
            btnGrades.TabIndex = 2;
            btnGrades.Text = "Asignar Nota";
            btnGrades.UseVisualStyleBackColor = true;
            this.btnGrades.Click += new System.EventHandler(this.btnGrades_Click);

            // 
            // btnReport
            // 
            btnReport.Location = new Point(492, 307);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(75, 23);
            btnReport.TabIndex = 3;
            btnReport.Text = "Ver Reporte";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReport);
            Controls.Add(btnGrades);
            Controls.Add(btnCourses);
            Controls.Add(btnStudents);
            Name = "Form1";
            Text = "Sistema de Notas Escolares";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnStudents;
        private Button btnCourses;
        private Button btnGrades;
        private Button btnReport;
    }
}
