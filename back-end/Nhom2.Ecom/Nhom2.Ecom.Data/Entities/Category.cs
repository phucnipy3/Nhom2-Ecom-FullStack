namespace Nhom2.Ecom.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("Category")]
    public partial class Category
    {
        [Key]
        public int CategoryID { get; set; }

        public string Name { get; set; }

        public string MetaTitle { get; set; }

        public int? ParentID { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public bool Status { get; set; }

        public virtual ICollection<CategoryDetail> CategoryDetails { get; set; }
    }
}
