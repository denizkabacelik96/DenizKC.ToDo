using DenizKc.ToDo.Business.Interfaces;
using DenizKc.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using DenizKC.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DenizKc.ToDo.Business.Concrete
{
    public class KullaniciManager : IKullaniciService
    {

        private readonly EfKullaniciRepositories efKullaniciRepositories;
        public KullaniciManager()
        {
            efKullaniciRepositories = new EfKullaniciRepositories();
        }
        public List<Kullanici> GetirHepsi()
        {
            return efKullaniciRepositories.GetirHepsi();
        }

        public Kullanici GetirIdIle(int id)
        {
            return efKullaniciRepositories.GetirIdIle(id);
        }

        public void Guncelle(Kullanici tablo)
        {
            efKullaniciRepositories.Guncelle(tablo);
        }

        public void Kaydet(Kullanici tablo)
        {
            efKullaniciRepositories.Kaydet(tablo);
        }

        public void Sil(Kullanici tablo)
        {
            efKullaniciRepositories.Sil(tablo);
        }
    }
}
