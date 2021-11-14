
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace proyecto_api_parcial2.Models
{
    public class Usuario
    {

        [Key]
        public int UsuarioId { get; set; }

        public string NUsuario { get; set; }
        public string Contraseña { get; set; }

        public string FechaRegistro { get; set; }

        [JsonIgnore]
        public List<Nota> Notas { get; set; }


        public int FotoPerfilId { get; set; }


    }
}
