using Domain.Entities;
using FluentNHibernate.Mapping;

namespace Domain.Mappings
{
   public sealed class ClienteMap: ClassMap<Cliente>
    {
      public ClienteMap()
      {
          Id(x => x.Id);
          Map(x => x.Nome);
          Map(x => x.DataNascimento);
          HasMany(x => x.Telefones).Cascade.All();
          References(x => x.Endereco).Cascade.All();
       
      }
    }
}
