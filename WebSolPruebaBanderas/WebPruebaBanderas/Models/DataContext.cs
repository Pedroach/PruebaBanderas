namespace WebPruebaBanderas.Models
{
    using System.Data.Entity;
    public class DataContext :DbContext
    {
        public DataContext() : base("DefaultConnection")
        { 
        
        }

        public System.Data.Entity.DbSet<WebPruebaBanderas.Models.Country> Countries { get; set; }

        public System.Data.Entity.DbSet<WebPruebaBanderas.Models.Translations> Translations { get; set; }

        public System.Data.Entity.DbSet<WebPruebaBanderas.Models.Language> Languages { get; set; }

        public System.Data.Entity.DbSet<WebPruebaBanderas.Models.Currency> Currencies { get; set; }

        public System.Data.Entity.DbSet<WebPruebaBanderas.Models.RegionalBloc> RegionalBlocs { get; set; }
    }
}