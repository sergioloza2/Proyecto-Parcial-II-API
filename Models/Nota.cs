using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace proyecto_api_parcial2.Models
{
    public class Nota

    {
        [Key]
        public int NotaId { get; set; }
        public string Contenido { get; set; }


        public int UsuarioId { get; set; }

        [JsonIgnore]
        public Usuario Usuario { get; set; }
    }
}
