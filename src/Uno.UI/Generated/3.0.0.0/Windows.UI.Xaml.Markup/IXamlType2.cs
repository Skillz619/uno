#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Markup
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IXamlType2 : global::Windows.UI.Xaml.Markup.IXamlType
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Windows.UI.Xaml.Markup.IXamlType BoxedType
		{
			get;
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Markup.IXamlType2.BoxedType.get
	}
}
