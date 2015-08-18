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
          Map(x => x.Email);
          Map(x => x.Data);
          Map(x => x.Horario);
          References(x => x.TipoPele).Cascade.SaveUpdate();
          References(x => x.TomDePele).Cascade.SaveUpdate();
          References(x => x.Anfitriao).ForeignKey("Id");
          HasMany(x => x.Contatos).Cascade.SaveUpdate();
          References(x => x.Endereco).Cascade.SaveUpdate();
          References(x => x.FormaContato).Cascade.SaveUpdate();

      }
    }
}
