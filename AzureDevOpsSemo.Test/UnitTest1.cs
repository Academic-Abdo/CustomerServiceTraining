using AzureDevOpsDemo.Controllers;

namespace AzureDevOpsSemo.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var home = new HomeController();
            var resulte = home.Index();
            Assert.NotNull(resulte);
        }
    }
}