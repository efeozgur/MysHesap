namespace MysHesap.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ucuncuAsama")]
    public partial class ucuncuAsama
    {
        public int ID { get; set; }

        public double? HarcamaTuruNo { get; set; }

        [StringLength(255)]
        public string OdemeEmriTuru { get; set; }

        [StringLength(255)]
        public string OdemeDurumu { get; set; }

        [StringLength(255)]
        public string OdemeSureciTuru { get; set; }

        [StringLength(255)]
        public string ButceTuru { get; set; }

        public int Kimlik { get; set; }

        [StringLength(255)]
        public string Not { get; set; }
    }
}
