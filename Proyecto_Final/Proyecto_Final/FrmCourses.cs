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
    public partial class FrmCourses : Form
    {
        public FrmCourses()
        {
            InitializeComponent();
        }

        private void FrmCourses_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveCourse_Click(object sender, EventArgs e)
        {
            string name = txtCourseName.Text;
            string teacher = txtTeacher.Text;

            Course course = new Course(name, teacher);
            Database.Courses.Add(course);

            MessageBox.Show("Course registered successfully!");

            txtCourseName.Clear();
            txtTeacher.Clear();
        }

        private void txtTeacher_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
