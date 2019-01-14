using Xamarin.UITest;

namespace Todo.Mobile.UITests.Views.Common
{
    public class BasicViewChecker
    {

            protected BasicViewChecker(AppUser appUser)
            {
                AppUser = appUser;
            }

            public AppUser AppUser { get; }

            public IApp App => AppUser.App;


    }
}
