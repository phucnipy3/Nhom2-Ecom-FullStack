namespace Nhom2.Ecom.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("BlogComment")]
    public partial class BlogComment
    {
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BlogID { get; set; }

        public string Content { get; set; }

        public int? ParentID { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? LastModify { get; set; }

        public virtual Blog Blog { get; set; }

        public virtual Users User { get; set; }
    }
}
