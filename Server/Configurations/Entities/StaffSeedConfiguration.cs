
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
            },
            new Staff
            {
                Id = 2,
                StaffIcNo = "S2345678F",
                StaffName = "Aaron",
                StaffPostion = "Staff",
                StaffPhoneNo = 87654321,
             },
            new Staff
            {
                Id = 3,
                StaffIcNo = "S3456789F",
                StaffName = "Vedal",
                StaffPostion = "Staff",
                StaffPhoneNo = 76543210,
            },
            new Staff
            {
                Id = 4,
                StaffIcNo = "S4567890F",
                StaffName = "Marciana",
                StaffPostion = "Staff",
                StaffPhoneNo = 65432109,
            },
            new Staff
            {
                Id = 5,
                StaffIcNo = "S5678901F",
                StaffName = "Mark",
                StaffPostion = "Staff",
                StaffPhoneNo = 54321098,
            }
            );
        }
    }
}
