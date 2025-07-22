using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clientes.WEB.Models.Entities
{
    public class HistorialCorporal
    {
        [Key]
        public int IdHistorialesCorporal { get; set; }

        [DisplayName("Fecha de creación")]
        [Column("FechaCreación'", TypeName = "DateTime")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public DateTime FechaCreacion { get; set; }

        [DisplayName("Doctor")]
        [Column("NombreDoctor", TypeName = "nvarchar(256)")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string NombreDoctor { get; set; }

        [DisplayName("Tratamiento")]
        [Column("Tratamiento", TypeName = "nvarchar(700)")]
        public int Tratamiento { get; set; }
    


    }
}
