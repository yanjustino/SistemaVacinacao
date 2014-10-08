using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVacinacao.Dominio
{
   public class Paciente
   {
      public int Id { get; set; }
      public string Nome { get; set; }
      public string Sexo { get; set; }
      public DateTime DataNascimento { get; set; }
      public string TipoSanguineo { get; set; }
      public string FatorSanguineo { get; set; }
      public string Email { get; set; }
      public string Celular { get; set; }
   }
}
