using Domain.Entities;
using FluentNHibernate.Mapping;

namespace Domain.Mappings
{
   public sealed class CidadeMap : ClassMap<Cidade>  
    {
      public CidadeMap()
      {
          Id(x => x.Id);
          Map(x => x.Descricao);
          References(x => x.Estado);
      }
    }
}
