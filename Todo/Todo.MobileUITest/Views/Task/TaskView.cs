using System;
using Todo.MobileUITest.Views.Common;
using Todo.MobileUITest.Views.Todo;

namespace Todo.MobileUITest.Views.Task
{
    public class TaskView : BasicView
    {
        public TaskViewLocator Locate = new TaskViewLocator();
        public TaskView(AppUser appUser) : base(appUser)
        {
            Locate = new TaskViewLocator();
            Locate.CreateInstance(AppUser.Platform);
        }

        public TaskView EnterTaskName(string name = "Test")
        {
            App.WaitForElement(Locate.NameField, $"Timed out waiting for element {Locate.NameField}",
               TimeSpan.FromSeconds(60));
            App.ClearText(Locate.NameField);
            App.EnterText(Locate.NameField, name);
            return this;
        }

        public TaskView EnterTaskNotes(string notes = "Test Notes")
        {
            App.ClearText(Locate.NotesField);
            App.EnterText(Locate.NotesField, notes);
            return this;
        }

        public TaskView SwitchOnDone()
        {
            App.Tap(Locate.DoneSwitch);
            return this;
        }

        public TodoView TapOnSaveButtonAndGoToHome()
        {
            App.Tap(Locate.SaveButton);
            return new TodoView(AppUser);
        }

        public TodoView TapOnDeleteButtonAndGoToHome()
        {
            App.Tap(Locate.DeleteButton);
            return new TodoView(AppUser);
        }

        public TodoView TapOnCancelButtonAndGoToHome()
        {
            App.Tap(Locate.CancelButton);
            return new TodoView(AppUser);
        }

    }
}
