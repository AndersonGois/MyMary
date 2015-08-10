using Domain.Entities.Interfaces;

namespace Domain.Entities
{
    public class Telefone : IBase
    {
        public virtual int Id { get; set; }
        public virtual long Numero { get; set; }
        public virtual TipoTel TipoTel { get; set; }
    }
}
