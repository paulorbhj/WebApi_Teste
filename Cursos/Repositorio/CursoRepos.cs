using Cursos.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cursos.Repositorio
{
    public class CursoRepos : ICursoRepos
    {
        //O código abaixo é utilizado para chamar a classe de conexao com o banco
        public readonly CsContext _ctx;

        //O construtor abaixo é usado para instanciar a objeto de conexao 
        public CursoRepos(CsContext context)
        {
            _ctx = context;
        }
        public async Task<Curso> Create(Curso curso)
        {
            _ctx.Cursos.Add(curso);
            await _ctx.SaveChangesAsync();
            return curso;
        }

        public async Task<Curso> Delete(int IdCurso)
        {
            var cursodel = await _ctx.Cursos.FindAsync(IdCurso);
            _ctx.Cursos.Remove(cursodel);
            await _ctx.SaveChangesAsync();
            return null;
        }

        public async Task<IEnumerable<Curso>> Get()
        {
            return await _ctx.Cursos.ToListAsync();
        }

        public async Task<Curso> Get(int IdCurso)
        {
            return await _ctx.Cursos.FindAsync(IdCurso);
        }
    }
}
