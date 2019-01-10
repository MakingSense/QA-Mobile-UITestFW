using System;
using System.IO;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Todo.MobileUITest
{
	public class AppInitializer
	{
        public static IApp StartApp(Platform platform)
        {
            switch (platform)
            {
                case Platform.Android:
                    const string apkRelativePath = "../../app/Todo.Android.apk";
                    var apkPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, apkRelativePath);

                    return ConfigureApp
                        .Android
                        .ApkFile(apkPath)
                        .StartApp();

                case Platform.iOS:
                    const string appRelativePath = "/Users/celestesenoseain/dev/Todo/Todo.iOS/bin/iPhoneSimulator/Debug/device-builds/iphone11.8-12.1/TodoiOS.app";
                    //   var appPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, appRelativePath);
                    var appPath = appRelativePath;

                    return ConfigureApp
                        .iOS
                        .Debug()
                        .AppBundle(appPath)
                        .StartApp();

                default:
                    throw new ArgumentOutOfRangeException(nameof(platform), platform, null);
            }
        }
    }
}