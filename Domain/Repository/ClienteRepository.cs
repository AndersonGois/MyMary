
using System.Collections.Generic;
using System.Linq;
using Domain.Entities;

namespace Domain.Repository
{
    public class ClienteRepository : BaseRepository
    {
       
       public IList<Cliente> Todos()
       {
           return Todos<Cliente>();
       }
    }
}
