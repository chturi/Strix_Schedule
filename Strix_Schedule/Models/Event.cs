namespace Strix_Schedule
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Event
    {
        public int EventID { get; set; }

        public int EmployeeID { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        public DateTime Start { get; set; }

        public DateTime? End { get; set; }

        public bool IsFullDay { get; set; }

        [StringLength(20)]
        public string ThemeColor { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
