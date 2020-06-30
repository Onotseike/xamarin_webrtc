using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='Loggable']"
	[Register ("org/webrtc/Loggable", "", "Org.Webrtc.ILoggableInvoker")]
	public partial interface ILoggable : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='Loggable']/method[@name='onLogMessage' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.webrtc.Logging.Severity'] and parameter[3][@type='java.lang.String']]"
		[Register ("onLogMessage", "(Ljava/lang/String;Lorg/webrtc/Logging$Severity;Ljava/lang/String;)V", "GetOnLogMessage_Ljava_lang_String_Lorg_webrtc_Logging_Severity_Ljava_lang_String_Handler:Org.Webrtc.ILoggableInvoker, webrtc_android")]
		void OnLogMessage (string p0, global::Org.Webrtc.Logging.Severity p1, string p2);

	}

	[global::Android.Runtime.Register ("org/webrtc/Loggable", DoNotGenerateAcw=true)]
	internal partial class ILoggableInvoker : global::Java.Lang.Object, ILoggable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/Loggable", typeof (ILoggableInvoker));

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

		public static ILoggable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILoggable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.Loggable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILoggableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onLogMessage_Ljava_lang_String_Lorg_webrtc_Logging_Severity_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnLogMessage_Ljava_lang_String_Lorg_webrtc_Logging_Severity_Ljava_lang_String_Handler ()
		{
			if (cb_onLogMessage_Ljava_lang_String_Lorg_webrtc_Logging_Severity_Ljava_lang_String_ == null)
				cb_onLogMessage_Ljava_lang_String_Lorg_webrtc_Logging_Severity_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnLogMessage_Ljava_lang_String_Lorg_webrtc_Logging_Severity_Ljava_lang_String_);
			return cb_onLogMessage_Ljava_lang_String_Lorg_webrtc_Logging_Severity_Ljava_lang_String_;
		}

		static void n_OnLogMessage_Ljava_lang_String_Lorg_webrtc_Logging_Severity_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Webrtc.ILoggable __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ILoggable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.Logging.Severity p1 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.Severity> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnLogMessage (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onLogMessage_Ljava_lang_String_Lorg_webrtc_Logging_Severity_Ljava_lang_String_;
		public unsafe void OnLogMessage (string p0, global::Org.Webrtc.Logging.Severity p1, string p2)
		{
			if (id_onLogMessage_Ljava_lang_String_Lorg_webrtc_Logging_Severity_Ljava_lang_String_ == IntPtr.Zero)
				id_onLogMessage_Ljava_lang_String_Lorg_webrtc_Logging_Severity_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onLogMessage", "(Ljava/lang/String;Lorg/webrtc/Logging$Severity;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLogMessage_Ljava_lang_String_Lorg_webrtc_Logging_Severity_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}

}
