using System.Windows;
using Parser;

namespace MultiTaskAISolver
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Parser.Expression function;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string expression = this.expressionTextBox.Text;
            function = new Parser.Expression(expression);
            MessageBox.Show(function.Calculate(new System.Collections.Generic.List<double>() { 0.0, 0.0 }).ToString());
        }
    }
}
