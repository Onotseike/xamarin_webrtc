using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoCapturer']"
	[Register ("org/webrtc/VideoCapturer", "", "Org.Webrtc.IVideoCapturerInvoker")]
	public partial interface IVideoCapturer : IJavaObject, IJavaPeerable {

		bool IsScreencast {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoCapturer']/method[@name='isScreencast' and count(parameter)=0]"
			[Register ("isScreencast", "()Z", "GetIsScreencastHandler:Org.Webrtc.IVideoCapturerInvoker, webrtc_android")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoCapturer']/method[@name='changeCaptureFormat' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("changeCaptureFormat", "(III)V", "GetChangeCaptureFormat_IIIHandler:Org.Webrtc.IVideoCapturerInvoker, webrtc_android")]
		void ChangeCaptureFormat (int p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoCapturer']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler:Org.Webrtc.IVideoCapturerInvoker, webrtc_android")]
		void Dispose ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoCapturer']/method[@name='initialize' and count(parameter)=3 and parameter[1][@type='org.webrtc.SurfaceTextureHelper'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='org.webrtc.CapturerObserver']]"
		[Register ("initialize", "(Lorg/webrtc/SurfaceTextureHelper;Landroid/content/Context;Lorg/webrtc/CapturerObserver;)V", "GetInitialize_Lorg_webrtc_SurfaceTextureHelper_Landroid_content_Context_Lorg_webrtc_CapturerObserver_Handler:Org.Webrtc.IVideoCapturerInvoker, webrtc_android")]
		void Initialize (global::Org.Webrtc.SurfaceTextureHelper p0, global::Android.Content.Context p1, global::Org.Webrtc.ICapturerObserver p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoCapturer']/method[@name='startCapture' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("startCapture", "(III)V", "GetStartCapture_IIIHandler:Org.Webrtc.IVideoCapturerInvoker, webrtc_android")]
		void StartCapture (int p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoCapturer']/method[@name='stopCapture' and count(parameter)=0]"
		[Register ("stopCapture", "()V", "GetStopCaptureHandler:Org.Webrtc.IVideoCapturerInvoker, webrtc_android")]
		void StopCapture ();

	}

	[global::Android.Runtime.Register ("org/webrtc/VideoCapturer", DoNotGenerateAcw=true)]
	internal partial class IVideoCapturerInvoker : global::Java.Lang.Object, IVideoCapturer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoCapturer", typeof (IVideoCapturerInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IVideoCapturer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoCapturer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.VideoCapturer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoCapturerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Org.Webrtc.IVideoCapturer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoCapturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsScreencast;
		}
#pragma warning restore 0169

		IntPtr id_isScreencast;
		public unsafe bool IsScreencast {
			get {
				if (id_isScreencast == IntPtr.Zero)
					id_isScreencast = JNIEnv.GetMethodID (class_ref, "isScreencast", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isScreencast);
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
			global::Org.Webrtc.IVideoCapturer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoCapturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ChangeCaptureFormat (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_changeCaptureFormat_III;
		public unsafe void ChangeCaptureFormat (int p0, int p1, int p2)
		{
			if (id_changeCaptureFormat_III == IntPtr.Zero)
				id_changeCaptureFormat_III = JNIEnv.GetMethodID (class_ref, "changeCaptureFormat", "(III)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_changeCaptureFormat_III, __args);
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
			global::Org.Webrtc.IVideoCapturer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoCapturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		IntPtr id_dispose;
		public unsafe void Dispose ()
		{
			if (id_dispose == IntPtr.Zero)
				id_dispose = JNIEnv.GetMethodID (class_ref, "dispose", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dispose);
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
			global::Org.Webrtc.IVideoCapturer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoCapturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.SurfaceTextureHelper p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceTextureHelper> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.ICapturerObserver p2 = (global::Org.Webrtc.ICapturerObserver)global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICapturerObserver> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Initialize (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_initialize_Lorg_webrtc_SurfaceTextureHelper_Landroid_content_Context_Lorg_webrtc_CapturerObserver_;
		public unsafe void Initialize (global::Org.Webrtc.SurfaceTextureHelper p0, global::Android.Content.Context p1, global::Org.Webrtc.ICapturerObserver p2)
		{
			if (id_initialize_Lorg_webrtc_SurfaceTextureHelper_Landroid_content_Context_Lorg_webrtc_CapturerObserver_ == IntPtr.Zero)
				id_initialize_Lorg_webrtc_SurfaceTextureHelper_Landroid_content_Context_Lorg_webrtc_CapturerObserver_ = JNIEnv.GetMethodID (class_ref, "initialize", "(Lorg/webrtc/SurfaceTextureHelper;Landroid/content/Context;Lorg/webrtc/CapturerObserver;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initialize_Lorg_webrtc_SurfaceTextureHelper_Landroid_content_Context_Lorg_webrtc_CapturerObserver_, __args);
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
			global::Org.Webrtc.IVideoCapturer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoCapturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartCapture (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_startCapture_III;
		public unsafe void StartCapture (int p0, int p1, int p2)
		{
			if (id_startCapture_III == IntPtr.Zero)
				id_startCapture_III = JNIEnv.GetMethodID (class_ref, "startCapture", "(III)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startCapture_III, __args);
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
			global::Org.Webrtc.IVideoCapturer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoCapturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopCapture ();
		}
#pragma warning restore 0169

		IntPtr id_stopCapture;
		public unsafe void StopCapture ()
		{
			if (id_stopCapture == IntPtr.Zero)
				id_stopCapture = JNIEnv.GetMethodID (class_ref, "stopCapture", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopCapture);
		}

	}

}
