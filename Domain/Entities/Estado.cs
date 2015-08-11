using System.Collections.Generic;

using Domain.Entities.Interfaces;

namespace Domain.Entities
{
    public class Estado : Tipo
    {
        public virtual string Sigla { get; set; }
        public virtual Pais Pais { get; set; }
        public virtual IList<Cidade> Cidades { get; set; }

        public virtual void Adicionar(Cidade cidade)
        {
            if (Cidades == null)
            {
                Cidades = new List<Cidade>();
            }
            Cidades.Add(cidade);

        }
    }
}
