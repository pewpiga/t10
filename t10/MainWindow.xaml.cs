using System;
using System.Collections.Generic;
using System.IO;
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

namespace t10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string jsonPath = "clients.json";
        private int index;
        private List<Client> clients;
        private Operations operations;
        private ReadWrite rw;
        public MainWindow(string role)
        {
            InitializeComponent();

            rw = new ReadWrite(jsonPath);
            if (!File.Exists(jsonPath))
            {
                rw.Initialize(clients, clientList);
                clients = rw.Read();
            }
            else
            {
                clients = rw.Read();
                rw.Initialize(clients, clientList);
            }

            operations = new Operations(role, clients, clientList);
        }

        private void clientList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            index = clientList.SelectedIndex;
            operations.GetClientData(index, fullName, phoneNumber, passNumber);
        }

        private void setButton_Click(object sender, RoutedEventArgs e)
        {
            operations.SetClientData(rw, index, fullName, phoneNumber, passNumber);
            clients = rw.Read();
        }
    }
}
