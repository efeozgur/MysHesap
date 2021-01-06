using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MysHesap.Models;
using MysHesap.ViewModels;

namespace MysHesap.Controllers
{
    public class HomeController : Controller
    {
        MysModel db = new MysModel();

        public ActionResult Index()
        {
            MysViewModels mvm = new MysViewModels
            {
                BirinciAsama = db.birinciAsamas.ToList(),
                ikinciAsama = db.ikinciAsamas.ToList(),
                ucuncuAsama = db.ucuncuAsamas.ToList(),
                kesintiBirinciAsama = db.kesintiAltTuruBirinciAsamas.ToList(),
                kesintiIkinciAsama = db.kesintiAltTuruIkinciAsamas.ToList()
            };
            
            return View(mvm);
        }


        public ActionResult birinci()
        {
            
            return View(db.birinciAsamas.ToList());
        }


        public ActionResult Ikinci()
        {
            return View(db.ikinciAsamas.ToList());
        }


        public ActionResult Ucuncu()
        {
            return View(db.ucuncuAsamas.ToList());
        }


        public ActionResult kesbir()
        {
            return View(db.kesintiAltTuruBirinciAsamas.ToList());
        }


        public ActionResult kes2()
        {
            return View(db.kesintiAltTuruIkinciAsamas.ToList());
        }
    }
}