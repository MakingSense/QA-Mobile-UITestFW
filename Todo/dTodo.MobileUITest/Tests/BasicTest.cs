using System.Collections.Generic;
using NUnit.Framework;
using Todo.MobileUITest.Views.Common;

namespace Todo.MobileUITest.Tests
{
    [TestFixture]

    public class BasicTest : UITest
    {
        [Test]
        [Description("Create a simple Task and verify the task exists")]
        public void CreateTaskTest()
        {
            App
                .VisitTodoView()
                .TapOnCreateTask()
                .EnterTaskName()
                .EnterTaskNotes()
                .TapOnSaveButtonAndGoToHome()
                .Verify().YourRecentlyTaskIsShown();
        }

        [Test]
        [Description("Create a simple Task, delete the task created and verify the task does not exist")]
        public void CreateAndDeleteTaskTest()
        {
            App
                .VisitTodoView()
                .TapOnCreateTask()
                .EnterTaskName("Buy_apples")
                .EnterTaskNotes("Buy_apples_notes")
                .TapOnSaveButtonAndGoToHome()
                .TapOnPreviousTaskCreated("Buy_apples")
                .TapOnDeleteButtonAndGoToHome()
                .Verify().YourRecentlyTaskIsNOTShown("Buy_apples");
        }

        [Test]
        [Description("Create a multiple Tasks and verify all tasks exist")]
        public void CreateMultipleTaskTest()
        {
            App
                .VisitTodoView()
                .TapOnCreateTask()
                .EnterTaskName("Buy_orange")
                .EnterTaskNotes("Buy_orange_notes")
                .TapOnSaveButtonAndGoToHome()
                .TapOnCreateTask()
                .EnterTaskName("Buy_apples")
                .EnterTaskNotes("Buy_apples_notes")
                .TapOnSaveButtonAndGoToHome()
                .TapOnCreateTask()
                .EnterTaskName("Buy_milk")
                .EnterTaskNotes("Buy_milk_notes")
                .TapOnSaveButtonAndGoToHome()
                .Verify().YourAllRecentlyTasksAreShown(new List<string> { "Buy_orange", "Buy_apples", "Buy_milk" });
        }

        [Test]
        [Description("Create a simple Task with DONE status and verify")]
        public void CreateTaskDoneTest()
        {
            App
                .VisitTodoView()
                .TapOnCreateTask()
                .EnterTaskName()
                .EnterTaskNotes()
                .SwitchOnDone()
                .TapOnSaveButtonAndGoToHome()
                .Verify().YourRecentlyTaskIsDone();
        }
    }
}
