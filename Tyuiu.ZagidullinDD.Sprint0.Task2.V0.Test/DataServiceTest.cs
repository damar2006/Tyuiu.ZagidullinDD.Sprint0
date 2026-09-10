using Tyuiu.ZagidullinDD.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ZagidullinDD.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Дамир";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Дамир", res);
        }
    }
}
