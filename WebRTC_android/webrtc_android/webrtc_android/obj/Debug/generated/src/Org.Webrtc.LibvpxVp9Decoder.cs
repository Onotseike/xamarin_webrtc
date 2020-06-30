using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='LibvpxVp9Decoder']"
	[global::Android.Runtime.Register ("org/webrtc/LibvpxVp9Decoder", DoNotGenerateAcw=true)]
	public partial class LibvpxVp9Decoder : global::Org.Webrtc.WrappedNativeVideoDecoder {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/LibvpxVp9Decoder", typeof (LibvpxVp9Decoder));
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

		protected LibvpxVp9Decoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='LibvpxVp9Decoder']/constructor[@name='LibvpxVp9Decoder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LibvpxVp9Decoder ()
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

		static Delegate cb_createNativeVideoDecoder;
#pragma warning disable 0169
		static Delegate GetCreateNativeVideoDecoderHandler ()
		{
			if (cb_createNativeVideoDecoder == null)
				cb_createNativeVideoDecoder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_CreateNativeVideoDecoder);
			return cb_createNativeVideoDecoder;
		}

		static long n_CreateNativeVideoDecoder (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.LibvpxVp9Decoder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.LibvpxVp9Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CreateNativeVideoDecoder ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='LibvpxVp9Decoder']/method[@name='createNativeVideoDecoder' and count(parameter)=0]"
		[Register ("createNativeVideoDecoder", "()J", "GetCreateNativeVideoDecoderHandler")]
		public override unsafe long CreateNativeVideoDecoder ()
		{
			const string __id = "createNativeVideoDecoder.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
