using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using Xamarin.UITest.Queries;

namespace UITest.HAK
{
	[TestFixture]
	public class Tests
	{
		AndroidApp app;

		[SetUp]
		public void BeforeEachTest()
		{
			// TODO: If the Android app being tested is included in the solution then open
			// the Unit Tests window, right click Test Apps, select Add App Project
			// and select the app projects that should be tested.
			app = ConfigureApp
				.Android
				// TODO: Update this path to point to your Android app and uncomment the
				// code if the app is not included in the solution.
				.ApkFile (@"D:\lara\HolisticWare.Talks.CASE28\samples\app-files-native\Android\com.infinum.hak-1\base.apk")
				.StartApp();
			app.DismissKeyboard();

			app.EnterText(c => c.Marked("cellphone_number_text_view"), "823472984723947"); ;
			app.DismissKeyboard(); ;
			app.EnterText(c => c.Marked("name_and_surname_text_view"), "Jana Bajzek"); ;
			app.DismissKeyboard(); ;
			app.EnterText(c => c.Marked("plate_number_text_view"), "ZG43214P"); ;
			app.DismissKeyboard(); ;
			app.EnterText(c => c.Marked("hak_club_number_text_view"), "9832234"); ;
			app.ScrollDownTo(c => c.Marked("save_image_button")); ;
			                            app.DismissKeyboard(); ;
			app.Tap(c => c.Marked("save_image_button")); ;
			app.Tap(c => c.Marked("button1")); ;

			app.Repl();

			return;

		}

		[Test]
		public void AppLaunches()
		{
			app.Screenshot("First screen.");
		}
	}
}

