using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nhom2.Ecom.Data
{
    public class BLProduct : IBLProduct
    {
        private readonly DatabaseContext _db;

        public BLProduct(DatabaseContext db)
        {
            _db = db;
        }

        public IEnumerable<Product> GetCategories()
        {
            return _db.Products.Where(x => x.Status);
        }
    }
}
