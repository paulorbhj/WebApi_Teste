using Cursos.Model;
using Cursos.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Cursos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController :ControllerBase
    {
        
        private readonly ICursoRepos _CursoRepos;
        public CursoController(ICursoRepos CursoRepos)
        {
            _CursoRepos = CursoRepos;
        }

        [HttpGet]
        public async Task<IEnumerable<Curso>> Get()
        {
            return await _CursoRepos.Get();
        }
        //O código abaixo desta linha exibe na tela o atributo IdCurso
        [HttpGet("{IdCurso}")]
        public async Task<ActionResult<Curso>> Get(int IdCurso)
        {
            return await _CursoRepos.Get(IdCurso);
        }

        [HttpPost]
        public async Task<ActionResult<Curso>> Post([FromBody] Curso curso)
        {
            var NovoCurso = await _CursoRepos.Create(curso);
            return CreatedAtAction(nameof(Get), new { Id = NovoCurso.IdCurso }, NovoCurso);
        }

        [HttpDelete ("{IdCurso}")]
        public async Task<ActionResult>Delete(int IdCurso)
        {
            var cursodel = await _CursoRepos.Get(IdCurso);
            if(cursodel == null)
            {
                return NotFound();
            }

            await _CursoRepos.Delete(cursodel.IdCurso);
            return NoContent();
        }
    }
}
