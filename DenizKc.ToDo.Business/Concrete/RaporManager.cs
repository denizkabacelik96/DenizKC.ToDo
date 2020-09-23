using DenizKc.ToDo.Business.Interfaces;
using DenizKc.ToDo.DataAccess.Interfaces;
using DenizKC.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DenizKc.ToDo.Business.Concrete
{
    public class RaporManager : IRaporService
    {
        private readonly IRaporDal _rapordal;
        public RaporManager(IRaporDal rapordal)
        {
            _rapordal = rapordal;
        }
        public List<Rapor> GetirHepsi()
        {
            return _rapordal.GetirHepsi();
        }

        public Rapor GetirIdIle(int id)
        {
            return _rapordal.GetirIdIle(id);
        }

        public void Guncelle(Rapor tablo)
        {
            _rapordal.Guncelle(tablo);
        }

        public void Kaydet(Rapor tablo)
        {
            _rapordal.Kaydet(tablo);
        }

        public void Sil(Rapor tablo)
        {
            _rapordal.Sil(tablo);
        }
    }
}

