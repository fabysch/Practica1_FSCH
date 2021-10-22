using NUnit.Framework;
using Practica1_FSCH_Library;
namespace Practica1_FSCH.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TDD_WhenSum_ReturnGreater([Values (4)] int numero1,[Values(2)] int numero2)
        {
            string resultado =Practica1FSCH.Sum(numero1,numero2);

          

            Assert.Greater(numero1,numero2);
        }

        [Test]
        public void TDD_WhenSubstract_ReturnGreater([Values(10)] int numero1, [Values(3)] int numero2)
        {
            string resultado = Practica1FSCH.Substract(numero1, numero2);



            Assert.Less(numero1,numero2);
        }
    }
}