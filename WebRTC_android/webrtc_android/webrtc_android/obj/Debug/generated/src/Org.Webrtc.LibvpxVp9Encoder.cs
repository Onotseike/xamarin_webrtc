using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='LibvpxVp9Encoder']"
	[global::Android.Runtime.Register ("org/webrtc/LibvpxVp9Encoder", DoNotGenerateAcw=true)]
	public partial class LibvpxVp9Encoder : global::Org.Webrtc.WrappedNativeVideoEncoder {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/LibvpxVp9Encoder", typeof (LibvpxVp9Encoder));
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

		protected LibvpxVp9Encoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='LibvpxVp9Encoder']/constructor[@name='LibvpxVp9Encoder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LibvpxVp9Encoder ()
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

		static Delegate cb_isHardwareEncoder;
#pragma warning disable 0169
		static Delegate GetIsHardwareEncoderHandler ()
		{
			if (cb_isHardwareEncoder == null)
				cb_isHardwareEncoder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHardwareEncoder);
			return cb_isHardwareEncoder;
		}

		static bool n_IsHardwareEncoder (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.LibvpxVp9Encoder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.LibvpxVp9Encoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHardwareEncoder;
		}
#pragma warning restore 0169

		public override unsafe bool IsHardwareEncoder {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='LibvpxVp9Encoder']/method[@name='isHardwareEncoder' and count(parameter)=0]"
			[Register ("isHardwareEncoder", "()Z", "GetIsHardwareEncoderHandler")]
			get {
				const string __id = "isHardwareEncoder.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_createNativeVideoEncoder;
#pragma warning disable 0169
		static Delegate GetCreateNativeVideoEncoderHandler ()
		{
			if (cb_createNativeVideoEncoder == null)
				cb_createNativeVideoEncoder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_CreateNativeVideoEncoder);
			return cb_createNativeVideoEncoder;
		}

		static long n_CreateNativeVideoEncoder (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.LibvpxVp9Encoder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.LibvpxVp9Encoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CreateNativeVideoEncoder ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='LibvpxVp9Encoder']/method[@name='createNativeVideoEncoder' and count(parameter)=0]"
		[Register ("createNativeVideoEncoder", "()J", "GetCreateNativeVideoEncoderHandler")]
		public override unsafe long CreateNativeVideoEncoder ()
		{
			const string __id = "createNativeVideoEncoder.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
