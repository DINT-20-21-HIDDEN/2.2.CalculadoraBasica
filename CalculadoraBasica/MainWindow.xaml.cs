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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculadoraBasica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double operando1 = Double.Parse(Operando1TextBox.Text);
                double operando2 = Double.Parse(Operando2TextBox.Text);

                switch (OperadorTextBox.Text)
                {
                    case "+":
                        ResultadoTextBox.Text = (operando1 + operando2).ToString();
                        break;
                    case "-":
                        ResultadoTextBox.Text = (operando1 - operando2).ToString();
                        break;
                    case "*":
                        ResultadoTextBox.Text = (operando1 * operando2).ToString();
                        break;
                    case "/":
                        ResultadoTextBox.Text = (operando1 / operando2).ToString();
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Se ha producido un error. Revise los operandos.");
            }
        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            Operando1TextBox.Text = "";
            Operando2TextBox.Text = "";
            OperadorTextBox.Text = "";
            ResultadoTextBox.Text = "";
        }

        private void OperadorTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<string> operadores = new List<string> { "+", "-", "*", "/" };

            CalcularButton.IsEnabled = operadores.Contains(OperadorTextBox.Text);

        }
    }
}
