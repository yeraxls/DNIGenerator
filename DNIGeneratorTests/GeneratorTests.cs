using DNIGenerator;

namespace DNIGeneratorTests
{
    public class GeneratorTests
    {
        private Generator generator;
        private Validator validator;
        [SetUp]
        public void Setup()
        {
            generator = new Generator();
            validator = new Validator();
        }

        [Test]
        public void GeneratorSuccesfull()
        {
            var result = generator.Generate();
            var checkValid = validator.ValidateDNI(result);
            Assert.That(result.Length, Is.EqualTo(9));
            Assert.That(checkValid, Is.EqualTo(true));
        }
       
    }
}