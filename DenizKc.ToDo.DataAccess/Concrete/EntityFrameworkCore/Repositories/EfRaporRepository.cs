using DenizKc.ToDo.DataAccess.Interfaces;
using DenizKC.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DenizKc.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
   public  class EfRaporRepository : EfGenericRepositories<Rapor>, IRaporDal
    {
    }
}
