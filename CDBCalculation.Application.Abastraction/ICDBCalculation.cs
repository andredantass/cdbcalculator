using CDBCalculation.Domain;

namespace CDBCalculation.Application.Abastraction
{
    public interface ICDBCalculationService
    {
        Task<CDBResponse> CalculateCDBByPeriod(CDBRequest request);
    }
}