using System;
using System.Collections.Generic;
using System.Linq;
using TheAmazingQuickBuy.Domain.ObjectValue;

namespace TheAmazingQuickBuy.Domain.Entities
{
    public class Order : EnitiyBase
    {
        public DateTime DateOrder { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public DateTime DateDelivered { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string FullAddress { get; set; }
        public int AddressNumber { get; set; }
        public int FormOfPaymentId { get; set; }
        public virtual FormOfPayment FormOfPayment  { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }

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
