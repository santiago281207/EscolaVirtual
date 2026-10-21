using EscolaVirtual.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaVirtual
{
    public partial class FormAbsencesTeacher : Form
    {
        Admin admin;
        Teacher teacher;
        public FormAbsencesTeacher(Teacher teacher,Admin admin)
        {
            InitializeComponent();
            this.teacher = teacher;
            this.admin = admin;
        }

        

        private void FormAbsencesTeacher_Load(object sender, EventArgs e)
        {
            List<TeacherClassSubject> teacherClassSubjects = admin.TeacherClassSubjects.FindAll(tcs => tcs.Teacher == teacher).ToList();

            List<Class> classes = teacherClassSubjects.Select(tcs => tcs.Class).Distinct().ToList();

            classes.ForEach(cls => cbClass.Items.Add($"{cls.SchoolYear.YearName} {cls.Name}"));

            dtpAbsenceDate.MinDate = DateTime.Now.AddMonths(-6);
            dtpAbsenceDate.MaxDate = DateTime.Now;
                
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbClass.SelectedItem != null)
            {
                int firstLetter = -1;
                string selectedClass = cbClass.SelectedItem.ToString();

                for (int i = 0; i < cbClass.SelectedItem.ToString().Length; i++)
                {
                    if (char.IsLetter(cbClass.SelectedItem.ToString()[i]) && cbClass.SelectedItem.ToString()[i] != 'º')
                    {
                        firstLetter = i;
                        break;
                    }
                }

                if (firstLetter != -1)
                {
                    string yearName = selectedClass.Substring(0, firstLetter).Trim();
                    string className = selectedClass.Substring(firstLetter).Trim();

                    ClassYear classYear = admin.ClassYears.FirstOrDefault(cy => cy.YearName == yearName);

                    if (classYear != null)
                    {
                        Class @class = classYear.Classes.FirstOrDefault(cls => cls.Name == className);

                        if (@class != null)
                        {
                            cbStudent.Items.Clear();
                            cbStudent.SelectedItem = null;
                            List<Student> students = @class.Student;
                            students.ForEach(student => cbStudent.Items.Add($"{student.Name} {student.SchoolNumber}"));

                            cbSubject.Items.Clear();
                            cbSubject.SelectedItem = null;
                            List<Subject> subjects = classYear.Subject;
                            subjects.ForEach(sub => cbSubject.Items.Add(sub.SubjectName));

                        }


                    }
                }


                cbStudent.Enabled = true;
                cbSubject.Enabled = true;
            }
        }

        private void txtJustification_TextChanged(object sender, EventArgs e)
        {
            if (cbStudent.SelectedItem != null && txtJustification.Text.Trim() != "" && cbSubject.SelectedItem != null)
            {
                btnCreate.Enabled = true;
            }
            else
            {
                btnCreate.Enabled = false;
            }
        }

        

        private void rbJustified_CheckedChanged(object sender, EventArgs e)
        {
            if (rbJustified.Checked)
            {
                txtJustification.Enabled = true;
            }
            else
            {
                txtJustification.Enabled = false;
                txtJustification.Text = "";
            }

            if (rbJustified.Checked == true && txtJustification.Text.Trim() != "")
            {
                btnCreate.Enabled = true;
            }
            else if (rbNotJustified.Checked == true && cbStudent.SelectedItem != null && cbSubject.SelectedItem != null)
            {
                btnCreate.Enabled = true;
            }
            else
            {
                btnCreate.Enabled = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rbJustified.Checked == true && txtJustification.Text.Trim() != "" && cbSubject.SelectedItem != null)
            {
                btnCreate.Enabled = true;
            }else if(rbNotJustified.Checked == true && cbSubject.SelectedItem != null)
            {
                btnCreate.Enabled = true;
            }else
            {
                btnCreate.Enabled = false;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string schoolNumber = "";
            string selectedClass = cbClass.SelectedItem.ToString();

            for (int i = 0;i < cbStudent.SelectedItem.ToString().Length;i++)
            {
                if (Char.IsDigit(cbStudent.SelectedItem.ToString()[i]) == true)
                {
                    schoolNumber = cbStudent.SelectedItem.ToString().Substring(i);
                    break;
                }
            }

            string yearName = "";
            string className = "";

            for(int i = 0;i < cbClass.SelectedItem.ToString().Length;i++)
            {
                if (Char.IsLetter(cbClass.SelectedItem.ToString()[i]) == true && cbClass.SelectedItem.ToString()[i] != 'º')
                {
                    yearName = cbClass.SelectedItem.ToString().Substring(0, i).Trim();
                    className = cbClass.SelectedItem.ToString().Substring(i);
                    break;
                }
            }

            string selectedSubject = cbSubject.SelectedItem.ToString();

            ClassYear classYear = admin.ClassYears.FirstOrDefault(y => y.YearName == yearName);
            Class @class = classYear.Classes.FirstOrDefault(cls => cls.Name == className);
            Subject subject = classYear.Subject.FirstOrDefault(sub => sub.SubjectName == selectedSubject);
            Student student = @class.Student.FirstOrDefault(std => std.SchoolNumber == schoolNumber);

            string justification = rbJustified.Checked == true ? txtJustification.Text : "Sem justificação";

            student.Absence.Add(new Absence(
                                rbJustified.Checked == true ? AbsenceStatus.Justified : AbsenceStatus.Unjustified
                                , student
                                , dtpAbsenceDate.Value
                                , subject
                                , justification));

            cbSubject.SelectedItem = null;
            cbSubject.Enabled = false;

            cbStudent.SelectedItem = null;
            cbStudent.Enabled = false;

            cbClass.SelectedItem = null;
            rbNotJustified.Checked = true;
            txtJustification.Text = "";
            dtpAbsenceDate.Value = DateTime.Now.AddDays(-1);

            MessageBox.Show($"Falta marcada a {student.Name} na disciplina de {selectedSubject}","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbJustified.Checked == true && txtJustification.Text.Trim() != "" && cbStudent.SelectedItem != null)
            {
                btnCreate.Enabled = true;
            }
            else if (rbNotJustified.Checked == true && cbStudent.SelectedItem != null)
            {
                btnCreate.Enabled = true;
            }
            else
            {
                btnCreate.Enabled = false;
            }
        }
    }
}
