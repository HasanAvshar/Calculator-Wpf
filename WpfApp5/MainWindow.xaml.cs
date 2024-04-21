using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp5
{
    public partial class MainWindow : Window
    {
        double resultValue = 0;
        string operationPerformed;
        bool isOperationPerformed = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "0" || (isOperationPerformed))
            {
                textBox1.Clear();
            }
            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Content.ToString() == "0")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text += button.Content.ToString();
                }
            }
            else
            {
                textBox1.Text += button.Content.ToString();
            }
        }

        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            operationPerformed = button.Content.ToString();
            resultValue = Double.Parse(textBox1.Text);
            isOperationPerformed = true;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "0";
        }

        private void Button12_Click(object sender, RoutedEventArgs e)
        {
            if (operationPerformed == "+")
            {
                textBox1.Text = (resultValue + double.Parse(textBox1.Text)).ToString();
            }
            else if (operationPerformed == "-")
            {
                textBox1.Text = (resultValue - double.Parse(textBox1.Text)).ToString();
            }
            else if (operationPerformed == "*")
            {
                textBox1.Text = (resultValue * double.Parse(textBox1.Text)).ToString();
            }
            else if (operationPerformed == "/")
            {
                textBox1.Text = (resultValue / double.Parse(textBox1.Text)).ToString();
            }
        }
    }
}
