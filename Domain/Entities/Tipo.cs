using Domain.Entities.Interfaces;

namespace Domain.Entities
{
   public class Tipo :IBase
    {
       public virtual int Id { get; set; }
       public virtual string Descricao { get; set; }
    }
}
