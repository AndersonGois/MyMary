using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Repository
{
    public class FormaContatoRepository : BaseRepository
    { 
        public IList<FormaContato> ListaFormaContatos()
        {
            return Todos<FormaContato>();
        }

        public FormaContato GetFormacontato(int id)
        {
            return Obter<FormaContato>(id);
        }
    }
}
