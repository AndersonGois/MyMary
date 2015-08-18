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
        public virtual string Email { get; set; }
        public virtual DateTime? DataNascimento { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual string Telefone { get; set; }
        public virtual string Celular { get; set; }
        public virtual TipoPele TipoPele { get; set; }
        public virtual TomDePele TomDePele { get; set; }
        public virtual FormaContato FormaContato { get; set; }
        public virtual IList<Cliente> Contatos { get; set; }
        public virtual void AdicionarTelefone(Cliente cliente)
        {
            if (Contatos == null)
                Contatos = new List<Cliente>();

            Contatos.Add(cliente);
        }
        public virtual char Horario { get; set; }
        public virtual Cliente Anfitriao { get; set; }

        
    }
}
