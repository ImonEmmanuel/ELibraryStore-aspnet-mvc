namespace ELibraryStore.Models.PaymentData
{
    public class InputData
    {
        public string email { get; set; } 
        public string amount { get; set; }

        public string currency { get; set; } = "NGN";
        public string reference { get; set; } = Generate();
        public string callback_url { get; set;  }

        public static string Generate()
        {
            Random rand = new Random((int)DateTime.Now.Ticks);

            return rand.Next(100000000, 999999999).ToString();
        }
    }

    
}
