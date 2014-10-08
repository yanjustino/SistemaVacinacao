﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVacinacao.Dominio
{
   [Table("Medicamentos")]
   public class Medicamento
   {
      public int Id { get; set; }
      [StringLength(50)]
      public string Nome { get; set; }
   }
}
