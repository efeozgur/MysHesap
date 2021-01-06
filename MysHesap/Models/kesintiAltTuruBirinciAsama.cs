namespace MysHesap.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("kesintiAltTuruBirinciAsama")]
    public partial class kesintiAltTuruBirinciAsama
    {
        public int ID { get; set; }

        [StringLength(255)]
        public string EmaneteAlinmaDurumu { get; set; }

        [StringLength(255)]
        public string kesintiAltTuruAdi { get; set; }

        public double? KesintiTuruNo { get; set; }

        [StringLength(255)]
        public string AlacakKontrolDurumu { get; set; }

        [StringLength(255)]
        public string Durumu { get; set; }

        [StringLength(255)]
        public string ButceTuru { get; set; }

        [StringLength(255)]
        public string OzelButceHesapKodu { get; set; }

        [StringLength(255)]
        public string GenelButceHesapKodu { get; set; }

        [StringLength(255)]
        public string DigerHesapKodu { get; set; }

        [StringLength(255)]
        public string butceGelirHesapKodu { get; set; }

        [StringLength(255)]
        public string EklenmeTarihi { get; set; }

        [StringLength(255)]
        public string KamuIdaresiBir { get; set; }

        [StringLength(255)]
        public string KamuIdaresiIki { get; set; }

        public DateTime? PasiflestirmeTarihi { get; set; }

        public DateTime? DegisiklikTarihi { get; set; }
    }
}
