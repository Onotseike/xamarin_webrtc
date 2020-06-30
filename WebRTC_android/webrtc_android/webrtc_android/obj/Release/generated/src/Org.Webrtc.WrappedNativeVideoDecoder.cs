using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='WrappedNativeVideoDecoder']"
	[global::Android.Runtime.Register ("org/webrtc/WrappedNativeVideoDecoder", DoNotGenerateAcw=true)]
	public abstract partial class WrappedNativeVideoDecoder : global::Java.Lang.Object, global::Org.Webrtc.IVideoDecoder {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/WrappedNativeVideoDecoder", typeof (WrappedNativeVideoDecoder));
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

		protected WrappedNativeVideoDecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='WrappedNativeVideoDecoder']/constructor[@name='WrappedNativeVideoDecoder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WrappedNativeVideoDecoder ()
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

		public unsafe string ImplementationName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='WrappedNativeVideoDecoder']/method[@name='getImplementationName' and count(parameter)=0]"
			[Register ("getImplementationName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getImplementationName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool PrefersLateDecoding {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='WrappedNativeVideoDecoder']/method[@name='getPrefersLateDecoding' and count(parameter)=0]"
			[Register ("getPrefersLateDecoding", "()Z", "")]
			get {
				const string __id = "getPrefersLateDecoding.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			global::Org.Webrtc.WrappedNativeVideoDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.WrappedNativeVideoDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CreateNativeVideoDecoder ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='WrappedNativeVideoDecoder']/method[@name='createNativeVideoDecoder' and count(parameter)=0]"
		[Register ("createNativeVideoDecoder", "()J", "GetCreateNativeVideoDecoderHandler")]
		public abstract long CreateNativeVideoDecoder ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='WrappedNativeVideoDecoder']/method[@name='decode' and count(parameter)=2 and parameter[1][@type='org.webrtc.EncodedImage'] and parameter[2][@type='org.webrtc.VideoDecoder.DecodeInfo']]"
		[Register ("decode", "(Lorg/webrtc/EncodedImage;Lorg/webrtc/VideoDecoder$DecodeInfo;)Lorg/webrtc/VideoCodecStatus;", "")]
		public unsafe global::Org.Webrtc.VideoCodecStatus Decode (global::Org.Webrtc.EncodedImage frame, global::Org.Webrtc.VideoDecoderDecodeInfo info)
		{
			const string __id = "decode.(Lorg/webrtc/EncodedImage;Lorg/webrtc/VideoDecoder$DecodeInfo;)Lorg/webrtc/VideoCodecStatus;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((frame == null) ? IntPtr.Zero : ((global::Java.Lang.Object) frame).Handle);
				__args [1] = new JniArgumentValue ((info == null) ? IntPtr.Zero : ((global::Java.Lang.Object) info).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='WrappedNativeVideoDecoder']/method[@name='initDecode' and count(parameter)=2 and parameter[1][@type='org.webrtc.VideoDecoder.Settings'] and parameter[2][@type='org.webrtc.VideoDecoder.Callback']]"
		[Register ("initDecode", "(Lorg/webrtc/VideoDecoder$Settings;Lorg/webrtc/VideoDecoder$Callback;)Lorg/webrtc/VideoCodecStatus;", "")]
		public unsafe global::Org.Webrtc.VideoCodecStatus InitDecode (global::Org.Webrtc.VideoDecoderSettings settings, global::Org.Webrtc.IVideoDecoderCallback decodeCallback)
		{
			const string __id = "initDecode.(Lorg/webrtc/VideoDecoder$Settings;Lorg/webrtc/VideoDecoder$Callback;)Lorg/webrtc/VideoCodecStatus;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((settings == null) ? IntPtr.Zero : ((global::Java.Lang.Object) settings).Handle);
				__args [1] = new JniArgumentValue ((decodeCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) decodeCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='WrappedNativeVideoDecoder']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()Lorg/webrtc/VideoCodecStatus;", "")]
		public unsafe global::Org.Webrtc.VideoCodecStatus Release ()
		{
			const string __id = "release.()Lorg/webrtc/VideoCodecStatus;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/webrtc/WrappedNativeVideoDecoder", DoNotGenerateAcw=true)]
	internal partial class WrappedNativeVideoDecoderInvoker : WrappedNativeVideoDecoder {

		public WrappedNativeVideoDecoderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/WrappedNativeVideoDecoder", typeof (WrappedNativeVideoDecoderInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='WrappedNativeVideoDecoder']/method[@name='createNativeVideoDecoder' and count(parameter)=0]"
		[Register ("createNativeVideoDecoder", "()J", "GetCreateNativeVideoDecoderHandler")]
		public override unsafe long CreateNativeVideoDecoder ()
		{
			const string __id = "createNativeVideoDecoder.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}

}
