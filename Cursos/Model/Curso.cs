using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cursos.Model
{
    // O código abaixo é usado para indicar ao visual studio que ele tem que encontrar uma tabela no banco de dados de nome Curso
    [Table("Curso")]
    public class Curso
    {
        [Key]
        public int IdCurso { get; set; }
        public string Nome { get; set; }
        public string Disciplina { get; set; }
    }
}
