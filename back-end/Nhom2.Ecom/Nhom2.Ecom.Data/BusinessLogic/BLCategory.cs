using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nhom2.Ecom.Data
{
    public class BLCategory : IBLCategory
    {
        private readonly DatabaseContext _db;

        public BLCategory(DatabaseContext db)
        {
            _db = db;
        }

        public IEnumerable<Category> GetCategories()
        {
            return _db.Categories.Where(x => x.Status);
        }
    }
}
