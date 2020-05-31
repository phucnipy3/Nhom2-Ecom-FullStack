namespace Nhom2.Ecom.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("ProductImage")]
    public partial class ProductImage
    {
        [Key]
        public int ProductImageID { get; set; }

        public string Image { get; set; }

        public int ProductID { get; set; }

        public virtual Product Product { get; set; }
    }
}
