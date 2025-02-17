using OrderProcessingApp.Models;

namespace OrderProcessingApp.Business
{
    public class ProcessOrder : IProcessOrder
    {
        private const decimal DISCOUNT = .10m;
        public ProcessResults ProcessOrderAsync(Order order)
        {
            var result = new ProcessResults();
            try
            {
                decimal discountAmount = 0;
                if (order.OrderTotal >= 100 && order.CustomerType == "Loyal")
                {
                    discountAmount = order.OrderTotal * DISCOUNT;
                }
                decimal finalAmount = order.OrderTotal - discountAmount;
                result.OrderTotal = order.OrderTotal;
                result.CustomerType = order.CustomerType;
                 result.Discount = discountAmount;
                result.FinalAmount = finalAmount;

                return result;
            }
            catch (Exception ex)
            {
                result.Errors.Add(ex);
                return result;
            }

        }
    }
}