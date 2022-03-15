using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cursos.Model
{
    [Table("Curso")]
    public class Curso
    {
        [Key]
        public int IdCurso { get; set; }
        public string Nome { get; set; }
        public string Disciplina { get; set; }
    }
}
