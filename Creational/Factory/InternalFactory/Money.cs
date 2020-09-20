using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.InternalFactory
{
    public class Money
    {
        public string Currency { get; }
        public decimal Value { get; }

        private Money(string currency, decimal value)
        {
            Currency = currency;
            Value = value;
        }

        public override string ToString()
        {
            return $"{nameof(Currency)}: {Currency}, {nameof(Value)}: {Value}";
        }

        #region InnerFactory

        public static class Factory
        {
            public static Money PLN(decimal value)
            {
                return new Money("PLN", value);
            }

            public static Money USD(decimal value)
            {
                return new Money("USD", value);
            }
        }

        #endregion

    }
}
