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
    public class BranchSeedConfiguration : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.HasData(
            new Branch
            {
                Id = 1,
                BranchName="Tampines",
                BranchAddress="Tampines 1",
                BranchCapacity=40,
                BranchPhoneNo=62345678,
            },
            new Branch
            {
                Id = 2,
                BranchName = "Ubi",
                BranchAddress = "Ubi Avenue 1",
                BranchCapacity = 45,
                BranchPhoneNo = 63456781,
            },
            new Branch
            {
                Id = 3,
                BranchName = "Serangoon",
                BranchAddress = "Serangoon Nex",
                BranchCapacity = 47,
                BranchPhoneNo = 64567812,
            },
             new Branch
             {
                 Id = 4,
                 BranchName = "Ang Mo Kio",
                 BranchAddress = "Ang Mo Kio Hub",
                 BranchCapacity = 50,
                 BranchPhoneNo = 65678123,
             }
             );
        }
    }
}
