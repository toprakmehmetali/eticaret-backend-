using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete.Sms
{
    public class SmsRequest
    {
        public Request Request { get; set; }
        public Order Order { get; set; }
    }
}
