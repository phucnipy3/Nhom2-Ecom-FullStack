namespace Nhom2.Ecom.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("Product")]
    public partial class Product
    {
        [Key]
        public int ProductID { get; set; }

        public int? Name { get; set; }

        public string MetaTitle { get; set; }

        public string Detail { get; set; }

        public string Description { get; set; }

        public decimal? Price { get; set; }

        public decimal? PromotionPrice { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public bool Status { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public virtual ICollection<ProductComment> ProductComments { get; set; }

        public virtual ICollection<ProductRate> ProductRates { get; set; }

        public virtual ICollection<CategoryDetail> CategoryDetails { get; set; }

        public virtual ICollection<ProductImage> ProductImages { get; set; }
    }
}
