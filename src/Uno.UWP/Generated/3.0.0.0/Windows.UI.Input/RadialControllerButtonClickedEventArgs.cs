#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Input
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RadialControllerButtonClickedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Input.RadialControllerScreenContact Contact
		{
			get
			{
				throw new global::System.NotImplementedException("The member RadialControllerScreenContact RadialControllerButtonClickedEventArgs.Contact is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.Haptics.SimpleHapticsController SimpleHapticsController
		{
			get
			{
				throw new global::System.NotImplementedException("The member SimpleHapticsController RadialControllerButtonClickedEventArgs.SimpleHapticsController is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Input.RadialControllerButtonClickedEventArgs.Contact.get
		// Forced skipping of method Windows.UI.Input.RadialControllerButtonClickedEventArgs.SimpleHapticsController.get
	}
}
