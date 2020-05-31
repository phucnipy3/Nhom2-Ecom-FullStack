using System.Collections.Generic;

namespace Nhom2.Ecom.Data
{
    public interface IBLUsers
    {
        IEnumerable<Users> GetUsers();

        void Add(Users user);

        bool Exists();
    }
}