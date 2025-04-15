namespace SistemaNotasEscolares
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvStudents = new DataGridView();
            txtSearchStudent = new TextBox();
            label3 = new Label();
            btnAddStudent = new Button();
            txtStudentName = new TextBox();
            label2 = new Label();
            txtStudentId = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            dgvCourses = new DataGridView();
            txtSearchCourse = new TextBox();
            label6 = new Label();
            btnAddCourse = new Button();
            txtCourseName = new TextBox();
            label5 = new Label();
            txtCourseId = new TextBox();
            label4 = new Label();
            tabPage3 = new TabPage();
            dgvGrades = new DataGridView();
            gbFilters = new GroupBox();
            btnClearFilters = new Button();
            btnApplyFilters = new Button();
            cmbFilterCourse = new ComboBox();
            label11 = new Label();
            cmbFilterStudent = new ComboBox();
            label10 = new Label();
            btnAddGrade = new Button();
            txtGradeValue = new TextBox();
            label9 = new Label();
            cmbCourse = new ComboBox();
            label8 = new Label();
            cmbStudent = new ComboBox();
            label7 = new Label();
            tabPage4 = new TabPage();
            btnExportReport = new Button();
            rtbReport = new RichTextBox();
            btnGenerateReport = new Button();
            gbReportType = new GroupBox();
            cmbReportStudent = new ComboBox();
            rbByStudent = new RadioButton();
            rbAllStudents = new RadioButton();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            cargarToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrades).BeginInit();
            gbFilters.SuspendLayout();
            tabPage4.SuspendLayout();
            gbReportType.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 24);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(784, 537);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvStudents);
            tabPage1.Controls.Add(txtSearchStudent);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(btnAddStudent);
            tabPage1.Controls.Add(txtStudentName);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtStudentId);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(776, 509);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Estudiantes";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvStudents
            // 
            dgvStudents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(20, 130);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(700, 300);
            dgvStudents.TabIndex = 7;
            // 
            // txtSearchStudent
            // 
            txtSearchStudent.Location = new Point(130, 90);
            txtSearchStudent.Name = "txtSearchStudent";
            txtSearchStudent.Size = new Size(100, 23);
            txtSearchStudent.TabIndex = 6;
            // 
            // label3
            // 
            label3.Location = new Point(20, 90);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 5;
            label3.Text = "Buscar:";
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(350, 35);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(150, 30);
            btnAddStudent.TabIndex = 4;
            btnAddStudent.Text = "Agregar Estudiante";
            btnAddStudent.UseVisualStyleBackColor = true;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(130, 50);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(100, 23);
            txtStudentName.TabIndex = 3;
            // 
            // label2
            // 
            label2.Location = new Point(20, 50);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 2;
            label2.Text = "Nombre: ";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(130, 20);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(100, 23);
            txtStudentId.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvCourses);
            tabPage2.Controls.Add(txtSearchCourse);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(btnAddCourse);
            tabPage2.Controls.Add(txtCourseName);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(txtCourseId);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(776, 509);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cursos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvCourses
            // 
            dgvCourses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourses.Location = new Point(20, 130);
            dgvCourses.Name = "dgvCourses";
            dgvCourses.Size = new Size(700, 300);
            dgvCourses.TabIndex = 7;
            // 
            // txtSearchCourse
            // 
            txtSearchCourse.Location = new Point(130, 90);
            txtSearchCourse.Name = "txtSearchCourse";
            txtSearchCourse.Size = new Size(210, 23);
            txtSearchCourse.TabIndex = 6;
            // 
            // label6
            // 
            label6.Location = new Point(20, 90);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 5;
            label6.Text = "Buscar: ";
            // 
            // btnAddCourse
            // 
            btnAddCourse.Location = new Point(350, 35);
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Size = new Size(150, 30);
            btnAddCourse.TabIndex = 4;
            btnAddCourse.Text = "Agregar Curso";
            btnAddCourse.UseVisualStyleBackColor = true;
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(130, 50);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(210, 23);
            txtCourseName.TabIndex = 3;
            // 
            // label5
            // 
            label5.Location = new Point(20, 50);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 2;
            label5.Text = "Nombre: ";
            // 
            // txtCourseId
            // 
            txtCourseId.Location = new Point(130, 20);
            txtCourseId.Name = "txtCourseId";
            txtCourseId.Size = new Size(100, 23);
            txtCourseId.TabIndex = 1;
            // 
            // label4
            // 
            label4.Location = new Point(100, 23);
            label4.Name = "label4";
            label4.Size = new Size(20, 20);
            label4.TabIndex = 0;
            label4.Text = "ID: ";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvGrades);
            tabPage3.Controls.Add(gbFilters);
            tabPage3.Controls.Add(btnAddGrade);
            tabPage3.Controls.Add(txtGradeValue);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(cmbCourse);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(cmbStudent);
            tabPage3.Controls.Add(label7);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(776, 509);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Calificaciones";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvGrades
            // 
            dgvGrades.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrades.Location = new Point(20, 210);
            dgvGrades.Name = "dgvGrades";
            dgvGrades.Size = new Size(700, 250);
            dgvGrades.TabIndex = 8;
            // 
            // gbFilters
            // 
            gbFilters.Controls.Add(btnClearFilters);
            gbFilters.Controls.Add(btnApplyFilters);
            gbFilters.Controls.Add(cmbFilterCourse);
            gbFilters.Controls.Add(label11);
            gbFilters.Controls.Add(cmbFilterStudent);
            gbFilters.Controls.Add(label10);
            gbFilters.Location = new Point(20, 120);
            gbFilters.Name = "gbFilters";
            gbFilters.Size = new Size(700, 80);
            gbFilters.TabIndex = 7;
            gbFilters.TabStop = false;
            gbFilters.Text = "Filtros";
            // 
            // btnClearFilters
            // 
            btnClearFilters.Location = new Point(522, 34);
            btnClearFilters.Name = "btnClearFilters";
            btnClearFilters.Size = new Size(120, 30);
            btnClearFilters.TabIndex = 9;
            btnClearFilters.Text = "Limpiar Filtros";
            btnClearFilters.UseVisualStyleBackColor = true;
            // 
            // btnApplyFilters
            // 
            btnApplyFilters.Location = new Point(396, 34);
            btnApplyFilters.Name = "btnApplyFilters";
            btnApplyFilters.Size = new Size(120, 30);
            btnApplyFilters.TabIndex = 8;
            btnApplyFilters.Text = "Aplicar Filtros";
            btnApplyFilters.UseVisualStyleBackColor = true;
            // 
            // cmbFilterCourse
            // 
            cmbFilterCourse.FormattingEnabled = true;
            cmbFilterCourse.Location = new Point(150, 52);
            cmbFilterCourse.Name = "cmbFilterCourse";
            cmbFilterCourse.Size = new Size(202, 23);
            cmbFilterCourse.TabIndex = 8;
            // 
            // label11
            // 
            label11.Location = new Point(20, 55);
            label11.Name = "label11";
            label11.Size = new Size(120, 23);
            label11.TabIndex = 2;
            label11.Text = "Filtrar por Curso:";
            // 
            // cmbFilterStudent
            // 
            cmbFilterStudent.FormattingEnabled = true;
            cmbFilterStudent.Location = new Point(150, 25);
            cmbFilterStudent.Name = "cmbFilterStudent";
            cmbFilterStudent.Size = new Size(202, 23);
            cmbFilterStudent.TabIndex = 1;
            // 
            // label10
            // 
            label10.Location = new Point(20, 25);
            label10.Name = "label10";
            label10.Size = new Size(120, 23);
            label10.TabIndex = 0;
            label10.Text = "Filtrar por Estudiante:";
            // 
            // btnAddGrade
            // 
            btnAddGrade.Location = new Point(350, 50);
            btnAddGrade.Name = "btnAddGrade";
            btnAddGrade.Size = new Size(150, 30);
            btnAddGrade.TabIndex = 6;
            btnAddGrade.Text = "Agregar Calificación";
            btnAddGrade.UseVisualStyleBackColor = true;
            // 
            // txtGradeValue
            // 
            txtGradeValue.Location = new Point(130, 80);
            txtGradeValue.Name = "txtGradeValue";
            txtGradeValue.Size = new Size(202, 23);
            txtGradeValue.TabIndex = 5;
            // 
            // label9
            // 
            label9.Location = new Point(20, 80);
            label9.Name = "label9";
            label9.Size = new Size(100, 23);
            label9.TabIndex = 4;
            label9.Text = "Calificación: ";
            // 
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Location = new Point(130, 50);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(202, 23);
            cmbCourse.TabIndex = 3;
            // 
            // label8
            // 
            label8.Location = new Point(20, 50);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 2;
            label8.Text = "Curso: ";
            // 
            // cmbStudent
            // 
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(130, 20);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(202, 23);
            cmbStudent.TabIndex = 1;
            // 
            // label7
            // 
            label7.Location = new Point(20, 20);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 0;
            label7.Text = "Estudiante: ";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btnExportReport);
            tabPage4.Controls.Add(rtbReport);
            tabPage4.Controls.Add(btnGenerateReport);
            tabPage4.Controls.Add(gbReportType);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(776, 509);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Reportes";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnExportReport
            // 
            btnExportReport.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExportReport.Location = new Point(580, 450);
            btnExportReport.Name = "btnExportReport";
            btnExportReport.Size = new Size(140, 30);
            btnExportReport.TabIndex = 3;
            btnExportReport.Text = "Exportar Reporte";
            btnExportReport.UseVisualStyleBackColor = true;
            // 
            // rtbReport
            // 
            rtbReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbReport.Location = new Point(20, 120);
            rtbReport.Name = "rtbReport";
            rtbReport.ReadOnly = true;
            rtbReport.Size = new Size(700, 296);
            rtbReport.TabIndex = 2;
            rtbReport.Text = "";
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(500, 45);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(150, 30);
            btnGenerateReport.TabIndex = 1;
            btnGenerateReport.Text = "Generar Reporte";
            btnGenerateReport.UseVisualStyleBackColor = true;
            // 
            // gbReportType
            // 
            gbReportType.Controls.Add(cmbReportStudent);
            gbReportType.Controls.Add(rbByStudent);
            gbReportType.Controls.Add(rbAllStudents);
            gbReportType.Location = new Point(20, 20);
            gbReportType.Name = "gbReportType";
            gbReportType.Size = new Size(700, 80);
            gbReportType.TabIndex = 0;
            gbReportType.TabStop = false;
            gbReportType.Text = "Tipo de Reporte";
            // 
            // cmbReportStudent
            // 
            cmbReportStudent.Enabled = false;
            cmbReportStudent.FormattingEnabled = true;
            cmbReportStudent.Location = new Point(268, 21);
            cmbReportStudent.Name = "cmbReportStudent";
            cmbReportStudent.Size = new Size(200, 23);
            cmbReportStudent.TabIndex = 1;
            // 
            // rbByStudent
            // 
            rbByStudent.AutoSize = true;
            rbByStudent.Location = new Point(6, 47);
            rbByStudent.Name = "rbByStudent";
            rbByStudent.Size = new Size(177, 19);
            rbByStudent.TabIndex = 1;
            rbByStudent.TabStop = true;
            rbByStudent.Text = "Calificaciones por Estudiante";
            rbByStudent.UseVisualStyleBackColor = true;
            // 
            // rbAllStudents
            // 
            rbAllStudents.AutoSize = true;
            rbAllStudents.Location = new Point(6, 22);
            rbAllStudents.Name = "rbAllStudents";
            rbAllStudents.Size = new Size(256, 19);
            rbAllStudents.TabIndex = 1;
            rbAllStudents.TabStop = true;
            rbAllStudents.Text = "Todos los Estudiantes con sus Calificaciones";
            rbAllStudents.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, guardarToolStripMenuItem, cargarToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(94, 20);
            guardarToolStripMenuItem.Text = "Guardar Datos";
            // 
            // cargarToolStripMenuItem
            // 
            cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            cargarToolStripMenuItem.Size = new Size(87, 20);
            cargarToolStripMenuItem.Text = "Cargar Datos";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Notas Escolares";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrades).EndInit();
            gbFilters.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            gbReportType.ResumeLayout(false);
            gbReportType.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label label1;
        private Label label2;
        private TextBox txtStudentId;
        private Label label3;
        private Button btnAddStudent;
        private TextBox txtStudentName;
        private DataGridView dgvStudents;
        private TextBox txtSearchStudent;
        private TextBox txtCourseName;
        private Label label5;
        private TextBox txtCourseId;
        private Label label4;
        private TextBox txtSearchCourse;
        private Label label6;
        private Button btnAddCourse;
        private DataGridView dgvCourses;
        private Label label9;
        private ComboBox cmbCourse;
        private Label label8;
        private ComboBox cmbStudent;
        private Label label7;
        private GroupBox gbFilters;
        private Button btnAddGrade;
        private TextBox txtGradeValue;
        private ComboBox cmbFilterCourse;
        private Label label11;
        private ComboBox cmbFilterStudent;
        private Label label10;
        private DataGridView dgvGrades;
        private Button btnClearFilters;
        private Button btnApplyFilters;
        private RadioButton rbAllStudents;
        private GroupBox gbReportType;
        private RadioButton rbByStudent;
        private RichTextBox rtbReport;
        private Button btnGenerateReport;
        private ComboBox cmbReportStudent;
        private Button btnExportReport;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem cargarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}
