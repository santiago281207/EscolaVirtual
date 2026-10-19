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

        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClass.SelectedIndex >= 0)
            {
                string selectedClass = cbClass.SelectedItem.ToString();
                Class @class = admin.TeacherClassSubjects.Select(tcs => tcs.Class).Distinct().FirstOrDefault(c => $"{c.SchoolYear.YearName} {c.Name}" == selectedClass);
                if (@class != null)
                {
                    List<Subject> subjects = admin.TeacherClassSubjects.Where(tcs => tcs.Class == @class && tcs.Teacher == teacher).Select(tcs => tcs.Subject).ToList();
                    cbSubject.Items.Clear();
                    subjects.ForEach(s => cbSubject.Items.Add(s.SubjectName));
                    cbSubject.Enabled = true;
                    
                    List<Student> students = @class.Student;
                    students.ForEach(std => cbStudent.Items.Add(std.Name));
                    cbStudent.Enabled = true;

                }
            }
        }

        private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
