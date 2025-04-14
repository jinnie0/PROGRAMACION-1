namespace Proyecto_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            FrmStudents frm = new FrmStudents();
            frm.Show();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            FrmCourses courseForm = new FrmCourses();
            courseForm.ShowDialog();
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            FrmGrades gradesForm = new FrmGrades();
            gradesForm.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FrmReport report = new FrmReport();
            report.ShowDialog();
        }

        private void btnReport_Click_1(object sender, EventArgs e)
        {

        }
    }
}
