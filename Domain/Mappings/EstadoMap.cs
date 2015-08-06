
using Domain.Entities;
using FluentNHibernate.Mapping;

namespace Domain.Mappings
{
   public sealed class EstadoMap : ClassMap<Estado>
    {
       public EstadoMap()
       {
           Id(x => x.Id);
           Map(x => x.Descricao);
           Map(x => x.Sigla);
       }
    }
}
