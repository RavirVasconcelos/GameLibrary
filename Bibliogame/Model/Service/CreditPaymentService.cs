namespace Bibliogame.Model.Service
{
    class CreditPaymentService : IPayment
    {
        public double TaxPayment(double amount)
        {
            return amount * 1.053;
        }
    }
}
