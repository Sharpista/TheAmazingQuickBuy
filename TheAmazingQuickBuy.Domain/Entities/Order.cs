using System;
using System.Collections.Generic;
using System.Linq;
using TheAmazingQuickBuy.Domain.ObjectValue;

namespace TheAmazingQuickBuy.Domain.Entities
{
    class Order : EnitiyBase
    {
        public DateTime DateOrder { get; set; }
        public int UserId { get; set; }
        public DateTime DateDelivered { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string FullAddress { get; set; }
        public int AddressNumber { get; set; }
        public int FormPaymentId { get; set; }
        public FormOfPayment FormOfPayment  { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }

        public override void Validate()
        {
            if (!OrderItems.Any())
            {
                ClearValidationMessage();
                AddMessage("Critica - Pedido não pode ficar sem item de pedido");
            }
            if (string.IsNullOrEmpty(PostalCode))
            {
                AddMessage("Critica - Postal Code deve ser preenchido");
            }
            
        }
    }
}
