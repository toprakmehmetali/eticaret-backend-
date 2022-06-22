using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete.Sms
{
    public class SmsOptions
    {
        public string Key { get; set; }
        public string Hash { get; set; }
        public string Iys { get; set; }
        public string IysList { get; set; }
        public string ApiUrl { get; set; }
        public string Sender { get; set; }

    }
}
