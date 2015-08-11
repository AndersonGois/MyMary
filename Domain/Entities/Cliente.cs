using System;
using System.Collections.Generic;
using Domain.Entities.Interfaces;


namespace Domain.Entities
{
    public class Cliente : IBase
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual DateTime DataNascimento { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual IList<Telefone> Telefones { get; set; }
        public virtual void AdicionarTelefone(Telefone telefone)
        {
            if (Telefones == null)
                Telefones = new List<Telefone>();

            Telefones.Add(telefone);
        }
    }
}
