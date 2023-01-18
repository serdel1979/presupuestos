namespace Presupuestos.Models
{
    public class TipoCuenta
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int usuarioid { get; set;}
        public int orden { get; set; }
    }
}
