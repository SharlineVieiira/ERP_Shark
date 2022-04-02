using ERP_Shark;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace ERP_Shark
{
    public class Context : DbContext
    {

        public Context() : base("DB")
        {
        }
        public DbSet<DtoUsuario> usuario { get; set; }
        public DbSet<DtoProduto> produto { get; set; }

    }
}