using System.Collections.Generic;
using Domain.Entities.Interfaces;

namespace Domain.Entities
{
    public class Pais : IBase
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual IList<Estado> Estados { get; set; }
        
        public virtual void AdicinarEstado(Estado estado)
        {
            if (Estados == null)
                Estados = new List<Estado>();
            Estados.Add(estado);
        }
    }
}
