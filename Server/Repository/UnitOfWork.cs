
using FullSD.Server.Data;
using FullSD.Server.IRepository;
using FullSD.Server.Models;
using FullSD.Server.Repository;
using FullSD.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FullSD.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Booking> _bookings;
        private IGenericRepository<Branch> _branches;
        private IGenericRepository<Food> _foods;
        private IGenericRepository<OrderItem> _orderItems;
        private IGenericRepository<Review> _reviews;
        private IGenericRepository<Staff> _staffs;
        private IGenericRepository<Customer> _customers;


        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<Booking> Bookings
            => _bookings ??= new GenericRepository<Booking>(_context);
        public IGenericRepository<Branch> Branches
            => _branches ??= new GenericRepository<Branch>(_context);
        public IGenericRepository<Food> Foods
            => _foods ??= new GenericRepository<Food>(_context);
        public IGenericRepository<OrderItem> OrderItems
            => _orderItems ??= new GenericRepository<OrderItem>(_context);

        public IGenericRepository<Review> Reviews
            => _reviews ??= new GenericRepository<Review>(_context);
        public IGenericRepository<Staff> Staffs
            => _staffs ??= new GenericRepository<Staff>(_context);

        public IGenericRepository<Customer> Customers
    => _customers ??= new GenericRepository<Customer>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user;
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}