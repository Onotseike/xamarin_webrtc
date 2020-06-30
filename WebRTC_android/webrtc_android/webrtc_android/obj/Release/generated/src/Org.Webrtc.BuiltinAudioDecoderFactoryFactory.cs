using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='BuiltinAudioDecoderFactoryFactory']"
	[global::Android.Runtime.Register ("org/webrtc/BuiltinAudioDecoderFactoryFactory", DoNotGenerateAcw=true)]
	public partial class BuiltinAudioDecoderFactoryFactory : global::Java.Lang.Object, global::Org.Webrtc.IAudioDecoderFactoryFactory {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/BuiltinAudioDecoderFactoryFactory", typeof (BuiltinAudioDecoderFactoryFactory));
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

		protected BuiltinAudioDecoderFactoryFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='BuiltinAudioDecoderFactoryFactory']/constructor[@name='BuiltinAudioDecoderFactoryFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BuiltinAudioDecoderFactoryFactory ()
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

		static Delegate cb_createNativeAudioDecoderFactory;
#pragma warning disable 0169
		static Delegate GetCreateNativeAudioDecoderFactoryHandler ()
		{
			if (cb_createNativeAudioDecoderFactory == null)
				cb_createNativeAudioDecoderFactory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_CreateNativeAudioDecoderFactory);
			return cb_createNativeAudioDecoderFactory;
		}

		static long n_CreateNativeAudioDecoderFactory (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.BuiltinAudioDecoderFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.BuiltinAudioDecoderFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CreateNativeAudioDecoderFactory ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='BuiltinAudioDecoderFactoryFactory']/method[@name='createNativeAudioDecoderFactory' and count(parameter)=0]"
		[Register ("createNativeAudioDecoderFactory", "()J", "GetCreateNativeAudioDecoderFactoryHandler")]
		public virtual unsafe long CreateNativeAudioDecoderFactory ()
		{
			const string __id = "createNativeAudioDecoderFactory.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
