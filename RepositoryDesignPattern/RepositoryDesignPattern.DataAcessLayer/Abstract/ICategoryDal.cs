﻿using RepositoryDesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.DataAcessLayer.Abstract
{
    public interface ICategoryDal:IGenericDal<Category>
    {
    }
}
