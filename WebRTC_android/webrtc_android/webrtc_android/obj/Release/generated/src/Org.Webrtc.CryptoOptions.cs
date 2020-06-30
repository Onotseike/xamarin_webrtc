using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='CryptoOptions']"
	[global::Android.Runtime.Register ("org/webrtc/CryptoOptions", DoNotGenerateAcw=true)]
	public sealed partial class CryptoOptions : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='CryptoOptions.Builder']"
		[global::Android.Runtime.Register ("org/webrtc/CryptoOptions$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/CryptoOptions$Builder", typeof (Builder));
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

			static Delegate cb_createCryptoOptions;
#pragma warning disable 0169
			static Delegate GetCreateCryptoOptionsHandler ()
			{
				if (cb_createCryptoOptions == null)
					cb_createCryptoOptions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreateCryptoOptions);
				return cb_createCryptoOptions;
			}

			static IntPtr n_CreateCryptoOptions (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.CryptoOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.CryptoOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.CreateCryptoOptions ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='CryptoOptions.Builder']/method[@name='createCryptoOptions' and count(parameter)=0]"
			[Register ("createCryptoOptions", "()Lorg/webrtc/CryptoOptions;", "GetCreateCryptoOptionsHandler")]
			public virtual unsafe global::Org.Webrtc.CryptoOptions CreateCryptoOptions ()
			{
				const string __id = "createCryptoOptions.()Lorg/webrtc/CryptoOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.CryptoOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setEnableAes128Sha1_32CryptoCipher_Z;
#pragma warning disable 0169
			static Delegate GetSetEnableAes128Sha1_32CryptoCipher_ZHandler ()
			{
				if (cb_setEnableAes128Sha1_32CryptoCipher_Z == null)
					cb_setEnableAes128Sha1_32CryptoCipher_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetEnableAes128Sha1_32CryptoCipher_Z);
				return cb_setEnableAes128Sha1_32CryptoCipher_Z;
			}

			static IntPtr n_SetEnableAes128Sha1_32CryptoCipher_Z (IntPtr jnienv, IntPtr native__this, bool enableAes128Sha1_32CryptoCipher)
			{
				global::Org.Webrtc.CryptoOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.CryptoOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetEnableAes128Sha1_32CryptoCipher (enableAes128Sha1_32CryptoCipher));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='CryptoOptions.Builder']/method[@name='setEnableAes128Sha1_32CryptoCipher' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEnableAes128Sha1_32CryptoCipher", "(Z)Lorg/webrtc/CryptoOptions$Builder;", "GetSetEnableAes128Sha1_32CryptoCipher_ZHandler")]
			public virtual unsafe global::Org.Webrtc.CryptoOptions.Builder SetEnableAes128Sha1_32CryptoCipher (bool enableAes128Sha1_32CryptoCipher)
			{
				const string __id = "setEnableAes128Sha1_32CryptoCipher.(Z)Lorg/webrtc/CryptoOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (enableAes128Sha1_32CryptoCipher);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.CryptoOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setEnableEncryptedRtpHeaderExtensions_Z;
#pragma warning disable 0169
			static Delegate GetSetEnableEncryptedRtpHeaderExtensions_ZHandler ()
			{
				if (cb_setEnableEncryptedRtpHeaderExtensions_Z == null)
					cb_setEnableEncryptedRtpHeaderExtensions_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetEnableEncryptedRtpHeaderExtensions_Z);
				return cb_setEnableEncryptedRtpHeaderExtensions_Z;
			}

			static IntPtr n_SetEnableEncryptedRtpHeaderExtensions_Z (IntPtr jnienv, IntPtr native__this, bool enableEncryptedRtpHeaderExtensions)
			{
				global::Org.Webrtc.CryptoOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.CryptoOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetEnableEncryptedRtpHeaderExtensions (enableEncryptedRtpHeaderExtensions));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='CryptoOptions.Builder']/method[@name='setEnableEncryptedRtpHeaderExtensions' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEnableEncryptedRtpHeaderExtensions", "(Z)Lorg/webrtc/CryptoOptions$Builder;", "GetSetEnableEncryptedRtpHeaderExtensions_ZHandler")]
			public virtual unsafe global::Org.Webrtc.CryptoOptions.Builder SetEnableEncryptedRtpHeaderExtensions (bool enableEncryptedRtpHeaderExtensions)
			{
				const string __id = "setEnableEncryptedRtpHeaderExtensions.(Z)Lorg/webrtc/CryptoOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (enableEncryptedRtpHeaderExtensions);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.CryptoOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setEnableGcmCryptoSuites_Z;
#pragma warning disable 0169
			static Delegate GetSetEnableGcmCryptoSuites_ZHandler ()
			{
				if (cb_setEnableGcmCryptoSuites_Z == null)
					cb_setEnableGcmCryptoSuites_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetEnableGcmCryptoSuites_Z);
				return cb_setEnableGcmCryptoSuites_Z;
			}

			static IntPtr n_SetEnableGcmCryptoSuites_Z (IntPtr jnienv, IntPtr native__this, bool enableGcmCryptoSuites)
			{
				global::Org.Webrtc.CryptoOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.CryptoOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetEnableGcmCryptoSuites (enableGcmCryptoSuites));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='CryptoOptions.Builder']/method[@name='setEnableGcmCryptoSuites' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEnableGcmCryptoSuites", "(Z)Lorg/webrtc/CryptoOptions$Builder;", "GetSetEnableGcmCryptoSuites_ZHandler")]
			public virtual unsafe global::Org.Webrtc.CryptoOptions.Builder SetEnableGcmCryptoSuites (bool enableGcmCryptoSuites)
			{
				const string __id = "setEnableGcmCryptoSuites.(Z)Lorg/webrtc/CryptoOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (enableGcmCryptoSuites);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.CryptoOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setRequireFrameEncryption_Z;
#pragma warning disable 0169
			static Delegate GetSetRequireFrameEncryption_ZHandler ()
			{
				if (cb_setRequireFrameEncryption_Z == null)
					cb_setRequireFrameEncryption_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetRequireFrameEncryption_Z);
				return cb_setRequireFrameEncryption_Z;
			}

			static IntPtr n_SetRequireFrameEncryption_Z (IntPtr jnienv, IntPtr native__this, bool requireFrameEncryption)
			{
				global::Org.Webrtc.CryptoOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.CryptoOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetRequireFrameEncryption (requireFrameEncryption));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='CryptoOptions.Builder']/method[@name='setRequireFrameEncryption' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRequireFrameEncryption", "(Z)Lorg/webrtc/CryptoOptions$Builder;", "GetSetRequireFrameEncryption_ZHandler")]
			public virtual unsafe global::Org.Webrtc.CryptoOptions.Builder SetRequireFrameEncryption (bool requireFrameEncryption)
			{
				const string __id = "setRequireFrameEncryption.(Z)Lorg/webrtc/CryptoOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (requireFrameEncryption);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.CryptoOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='CryptoOptions.SFrame']"
		[global::Android.Runtime.Register ("org/webrtc/CryptoOptions$SFrame", DoNotGenerateAcw=true)]
		public sealed partial class SFrame : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/CryptoOptions$SFrame", typeof (SFrame));
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

			internal SFrame (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			public unsafe bool RequireFrameEncryption {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='CryptoOptions.SFrame']/method[@name='getRequireFrameEncryption' and count(parameter)=0]"
				[Register ("getRequireFrameEncryption", "()Z", "")]
				get {
					const string __id = "getRequireFrameEncryption.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='CryptoOptions.Srtp']"
		[global::Android.Runtime.Register ("org/webrtc/CryptoOptions$Srtp", DoNotGenerateAcw=true)]
		public sealed partial class Srtp : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/CryptoOptions$Srtp", typeof (Srtp));
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

			internal Srtp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			public unsafe bool EnableAes128Sha1_32CryptoCipher {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='CryptoOptions.Srtp']/method[@name='getEnableAes128Sha1_32CryptoCipher' and count(parameter)=0]"
				[Register ("getEnableAes128Sha1_32CryptoCipher", "()Z", "")]
				get {
					const string __id = "getEnableAes128Sha1_32CryptoCipher.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe bool EnableEncryptedRtpHeaderExtensions {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='CryptoOptions.Srtp']/method[@name='getEnableEncryptedRtpHeaderExtensions' and count(parameter)=0]"
				[Register ("getEnableEncryptedRtpHeaderExtensions", "()Z", "")]
				get {
					const string __id = "getEnableEncryptedRtpHeaderExtensions.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe bool EnableGcmCryptoSuites {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='CryptoOptions.Srtp']/method[@name='getEnableGcmCryptoSuites' and count(parameter)=0]"
				[Register ("getEnableGcmCryptoSuites", "()Z", "")]
				get {
					const string __id = "getEnableGcmCryptoSuites.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/CryptoOptions", typeof (CryptoOptions));
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

		internal CryptoOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='CryptoOptions']/method[@name='builder' and count(parameter)=0]"
		[Register ("builder", "()Lorg/webrtc/CryptoOptions$Builder;", "")]
		public static unsafe global::Org.Webrtc.CryptoOptions.Builder InvokeBuilder ()
		{
			const string __id = "builder.()Lorg/webrtc/CryptoOptions$Builder;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.CryptoOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='CryptoOptions']/method[@name='getSFrame' and count(parameter)=0]"
		[Register ("getSFrame", "()Lorg/webrtc/CryptoOptions$SFrame;", "")]
		public unsafe global::Org.Webrtc.CryptoOptions.SFrame GetSFrame ()
		{
			const string __id = "getSFrame.()Lorg/webrtc/CryptoOptions$SFrame;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.CryptoOptions.SFrame> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='CryptoOptions']/method[@name='getSrtp' and count(parameter)=0]"
		[Register ("getSrtp", "()Lorg/webrtc/CryptoOptions$Srtp;", "")]
		public unsafe global::Org.Webrtc.CryptoOptions.Srtp GetSrtp ()
		{
			const string __id = "getSrtp.()Lorg/webrtc/CryptoOptions$Srtp;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.CryptoOptions.Srtp> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
