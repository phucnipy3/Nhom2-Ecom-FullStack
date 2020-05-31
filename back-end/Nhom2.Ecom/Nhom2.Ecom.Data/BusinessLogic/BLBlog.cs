using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nhom2.Ecom.Data
{
    public class BLBlog : IBLBlog
    {
        private readonly DatabaseContext _db;

        public BLBlog(DatabaseContext db)
        {
            _db = db;
        }

        public IEnumerable<Blog> GetCategories()
        {
            return _db.Blogs.Where(x => x.Status);
        }
    }
}
