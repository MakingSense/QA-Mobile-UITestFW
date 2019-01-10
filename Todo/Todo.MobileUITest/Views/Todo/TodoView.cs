using System;
using Todo.MobileUITest.Views.Common;
using Todo.MobileUITest.Views.Task;

namespace Todo.MobileUITest.Views.Todo
{
    public class TodoView : BasicView
    {
        public TodoViewLocator Locate = new TodoViewLocator();
        public TodoView(AppUser appUser) : base(appUser) { }

        public TaskView TapOnCreateTask()
        {
            App.Tap(Locate.AddButton);
            return new TaskView(AppUser);
        }

        public TaskView TapOnPreviousTaskCreated(string taskName)
        {

            return new TaskView(AppUser);
        }

        public TodoViewChecker Verify()
        {
            return new TodoViewChecker(AppUser);
        }
    }
}
