using ExemplosAula;

namespace IntroducaoPOOTests
{
    [TestClass]
    public class ContaTests
    {
        [TestMethod]
        public void DepositoTest()
        {
            //Cenario
            Conta conta1 = new Conta(123, 1000, "Luis");

            decimal valorDepositado = 1000;

            decimal saldoDesejado = 2000;

            //Ação
            conta1.Deposito(valorDepositado);

            //Verificação
            Assert.AreEqual(saldoDesejado, conta1.Saldo);
        

        }
    }
}