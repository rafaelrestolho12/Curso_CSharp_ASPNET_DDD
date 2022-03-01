using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("Id")]
        [Display(Description = "Código")]
        public int Id { get; set; }

        [Column("NomeUsuario")]
        [Display(Description = "Nome do usuário")]
        public string? NomeUsuario { get; set; }
    }
}
