using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Nhom2.Ecom.Data
{
    [Table("CategoryDetail")]
    public partial class CategoryDetail
    {
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategoryID { get; set; }

        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }

        public virtual Category Category { get; set; }

        public virtual Product Product { get; set; }
    }
}
