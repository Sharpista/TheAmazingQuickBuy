namespace TheAmazingQuickBuy.Domain.Entities
{
    class OrderItem : EnitiyBase
    {
        public int ProductId { get; set; }
        public int QuantityItem { get; set; }

        public override void Validate()
        {
           if(ProductId == 0)
           {
                AddMessage("Não foi identificado qual a referência do produto");
           }
           if(QuantityItem == 0)
           {
                AddMessage("Quantidade não foi informada");
           }

        }
    }
}
