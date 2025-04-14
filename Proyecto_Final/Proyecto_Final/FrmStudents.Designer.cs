namespace Proyecto_Final
{
    partial class FrmStudents
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
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtID = new TextBox();
            btnSaveStudent = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 95);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(331, 129);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Edad: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(322, 157);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Matrícula: ";
            // 
            // txtName
            // 
            txtName.Location = new Point(391, 92);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 3;
            txtName.Click += this.btnStudents_Click;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(391, 124);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 4;
            // 
            // txtID
            // 
            txtID.Location = new Point(391, 157);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 5;
            txtID.TextChanged += txtMatrícula_TextChanged;
            // 
            // btnSaveStudent
            // 
            btnSaveStudent.Location = new Point(350, 206);
            btnSaveStudent.Name = "btnSaveStudent";
            btnSaveStudent.Size = new Size(120, 23);
            btnSaveStudent.TabIndex = 6;
            btnSaveStudent.Text = "Guardar Estudiante";
            btnSaveStudent.UseVisualStyleBackColor = true;
            btnSaveStudent.Click += btnSaveStudent_Click;
            // 
            // FrmStudents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaveStudent);
            Controls.Add(txtID);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmStudents";
            Text = "FrmEstudiantes";
            Load += FrmStudents_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtID;
        private Button btnSaveStudent;
    }
}