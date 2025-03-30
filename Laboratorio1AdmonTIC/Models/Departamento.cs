using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Laboratorio1AdmonTIC.Models
{
    public class Departamento
    {
        // agregar la pk
        [Key]
        public Guid DepartamentoId { get; set; }

        [DisplayName ("Nombre departamento")]
        public string? Nombre { get; set; }

        [DisplayName("Codigo departamento")]
        public int Codigo { get; set; }

        [ScaffoldColumn (false)]
        public bool inactivo { get; set; }
    }
}
