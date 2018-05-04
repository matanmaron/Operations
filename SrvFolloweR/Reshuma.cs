using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrvFolloweR
{
    public class Reshuma
    {
        public Reshuma(int reshumaid,string company, string zone, string phonenumber, DateTime enddate)
        {
            ReshumaId = reshumaid;
            Company = company;    
            Zone = zone;
            PhoneNumber = phonenumber;
            EndDate = enddate;
        }

        public Reshuma()
        {
            ReshumaId = Form1.LastId;
            Company = "";
            Zone = "";
            PhoneNumber = "0";
            EndDate = DateTime.Now;
        }

        public string Company { get; set; }
        public string Zone { get; set; }
        public string PhoneNumber { get; set; }
        private int EndDateint;
        public DateTime EndDate
        { 
        get {
                // Unix timestamp is seconds past epoch
                System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                dtDateTime = dtDateTime.AddSeconds(EndDateint).ToLocalTime();
                return dtDateTime;
            }
        set
            {
                EndDateint = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            }
        }
        public int ReshumaId { get; set; }

        public static DateTime UnixTimeStampToDateTime(int unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }
    }
}
