using System.Collections;
using System.Linq;
using Domain.Entities;
using Domain.Repository;

namespace Facade
{
    public class ClienteFacade
    {
        
        public void Salvar(Cliente cliente)
        {
            
            (new ClienteRepository()).SalvarCliente(cliente);
        }

        public IEnumerable GetTodosClientesSelect()
        {
            return (new ClienteRepository()).Todos().Select(x => new { id = x.Id, name = x.Nome });
        }

        public Cliente GetCliente(int id)
        {
            return (new ClienteRepository()).Obter<Cliente>(id);

        }
        public IEnumerable GetPaizSelect()
        {
            return (new PaisRepository()).Todos().Select(x => new { id = x.Id, name = x.Descricao });
        }

        public IEnumerable GetEstadosPorPaizSelect(int id)
        {
            return (new EstadosRepository()).EstadosPorPais(id).Select(x => new { id = x.Id, name = x.Descricao });
        }


        public IEnumerable GetFormaContato()
        {

            return (new FormaContatoRepository()).ListaFormaContatos().Select(x => new { id = x.Id, name = x.Descricao });
        }

        public IEnumerable GetCidadesPorEstadoSelect(int id)
        {
            return (new CidadeRepository()).CidadesPorEstado(id).Select(x => new { id = x.Id, name = x.Descricao });
        }

        public object GetTipoPele()
        {
            return (new TipoPeleRepository()).Todos<TipoPele>().Select(x => new { id = x.Id, name = x.Descricao });
        }

        public object GetTomPele()
        {
            return (new TomDePeleRepository()).Todos<TomDePele>().Select(x => new { id = x.Id, name = x.Descricao +" "+ x.Numero });
        }
    }
}