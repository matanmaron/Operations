using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SrvFolloweR
{
    //[Serializable]
    public class Call
    {
        public Call(int callid, string representative, string contents, DateTime calldate, string remarks)
        {
            CallID = callid;
            Representative = representative;
            Contents = contents;
            CallDate = calldate;
            Remarks = remarks;
        }

        public Call()
        {
            CallID = 0;
            Representative = "";
            Contents = "";
            CallDate = DateTime.Now;
            Remarks = "";
            CallEnd = DateTime.Now;
        }

        public double CallID { get; set; }
        public string Representative { get; set; }
        public string Contents { get; set; }
        private int CallDateint;
        public DateTime CallDate {
            get {
                // Unix timestamp is seconds past epoch
                System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                dtDateTime = dtDateTime.AddSeconds(CallDateint).ToLocalTime();
                return dtDateTime;
            }
            set
            {
                CallDateint = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            }
        }
        public string Remarks { get; set; }
        private int CallEndint;
        public DateTime CallEnd
        {
            get
            {
                // Unix timestamp is seconds past epoch
                System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                dtDateTime = dtDateTime.AddSeconds(CallEndint).ToLocalTime();
                return dtDateTime;
            }
            set
            {
                CallEndint = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            }
        }

        public static DateTime UnixTimeStampToDateTime(int unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }
    }
}
