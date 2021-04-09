using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoSystem
{
    public partial class FrmStudentInfoSystem : Form
    {
        public FrmStudentInfoSystem()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmStudentInfoSystem_Load(object sender, EventArgs e)
        {
            string[] items = { "Biomedical Engineering Technology", "Computer Repair and Maintenance", "Computer Systems Technician – Networking", "Computer Systems Technology – Networking", "Electronics Engineering Technician", "Electronics Engineering Technology", "Health Informatics Technology", "Software Engineering Technician", "Software Engineering Technology", "Software Engineering Technology – Interactive Gaming", "Technology Foundations (ICET)" };

            foreach(string program in items)
            {
                cbProgram.Items.Add(program);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtCity.Text = "";

            rbDomestic.Checked = false;
            rbForeign.Checked = false;
            nudSemester.Value = 0;
            txtGpa.Text = "0";
            cbProgram.Text = "";

            cb01.Checked = false;
            cb02.Checked = false;
            cb03.Checked = false;
            cb04.Checked = false;
            cb05.Checked = false;
            cb06.Checked = false;
            cb07.Checked = false;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            Student student = new Student(txtCity.Text,
                txtFirstName.Text,
                txtLastName.Text,
                cbProgram.Text,
                (cb01.Checked ? (cb01.Text + ",") : "")+
                (cb02.Checked ? (cb02.Text + ",") : "")+
                (cb03.Checked ? (cb03.Text + ",") : "")+
                (cb04.Checked ? (cb04.Text + ",") : "")+
                (cb05.Checked ? (cb05.Text + ",") : "")+
                (cb06.Checked ? (cb06.Text + ",") : "")+
                (cb07.Checked ? (cb07.Text + ",") : ""), 
                double.Parse(txtGpa.Text),
                (int)nudSemester.Value, 
                rbDomestic.Checked);
            MessageBox.Show($"Name: {student.FirstName} {student.LastName}\n" +
                $"Program: {student.Program}\n" +
                $"Courses: {student.Courses}\n" +
                $"Gpa: {student.Gpa}\n" +
                $"Semester: {student.Semester}\n" +
                $"Residence: {student.IsDomestic}");
        }
    }
}
