using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMusica.Repositorio
{
    public class SistemaMusicaContexto : DbContext
    {
        public SistemaMusicaContexto() : base("Tienda_Musica")
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Cancion> Canciones { get; set; }
        public DbSet<Disco> Discos { get; set; }


    }
}
