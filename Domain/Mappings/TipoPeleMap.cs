using Domain.Entities;
using FluentNHibernate.Mapping;

namespace Domain.Mappings
{
   public sealed class TipoPeleMap : ClassMap<TipoPele>
    {
      public TipoPeleMap()
      {
          Id(x => x.Id);
          Map(x => x.Descricao);

      }
    }
}
