using GlobalTicket.TicketManagement.Domain.Common;
using GlobalTicket.TicketManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GlobalTicket.TicketManagement.Persistence
{
    public class GlobalTicketDbContext:DbContext
    {
        public GlobalTicketDbContext(DbContextOptions<GlobalTicketDbContext> options)
            : base(options)
        {

        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override  void OnModelCreating(ModelBuilder modelBuilder)
        {
            //??
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GlobalTicketDbContext).Assembly);

            var concertGuid = Guid.Parse("{18FCDF5E-E36A-45F6-9554-827CA0367B06}");
            var musicalGuid = Guid.Parse("{4B7209D3-06BE-4595-AAB6-8A2307AB4943}");
            var playGuid = Guid.Parse("{ECB7E526-BDF7-4EE9-A955-A5388F6FD1ED}");
            var conferenceGuid = Guid.Parse("{65157130-0489-4CF0-BD4F-4D44B237E57C}");

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId=concertGuid,
                Name = "Concerts"
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = musicalGuid,
                Name = "Musicals"
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = playGuid,
                Name = "Plays"
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = conferenceGuid,
                Name = "Conferences"
            });

            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = Guid.Parse("{B0AA8647-403E-4FB6-AAD1-727820B97CAF}"),
                Name = "Sezen Aksu Live",
                Price = 300,
                Artist = "Sezen Aksu",
                Date = DateTime.Now.AddMonths(6),
                Description = "Bu bir Sezen Aksu konseri için yapılan açıklamadır.",
                ImageUrl = "https://images.app.goo.gl/kCcpzuubW44VtY8F6",
                CategoryId = concertGuid
            });

            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = Guid.Parse("{E56C5E17-E600-4B69-92E3-F41778CEBCEB}"),
                Name = "Erol Evgin Live",
                Price = 200,
                Artist = "Erol Evgin",
                Date = DateTime.Now.AddMonths(9),
                Description = "Bu bir Erol Evgin konseri için yapılan açıklamadır.",
                ImageUrl = "https://images.app.goo.gl/S8TC2NSkmhpyLrnr9",
                CategoryId = concertGuid
            });

            modelBuilder.Entity<Order>().HasData(new Order {
                Id = Guid.Parse("{ABE9C743-4A18-402C-976D-1F98AC7D0F0E}"),
                OrderTotal = 200,
                OrderPaid = true,
                OrderPlaced = DateTime.Now,
                UserId = Guid.Parse("{CEF94DEE-A7B0-49B4-915E-C8BB764F89C7}")
            });

            modelBuilder.Entity<Order>().HasData(new Order
            {
                Id = Guid.Parse("{9B739DD9-AC04-4F68-B33A-91BA54B091D3}"),
                OrderTotal = 300,
                OrderPaid = true,
                OrderPlaced = DateTime.Now,
                UserId = Guid.Parse("{FF5F5FE1-B4A3-492B-9477-4CE6174F0627}")
            });
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
