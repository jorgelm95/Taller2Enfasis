using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMusica.Repositorio
{
   public class Disco
    {
        public int Id { get; set; }

       [StringLength(40)]
        public string Nombre { get; set; }
        public string UrlFoto { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public int NumeroCanciones { get; set; }
        public int Precio { get; set; }

        public virtual Artista artista { get; set; }
        public virtual List<Cancion> Canciones { get; set; }

    }
}
