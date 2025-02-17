using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingApp.Models
{
    public class ProcessResults : Order
    {
        public ProcessResults() 
        {
            this.Errors = new List<Exception>();
        }
        public decimal Discount { get; set; }
        public decimal FinalAmount { get; set; }

        public List<Exception> Errors { get; set; }
    }
}
