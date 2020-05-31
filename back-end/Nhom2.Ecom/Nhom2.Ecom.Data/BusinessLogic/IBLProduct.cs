using System.Collections.Generic;

namespace Nhom2.Ecom.Data
{
    public interface IBLProduct
    {
        IEnumerable<Product> GetCategories();
    }
}