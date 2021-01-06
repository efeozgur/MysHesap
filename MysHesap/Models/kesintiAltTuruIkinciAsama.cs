namespace MysHesap.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("kesintiAltTuruIkinciAsama")]
    public partial class kesintiAltTuruIkinciAsama
    {
        public int ID { get; set; }

        [StringLength(255)]
        public string kesintiTuruAdi { get; set; }

        [StringLength(255)]
        public string Durumu { get; set; }

        [StringLength(255)]
        public string ButceTuru { get; set; }
    }
}
