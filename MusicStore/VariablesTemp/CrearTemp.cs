using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesTemp
{
    public class CrearTemp
    {
        public static void Inicializar()
        {
            AutorTemp.Inicializar();
            GeneroTemp.Inicializar();
            MusicaTemp.Inicializar(AutorTemp.getAutores(), GeneroTemp.getGenero());
        }

    }
}
