namespace Bibliogame.Model.Service
{
    class DebitPaymentService : IPayment
    {
        public double TaxPayment(double amount)
        {
            return amount * 1.027;
        }
    }
}
