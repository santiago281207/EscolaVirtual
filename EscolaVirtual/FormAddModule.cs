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
    public partial class FormAddModule : Form
    {
        
        private bool changed;

        public bool Changed
        {
            get { return changed; }
            set { changed = value; }
        }

        Admin admin;

        public FormAddModule(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        //metodo para meter o nome da disciplina e o ano na combobox
        private class SubjectItem
        {
            public Subject Subject { get; set; }
            public string DisplayName { get; set; }

            public SubjectItem(Subject subject, string yearName)
            {
                Subject = subject;
                DisplayName = subject.SubjectName + " - " + yearName;
            }

            public override string ToString()
            {
                return DisplayName;
            }
        }

        private void btnCreateModule_Click(object sender, EventArgs e)
        {
            if (cbModuleSubject.SelectedItem == null)
            {
                MessageBox.Show("Seleciona uma disciplina!", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string moduleName = txtModuleName.Text.Trim();

            if (string.IsNullOrWhiteSpace(moduleName))
            {
                MessageBox.Show("Introduz o nome do módulo!", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SubjectItem selectedItem = cbModuleSubject.SelectedItem as SubjectItem;

            if (selectedItem == null)
            {
                MessageBox.Show("A disciplina selecionada é inválida!", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Subject selectedSubject = selectedItem.Subject;

            if (selectedSubject.Module != null && selectedSubject.Module.Any(m => m.ModuleName.Equals(moduleName, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Este módulo já existe nesta disciplina.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Module newModule = new Module(moduleName, selectedSubject);

            MessageBox.Show("Módulo criado com sucesso!",
                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            changed = true;
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtModuleName_TextChanged(object sender, EventArgs e)
        {
            btnCreateModule.Enabled = cbModuleSubject.SelectedItem != null &&
                                   !string.IsNullOrWhiteSpace(txtModuleName.Text);

        }

        private void cbModuleSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCreateModule.Enabled = cbModuleSubject.SelectedItem != null &&
                                  !string.IsNullOrWhiteSpace(txtModuleName.Text);

            if (cbModuleSubject.SelectedItem != null)
            {
                txtModuleName.Enabled = true;
            }
            else
            {
                txtModuleName.Enabled = false;
            }

        }

        private void FormAddModule_Load(object sender, EventArgs e)
        {
            cbModuleSubject.Items.Clear();

            if (admin == null || admin.ClassYears == null)
            {
                MessageBox.Show("Não foi possível carregar os anos escolares.",
                    "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (ClassYear classYear in admin.ClassYears)
            {
                if (classYear.Subject != null)
                {
                    foreach (Subject subject in classYear.Subject)
                    {
                        cbModuleSubject.Items.Add(
                            new SubjectItem(subject, classYear.YearName));
                    }
                }
            }

            cbModuleSubject.SelectedIndex = -1;
            txtModuleName.Clear();
            txtModuleName.Enabled = false;
            btnCreateModule.Enabled = false;
        }
    }
    
}
