using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using livro_receitas.Models;

namespace livro_receitas.Models
{
    public class Receitas
    {
        public int Id { get; set; }
       public string Nome { get; set; }
       public string Descrição { get; set; }
       public EnumTipoReceita Tipo { get; set; }
       public string Igredientes { get; set; }
       public string ModoDePreparo { get; set; }
       public string LinkYoutube { get; set; }
    }
}