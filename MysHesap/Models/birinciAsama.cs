namespace MysHesap.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("birinciAsama")]
    public partial class birinciAsama
    {
        public int ID { get; set; }

        [StringLength(255)]
        public string odemeKalemTuru { get; set; }

        [StringLength(255)]
        public string Tertipli { get; set; }

        [StringLength(255)]
        public string hesapKodu { get; set; }

        [StringLength(255)]
        public string merkeziButceKaynakliHesapKodu { get; set; }

        [StringLength(255)]
        public string varlikmi { get; set; }

        [StringLength(255)]
        public string harcamaAltTuru { get; set; }
    }
}
