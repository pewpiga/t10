using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace t10
{
    internal class Operations
    {
        private Employee employee;
        private List<Client> clients;
        private ListBox clientList;
        private string role;
        
        public Operations(string role, List<Client> clients, ListBox clientList)
        {
            this.role = role;
            if (role == "Консультант")
                employee = new Consultant();
            else if (role == "Менеджер")
                employee = new Manager();
            this.clients = clients;
            this.clientList = clientList;
        }
        /// <summary>
        /// Получение данных о клиенте
        /// </summary>
        /// <param name="index"></param>
        /// <param name="fullName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="passNumber"></param>
        public void GetClientData(int index, TextBox fullName, TextBox phoneNumber, TextBox passNumber)
        {
            Client client = employee.GetData(clients[index]);
            fullName.Text = client.FullName;
            phoneNumber.Text = Convert.ToString(client.PhoneNumber);
            passNumber.Text = client.PassNumber;
        }
        /// <summary>
        /// Изменение данных о клиенте
        /// </summary>
        /// <param name="rw"></param>
        /// <param name="index"></param>
        /// <param name="fullName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="passNumber"></param>
        public void SetClientData(ReadWrite rw, int index, TextBox fullName, TextBox phoneNumber, TextBox passNumber)
        {
            Client client = clients[index];
            string pass = PassCheck(index, passNumber);
            if (role == "Консультант")
            {
                (employee as Consultant).ChangePhoneNumber(client, Convert.ToUInt64(phoneNumber.Text));
            }
            else if (role == "Менеджер")
            {
                (employee as Manager).ChangeFullName(client, fullName.Text);
                (employee as Manager).ChangePhoneNumber(client, Convert.ToUInt64(phoneNumber.Text));
                (employee as Manager).ChangePassNumber(client, pass);
            }
            clients[index] = client;
            rw.Write(clients);
        }
        /// <summary>
        /// Замена ********* на нормальный номер при записи в json
        /// <param name="index"></param>
        /// <param name="passNumber"></param>
        /// <returns></returns>
        public string PassCheck(int index, TextBox passNumber)
        {
            string pass;

            if (passNumber.Text.StartsWith("*") || passNumber.Text.EndsWith("*"))
                pass = clients[index].PassNumber;
            else
                pass = passNumber.Text;

            return pass;
        }
    }
}
