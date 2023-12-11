using CDBCalcuclatio.Application.Const;
using CDBCalculation.Application.Abastraction;
using CDBCalculation.Application.Util;
using CDBCalculation.Domain;

namespace CDBCalculation.Application.Services
{
    public class CDBCalculationService : ICDBCalculationService
    {
        public async Task<CDBResponse> CalculateCDBByPeriod(CDBRequest request)
        {
            var months = Enumerable.Range(0, request.period).ToList();
            var initialMonetaryValue = request.monetaryValue;
            double cdbCalculate = request.monetaryValue;
            double cdiMonth = CDBSettings.cdi;
            double tbMonth = CDBSettings.tb;

            months.ForEach(month =>
            {
                cdbCalculate = Math.Round(CalculateCompoundRate(cdbCalculate, cdiMonth, tbMonth),2);
            });

            var netValueIR = Math.Round((cdbCalculate - initialMonetaryValue) * Utility.GetIRAliquot(request.period)/100,2);
            return new CDBResponse
            {
                grossValue = cdbCalculate,
                netValue = cdbCalculate - netValueIR
            };
        }
        private double CalculateCompoundRate(double monetaryValue, double cdi, double tb) 
        {
            return monetaryValue * (1 + (cdi * tb));
        }
       
    }
}
