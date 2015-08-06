using System;
using System.Collections.Generic;
using Domain.Entities.Interfaces;


namespace Domain.Entities
{
    public class Cliente : IBase
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual DateTime Data { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual List<Telefone> Telefone { get; set; }
    }
}
