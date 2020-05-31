namespace Nhom2.Ecom.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("CustomerAddress")]
    public partial class CustomerAddress
    {
        [Key]
        public int CustomerAddressID { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public int? ProvinceID { get; set; }

        public int UserID { get; set; }

        public virtual Users User { get; set; }

        public virtual Province Province { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
