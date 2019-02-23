using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Strix_Schedule.Models
{
    public class resourceModel
    {

        //Temporary Model for Resource
        public int id { get; set; }
        public string title { get; set; }
        public string EventTitle { get; set; }
        public string groupId { get; set; }

        //Temporary Model for Events
        public int EventID { get; set; }
        public int EmployeeID { get; set; } //Also Employee ID
        public string Description { get; set; }
        public DateTime Start { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime Duration { get; set; }
        public DateTime? End { get; set; }
        public bool IsFullDay { get; set; }
        public string ThemeColor { get; set; }

        //Temporary Model for Employee
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Occupation { get; set; }
        public string EmployeeColor { get; set; }


    }
}