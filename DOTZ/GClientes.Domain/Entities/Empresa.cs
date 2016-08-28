namespace GClientes.Domain.Entities
{
    public class Empresa: EntityBase
    {

        public int EmpresaId { get; set; }

        public const int RazaoMaxLength = 50;
        public string Razao { get; set; }

    }
}
