﻿using DenizKC.ToDo.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DenizKC.ToDo.Entities.Concrete
{
   public  class Aciliyet:ITablo
    {

        public int Id { get; set; }
        public string Tanim { get; set; }
        public List<Gorev> Gorevler { get; set; }
    }
}
