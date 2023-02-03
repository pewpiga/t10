using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t10
{
    internal class Manager : Consultant, IManager
    {
        private string editor;
        public Manager()
        {
            editor = "manager";
        }
        public void ChangeFullName(Client client, string fullName)
        {
            if (client.FullName != fullName)
            {
                client.ChangeLog.Add(new ChangeLog(DateTime.Now, "FullName", client.FullName, fullName, editor));
            }            
            client.FullName = fullName;
        }
        public void ChangePassNumber(Client client, string passNumber)
        {
            if (client.PassNumber != passNumber)
            {
                client.ChangeLog.Add(new ChangeLog(DateTime.Now, "PassNumber", client.PassNumber, passNumber, editor));
            }
            client.PassNumber = passNumber;
        }
    }
}
