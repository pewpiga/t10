using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t10
{
    internal class Consultant : Employee, IConsultant
    {
        private string editor;
        public Consultant()
        {
            editor = "consultant";
        }
        public void ChangePhoneNumber(Client client, ulong phoneNumber)
        {
            if (client.PhoneNumber != phoneNumber)
            {
                client.ChangeLog.Add(new ChangeLog(DateTime.Now, "PhoneNumber", 
                    Convert.ToString(client.PhoneNumber), Convert.ToString(phoneNumber), editor));
            }            
            client.PhoneNumber = phoneNumber;
        }
    }
}
