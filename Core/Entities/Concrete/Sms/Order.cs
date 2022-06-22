using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete.Sms
{
    public class Order
    {
        public string Sender { get; set; }
        public DateTime[] SendDateTime { get; set; }
        public string Iys { get; set; }
        public string IysList { get; set; }
        public Message Message { get; set; }

    }
}
