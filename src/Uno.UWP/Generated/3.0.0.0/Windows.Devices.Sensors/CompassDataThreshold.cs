#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Sensors
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompassDataThreshold 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double Degrees
		{
			get
			{
				throw new global::System.NotImplementedException("The member double CompassDataThreshold.Degrees is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.CompassDataThreshold", "double CompassDataThreshold.Degrees");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Sensors.CompassDataThreshold.Degrees.get
		// Forced skipping of method Windows.Devices.Sensors.CompassDataThreshold.Degrees.set
	}
}
