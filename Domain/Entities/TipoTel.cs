using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Entities.Interfaces;

namespace Domain.Entities
{

    public class TipoTel : IBase
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
    }
}
