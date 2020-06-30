using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='CameraVideoCapturer.CameraEventsHandler']"
	[Register ("org/webrtc/CameraVideoCapturer$CameraEventsHandler", "", "Org.Webrtc.ICameraVideoCapturerCameraEventsHandlerInvoker")]
	public partial interface ICameraVideoCapturerCameraEventsHandler : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='CameraVideoCapturer.CameraEventsHandler']/method[@name='onCameraClosed' and count(parameter)=0]"
		[Register ("onCameraClosed", "()V", "GetOnCameraClosedHandler:Org.Webrtc.ICameraVideoCapturerCameraEventsHandlerInvoker, webrtc_android")]
		void OnCameraClosed ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='CameraVideoCapturer.CameraEventsHandler']/method[@name='onCameraDisconnected' and count(parameter)=0]"
		[Register ("onCameraDisconnected", "()V", "GetOnCameraDisconnectedHandler:Org.Webrtc.ICameraVideoCapturerCameraEventsHandlerInvoker, webrtc_android")]
		void OnCameraDisconnected ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='CameraVideoCapturer.CameraEventsHandler']/method[@name='onCameraError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onCameraError", "(Ljava/lang/String;)V", "GetOnCameraError_Ljava_lang_String_Handler:Org.Webrtc.ICameraVideoCapturerCameraEventsHandlerInvoker, webrtc_android")]
		void OnCameraError (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='CameraVideoCapturer.CameraEventsHandler']/method[@name='onCameraFreezed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onCameraFreezed", "(Ljava/lang/String;)V", "GetOnCameraFreezed_Ljava_lang_String_Handler:Org.Webrtc.ICameraVideoCapturerCameraEventsHandlerInvoker, webrtc_android")]
		void OnCameraFreezed (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='CameraVideoCapturer.CameraEventsHandler']/method[@name='onCameraOpening' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onCameraOpening", "(Ljava/lang/String;)V", "GetOnCameraOpening_Ljava_lang_String_Handler:Org.Webrtc.ICameraVideoCapturerCameraEventsHandlerInvoker, webrtc_android")]
		void OnCameraOpening (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='CameraVideoCapturer.CameraEventsHandler']/method[@name='onFirstFrameAvailable' and count(parameter)=0]"
		[Register ("onFirstFrameAvailable", "()V", "GetOnFirstFrameAvailableHandler:Org.Webrtc.ICameraVideoCapturerCameraEventsHandlerInvoker, webrtc_android")]
		void OnFirstFrameAvailable ();

	}

	[global::Android.Runtime.Register ("org/webrtc/CameraVideoCapturer$CameraEventsHandler", DoNotGenerateAcw=true)]
	internal partial class ICameraVideoCapturerCameraEventsHandlerInvoker : global::Java.Lang.Object, ICameraVideoCapturerCameraEventsHandler {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/CameraVideoCapturer$CameraEventsHandler", typeof (ICameraVideoCapturerCameraEventsHandlerInvoker));

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

		public static ICameraVideoCapturerCameraEventsHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICameraVideoCapturerCameraEventsHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.CameraVideoCapturer.CameraEventsHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICameraVideoCapturerCameraEventsHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCameraClosed;
#pragma warning disable 0169
		static Delegate GetOnCameraClosedHandler ()
		{
			if (cb_onCameraClosed == null)
				cb_onCameraClosed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCameraClosed);
			return cb_onCameraClosed;
		}

		static void n_OnCameraClosed (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.ICameraVideoCapturerCameraEventsHandler __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICameraVideoCapturerCameraEventsHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCameraClosed ();
		}
#pragma warning restore 0169

		IntPtr id_onCameraClosed;
		public unsafe void OnCameraClosed ()
		{
			if (id_onCameraClosed == IntPtr.Zero)
				id_onCameraClosed = JNIEnv.GetMethodID (class_ref, "onCameraClosed", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraClosed);
		}

		static Delegate cb_onCameraDisconnected;
#pragma warning disable 0169
		static Delegate GetOnCameraDisconnectedHandler ()
		{
			if (cb_onCameraDisconnected == null)
				cb_onCameraDisconnected = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCameraDisconnected);
			return cb_onCameraDisconnected;
		}

		static void n_OnCameraDisconnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.ICameraVideoCapturerCameraEventsHandler __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICameraVideoCapturerCameraEventsHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCameraDisconnected ();
		}
