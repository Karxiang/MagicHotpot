using FullSD.Server.IRepository;
using FullSD.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace FullSD.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Booking> Bookings { get; }
        IGenericRepository<Branch> Branches { get; }
        IGenericRepository<Food> Foods { get; }
        IGenericRepository<OrderItem> OrderItems { get; }
        IGenericRepository<Review> Reviews { get; }
        IGenericRepository<Staff> Staffs { get; }

        IGenericRepository<Customer> Customers { get; }
    }
}