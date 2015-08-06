using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Entities.Interfaces;

namespace Domain.Entities
{
   public class Endereco : IBase
    {
       public int Id { get; set; }
       public Estado Estado { get; set; }
       public Cidade Cidade { get; set; }
       public Bairro Bairro { get; set; }
       public string Logradouro { get; set; }
       public int? Numero { get; set; }
       public string Complemento { get; set; }
    }
}
