namespace ELibraryStore.Data
{
    public class Conversion
    {
        public int Naira { get; set; } = 680;
        public string CurrencyConversion(double price)
        {
            double amount = price * Naira;
            string naira = "N " + (amount).ToString();

            return naira;
        }
    }
}
