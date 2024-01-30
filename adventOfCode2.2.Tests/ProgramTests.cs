
namespace adventOfCodeTests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestMethod1()
        {   //arange
            string inputGame = "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green";
            int expected = 48;
           
            //act 
            int result = Program.ComputeGame(inputGame);
           
            // assert 
            Assert.AreEqual(expected, result);
        }
    }
}



