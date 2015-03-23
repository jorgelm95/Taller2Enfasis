using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMusica.Repositorio
{
    public class DiscoRepositorio
    {
        SistemaMusicaContexto contexto;

        public DiscoRepositorio()
        {
            contexto = new SistemaMusicaContexto();
        }

        public void GuardarDisco(Disco disco)
        {
            contexto.Discos.Add(disco);
            contexto.SaveChanges();

        }

        public void ModificarDisco(Disco disco)
        {
            Disco discoModificar = contexto.Discos.FirstOrDefault(d => d.Id == disco.Id);
            discoModificar.Nombre = disco.Nombre;
            discoModificar.UrlFoto = disco.UrlFoto;
            discoModificar.FechaLanzamiento = disco.FechaLanzamiento;
            discoModificar.NumeroCanciones = disco.NumeroCanciones;
            discoModificar.Precio = disco.Precio;
            discoModificar.artista = disco.artista;
            discoModificar.Canciones = disco.Canciones;

            contexto.SaveChanges();

        }

        public void EliminarDisco(Disco disco)
        {
            Disco discoEliminar = contexto.Discos.FirstOrDefault(d => d.Id == disco.Id);
            contexto.Discos.Remove(discoEliminar);
        }
    }
}
