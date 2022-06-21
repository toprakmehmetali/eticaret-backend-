using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Dtos
{
    public class BasketForUserDto:IDto
    {
        public int BasketId { get; set; }
        public string ProductName { get; set;}
        public int Piece { get; set; }
        public int Price { get; set; }
    }
}
