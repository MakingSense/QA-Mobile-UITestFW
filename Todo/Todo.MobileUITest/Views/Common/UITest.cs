using NUnit.Framework;

namespace Todo.MobileUITest.Views.Common
{
    public class UITest
    {
        public AppUser App { get; private set; }

        [SetUp]
        public void BaseSetUp()
        {
            App = new AppUser();
        }
    }
}
