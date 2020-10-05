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
using Academia.DAL;
using Academia.Models;

namespace Academia.Views
{
    /// <summary>
    /// Lógica interna para frmProfile.xaml
    /// </summary>
    public partial class frmProfile : Window
    {
        public frmProfile()
        {
            InitializeComponent();
        }

        public void sair()
        {
            Login.cpfLogin = "";
            Login.senhaLogin = "";
            Login.Professor = false;
            frmPrincipal f = (frmPrincipal)Application.Current.MainWindow;
            f.mntLogin.Header = "Login";
            f.mntAvaliacao.Header = "Marcar Avaliação";
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (Login.Professor == false)
            {
                Aluno a = AlunoDAO.BuscarNomeSenha(Login.cpfLogin, Login.senhaLogin);

                txtBairro.Text = a.bairro.ToString();
                txtNome.Text = a.nome.ToString();
                txtEstado.Text = a.estado.ToString();
                txtCidade.Text = a.cidade.ToString();
                txtCpf.Text = a.cpf.ToString();
                txtRg.Text = a.rg.ToString();
                txtSenha.Text = a.senha.ToString();
                txtEmail.Text = a.email.ToString();
            }
            else
            {
                Professor p = ProfessorDAO.BuscarNomeSenha(Login.cpfLogin, Login.senhaLogin);

                txtBairro.Text = p.bairro.ToString();
                txtNome.Text = p.nome.ToString();
                txtEstado.Text = p.estado.ToString();
                txtCidade.Text = p.cidade.ToString();
                txtCpf.Text = p.cpf.ToString();
                txtRg.Text = p.rg.ToString();
                txtSenha.Text = p.senha.ToString();
                txtEmail.Text = p.email.ToString();
            }
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            sair();
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("Deseja mesmo excluir esse cadastro?", "Excluir", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                
            }
            else
            {
                if (Login.Professor == true)
                {
                    ProfessorDAO.DeletarProfessor(Login.cpfLogin, Login.senhaLogin);
                }
                else
                {
                    AlunoDAO.DeletarAluno(Login.cpfLogin, Login.senhaLogin);
                }
                
                MessageBox.Show("Cadastro deletado");
                sair();
            }
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            if (txtNome.Text != "" && txtCpf.Text != "" && txtRg.Text != "" && txtEstado.Text != "" && txtCidade.Text != "" && txtBairro.Text != "" && txtEmail.Text != "" && txtSenha.Text != "")
            {
                if (Login.Professor == true)
                {
                    Professor professor = new Professor
                    {
                        nome = txtNome.Text,
                        senha = txtSenha.Text,
                        estado = txtEstado.Text,
                        bairro = txtBairro.Text,
                        cidade = txtCidade.Text,
                        cpf = txtCpf.Text,
                        rg = txtRg.Text,
                        email = txtEmail.Text,
                    };
                    if (ProfessorDAO.UpdateProfessor(professor, Login.cpfLogin, Login.senhaLogin, Login.idLogin))
                    {
                        Login.cpfLogin = txtCpf.Text;
                        Login.senhaLogin = txtSenha.Text;
                        MessageBox.Show("Editado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Esse Professor já existe!");
                    }
                    Professor a = ProfessorDAO.BuscarNomeSenha(Login.cpfLogin, Login.senhaLogin);
                    txtBairro.Text = a.bairro.ToString();
                    txtNome.Text = a.nome.ToString();
                    txtEstado.Text = a.estado.ToString();
                    txtCidade.Text = a.cidade.ToString();
                    txtCpf.Text = a.cpf.ToString();
                    txtRg.Text = a.rg.ToString();
                    txtSenha.Text = a.senha.ToString();
                    txtEmail.Text = a.email.ToString();
                }
                else
                {
                    Aluno aluno = new Aluno
                    {
                        nome = txtNome.Text,
                        senha = txtSenha.Text,
                        estado = txtEstado.Text,
                        bairro = txtBairro.Text,
                        cidade = txtCidade.Text,
                        cpf = txtCpf.Text,
                        rg = txtRg.Text,
                        email = txtEmail.Text,
                    };
                    if (AlunoDAO.UpdateAluno(aluno, Login.cpfLogin, Login.senhaLogin, Login.idLogin))
                    {
                        Login.cpfLogin = txtCpf.Text;
                        Login.senhaLogin = txtSenha.Text;
                        MessageBox.Show("Editado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Esse aluno já existe!");
                    }
                    Aluno a = AlunoDAO.BuscarNomeSenha(Login.cpfLogin, Login.senhaLogin);
                    txtBairro.Text = a.bairro.ToString();
                    txtNome.Text = a.nome.ToString();
                    txtEstado.Text = a.estado.ToString();
                    txtCidade.Text = a.cidade.ToString();
                    txtCpf.Text = a.cpf.ToString();
                    txtRg.Text = a.rg.ToString();
                    txtSenha.Text = a.senha.ToString();
                    txtEmail.Text = a.email.ToString();
                }
            }
            else
            {
                MessageBox.Show("Prencha todos os campos", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                if(Login.Professor == true)
                {
                    Professor a = ProfessorDAO.BuscarNomeSenha(Login.cpfLogin, Login.senhaLogin);
                    txtBairro.Text = a.bairro.ToString();
                    txtNome.Text = a.nome.ToString();
                    txtEstado.Text = a.estado.ToString();
                    txtCidade.Text = a.cidade.ToString();
                    txtCpf.Text = a.cpf.ToString();
                    txtRg.Text = a.rg.ToString();
                    txtSenha.Text = a.senha.ToString();
                    txtEmail.Text = a.email.ToString();
                }
                else
                {
                    Aluno a = AlunoDAO.BuscarNomeSenha(Login.cpfLogin, Login.senhaLogin);
                    txtBairro.Text = a.bairro.ToString();
                    txtNome.Text = a.nome.ToString();
                    txtEstado.Text = a.estado.ToString();
                    txtCidade.Text = a.cidade.ToString();
                    txtCpf.Text = a.cpf.ToString();
                    txtRg.Text = a.rg.ToString();
                    txtSenha.Text = a.senha.ToString();
                    txtEmail.Text = a.email.ToString();
                }
            }
        }
    }
}
