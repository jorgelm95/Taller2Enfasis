using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMusica.Repositorio
{
  public class CancionRepositorio
    {
      SistemaMusicaContexto contexto;

      public CancionRepositorio()
      {
          contexto = new SistemaMusicaContexto();
      }

      public void  GuardarCancion(Cancion cancion)
      {
          contexto.Canciones.Add(cancion);
          contexto.SaveChanges();

      }

      public void ModificarCancion(Cancion cancion)
      {
          Cancion cancionModificar = contexto.Canciones.FirstOrDefault(c => c.Id == cancion.Id);
          cancionModificar.NombreCacion = cancion.NombreCacion;
          cancionModificar.Duracion = cancion.Duracion;
          cancionModificar.Precio = cancion.Precio;
          cancion.album = cancion.album;

          contexto.SaveChanges();
      }

      public void EliminarCancion(Cancion cancion)
      {
          Cancion cancionEliminar = contexto.Canciones.FirstOrDefault(c => c.Id == cancion.Id);
          contexto.Canciones.Remove(cancionEliminar);
          contexto.SaveChanges();
      }

      public List<Cancion> canciones()
      {
          List<Cancion> canciones = contexto.Canciones.Where(c=> c.Precio>=2000 && c.Precio< 5000 ).ToList();
          return canciones;
      }

      public List<Cancion> BuscarCanciones(string opcion, string PalabraClave)
      {
              if (opcion == "album")
              {
              
                  Disco disco = contexto.Discos.FirstOrDefault(d=> d.Nombre == PalabraClave);
                  int disco_album = disco.Id;

                  List<Cancion> cancionesEncontradas = contexto.Canciones.Where(c => Equals(c.album, disco_album)).ToList();   
                  return cancionesEncontradas;  

              }
              else if (opcion == "Artista")
              {
                  Artista artistas = contexto.Artistas.FirstOrDefault(a => a.Nombres == PalabraClave);
                  int id_artista = artistas.Id;

                  List<Disco> discosArtista = contexto.Discos.Where(d=> Equals(d.artista,id_artista)).ToList();

                  foreach (var item in discosArtista)
                  {
                      List<Cancion> canciones = contexto.Canciones.ToList();
                      foreach (var itenCancion in canciones)
                      {
                      
                          if (Equals(item.Id,itenCancion.album))
                          {
                              List<Cancion> cancionesEncintradas = new List<Cancion>();
                              cancionesEncintradas.Add(itenCancion);
                              return cancionesEncintradas.ToList();
                          }
                      }
                  }
             }
              return null;
          }





    }
}
