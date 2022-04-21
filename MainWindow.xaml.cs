using System.Windows;
using System.Windows.Controls;

namespace NetPierwszeZajecia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ResultText.Text = string.Empty;
            CurrentOperationText.Text = string.Empty;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            ResultText.Text = string.Empty;
            var button = sender as Button;
#pragma warning disable CS8602 // Wyłuskanie odwołania, które może mieć wartość null.
            var currentNumber = button.Name[button.Name.Length-1];
#pragma warning restore CS8602 // Wyłuskanie odwołania, które może mieć wartość null.
            CurrentOperationText.Text += currentNumber;

        }
        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;
            if (ifTheresOperation(operation))
            {
                CurrentOperationText.Text = Result(operation).ToString();
            }
            CurrentOperationText.Text += "+";
        }
        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;
            if (ifTheresOperation(operation))
            {
                CurrentOperationText.Text = Result(operation).ToString();
            }

            CurrentOperationText.Text += "-";

        }
        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;
            if (ifTheresOperation(operation))
            {
                CurrentOperationText.Text = Result(operation).ToString();
            }
            CurrentOperationText.Text += "*";

        }
        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;
            if (ifTheresOperation(operation))
            {
                CurrentOperationText.Text = Result(operation).ToString();
            }
            CurrentOperationText.Text += "/";

        }
        private void ButtonEqual_Click(object sender, RoutedEventArgs e)
        {
            var operation = CurrentOperationText.Text;

            ResultText.Text = Result(operation).ToString();

        }

        private int Result(string operation)
        {
            if (operation.Contains('+'))
            {
                var elements = operation.Split('+');

               return int.Parse(elements[0]) + int.Parse(elements[1]);
            }
            if (operation.Contains('-'))
            {
                var elements = operation.Split('-');

                return int.Parse(elements[0]) - int.Parse(elements[1]);
            }
            if (operation.Contains('*'))
            {
                var elements = operation.Split('*');

                return int.Parse(elements[0]) * int.Parse(elements[1]);
            }
            if (operation.Contains('/'))
            {
                var elements = operation.Split('/');

                return int.Parse(elements[0]) / int.Parse(elements[1]);
            }
            return 0;
        }

        private bool ifTheresOperation(string operation)
        {
            return operation.Contains('+') || operation.Contains('-') || operation.Contains('*') || operation.Contains('/');
        }
        
    }
}
