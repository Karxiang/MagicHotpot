using Duende.IdentityServer.EntityFramework.Options;
using FullSD.Server.Models;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using FullSD.Shared.Domain;

namespace FullSD.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

		public DbSet<Customer> Customers { get; set; }
        public DbSet<Booking> Bookings { get; set; }
		public DbSet<Branch> Branches { get; set; }
		public DbSet<Food> Foods { get; set; }
		public DbSet<OrderItem> OrderItems { get; set; }
		public DbSet<Review> Reviews { get; set; }
		public DbSet<Staff> Staffs { get; set;}
	}
}