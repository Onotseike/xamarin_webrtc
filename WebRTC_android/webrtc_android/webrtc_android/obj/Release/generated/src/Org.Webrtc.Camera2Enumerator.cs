using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='Camera2Enumerator']"
	[global::Android.Runtime.Register ("org/webrtc/Camera2Enumerator", DoNotGenerateAcw=true)]
	public partial class Camera2Enumerator : global::Java.Lang.Object, global::Org.Webrtc.ICameraEnumerator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/Camera2Enumerator", typeof (Camera2Enumerator));
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

		protected Camera2Enumerator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='Camera2Enumerator']/constructor[@name='Camera2Enumerator' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe Camera2Enumerator (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_createCapturer_Ljava_lang_String_Lorg_webrtc_CameraVideoCapturer_CameraEventsHandler_;
#pragma warning disable 0169
		static Delegate GetCreateCapturer_Ljava_lang_String_Lorg_webrtc_CameraVideoCapturer_CameraEventsHandler_Handler ()
		{
			if (cb_createCapturer_Ljava_lang_String_Lorg_webrtc_CameraVideoCapturer_CameraEventsHandler_ == null)
				cb_createCapturer_Ljava_lang_String_Lorg_webrtc_CameraVideoCapturer_CameraEventsHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateCapturer_Ljava_lang_String_Lorg_webrtc_CameraVideoCapturer_CameraEventsHandler_);
			return cb_createCapturer_Ljava_lang_String_Lorg_webrtc_CameraVideoCapturer_CameraEventsHandler_;
		}

		static IntPtr n_CreateCapturer_Ljava_lang_String_Lorg_webrtc_CameraVideoCapturer_CameraEventsHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_deviceName, IntPtr native_eventsHandler)
		{
			global::Org.Webrtc.Camera2Enumerator __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Camera2Enumerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string deviceName = JNIEnv.GetString (native_deviceName, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.ICameraVideoCapturerCameraEventsHandler eventsHandler = (global::Org.Webrtc.ICameraVideoCapturerCameraEventsHandler)global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICameraVideoCapturerCameraEventsHandler> (native_eventsHandler, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateCapturer (deviceName, eventsHandler));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Camera2Enumerator']/method[@name='createCapturer' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.webrtc.CameraVideoCapturer.CameraEventsHandler']]"
		[Register ("createCapturer", "(Ljava/lang/String;Lorg/webrtc/CameraVideoCapturer$CameraEventsHandler;)Lorg/webrtc/CameraVideoCapturer;", "GetCreateCapturer_Ljava_lang_String_Lorg_webrtc_CameraVideoCapturer_CameraEventsHandler_Handler")]
		public virtual unsafe global::Org.Webrtc.ICameraVideoCapturer CreateCapturer (string deviceName, global::Org.Webrtc.ICameraVideoCapturerCameraEventsHandler eventsHandler)
		{
			const string __id = "createCapturer.(Ljava/lang/String;Lorg/webrtc/CameraVideoCapturer$CameraEventsHandler;)Lorg/webrtc/CameraVideoCapturer;";
			IntPtr native_deviceName = JNIEnv.NewString (deviceName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_deviceName);
				__args [1] = new JniArgumentValue ((eventsHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventsHandler).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICameraVideoCapturer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_deviceName);
			}
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
			global::Org.Webrtc.Camera2Enumerator __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Camera2Enumerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDeviceNames ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Camera2Enumerator']/method[@name='getDeviceNames' and count(parameter)=0]"
		[Register ("getDeviceNames", "()[Ljava/lang/String;", "GetGetDeviceNamesHandler")]
		public virtual unsafe string[] GetDeviceNames ()
		{
			const string __id = "getDeviceNames.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_getSupportedFormats_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSupportedFormats_Ljava_lang_String_Handler ()
		{
			if (cb_getSupportedFormats_Ljava_lang_String_ == null)
				cb_getSupportedFormats_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSupportedFormats_Ljava_lang_String_);
			return cb_getSupportedFormats_Ljava_lang_String_;
		}

		static IntPtr n_GetSupportedFormats_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_deviceName)
		{
			global::Org.Webrtc.Camera2Enumerator __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Camera2Enumerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string deviceName = JNIEnv.GetString (native_deviceName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Org.Webrtc.CameraEnumerationAndroid.CaptureFormat>.ToLocalJniHandle (__this.GetSupportedFormats (deviceName));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Camera2Enumerator']/method[@name='getSupportedFormats' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSupportedFormats", "(Ljava/lang/String;)Ljava/util/List;", "GetGetSupportedFormats_Ljava_lang_String_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Webrtc.CameraEnumerationAndroid.CaptureFormat> GetSupportedFormats (string deviceName)
		{
			const string __id = "getSupportedFormats.(Ljava/lang/String;)Ljava/util/List;";
			IntPtr native_deviceName = JNIEnv.NewString (deviceName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_deviceName);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Org.Webrtc.CameraEnumerationAndroid.CaptureFormat>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_deviceName);
			}
		}

		static Delegate cb_isBackFacing_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsBackFacing_Ljava_lang_String_Handler ()
		{
			if (cb_isBackFacing_Ljava_lang_String_ == null)
				cb_isBackFacing_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsBackFacing_Ljava_lang_String_);
			return cb_isBackFacing_Ljava_lang_String_;
		}

		static bool n_IsBackFacing_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_deviceName)
		{
			global::Org.Webrtc.Camera2Enumerator __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Camera2Enumerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string deviceName = JNIEnv.GetString (native_deviceName, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsBackFacing (deviceName);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Camera2Enumerator']/method[@name='isBackFacing' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isBackFacing", "(Ljava/lang/String;)Z", "GetIsBackFacing_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsBackFacing (string deviceName)
		{
			const string __id = "isBackFacing.(Ljava/lang/String;)Z";
			IntPtr native_deviceName = JNIEnv.NewString (deviceName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_deviceName);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_deviceName);
			}
		}

		static Delegate cb_isFrontFacing_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsFrontFacing_Ljava_lang_String_Handler ()
		{
			if (cb_isFrontFacing_Ljava_lang_String_ == null)
				cb_isFrontFacing_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsFrontFacing_Ljava_lang_String_);
			return cb_isFrontFacing_Ljava_lang_String_;
		}

		static bool n_IsFrontFacing_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_deviceName)
		{
			global::Org.Webrtc.Camera2Enumerator __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Camera2Enumerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string deviceName = JNIEnv.GetString (native_deviceName, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsFrontFacing (deviceName);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Camera2Enumerator']/method[@name='isFrontFacing' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isFrontFacing", "(Ljava/lang/String;)Z", "GetIsFrontFacing_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsFrontFacing (string deviceName)
		{
			const string __id = "isFrontFacing.(Ljava/lang/String;)Z";
			IntPtr native_deviceName = JNIEnv.NewString (deviceName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_deviceName);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_deviceName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Camera2Enumerator']/method[@name='isSupported' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isSupported", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsSupported (global::Android.Content.Context context)
		{
			const string __id = "isSupported.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
