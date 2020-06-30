using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='ScreenCapturerAndroid']"
	[global::Android.Runtime.Register ("org/webrtc/ScreenCapturerAndroid", DoNotGenerateAcw=true)]
	public partial class ScreenCapturerAndroid : global::Java.Lang.Object, global::Org.Webrtc.IVideoCapturer, global::Org.Webrtc.IVideoSink {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/ScreenCapturerAndroid", typeof (ScreenCapturerAndroid));
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

		protected ScreenCapturerAndroid (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='ScreenCapturerAndroid']/constructor[@name='ScreenCapturerAndroid' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.media.projection.MediaProjection.Callback']]"
		[Register (".ctor", "(Landroid/content/Intent;Landroid/media/projection/MediaProjection$Callback;)V", "")]
		public unsafe ScreenCapturerAndroid (global::Android.Content.Intent mediaProjectionPermissionResultData, global::Android.Media.Projection.MediaProjection.Callback mediaProjectionCallback)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Intent;Landroid/media/projection/MediaProjection$Callback;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((mediaProjectionPermissionResultData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaProjectionPermissionResultData).Handle);
				__args [1] = new JniArgumentValue ((mediaProjectionCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaProjectionCallback).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isScreencast;
#pragma warning disable 0169
		static Delegate GetIsScreencastHandler ()
		{
			if (cb_isScreencast == null)
				cb_isScreencast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsScreencast);
			return cb_isScreencast;
		}

		static bool n_IsScreencast (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.ScreenCapturerAndroid __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ScreenCapturerAndroid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsScreencast;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsScreencast {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='ScreenCapturerAndroid']/method[@name='isScreencast' and count(parameter)=0]"
			[Register ("isScreencast", "()Z", "GetIsScreencastHandler")]
			get {
				const string __id = "isScreencast.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getNumCapturedFrames;
#pragma warning disable 0169
		static Delegate GetGetNumCapturedFramesHandler ()
		{
			if (cb_getNumCapturedFrames == null)
				cb_getNumCapturedFrames = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetNumCapturedFrames);
			return cb_getNumCapturedFrames;
		}

		static long n_GetNumCapturedFrames (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.ScreenCapturerAndroid __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ScreenCapturerAndroid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumCapturedFrames;
		}
#pragma warning restore 0169

		public virtual unsafe long NumCapturedFrames {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='ScreenCapturerAndroid']/method[@name='getNumCapturedFrames' and count(parameter)=0]"
			[Register ("getNumCapturedFrames", "()J", "GetGetNumCapturedFramesHandler")]
			get {
				const string __id = "getNumCapturedFrames.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_changeCaptureFormat_III;
#pragma warning disable 0169
		static Delegate GetChangeCaptureFormat_IIIHandler ()
		{
			if (cb_changeCaptureFormat_III == null)
				cb_changeCaptureFormat_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_ChangeCaptureFormat_III);
			return cb_changeCaptureFormat_III;
		}

		static void n_ChangeCaptureFormat_III (IntPtr jnienv, IntPtr native__this, int width, int height, int ignoredFramerate)
		{
			global::Org.Webrtc.ScreenCapturerAndroid __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ScreenCapturerAndroid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ChangeCaptureFormat (width, height, ignoredFramerate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='ScreenCapturerAndroid']/method[@name='changeCaptureFormat' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("changeCaptureFormat", "(III)V", "GetChangeCaptureFormat_IIIHandler")]
		public virtual unsafe void ChangeCaptureFormat (int width, int height, int ignoredFramerate)
		{
			const string __id = "changeCaptureFormat.(III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
				__args [2] = new JniArgumentValue (ignoredFramerate);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_dispose;
#pragma warning disable 0169
		static Delegate GetDisposeHandler ()
		{
			if (cb_dispose == null)
				cb_dispose = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Dispose);
			return cb_dispose;
		}

		static void n_Dispose (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.ScreenCapturerAndroid __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ScreenCapturerAndroid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='ScreenCapturerAndroid']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public virtual unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_initialize_Lorg_webrtc_SurfaceTextureHelper_Landroid_content_Context_Lorg_webrtc_CapturerObserver_;
#pragma warning disable 0169
		static Delegate GetInitialize_Lorg_webrtc_SurfaceTextureHelper_Landroid_content_Context_Lorg_webrtc_CapturerObserver_Handler ()
		{
			if (cb_initialize_Lorg_webrtc_SurfaceTextureHelper_Landroid_content_Context_Lorg_webrtc_CapturerObserver_ == null)
				cb_initialize_Lorg_webrtc_SurfaceTextureHelper_Landroid_content_Context_Lorg_webrtc_CapturerObserver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Initialize_Lorg_webrtc_SurfaceTextureHelper_Landroid_content_Context_Lorg_webrtc_CapturerObserver_);
			return cb_initialize_Lorg_webrtc_SurfaceTextureHelper_Landroid_content_Context_Lorg_webrtc_CapturerObserver_;
		}

		static void n_Initialize_Lorg_webrtc_SurfaceTextureHelper_Landroid_content_Context_Lorg_webrtc_CapturerObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_surfaceTextureHelper, IntPtr native_applicationContext, IntPtr native_capturerObserver)
		{
			global::Org.Webrtc.ScreenCapturerAndroid __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ScreenCapturerAndroid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.SurfaceTextureHelper surfaceTextureHelper = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceTextureHelper> (native_surfaceTextureHelper, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context applicationContext = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_applicationContext, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.ICapturerObserver capturerObserver = (global::Org.Webrtc.ICapturerObserver)global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICapturerObserver> (native_capturerObserver, JniHandleOwnership.DoNotTransfer);
			__this.Initialize (surfaceTextureHelper, applicationContext, capturerObserver);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='ScreenCapturerAndroid']/method[@name='initialize' and count(parameter)=3 and parameter[1][@type='org.webrtc.SurfaceTextureHelper'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='org.webrtc.CapturerObserver']]"
		[Register ("initialize", "(Lorg/webrtc/SurfaceTextureHelper;Landroid/content/Context;Lorg/webrtc/CapturerObserver;)V", "GetInitialize_Lorg_webrtc_SurfaceTextureHelper_Landroid_content_Context_Lorg_webrtc_CapturerObserver_Handler")]
		public virtual unsafe void Initialize (global::Org.Webrtc.SurfaceTextureHelper surfaceTextureHelper, global::Android.Content.Context applicationContext, global::Org.Webrtc.ICapturerObserver capturerObserver)
		{
			const string __id = "initialize.(Lorg/webrtc/SurfaceTextureHelper;Landroid/content/Context;Lorg/webrtc/CapturerObserver;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((surfaceTextureHelper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) surfaceTextureHelper).Handle);
				__args [1] = new JniArgumentValue ((applicationContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) applicationContext).Handle);
				__args [2] = new JniArgumentValue ((capturerObserver == null) ? IntPtr.Zero : ((global::Java.Lang.Object) capturerObserver).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
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
			global::Org.Webrtc.ScreenCapturerAndroid __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ScreenCapturerAndroid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.VideoFrame frame = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame> (native_frame, JniHandleOwnership.DoNotTransfer);
			__this.OnFrame (frame);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='ScreenCapturerAndroid']/method[@name='onFrame' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoFrame']]"
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

		static Delegate cb_startCapture_III;
#pragma warning disable 0169
		static Delegate GetStartCapture_IIIHandler ()
		{
			if (cb_startCapture_III == null)
				cb_startCapture_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_StartCapture_III);
			return cb_startCapture_III;
		}

		static void n_StartCapture_III (IntPtr jnienv, IntPtr native__this, int width, int height, int ignoredFramerate)
		{
			global::Org.Webrtc.ScreenCapturerAndroid __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ScreenCapturerAndroid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartCapture (width, height, ignoredFramerate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='ScreenCapturerAndroid']/method[@name='startCapture' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("startCapture", "(III)V", "GetStartCapture_IIIHandler")]
		public virtual unsafe void StartCapture (int width, int height, int ignoredFramerate)
		{
			const string __id = "startCapture.(III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
				__args [2] = new JniArgumentValue (ignoredFramerate);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_stopCapture;
#pragma warning disable 0169
		static Delegate GetStopCaptureHandler ()
		{
			if (cb_stopCapture == null)
				cb_stopCapture = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopCapture);
			return cb_stopCapture;
		}

		static void n_StopCapture (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.ScreenCapturerAndroid __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ScreenCapturerAndroid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopCapture ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='ScreenCapturerAndroid']/method[@name='stopCapture' and count(parameter)=0]"
		[Register ("stopCapture", "()V", "GetStopCaptureHandler")]
		public virtual unsafe void StopCapture ()
		{
			const string __id = "stopCapture.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
