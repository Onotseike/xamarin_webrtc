using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoDecoderFallback']"
	[global::Android.Runtime.Register ("org/webrtc/VideoDecoderFallback", DoNotGenerateAcw=true)]
	public partial class VideoDecoderFallback : global::Org.Webrtc.WrappedNativeVideoDecoder {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoDecoderFallback", typeof (VideoDecoderFallback));
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

		protected VideoDecoderFallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoDecoderFallback']/constructor[@name='VideoDecoderFallback' and count(parameter)=2 and parameter[1][@type='org.webrtc.VideoDecoder'] and parameter[2][@type='org.webrtc.VideoDecoder']]"
		[Register (".ctor", "(Lorg/webrtc/VideoDecoder;Lorg/webrtc/VideoDecoder;)V", "")]
		public unsafe VideoDecoderFallback (global::Org.Webrtc.IVideoDecoder fallback, global::Org.Webrtc.IVideoDecoder primary)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/webrtc/VideoDecoder;Lorg/webrtc/VideoDecoder;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((fallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fallback).Handle);
				__args [1] = new JniArgumentValue ((primary == null) ? IntPtr.Zero : ((global::Java.Lang.Object) primary).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
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
			global::Org.Webrtc.VideoDecoderFallback __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoDecoderFallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CreateNativeVideoDecoder ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoDecoderFallback']/method[@name='createNativeVideoDecoder' and count(parameter)=0]"
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
