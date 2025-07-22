using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clientes.WEB.Models.Entities
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        [DisplayName("Cedula")]
        [Column("DocumentoIdentidad", TypeName = "nvarchar(10)")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Documento { get; set; }

        [DisplayName("Fecha de Creacion")]
        [Column("FechaCreacion", TypeName = "DateTime")]
        public DateTime FechaCreacion { get; set; }

        [DisplayName("Nombre Completo")]
        [Column("NombreCliente", TypeName = "nvarchar(256)")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Nombre { get; set; }

        [DisplayName("Número de telefono")]
        [Column("NumeroTelefono'", TypeName = "nvarchar(10)")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Telefono { get; set; }

        [DisplayName("Correo electronico")]
        [Column("CorreoElectronico'", TypeName = "nvarchar(90)")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Correo { get; set; }

        [DisplayName("Dirección")]
        [Column("DireccionHogar'", TypeName = "nvarchar(90)")]
        [Required(ErrorMessage = "Este campo es obligatorio")]

        public string Direccion { get; set; }

        [DisplayName("Fecha de nacimiento")]
        [Column("FechaNacimiento'", TypeName = "Date")]
        public DateTime FechaNacimiento { get; set; }
        public int IdHistorialesCorporal { get; set; }

        public virtual  HistorialCorporal HistorialCorporal { get; set; }

        [DisplayName("Fecha de Actualizacion")]
        [Column("FechaActualizacion", TypeName = "DateTime")]
        public DateTime FechaActualizacion { get; set; }
    }
}
