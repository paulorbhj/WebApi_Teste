using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Cursos.Model
{
    public class CsContext : DbContext
    {
        public DbSet<Curso> Cursos { get; set; }
        public CsContext(DbContextOptions<CsContext> options) : base(options)
        {

        }

    }

}
