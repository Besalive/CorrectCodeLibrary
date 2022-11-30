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
using CorrectCodeLibrary;

namespace CorrectCode
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CorrectCodeClass obj = new CorrectCodeClass();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            if (obj.IsCorrectCode(TB.Text))
            {
                Button.Content = "True";
                Button.Background = Brushes.Green;
            }
            else
            {
                Button.Content = "False";
                Button.Background = Brushes.Red;
            }
        }
    }
}
