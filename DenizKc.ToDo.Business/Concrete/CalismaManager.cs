using DenizKc.ToDo.Business.Interfaces;
using DenizKc.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using DenizKc.ToDo.DataAccess.Interfaces;
using DenizKC.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DenizKc.ToDo.Business.Concrete
{
   public  class CalismaManager:ICalismaService
    {

        private readonly EFCalismaRepositories efCalismaRepositories;
        public CalismaManager()
        {
            efCalismaRepositories = new EFCalismaRepositories();
        }
        public List<Calisma> GetirHepsi()
        {
            return efCalismaRepositories.GetirHepsi();
        }

        public Calisma GetirIdIle(int id)
        {
            return efCalismaRepositories.GetirIdIle(id);
        }

        public void Guncelle(Calisma tablo)
        {
            efCalismaRepositories.Guncelle(tablo);
        }

        public void Kaydet(Calisma tablo)
        {
            efCalismaRepositories.Kaydet(tablo);
        }

        public void Sil(Calisma tablo)
        {
            efCalismaRepositories.Sil(tablo);
        }
    }
}
