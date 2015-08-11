
using Domain.Entities.Interfaces;

namespace Domain.Entities
{
   public class Endereco : IBase
    {
        public virtual int Id { get; set; }
        public virtual Pais Pais { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Cidade Cidade { get; set; }
        public virtual string Bairro { get; set; }
        public virtual int? Cep { get; set; }
        public virtual string Logradouro { get; set; }
        public virtual int? Numero { get; set; }
        public virtual string Complemento { get; set; }
      //dd
    }
}
