using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVacinacao.Dominio
{
   [Table("Postos")]
   public class Posto
   {
      public int Id { get; set; }

      [StringLength(50)]
      public string Nome { get; set; }

      [StringLength(7)]
      public string Tipo { get; set; }

      public Posto()
      {
         this.Tipo = "PÚBLICO";
      }
   }
}
