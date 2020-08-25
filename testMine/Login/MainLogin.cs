using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testMine.Login
{
    public class PostgreDB : DbContext
    {
        public PostgreDB(DbContextOptions<PostgreDB> options) : base(options)
        { }
        public virtual DbSet<LoginTable.LoginList> Country { get; set; }
       
    }
}
