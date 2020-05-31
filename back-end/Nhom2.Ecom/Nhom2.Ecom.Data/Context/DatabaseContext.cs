using Microsoft.EntityFrameworkCore;
using Nhom2.Ecom.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nhom2.Ecom.Data.Context
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions options): base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
