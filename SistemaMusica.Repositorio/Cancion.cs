using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaMusica.Repositorio
{
   public class Cancion
    {
     
        public int Id { get; set; }
        [StringLength(30)]
        public string NombreCacion { get; set; }
        public string Duracion { get; set; }

        public int Precio { get; set; }

        public virtual Disco album { get; set; }
    }
}
