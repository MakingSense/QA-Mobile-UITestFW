using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Todo.MobileUITest.Views.Task
{
    public class TaskViewLocator
    {
        public Func<AppQuery, AppQuery> NameText { get; set; }
        public Func<AppQuery, AppQuery> NameField { get; set; }
           
        public Func<AppQuery, AppQuery> NotesText { get; set; }
        public Func<AppQuery, AppQuery> NotesField { get; set; } 
           

        public Func<AppQuery, AppQuery> SaveButton { get; set; }
        public Func<AppQuery, AppQuery> DeleteButton { get; set; } 
        public Func<AppQuery, AppQuery> CancelButton { get; set; } 
 
        public TaskViewLocator CreateInstance(Platform platform)
        {
            if (platform == Platform.Android)
            {

                NameText = c => c.Id("NoResourceEntry-6");
                NameField = c => c.Id("NoResourceEntry-7");
                NotesText = c => c.Id("NoResourceEntry-8");
                NotesField = c => c.Id("NoResourceEntry-9");
                SaveButton = c => c.Marked("SaveButton_Container");
                DeleteButton = c => c.Marked("DeleteButton_Container");
                CancelButton = c => c.Marked("CancelButton_Container");
            }
            else
            {
                NameText = c => c.Text("Name");
                NameField = c => c.Id("NameField");
                NotesText = c => c.Text("Note");
                NotesField = c => c.Id("NotesField");
                SaveButton = c => c.Id("SaveButton");
                DeleteButton = c => c.Id("DeleteButton");
                CancelButton = c => c.Id("CancelButton");
            }
            return this;
        }
    }

}