#pragma warning restore 0169

		IntPtr id_onCameraDisconnected;
		public unsafe void OnCameraDisconnected ()
		{
			if (id_onCameraDisconnected == IntPtr.Zero)
				id_onCameraDisconnected = JNIEnv.GetMethodID (class_ref, "onCameraDisconnected", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraDisconnected);
		}

		static Delegate cb_onCameraError_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnCameraError_Ljava_lang_String_Handler ()
		{
			if (cb_onCameraError_Ljava_lang_String_ == null)
				cb_onCameraError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCameraError_Ljava_lang_String_);
			return cb_onCameraError_Ljava_lang_String_;
		}

		static void n_OnCameraError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.ICameraVideoCapturerCameraEventsHandler __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICameraVideoCapturerCameraEventsHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCameraError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCameraError_Ljava_lang_String_;
		public unsafe void OnCameraError (string p0)
		{
			if (id_onCameraError_Ljava_lang_String_ == IntPtr.Zero)
				id_onCameraError_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onCameraError", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraError_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onCameraFreezed_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnCameraFreezed_Ljava_lang_String_Handler ()
		{
			if (cb_onCameraFreezed_Ljava_lang_String_ == null)
				cb_onCameraFreezed_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCameraFreezed_Ljava_lang_String_);
			return cb_onCameraFreezed_Ljava_lang_String_;
		}

		static void n_OnCameraFreezed_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.ICameraVideoCapturerCameraEventsHandler __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICameraVideoCapturerCameraEventsHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCameraFreezed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCameraFreezed_Ljava_lang_String_;
		public unsafe void OnCameraFreezed (string p0)
		{
			if (id_onCameraFreezed_Ljava_lang_String_ == IntPtr.Zero)
				id_onCameraFreezed_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onCameraFreezed", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraFreezed_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onCameraOpening_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnCameraOpening_Ljava_lang_String_Handler ()
		{
			if (cb_onCameraOpening_Ljava_lang_String_ == null)
				cb_onCameraOpening_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCameraOpening_Ljava_lang_String_);
			return cb_onCameraOpening_Ljava_lang_String_;
		}

		static void n_OnCameraOpening_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.ICameraVideoCapturerCameraEventsHandler __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICameraVideoCapturerCameraEventsHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCameraOpening (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCameraOpening_Ljava_lang_String_;
		public unsafe void OnCameraOpening (string p0)
		{
			if (id_onCameraOpening_Ljava_lang_String_ == IntPtr.Zero)
				id_onCameraOpening_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onCameraOpening", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraOpening_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onFirstFrameAvailable;
#pragma warning disable 0169
		static Delegate GetOnFirstFrameAvailableHandler ()
		{
			if (cb_onFirstFrameAvailable == null)
				cb_onFirstFrameAvailable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnFirstFrameAvailable);
			return cb_onFirstFrameAvailable;
		}

		static void n_OnFirstFrameAvailable (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.ICameraVideoCapturerCameraEventsHandler __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICameraVideoCapturerCameraEventsHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFirstFrameAvailable ();
		}
#pragma warning restore 0169

		IntPtr id_onFirstFrameAvailable;
		public unsafe void OnFirstFrameAvailable ()
		{
			if (id_onFirstFrameAvailable == IntPtr.Zero)
				id_onFirstFrameAvailable = JNIEnv.GetMethodID (class_ref, "onFirstFrameAvailable", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFirstFrameAvailable);
		}

	}


	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='CameraVideoCapturer.CameraStatistics']"
	[global::Android.Runtime.Register ("org/webrtc/CameraVideoCapturer$CameraStatistics", DoNotGenerateAcw=true)]
	public partial class CameraVideoCapturerCameraStatistics : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/CameraVideoCapturer$CameraStatistics", typeof (CameraVideoCapturerCameraStatistics));
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

		protected CameraVideoCapturerCameraStatistics (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='CameraVideoCapturer.CameraStatistics']/constructor[@name='CameraVideoCapturer.CameraStatistics' and count(parameter)=2 and parameter[1][@type='org.webrtc.SurfaceTextureHelper'] and parameter[2][@type='org.webrtc.CameraVideoCapturer.CameraEventsHandler']]"
		[Register (".ctor", "(Lorg/webrtc/SurfaceTextureHelper;Lorg/webrtc/CameraVideoCapturer$CameraEventsHandler;)V", "")]
		public unsafe CameraVideoCapturerCameraStatistics (global::Org.Webrtc.SurfaceTextureHelper surfaceTextureHelper, global::Org.Webrtc.ICameraVideoCapturerCameraEventsHandler eventsHandler)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/webrtc/SurfaceTextureHelper;Lorg/webrtc/CameraVideoCapturer$CameraEventsHandler;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((surfaceTextureHelper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) surfaceTextureHelper).Handle);
				__args [1] = new JniArgumentValue ((eventsHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventsHandler).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addFrame;
#pragma warning disable 0169
		static Delegate GetAddFrameHandler ()
		{
			if (cb_addFrame == null)
				cb_addFrame = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AddFrame);
			return cb_addFrame;
		}

		static void n_AddFrame (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.CameraVideoCapturerCameraStatistics __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.CameraVideoCapturerCameraStatistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddFrame ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='CameraVideoCapturer.CameraStatistics']/method[@name='addFrame' and count(parameter)=0]"
		[Register ("addFrame", "()V", "GetAddFrameHandler")]
		public virtual unsafe void AddFrame ()
		{
			const string __id = "addFrame.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
			global::Org.Webrtc.CameraVideoCapturerCameraStatistics __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.CameraVideoCapturerCameraStatistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='CameraVideoCapturer.CameraStatistics']/method[@name='release' and count(parameter)=0]"
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

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='CameraVideoCapturer.CameraSwitchHandler']"
	[Register ("org/webrtc/CameraVideoCapturer$CameraSwitchHandler", "", "Org.Webrtc.ICameraVideoCapturerCameraSwitchHandlerInvoker")]
	public partial interface ICameraVideoCapturerCameraSwitchHandler : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='CameraVideoCapturer.CameraSwitchHandler']/method[@name='onCameraSwitchDone' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onCameraSwitchDone", "(Z)V", "GetOnCameraSwitchDone_ZHandler:Org.Webrtc.ICameraVideoCapturerCameraSwitchHandlerInvoker, webrtc_android")]
		void OnCameraSwitchDone (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='CameraVideoCapturer.CameraSwitchHandler']/method[@name='onCameraSwitchError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onCameraSwitchError", "(Ljava/lang/String;)V", "GetOnCameraSwitchError_Ljava_lang_String_Handler:Org.Webrtc.ICameraVideoCapturerCameraSwitchHandlerInvoker, webrtc_android")]
		void OnCameraSwitchError (string p0);

	}

	[global::Android.Runtime.Register ("org/webrtc/CameraVideoCapturer$CameraSwitchHandler", DoNotGenerateAcw=true)]
	internal partial class ICameraVideoCapturerCameraSwitchHandlerInvoker : global::Java.Lang.Object, ICameraVideoCapturerCameraSwitchHandler {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/CameraVideoCapturer$CameraSwitchHandler", typeof (ICameraVideoCapturerCameraSwitchHandlerInvoker));

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

		public static ICameraVideoCapturerCameraSwitchHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICameraVideoCapturerCameraSwitchHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.CameraVideoCapturer.CameraSwitchHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICameraVideoCapturerCameraSwitchHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCameraSwitchDone_Z;
#pragma warning disable 0169
		static Delegate GetOnCameraSwitchDone_ZHandler ()
		{
			if (cb_onCameraSwitchDone_Z == null)
				cb_onCameraSwitchDone_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnCameraSwitchDone_Z);
			return cb_onCameraSwitchDone_Z;
		}

		static void n_OnCameraSwitchDone_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Webrtc.ICameraVideoCapturerCameraSwitchHandler __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICameraVideoCapturerCameraSwitchHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCameraSwitchDone (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCameraSwitchDone_Z;
		public unsafe void OnCameraSwitchDone (bool p0)
		{
			if (id_onCameraSwitchDone_Z == IntPtr.Zero)
				id_onCameraSwitchDone_Z = JNIEnv.GetMethodID (class_ref, "onCameraSwitchDone", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraSwitchDone_Z, __args);
		}

		static Delegate cb_onCameraSwitchError_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnCameraSwitchError_Ljava_lang_String_Handler ()
		{
			if (cb_onCameraSwitchError_Ljava_lang_String_ == null)
				cb_onCameraSwitchError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCameraSwitchError_Ljava_lang_String_);
			return cb_onCameraSwitchError_Ljava_lang_String_;
		}

		static void n_OnCameraSwitchError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.ICameraVideoCapturerCameraSwitchHandler __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICameraVideoCapturerCameraSwitchHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCameraSwitchError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCameraSwitchError_Ljava_lang_String_;
		public unsafe void OnCameraSwitchError (string p0)
		{
			if (id_onCameraSwitchError_Ljava_lang_String_ == IntPtr.Zero)
				id_onCameraSwitchError_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onCameraSwitchError", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraSwitchError_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='CameraVideoCapturer.MediaRecorderHandler']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[Register ("org/webrtc/CameraVideoCapturer$MediaRecorderHandler", "", "Org.Webrtc.ICameraVideoCapturerMediaRecorderHandlerInvoker")]
	public partial interface ICameraVideoCapturerMediaRecorderHandler : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='CameraVideoCapturer.MediaRecorderHandler']/method[@name='onMediaRecorderError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onMediaRecorderError", "(Ljava/lang/String;)V", "GetOnMediaRecorderError_Ljava_lang_String_Handler:Org.Webrtc.ICameraVideoCapturerMediaRecorderHandlerInvoker, webrtc_android")]
		void OnMediaRecorderError (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='CameraVideoCapturer.MediaRecorderHandler']/method[@name='onMediaRecorderSuccess' and count(parameter)=0]"
		[Register ("onMediaRecorderSuccess", "()V", "GetOnMediaRecorderSuccessHandler:Org.Webrtc.ICameraVideoCapturerMediaRecorderHandlerInvoker, webrtc_android")]
		void OnMediaRecorderSuccess ();

	}

	[global::Android.Runtime.Register ("org/webrtc/CameraVideoCapturer$MediaRecorderHandler", DoNotGenerateAcw=true)]
	internal partial class ICameraVideoCapturerMediaRecorderHandlerInvoker : global::Java.Lang.Object, ICameraVideoCapturerMediaRecorderHandler {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/CameraVideoCapturer$MediaRecorderHandler", typeof (ICameraVideoCapturerMediaRecorderHandlerInvoker));

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

		public static ICameraVideoCapturerMediaRecorderHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICameraVideoCapturerMediaRecorderHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.CameraVideoCapturer.MediaRecorderHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICameraVideoCapturerMediaRecorderHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onMediaRecorderError_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnMediaRecorderError_Ljava_lang_String_Handler ()
		{
			if (cb_onMediaRecorderError_Ljava_lang_String_ == null)
				cb_onMediaRecorderError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMediaRecorderError_Ljava_lang_String_);
			return cb_onMediaRecorderError_Ljava_lang_String_;
		}

		static void n_OnMediaRecorderError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.ICameraVideoCapturerMediaRecorderHandler __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICameraVideoCapturerMediaRecorderHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnMediaRecorderError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onMediaRecorderError_Ljava_lang_String_;
		public unsafe void OnMediaRecorderError (string p0)
		{
			if (id_onMediaRecorderError_Ljava_lang_String_ == IntPtr.Zero)
				id_onMediaRecorderError_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onMediaRecorderError", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMediaRecorderError_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onMediaRecorderSuccess;
#pragma warning disable 0169
		static Delegate GetOnMediaRecorderSuccessHandler ()
		{
			if (cb_onMediaRecorderSuccess == null)
				cb_onMediaRecorderSuccess = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnMediaRecorderSuccess);
			return cb_onMediaRecorderSuccess;
		}

		static void n_OnMediaRecorderSuccess (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.ICameraVideoCapturerMediaRecorderHandler __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICameraVideoCapturerMediaRecorderHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMediaRecorderSuccess ();
		}
#pragma warning restore 0169

		IntPtr id_onMediaRecorderSuccess;
		public unsafe void OnMediaRecorderSuccess ()
		{
			if (id_onMediaRecorderSuccess == IntPtr.Zero)
				id_onMediaRecorderSuccess = JNIEnv.GetMethodID (class_ref, "onMediaRecorderSuccess", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMediaRecorderSuccess);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='CameraVideoCapturer']"
	[Register ("org/webrtc/CameraVideoCapturer", "", "Org.Webrtc.ICameraVideoCapturerInvoker")]
	public partial interface ICameraVideoCapturer : global::Org.Webrtc.IVideoCapturer {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='CameraVideoCapturer']/method[@name='switchCamera' and count(parameter)=1 and parameter[1][@type='org.webrtc.CameraVideoCapturer.CameraSwitchHandler']]"
		[Register ("switchCamera", "(Lorg/webrtc/CameraVideoCapturer$CameraSwitchHandler;)V", "GetSwitchCamera_Lorg_webrtc_CameraVideoCapturer_CameraSwitchHandler_Handler:Org.Webrtc.ICameraVideoCapturerInvoker, webrtc_android")]
		void SwitchCamera (global::Org.Webrtc.ICameraVideoCapturerCameraSwitchHandler p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='CameraVideoCapturer']/method[@name='switchCamera' and count(parameter)=2 and parameter[1][@type='org.webrtc.CameraVideoCapturer.CameraSwitchHandler'] and parameter[2][@type='java.lang.String']]"
		[Register ("switchCamera", "(Lorg/webrtc/CameraVideoCapturer$CameraSwitchHandler;Ljava/lang/String;)V", "GetSwitchCamera_Lorg_webrtc_CameraVideoCapturer_CameraSwitchHandler_Ljava_lang_String_Handler:Org.Webrtc.ICameraVideoCapturerInvoker, webrtc_android")]
		void SwitchCamera (global::Org.Webrtc.ICameraVideoCapturerCameraSwitchHandler p0, string p1);

	}

	[global::Android.Runtime.Register ("org/webrtc/CameraVideoCapturer", DoNotGenerateAcw=true)]
	internal partial class ICameraVideoCapturerInvoker : global::Java.Lang.Object, ICameraVideoCapturer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/CameraVideoCapturer", typeof (ICameraVideoCapturerInvoker));

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

		public static ICameraVideoCapturer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICameraVideoCapturer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.CameraVideoCapturer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICameraVideoCapturerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Org.Webrtc.ICameraVideoCapturer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICameraVideoCapturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.ICameraVideoCapturerCameraSwitchHandler p0 = (global::Org.Webrtc.ICameraVideoCapturerCameraSwitchHandler)global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICameraVideoCapturerCameraSwitchHandler> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SwitchCamera (p0);
		}
