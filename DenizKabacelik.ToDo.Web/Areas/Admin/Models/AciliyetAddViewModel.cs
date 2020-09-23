using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DenizKabacelik.ToDo.Web.Areas.Admin.Models
{
    public class AciliyetAddViewModel
    {
        [Display(Name="Tanım")]
        [Required(ErrorMessage="Aciliyet tanım alanı boş  geçilemez")]
        public string Tanim { get; set; }
    }
}
