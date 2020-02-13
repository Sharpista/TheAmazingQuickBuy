namespace TheAmazingQuickBuy.Domain.Entities
{
    class Product : EnitiyBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Name))
            {
                AddMessage("Nome está vazio ou  nulo");
            }
        }
    }
}
