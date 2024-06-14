namespace ProyectoTesteoApp
{
    public class TestLibros
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ObtenerLibrosTest()
        {
            LibrosRepository librosRepository= new LibrosRepository();
            Assert.Pass();
        }
    }
}