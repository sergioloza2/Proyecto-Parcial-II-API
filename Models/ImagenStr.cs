using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto_api_parcial2
{
    public class ImagenStr
    {


        [Key]
        public int ImagenStrId { get; set; }
        public String ImagenBase64 { get; set; }
    }
}
