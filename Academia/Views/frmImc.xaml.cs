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
    /// Lógica interna para frmImc.xaml
    /// </summary>
    public partial class frmImc : Window
    {
        private List<dynamic> imcGrid = new List<dynamic>();

        public frmImc()
        {
            InitializeComponent();
        }

        private void btnCalcularImc_Click(object sender, RoutedEventArgs e)
        {
            txtImc.Text = "IMC= ";
            if (txtAltura.Text != "" && txtPeso.Text != "")
            {
                double altura = Convert.ToDouble(txtAltura.Text);
                double peso = Convert.ToDouble(txtPeso.Text);
                string resultado = "";

                altura = altura * altura;
                peso = peso / altura;
                txtImc.Text += peso.ToString("F2");

                if (peso >= 40)
                    resultado = "Obesidade de nível 3";
                else if (peso >= 35 && peso <= 39)
                    resultado = "Obesidade de nível 2";
                else if (peso >= 30 && peso <= 34)
                    resultado = "Obesidade de nível 1";
                else if (peso >= 25 && peso <= 29)
                    resultado = "Sobrepeso";
                else if (peso >= 18 && peso <= 24)
                    resultado = "Peso normal";
                else if (peso <= 17)
                    resultado = "Magreza";

                Aluno a = AlunoDAO.BuscarNomeSenha(Login.cpfLogin, Login.senhaLogin);
                
                Imc i = new Imc();
                i.altura = Convert.ToDouble(txtAltura.Text);
                i.peso = Convert.ToDouble(txtPeso.Text);
                if (a != null)
                {
                    i.aluno = a;
                }
                else
                {
                    MessageBox.Show("Deu ruim");
                }
                i.imcResult = peso.ToString("F2");
                i.resultado = resultado;
                ImcDAO.CadastrarImc(i);

                int idImc = Convert.ToInt32(i.idImc);
                i = ImcDAO.BuscarId(idImc);
                dynamic d = new
                {
                    peso = i.peso,
                    altura = i.altura,
                    criadoEm = i.criadoEm,
                    imcResult = i.imcResult,
                    resultado = i.resultado
                };
                imcGrid.Add(d);
                cboImc.ItemsSource = imcGrid;
                cboImc.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Prencha os campos", "Erro");
            }
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (Login.Professor == true)
            {
                Binding textColumnBinding = new Binding();
                textColumnBinding.Path = new PropertyPath("aluno.nome");
                DataGridTextColumn textColumn = new DataGridTextColumn();
                textColumn.Header = "Nome";
                textColumn.Binding = textColumnBinding;
                cboImc.Columns.Add(textColumn);
                Binding textColumnBinding1 = new Binding();
                textColumnBinding1.Path = new PropertyPath("aluno.cpf");
                DataGridTextColumn textColumn1 = new DataGridTextColumn();
                textColumn1.Header = "Cpf";
                textColumn1.Binding = textColumnBinding1;
                cboImc.Columns.Add(textColumn1);
                Thickness margin = cboImc.Margin;
                margin.Top = 30;
                cboImc.Margin = margin;
                cboImc.Height = 300;
                for (int i = 0; i <= 6; i++)
                {
                    cboImc.Columns[i].Width = 750/ 7;
                }
                txtAltura.Visibility = System.Windows.Visibility.Hidden;
                txtPeso.Visibility = System.Windows.Visibility.Hidden;
                btnCalcularImc.Visibility = System.Windows.Visibility.Hidden;
                txtImc.Visibility = System.Windows.Visibility.Hidden;
                txtCm.Visibility = System.Windows.Visibility.Hidden;
                txtKg.Visibility = System.Windows.Visibility.Hidden;
                lblAltura.Visibility = System.Windows.Visibility.Hidden;
                lblPeso.Visibility = System.Windows.Visibility.Hidden;

                foreach (Imc i in ImcDAO.ListarImces())
                {
                    imcGrid.Add(i);
                }
                cboImc.ItemsSource = imcGrid;
                cboImc.Items.Refresh();
            }
            else
            {
                Aluno a = AlunoDAO.BuscarNomeSenha(Login.cpfLogin, Login.senhaLogin);
                foreach (Imc i in ImcDAO.ListarImces())
                {
                    if (i.aluno == a)
                    {
                        imcGrid.Add(i);
                    }
                }
                cboImc.ItemsSource = imcGrid;
                cboImc.Items.Refresh();
            }
        }
    }
}
