using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVacinacao.Dominio
{
   [Table("Medicos")]
   public class Medico
   {
      public int Id { get; set; }

      [StringLength(80)]
      public string Nome { get; set; }
   }
}
