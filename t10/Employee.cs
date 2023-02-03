using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t10
{
    internal class Employee
    {
        private Client _client;
        public Employee() 
        {
            _client = new Client();
        }
        public Client GetData(Client client)
        {
            _client.FullName = client.FullName;
            _client.PhoneNumber = client.PhoneNumber;
            if (_client.PassNumber != null)
                _client.PassNumber = "******************";
            else
                _client.PassNumber = "";
            return _client;
        }
    }
}
