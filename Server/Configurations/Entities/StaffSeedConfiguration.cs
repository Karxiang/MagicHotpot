
using FullSD.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace FullSD.Server.Configurations.Entities
{
    public class StaffSeedConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
            new Staff
            {
                Id = 1,
                StaffIcNo = "S1234567F",
                StaffName = "Milly",
                StaffPostion = "Manager",
                StaffPhoneNo = 98765432,
                BranchId = 1,
                StaffDOB = new DateTime(2005,03,18),
            },
            new Staff
            {
                Id = 2,
                StaffIcNo = "S2345678F",
                StaffName = "Aaron",
                StaffPostion = "Staff",
                StaffPhoneNo = 87654321,
                BranchId = 1,
                StaffDOB = new DateTime(2001, 06, 15),
            },
            new Staff
            {
                Id = 3,
                StaffIcNo = "S3456789F",
                StaffName = "Vedal",
                StaffPostion = "Staff",
                StaffPhoneNo = 76543210,
                BranchId = 2,
                StaffDOB = new DateTime(1999, 05, 18),
            },
            new Staff
            {
                Id = 4,
                StaffIcNo = "S4567890F",
                StaffName = "Marciana",
                StaffPostion = "Staff",
                StaffPhoneNo = 65432109,
                BranchId = 3,
                StaffDOB = new DateTime(2002, 08, 20),
            },
            new Staff
            {
                Id = 5,
                StaffIcNo = "S5678901F",
                StaffName = "Mark",
                StaffPostion = "Staff",
                StaffPhoneNo = 54321098,
                BranchId = 4,
                StaffDOB = new DateTime(1996, 11, 10),
            }
            );
        }
    }
}
