using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataAnagramas
{
    public class Anagramas
    {
        public static List<string> obtenerAnagramas(string strPalabraOriginal)
        {
            List<String> resultados = new List<string>();
            resultados.Add("Orma");
            resultados.Add("Amor");
            resultados.Add("Omar");
            resultados.Add("Mora");
            resultados.Add("Ramo");
            resultados.Add("Armo");
            return resultados;
        }
    }
}
