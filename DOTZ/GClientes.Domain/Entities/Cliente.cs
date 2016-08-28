using GClientes.Domain.ValueObject;

namespace GClientes.Domain.Entities
{
    public class Cliente : EntityBase
    {

        public int ClienteId { get; set; }

        public const int NomeMaxLength = 50;
        public string Nome { get; set; }

        public const int SobrenbomeMaxLength = 50;
        public string Sobrenome { get; set; }
        
        public Email Email { get; set; }
        
        //public Endereco Endereco { get; private set; }

        //public bool Ativo { get; set; }
        //public virtual IEnumerable<Produto> Produtos { get; set; }

        //public bool ClienteEspecial(Cliente cliente)
        //{
        //    return cliente.Ativo && DateTime.Now.Year - DtInclusao.Year >= 5;
        //}

    }
}
