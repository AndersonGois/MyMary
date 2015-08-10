
using Domain.Entities;
using FluentNHibernate.Mapping;

namespace Domain.Mappings
{
   public sealed class TipoTelMap: ClassMap<TipoTel>
    {
       public TipoTelMap()
       {
           Id(x => x.Id);
           Map(x => x.Nome);
           
       }
    }
}
