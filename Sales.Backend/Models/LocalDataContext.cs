

namespace Sales.Backend.Models
{
    using Sales.Domain.Models;
    //esto se hace para facilitar las migraciones de datos
    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<Sales.Common.Models.Product> Products { get; set; }
    }
}