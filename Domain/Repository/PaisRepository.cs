
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Repository
{
    public class PaisRepository : BaseRepository
    {
        public IList<Pais> Todos()
        {
           return Todos<Pais>();
        }
    }
}
