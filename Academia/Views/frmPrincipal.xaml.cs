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

namespace Academia.Views
{
    /// <summary>
    /// Lógica interna para frmPrincipal.xaml
    /// </summary>
    public partial class frmPrincipal : Window
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            frmCadastroAluno f = new frmCadastroAluno();
            f.ShowDialog();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Login l = new Login();
            if (mntLogin.Header.ToString() == "Login")
            {
                frmLogin f = new frmLogin();
                f.ShowDialog();
            }
            else
            {
                frmProfile f = new frmProfile();
                f.ShowDialog();
            }
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar a janela?",
                "Academia", MessageBoxButton.YesNo,
                MessageBoxImage.Question) == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            frmCadastroProfessor f = new frmCadastroProfessor();
            f.ShowDialog();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            if (Login.cpfLogin != "")
            {
                frmImc f = new frmImc();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Necessario fazer login", "Alerta", MessageBoxButton.OK, MessageBoxImage.Information);
                if (MessageBox.Show("Já tem cadastro?", "Acad", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    frmLogin f = new frmLogin();
                    f.ShowDialog();
                }
                else
                {
                    frmCadastroAluno f = new frmCadastroAluno();
                    f.ShowDialog();
                }
            }
            
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            if (Login.cpfLogin != "")
            {
                if (Login.Professor == true)
                {
                    AgendaAvaliacao f = new AgendaAvaliacao();
                    f.ShowDialog();
                }
                else
                {
                    if (mntAvaliacao.Header.ToString() == "Acompanhar Avaliação")
                    {
                        frmVisualizarAvaliacao f = new frmVisualizarAvaliacao();
                        f.ShowDialog();
                    }
                    else
                    {
                        frmCadastrarAvaliacao f = new frmCadastrarAvaliacao();
                        f.ShowDialog();
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Necessario fazer login", "Alerta", MessageBoxButton.OK, MessageBoxImage.Information);
                if (MessageBox.Show("Já tem cadastro?", "Acad", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    frmLogin f = new frmLogin();
                    f.ShowDialog();
                }
                else
                {
                    frmCadastroAluno f = new frmCadastroAluno();
                    f.ShowDialog();
                }
            }
        }
    }
}
