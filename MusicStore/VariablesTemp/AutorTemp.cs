using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using Modelos;


namespace VariablesTemp
{
    public class AutorTemp
    {
        static private AutorBLL autores;
        public static void Inicializar()
        {
            autores = new AutorBLL();
            autores.Agregar(1,"Carlos", "Almonte", "Perez");
            autores.Agregar(2, "Nirvana", "", "");            
            autores.Agregar(3, "Marco", "Solis", "Perez");
            autores.Agregar(4, "Jose Carlos", "Gallegos", "Perez");
        }

        public static List<Autor>getAutores()
        {
            return autores.getAutores();
        }
        public static List<Musica> getMusicaporAutor()
        {
            List<Musica> canciones = MusicaTemp.getMusica().OrderBy(x => x.Autor.Nombre).ToList();
            return canciones;
        }
    }
}
