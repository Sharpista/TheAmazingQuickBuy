namespace TheAmazingQuickBuy.Domain.Entities
{
    public class Product : EntityBase
    {
        public string Name { get; set; }
        public virtual Photo Photo { get; set; }
        public int PhotoId { get; set; }
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
