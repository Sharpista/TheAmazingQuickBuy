using System.Collections.Generic;

namespace TheAmazingQuickBuy.Domain.Entities
{
    class User : EnitiyBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string LastName { get; set; }
        public ICollection<Product> Products { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
            {
                AddMessage("Email não foi informado");
            }
            if (string.IsNullOrEmpty(Password))
            {
                AddMessage("Senha não foi informada");
            }
            if (string.IsNullOrEmpty(Name))
            {
                AddMessage("Nome não foi informado");
            }
        }
    }
}
