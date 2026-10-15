using EscolaVirtual.Classes;
using EscolaVirtual.Forms;
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
    public partial class FormStudent : Form
    {
        Student student;
        Admin admin;
        public FormStudent(Admin admin, Student student)
        {
            InitializeComponent();
            this.student = student;
            this.admin = admin;
        }

        private void FormStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form_Login loginForm = new Form_Login(admin);
            this.Hide();
            loginForm.Show();
        }

        private void btnAbsence_Click(object sender, EventArgs e)
        {
            if(student.Absence.Count == 0)
            {
                MessageBox.Show("Não existem faltas registadas para este aluno.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                FormAbsencesStudent AbsencesStudentForm = new FormAbsencesStudent(student, admin);
                this.Hide();
                AbsencesStudentForm.Show();
            }
                
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Bem-vindo, {student.Name}";

            // Lista de todas as notas do aluno que está logado
            List<Grade> grades = student.Grades.FindAll(g => g.Student == student).ToList();

            // Se existirem notas
            if (grades.Count > 0)
            {
                // Média geral
                double average = grades.Average(g => g.Value);
                lblAverage.Text = $"Média geral: {average:F2} valores";
            }
            else
            {
                // Não existem notas
                lblAverage.Text = "Média geral: Sem notas";
            }

            // Percorrer as notas do aluno
            foreach (Grade grade in grades)
            {
                // Disciplina da nota atual
                Subject subject = grade.Module.Subject;

                // Procurar o nó da disciplina na TreeView
                TreeNode tnSubject = tvwGradesAndAverage.Nodes.Cast<TreeNode>().FirstOrDefault(tn => tn.Tag == subject);

                // Se o nó da disciplina não existir
                if (tnSubject == null)
                {
                    // Todas as notas do aluno nesta disciplina
                    List<Grade> gradesPerSubject = grades.FindAll(g => g.Module.Subject == subject);

                    string textSubject;

                    if (gradesPerSubject.Count == 0)
                    {
                        textSubject = $"{subject.SubjectName}: Não existem notas";
                    }
                    else
                    {
                        double averageSubject = gradesPerSubject.Average(g => g.Value);
                        textSubject = $"{subject.SubjectName}: {averageSubject:F2} valores";
                    }

                    // Criar o nó da disciplina
                    tnSubject = new TreeNode(textSubject);
                    tnSubject.Tag = subject;

                    // Selecionar todos os módulos da disciplina
                    List<Module> modules = subject.Module;

                    foreach (Module module in modules)
                    {
                        // Procurar as notas do aluno no módulo atual
                        List<Grade> gradesPerModule = grades.FindAll(g => g.Module == module);

                        string textModule;

                        if (gradesPerModule.Count == 0)
                        {
                            textModule = $"{module.ModuleName}: Sem notas";
                        }
                        else
                        {
                            // Cada módulo tem apenas uma nota
                            textModule = $"{module.ModuleName}: {gradesPerModule[0].Value:F2} valores";
                        }

                        // Criar o nó do módulo
                        TreeNode tnModule = new TreeNode(textModule);
                        tnModule.Tag = module;

                        // Adicionar o módulo à disciplina
                        tnSubject.Nodes.Add(tnModule);
                    }

                    // Adicionar a disciplina à TreeView
                    tvwGradesAndAverage.Nodes.Add(tnSubject);
                }
            }
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            FormChangeDataStudent ChangeDataStudentForm = new FormChangeDataStudent(student);
            ChangeDataStudentForm.ShowDialog();
        }

        private void btnSchoolCard_Click(object sender, EventArgs e)
        {
            FormSchoolCard SchoolCardForm = new FormSchoolCard(student);
            SchoolCardForm.ShowDialog();
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            if(student.Messages.Count == 0)
            {
                MessageBox.Show("Não existem mensagens para ler.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                FormStudentMessage StudentMessagesForm = new FormStudentMessage(student);
                StudentMessagesForm.ShowDialog();
            }
                
        }
    }
}
