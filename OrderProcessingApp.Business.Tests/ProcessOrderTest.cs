using OrderProcessingApp.Models;
using Xunit;

namespace OrderProcessingApp.Business.Tests
{
    public class ProcessOrderUNitTest
    {
        [Fact]
        public void WhenAmountIsGreaternThan100_And_CustomerTypeISLoyal_DiscountGiven()
        {
            //Arrange Data
            var order = new Order() { CustomerType = "Loyal", OrderTotal = 120 };
            IProcessOrder processOrder = new ProcessOrder();

            //ACT
            var result = processOrder.ProcessCustomerOrder(order);

            //Verify or Assert
            Assert.Equal(12, result.Discount);
            Assert.Equal(108, result.FinalAmount);
        }

        [Fact]
        public void WhenAmountIsGreaternThan100_And_CustomerTypeISNew_DiscountNOTGiven()
        {
            //Arrange Data
            var order = new Order() { CustomerType = "New", OrderTotal = 120 };
            IProcessOrder processOrder = new ProcessOrder();

            //ACT
            var result = processOrder.ProcessCustomerOrder(order);

            //Verify or Assert
            Assert.Equal(0, result.Discount);
            Assert.Equal(120, result.FinalAmount);
        }

        [Fact]
        public void WhenAmountIs100_And_CustomerTypeISLoyal_DiscountGiven()
        {
            //Arrange Data
            var order = new Order() { CustomerType = "Loyal", OrderTotal = 100 };
            IProcessOrder processOrder = new ProcessOrder();

            //ACT
            var result = processOrder.ProcessCustomerOrder(order);

            //Verify or Assert
            Assert.Equal(10, result.Discount);
            Assert.Equal(90, result.FinalAmount);
        }

        [Fact]
        public void WhenAmountIs100_And_CustomerTypeISNewl_DiscountNOTGiven()
        {
            //Arrange Data
            var order = new Order() { CustomerType = "New", OrderTotal = 100 };
            IProcessOrder processOrder = new ProcessOrder();

            //ACT
            var result = processOrder.ProcessCustomerOrder(order);

            //Verify or Assert
            Assert.Equal(0, result.Discount);
            Assert.Equal(100, result.FinalAmount);
        }
    }
}