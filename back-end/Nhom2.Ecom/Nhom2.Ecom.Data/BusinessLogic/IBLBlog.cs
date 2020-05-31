using System.Collections.Generic;

namespace Nhom2.Ecom.Data
{
    public interface IBLBlog
    {
        IEnumerable<Blog> GetCategories();
    }
}