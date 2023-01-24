using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Presupuestos.Models
{
    public class TipoCuenta
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El campo {0} es requerido!!!")]
        [StringLength(maximumLength:50,MinimumLength =5, ErrorMessage = "La longitud de {0} debe estar entre {2} y {1}")]
        public string Nombre { get; set; }
        public int UsuarioId { get; set; }
        public int Orden { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido!!!")]
        [EmailAddress(ErrorMessage = "El campo {0} debe ser un email válido!!!")]
        public string Email { get; set; }
        [Url(ErrorMessage = "El campo {0} debe ser una url válida")]
        public string URL { get; set; }
        [CreditCard(ErrorMessage = "El campo {0} debe ser una número tarjeta de crédito válida")]
        public string TarjetaDeCredito { get; set; }

    }
}
