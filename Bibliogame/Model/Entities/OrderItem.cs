using Bibliogame.Model.Service;
using Bibliogame.Model.Service.Enums;

namespace Bibliogame.Model.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        public TypePayment TypePayment { get; set; }
        public IPayment PaymentService { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product, TypePayment typePayment)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
            TypePayment = typePayment;

            PaymentService = typePayment switch
            {
                TypePayment.Credit => new CreditPaymentService(),
                TypePayment.Debit => new DebitPaymentService(),
                TypePayment.Pix => new PixPaymentService(),
                _ => throw new ArgumentOutOfRangeException(nameof(typePayment), typePayment, null)
            };
        }

        public double TotalPrice()
        {
            double totalPrice = Price * Quantity;
            return PaymentService.TaxPayment(totalPrice);
        }

        public override string ToString()
        {
            return
                 "Product Name: " + Product.Name +
                 ", Product Price: " + Price.ToString("F2") +
                 ", Product Quantity: " + Quantity +
                 ", Product Category: " + Product.Category +
                 ", Product Type Payment: " + TypePayment +
                 ", Product Total Price: " + TotalPrice().ToString("F2");

        }
    }
}
