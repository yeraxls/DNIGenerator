using DNIGenerator.Models;
using DNIGenerator.Shared;
using System.Reflection.Metadata;

namespace DNIGenerator
{
    public class Validator
    {
        public bool ValidateDNI(string dni)
        {
            try
            {
                if(dni.Length < 9 || dni.Length > 9)
                    throw new Exception();
                var numbers = Int32.Parse(dni.Remove(dni.Length - 1));
                var cod = numbers % 23;
                var letter = Constants.letters.First(l => l.Value == cod).Character;
                return dni.EndsWith(letter);
            }
            catch
            {
                return false;
            }
        }
    }
}