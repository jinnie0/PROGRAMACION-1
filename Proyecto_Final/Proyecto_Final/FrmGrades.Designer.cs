namespace Proyecto_Final
{
    partial class FrmGrades
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
            label1 = new Label();
            cmbStudent = new ComboBox();
            cmbCourse = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txtGrade = new TextBox();
            btnSaveGrade = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(309, 139);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Estudiante:";
            // 
            // cmbStudent
            // 
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(380, 136);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(121, 23);
            cmbStudent.TabIndex = 1;
            // 
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Location = new Point(380, 187);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(121, 23);
            cmbCourse.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(318, 190);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 2;
            label2.Text = "Curso:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(321, 239);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 4;
            label3.Text = "Nota";
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(392, 236);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(100, 23);
            txtGrade.TabIndex = 5;
            // 
            // btnSaveGrade
            // 
            btnSaveGrade.Location = new Point(344, 288);
            btnSaveGrade.Name = "btnSaveGrade";
            btnSaveGrade.Size = new Size(115, 23);
            btnSaveGrade.TabIndex = 6;
            btnSaveGrade.Text = "Guardar Nota";
            btnSaveGrade.UseVisualStyleBackColor = true;
            btnSaveGrade.Click += btnSaveGrade_Click;
            // 
            // FrmGrades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaveGrade);
            Controls.Add(txtGrade);
            Controls.Add(label3);
            Controls.Add(cmbCourse);
            Controls.Add(label2);
            Controls.Add(cmbStudent);
            Controls.Add(label1);
            Name = "FrmGrades";
            Text = "FrmGrades";
            Load += FrmGrades_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbStudent;
        private ComboBox cmbCourse;
        private Label label2;
        private Label label3;
        private TextBox txtGrade;
        private Button btnSaveGrade;
    }
}