using System.Collections.Generic;
using Domain.Entities;
using Domain.Repository;

namespace Facade
{
    public class ClienteFacade
    {
        private readonly ClienteRepository _repository = new ClienteRepository();
        private readonly PaisRepository _paisRepository = new PaisRepository();
        public void Salvar(ClienteView cliente)
        {
            _repository.Salvar(cliente);
        }

        public IList<Cliente> GetTodosClientes()
        {
            return   _repository.Todos<Cliente>();

        }

        public IList<Pais> GetPais()
        {
            return _paisRepository.Todos();
        } 

        public  IList<Estado> GetEstadosPorPais(int id)
        {
            return (new EstadosRepository()).EstadosPorPais(id);
        }

        public IList<Cidade>  GetCidadesPorEstado(int id)
        {
            return (new CidadeRepository()).CidadesPorEstado(id);
        }
    }
}