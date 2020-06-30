using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCodecInfo']"
	[global::Android.Runtime.Register ("org/webrtc/VideoCodecInfo", DoNotGenerateAcw=true)]
	public partial class VideoCodecInfo : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCodecInfo']/field[@name='H264_CONSTRAINED_BASELINE_3_1']"
		[Register ("H264_CONSTRAINED_BASELINE_3_1")]
		public const string H264ConstrainedBaseline31 = (string) "42e01f";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCodecInfo']/field[@name='H264_CONSTRAINED_HIGH_3_1']"
		[Register ("H264_CONSTRAINED_HIGH_3_1")]
		public const string H264ConstrainedHigh31 = (string) "640c1f";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCodecInfo']/field[@name='H264_FMTP_LEVEL_ASYMMETRY_ALLOWED']"
		[Register ("H264_FMTP_LEVEL_ASYMMETRY_ALLOWED")]
		public const string H264FmtpLevelAsymmetryAllowed = (string) "level-asymmetry-allowed";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCodecInfo']/field[@name='H264_FMTP_PACKETIZATION_MODE']"
		[Register ("H264_FMTP_PACKETIZATION_MODE")]
		public const string H264FmtpPacketizationMode = (string) "packetization-mode";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCodecInfo']/field[@name='H264_FMTP_PROFILE_LEVEL_ID']"
		[Register ("H264_FMTP_PROFILE_LEVEL_ID")]
		public const string H264FmtpProfileLevelId = (string) "profile-level-id";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCodecInfo']/field[@name='H264_LEVEL_3_1']"
		[Register ("H264_LEVEL_3_1")]
		public const string H264Level31 = (string) "1f";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCodecInfo']/field[@name='H264_PROFILE_CONSTRAINED_BASELINE']"
		[Register ("H264_PROFILE_CONSTRAINED_BASELINE")]
		public const string H264ProfileConstrainedBaseline = (string) "42e0";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCodecInfo']/field[@name='H264_PROFILE_CONSTRAINED_HIGH']"
		[Register ("H264_PROFILE_CONSTRAINED_HIGH")]
		public const string H264ProfileConstrainedHigh = (string) "640c";


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCodecInfo']/field[@name='name']"
		[Register ("name")]
		public string Name {
			get {
				const string __id = "name.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "name.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCodecInfo']/field[@name='params']"
		[Register ("params")]
		public global::System.Collections.IDictionary Params {
			get {
				const string __id = "params.Ljava/util/Map;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "params.Ljava/util/Map;";

				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCodecInfo']/field[@name='payload']"
		[Register ("payload")]
		[Obsolete ("deprecated")]
		public int Payload {
			get {
				const string __id = "payload.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "payload.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoCodecInfo", typeof (VideoCodecInfo));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected VideoCodecInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCodecInfo']/constructor[@name='VideoCodecInfo' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register (".ctor", "(ILjava/lang/String;Ljava/util/Map;)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe VideoCodecInfo (int payload, string name, global::System.Collections.Generic.IDictionary<string, string> @params)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILjava/lang/String;Ljava/util/Map;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native__params = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (@params);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (payload);
				__args [1] = new JniArgumentValue (native_name);
				__args [2] = new JniArgumentValue (native__params);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native__params);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCodecInfo']/constructor[@name='VideoCodecInfo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/util/Map;)V", "")]
		public unsafe VideoCodecInfo (string name, global::System.Collections.Generic.IDictionary<string, string> @params)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/util/Map;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native__params = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (@params);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native__params);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native__params);
			}
		}

	}
}
