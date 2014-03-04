using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Xamarin.Crash {
	public partial class XamarinCrashViewController : UIViewController {

		////////////////////////////////////
		// PROPERTIES
		////////////////////

		private CrashCamera camera;

		////////////////////////////////////
		// CONSTRUCTORS
		////////////////////

		public XamarinCrashViewController(IntPtr handle) : base(handle) {
		}

		////////////////////////////////////
		// METHODS
		////////////////////

		public override void ViewDidLoad() {
			base.ViewDidLoad();

			this.camera = new CrashCamera(delegate {

			});
		}

		partial void CrashButtonClicked(NSObject sender) {
			if (this.camera != null) {
				this.camera.Dispose();
				this.camera = null;
			}
			GC.Collect();
		}

		////////////////////////////////////
		// GETTERS/SETTERS
		////////////////////

	}
}

