using NUnit.Framework;
using UnitTestAndDebug;

namespace PersonNameTests
{
    [TestFixture]
    public class PersonNameTests
    {

        [Test]
        public void Test1() // verificar funcionamiento normal de nombre
        {
            Person persona = new Person("Jose Lopez","1.232.234-5");
            Assert.AreEqual(persona.Name, "Jose Lopez");
        }

        [Test]
        public void Test2() // verificar ingrese nombre aunque no ingrese ID
        {
            Person persona = new Person("Jose Lopez","8.8.8.8");
            Assert.AreEqual(persona.Name, "Jose Lopez");
        }

        [Test]
        public void Test3() // verificar si determina que es vacio
        {
            Person persona = new Person("","1.232.234-5");
            Assert.IsNull(persona.Name);
        }

        [Test]
        public void Test4() // verificar si es null
        {
            Person persona = new Person(null,"1.232.234-5");
            Assert.IsNull(persona.Name);
        }
    }
}