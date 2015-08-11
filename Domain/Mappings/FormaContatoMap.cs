
using Domain.Entities;
using FluentNHibernate.Mapping;

namespace Domain.Mappings
{
   public sealed class FormaContatoMap : ClassMap<FormaContato>
   {
       public  FormaContatoMap()
       {
           Id(x => x.Id);
           Map(x => x.Descricao);
       }
    }
}
