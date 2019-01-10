using System;
using Xamarin.UITest.Queries;

namespace Todo.MobileUITest.Views.Todo
{
    public class TodoViewLocator
    {
        public Func<AppQuery, AppQuery> AddButton { get; } =
          new Func<AppQuery, AppQuery>(c => c.Id("NoResourceEntry-0"));

        public Func<AppQuery, AppQuery> TasksList { get; } =
          new Func<AppQuery, AppQuery>(c => c.Id("NoResourceEntry-3"));
    }
}
