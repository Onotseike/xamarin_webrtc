using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='BuiltinAudioEncoderFactoryFactory']"
	[global::Android.Runtime.Register ("org/webrtc/BuiltinAudioEncoderFactoryFactory", DoNotGenerateAcw=true)]
	public partial class BuiltinAudioEncoderFactoryFactory : global::Java.Lang.Object, global::Org.Webrtc.IAudioEncoderFactoryFactory {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/BuiltinAudioEncoderFactoryFactory", typeof (BuiltinAudioEncoderFactoryFactory));
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

		protected BuiltinAudioEncoderFactoryFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='BuiltinAudioEncoderFactoryFactory']/constructor[@name='BuiltinAudioEncoderFactoryFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BuiltinAudioEncoderFactoryFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_createNativeAudioEncoderFactory;
#pragma warning disable 0169
		static Delegate GetCreateNativeAudioEncoderFactoryHandler ()
		{
			if (cb_createNativeAudioEncoderFactory == null)
				cb_createNativeAudioEncoderFactory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_CreateNativeAudioEncoderFactory);
			return cb_createNativeAudioEncoderFactory;
		}

		static long n_CreateNativeAudioEncoderFactory (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.BuiltinAudioEncoderFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.BuiltinAudioEncoderFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CreateNativeAudioEncoderFactory ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='BuiltinAudioEncoderFactoryFactory']/method[@name='createNativeAudioEncoderFactory' and count(parameter)=0]"
		[Register ("createNativeAudioEncoderFactory", "()J", "GetCreateNativeAudioEncoderFactoryHandler")]
		public virtual unsafe long CreateNativeAudioEncoderFactory ()
		{
			const string __id = "createNativeAudioEncoderFactory.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
