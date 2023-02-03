using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t10
{
    internal class ChangeLog
    {
        public DateTime ChangeDate { get; set; }
        public string ChangedData { get; set; }
        public string OldData { get; set; }
        public string NewData { get; set; }
        public string WhoChanged { get; set; }
        public ChangeLog()
        {
            ChangeDate = DateTime.Now;
            ChangedData = string.Empty;
            OldData = string.Empty;
            NewData = string.Empty;
            WhoChanged = "Generator";
        }
        public ChangeLog(DateTime changeDate, string changedData, string oldData, string newData, string whoChanged)
        {
            ChangeDate = changeDate;
            ChangedData = changedData;
            OldData = oldData;
            NewData = newData;
            WhoChanged = whoChanged;
        }
    }
}
