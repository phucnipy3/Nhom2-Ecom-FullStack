using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nhom2.Ecom.Data
{
    public class BLOrder : IBLOrder
    {
        private readonly DatabaseContext _db;

        public BLOrder(DatabaseContext db)
        {
            _db = db;
        }

        public IEnumerable<Order> GetCategories()
        {
            return _db.Orders;
        }
    }
}
