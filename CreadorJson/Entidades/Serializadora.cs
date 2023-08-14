using System.Text.Json;

namespace Entidades
{
    public class Serializadora<T>

    {
        private static string rutaBase;
        static Serializadora()
        {
            rutaBase = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }
        public static void SerializarJson(string nombreArchivo, T objeto)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter($"{rutaBase}\\{nombreArchivo}"))
                {
                    JsonSerializerOptions opciones = new JsonSerializerOptions();
                    opciones.WriteIndented = true;
                    string ser = JsonSerializer.Serialize(objeto, opciones);
                    sw.WriteLine(ser);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al serializar el json", ex);
            }
        }
    }
}