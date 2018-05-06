using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VictoriasWardrobe.Data.Entities;

namespace VictoriasWardrobe.Data.Contexts
{
    public class VictoriasWardrobeContext : DbContext
    {
        private const string ConnectionStringName = "Data Source=DESKTOP-US4FEKS;Initial Catalog=VictoriasWardrobe;Integrated Security=True";

        public VictoriasWardrobeContext() :base(ConnectionStringName)
        {
            Database.SetInitializer<VictoriasWardrobeContext>(null);
            Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Persons> Persons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<DivError>().ToTable("DIV_ERRORS");
            //modelBuilder.Entity<DivError>().Property(e => e.ErrorId).HasColumnName("div_ErrorID");
            //modelBuilder.Entity<DivError>().Property(e => e.ErrorCode).HasColumnName("div_ErrorCode");
            //modelBuilder.Entity<DivError>().Property(e => e.ErrorType).HasColumnName("div_ErrorType");
            //modelBuilder.Entity<DivError>().Property(e => e.LanguageCode).HasColumnName("div_Language");
            //modelBuilder.Entity<DivError>().Property(e => e.TransactionId).HasColumnName("div_TransactionID");
            //modelBuilder.Entity<DivError>().Property(e => e.ErrorDate).HasColumnName("div_ErrorDate");

            //modelBuilder.Entity<ZPlate>().ToTable("CommercialPlate");
            //modelBuilder.Entity<ZPlate>().Property(e => e.Ocaid).HasColumnName("OCAID");
            //modelBuilder.Entity<ZPlate>().Property(e => e.DivTransactionId).HasColumnName("DIVTransactionId");

            //modelBuilder.Entity<TranslatedError>().ToTable("IMM_ERRORS");
            //modelBuilder.Entity<TranslatedError>().Property(e => e.ErrorCode).HasColumnName("div_ErrorCode");
            //modelBuilder.Entity<TranslatedError>().Property(e => e.ErrorId).HasColumnName("div_ErrorID");
            //modelBuilder.Entity<TranslatedError>().Property(e => e.ErrorType).HasColumnName("div_ErrorType");
            //modelBuilder.Entity<TranslatedError>().Property(e => e.ErrorTypeFr).HasColumnName("div_ErrorTypeFR");
            //modelBuilder.Entity<TranslatedError>().Property(e => e.ErrorExplanationNl).HasColumnName("div_UitlegNL");
            //modelBuilder.Entity<TranslatedError>().Property(e => e.ErrorExplanationFr).HasColumnName("div_UitlegFR");
            //modelBuilder.Entity<TranslatedError>().Property(e => e.ErrorExplanationEn).HasColumnName("div_UitlegEN");

            //modelBuilder.Entity<ZPlateError>().ToTable("CommercialPlateError");

            
        }

    }
}
