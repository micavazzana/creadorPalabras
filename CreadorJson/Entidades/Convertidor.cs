using System.Text;

namespace Entidades
{
    public static class Convertidor
    {
        public static String[] SepararTxt(this String txt)
        {
            char[] demilitador = { ' ', '\n' };
            return txt.Split(demilitador, StringSplitOptions.RemoveEmptyEntries);
        }

        public static char RemoverTildeCaracter(char caracter)
        {
            char retorno = caracter;
            switch (caracter)
            {
                case 'á':
                    retorno = 'a';
                    break;
                case 'é':
                    retorno = 'e';
                    break;
                case 'í':
                    retorno = 'i';
                    break;
                case 'ó':
                    retorno = 'o';
                    break;
                case 'ú':
                    retorno = 'u';
                    break;
            }
            return retorno;
        }

        public static String RemoverTildes(String txt)
        {
            StringBuilder palabraSinTildes = new StringBuilder(txt.Length);
            foreach (char c in txt)
            {
                palabraSinTildes.Append(RemoverTildeCaracter(c));
            }
            return palabraSinTildes.ToString();
        }
    }
}