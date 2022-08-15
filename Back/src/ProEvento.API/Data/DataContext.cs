using Microsoft.EntityFrameworkCore;
using ProEvento.API.Models;

namespace ProEvento.API.DataEvento{

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
      public DbSet<Evento>Eventos{ get; set; }  
    }
}