using Domain.Entities;
using FluentNHibernate.Mapping;

namespace Domain.Mappings
{
    public sealed class EnderecoMap : ClassMap<Endereco>
    {
        public EnderecoMap()
        {
            Id(x => x.Id);
            Map(x => x.Complemento);
            Map(x => x.Logradouro);
            Map(x => x.Numero);
            Map(x => x.Bairro);
            References(x => x.Cidade);
            References(x => x.Estado);
            References(x => x.Pais);
        }
    }
}