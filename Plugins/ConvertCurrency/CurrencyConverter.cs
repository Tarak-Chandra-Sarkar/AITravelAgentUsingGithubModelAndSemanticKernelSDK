using AITravelAgent;
using Microsoft.SemanticKernel;
using System.ComponentModel;

public class CurrencyConverter
{
    [KernelFunction("ConvertAmount")]
    [Description("Converts an amount from one currency to another")]
    public static string ConvertAmount(string amount, string baseCurrencyCode, string targetCurrencyCode)
    {
        var currencyDictionary = Currency.Currencies;
        Currency targetCurrency = currencyDictionary[targetCurrencyCode];
        Currency baseCurrency = currencyDictionary[baseCurrencyCode];

        if (targetCurrency == null)
        {
            return targetCurrencyCode + " was not found";
        }
        else if (baseCurrency == null)
        {
            return baseCurrencyCode + " was not found";
        }
        else
        {
            double amountInUSD = Double.Parse(amount) * baseCurrency.USDPerUnit;
            double result = amountInUSD * targetCurrency.UnitsPerUSD;
            return result + targetCurrencyCode;
        }
    }
}
