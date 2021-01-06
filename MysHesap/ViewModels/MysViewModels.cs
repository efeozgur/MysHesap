using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MysHesap.Models;

namespace MysHesap.ViewModels
{
    public class MysViewModels
    {
        public List<birinciAsama> BirinciAsama { get; set; }
        public List<ikinciAsama> ikinciAsama { get; set; }
        public List<ucuncuAsama> ucuncuAsama { get; set; }
        public List<kesintiAltTuruBirinciAsama> kesintiBirinciAsama { get; set; }
        public List<kesintiAltTuruIkinciAsama> kesintiIkinciAsama { get; set; }

    }
}