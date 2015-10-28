
using System.Collections.Generic;
using System.Linq;
using Domain.Entities;

namespace Domain.Repository
{
    public class ClienteRepository : BaseRepository
    {
       
        public void SalvarCliente(Cliente cliente)
        {
            var formaContatoRepo = new FormaContatoRepository();
            var vaTipoPeleRepo = new TipoPeleRepository();
            var vaTomPele = new TomDePeleRepository();
        
            if (cliente.Anfitriao.Id == 0)
                cliente.Anfitriao = null;


            cliente.TipoPele = vaTipoPeleRepo.Obter<TipoPele>(cliente.TipoPele.Id);
            cliente.FormaContato = formaContatoRepo.Obter<FormaContato>(cliente.FormaContato.Id);
            cliente.TomDePele = vaTomPele.Obter<TomDePele>(cliente.TomDePele.Id);
            Salvar(cliente);
        }

       public IList<Cliente> Todos()
       {
           return Todos<Cliente>();
       }
    }
}
