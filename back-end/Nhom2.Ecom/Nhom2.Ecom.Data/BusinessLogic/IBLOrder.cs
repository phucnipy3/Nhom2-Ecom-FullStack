using System.Collections.Generic;

namespace Nhom2.Ecom.Data
{
    public interface IBLOrder
    {
        IEnumerable<Order> GetCategories();
    }
}