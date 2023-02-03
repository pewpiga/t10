using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t10
{
    internal class ClientGenerator
    {
        private List<Client> _clients;
        private Random _rand;
        public ClientGenerator()
        {
            _clients = new List<Client>();
            _rand = new Random();
        }
        public List<Client> ClientListGenerator(int count)
        {
            Client client;
            string firstName;
            string secondName;
            string lastName;
            string phoneNumber;

            for (int i = 0; i < count; i++)
            {
                client = new Client();

                lastName = "Фамилия" + _rand.Next(0, 8 * i);
                firstName = "Имя" + _rand.Next(0, 9 * i);
                secondName = "Отчество" + _rand.Next(0, 10 * i);
                client.FullName = $"{lastName} {firstName} {secondName}";

                phoneNumber = $"7{_rand.Next(900, 999)}{_rand.Next(1000000, 9999999)}";
                client.PhoneNumber = Convert.ToUInt64(phoneNumber);

                client.PassNumber = $"{_rand.Next(1000, 9999)} {_rand.Next(100000, 999999)}";

                _clients.Add(client);
            }
            return _clients;
        }
    }
}
