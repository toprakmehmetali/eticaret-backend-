﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBasketService
    {
        public IDataResult<List<Basket>> GetBaskets(int ProductId);
    }
}