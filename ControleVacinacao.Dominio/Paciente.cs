using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVacinacao.Dominio
{
   [Table("Pacientes")]
   public class Paciente
   {
      public int Id { get; set; }
      [StringLength(80)]
      public string Nome { get; set; }
      [StringLength(1)]
      public string Sexo { get; set; }
      public DateTime DataNascimento { get; set; }
      [StringLength(1)]
      public string TipoSanguineo { get; set; }
      [StringLength(1)]
      public string FatorSanguineo { get; set; }
      [EmailAddress]
      public string Email { get; set; }
      [StringLength(20)]
      public string Celular { get; set; }
   }
}
