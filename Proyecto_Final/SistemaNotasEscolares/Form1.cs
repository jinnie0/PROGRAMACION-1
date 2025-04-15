using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SistemaNotasEscolares.Model;

namespace SistemaNotasEscolares
{
    public partial class Form1 : Form
    {
        private Database database;

        public Form1()
        {
            InitializeComponent();
            database = new Database();

            // Configurar DataGridViews
            SetupDataGridViews();

            // Conectar eventos
            ConnectEvents();
        }

        private void SetupDataGridViews()
        {
            // Configurar DataGridView de estudiantes
            dgvStudents.AutoGenerateColumns = false;
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id",
                Width = 80
            });
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                HeaderText = "Nombre",
                DataPropertyName = "Name",
                Width = 300
            });

            // Configurar DataGridView de cursos
            dgvCourses.AutoGenerateColumns = false;
            dgvCourses.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id",
                Width = 80
            });
            dgvCourses.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                HeaderText = "Nombre",
                DataPropertyName = "Name",
                Width = 300
            });

            // Configurar DataGridView de calificaciones
            dgvGrades.AutoGenerateColumns = false;
            dgvGrades.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Student",
                HeaderText = "Estudiante",
                Width = 200
            });
            dgvGrades.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Course",
                HeaderText = "Curso",
                Width = 200
            });
            dgvGrades.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Value",
                HeaderText = "Calificación",
                Width = 100
            });
        }

        private void ConnectEvents()
        {
            // Eventos para la pestaña de estudiantes
            btnAddStudent.Click += BtnAddStudent_Click;
            txtSearchStudent.TextChanged += TxtSearchStudent_TextChanged;

            // Eventos para la pestaña de cursos
            btnAddCourse.Click += BtnAddCourse_Click;
            txtSearchCourse.TextChanged += TxtSearchCourse_TextChanged;

            // Eventos para la pestaña de calificaciones
            btnAddGrade.Click += BtnAddGrade_Click;
            btnApplyFilters.Click += BtnApplyFilters_Click;
            btnClearFilters.Click += BtnClearFilters_Click;
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;

            // Eventos para la pestaña de reportes
            rbByStudent.CheckedChanged += RbByStudent_CheckedChanged;
            btnGenerateReport.Click += BtnGenerateReport_Click;
            btnExportReport.Click += BtnExportReport_Click;

            // Eventos del menú
            guardarToolStripMenuItem.Click += GuardarToolStripMenuItem_Click;
            cargarToolStripMenuItem.Click += CargarToolStripMenuItem_Click;
            salirToolStripMenuItem.Click += SalirToolStripMenuItem_Click;
        }

        #region Estudiantes

        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar entradas
                if (string.IsNullOrWhiteSpace(txtStudentName.Text))
                {
                    MessageBox.Show("Por favor ingrese un nombre para el estudiante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtStudentId.Text, out int id) || id <= 0)
                {
                    MessageBox.Show("Por favor ingrese un ID válido para el estudiante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verificar duplicados
                if (database.GetStudents().Any(s => s.Id == id))
                {
                    MessageBox.Show("Ya existe un estudiante con este ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear y agregar estudiante
                Student student = new Student(id, txtStudentName.Text);
                database.AddStudent(student);

                // Actualizar DataGridView
                RefreshStudentsGrid();

                // Limpiar campos
                txtStudentId.Clear();
                txtStudentName.Clear();
                txtStudentId.Focus();

                MessageBox.Show("Estudiante agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar estudiante: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtSearchStudent_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtSearchStudent.Text.ToLower();

                var filteredStudents = database.GetStudents()
                    .Where(s => s.Name.ToLower().Contains(searchTerm) || s.Id.ToString().Contains(searchTerm))
                    .ToList();

                dgvStudents.DataSource = null;
                dgvStudents.DataSource = filteredStudents;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar estudiantes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshStudentsGrid()
        {
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = database.GetStudents();
        }

        #endregion

        #region Cursos

        private void BtnAddCourse_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar entradas
                if (string.IsNullOrWhiteSpace(txtCourseName.Text))
                {
                    MessageBox.Show("Por favor ingrese un nombre para el curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtCourseId.Text, out int id) || id <= 0)
                {
                    MessageBox.Show("Por favor ingrese un ID válido para el curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verificar duplicados
                if (database.GetCourses().Any(c => c.Id == id))
                {
                    MessageBox.Show("Ya existe un curso con este ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear y agregar curso
                Course course = new Course(id, txtCourseName.Text);
                database.AddCourse(course);

                // Actualizar DataGridView
                RefreshCoursesGrid();

                // Limpiar campos
                txtCourseId.Clear();
                txtCourseName.Clear();
                txtCourseId.Focus();

                MessageBox.Show("Curso agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar curso: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtSearchCourse_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtSearchCourse.Text.ToLower();

                var filteredCourses = database.GetCourses()
                    .Where(c => c.Name.ToLower().Contains(searchTerm) || c.Id.ToString().Contains(searchTerm))
                    .ToList();

                dgvCourses.DataSource = null;
                dgvCourses.DataSource = filteredCourses;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar cursos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshCoursesGrid()
        {
            dgvCourses.DataSource = null;
            dgvCourses.DataSource = database.GetCourses();
        }

        #endregion

        #region Calificaciones

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2) // Pestaña de Calificaciones
            {
                LoadComboBoxes();
            }
            else if (tabControl1.SelectedIndex == 3) // Pestaña de Reportes
            {
                LoadReportComboBoxes();
            }
        }

        private void LoadComboBoxes()
        {
            // Cargar combo de estudiantes
            cmbStudent.DataSource = null;
            cmbStudent.DisplayMember = "Name";
            cmbStudent.ValueMember = "Id";
            cmbStudent.DataSource = database.GetStudents();
            cmbStudent.SelectedIndex = -1;

            // Cargar combo de cursos
            cmbCourse.DataSource = null;
            cmbCourse.DisplayMember = "Name";
            cmbCourse.ValueMember = "Id";
            cmbCourse.DataSource = database.GetCourses();
            cmbCourse.SelectedIndex = -1;

            // Cargar combos de filtros
            LoadFilterComboBoxes();
        }

        private void LoadFilterComboBoxes()
        {
            // Cargar combo de filtro por estudiante
            cmbFilterStudent.DataSource = null;
            cmbFilterStudent.DisplayMember = "Name";
            cmbFilterStudent.ValueMember = "Id";
            cmbFilterStudent.DataSource = new List<Student>(database.GetStudents());
            cmbFilterStudent.SelectedIndex = -1;

            // Cargar combo de filtro por curso
            cmbFilterCourse.DataSource = null;
            cmbFilterCourse.DisplayMember = "Name";
            cmbFilterCourse.ValueMember = "Id";
            cmbFilterCourse.DataSource = new List<Course>(database.GetCourses());
            cmbFilterCourse.SelectedIndex = -1;
        }

        private void BtnAddGrade_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar selecciones
                if (cmbStudent.SelectedItem == null)
                {
                    MessageBox.Show("Por favor seleccione un estudiante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cmbCourse.SelectedItem == null)
                {
                    MessageBox.Show("Por favor seleccione un curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar calificación
                if (!float.TryParse(txtGradeValue.Text, out float value) || value < 0 || value > 100)
                {
                    MessageBox.Show("Por favor ingrese una calificación válida (0-100).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener estudiante y curso seleccionados
                Student student = (Student)cmbStudent.SelectedItem;
                Course course = (Course)cmbCourse.SelectedItem;

                // Verificar si ya existe una calificación para este estudiante y curso
                if (database.GetGrades().Any(g => g.Student.Id == student.Id && g.Course.Id == course.Id))
                {
                    MessageBox.Show("Ya existe una calificación para este estudiante y curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear y agregar calificación
                Grade grade = new Grade(student, course, value);
                database.AddGrade(grade);

                // Actualizar DataGridView
                RefreshGradesGrid();

                // Limpiar campos
                cmbStudent.SelectedIndex = -1;
                cmbCourse.SelectedIndex = -1;
                txtGradeValue.Clear();
                cmbStudent.Focus();

                MessageBox.Show("Calificación agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar calificación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnApplyFilters_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshGradesGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al aplicar filtros: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClearFilters_Click(object sender, EventArgs e)
        {
            try
            {
                cmbFilterStudent.SelectedIndex = -1;
                cmbFilterCourse.SelectedIndex = -1;
                RefreshGradesGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al limpiar filtros: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshGradesGrid()
        {
            var filteredGrades = database.GetGrades();

            // Aplicar filtros si están seleccionados
            if (cmbFilterStudent.SelectedItem != null)
            {
                Student selectedStudent = (Student)cmbFilterStudent.SelectedItem;
                filteredGrades = filteredGrades.Where(g => g.Student.Id == selectedStudent.Id).ToList();
            }

            if (cmbFilterCourse.SelectedItem != null)
            {
                Course selectedCourse = (Course)cmbFilterCourse.SelectedItem;
                filteredGrades = filteredGrades.Where(g => g.Course.Id == selectedCourse.Id).ToList();
            }

            // Limpiar DataGridView
            dgvGrades.Rows.Clear();

            // Llenar DataGridView con los datos filtrados
            foreach (var grade in filteredGrades)
            {
                dgvGrades.Rows.Add(grade.Student.Name, grade.Course.Name, grade.Value);
            }
        }

        #endregion

        #region Reportes

        private void LoadReportComboBoxes()
        {
            // Cargar combo de estudiantes para reportes
            cmbReportStudent.DataSource = null;
            cmbReportStudent.DisplayMember = "Name";
            cmbReportStudent.ValueMember = "Id";
            cmbReportStudent.DataSource = new List<Student>(database.GetStudents());
            cmbReportStudent.SelectedIndex = -1;
        }

        private void RbByStudent_CheckedChanged(object sender, EventArgs e)
        {
            cmbReportStudent.Enabled = rbByStudent.Checked;
        }

        private void BtnGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si hay datos
                if (database.GetStudents().Count == 0 || database.GetGrades().Count == 0)
                {
                    MessageBox.Show("No hay suficientes datos para generar el reporte.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Validar selección de estudiante si es necesario
                if (rbByStudent.Checked && cmbReportStudent.SelectedItem == null)
                {
                    MessageBox.Show("Por favor seleccione un estudiante para el reporte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Generar el reporte según el tipo seleccionado
                rtbReport.Clear();
                if (rbAllStudents.Checked)
                {
                    GenerateAllStudentsReport();
                }
                else
                {
                    GenerateStudentReport((Student)cmbReportStudent.SelectedItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateAllStudentsReport()
        {
            StringBuilder report = new StringBuilder();
            report.AppendLine("SISTEMA DE NOTAS ESCOLARES - REPORTE GENERAL");
            report.AppendLine("===========================================");
            report.AppendLine();
            report.AppendLine($"Fecha: {DateTime.Now.ToShortDateString()}");
            report.AppendLine($"Hora: {DateTime.Now.ToShortTimeString()}");
            report.AppendLine();
            report.AppendLine($"Total de estudiantes: {database.GetStudents().Count}");
            report.AppendLine($"Total de cursos: {database.GetCourses().Count}");
            report.AppendLine($"Total de calificaciones: {database.GetGrades().Count}");
            report.AppendLine();
            report.AppendLine("CALIFICACIONES POR ESTUDIANTE");
            report.AppendLine("-----------------------------");
            report.AppendLine();

            foreach (var student in database.GetStudents())
            {
                report.AppendLine($"Estudiante: {student.Name} (ID: {student.Id})");
                report.AppendLine("----------------------------------------");

                var studentGrades = database.GetGrades().Where(g => g.Student.Id == student.Id).ToList();
                if (studentGrades.Count > 0)
                {
                    float sum = 0;
                    foreach (var grade in studentGrades)
                    {
                        report.AppendLine($"  Curso: {grade.Course.Name} - Calificación: {grade.Value}");
                        sum += grade.Value;
                    }
                    float average = sum / studentGrades.Count;
                    report.AppendLine($"  Promedio: {average:F2}");
                }
                else
                {
                    report.AppendLine("  No hay calificaciones registradas.");
                }
                report.AppendLine();
            }

            rtbReport.Text = report.ToString();
        }

        private void GenerateStudentReport(Student student)
        {
            StringBuilder report = new StringBuilder();
            report.AppendLine("SISTEMA DE NOTAS ESCOLARES - REPORTE INDIVIDUAL");
            report.AppendLine("==============================================");
            report.AppendLine();
            report.AppendLine($"Fecha: {DateTime.Now.ToShortDateString()}");
            report.AppendLine($"Hora: {DateTime.Now.ToShortTimeString()}");
            report.AppendLine();
            report.AppendLine($"Estudiante: {student.Name}");
            report.AppendLine($"ID: {student.Id}");
            report.AppendLine();
            report.AppendLine("CALIFICACIONES");
            report.AppendLine("-------------");

            var studentGrades = database.GetGrades().Where(g => g.Student.Id == student.Id).ToList();
            if (studentGrades.Count > 0)
            {
                float sum = 0;
                foreach (var grade in studentGrades)
                {
                    report.AppendLine($"  Curso: {grade.Course.Name} - Calificación: {grade.Value}");
                    sum += grade.Value;
                }
                report.AppendLine();
                float average = sum / studentGrades.Count;
                report.AppendLine($"Promedio general: {average:F2}");
                report.AppendLine();
                report.AppendLine("Observaciones:");
                if (average >= 70)
                {
                    report.AppendLine("El estudiante tiene un rendimiento satisfactorio.");
                }
                else
                {
                    report.AppendLine("El estudiante necesita mejorar su rendimiento académico.");
                }
            }
            else
            {
                report.AppendLine("  No hay calificaciones registradas para este estudiante.");
            }

            rtbReport.Text = report.ToString();
        }

        private void BtnExportReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(rtbReport.Text))
                {
                    MessageBox.Show("No hay un reporte para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                saveDialog.Title = "Exportar Reporte";
                saveDialog.FileName = "Reporte_Notas_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveDialog.FileName, rtbReport.Text);
                    MessageBox.Show("Reporte exportado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Menú

        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Archivos de datos (*.dat)|*.dat|Todos los archivos (*.*)|*.*";
                saveDialog.Title = "Guardar Datos";
                saveDialog.FileName = "SistemaNotas_" + DateTime.Now.ToString("yyyyMMdd");

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    database.SaveToFile(saveDialog.FileName);
                    MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openDialog = new OpenFileDialog();
                openDialog.Filter = "Archivos de datos (*.dat)|*.dat|Todos los archivos (*.*)|*.*";
                openDialog.Title = "Cargar Datos";

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    database.LoadFromFile(openDialog.FileName);

                    // Actualizar DataGridViews
                    RefreshStudentsGrid();
                    RefreshCoursesGrid();
                    RefreshGradesGrid();

                    MessageBox.Show("Datos cargados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}