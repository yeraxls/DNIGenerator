using DNIGenerator.Models;
using DNIGenerator.Shared;
using System.Reflection.Metadata;
using System.Text;

namespace DNIGenerator
{
    public class Generator
    {
        public string Generate()
        {
            try
            {
                var numbers = GenerateNumbers();
                var letter = GetLetter(Int32.Parse(numbers));
                return string.Format("{0}{1}", numbers, letter);
            }
            catch
            {
                return string.Empty;
            }
        }

        private string GenerateNumbers()
        {
            var sb = new StringBuilder();

            var rnd = SeedRandom();
            for (int i = 0; i < 8; i++)
            {
                sb.Append(rnd.Next(0, 9).ToString());
            }
            return sb.ToString();
        }

        private string GetLetter(int number)
        {
            var resto = number % 23;
            return Constants.letters.First(l => l.Value == resto).Character;
        }

        private Random SeedRandom()
        {
            return new Random(Guid.NewGuid().GetHashCode());
        }
    }
}