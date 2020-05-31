using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nhom2.Ecom.Data
{
    public class BLUsers : IBLUsers
    {
        private readonly DatabaseContext db;

        public BLUsers(DatabaseContext db)
        {
            this.db = db;
        }

        public IEnumerable<Users> GetUsers()
        {
            return db.Users;
        }

        public void Add(Users user)
        {
            user.Status = true;
            db.Users.Add(user);
            db.SaveChanges();
        }

        public bool Exists()
        {
            return true;
        }
    }
}
