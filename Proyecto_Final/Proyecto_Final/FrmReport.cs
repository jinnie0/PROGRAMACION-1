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
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {

        }
        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            lstReport.Items.Clear();

            lstReport.Items.Add("== Students ==");
            foreach (var student in Database.Students)
                lstReport.Items.Add($"{student.Name} ({student.ID})");

            lstReport.Items.Add("\n== Courses ==");
            foreach (var course in Database.Courses)
                lstReport.Items.Add(course);

            lstReport.Items.Add("\n== Grades ==");
            foreach (var grade in Database.Grades)
                lstReport.Items.Add(grade);
        }

    }
}
