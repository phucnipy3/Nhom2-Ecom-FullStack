namespace Nhom2.Ecom.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("Province")]
    public partial class Province
    {
        [Key]
        public int ProvinceID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }
    }
}
