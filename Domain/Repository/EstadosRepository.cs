
using System.Collections.Generic;
using System.Linq;
using Domain.Entities;

namespace Domain.Repository
{
    public class EstadosRepository : BaseRepository
    {
        
        public IList<Estado> EstadosPorPais(int idPais)
        {
            return Todos<Estado>().Where(x => x.Pais.Id == idPais).ToList();
        }

    }
}
