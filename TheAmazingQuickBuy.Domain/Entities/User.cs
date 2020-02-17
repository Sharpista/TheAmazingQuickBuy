using System.Collections.Generic;

namespace TheAmazingQuickBuy.Domain.Entities
{
    public class User : EntityBase
    {
        public string Name { get; set; }
        public virtual Photo Photo { get; set; }
        public string LastName { get; set; }
        public int PhotoId { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
       
        public virtual ICollection<Order> Orders { get; set; }

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
