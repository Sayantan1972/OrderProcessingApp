using Microsoft.AspNetCore.Mvc;
using OrderProcessingApp.Business;
using OrderProcessingApp.Models;

namespace OrderProcessingApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly IProcessOrder _processOrder;
        public OrderController(IProcessOrder processOrder) 
        {
            _processOrder= processOrder;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProcessOrder(Order order)
        {

            var results =  _processOrder.ProcessCustomerOrder(order);
            if (results.Errors.Count > 0)
            {
                return View("Error");
            }
            else
            {
                ViewBag.OrderAmount = results.OrderTotal;
                ViewBag.CustomerType = results.CustomerType;
                ViewBag.Discount = results.Discount;
                ViewBag.FinalAmount = results.FinalAmount;
            }


            return View("Result");
        }
    }
}
