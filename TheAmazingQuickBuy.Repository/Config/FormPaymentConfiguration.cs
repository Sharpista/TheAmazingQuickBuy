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
            throw new NotImplementedException();
        }
    }
}
