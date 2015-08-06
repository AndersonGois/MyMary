using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Entities.Interfaces;

namespace Domain.Entities
{
    public class Telefone : IBase
    {
        public virtual int Id { get; set; }
        public virtual string Numero { get; set; }
        public virtual TipoTel Nome { get; set; }
    }
}
