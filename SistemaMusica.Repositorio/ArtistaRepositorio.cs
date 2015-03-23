using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMusica.Repositorio
{
   public class ArtistaRepositorio
    {
       SistemaMusicaContexto contexto;

       public ArtistaRepositorio()
       {
           contexto = new SistemaMusicaContexto();
       }

       public void GuardarArtista(Artista artista)
       {
           contexto.Artistas.Add(artista);
           contexto.SaveChanges();
       }

       public void ModificarArtista(Artista artista)
       {
           Artista artistaModificar = contexto.Artistas.FirstOrDefault(a => a.Id == artista.Id);
           artistaModificar.Nombres = artista.Nombres;
           artistaModificar.UrlFoto = artista.UrlFoto;
           artistaModificar.discos = artista.discos;
            
           contexto.SaveChanges();
       }

       public void EliminarArtista(Artista artista)
       {
           Artista artistaEliminar = contexto.Artistas.FirstOrDefault(a=> a.Id==artista.Id);
           contexto.Artistas.Remove(artistaEliminar);

           contexto.SaveChanges();
       }
    }
}
