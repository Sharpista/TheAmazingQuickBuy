using System;
using System.Collections.Generic;
using System.Text;
using TheAmazingQuickBuy.Domain.ObjectValue.Enums;

namespace TheAmazingQuickBuy.Domain.ObjectValue
{
    public class FormOfPayment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public bool IsBankSlip
        {
            get { return Id == (int)FormPaymentEnums.BankSlip; }
        }
        public bool IsCreditCard
        {
            get { return Id == (int)FormPaymentEnums.CreditCard; }
        }
        public bool IsUndefined
        {
            get { return Id == (int)FormPaymentEnums.Undefined; }
        }
        public bool IsDeposit
        {
            get { return Id == (int)FormPaymentEnums.Deposit; }
        }
    }
}
