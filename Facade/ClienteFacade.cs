using System.Collections.Generic;
using Domain.Entities;
using Domain.Repository;

namespace Facade
{
    public class ClienteFacade
    {
        private readonly ClienteRepository _repository = new ClienteRepository();
        public void Salvar(ClienteView cliente)
        {
            _repository.Salvar(cliente);
        }

        public IList<Cliente> GetTodosClientes()
        {
            return   _repository.Todos<Cliente>();

        }
    }
}