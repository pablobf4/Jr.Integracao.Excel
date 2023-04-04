
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jr.Integracao.Excel.Model.Base
{
    public class Usuario : BaseEntity
    {
        [Column("name")]
        [Required]
        [StringLength(150)]
        public string Name { get; set; }


        [Column("endereco")]
        [StringLength(500)]
        public string Endereco { get; set; }


        [Column("email")]
        [StringLength(100)]
        public string Email { get; set; }



    }
}
