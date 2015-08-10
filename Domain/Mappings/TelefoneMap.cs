
using Domain.Entities;
using FluentNHibernate.Mapping;

namespace Domain.Mappings
{
    public sealed class TelefoneMap : ClassMap<Telefone>
    {
        public TelefoneMap()
        {
            Id(x => x.Id);
            Map(x => x.Numero);
            References(x => x.TipoTel);

        }
    }
}
