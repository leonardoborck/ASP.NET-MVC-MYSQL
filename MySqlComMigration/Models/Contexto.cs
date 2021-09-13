using System.Data.Entity;
namespace MySqlComMigration
{
    public class Contexto : DbContext
    {
        public Contexto()
                     : base("Contexto")
        {

        }

        public DbSet<Contato> Contato { get; set; }

    }
}