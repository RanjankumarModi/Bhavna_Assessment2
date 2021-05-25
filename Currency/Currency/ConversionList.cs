using System;
using System.Collections.Generic;
using System.Text;

namespace Currency
{
    class ConversionList
    {
        private string currencyname;
        private float exchangevalue;

        public ConversionList(string currencyname, float exchangevalue)
        {
            this.currencyname = currencyname;
            this.exchangevalue = exchangevalue;
        }

        public string Currencyname { get => currencyname; set => currencyname = value; }
        public float Exchangevalue { get => exchangevalue; set => exchangevalue = value; }
    }
}
