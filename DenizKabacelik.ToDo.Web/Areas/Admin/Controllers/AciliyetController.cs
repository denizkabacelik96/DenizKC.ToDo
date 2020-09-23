using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DenizKabacelik.ToDo.Web.Areas.Admin.Models;
using DenizKc.ToDo.Business.Interfaces;
using DenizKC.ToDo.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace DenizKabacelik.ToDo.Web.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class AciliyetController : Controller
    {

        private readonly IAciliyetService _aciliyetService;

        public AciliyetController(IAciliyetService aciliyetService)
        {
            _aciliyetService = aciliyetService;
        }
        public IActionResult Index()
        {


            List<Aciliyet> aciliyetler = _aciliyetService.GetirHepsi();
            List<AciliyetListViewModel> model = new List<AciliyetListViewModel>();
            foreach (var item in aciliyetler)
            {

                AciliyetListViewModel aciliyetmodel = new AciliyetListViewModel();
                aciliyetmodel.Id = item.Id;
                aciliyetmodel.Tanim = item.Tanim;
                model.Add(aciliyetmodel);

            }
            return View(model);
        }


        public IActionResult EkleAciliyet()
        {


            return View(new AciliyetAddViewModel());
        }
        [HttpPost]
        public IActionResult EkleAciliyet(AciliyetAddViewModel model)
        {

            if (ModelState.IsValid)
            {

                _aciliyetService.Kaydet(new Aciliyet()
                {

                    Tanim = model.Tanim

                });
                return RedirectToAction("Index");
            }
            return View(new AciliyetAddViewModel());
        }
    }
}
