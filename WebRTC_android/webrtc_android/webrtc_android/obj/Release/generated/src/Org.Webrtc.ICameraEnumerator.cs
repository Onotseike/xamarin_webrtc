using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='CameraEnumerator']"
	[Register ("org/webrtc/CameraEnumerator", "", "Org.Webrtc.ICameraEnumeratorInvoker")]
	public partial interface ICameraEnumerator : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='CameraEnumerator']/method[@name='createCapturer' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.webrtc.CameraVideoCapturer.CameraEventsHandler']]"
		[Register ("createCapturer", "(Ljava/lang/String;Lorg/webrtc/CameraVideoCapturer$CameraEventsHandler;)Lorg/webrtc/CameraVideoCapturer;", "GetCreateCapturer_Ljava_lang_String_Lorg_webrtc_CameraVideoCapturer_CameraEventsHandler_Handler:Org.Webrtc.ICameraEnumeratorInvoker, webrtc_android")]
		global::Org.Webrtc.ICameraVideoCapturer CreateCapturer (string p0, global::Org.Webrtc.ICameraVideoCapturerCameraEventsHandler p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='CameraEnumerator']/method[@name='getDeviceNames' and count(parameter)=0]"
		[Register ("getDeviceNames", "()[Ljava/lang/String;", "GetGetDeviceNamesHandler:Org.Webrtc.ICameraEnumeratorInvoker, webrtc_android")]
		string[] GetDeviceNames ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='CameraEnumerator']/method[@name='getSupportedFormats' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSupportedFormats", "(Ljava/lang/String;)Ljava/util/List;", "GetGetSupportedFormats_Ljava_lang_String_Handler:Org.Webrtc.ICameraEnumeratorInvoker, webrtc_android")]
		global::System.Collections.Generic.IList<global::Org.Webrtc.CameraEnumerationAndroid.CaptureFormat> GetSupportedFormats (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='CameraEnumerator']/method[@name='isBackFacing' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isBackFacing", "(Ljava/lang/String;)Z", "GetIsBackFacing_Ljava_lang_String_Handler:Org.Webrtc.ICameraEnumeratorInvoker, webrtc_android")]
		bool IsBackFacing (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='CameraEnumerator']/method[@name='isFrontFacing' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isFrontFacing", "(Ljava/lang/String;)Z", "GetIsFrontFacing_Ljava_lang_String_Handler:Org.Webrtc.ICameraEnumeratorInvoker, webrtc_android")]
		bool IsFrontFacing (string p0);

	}

	[global::Android.Runtime.Register ("org/webrtc/CameraEnumerator", DoNotGenerateAcw=true)]
	internal partial class ICameraEnumeratorInvoker : global::Java.Lang.Object, ICameraEnumerator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/CameraEnumerator", typeof (ICameraEnumeratorInvoker));

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

		public static ICameraEnumerator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICameraEnumerator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.CameraEnumerator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICameraEnumeratorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_createCapturer_Ljava_lang_String_Lorg_webrtc_CameraVideoCapturer_CameraEventsHandler_;
#pragma warning disable 0169
		static Delegate GetCreateCapturer_Ljava_lang_String_Lorg_webrtc_CameraVideoCapturer_CameraEventsHandler_Handler ()
		{
			if (cb_createCapturer_Ljava_lang_String_Lorg_webrtc_CameraVideoCapturer_CameraEventsHandler_ == null)
				cb_createCapturer_Ljava_lang_String_Lorg_webrtc_CameraVideoCapturer_CameraEventsHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateCapturer_Ljava_lang_String_Lorg_webrtc_CameraVideoCapturer_CameraEventsHandler_);
			return cb_createCapturer_Ljava_lang_String_Lorg_webrtc_CameraVideoCapturer_CameraEventsHandler_;
		}

		static IntPtr n_CreateCapturer_Ljava_lang_String_Lorg_webrtc_CameraVideoCapturer_CameraEventsHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Webrtc.ICameraEnumerator __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICameraEnumerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.ICameraVideoCapturerCameraEventsHandler p1 = (global::Org.Webrtc.ICameraVideoCapturerCameraEventsHandler)global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICameraVideoCapturerCameraEventsHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateCapturer (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createCapturer_Ljava_lang_String_Lorg_webrtc_CameraVideoCapturer_CameraEventsHandler_;
		public unsafe global::Org.Webrtc.ICameraVideoCapturer CreateCapturer (string p0, global::Org.Webrtc.ICameraVideoCapturerCameraEventsHandler p1)
		{
			if (id_createCapturer_Ljava_lang_String_Lorg_webrtc_CameraVideoCapturer_CameraEventsHandler_ == IntPtr.Zero)
				id_createCapturer_Ljava_lang_String_Lorg_webrtc_CameraVideoCapturer_CameraEventsHandler_ = JNIEnv.GetMethodID (class_ref, "createCapturer", "(Ljava/lang/String;Lorg/webrtc/CameraVideoCapturer$CameraEventsHandler;)Lorg/webrtc/CameraVideoCapturer;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Org.Webrtc.ICameraVideoCapturer __ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICameraVideoCapturer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createCapturer_Ljava_lang_String_Lorg_webrtc_CameraVideoCapturer_CameraEventsHandler_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getDeviceNames;
#pragma warning disable 0169
		static Delegate GetGetDeviceNamesHandler ()
		{
			if (cb_getDeviceNames == null)
				cb_getDeviceNames = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceNames);
			return cb_getDeviceNames;
		}

		static IntPtr n_GetDeviceNames (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.ICameraEnumerator __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICameraEnumerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDeviceNames ());
		}
#pragma warning restore 0169

		IntPtr id_getDeviceNames;
		public unsafe string[] GetDeviceNames ()
		{
			if (id_getDeviceNames == IntPtr.Zero)
				id_getDeviceNames = JNIEnv.GetMethodID (class_ref, "getDeviceNames", "()[Ljava/lang/String;");
			return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceNames), JniHandleOwnership.TransferLocalRef, typeof (string));
		}

		static Delegate cb_getSupportedFormats_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSupportedFormats_Ljava_lang_String_Handler ()
		{
			if (cb_getSupportedFormats_Ljava_lang_String_ == null)
				cb_getSupportedFormats_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSupportedFormats_Ljava_lang_String_);
			return cb_getSupportedFormats_Ljava_lang_String_;
		}

		static IntPtr n_GetSupportedFormats_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.ICameraEnumerator __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICameraEnumerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Org.Webrtc.CameraEnumerationAndroid.CaptureFormat>.ToLocalJniHandle (__this.GetSupportedFormats (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getSupportedFormats_Ljava_lang_String_;
		public unsafe global::System.Collections.Generic.IList<global::Org.Webrtc.CameraEnumerationAndroid.CaptureFormat> GetSupportedFormats (string p0)
		{
			if (id_getSupportedFormats_Ljava_lang_String_ == IntPtr.Zero)
				id_getSupportedFormats_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getSupportedFormats", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::System.Collections.Generic.IList<global::Org.Webrtc.CameraEnumerationAndroid.CaptureFormat> __ret = global::Android.Runtime.JavaList<global::Org.Webrtc.CameraEnumerationAndroid.CaptureFormat>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSupportedFormats_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_isBackFacing_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsBackFacing_Ljava_lang_String_Handler ()
		{
			if (cb_isBackFacing_Ljava_lang_String_ == null)
				cb_isBackFacing_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsBackFacing_Ljava_lang_String_);
			return cb_isBackFacing_Ljava_lang_String_;
		}

		static bool n_IsBackFacing_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.ICameraEnumerator __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICameraEnumerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsBackFacing (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isBackFacing_Ljava_lang_String_;
		public unsafe bool IsBackFacing (string p0)
		{
			if (id_isBackFacing_Ljava_lang_String_ == IntPtr.Zero)
				id_isBackFacing_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isBackFacing", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isBackFacing_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_isFrontFacing_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsFrontFacing_Ljava_lang_String_Handler ()
		{
			if (cb_isFrontFacing_Ljava_lang_String_ == null)
				cb_isFrontFacing_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsFrontFacing_Ljava_lang_String_);
			return cb_isFrontFacing_Ljava_lang_String_;
		}

		static bool n_IsFrontFacing_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.ICameraEnumerator __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICameraEnumerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsFrontFacing (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isFrontFacing_Ljava_lang_String_;
		public unsafe bool IsFrontFacing (string p0)
		{
			if (id_isFrontFacing_Ljava_lang_String_ == IntPtr.Zero)
				id_isFrontFacing_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isFrontFacing", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isFrontFacing_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
