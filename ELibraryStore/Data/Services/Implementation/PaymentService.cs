using ELibraryStore.Models;
using ELibraryStore.Models.PaymentData;
using Newtonsoft.Json;
using System.Text;  

namespace ELibraryStore.Data.Services.Implementation
{
    public class PaymentService : IPaymentService
    {
        private readonly HttpClient _client;
        private readonly IConfiguration _config;
        private readonly string secretkey;
        private readonly ApplicationDbContext _context;


        public PaymentService(HttpClient client, IConfiguration config, ApplicationDbContext context)
        {
            _client = client;
            _client.BaseAddress = new Uri("https://api.paystack.co/");
            _client.DefaultRequestHeaders.Clear();
            _config = config;
            secretkey = _config["Paystack:Paystack_Test"];
            _client.DefaultRequestHeaders.Add("Authorization", secretkey);
            _context = context;
        }

        public async Task<DataResponse> InitializeTransaction(double Amount)
        {
            Conversion conversion = new Conversion();
            InputData inputData = new InputData()
            {
                //amount = conversion.CurrencyConversion((Amount*100)).Replace('N', ' ').ToString(),//Paystack Payment is in Kobo
                amount = (Amount * 680 * 100).ToString(),
                email = "emmanuelpraise42@gmail.com",
                callback_url = "https://localhost:7141/order/VerifyPaymentOrder"
            };
            var stringContent = new StringContent(JsonConvert.SerializeObject(inputData), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("transaction/initialize", stringContent);
            
            if (response.IsSuccessStatusCode == true)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                Responsemodel newresponse = JsonConvert.DeserializeObject<Responsemodel>(jsonResponse);
                DataResponse setData = newresponse.data;

                Transaction transaction = new Transaction()
                {
                    Amount = inputData.amount,
                    Email = inputData.email,
                    TransactionReference = inputData.reference
                };

                await _context.Transactions.AddAsync(transaction);
                await _context.SaveChangesAsync();

                return setData;

            }
            return new DataResponse();
        }

        public async Task<string> VerifyTransaction(string reference)
        {
            string verifyUri = "transaction/verify/" + reference;
            var response = await _client.GetAsync(verifyUri);
            string latestResponse = await response.Content.ReadAsStringAsync();
            VerifyResponse verify = JsonConvert.DeserializeObject<VerifyResponse>(latestResponse);
            
            if (verify.data.status == "success")
            {
                var transactData = _context.Transactions.Where(n => n.TransactionReference == reference).FirstOrDefault();
                
                if(transactData != null)
                {
                    transactData.Status = true;
                    transactData.Channel = verify.data.channel;

                    _context.Transactions.Update(transactData);
                    await _context.SaveChangesAsync();

                    return "true";
                }
                return verify.data.gateway_response;
            }
            return verify.message;
        }
    }
}
