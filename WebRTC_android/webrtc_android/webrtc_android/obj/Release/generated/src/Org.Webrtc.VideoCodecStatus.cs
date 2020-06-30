using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCodecStatus']"
	[global::Android.Runtime.Register ("org/webrtc/VideoCodecStatus", DoNotGenerateAcw=true)]
	public sealed partial class VideoCodecStatus : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCodecStatus']/field[@name='ERROR']"
		[Register ("ERROR")]
		public static global::Org.Webrtc.VideoCodecStatus Error {
			get {
				const string __id = "ERROR.Lorg/webrtc/VideoCodecStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCodecStatus']/field[@name='ERR_PARAMETER']"
		[Register ("ERR_PARAMETER")]
		public static global::Org.Webrtc.VideoCodecStatus ErrParameter {
			get {
				const string __id = "ERR_PARAMETER.Lorg/webrtc/VideoCodecStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCodecStatus']/field[@name='ERR_REQUEST_SLI']"
		[Register ("ERR_REQUEST_SLI")]
		public static global::Org.Webrtc.VideoCodecStatus ErrRequestSli {
			get {
				const string __id = "ERR_REQUEST_SLI.Lorg/webrtc/VideoCodecStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCodecStatus']/field[@name='ERR_SIZE']"
		[Register ("ERR_SIZE")]
		public static global::Org.Webrtc.VideoCodecStatus ErrSize {
			get {
				const string __id = "ERR_SIZE.Lorg/webrtc/VideoCodecStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCodecStatus']/field[@name='FALLBACK_SOFTWARE']"
		[Register ("FALLBACK_SOFTWARE")]
		public static global::Org.Webrtc.VideoCodecStatus FallbackSoftware {
			get {
				const string __id = "FALLBACK_SOFTWARE.Lorg/webrtc/VideoCodecStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCodecStatus']/field[@name='LEVEL_EXCEEDED']"
		[Register ("LEVEL_EXCEEDED")]
		public static global::Org.Webrtc.VideoCodecStatus LevelExceeded {
			get {
				const string __id = "LEVEL_EXCEEDED.Lorg/webrtc/VideoCodecStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCodecStatus']/field[@name='MEMORY']"
		[Register ("MEMORY")]
		public static global::Org.Webrtc.VideoCodecStatus Memory {
			get {
				const string __id = "MEMORY.Lorg/webrtc/VideoCodecStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCodecStatus']/field[@name='NO_OUTPUT']"
		[Register ("NO_OUTPUT")]
		public static global::Org.Webrtc.VideoCodecStatus NoOutput {
			get {
				const string __id = "NO_OUTPUT.Lorg/webrtc/VideoCodecStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCodecStatus']/field[@name='OK']"
		[Register ("OK")]
		public static global::Org.Webrtc.VideoCodecStatus Ok {
			get {
				const string __id = "OK.Lorg/webrtc/VideoCodecStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCodecStatus']/field[@name='REQUEST_SLI']"
		[Register ("REQUEST_SLI")]
		public static global::Org.Webrtc.VideoCodecStatus RequestSli {
			get {
				const string __id = "REQUEST_SLI.Lorg/webrtc/VideoCodecStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCodecStatus']/field[@name='TARGET_BITRATE_OVERSHOOT']"
		[Register ("TARGET_BITRATE_OVERSHOOT")]
		public static global::Org.Webrtc.VideoCodecStatus TargetBitrateOvershoot {
			get {
				const string __id = "TARGET_BITRATE_OVERSHOOT.Lorg/webrtc/VideoCodecStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCodecStatus']/field[@name='TIMEOUT']"
		[Register ("TIMEOUT")]
		public static global::Org.Webrtc.VideoCodecStatus Timeout {
			get {
				const string __id = "TIMEOUT.Lorg/webrtc/VideoCodecStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCodecStatus']/field[@name='UNINITIALIZED']"
		[Register ("UNINITIALIZED")]
		public static global::Org.Webrtc.VideoCodecStatus Uninitialized {
			get {
				const string __id = "UNINITIALIZED.Lorg/webrtc/VideoCodecStatus;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoCodecStatus", typeof (VideoCodecStatus));
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

		internal VideoCodecStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe int Number {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCodecStatus']/method[@name='getNumber' and count(parameter)=0]"
			[Register ("getNumber", "()I", "")]
			get {
				const string __id = "getNumber.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCodecStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/VideoCodecStatus;", "")]
		public static unsafe global::Org.Webrtc.VideoCodecStatus ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lorg/webrtc/VideoCodecStatus;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCodecStatus']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/webrtc/VideoCodecStatus;", "")]
		public static unsafe global::Org.Webrtc.VideoCodecStatus[] Values ()
		{
			const string __id = "values.()[Lorg/webrtc/VideoCodecStatus;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Org.Webrtc.VideoCodecStatus[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.VideoCodecStatus));
			} finally {
			}
		}

	}
}
