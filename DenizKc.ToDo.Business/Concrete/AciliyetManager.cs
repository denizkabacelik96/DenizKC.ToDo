using DenizKc.ToDo.Business.Interfaces;
using DenizKc.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using DenizKc.ToDo.DataAccess.Interfaces;
using DenizKC.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DenizKc.ToDo.Business.Concrete
{

  
    public class AciliyetManager : IAciliyetService
    {

        private readonly IAciliyetDal _aciliyetDal;
        public AciliyetManager(IAciliyetDal aciliyetDal)
        {
            _aciliyetDal = aciliyetDal;
        }
        public List<Aciliyet> GetirHepsi()
        {
            return _aciliyetDal.GetirHepsi();
        }

        public Aciliyet GetirIdIle(int id)
        {
            return _aciliyetDal.GetirIdIle(id);
        }

        public void Guncelle(Aciliyet tablo)
        {
            _aciliyetDal.Guncelle(tablo);
        }

        public void Kaydet(Aciliyet tablo)
        {
            _aciliyetDal.Kaydet(tablo);
        }

        public void Sil(Aciliyet tablo)
        {
            _aciliyetDal.Sil(tablo);
        }
    }
}
