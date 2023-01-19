using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Presupuestos.Models
{
    public class TipoCuenta
    {
        public int id { get; set; }
        [Required(ErrorMessage ="El campo {0} es requerido!!!")]
        [StringLength(maximumLength:50,MinimumLength =5, ErrorMessage = "La longitud de {0} debe estar entre {2} y {1}")]
        public string nombre { get; set; }
        public int usuarioid { get; set;}
        public int orden { get; set; }
    }
}
