using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("Id")]
        [DisplayName("#")]
        public int Id { get; set; }

        [Column("NomeUsuario")]
        [DisplayName("Nome do usuário")]
        public string? NomeUsuario { get; set; }
    }
}
