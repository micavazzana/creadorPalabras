using Entidades;

internal class Program
{
    private static void Main(string[] args)
    {
        int cantidadDeLetrasMin = 4;
        int cantidadDeLetrasMax = 8;

        try
        {
            //Obtengo el txt de todas las palabras existentes
            String txt = GestorArchivo.LeerTxt("words_sin_conjugaciones.txt");

            //Utilizo el metodo extendido para separar el texto en un array de palabras
            String[] palabras = txt.SepararTxt();

            //Creo una nueva lista. Itero mi array de palabras y remuevo las tildes de cada palabra.
            //Luego añado la palabra sin tilde en mi nueva lista
            List<string> palabrasSinTildes = new List<string>();
            foreach (string palabra in palabras)
            {
                string palabraSinTilde = Convertidor.RemoverTildes(palabra);
                palabrasSinTildes.Add(palabraSinTilde);
            }

            //Creo un obj Palabra. Itero la lista de palabras filtradas.
            //Solo me guardo dentro del objeto las palabras que tengan entre 4 y 8 letras
            Palabra p = new Palabra();
            foreach (string palabra in palabrasSinTildes)
            {
                if (palabra.Length >= cantidadDeLetrasMin && palabra.Length <= cantidadDeLetrasMax)
                {
                    p.palabras.Add(palabra);
                }
            }

            //GUARDO LAS PALABRAS en un JSON con el formato de objeto Palabra(atributo palabras)
            Serializadora<Palabra>.SerializarJson("palabras.json", p);
            Console.WriteLine($"La serializacion ha finalizado, hay: {p.palabras.Count} palabras");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}