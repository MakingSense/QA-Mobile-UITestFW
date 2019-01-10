using System;
using Todo.MobileUITest.Views.Todo;
using Xamarin.UITest;

namespace Todo.MobileUITest.Views.Common
{
    public class AppUser
    {
        public AppUser()
        {
            Platform = GetSelectedPlatform();
            App = AppInitializer.StartApp(Platform);
        }

        public Platform Platform { get; }

        public IApp App { get; }

        public TodoView VisitTodoView() => new TodoView(this);

        private Platform GetSelectedPlatform()
        {
            if (!Enum.TryParse(System.Configuration.ConfigurationManager.AppSettings["platform"], true, out Platform platform))
            {
                throw new Exception("A platform must be specified in App.config");
            }
            return Platform.iOS;
        }
    }
}
