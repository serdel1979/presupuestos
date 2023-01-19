using System.ComponentModel.DataAnnotations;

namespace Presupuestos.Models
{
    public class TipoCuenta
    {
        public int id { get; set; }
        [Required(ErrorMessage ="El campo {0} es requerido!!!")]
        public string nombre { get; set; }
        public int usuarioid { get; set;}
        public int orden { get; set; }
    }
}
