using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoFileRenderer']"
	[global::Android.Runtime.Register ("org/webrtc/VideoFileRenderer", DoNotGenerateAcw=true)]
	public partial class VideoFileRenderer : global::Java.Lang.Object, global::Org.Webrtc.IVideoSink {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoFileRenderer", typeof (VideoFileRenderer));
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

		protected VideoFileRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoFileRenderer']/constructor[@name='VideoFileRenderer' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='org.webrtc.EglBase.Context']]"
		[Register (".ctor", "(Ljava/lang/String;IILorg/webrtc/EglBase$Context;)V", "")]
		public unsafe VideoFileRenderer (string outputFile, int outputFileWidth, int outputFileHeight, global::Org.Webrtc.IEglBaseContext sharedContext)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;IILorg/webrtc/EglBase$Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_outputFile = JNIEnv.NewString (outputFile);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_outputFile);
				__args [1] = new JniArgumentValue (outputFileWidth);
				__args [2] = new JniArgumentValue (outputFileHeight);
				__args [3] = new JniArgumentValue ((sharedContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sharedContext).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_outputFile);
			}
		}

		static Delegate cb_onFrame_Lorg_webrtc_VideoFrame_;
#pragma warning disable 0169
		static Delegate GetOnFrame_Lorg_webrtc_VideoFrame_Handler ()
		{
			if (cb_onFrame_Lorg_webrtc_VideoFrame_ == null)
				cb_onFrame_Lorg_webrtc_VideoFrame_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFrame_Lorg_webrtc_VideoFrame_);
			return cb_onFrame_Lorg_webrtc_VideoFrame_;
		}

		static void n_OnFrame_Lorg_webrtc_VideoFrame_ (IntPtr jnienv, IntPtr native__this, IntPtr native_frame)
		{
			global::Org.Webrtc.VideoFileRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFileRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.VideoFrame frame = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame> (native_frame, JniHandleOwnership.DoNotTransfer);
			__this.OnFrame (frame);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoFileRenderer']/method[@name='onFrame' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoFrame']]"
		[Register ("onFrame", "(Lorg/webrtc/VideoFrame;)V", "GetOnFrame_Lorg_webrtc_VideoFrame_Handler")]
		public virtual unsafe void OnFrame (global::Org.Webrtc.VideoFrame frame)
		{
			const string __id = "onFrame.(Lorg/webrtc/VideoFrame;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((frame == null) ? IntPtr.Zero : ((global::Java.Lang.Object) frame).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Org.Webrtc.VideoFileRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFileRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoFileRenderer']/method[@name='release' and count(parameter)=0]"
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
