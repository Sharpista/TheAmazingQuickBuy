using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TheAmazingQuickBuy.Domain.ObjectValue;

namespace TheAmazingQuickBuy.Repository.Config
{
    public class FormPaymentConfiguration : IEntityTypeConfiguration<FormOfPayment>
    {
        public void Configure(EntityTypeBuilder<FormOfPayment> builder)
        {
            builder.HasKey(f => f.Id);

            builder
                .Property(f => f.Description)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(f => f.Name)
                .IsRequired()
                .HasMaxLength(50);
                
        }
    }
}
