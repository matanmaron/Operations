using System;
using System.Collections.Generic;

namespace SrvFolloweR
{
    public class Reshuma
    {
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
                EndDateint = (int)(value.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            }
        }
        public int ReshumaId { get; set; }
        public List<Call> Calls { get; set; }

        public Reshuma()
        {
            if (DataHandler.reshumas.Capacity > 0)
            {
                int max = 1;
                foreach (var resh in DataHandler.reshumas)
                {
                    if (resh.ReshumaId > max)
                    {
                        max = resh.ReshumaId;
                    }
                }
                ReshumaId = max + 1;
            }
            else
            {
                ReshumaId = 1;
            }
            Company = string.Empty;
            Zone = string.Empty;
            PhoneNumber = string.Empty;
            EndDate = DateTime.Now;
            Calls = new List<Call>();
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
