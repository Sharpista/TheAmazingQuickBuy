using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TheAmazingQuickBuy.Domain.Entities;

namespace TheAmazingQuickBuy.Repository.Config
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasKey(i => i.Id);

            builder
                .Property(i => i.ProductId)
                .IsRequired();

            builder
                .Property(i => i.QuantityItem)
                .IsRequired();

           
        }
    }
}
