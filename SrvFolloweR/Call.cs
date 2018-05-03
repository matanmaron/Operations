using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrvFolloweR
{
    public class Call
    {
        public Call(int callid, string reprepresentative, string contents, DateTime calldate, string remarks)
        {
            CallID = callid;
            Reprepresentative = reprepresentative;
            Contents = contents;
            CallDate = calldate;
            Remarks = remarks;
        }

        public Call()
        {
            CallID = Form2.LastCallId;
            Reprepresentative = "";
            Contents = "";
            CallDate = DateTime.Today;
            Remarks = "";
            CallEnd = DateTime.Today;
        }

        public double CallID { get; set; }
        public string Reprepresentative { get; set; }
        public string Contents { get; set; }
        public DateTime CallDate { get; set; }
        public string Remarks { get; set; }
        public DateTime CallEnd { get; set; }
    }
}
