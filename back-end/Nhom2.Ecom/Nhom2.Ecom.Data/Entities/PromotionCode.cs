namespace Nhom2.Ecom.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("PromotionCode")]
    public partial class PromotionCode
    {
        [Key]
        public int PromotionCodeID { get; set; }

        public string Code { get; set; }

        public string Infomation { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public bool Status { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
