using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MysHesap.Models
{
    public partial class MysModel : DbContext
    {
        public MysModel()
            : base("name=MysModels")
        {
        }

        public virtual DbSet<birinciAsama> birinciAsamas { get; set; }
        public virtual DbSet<ikinciAsama> ikinciAsamas { get; set; }
        public virtual DbSet<kesintiAltTuruBirinciAsama> kesintiAltTuruBirinciAsamas { get; set; }
        public virtual DbSet<kesintiAltTuruIkinciAsama> kesintiAltTuruIkinciAsamas { get; set; }
        public virtual DbSet<ucuncuAsama> ucuncuAsamas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
