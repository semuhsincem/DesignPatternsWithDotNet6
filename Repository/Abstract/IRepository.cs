﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Abstract
{
    public  interface IRepository<T> where T:class, IEntity
    {
        List<T> GetAll();
        T Get();
    }
}
