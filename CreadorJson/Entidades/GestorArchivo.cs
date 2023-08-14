namespace Entidades
{
    public class GestorArchivo
    {
        private static string rutaBase;

        static GestorArchivo()
        {
            rutaBase = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        public static void EscribirTxt(string nombreArchivo, string contenido)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter($"{rutaBase}\\{nombreArchivo}"))
                {
                    sw.WriteLine(contenido);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al escribir archivo de texto", ex);
            }
        }

        public static string LeerTxt(string nombreArchivo)
        {
            string retorno = String.Empty;

            try
            {
                using (StreamReader sr = new StreamReader($"{GestorArchivo.rutaBase}\\{nombreArchivo}"))
                {
                    return sr.ReadToEnd();

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer archivo de texto", ex);
            }
        }
    }
}