using System.Collections.Generic;

namespace Nhom2.Ecom.Data
{
    public interface IBLCategory
    {
        IEnumerable<Category> GetCategories();
    }
}