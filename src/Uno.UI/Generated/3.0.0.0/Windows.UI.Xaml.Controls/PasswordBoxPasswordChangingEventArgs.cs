#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PasswordBoxPasswordChangingEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsContentChanging
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool PasswordBoxPasswordChangingEventArgs.IsContentChanging is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.PasswordBoxPasswordChangingEventArgs.IsContentChanging.get
	}
}
