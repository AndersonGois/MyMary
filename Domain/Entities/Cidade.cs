using Domain.Entities.Interfaces;

namespace Domain.Entities
{
    public class Cidade : Tipo
    {
        public virtual Estado Estado { get; set; }
    }
}
