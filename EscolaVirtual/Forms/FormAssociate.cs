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
    public partial class FormAssociate : Form
    {
        Admin admin;
        public FormAssociate(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void FormAssociate_Load(object sender, EventArgs e)
        {
            List<Teacher> teachers = admin.Teachers;
            List<Class> classes = admin.ClassYears.SelectMany(cy => cy.Classes).ToList();

            cbTeacher.DisplayMember = "Name";
            cbTeacher.DataSource = teachers;

            cbClass.DisplayMember = "Name";
            cbClass.DataSource = classes;

            cbTeacher.SelectedItem = null;
            cbClass.SelectedItem = null;

            cbSubject.Enabled = false;
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbClass.SelectedItem != null)
            {
                Class @class = cbClass.SelectedItem as Class;
                ClassYear classYear = @class.SchoolYear;

                cbSubject.DataSource = null;
                cbSubject.DataSource = classYear.Subject;
                cbSubject.DisplayMember = "SubjectName";

                cbSubject.SelectedItem = null;
                cbSubject.Enabled = true;
            }

            if (cbClass.SelectedItem != null && cbSubject.SelectedItem != null && cbTeacher.SelectedItem != null)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void cbTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbClass.SelectedItem != null && cbSubject.SelectedItem != null && cbTeacher.SelectedItem != null)
            {
                btnAdd.Enabled = true;
            }else
            {
                btnAdd.Enabled = false;
            }
        }

        private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClass.SelectedItem != null && cbSubject.SelectedItem != null && cbTeacher.SelectedItem != null)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<TeacherClassSubject> teacherClassSubjects = admin.TeacherClassSubjects;

            Class @class = cbClass.SelectedItem as Class;
            Teacher teacher = cbTeacher.SelectedItem as Teacher;
            Subject subject = cbSubject.SelectedItem as Subject;

            TeacherClassSubject validCheck = teacherClassSubjects.FirstOrDefault(tcs => tcs.Class == @class && tcs.Subject == subject && tcs.Teacher == teacher);

            if(validCheck != null)
            {
                MessageBox.Show("Já existe esta relação!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            validCheck = teacherClassSubjects.FirstOrDefault(tcs => tcs.Class == @class && tcs.Subject == subject);

            if(validCheck != null)
            {
                MessageBox.Show("Já existe um professor a dar aulas na disciplina desta turma!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                admin.TeacherClassSubjects.Add(new TeacherClassSubject(teacher, subject, @class));
            }

            cbClass.SelectedItem = null;
            cbSubject.SelectedItem = null;
            cbTeacher.SelectedItem = null;

            btnAdd.Enabled = cbClass.SelectedItem != null && cbSubject.SelectedItem != null && cbTeacher.SelectedItem != null;
        }
    }
}
