﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace TALENTO2017__.Models
{
    public class PGDbContext : DbContext
    {
        public PGDbContext() : base(nameOrConnectionString: "DefaultConnectionString") { }
        public virtual DbSet<Users> Usr  { get; set; }
    }
}