using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

using com.badlogic.gdx.backends.ios;
using org.ENSEA-CS.core;

namespace org.ENSEA-CS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : IOSApplication {
		public AppDelegate () : base(new Boggle(), createConfig()) {}

		internal static IOSApplicationConfiguration createConfig () {
			IOSApplicationConfiguration config = new IOSApplicationConfiguration();
			config.orientationLandscape = true;
			config.orientationPortrait = false;
			config.useAccelerometer = true;
			config.useMonotouchOpenTK = true;
			config.useObjectAL = true;
			return config;
		}
	}

	public class Application {
		static void Main (string[] args) {
			UIApplication.Main (args, null, "AppDelegate");
		}
	}
}
