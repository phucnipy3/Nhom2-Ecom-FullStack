namespace Nhom2.Ecom.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("Order")]
    public partial class Order
    {
        [Key]
        public int OrderID { get; set; }

        public int UserID { get; set; }

        public string Message { get; set; }

        public string Transport { get; set; }

        public string Payment { get; set; }

        public int? PromotionCodeID { get; set; }

        public int CustomerAddressID { get; set; }

        public int? StatusID { get; set; }

        public virtual Users User { get; set; }

        public virtual CustomerAddress CustomerAddress { get; set; }

        public virtual PromotionCode PromotionCode { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public virtual ICollection<OrderTracking> OrderTrackings { get; set; }
    }
}
