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
    /// Lógica interna para AgendaAvaliacao.xaml
    /// </summary>
    public partial class AgendaAvaliacao : Window
    {

        public AgendaAvaliacao()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            txtNome.Text = "";
            txtCpf.Text = "";
            txtData.Text = "";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int i = Convert.ToInt32(cboAlunos.SelectedValue);
            AvaliacaoDAO.AceitarAvaliacao(i);
            cboStatus.SelectedValue = null;
            cboAlunos.SelectedValue = null;
            Limpar();
            MessageBox.Show("Avaliação aceita!", "Avaliação", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int i = Convert.ToInt32(cboAlunos.SelectedValue);
            AvaliacaoDAO.RecusarAvaliacao(i);
            cboStatus.SelectedValue = null;
            cboAlunos.SelectedValue = null;
            Limpar();
            MessageBox.Show("Avaliação recusada!", "Avaliação", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void cboAlunos_DropDownClosed(object sender, EventArgs e)
        {
            if (cboAlunos.SelectedValue != null)
            {
                int i = Convert.ToInt32(cboAlunos.SelectedValue);
                Avaliacao v = AvaliacaoDAO.BuscarAvaliacaoPorId(i);
                txtNome.Text = v.aluno.nome.ToString();
                txtCpf.Text = v.aluno.cpf.ToString();
                txtData.Text = v.dataMarcada.ToString();
            }
        }

        private void cboStatus_DropDownClosed_1(object sender, EventArgs e)
        {
            List<Avaliacao> avaBox = new List<Avaliacao>();
            Professor p = ProfessorDAO.BuscarNomeSenha(Login.cpfLogin, Login.senhaLogin);

            if (cboStatus.SelectedIndex == 0)
            {
                foreach (Avaliacao ava in AvaliacaoDAO.ListarAvaliacaos())
                {
                    if (ava.professor == p)
                    {
                        if (ava.statusAvaliacao == "Pendente")
                            avaBox.Add(ava);
                    }
                }

                btnAceitar.IsEnabled = true;
                btnRecusar.IsEnabled = true;
            }

            if (cboStatus.SelectedIndex == 1)
            {
                foreach (Avaliacao ava in AvaliacaoDAO.ListarAvaliacaos())
                {
                    if (ava.professor == p)
                    {
                        if (ava.statusAvaliacao == "Aceita")
                            avaBox.Add(ava);
                    }
                }

                btnAceitar.IsEnabled = false;
                btnRecusar.IsEnabled = false;
            }

            if (cboStatus.SelectedIndex == 2)
            {
                foreach (Avaliacao ava in AvaliacaoDAO.ListarAvaliacaos())
                {
                    if (ava.professor == p)
                    {
                        if (ava.statusAvaliacao == "Recusada")
                            avaBox.Add(ava);
                    }
                }

                btnAceitar.IsEnabled = false;
                btnRecusar.IsEnabled = false;
            }

            cboAlunos.ItemsSource = avaBox;
            cboAlunos.SelectedValuePath = "idAvaliacao";
            cboAlunos.Items.Refresh();
            Limpar();
        }
    }
}
