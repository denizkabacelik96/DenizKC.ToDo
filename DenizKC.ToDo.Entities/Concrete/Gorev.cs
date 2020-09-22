﻿using DenizKC.ToDo.Entities.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DenizKC.ToDo.Entities.Concrete
{
    public class Gorev : ITablo
    {


        public int Id { get; set; }


        public string Ad { get; set; }

        public string Aciklama { get; set; }
        public bool Durum { get; set; }
        public DateTime OlusturulmaTarih { get; set; }

        public AppUser AppUser { get; set; }
        public int? AppUserId { get; set; }
    }
}