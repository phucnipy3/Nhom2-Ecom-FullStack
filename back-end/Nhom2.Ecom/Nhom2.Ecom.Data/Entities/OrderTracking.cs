namespace Nhom2.Ecom.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("OrderTracking")]
    public partial class OrderTracking
    {
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }

        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StatusID { get; set; }

        public DateTime? CompleteAt { get; set; }

        public string Information { get; set; }

        public virtual Order Order { get; set; }

        public virtual Status Status { get; set; }
    }
}
