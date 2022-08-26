namespace ELibraryStore.Models.PaymentData
{
    public class Responsemodel
    {
        public bool status { get; set; }
        public string message { get; set; }
        public DataResponse data { get; set; }
    }

    public class DataResponse
    {
        public string authorization_url { get; set; }
        public string access_code { get; set; }
        public string reference { get; set; }
    }
}
