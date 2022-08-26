using ELibraryStore.Models;
using ELibraryStore.Models.PaymentData;

namespace ELibraryStore.Data.Services
{
    public interface IPaymentService
    {
        Task <DataResponse> InitializeTransaction(double Amount);
        Task<string> VerifyTransaction(string reference);
    }
}
