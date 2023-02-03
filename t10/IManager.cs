using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t10
{
    internal interface IManager
    {
        public void ChangeFullName(Client client, string fullName);
        public void ChangePassNumber(Client client, string passNumber);
    }
}
