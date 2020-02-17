using System.Collections.Generic;
using System.Linq;

namespace TheAmazingQuickBuy.Domain.Entities
{
    public abstract class EnitiyBase
    {
        public int Id { get; set; }
        private List<string> _validationMessage  { get; set; }
        public List<string>validationMessage
        {
            get { return _validationMessage ?? (_validationMessage = new List<string>()); }
        }
        protected void ClearValidationMessage()
        {
            validationMessage.Clear();
        }
        protected void AddMessage(string message)
        {
            validationMessage.Add(message);
        }
        public abstract void Validate();
       
        protected bool IsValid
        {
            get { return !validationMessage.Any(); }
        }
    }
}
