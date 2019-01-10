using System;
using Xamarin.UITest.Queries;

namespace Todo.MobileUITest.Views.Task
{
    public class TaskViewLocator
    {
        public Func<AppQuery, AppQuery> NameText { get; } =
          new Func<AppQuery, AppQuery>(c => c.Id("NoResourceEntry-6"));

        public Func<AppQuery, AppQuery> NameField { get; } =
           new Func<AppQuery, AppQuery>(c => c.Id("NoResourceEntry-7"));

        public Func<AppQuery, AppQuery> NotesText { get; } =
           new Func<AppQuery, AppQuery>(c => c.Id("NoResourceEntry-8"));
        public Func<AppQuery, AppQuery> NotesField { get; } =
           new Func<AppQuery, AppQuery>(c => c.Id("NoResourceEntry-9"));

        public Func<AppQuery, AppQuery> SaveButton { get; } =
           new Func<AppQuery, AppQuery>(c => c.Id("NoResourceEntry-12"));

        public Func<AppQuery, AppQuery> DeleteButton { get; } =
            new Func<AppQuery, AppQuery>(c => c.Id("NoResourceEntry-13"));

        public Func<AppQuery, AppQuery> CancelButton { get; } =
          new Func<AppQuery, AppQuery>(c => c.Id("NoResourceEntry-14"));

    }
}
