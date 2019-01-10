using System;
using System.Linq;
using NUnit.Framework;
using Todo.MobileUITest.Views.Common;

namespace Todo.MobileUITest.Views.Todo
{
    public class TodoViewChecker : BasicViewChecker
    {
        public TodoViewLocator Locate = new TodoViewLocator();

        public TodoViewChecker(AppUser appUser) : base(appUser) { }

        public TodoViewChecker YourRecentlyTaskIsShown()
        {
            App.WaitForElement(Locate.TasksList, $"Timed out waiting for element {Locate.TasksList}", 
                TimeSpan.FromSeconds(60));
            Assert.IsTrue(App.Query(Locate.TasksList).First().Enabled);
            return this;
        }
    }
}
