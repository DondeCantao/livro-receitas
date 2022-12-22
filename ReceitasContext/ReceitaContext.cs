using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using livro_receitas.Models;
using Microsoft.EntityFrameworkCore;

namespace livro_receitas.ReceitasContext
{
    public class ReceitaContext : DbContext
    {
        public ReceitaContext (DbContextOptions<ReceitaContext>options) : base (options)
        {

        }   
        public DbSet<Receitas> receitas { get; set;}
    }

}