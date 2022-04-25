using NUnit.Framework;
using UnitTestAndDebug;

namespace PersonIdTests
{
    [TestFixture]
    public class PersonIdTests
    {

        [Test]
        public void Test1() // verificar funcionamiento normal de ID
        {
            Person persona = new Person("Jose Lopez","1.232.234-5");
            Assert.AreEqual(persona.ID, "1.232.234-5");
        }

        [Test]
        public void Test2() // verificar funcionamiento normal de ID
        {
            Person persona = new Person("","1.232.234-5");
            Assert.AreEqual(persona.ID, "1.232.234-5");
        }

        [Test]
        public void Test3() // verificar si determina que es vacio
        {
            Person persona = new Person("Jose Lopez","");
            Assert.IsNull(persona.ID);
        }

        [Test]
        public void Test4() // verificar si no es válido
        {
            Person persona = new Person("Jose Lopez","8.8.8.8");
            Assert.IsNull(persona.ID);
        }
    }
}