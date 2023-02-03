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

namespace t10
{
    /// <summary>
    /// Логика взаимодействия для SelectorWindow.xaml
    /// </summary>
    public partial class SelectorWindow : Window
    {
        public SelectorWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow;

            if (selectedRole.Text == "Консультант")
            {
                mainWindow = new MainWindow(selectedRole.Text);
                mainWindow.Show();
            }
            else if (selectedRole.Text == "Менеджер")
            {
                mainWindow = new MainWindow(selectedRole.Text);
                mainWindow.Show();
            }
            this.Close();
        }
    }
}
