using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

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
