using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='Camera2Capturer']"
	[global::Android.Runtime.Register ("org/webrtc/Camera2Capturer", DoNotGenerateAcw=true)]
	public partial class Camera2Capturer : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/Camera2Capturer", typeof (Camera2Capturer));
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

		protected Camera2Capturer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='Camera2Capturer']/constructor[@name='Camera2Capturer' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.webrtc.CameraVideoCapturer.CameraEventsHandler']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Lorg/webrtc/CameraVideoCapturer$CameraEventsHandler;)V", "")]
		public unsafe Camera2Capturer (global::Android.Content.Context context, string cameraName, global::Org.Webrtc.ICameraVideoCapturerCameraEventsHandler eventsHandler)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Ljava/lang/String;Lorg/webrtc/CameraVideoCapturer$CameraEventsHandler;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_cameraName = JNIEnv.NewString (cameraName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_cameraName);
				__args [2] = new JniArgumentValue ((eventsHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventsHandler).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_cameraName);
			}
		}

		static Delegate cb_getCameraName;
#pragma warning disable 0169
		static Delegate GetGetCameraNameHandler ()
		{
			if (cb_getCameraName == null)
				cb_getCameraName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCameraName);
			return cb_getCameraName;
		}

		static IntPtr n_GetCameraName (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.Camera2Capturer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Camera2Capturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CameraName);
		}
