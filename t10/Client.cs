using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t10
{
    internal class Client
    {
        public string FullName { get; set; }
        public ulong PhoneNumber { get; set; }
        public string PassNumber { get; set; }
        public List<ChangeLog> ChangeLog { get; set; }
        public Client()
        {
            FullName = string.Empty;
            PhoneNumber = ulong.MinValue;
            PassNumber = string.Empty;
            ChangeLog = new List<ChangeLog>();
        }
        public Client(string fullName, ulong phoneNumber, string passNumber, List<ChangeLog> changeLogs)
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;
            PassNumber = passNumber;
            ChangeLog = changeLogs;
        }
    }
}
