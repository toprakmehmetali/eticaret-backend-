using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete.Sms
{
    public class Message
    {
        public string Text { get; set; }
        public Receipents Receipents { get; set; }
    }
}
