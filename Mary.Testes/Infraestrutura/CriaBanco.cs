

using Domain.Entities;
using Domain.Repository;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;

namespace Mary.Testes.Infraestrutura
{
    [TestFixture]
    public class CriaBanco
    {
        [Test]
       // [Ignore]
        public void a__Criar_Banco_De_Dados_Por_Modelo()
        {
            Fluently.Configure().Database(MsSqlConfiguration.MsSql2005.ConnectionString(c => c
           .FromAppSetting("Conexao")
            )).Mappings(m => m.FluentMappings.AddFromAssemblyOf<Estado>()).Mappings(m => m.MergeMappings())
            .ExposeConfiguration(BuildSchema).BuildSessionFactory();
        }

        [Test]
        public void InsertEstados()
        {
            var rep = new EstadosRepository();
            var estado = new Estado { Descricao = "Bahia", Sigla = "BA" };
            rep.Salvar(estado);
            rep.Salvar(estado);
            estado = new Estado { Sigla = "AC", Descricao = "Acre" };
            rep.Salvar(estado);
            estado = new Estado { Sigla = "AL", Descricao = "Alagoas" };
            rep.Salvar(estado);
            estado = new Estado { Sigla = "AP", Descricao = "Amapá" };
            rep.Salvar(estado);
            estado = new Estado { Sigla = "AM", Descricao = "Amazonas" };
            rep.Salvar(estado);
            estado = new Estado { Sigla = "BA", Descricao = "Bahia" };
            rep.Salvar(estado);
            estado = new Estado { Sigla = "CE", Descricao = "Ceará" };
            rep.Salvar(estado);
            estado = new Estado { Sigla = "DF", Descricao = "Distrito Federal" };
            rep.Salvar(estado);
            estado = new Estado { Sigla = "ES", Descricao = "Espírito Santo" };
            rep.Salvar(estado);
            estado = new Estado { Sigla = "GO", Descricao = "Goiás" };
            rep.Salvar(estado);
            estado = new Estado { Sigla = "MA", Descricao = "Maranhão" };
            rep.Salvar(estado);
            estado = new Estado { Sigla = "MT", Descricao = "Mato Grosso" };
            rep.Salvar(estado);
            estado = new Estado { Sigla = "MS", Descricao = "Mato Grosso do Sul" };
            rep.Salvar(estado);
            estado = new Estado { Sigla = "MG", Descricao = "Minas Gerais" };
            rep.Salvar(estado);
            estado = new Estado { Sigla = "PA", Descricao = "Pará" };
            rep.Salvar(estado);
            estado = new Estado { Sigla = "PB", Descricao = "Paraíba" };
            rep.Salvar(estado);
            estado = new Estado { Sigla = "PR", Descricao = "Paraná" };
            rep.Salvar(estado);
            estado = new Estado { Sigla = "PE", Descricao = "Pernambuco" };
            rep.Salvar(estado);
            estado = new Estado { Sigla = "PI", Descricao = "Piauí" };
            rep.Salvar(estado);
            estado = new Estado { Sigla = "RJ", Descricao = "Rio de Janeiro" };
            rep.Salvar(estado);
            estado = new Estado { Sigla = "RN", Descricao = "Rio Grande do Norte" };
            rep.Salvar(estado);
            estado = new Estado { Sigla = "RS", Descricao = "Rio Grande do Sul" };
            rep.Salvar(estado);
            estado = new Estado { Sigla = "RO", Descricao = "Rondônia" };
            rep.Salvar(estado);
            estado = new Estado { Sigla = "RR", Descricao = "Roraima" };
            rep.Salvar(estado);
            estado = new Estado { Sigla = "SC", Descricao = "Santa Catarina" };
            rep.Salvar(estado);
            estado = new Estado { Sigla = "SP", Descricao = "São Paulo" };
            rep.Salvar(estado);
            estado = new Estado { Sigla = "SE", Descricao = "Sergipe" };
            rep.Salvar(estado);
            estado = new Estado { Sigla = "TO", Descricao = "Tocantins" };
            rep.Salvar(estado);
          
        }


        private void BuildSchema(Configuration config)
        {
            new SchemaExport(config)
                .Drop(true, true);

            new SchemaExport(config)
                .Create(true, true);
        }
    }
}
