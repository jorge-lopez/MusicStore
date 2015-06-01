using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using Modelos;


namespace VariablesTemp
{
    public class MusicaTemp
    {
        static MusicaBLL Musica;
        public static void Inicializar(List<Autor> autores, List<Genero> generos)
        {
            Musica = new MusicaBLL();
            Musica.Agregar(1, "Cancion", autores[0], generos[0], 34.55);
            Musica.Agregar(2, "Smells Like Teen Spirit", autores[1], generos[1], 34.55);
            Musica.Agregar(3, "Sonata", autores[2], generos[2], 34.55);
            Musica.Agregar(4, "Cuarteto", autores[3], generos[3], 34.55);
        }

        public static List<Musica> getMusica()
        {
            return MusicaTemp.getMusica().OrderBy(x=>x.Nombre).ToList();
        }
    }
}
