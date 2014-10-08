using ControleVacinacao.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVacinacao.Repositorio
{
    public class DataContext: DbContext
    {
       public DbSet<Doenca> Doencas { get; set; }
       public DbSet<ElementoNatural> ElementosNaturais { get; set; }
       public DbSet<Medicamento> Medicamentos { get; set; }
       public DbSet<Medico> Medicos { get; set; }
       public DbSet<Paciente> Pacientes { get; set; }
       public DbSet<Posto> Postos { get; set; }
    }
}
