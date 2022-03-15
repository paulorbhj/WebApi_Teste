using Cursos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cursos.Repositorio
{
    public interface ICursoRepos
    {
        Task<IEnumerable<Curso>> Get();
        Task<Curso> Create(Curso curso);
        Task<Curso> Delete(int IdCurso);
        Task<Curso> Get(int IdCurso);
    }
}
