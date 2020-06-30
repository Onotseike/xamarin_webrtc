using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='YuvConverter']"
	[global::Android.Runtime.Register ("org/webrtc/YuvConverter", DoNotGenerateAcw=true)]
	public partial class YuvConverter : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/YuvConverter", typeof (YuvConverter));
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

		protected YuvConverter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='YuvConverter']/constructor[@name='YuvConverter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe YuvConverter ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='YuvConverter']/constructor[@name='YuvConverter' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoFrameDrawer']]"
		[Register (".ctor", "(Lorg/webrtc/VideoFrameDrawer;)V", "")]
		public unsafe YuvConverter (global::Org.Webrtc.VideoFrameDrawer videoFrameDrawer)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/webrtc/VideoFrameDrawer;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((videoFrameDrawer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) videoFrameDrawer).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_convert_Lorg_webrtc_VideoFrame_TextureBuffer_;
#pragma warning disable 0169
		static Delegate GetConvert_Lorg_webrtc_VideoFrame_TextureBuffer_Handler ()
		{
			if (cb_convert_Lorg_webrtc_VideoFrame_TextureBuffer_ == null)
				cb_convert_Lorg_webrtc_VideoFrame_TextureBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Convert_Lorg_webrtc_VideoFrame_TextureBuffer_);
			return cb_convert_Lorg_webrtc_VideoFrame_TextureBuffer_;
		}

		static IntPtr n_Convert_Lorg_webrtc_VideoFrame_TextureBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inputTextureBuffer)
		{
			global::Org.Webrtc.YuvConverter __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.YuvConverter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.VideoFrame.ITextureBuffer inputTextureBuffer = (global::Org.Webrtc.VideoFrame.ITextureBuffer)global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.ITextureBuffer> (native_inputTextureBuffer, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Convert (inputTextureBuffer));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='YuvConverter']/method[@name='convert' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoFrame.TextureBuffer']]"
		[Register ("convert", "(Lorg/webrtc/VideoFrame$TextureBuffer;)Lorg/webrtc/VideoFrame$I420Buffer;", "GetConvert_Lorg_webrtc_VideoFrame_TextureBuffer_Handler")]
		public virtual unsafe global::Org.Webrtc.VideoFrame.II420Buffer Convert (global::Org.Webrtc.VideoFrame.ITextureBuffer inputTextureBuffer)
		{
			const string __id = "convert.(Lorg/webrtc/VideoFrame$TextureBuffer;)Lorg/webrtc/VideoFrame$I420Buffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((inputTextureBuffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inputTextureBuffer).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.II420Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.YuvConverter __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.YuvConverter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='YuvConverter']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
