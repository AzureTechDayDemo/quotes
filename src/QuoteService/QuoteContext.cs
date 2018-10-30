using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteService
{
    public class QuoteContext : DbContext
    {
        public QuoteContext(DbContextOptions<QuoteContext> options)
            : base(options)
        {

        }
        public DbSet<Quote> Quotes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Quote>()
                   .HasData(new Quote { Id=1,Attribution="Will Huang", Text="The network is always reliable." },
                            new Quote { Id=2,Attribution="Albert Einstein", Text="The value of a man resides in what he gives and not in what he is capable of receiving." },
                            new Quote { Id=3,Attribution="N/A", Text="世上沒有絕望的處境，只有對處境絕望的人。" }
                   );
        }
    }
}
