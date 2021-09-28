using FilmRest.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FilmRestTest
{
    [TestClass]
    public class UnitTest1
    {
        FilmServices _filmServices = new FilmServices();

        [TestMethod]
        public void TestGetById()
        {
            var f = _filmServices.GetById("AA");
            Assert.AreEqual("El señor de los palillos", f.Name);
        }
    }
}
