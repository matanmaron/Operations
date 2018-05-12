using System;

namespace SrvFolloweR
{
    public class Call
    {
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
                CallDateint = (int)(value.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
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

        public Call()
        {
            if (DataHandler.reshumas[DataHandler.selectedid].Calls.Capacity > 0)
            {
                double max = 1;
                foreach (var call in DataHandler.reshumas[DataHandler.selectedid].Calls)
                {
                    if (call.CallID > max)
                    {
                        max = call.CallID;
                    }
                }
                CallID = max + 1;
            }
            else
            {
                CallID = 1;
            }
            Representative = string.Empty;
            Contents = string.Empty;
            CallDate = DateTime.Now;
            Remarks = string.Empty;
            CallEnd = DateTime.Now;
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
