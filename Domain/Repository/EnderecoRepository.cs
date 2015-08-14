using Domain.Entities;

namespace Domain.Repository
{
    public class EnderecoRepository : BaseRepository
    {
       public Endereco GetEndereco(int id)
       {
           return Obter<Endereco>(id);
       }
    }
}