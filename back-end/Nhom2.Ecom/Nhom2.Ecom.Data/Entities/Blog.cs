namespace Nhom2.Ecom.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("Blog")]
    public partial class Blog
    {
        [Key]
        public int BlogID { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public int CreateBy { get; set; }

        public DateTime CreateDate { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public bool Status { get; set; }

        public virtual ICollection<BlogComment> BlogComments { get; set; }
    }
}
