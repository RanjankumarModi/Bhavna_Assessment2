using system;
using system.collections.generic;
using system.linq;
using system.text;
using system.threading.tasks;

namespace currencyconverter
{
    class conversionlist
    {
        private string currencyname;
    private float exchangevalue;

    public conversionlist(string currencyname, float exchangevalue)
    {
        currencyname1 = currencyname;
        exchangevalue1 = exchangevalue;
    }

    public string currencyname1 { get => currencyname; set => currencyname = value; }
    public float exchangevalue1 { get => exchangevalue; set => exchangevalue = value; }
}
}
