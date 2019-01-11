﻿using NUnit.Framework;
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
    }
}
