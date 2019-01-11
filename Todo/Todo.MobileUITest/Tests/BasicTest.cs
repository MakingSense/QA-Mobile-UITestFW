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
                .EnterTaskName("Task_Name")
                .EnterTaskNotes("Task_Notes")
                .TapOnSaveButtonAndGoToHome()
                .TapOnPreviousTaskCreated("Task_Name")
                .TapOnDeleteButtonAndGoToHome()
                .Verify().YourRecentlyTaskIsNOTShown("Task_Name");
        }

        [Test]
        [Description("Create a multiple Tasks and verify all tasks exist")]
        public void CreateMultipleTaskTest()
        {
            App
                .VisitTodoView()
                .TapOnCreateTask()
                .EnterTaskName("Task_1")
                .EnterTaskNotes("Task_Notes_1")
                .TapOnSaveButtonAndGoToHome()
                .TapOnCreateTask()
                .EnterTaskName("Task_2")
                .EnterTaskNotes("Task_Notes_2")
                .TapOnSaveButtonAndGoToHome()
                .TapOnCreateTask()
                .EnterTaskName("Task_3")
                .EnterTaskNotes("Task_Notes_3")
                .TapOnSaveButtonAndGoToHome()
                .Verify().YourAllRecentlyTasksAreShown(new List<string> { "Task_1", "Task_2", "Task_3" });
        }
    }
}
