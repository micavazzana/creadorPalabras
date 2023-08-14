namespace Entidades
{
    public class Palabra
    {
        private List<string> words;

        public Palabra()
        {
            this.words = new List<string>();
        }

        public List<string> palabras { get => words; set => words = value; }
    }
}