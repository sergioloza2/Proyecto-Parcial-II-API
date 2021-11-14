using proyecto_api_parcial2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto_api_parcial2
{
    public class UsuarioYListas
    {

        public Usuario User { get; set; }
        public List<Nota> NotasDeUsuario { get; set; }

        public UsuarioYListas(Usuario a, List<Nota> b)
        {
            User = a;
            NotasDeUsuario = b;
        }

    }
}
