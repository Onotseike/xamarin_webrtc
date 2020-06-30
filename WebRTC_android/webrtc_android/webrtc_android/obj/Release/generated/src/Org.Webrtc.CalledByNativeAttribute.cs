using System;

namespace Org.Webrtc {

	[global::Android.Runtime.Annotation ("org.webrtc.CalledByNative")]
	public partial class CalledByNativeAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
