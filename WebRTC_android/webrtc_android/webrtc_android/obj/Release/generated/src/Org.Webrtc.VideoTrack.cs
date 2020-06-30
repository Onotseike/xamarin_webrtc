using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoTrack']"
	[global::Android.Runtime.Register ("org/webrtc/VideoTrack", DoNotGenerateAcw=true)]
	public partial class VideoTrack : global::Org.Webrtc.MediaStreamTrack {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoTrack", typeof (VideoTrack));
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

		protected VideoTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoTrack']/constructor[@name='VideoTrack' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe VideoTrack (long nativeTrack)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (nativeTrack);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addSink_Lorg_webrtc_VideoSink_;
#pragma warning disable 0169
		static Delegate GetAddSink_Lorg_webrtc_VideoSink_Handler ()
		{
			if (cb_addSink_Lorg_webrtc_VideoSink_ == null)
				cb_addSink_Lorg_webrtc_VideoSink_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddSink_Lorg_webrtc_VideoSink_);
			return cb_addSink_Lorg_webrtc_VideoSink_;
		}

		static void n_AddSink_Lorg_webrtc_VideoSink_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sink)
		{
			global::Org.Webrtc.VideoTrack __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.IVideoSink sink = (global::Org.Webrtc.IVideoSink)global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoSink> (native_sink, JniHandleOwnership.DoNotTransfer);
			__this.AddSink (sink);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoTrack']/method[@name='addSink' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoSink']]"
		[Register ("addSink", "(Lorg/webrtc/VideoSink;)V", "GetAddSink_Lorg_webrtc_VideoSink_Handler")]
		public virtual unsafe void AddSink (global::Org.Webrtc.IVideoSink sink)
		{
			const string __id = "addSink.(Lorg/webrtc/VideoSink;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sink == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sink).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeSink_Lorg_webrtc_VideoSink_;
#pragma warning disable 0169
		static Delegate GetRemoveSink_Lorg_webrtc_VideoSink_Handler ()
		{
			if (cb_removeSink_Lorg_webrtc_VideoSink_ == null)
				cb_removeSink_Lorg_webrtc_VideoSink_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveSink_Lorg_webrtc_VideoSink_);
			return cb_removeSink_Lorg_webrtc_VideoSink_;
		}

		static void n_RemoveSink_Lorg_webrtc_VideoSink_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sink)
		{
			global::Org.Webrtc.VideoTrack __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.IVideoSink sink = (global::Org.Webrtc.IVideoSink)global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoSink> (native_sink, JniHandleOwnership.DoNotTransfer);
			__this.RemoveSink (sink);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoTrack']/method[@name='removeSink' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoSink']]"
		[Register ("removeSink", "(Lorg/webrtc/VideoSink;)V", "GetRemoveSink_Lorg_webrtc_VideoSink_Handler")]
		public virtual unsafe void RemoveSink (global::Org.Webrtc.IVideoSink sink)
		{
			const string __id = "removeSink.(Lorg/webrtc/VideoSink;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sink == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sink).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
