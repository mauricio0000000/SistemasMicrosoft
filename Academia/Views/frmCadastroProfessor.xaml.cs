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
    /// Lógica interna para frmCadastroProfessor.xaml
    /// </summary>
    public partial class frmCadastroProfessor : Window
    {
        public frmCadastroProfessor()
        {
            InitializeComponent();
        }

        public void LimparFormulario()
        {
            txtNome.Clear();
            txtSenha.Clear();
            txtEmail.Clear();
            txtCpf.Clear();
            txtRg.Clear();
            txtEstado.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
        }

        private void btnCadastrarProduto_Click(object sender, RoutedEventArgs e)
        {
            if (txtNome.Text != "" && txtCpf.Text != "" && txtRg.Text != "" && txtEstado.Text != "" && txtCidade.Text != "" && txtBairro.Text != "" && txtEmail.Text != "" && txtSenha.Text != "")
            {
                Professor p = new Professor
                {
                    nome = txtNome.Text,
                    senha = txtSenha.Text,
                    email = txtEmail.Text,
                    cpf = txtCpf.Text,
                    rg = txtRg.Text,
                    estado = txtEstado.Text,
                    cidade = txtCidade.Text,
                    bairro = txtBairro.Text,
                };
                if (ProfessorDAO.CadastrarProfessor(p))
                {
                    MessageBox.Show("Professor Cadastrado!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
                    LimparFormulario();
                }
                else
                {
                    MessageBox.Show("Esse Professor já existe!", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Prencha todos os campos", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
