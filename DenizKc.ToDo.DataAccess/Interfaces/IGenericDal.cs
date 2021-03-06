﻿using DenizKC.ToDo.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DenizKc.ToDo.DataAccess.Interfaces
{
    public interface IGenericDal<Tablo> where Tablo : class, ITablo, new()
    {
        void Kaydet(Tablo tablo);
        void Sil(Tablo tablo);
        void Guncelle(Tablo tablo);
        Tablo GetirIdIle(int id);
        List<Tablo> GetirHepsi();
    }
}
