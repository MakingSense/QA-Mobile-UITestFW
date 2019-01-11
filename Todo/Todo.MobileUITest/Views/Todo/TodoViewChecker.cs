using System;
using System.Linq;
using NUnit.Framework;
using Todo.MobileUITest.Views.Common;

namespace Todo.MobileUITest.Views.Todo
{
    public class TodoViewChecker : BasicViewChecker
    {
        public TodoViewLocator Locate;

        public TodoViewChecker(AppUser appUser) : base(appUser) 
        {
            Locate = new TodoViewLocator();
            Locate.CreateInstance(AppUser.Platform);
        }

        public TodoViewChecker YourRecentlyTaskIsShown(string name = "Test")
        {
            App.WaitForElement(Locate.TaskName, $"Timed out waiting for element {Locate.TaskName}",
                TimeSpan.FromSeconds(60));
            var appResult = App.Query(Locate.TaskName).First();
            Assert.AreEqual(appResult.Text, name);
            return this;
        }

        public TodoViewChecker YourRecentlyTaskIsNOTShown(string name = "Test")
        {
            App.WaitForElement(Locate.TasksList, $"Timed out waiting for element {Locate.TasksList}",
                TimeSpan.FromSeconds(60));
            var appResult = App.Query(Locate.TaskName).ToList();
            var elem = appResult.FirstOrDefault(c => c.Text == name);
            Assert.IsTrue(elem == null);
            return this;
        }
    }
}
