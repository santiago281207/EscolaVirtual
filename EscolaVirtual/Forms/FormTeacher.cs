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
using static System.Net.Mime.MediaTypeNames;

namespace EscolaVirtual
{
    public partial class FormTeacher : Form
    {
        Admin admin;
        Teacher teacher;
        public FormTeacher(Admin admin, Teacher teacher)
        {
            InitializeComponent();
            this.admin = admin;
            this.teacher = teacher;
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            // criar um form novo para poder editar e por notas 
        }

        private void btnAbsences_Click(object sender, EventArgs e)
        {
            // criar um form novo para poder marcar faltas
        }

        private void btnChangeData_Click(object sender, EventArgs e)
        {
            // criar form para poder mudar os dados do professor
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            // criar form para poder mandar mensagens para os alunos
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form_Login loginForm = new Form_Login(admin);
            this.Hide();
            loginForm.Show();
        }


        private void FormTeacher_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Bem vindo, {teacher.Name}";

            List<TeacherClassSubject> teacherClassSubjects = admin.TeacherClassSubjects.FindAll(t => t.Teacher == teacher);

            foreach (TeacherClassSubject tcs in teacherClassSubjects)
            {
                //Turma e disciplina do registo atual
                Class @class = tcs.Class;
                Subject subject = tcs.Subject;

                // Procurar a turma na treeview
                TreeNode classFind = tvwSubjectClass.Nodes.Cast<TreeNode>().FirstOrDefault(tn => tn.Tag == @class);

                //Notas dos estudantes da turma do registo atual
                List<Grade> gradesClass = @class.Student.SelectMany(student => student.Grades).Where(grade => grade.Module.Subject == subject).ToList();

                // Criar a turma se ainda não existir
                if (classFind == null)
                {
                    try
                    {
                        classFind = new TreeNode($"{@class.Name} {@class.SchoolYear.YearName} Média da turma: {gradesClass.Average(g => g.Value)} valores");
                    }
                    catch(ArgumentNullException)    //Nao existem notas na turma
                    {
                        classFind = new TreeNode($"{@class.Name} {@class.SchoolYear.YearName}: Ainda não existem notas na turma");
                    }
                    catch(InvalidOperationException)    //Nao existem valores
                    {
                        classFind = new TreeNode($"{@class.Name} {@class.SchoolYear.YearName}: Ainda não existem notas na turma");
                    }


                    classFind.Tag = @class;
                    tvwSubjectClass.Nodes.Add(classFind);
                }

                // Percorrer os alunos da turma
                foreach (Student student in @class.Student)
                {
                    // Procurar o aluno na treeview
                    TreeNode tnStudent = classFind.Nodes.Cast<TreeNode>().FirstOrDefault(tn => tn.Tag == student);

                    // Criar o aluno se ainda não existir
                    if (tnStudent == null)
                    {
                        tnStudent = new TreeNode(student.Name);
                        tnStudent.Tag = student;

                        classFind.Nodes.Add(tnStudent);
                    }

                    // Procurar a disciplina nos nodes do estudante
                    TreeNode tnSubject = tnStudent.Nodes.Cast<TreeNode>().FirstOrDefault(tn => tn.Tag == subject);

                    if (tnSubject == null)
                    {
                        // Obter as notas dos módulos da disciplina do registo tcs atual
                        List<Grade> grades = student.Grades.Where(g => g.Module.Subject == subject).ToList();
                        
                        if (grades.Count > 0)
                        {
                            double avg = grades.Average(g => g.Value);

                            tnSubject = new TreeNode($"{subject.SubjectName} Média da disciplina: {avg:F2} valores");
                        }
                        else
                        {
                            tnSubject = new TreeNode(
                                $"{subject.SubjectName}: Sem notas");
                        }

                        tnSubject.Tag = subject;
                        tnStudent.Nodes.Add(tnSubject);
                    }


                    foreach(Module module in subject.Module)
                    {
                        Grade grade = student.Grades.FirstOrDefault(g => g.Module == module);

                        TreeNode tModule;

                        if (grade != null)
                        {
                            tModule = new TreeNode($"{module.ModuleName}: {grade.Value:F2} valores");
                        }
                        else
                        {
                            tModule = new TreeNode($"{module.ModuleName}: Sem nota");
                        }

                        
                        tModule.Tag = module;
                        tnSubject.Nodes.Add(tModule);
                    }
                }
            }
        }
    }
}


