

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
        [Ignore]
        public void a__Criar_Banco_De_Dados_Por_Modelo()
        {
            Fluently.Configure().Database(MsSqlConfiguration.MsSql2005.ConnectionString(c => c
           .FromAppSetting("Conexao")
            )).Mappings(m => m.FluentMappings.AddFromAssemblyOf<Estado>()).Mappings(m => m.MergeMappings())
            .ExposeConfiguration(BuildSchema).BuildSessionFactory();
        }

        [Test]
        [Ignore]
        public void InsertEstados()
        {
            var repPais = new PaisRepository();
            var pais = new Pais { Nome = "Brasil" };
            var estado = new Estado { Descricao = "Bahia", Sigla = "BA", Pais = pais };
            pais.AdicinarEstado(estado);
            estado = new Estado { Sigla = "AC", Descricao = "Acre", Pais = pais };
            pais.AdicinarEstado(estado);
            estado = new Estado { Sigla = "AL", Descricao = "Alagoas", Pais = pais };
            pais.AdicinarEstado(estado);
            estado = new Estado { Sigla = "AP", Descricao = "Amapá", Pais = pais };
            pais.AdicinarEstado(estado);
            estado = new Estado { Sigla = "AM", Descricao = "Amazonas", Pais = pais };
            pais.AdicinarEstado(estado);
            estado = new Estado { Sigla = "BA", Descricao = "Bahia", Pais = pais };
            pais.AdicinarEstado(estado);
            estado = new Estado { Sigla = "CE", Descricao = "Ceará", Pais = pais };
            pais.AdicinarEstado(estado);
            estado = new Estado { Sigla = "DF", Descricao = "Distrito Federal", Pais = pais };
            pais.AdicinarEstado(estado);
            estado = new Estado { Sigla = "ES", Descricao = "Espírito Santo", Pais = pais };
            pais.AdicinarEstado(estado);
            estado = new Estado { Sigla = "GO", Descricao = "Goiás", Pais = pais };
            pais.AdicinarEstado(estado);
            estado = new Estado { Sigla = "MA", Descricao = "Maranhão", Pais = pais };
            pais.AdicinarEstado(estado);
            estado = new Estado { Sigla = "MT", Descricao = "Mato Grosso", Pais = pais };
            pais.AdicinarEstado(estado);
            estado = new Estado { Sigla = "MS", Descricao = "Mato Grosso do Sul", Pais = pais };
            pais.AdicinarEstado(estado);
            estado = new Estado { Sigla = "MG", Descricao = "Minas Gerais", Pais = pais };
            pais.AdicinarEstado(estado);
            estado = new Estado { Sigla = "PA", Descricao = "Pará", Pais = pais };
            pais.AdicinarEstado(estado);
            estado = new Estado { Sigla = "PB", Descricao = "Paraíba", Pais = pais };
            pais.AdicinarEstado(estado);
            estado = new Estado { Sigla = "PR", Descricao = "Paraná", Pais = pais };
            pais.AdicinarEstado(estado);
            estado = new Estado { Sigla = "PE", Descricao = "Pernambuco", Pais = pais };
            pais.AdicinarEstado(estado);
            estado = new Estado { Sigla = "PI", Descricao = "Piauí", Pais = pais };
            pais.AdicinarEstado(estado);
            estado = new Estado { Sigla = "RJ", Descricao = "Rio de Janeiro", Pais = pais };
            pais.AdicinarEstado(estado);
            estado = new Estado { Sigla = "RN", Descricao = "Rio Grande do Norte", Pais = pais };
            pais.AdicinarEstado(estado);
            estado = new Estado { Sigla = "RS", Descricao = "Rio Grande do Sul", Pais = pais };
            pais.AdicinarEstado(estado);
            estado = new Estado { Sigla = "RO", Descricao = "Rondônia", Pais = pais };
            pais.AdicinarEstado(estado);
            estado = new Estado { Sigla = "RR", Descricao = "Roraima", Pais = pais };
            pais.AdicinarEstado(estado);
            estado = new Estado { Sigla = "SC", Descricao = "Santa Catarina", Pais = pais };
            pais.AdicinarEstado(estado);
            estado = new Estado { Sigla = "SP", Descricao = "São Paulo", Pais = pais };
            pais.AdicinarEstado(estado);
            estado = new Estado { Sigla = "SE", Descricao = "Sergipe", Pais = pais };
            pais.AdicinarEstado(estado);
            estado = new Estado { Sigla = "TO", Descricao = "Tocantins", Pais = pais };
            pais.AdicinarEstado(estado);
            repPais.Salvar(pais);
        }

        [Test]
        [Ignore]
        public void SelectEstado()
        {
            var teste = new PaisRepository();
            var bla = teste.Todos<Pais>();
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
