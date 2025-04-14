namespace Proyecto_Final
{
    partial class FrmCourses
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
            txtCourseName = new TextBox();
            txtTeacher = new TextBox();
            label2 = new Label();
            btnSaveCourse = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(295, 146);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Curso: ";
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(405, 143);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(100, 23);
            txtCourseName.TabIndex = 1;
            // 
            // txtTeacher
            // 
            txtTeacher.Location = new Point(379, 196);
            txtTeacher.Name = "txtTeacher";
            txtTeacher.Size = new Size(100, 23);
            txtTeacher.TabIndex = 3;
            txtTeacher.TextChanged += txtTeacher_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(316, 204);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Profesor: ";
            // 
            // btnSaveCourse
            // 
            btnSaveCourse.Location = new Point(334, 256);
            btnSaveCourse.Name = "btnSaveCourse";
            btnSaveCourse.Size = new Size(120, 23);
            btnSaveCourse.TabIndex = 4;
            btnSaveCourse.Text = "Guardar Curso";
            btnSaveCourse.UseVisualStyleBackColor = true;
            btnSaveCourse.Click += btnSaveCourse_Click;
            // 
            // FrmCourses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaveCourse);
            Controls.Add(txtTeacher);
            Controls.Add(label2);
            Controls.Add(txtCourseName);
            Controls.Add(label1);
            Name = "FrmCourses";
            Text = "FrmCourses";
            Load += FrmCourses_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCourseName;
        private TextBox txtTeacher;
        private Label label2;
        private Button btnSaveCourse;
    }
}