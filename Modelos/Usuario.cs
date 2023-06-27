using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app1_Migrations.Modelos
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(20)")]

        public string Name { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(20)")]
        
        public string Lastname { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(20)")]
        
        public string Direccion { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(40)")]
        
        public string Phone { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(10)")]
        
        public string Birthday { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(10)")]

        public Boolean Status { get; set; }

    }
}