#pragma warning restore 0169

		protected virtual unsafe string CameraName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Camera2Capturer']/method[@name='getCameraName' and count(parameter)=0]"
			[Register ("getCameraName", "()Ljava/lang/String;", "GetGetCameraNameHandler")]
			get {
				const string __id = "getCameraName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Org.Webrtc.Camera2Capturer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Camera2Capturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsScreencast;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsScreencast {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Camera2Capturer']/method[@name='isScreencast' and count(parameter)=0]"
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

		static Delegate cb_changeCaptureFormat_III;
#pragma warning disable 0169
		static Delegate GetChangeCaptureFormat_IIIHandler ()
		{
			if (cb_changeCaptureFormat_III == null)
				cb_changeCaptureFormat_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_ChangeCaptureFormat_III);
			return cb_changeCaptureFormat_III;
		}

		static void n_ChangeCaptureFormat_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			global::Org.Webrtc.Camera2Capturer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Camera2Capturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ChangeCaptureFormat (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Camera2Capturer']/method[@name='changeCaptureFormat' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("changeCaptureFormat", "(III)V", "GetChangeCaptureFormat_IIIHandler")]
		public virtual unsafe void ChangeCaptureFormat (int p0, int p1, int p2)
		{
			const string __id = "changeCaptureFormat.(III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
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
			global::Org.Webrtc.Camera2Capturer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Camera2Capturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Camera2Capturer']/method[@name='dispose' and count(parameter)=0]"
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

		static void n_Initialize_Lorg_webrtc_SurfaceTextureHelper_Landroid_content_Context_Lorg_webrtc_CapturerObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Webrtc.Camera2Capturer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Camera2Capturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.SurfaceTextureHelper p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceTextureHelper> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.ICapturerObserver p2 = (global::Org.Webrtc.ICapturerObserver)global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICapturerObserver> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Initialize (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Camera2Capturer']/method[@name='initialize' and count(parameter)=3 and parameter[1][@type='org.webrtc.SurfaceTextureHelper'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='org.webrtc.CapturerObserver']]"
		[Register ("initialize", "(Lorg/webrtc/SurfaceTextureHelper;Landroid/content/Context;Lorg/webrtc/CapturerObserver;)V", "GetInitialize_Lorg_webrtc_SurfaceTextureHelper_Landroid_content_Context_Lorg_webrtc_CapturerObserver_Handler")]
		public virtual unsafe void Initialize (global::Org.Webrtc.SurfaceTextureHelper p0, global::Android.Content.Context p1, global::Org.Webrtc.ICapturerObserver p2)
		{
			const string __id = "initialize.(Lorg/webrtc/SurfaceTextureHelper;Landroid/content/Context;Lorg/webrtc/CapturerObserver;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_printStackTrace;
#pragma warning disable 0169
		static Delegate GetPrintStackTraceHandler ()
		{
			if (cb_printStackTrace == null)
				cb_printStackTrace = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PrintStackTrace);
			return cb_printStackTrace;
		}

		static void n_PrintStackTrace (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.Camera2Capturer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Camera2Capturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PrintStackTrace ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Camera2Capturer']/method[@name='printStackTrace' and count(parameter)=0]"
		[Register ("printStackTrace", "()V", "GetPrintStackTraceHandler")]
		public virtual unsafe void PrintStackTrace ()
		{
			const string __id = "printStackTrace.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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

		static void n_StartCapture_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			global::Org.Webrtc.Camera2Capturer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Camera2Capturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartCapture (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Camera2Capturer']/method[@name='startCapture' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("startCapture", "(III)V", "GetStartCapture_IIIHandler")]
		public virtual unsafe void StartCapture (int p0, int p1, int p2)
		{
			const string __id = "startCapture.(III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
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
			global::Org.Webrtc.Camera2Capturer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Camera2Capturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopCapture ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Camera2Capturer']/method[@name='stopCapture' and count(parameter)=0]"
		[Register ("stopCapture", "()V", "GetStopCaptureHandler")]
		public virtual unsafe void StopCapture ()
		{
			const string __id = "stopCapture.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_switchCamera_Lorg_webrtc_CameraVideoCapturer_CameraSwitchHandler_;
#pragma warning disable 0169
		static Delegate GetSwitchCamera_Lorg_webrtc_CameraVideoCapturer_CameraSwitchHandler_Handler ()
		{
			if (cb_switchCamera_Lorg_webrtc_CameraVideoCapturer_CameraSwitchHandler_ == null)
				cb_switchCamera_Lorg_webrtc_CameraVideoCapturer_CameraSwitchHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SwitchCamera_Lorg_webrtc_CameraVideoCapturer_CameraSwitchHandler_);
			return cb_switchCamera_Lorg_webrtc_CameraVideoCapturer_CameraSwitchHandler_;
		}

		static void n_SwitchCamera_Lorg_webrtc_CameraVideoCapturer_CameraSwitchHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.Camera2Capturer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Camera2Capturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.ICameraVideoCapturerCameraSwitchHandler p0 = (global::Org.Webrtc.ICameraVideoCapturerCameraSwitchHandler)global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICameraVideoCapturerCameraSwitchHandler> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SwitchCamera (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Camera2Capturer']/method[@name='switchCamera' and count(parameter)=1 and parameter[1][@type='org.webrtc.CameraVideoCapturer.CameraSwitchHandler']]"
		[Register ("switchCamera", "(Lorg/webrtc/CameraVideoCapturer$CameraSwitchHandler;)V", "GetSwitchCamera_Lorg_webrtc_CameraVideoCapturer_CameraSwitchHandler_Handler")]
		public virtual unsafe void SwitchCamera (global::Org.Webrtc.ICameraVideoCapturerCameraSwitchHandler p0)
		{
			const string __id = "switchCamera.(Lorg/webrtc/CameraVideoCapturer$CameraSwitchHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_switchCamera_Lorg_webrtc_CameraVideoCapturer_CameraSwitchHandler_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSwitchCamera_Lorg_webrtc_CameraVideoCapturer_CameraSwitchHandler_Ljava_lang_String_Handler ()
		{
			if (cb_switchCamera_Lorg_webrtc_CameraVideoCapturer_CameraSwitchHandler_Ljava_lang_String_ == null)
				cb_switchCamera_Lorg_webrtc_CameraVideoCapturer_CameraSwitchHandler_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SwitchCamera_Lorg_webrtc_CameraVideoCapturer_CameraSwitchHandler_Ljava_lang_String_);
			return cb_switchCamera_Lorg_webrtc_CameraVideoCapturer_CameraSwitchHandler_Ljava_lang_String_;
		}

		static void n_SwitchCamera_Lorg_webrtc_CameraVideoCapturer_CameraSwitchHandler_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Webrtc.Camera2Capturer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Camera2Capturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.ICameraVideoCapturerCameraSwitchHandler p0 = (global::Org.Webrtc.ICameraVideoCapturerCameraSwitchHandler)global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICameraVideoCapturerCameraSwitchHandler> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SwitchCamera (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Camera2Capturer']/method[@name='switchCamera' and count(parameter)=2 and parameter[1][@type='org.webrtc.CameraVideoCapturer.CameraSwitchHandler'] and parameter[2][@type='java.lang.String']]"
		[Register ("switchCamera", "(Lorg/webrtc/CameraVideoCapturer$CameraSwitchHandler;Ljava/lang/String;)V", "GetSwitchCamera_Lorg_webrtc_CameraVideoCapturer_CameraSwitchHandler_Ljava_lang_String_Handler")]
		public virtual unsafe void SwitchCamera (global::Org.Webrtc.ICameraVideoCapturerCameraSwitchHandler p0, string p1)
		{
			const string __id = "switchCamera.(Lorg/webrtc/CameraVideoCapturer$CameraSwitchHandler;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
