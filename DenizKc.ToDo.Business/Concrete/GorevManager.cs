using DenizKc.ToDo.Business.Interfaces;
using DenizKc.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using DenizKc.ToDo.DataAccess.Interfaces;
using DenizKC.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DenizKc.ToDo.Business.Concrete
{
   public  class GorevManager:IGorevService
    {

        private readonly IGorevDal _gorevDal;
        public GorevManager(IGorevDal gorevDal)
        {
            _gorevDal = gorevDal;
        }
        public List<Gorev> GetirHepsi()
        {
            return _gorevDal.GetirHepsi();
        }

        public Gorev GetirIdIle(int id)
        {
            return _gorevDal.GetirIdIle(id);
        }

        public void Guncelle(Gorev tablo)
        {
            _gorevDal.Guncelle(tablo);
        }

        public void Kaydet(Gorev tablo)
        {
            _gorevDal.Kaydet(tablo);
        }

        public void Sil(Gorev tablo)
        {
            _gorevDal.Sil(tablo);
        }
    }
}
