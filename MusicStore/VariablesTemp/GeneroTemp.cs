using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using Modelos;


namespace VariablesTemp
{
    public class GeneroTemp
    {
        static private GeneroBLL generos;
        public static void Inicializar()
        {
            generos = new GeneroBLL();
            generos.Agregar(1, "Rock", "En espagnol");
            generos.Agregar(2, "Pop", "Yep yep");
            generos.Agregar(3, "Baladas", "Calafias");
            generos.Agregar(4, "Rap", "Tambien de calafia");
        }

        public static List<Genero> getGenero()
        {
            return generos.getGeneros();
        }
        public static List<Musica> getMusicaporGenero()
        {
            List<Musica> canciones = MusicaTemp.getMusica().OrderBy(x => x.Genero.Nombre).ToList();
            return canciones;
        }
    }
}
