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
    public partial class FormTeacherMessage : Form
    {
        Teacher teacher;
        Admin admin;
        public FormTeacherMessage(Teacher teacher,Admin admin)
        {
            InitializeComponent();
            this.teacher = teacher;
            this.admin = admin;
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMessage.Text = "";
            txtTitle.Text = "";

            int firstLetter = -1;
            

            //faz uma que se chame todos e mande msg para todos os alunos
            if(cbClass.SelectedItem != null)
            {
                string selectedClass = cbClass.SelectedItem.ToString();
                cbStudent.Enabled = true;

                for (int i = 0;i < cbClass.SelectedItem.ToString().Length;i++)
                {
                    if (char.IsLetter(cbClass.SelectedItem.ToString()[i]) && cbClass.SelectedItem.ToString()[i] != 'º')
                    {
                        firstLetter = i;
                        break;
                    }
                }

                if(firstLetter != -1)
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

                            List<Student> students = @class.Student;
                            cbStudent.Items.Add("Todos os alunos");
                            students.ForEach(student => cbStudent.Items.Add($"{student.Name} {student.SchoolNumber}"));
                            
                        }
                    }
                }else
                {
                    MessageBox.Show("Erro inesperado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int firstNumber = -1;
            int firstLetter = -1;

            for (int i = 0; i < cbClass.SelectedItem.ToString().Length; i++)
            {
                if (char.IsLetter(cbClass.SelectedItem.ToString()[i]) && cbClass.SelectedItem.ToString()[i] != 'º')
                {
                    firstLetter = i;
                    break;
                }
            }
            string selectedClass = cbClass.SelectedItem.ToString();

            string yearName = selectedClass.Substring(0, firstLetter).Trim();
            string className = selectedClass.Substring(firstLetter).Trim();
            string studentName = cbStudent.Text;

            ClassYear classYear = admin.ClassYears.FirstOrDefault(cy => cy.YearName == yearName);
            Class @class = classYear.Classes.FirstOrDefault(cls => cls.Name == className);

            if (studentName == "Todos os alunos")
            {
                bool firstMessage = true;
                foreach (Student student in @class.Student)
                {
                    new TextMessage(teacher, student, txtTitle.Text, txtMessage.Text, DateTime.Now, firstMessage,true);
                    firstMessage = false;
                }
                MessageBox.Show($"Mensagem enviada para todos os alunos da turma {@class.SchoolYear.YearName} {@class.Name}!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (int i = 0; i < cbStudent.SelectedItem.ToString().Length; i++)
                {
                    if (char.IsDigit(cbStudent.SelectedItem.ToString()[i]))
                    {
                        firstNumber = i;
                        break;
                    }
                }

                string schoolNumber = cbStudent.SelectedItem.ToString().Substring(firstNumber);

                Student studentSelected = @class.Student.Find(std => std.SchoolNumber == schoolNumber);

                new TextMessage(teacher, studentSelected, txtTitle.Text, txtMessage.Text, DateTime.Now,true,false);

                MessageBox.Show($"Mensagem enviada para {studentSelected.Name} com sucesso!","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }


            cbClass.SelectedItem = null;

            cbStudent.SelectedItem = null;
            cbStudent.Enabled = false;

            txtMessage.Text = "";
            txtMessage.Enabled = false;

            txtTitle.Text = "";
            txtTitle.Enabled = false;

            lvwMessages.Items.Clear();
            List<ListViewItem> listViewItems = teacher.Messages.Select(msg => msg.ToListViewItem(msg, teacher.UserType)).ToList();
            listViewItems.ForEach(msg => lvwMessages.Items.Add(msg));
        }
        

        private void FormTeacherMessage_Load(object sender, EventArgs e)
        {
            List<TeacherClassSubject> teacherClassSubjects = admin.TeacherClassSubjects.FindAll(tcs => tcs.Teacher == teacher).ToList();

            List<Class> classes = teacherClassSubjects.Select(tcs => tcs.Class).Distinct().ToList();

            classes.ForEach(cls => cbClass.Items.Add($"{cls.SchoolYear.YearName} {cls.Name}"));


            List<ListViewItem> listViewItems = teacher.Messages.Select(msg => msg.ToListViewItem(msg, teacher.UserType)).ToList();
            listViewItems.ForEach(msg => lvwMessages.Items.Add(msg));
            
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            if (cbStudent.SelectedItem != null && txtTitle.Text != "" && txtMessage.Text != "")
            {
                btnSend.Enabled = true;
            }
            else
            {
                btnSend.Enabled = false;
            }
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            if (cbStudent.SelectedItem != null && txtTitle.Text != "" && txtMessage.Text != "")
            {
                btnSend.Enabled = true;
            }
            else
            {
                btnSend.Enabled = false;
            }
        }

        private void cbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMessage.Text = "";
            txtTitle.Text = "";

            if (cbStudent.SelectedItem != null)
            {
                txtTitle.Enabled = true;
                txtMessage.Enabled = true;
            }
            
            if(cbStudent.SelectedItem != null && txtTitle.Text != "" && txtMessage.Text != "")
            {
                btnSend.Enabled = true;
            }else
            {
                btnSend.Enabled = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
