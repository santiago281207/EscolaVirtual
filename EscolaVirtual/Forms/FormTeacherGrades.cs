using EscolaVirtual.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EscolaVirtual.Forms
{
    public partial class FormTeacherGrades : Form
    {
        Teacher teacher;
        Admin admin;
        public FormTeacherGrades(Admin admin, Teacher teacher)
        {
            InitializeComponent();
            this.admin = admin;
            this.teacher = teacher;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTeacherGrades_Load(object sender, EventArgs e)
        {
            List<Class> classes = admin.TeacherClassSubjects.FindAll(tcs => tcs.Teacher == teacher).Select(tcs => tcs.Class).Distinct().ToList();
            classes.ForEach(c => cbClass.Items.Add($"{c.SchoolYear.YearName} {c.Name}"));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string selectedStudent = cbStudent.SelectedItem.ToString();
            string selectedClass = cbClass.SelectedItem.ToString();
            string selectedSubject = cbSubject.SelectedItem.ToString();
            string selectedModule = cbModule.SelectedItem.ToString();
            string schoolNumber = "";
            

            for(int i = 0;i < selectedStudent.Length;i++)
            {
                if (Char.IsDigit(selectedStudent[i]))
                {
                    schoolNumber = selectedStudent.Substring(i);
                    break;
                }
            }

            

            Class @class = admin.TeacherClassSubjects.Select(tcs => tcs.Class).FirstOrDefault(c => $"{c.SchoolYear.YearName} {c.Name}" == selectedClass);
            Student student = @class.Student.FirstOrDefault(std => std.SchoolNumber == schoolNumber);
            Subject subject = admin.TeacherClassSubjects.FirstOrDefault(tcs => tcs.Class == @class && tcs.Teacher == teacher && tcs.Subject.SubjectName == selectedSubject).Subject;
            Module module = subject.Module.FirstOrDefault(sub => sub.ModuleName == selectedModule);

            try
            {
                Grade grade = new Grade(teacher, module, (double)nudGrade.Value, student, DateTime.Now);
                MessageBox.Show("Nota criada com sucesso!","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cbSubject.SelectedIndex = -1;
            cbModule.SelectedIndex = -1;
            cbStudent.SelectedIndex = -1;
            nudGrade.Value = nudGrade.Minimum;

        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClass.SelectedItem != null)
            {
                cbModule.Items.Clear();
                cbModule.Enabled = false;
                cbStudent.Items.Clear();
                cbSubject.Items.Clear();

                string selectedClass = cbClass.SelectedItem.ToString();
                Class @class = admin.TeacherClassSubjects.Select(tcs => tcs.Class).FirstOrDefault(c => $"{c.SchoolYear.YearName} {c.Name}" == selectedClass);
                
                if (@class != null)
                {
                    List<Subject> subjects = admin.TeacherClassSubjects.Where(tcs => tcs.Class == @class && tcs.Teacher == teacher).Select(tcs => tcs.Subject).ToList();
                    cbSubject.Items.Clear();
                    subjects.ForEach(s => cbSubject.Items.Add(s.SubjectName));
                    cbSubject.Enabled = true;
                    
                    List<Student> students = @class.Student;
                    students.ForEach(std => cbStudent.Items.Add($"{std.Name} {std.SchoolNumber}"));
                    cbStudent.Enabled = true;

                }
            }


        }

        private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSubject.SelectedItem != null && cbClass.SelectedItem != null)
            {
                cbModule.Items.Clear();
                cbModule.SelectedIndex = -1;
                cbModule.Enabled = false;

                string selectedClass = cbClass.SelectedItem.ToString();
                string selectedSubject = cbSubject.SelectedItem.ToString();

                Class @class = admin.TeacherClassSubjects.Select(tcs => tcs.Class).FirstOrDefault(c => $"{c.SchoolYear.YearName} {c.Name}" == selectedClass);
                
                Subject subject = admin.TeacherClassSubjects.FirstOrDefault(tcs => tcs.Class == @class && tcs.Teacher == teacher && tcs.Subject.SubjectName == selectedSubject)
                    .Subject;

                subject.Module.ForEach(module => cbModule.Items.Add(module.ModuleName));

                cbModule.Enabled = true;
            }

            if(cbStudent.SelectedItem != null && cbSubject.SelectedItem != null && cbModule.SelectedItem != null)
            {
                btnAdd.Enabled = true;
            }else
            {
                btnAdd.Enabled = false;
            }
            
        }

        private void cbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStudent.SelectedItem != null && cbSubject.SelectedItem != null && cbModule.SelectedItem != null)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void cbModule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStudent.SelectedItem != null && cbSubject.SelectedItem != null && cbModule.SelectedItem != null)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }
    }
}
