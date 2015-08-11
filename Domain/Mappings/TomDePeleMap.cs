using Domain.Entities;
using FluentNHibernate.Mapping;

namespace Domain.Mappings
{
    public sealed class TomDePeleMap : ClassMap<TomDePele>
    {
        public TomDePeleMap()
        {
            Id(x => x.Id);
            Map(x => x.Descricao);
            Map(x => x.Numero);
        }
    }
}
