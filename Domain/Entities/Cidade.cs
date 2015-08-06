using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Entities.Interfaces;

namespace Domain.Entities
{
    public class Cidade : IBase
    {
        public virtual int Id { get; set; }
        public virtual string Descricao { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
