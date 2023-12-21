using DNIGenerator;

namespace DNIGeneratorTests
{
    public class ValidatorTests
    {
        private Validator validator;
        [SetUp]
        public void Setup()
        {
            validator = new Validator();
        }

        [Test]
        public void ValidationSuccesfull()
        {
            var result = validator.ValidateDNI("46271170T");
            Assert.That(result, Is.EqualTo(true));
        }
        [Test]
        public void ValidationError()
        {
            var result = validator.ValidateDNI("asdf");
            Assert.That(result, Is.EqualTo(false));
        }
        [Test]
        public void ValidationErrorNotNumeric()
        {
            var result = validator.ValidateDNI("asdfasdfL");
            Assert.That(result, Is.EqualTo(false));
        }
    }
}