using EaseCost.ApiEmail.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EaseCost.ApiEmail.Data
{
    public class ECcontext : DbContext
    {
        public ECcontext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Email> emails { get; set; }
    }
}
