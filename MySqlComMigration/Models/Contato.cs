using System.ComponentModel.DataAnnotations;

namespace MySqlComMigration
{
    public class Contato
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}