#pragma warning restore 0169

		IntPtr id_switchCamera_Lorg_webrtc_CameraVideoCapturer_CameraSwitchHandler_;
		public unsafe void SwitchCamera (global::Org.Webrtc.ICameraVideoCapturerCameraSwitchHandler p0)
		{
			if (id_switchCamera_Lorg_webrtc_CameraVideoCapturer_CameraSwitchHandler_ == IntPtr.Zero)
				id_switchCamera_Lorg_webrtc_CameraVideoCapturer_CameraSwitchHandler_ = JNIEnv.GetMethodID (class_ref, "switchCamera", "(Lorg/webrtc/CameraVideoCapturer$CameraSwitchHandler;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_switchCamera_Lorg_webrtc_CameraVideoCapturer_CameraSwitchHandler_, __args);
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
			global::Org.Webrtc.ICameraVideoCapturer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICameraVideoCapturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.ICameraVideoCapturerCameraSwitchHandler p0 = (global::Org.Webrtc.ICameraVideoCapturerCameraSwitchHandler)global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICameraVideoCapturerCameraSwitchHandler> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SwitchCamera (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_switchCamera_Lorg_webrtc_CameraVideoCapturer_CameraSwitchHandler_Ljava_lang_String_;
		public unsafe void SwitchCamera (global::Org.Webrtc.ICameraVideoCapturerCameraSwitchHandler p0, string p1)
		{
			if (id_switchCamera_Lorg_webrtc_CameraVideoCapturer_CameraSwitchHandler_Ljava_lang_String_ == IntPtr.Zero)
				id_switchCamera_Lorg_webrtc_CameraVideoCapturer_CameraSwitchHandler_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "switchCamera", "(Lorg/webrtc/CameraVideoCapturer$CameraSwitchHandler;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_switchCamera_Lorg_webrtc_CameraVideoCapturer_CameraSwitchHandler_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
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
			global::Org.Webrtc.ICameraVideoCapturer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICameraVideoCapturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Webrtc.ICameraVideoCapturer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICameraVideoCapturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Webrtc.ICameraVideoCapturer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICameraVideoCapturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Webrtc.ICameraVideoCapturer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICameraVideoCapturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Webrtc.ICameraVideoCapturer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICameraVideoCapturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Webrtc.ICameraVideoCapturer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICameraVideoCapturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
