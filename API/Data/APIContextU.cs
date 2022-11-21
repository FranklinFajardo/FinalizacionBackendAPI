using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API.models;

namespace API.Data
{
    public class APIContextU : DbContext
    {
        public APIContextU (DbContextOptions<APIContextU> options)
            : base(options)
        {
        }

        public DbSet<API.models.Usuarios> Usuarios { get; set; }
    }
}
