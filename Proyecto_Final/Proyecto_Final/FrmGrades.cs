using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class FrmGrades : Form
    {
        public FrmGrades()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmGrades_Load(object sender, EventArgs e)
        {
            // Cargar estudiantes en el ComboBox
            cmbStudent.DataSource = null;
            cmbStudent.DataSource = Database.Students;
            cmbStudent.DisplayMember = "Name"; // lo que se muestra en el combo

            // Cargar cursos en el ComboBox
            cmbCourse.DataSource = null;
            cmbCourse.DataSource = Database.Courses;
            cmbCourse.DisplayMember = "CourseName";
        }

        private void btnSaveGrade_Click(object sender, EventArgs e)
        {
            if (cmbStudent.SelectedItem == null || cmbCourse.SelectedItem == null || string.IsNullOrWhiteSpace(txtGrade.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            try
            {
                Student? student = cmbStudent.SelectedItem as Student;
                Course? course = cmbCourse.SelectedItem as Course;
                float score = float.Parse(txtGrade.Text);

                Grade grade = new Grade(student, course, score);
                Database.Grades.Add(grade);

                MessageBox.Show("Grade saved successfully!");
                txtGrade.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving grade: " + ex.Message);
            }
        }

    }
}
