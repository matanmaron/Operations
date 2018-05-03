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
            EndDate = DateTime.Today;
        }

        public string Company { get; set; }
        public string Zone { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime EndDate { get; set; }
        public int ReshumaId { get; set; }
    }
}
