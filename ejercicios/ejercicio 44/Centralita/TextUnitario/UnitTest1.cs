using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TextUnitario
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void LlamadasNotNull()
    {
      Centralita centralita= new Centralita("lpm");
      Assert.IsNotNull(centralita.Llamadas);
    }

    [TestMethod]
    [ExpectedException(typeof(CentralitaException))]
    public void ProbarTrow()
    {
      Centralita centralita = new Centralita("lpm");
      Local local = new Local("1531224833", (float)2.3, "1531224833", (float)3.25);
      centralita = centralita + local;
      centralita = centralita + local;
    }
    [TestMethod]
    public void IgualdadDeClases()
    {
      Local local = new Local("1531224833", (float)2.3, "1531224833", (float)3.25);
      Local local2 = new Local("1531224833", (float)2.3, "1531224833", (float)3.25);
      Provincial provincial = new Provincial("1531224833",Provincial.Franja.Franja_1,(float)2.3, "1531224833");
      Provincial provincial2 = new Provincial("1531224833", Provincial.Franja.Franja_1, (float)2.3, "1531224833");
      Assert.IsTrue(local == local2);
      Assert.IsTrue(provincial == provincial2);
      Assert.IsFalse(local == provincial);
      Assert.IsFalse(provincial2 == local2);
    }
  }
}
