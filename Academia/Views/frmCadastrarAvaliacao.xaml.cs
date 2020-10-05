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
    /// Lógica interna para frmCadastrarAvaliacao.xaml
    /// </summary>
    public partial class frmCadastrarAvaliacao : Window
    {
        public frmCadastrarAvaliacao()
        {
            InitializeComponent();
        }

        private void btnMarcar_Click(object sender, RoutedEventArgs e)
        {
            if (txtData.SelectedDate != null && cboHoras.SelectedItem != null && cboProfessor.SelectedItem != null)
            {
                if (txtData.SelectedDate > DateTime.Now)
                {
                    DateTime? data = txtData.SelectedDate;

                    if (cboHoras.SelectedIndex == 0)
                    {
                        data = data.Value.AddHours(9);
                    }
                    else if (cboHoras.SelectedIndex == 1)
                    {
                        data = data.Value.AddHours(12);
                    }
                    else if (cboHoras.SelectedIndex == 2)
                    {
                        data = data.Value.AddHours(15);
                    }
                    else
                    {
                        data = data.Value.AddHours(18);
                    }
                    MessageBox.Show(data.ToString());
                    Avaliacao a = new Avaliacao();
                    a.aluno = AlunoDAO.BuscarNomeSenha(Login.cpfLogin, Login.senhaLogin);
                    Professor p = ProfessorDAO.BuscarId(Convert.ToInt32(cboProfessor.SelectedValue));
                    a.professor = ProfessorDAO.BuscarNomeSenha(p.cpf, p.senha);
                    a.dataMarcada = data;
                    if(AvaliacaoDAO.CadastrarAvaliacao(a.professor, a))
                    {
                        MessageBox.Show("Avaliação cadastrada com sucesso!", "Avaliação", MessageBoxButton.OK, MessageBoxImage.Information);
                        this.Close();
                        frmPrincipal f = new frmPrincipal();
                        f.mntAvaliacao.Header = "Acompanhar Avaliação";
                    }
                    else
                    {
                        MessageBox.Show("Este horário já está reservado!", "Avaliação", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Data invalida", "Erro", MessageBoxButton.OK);
                    txtData.SelectedDate = null;
                }
            }
            else
            {
                MessageBox.Show("Prencha todos os campos", "Erro", MessageBoxButton.OK);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cboProfessor.ItemsSource = ProfessorDAO.ListarProfessores();
            cboProfessor.DisplayMemberPath = "nome";
            cboProfessor.SelectedValuePath = "idProfessor";
        }
    }
}
