using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t10
{
    internal interface IConsultant
    {
        public void ChangePhoneNumber(Client client, ulong phoneNumber);
    }
}
