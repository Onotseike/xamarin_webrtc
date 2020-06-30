using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='RtcCertificatePem']"
	[global::Android.Runtime.Register ("org/webrtc/RtcCertificatePem", DoNotGenerateAcw=true)]
	public partial class RtcCertificatePem : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='RtcCertificatePem']/field[@name='certificate']"
		[Register ("certificate")]
		public string Certificate {
			get {
				const string __id = "certificate.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "certificate.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='RtcCertificatePem']/field[@name='privateKey']"
		[Register ("privateKey")]
		public string PrivateKey {
			get {
				const string __id = "privateKey.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "privateKey.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/RtcCertificatePem", typeof (RtcCertificatePem));
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

		protected RtcCertificatePem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='RtcCertificatePem']/constructor[@name='RtcCertificatePem' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe RtcCertificatePem (string privateKey, string certificate)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_privateKey = JNIEnv.NewString (privateKey);
			IntPtr native_certificate = JNIEnv.NewString (certificate);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_privateKey);
				__args [1] = new JniArgumentValue (native_certificate);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_privateKey);
				JNIEnv.DeleteLocalRef (native_certificate);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtcCertificatePem']/method[@name='generateCertificate' and count(parameter)=0]"
		[Register ("generateCertificate", "()Lorg/webrtc/RtcCertificatePem;", "")]
		public static unsafe global::Org.Webrtc.RtcCertificatePem GenerateCertificate ()
		{
			const string __id = "generateCertificate.()Lorg/webrtc/RtcCertificatePem;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtcCertificatePem> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtcCertificatePem']/method[@name='generateCertificate' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("generateCertificate", "(J)Lorg/webrtc/RtcCertificatePem;", "")]
		public static unsafe global::Org.Webrtc.RtcCertificatePem GenerateCertificate (long expires)
		{
			const string __id = "generateCertificate.(J)Lorg/webrtc/RtcCertificatePem;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (expires);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtcCertificatePem> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtcCertificatePem']/method[@name='generateCertificate' and count(parameter)=1 and parameter[1][@type='org.webrtc.PeerConnection.KeyType']]"
		[Register ("generateCertificate", "(Lorg/webrtc/PeerConnection$KeyType;)Lorg/webrtc/RtcCertificatePem;", "")]
		public static unsafe global::Org.Webrtc.RtcCertificatePem GenerateCertificate (global::Org.Webrtc.PeerConnection.KeyType keyType)
		{
			const string __id = "generateCertificate.(Lorg/webrtc/PeerConnection$KeyType;)Lorg/webrtc/RtcCertificatePem;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((keyType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) keyType).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtcCertificatePem> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtcCertificatePem']/method[@name='generateCertificate' and count(parameter)=2 and parameter[1][@type='org.webrtc.PeerConnection.KeyType'] and parameter[2][@type='long']]"
		[Register ("generateCertificate", "(Lorg/webrtc/PeerConnection$KeyType;J)Lorg/webrtc/RtcCertificatePem;", "")]
		public static unsafe global::Org.Webrtc.RtcCertificatePem GenerateCertificate (global::Org.Webrtc.PeerConnection.KeyType keyType, long expires)
		{
			const string __id = "generateCertificate.(Lorg/webrtc/PeerConnection$KeyType;J)Lorg/webrtc/RtcCertificatePem;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((keyType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) keyType).Handle);
				__args [1] = new JniArgumentValue (expires);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtcCertificatePem> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
