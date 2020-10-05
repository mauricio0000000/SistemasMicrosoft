using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Academia.Models;
using Academia.DAL;

namespace Academia.Views
{
    /// <summary>
    /// Lógica interna para frmLogin.xaml
    /// </summary>
    public partial class frmLogin : Window
    {
        public frmLogin()
        {
            InitializeComponent();
            txtCpf.Focus();
        }

        private void btnLogar_Click(object sender, RoutedEventArgs e)
        {
            if(cbProfessor.IsChecked == true)
            {
                Professor p = ProfessorDAO.BuscarNomeSenha(txtCpf.Text.ToString(), txtSenha.Text.ToString());
                if (p != null)
                {
                    Login.cpfLogin = p.cpf;
                    Login.senhaLogin = p.senha;
                    Login.idLogin = p.idProfessor;
                    Login.Professor = true;
                    frmPrincipal f = (frmPrincipal)Application.Current.MainWindow;
                    f.mntLogin.Header = p.nome.ToString();
                    f.mntAvaliacao.Header = "Consultar Avaliações";
                    MessageBox.Show("Bem vindo " + p.nome);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario invalido!");
                }
            }
            else if (cbProfessor.IsChecked == false)
            {
                Aluno a = AlunoDAO.BuscarNomeSenha(txtCpf.Text.ToString(), txtSenha.Text.ToString());
                if (a != null)
                {
                    Login.cpfLogin = a.cpf;
                    Login.senhaLogin = a.senha;
                    Login.idLogin = a.idAluno;
                    frmPrincipal f = (frmPrincipal)Application.Current.MainWindow;
                    if (AvaliacaoDAO.BuscarAvaliacaoPorIdAluno(a.idAluno) != null)
                    {
                        if (AvaliacaoDAO.BuscarAvaliacaoPorIdAluno(a.idAluno).statusAvaliacao == "Aceita")
                        {
                            f.mntAvaliacao.Header = "Acompanhar Avaliação";
                        }
                    }
                    f.mntLogin.Header = a.nome.ToString();
                    MessageBox.Show("Bem vindo " + a.nome);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario invalido!");
                }
            }
        }
    }
}
