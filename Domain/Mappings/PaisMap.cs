
using Domain.Entities;
using FluentNHibernate.Mapping;

namespace Domain.Mappings
{
    public sealed class PaisMap: ClassMap<Pais>
    {
       public PaisMap()
       {
           Id(x => x.Id);
           Map(x => x.Nome);
           HasMany(x => x.Estados).Cascade.All();
       }
    }
}
