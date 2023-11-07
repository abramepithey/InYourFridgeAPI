using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InYourFridgeAPI.Models;

namespace InYourFridgeAPI.Data
{
    public class InYourFridgeAPIContext : DbContext
    {
        public InYourFridgeAPIContext (DbContextOptions<InYourFridgeAPIContext> options)
            : base(options)
        {
        }

        public DbSet<InYourFridgeAPI.Models.Ingredient> Ingredient { get; set; } = default!;
    }
}
