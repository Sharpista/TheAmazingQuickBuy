using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TheAmazingQuickBuy.Domain.Entities;

namespace TheAmazingQuickBuy.Repository.Config
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.Id);
            builder
                .Property(o => o.FullAddress)
                .IsRequired()
                .HasMaxLength(150);

            builder
                .Property(o => o.DateDelivered)
                .IsRequired();

            builder
                .Property(o => o.DateOrder)
                .IsRequired();

            builder
                .Property(o => o.AddressNumber)
                .IsRequired()
                .HasMaxLength(10);

            builder
                .Property(o => o.PostalCode)
                .IsRequired()
                .HasMaxLength(10);

            builder
                .Property(o => o.City)
                .IsRequired()
                .HasMaxLength(20);

            builder
                .Property(o => o.State)
                .IsRequired()
                .HasMaxLength(20);

            builder.HasOne(o => o.FormOfPayment);
        }
    }
}
