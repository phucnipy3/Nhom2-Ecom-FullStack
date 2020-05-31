namespace Nhom2.Ecom.Data
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    [Table("Users")]
    public partial class Users
    {
        [Key]
        public int UserID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public int Permission { get; set; }

        public string Name { get; set; }

        public string Sex { get; set; }

        public string Avatar { get; set; }

        public bool Status { get; set; }

        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public virtual ICollection<ProductRate> ProductRates { get; set; }

        public virtual ICollection<BlogComment> BlogComments { get; set; }

        public virtual ICollection<ProductComment> ProductComments { get; set; }
    }
}
