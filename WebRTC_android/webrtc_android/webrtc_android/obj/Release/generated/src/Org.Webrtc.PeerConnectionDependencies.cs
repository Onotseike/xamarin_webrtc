using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionDependencies']"
	[global::Android.Runtime.Register ("org/webrtc/PeerConnectionDependencies", DoNotGenerateAcw=true)]
	public sealed partial class PeerConnectionDependencies : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionDependencies.Builder']"
		[global::Android.Runtime.Register ("org/webrtc/PeerConnectionDependencies$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/PeerConnectionDependencies$Builder", typeof (Builder));
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

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_createPeerConnectionDependencies;
#pragma warning disable 0169
			static Delegate GetCreatePeerConnectionDependenciesHandler ()
			{
				if (cb_createPeerConnectionDependencies == null)
					cb_createPeerConnectionDependencies = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreatePeerConnectionDependencies);
				return cb_createPeerConnectionDependencies;
			}

			static IntPtr n_CreatePeerConnectionDependencies (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.PeerConnectionDependencies.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionDependencies.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.CreatePeerConnectionDependencies ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionDependencies.Builder']/method[@name='createPeerConnectionDependencies' and count(parameter)=0]"
			[Register ("createPeerConnectionDependencies", "()Lorg/webrtc/PeerConnectionDependencies;", "GetCreatePeerConnectionDependenciesHandler")]
			public virtual unsafe global::Org.Webrtc.PeerConnectionDependencies CreatePeerConnectionDependencies ()
			{
				const string __id = "createPeerConnectionDependencies.()Lorg/webrtc/PeerConnectionDependencies;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionDependencies> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setSSLCertificateVerifier_Lorg_webrtc_SSLCertificateVerifier_;
#pragma warning disable 0169
			static Delegate GetSetSSLCertificateVerifier_Lorg_webrtc_SSLCertificateVerifier_Handler ()
			{
				if (cb_setSSLCertificateVerifier_Lorg_webrtc_SSLCertificateVerifier_ == null)
					cb_setSSLCertificateVerifier_Lorg_webrtc_SSLCertificateVerifier_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetSSLCertificateVerifier_Lorg_webrtc_SSLCertificateVerifier_);
				return cb_setSSLCertificateVerifier_Lorg_webrtc_SSLCertificateVerifier_;
			}

			static IntPtr n_SetSSLCertificateVerifier_Lorg_webrtc_SSLCertificateVerifier_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sslCertificateVerifier)
			{
				global::Org.Webrtc.PeerConnectionDependencies.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionDependencies.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.ISSLCertificateVerifier sslCertificateVerifier = (global::Org.Webrtc.ISSLCertificateVerifier)global::Java.Lang.Object.GetObject<global::Org.Webrtc.ISSLCertificateVerifier> (native_sslCertificateVerifier, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSSLCertificateVerifier (sslCertificateVerifier));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionDependencies.Builder']/method[@name='setSSLCertificateVerifier' and count(parameter)=1 and parameter[1][@type='org.webrtc.SSLCertificateVerifier']]"
			[Register ("setSSLCertificateVerifier", "(Lorg/webrtc/SSLCertificateVerifier;)Lorg/webrtc/PeerConnectionDependencies$Builder;", "GetSetSSLCertificateVerifier_Lorg_webrtc_SSLCertificateVerifier_Handler")]
			public virtual unsafe global::Org.Webrtc.PeerConnectionDependencies.Builder SetSSLCertificateVerifier (global::Org.Webrtc.ISSLCertificateVerifier sslCertificateVerifier)
			{
				const string __id = "setSSLCertificateVerifier.(Lorg/webrtc/SSLCertificateVerifier;)Lorg/webrtc/PeerConnectionDependencies$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((sslCertificateVerifier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sslCertificateVerifier).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionDependencies.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/PeerConnectionDependencies", typeof (PeerConnectionDependencies));
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

		internal PeerConnectionDependencies (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionDependencies']/method[@name='builder' and count(parameter)=1 and parameter[1][@type='org.webrtc.PeerConnection.Observer']]"
		[Register ("builder", "(Lorg/webrtc/PeerConnection$Observer;)Lorg/webrtc/PeerConnectionDependencies$Builder;", "")]
		public static unsafe global::Org.Webrtc.PeerConnectionDependencies.Builder InvokeBuilder (global::Org.Webrtc.PeerConnection.IObserver observer)
		{
			const string __id = "builder.(Lorg/webrtc/PeerConnection$Observer;)Lorg/webrtc/PeerConnectionDependencies$Builder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((observer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) observer).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionDependencies.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
