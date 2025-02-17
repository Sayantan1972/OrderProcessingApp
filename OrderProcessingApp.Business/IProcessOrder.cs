using OrderProcessingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingApp.Business
{
    public interface IProcessOrder
    {
        ProcessResults ProcessOrderAsync(Order order);
    }
}
