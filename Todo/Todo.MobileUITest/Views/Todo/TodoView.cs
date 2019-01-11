using System;
using System.Linq;
using Todo.MobileUITest.Views.Common;
using Todo.MobileUITest.Views.Task;

namespace Todo.MobileUITest.Views.Todo
{
    public class TodoView : BasicView
    {
        public TodoViewLocator Locate;
        public TodoView(AppUser appUser) : base(appUser)
        {
            Locate = new TodoViewLocator();
            Locate.CreateInstance(AppUser.Platform);
        }

        public TaskView TapOnCreateTask()
        {
            App.WaitForElement(Locate.AddButton, $"Timed out waiting for element {Locate.AddButton}",
                 TimeSpan.FromSeconds(60));
            App.Tap(Locate.AddButton);
            return new TaskView(AppUser);
        }

        public TaskView TapOnPreviousTaskCreated(string name)
        {
            App.WaitForElement(Locate.TasksList, $"Timed out waiting for element {Locate.TasksList}",
                TimeSpan.FromSeconds(60));
            var appResult = App.Query(Locate.TaskName).ToList();
            var elem = appResult.FirstOrDefault(c => c.Text == name);
            App.Tap(elem.Id);
            return new TaskView(AppUser);
        }

        public TodoViewChecker Verify()
        {
            return new TodoViewChecker(AppUser);
        }
    }
}
