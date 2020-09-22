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

        private readonly EFGorevRepositories efCalismaRepositories;
        public GorevManager()
        {
            efCalismaRepositories = new EFGorevRepositories();
        }
        public List<Gorev> GetirHepsi()
        {
            return efCalismaRepositories.GetirHepsi();
        }

        public Gorev GetirIdIle(int id)
        {
            return efCalismaRepositories.GetirIdIle(id);
        }

        public void Guncelle(Gorev tablo)
        {
            efCalismaRepositories.Guncelle(tablo);
        }

        public void Kaydet(Gorev tablo)
        {
            efCalismaRepositories.Kaydet(tablo);
        }

        public void Sil(Gorev tablo)
        {
            efCalismaRepositories.Sil(tablo);
        }
    }
}
