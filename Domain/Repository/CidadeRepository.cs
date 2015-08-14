
using System.Collections.Generic;
using System.Linq;
using Domain.Entities;

namespace Domain.Repository
{
    public class CidadeRepository : BaseRepository
    {
        public IList<Cidade> CidadesPorEstado(int idEstado)
        {
            return Todos().Where(x => x.Estado.Id == idEstado).ToList();
        }

        public IList<Cidade> Todos()
        {
            return Todos<Cidade>();
        } 
    }
}
