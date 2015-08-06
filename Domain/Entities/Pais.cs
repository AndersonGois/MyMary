using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Interfaces;

namespace Domain.Entities
{
    public  class Pais : IBase
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual IList<Estado> Estados { get; set; }

        public Pais()
        {
            this.Estados = new List<Estado>();
        }

        public virtual void AdicinarEstado(Estado estado)
        {
            this.Estados.Add(estado);
        }
    }
}
