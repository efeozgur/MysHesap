namespace MysHesap.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ikinciAsama")]
    public partial class ikinciAsama
    {
        public int ID { get; set; }

        [StringLength(255)]
        public string Durumu { get; set; }

        public double? harcamaAltTuruNo { get; set; }

        [StringLength(255)]
        public string OdemeEmriAlturuNo { get; set; }

        public double? harcamaTuruID { get; set; }

        [StringLength(255)]
        public string ButceTuru { get; set; }

        public double? varsayilanOzelButceHesapKodu { get; set; }

        public double? VarsayilanGenelButceHesapKodu { get; set; }
    }
}
