using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD.Preparativos;
using TDD;

namespace PruebasTDD
{
    [TestClass]
    public class TestMaquinaDeCafe
    {
        Cafetera cafetera;
        Vaso vasosPequenos;
        Vaso vasosMediano;
        Vaso vasosGrande;
        Azuquero azuquero;
        MaquinaCafe maquinaCafe;

        [TestMethod]
        public void setUp()
        {
            cafetera = new Cafetera(50);
            vasosPequenos = new Vaso(5, 10);
            vasosMediano = new Vaso(5, 20);
            vasosGrande = new Vaso(5, 30);
            azuquero = new Azuquero(20);

            maquinaCafe = new MaquinaCafe();
            maquinaCafe.setCafetera(cafetera);
            maquinaCafe.setVasosPequenos(vasosPequenos);
            maquinaCafe.setVasosMediano(vasosMediano);
            maquinaCafe.setVasosGrande(vasosGrande);
            maquinaCafe.setAzucarero(azuquero);
        }

        [TestMethod]
        public void deveriaDevolverUnVasoPequeno()
        {
            Vaso vaso = maquinaCafe.getTipoVaso("pequeno");

            Assert.AreEqual(maquinaCafe.getVasosPequenos(), vaso);
        }
    }
}
