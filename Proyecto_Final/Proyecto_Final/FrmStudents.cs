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
    public partial class FrmStudents : Form
    {
        public FrmStudents()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMatrícula_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int age = int.Parse(txtAge.Text);
            string id = txtID.Text;

            Student newStudent = new Student(name, age, id);
            Database.Students.Add(newStudent);

            MessageBox.Show("Student registered successfully!");

            this.Close(); // 👈 Esto cierra el formulario automáticamente
        }
        private void FrmStudents_Load(object sender, EventArgs e)
        {
            // Puedes dejar esto vacío, o cargar datos si quieres
        }


    }
}
