using DenizKc.ToDo.DataAccess.Concrete.EntityFrameworkCore.Context;
using DenizKc.ToDo.DataAccess.Interfaces;
using DenizKC.ToDo.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DenizKc.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EFGorevRepositories : EfGenericRepositories<Gorev>, IGorevDal
    {
       

    }
}