#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __NETSTD_REFERENCE__ || __MACOS__
	public delegate global::Windows.Foundation.IAsyncOperation<object> ListViewKeyToItemHandler(string @key);
	#endif
}
