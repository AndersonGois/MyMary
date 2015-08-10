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
          HasMany(x => x.Telefone);
          References(x => x.Endereco);
      }
    }
}
