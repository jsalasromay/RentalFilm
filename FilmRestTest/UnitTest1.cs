using FilmRest;
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
        [TestMethod]
        public void TestGetByCategory()
        {
            var film = _filmServices.GetByCategory("Drama");
            foreach (var f in film)
            {
                Assert.AreEqual("Drama", f.Category);
            }
        }
        [TestMethod]
        public void TestGetAll()
        {
            var f = _filmServices.GetAll().Count;
            Assert.IsTrue(f > 0);
        }
        [TestMethod]
        public void TestSetFilm()
        {
            Film film = new Film("AA", "El señor de los pardillos", "Comedia");
            var f = _filmServices.SetFilm(film);
            var f2 = _filmServices.GetById(f.Id);
            Assert.AreEqual(film.Id, f2.Id);
            Assert.AreEqual(film.Name, f2.Name);
            Assert.AreEqual(film.Category, f2.Category);
        }
    }
}
