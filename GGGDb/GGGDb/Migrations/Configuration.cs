namespace GGGDb.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GGGDb.GGGDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GGGDb.GGGDbContext context)
        {
            using (var ctx = new GGGDbContext())
            {
                List<Book> books = new List<Book>()
                {
                    new Book(Guid.NewGuid(), "Catcher in the Rye","J. D. Salinger", 199),
                    new Book(Guid.NewGuid(), "The Selfish Gene", "Richard Dawkins", 209),
                    new Book(Guid.NewGuid(), "Letter to a christian nation","Sam Harris", 205),
                    new Book(Guid.NewGuid(), "The origin of species","Charles Darwin", 399)
                };

                foreach (var item in books)
                {
                    ctx.Books.Add(item);
                }
                ctx.SaveChanges();
            }
        }
    }
}
