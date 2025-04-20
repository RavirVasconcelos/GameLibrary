namespace Bibliogame.Model.Service
{
    class PixPaymentService : IPayment
    {
        public double TaxPayment(double amount)
        {
            return amount * 1.01;
        }
    }
}
