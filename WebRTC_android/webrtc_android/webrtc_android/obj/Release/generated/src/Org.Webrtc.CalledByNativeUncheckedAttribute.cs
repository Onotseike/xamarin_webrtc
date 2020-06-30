using System;

namespace Org.Webrtc {

	[global::Android.Runtime.Annotation ("org.webrtc.CalledByNativeUnchecked")]
	public partial class CalledByNativeUncheckedAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
