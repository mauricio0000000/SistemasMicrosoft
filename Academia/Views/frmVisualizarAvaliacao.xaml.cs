using Academia.DAL;
using Academia.Models;
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

namespace Academia.Views
{
    /// <summary>
    /// Lógica interna para frmVisualizarAvaliacao.xaml
    /// </summary>
    public partial class frmVisualizarAvaliacao : Window
    {
        public frmVisualizarAvaliacao()
        {
            InitializeComponent();
            //Trazer OBJ ALUNO
            Aluno a = AlunoDAO.BuscarAlunoPorCPF(Login.cpfLogin);

            //Buscar avaliações por aluno
            Avaliacao p = AvaliacaoDAO.BuscarAvaliacaoPorIdAluno(a.idAluno);

            // Avaliacao paux = AvaliacaoDAO.BuscarAvaliacaoPorId(a.idAluno);

            txtCpf.Text = p.professor.cpf;
            txtData.Text = p.dataMarcada.ToString();
            txtNome.Text = p.professor.nome;
            txtData_Copy.Text = p.statusAvaliacao;


        }

        private void btnCancelar_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
