namespace Nhom2.Ecom.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    [Table("Status")]
    public partial class Status
    {
        [Key]
        public int StatusID { get; set; }

        public string Infomation { get; set; }

        public virtual ICollection<OrderTracking> OrderTrackings { get; set; }
    }
}
