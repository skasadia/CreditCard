using CreditCard.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditCard
{
    public class appContext: DbContext
    {
        public appContext(DbContextOptions options)
           : base(options) { }

        public DbSet<Results> searchResults { get; set; }

        public DbSet<ApplicantEntity> Applicants { get; set; }
        public DbSet<Cards> Cards { get; set; }
    }
}
