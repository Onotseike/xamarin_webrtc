using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc.Voiceengine {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioTrack']"
	[global::Android.Runtime.Register ("org/webrtc/voiceengine/WebRtcAudioTrack", DoNotGenerateAcw=true)]
	public partial class WebRtcAudioTrack : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioTrack.AudioTrackStartErrorCode']"
		[global::Android.Runtime.Register ("org/webrtc/voiceengine/WebRtcAudioTrack$AudioTrackStartErrorCode", DoNotGenerateAcw=true)]
		public sealed partial class AudioTrackStartErrorCode : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioTrack.AudioTrackStartErrorCode']/field[@name='AUDIO_TRACK_START_EXCEPTION']"
			[Register ("AUDIO_TRACK_START_EXCEPTION")]
			public static global::Org.Webrtc.Voiceengine.WebRtcAudioTrack.AudioTrackStartErrorCode AudioTrackStartException {
				get {
					const string __id = "AUDIO_TRACK_START_EXCEPTION.Lorg/webrtc/voiceengine/WebRtcAudioTrack$AudioTrackStartErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Voiceengine.WebRtcAudioTrack.AudioTrackStartErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioTrack.AudioTrackStartErrorCode']/field[@name='AUDIO_TRACK_START_STATE_MISMATCH']"
			[Register ("AUDIO_TRACK_START_STATE_MISMATCH")]
			public static global::Org.Webrtc.Voiceengine.WebRtcAudioTrack.AudioTrackStartErrorCode AudioTrackStartStateMismatch {
				get {
					const string __id = "AUDIO_TRACK_START_STATE_MISMATCH.Lorg/webrtc/voiceengine/WebRtcAudioTrack$AudioTrackStartErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Voiceengine.WebRtcAudioTrack.AudioTrackStartErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/voiceengine/WebRtcAudioTrack$AudioTrackStartErrorCode", typeof (AudioTrackStartErrorCode));
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

			internal AudioTrackStartErrorCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioTrack.AudioTrackStartErrorCode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/voiceengine/WebRtcAudioTrack$AudioTrackStartErrorCode;", "")]
			public static unsafe global::Org.Webrtc.Voiceengine.WebRtcAudioTrack.AudioTrackStartErrorCode ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/webrtc/voiceengine/WebRtcAudioTrack$AudioTrackStartErrorCode;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Voiceengine.WebRtcAudioTrack.AudioTrackStartErrorCode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioTrack.AudioTrackStartErrorCode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/voiceengine/WebRtcAudioTrack$AudioTrackStartErrorCode;", "")]
			public static unsafe global::Org.Webrtc.Voiceengine.WebRtcAudioTrack.AudioTrackStartErrorCode[] Values ()
			{
				const string __id = "values.()[Lorg/webrtc/voiceengine/WebRtcAudioTrack$AudioTrackStartErrorCode;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Webrtc.Voiceengine.WebRtcAudioTrack.AudioTrackStartErrorCode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.Voiceengine.WebRtcAudioTrack.AudioTrackStartErrorCode));
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc.voiceengine']/interface[@name='WebRtcAudioTrack.ErrorCallback']"
		[Register ("org/webrtc/voiceengine/WebRtcAudioTrack$ErrorCallback", "", "Org.Webrtc.Voiceengine.WebRtcAudioTrack/IErrorCallbackInvoker")]
		public partial interface IErrorCallback : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/interface[@name='WebRtcAudioTrack.ErrorCallback']/method[@name='onWebRtcAudioTrackError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onWebRtcAudioTrackError", "(Ljava/lang/String;)V", "GetOnWebRtcAudioTrackError_Ljava_lang_String_Handler:Org.Webrtc.Voiceengine.WebRtcAudioTrack/IErrorCallbackInvoker, webrtc_android")]
			void OnWebRtcAudioTrackError (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/interface[@name='WebRtcAudioTrack.ErrorCallback']/method[@name='onWebRtcAudioTrackInitError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onWebRtcAudioTrackInitError", "(Ljava/lang/String;)V", "GetOnWebRtcAudioTrackInitError_Ljava_lang_String_Handler:Org.Webrtc.Voiceengine.WebRtcAudioTrack/IErrorCallbackInvoker, webrtc_android")]
			void OnWebRtcAudioTrackInitError (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/interface[@name='WebRtcAudioTrack.ErrorCallback']/method[@name='onWebRtcAudioTrackStartError' and count(parameter)=2 and parameter[1][@type='org.webrtc.voiceengine.WebRtcAudioTrack.AudioTrackStartErrorCode'] and parameter[2][@type='java.lang.String']]"
			[Register ("onWebRtcAudioTrackStartError", "(Lorg/webrtc/voiceengine/WebRtcAudioTrack$AudioTrackStartErrorCode;Ljava/lang/String;)V", "GetOnWebRtcAudioTrackStartError_Lorg_webrtc_voiceengine_WebRtcAudioTrack_AudioTrackStartErrorCode_Ljava_lang_String_Handler:Org.Webrtc.Voiceengine.WebRtcAudioTrack/IErrorCallbackInvoker, webrtc_android")]
			void OnWebRtcAudioTrackStartError (global::Org.Webrtc.Voiceengine.WebRtcAudioTrack.AudioTrackStartErrorCode p0, string p1);

		}

		[global::Android.Runtime.Register ("org/webrtc/voiceengine/WebRtcAudioTrack$ErrorCallback", DoNotGenerateAcw=true)]
		internal partial class IErrorCallbackInvoker : global::Java.Lang.Object, IErrorCallback {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/voiceengine/WebRtcAudioTrack$ErrorCallback", typeof (IErrorCallbackInvoker));

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

			public static IErrorCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IErrorCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.voiceengine.WebRtcAudioTrack.ErrorCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IErrorCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onWebRtcAudioTrackError_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnWebRtcAudioTrackError_Ljava_lang_String_Handler ()
			{
				if (cb_onWebRtcAudioTrackError_Ljava_lang_String_ == null)
					cb_onWebRtcAudioTrackError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnWebRtcAudioTrackError_Ljava_lang_String_);
				return cb_onWebRtcAudioTrackError_Ljava_lang_String_;
			}

			static void n_OnWebRtcAudioTrackError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.Voiceengine.WebRtcAudioTrack.IErrorCallback __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Voiceengine.WebRtcAudioTrack.IErrorCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnWebRtcAudioTrackError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onWebRtcAudioTrackError_Ljava_lang_String_;
			public unsafe void OnWebRtcAudioTrackError (string p0)
			{
				if (id_onWebRtcAudioTrackError_Ljava_lang_String_ == IntPtr.Zero)
					id_onWebRtcAudioTrackError_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onWebRtcAudioTrackError", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWebRtcAudioTrackError_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_onWebRtcAudioTrackInitError_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnWebRtcAudioTrackInitError_Ljava_lang_String_Handler ()
			{
				if (cb_onWebRtcAudioTrackInitError_Ljava_lang_String_ == null)
					cb_onWebRtcAudioTrackInitError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnWebRtcAudioTrackInitError_Ljava_lang_String_);
				return cb_onWebRtcAudioTrackInitError_Ljava_lang_String_;
			}

			static void n_OnWebRtcAudioTrackInitError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.Voiceengine.WebRtcAudioTrack.IErrorCallback __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Voiceengine.WebRtcAudioTrack.IErrorCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnWebRtcAudioTrackInitError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onWebRtcAudioTrackInitError_Ljava_lang_String_;
			public unsafe void OnWebRtcAudioTrackInitError (string p0)
			{
				if (id_onWebRtcAudioTrackInitError_Ljava_lang_String_ == IntPtr.Zero)
					id_onWebRtcAudioTrackInitError_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onWebRtcAudioTrackInitError", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWebRtcAudioTrackInitError_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_onWebRtcAudioTrackStartError_Lorg_webrtc_voiceengine_WebRtcAudioTrack_AudioTrackStartErrorCode_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnWebRtcAudioTrackStartError_Lorg_webrtc_voiceengine_WebRtcAudioTrack_AudioTrackStartErrorCode_Ljava_lang_String_Handler ()
			{
				if (cb_onWebRtcAudioTrackStartError_Lorg_webrtc_voiceengine_WebRtcAudioTrack_AudioTrackStartErrorCode_Ljava_lang_String_ == null)
					cb_onWebRtcAudioTrackStartError_Lorg_webrtc_voiceengine_WebRtcAudioTrack_AudioTrackStartErrorCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnWebRtcAudioTrackStartError_Lorg_webrtc_voiceengine_WebRtcAudioTrack_AudioTrackStartErrorCode_Ljava_lang_String_);
				return cb_onWebRtcAudioTrackStartError_Lorg_webrtc_voiceengine_WebRtcAudioTrack_AudioTrackStartErrorCode_Ljava_lang_String_;
			}

			static void n_OnWebRtcAudioTrackStartError_Lorg_webrtc_voiceengine_WebRtcAudioTrack_AudioTrackStartErrorCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Org.Webrtc.Voiceengine.WebRtcAudioTrack.IErrorCallback __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Voiceengine.WebRtcAudioTrack.IErrorCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.Voiceengine.WebRtcAudioTrack.AudioTrackStartErrorCode p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Voiceengine.WebRtcAudioTrack.AudioTrackStartErrorCode> (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnWebRtcAudioTrackStartError (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onWebRtcAudioTrackStartError_Lorg_webrtc_voiceengine_WebRtcAudioTrack_AudioTrackStartErrorCode_Ljava_lang_String_;
			public unsafe void OnWebRtcAudioTrackStartError (global::Org.Webrtc.Voiceengine.WebRtcAudioTrack.AudioTrackStartErrorCode p0, string p1)
			{
				if (id_onWebRtcAudioTrackStartError_Lorg_webrtc_voiceengine_WebRtcAudioTrack_AudioTrackStartErrorCode_Ljava_lang_String_ == IntPtr.Zero)
					id_onWebRtcAudioTrackStartError_Lorg_webrtc_voiceengine_WebRtcAudioTrack_AudioTrackStartErrorCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onWebRtcAudioTrackStartError", "(Lorg/webrtc/voiceengine/WebRtcAudioTrack$AudioTrackStartErrorCode;Ljava/lang/String;)V");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWebRtcAudioTrackStartError_Lorg_webrtc_voiceengine_WebRtcAudioTrack_AudioTrackStartErrorCode_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p1);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc.voiceengine']/interface[@name='WebRtcAudioTrack.WebRtcAudioTrackErrorCallback']"
		[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
		[Register ("org/webrtc/voiceengine/WebRtcAudioTrack$WebRtcAudioTrackErrorCallback", "", "Org.Webrtc.Voiceengine.WebRtcAudioTrack/IWebRtcAudioTrackErrorCallbackInvoker")]
		public partial interface IWebRtcAudioTrackErrorCallback : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/interface[@name='WebRtcAudioTrack.WebRtcAudioTrackErrorCallback']/method[@name='onWebRtcAudioTrackError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onWebRtcAudioTrackError", "(Ljava/lang/String;)V", "GetOnWebRtcAudioTrackError_Ljava_lang_String_Handler:Org.Webrtc.Voiceengine.WebRtcAudioTrack/IWebRtcAudioTrackErrorCallbackInvoker, webrtc_android")]
			void OnWebRtcAudioTrackError (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/interface[@name='WebRtcAudioTrack.WebRtcAudioTrackErrorCallback']/method[@name='onWebRtcAudioTrackInitError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onWebRtcAudioTrackInitError", "(Ljava/lang/String;)V", "GetOnWebRtcAudioTrackInitError_Ljava_lang_String_Handler:Org.Webrtc.Voiceengine.WebRtcAudioTrack/IWebRtcAudioTrackErrorCallbackInvoker, webrtc_android")]
			void OnWebRtcAudioTrackInitError (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/interface[@name='WebRtcAudioTrack.WebRtcAudioTrackErrorCallback']/method[@name='onWebRtcAudioTrackStartError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onWebRtcAudioTrackStartError", "(Ljava/lang/String;)V", "GetOnWebRtcAudioTrackStartError_Ljava_lang_String_Handler:Org.Webrtc.Voiceengine.WebRtcAudioTrack/IWebRtcAudioTrackErrorCallbackInvoker, webrtc_android")]
			void OnWebRtcAudioTrackStartError (string p0);

		}

		[global::Android.Runtime.Register ("org/webrtc/voiceengine/WebRtcAudioTrack$WebRtcAudioTrackErrorCallback", DoNotGenerateAcw=true)]
		internal partial class IWebRtcAudioTrackErrorCallbackInvoker : global::Java.Lang.Object, IWebRtcAudioTrackErrorCallback {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/voiceengine/WebRtcAudioTrack$WebRtcAudioTrackErrorCallback", typeof (IWebRtcAudioTrackErrorCallbackInvoker));

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

			public static IWebRtcAudioTrackErrorCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IWebRtcAudioTrackErrorCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.voiceengine.WebRtcAudioTrack.WebRtcAudioTrackErrorCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IWebRtcAudioTrackErrorCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onWebRtcAudioTrackError_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnWebRtcAudioTrackError_Ljava_lang_String_Handler ()
			{
				if (cb_onWebRtcAudioTrackError_Ljava_lang_String_ == null)
					cb_onWebRtcAudioTrackError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnWebRtcAudioTrackError_Ljava_lang_String_);
				return cb_onWebRtcAudioTrackError_Ljava_lang_String_;
			}

			static void n_OnWebRtcAudioTrackError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.Voiceengine.WebRtcAudioTrack.IWebRtcAudioTrackErrorCallback __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Voiceengine.WebRtcAudioTrack.IWebRtcAudioTrackErrorCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnWebRtcAudioTrackError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onWebRtcAudioTrackError_Ljava_lang_String_;
			public unsafe void OnWebRtcAudioTrackError (string p0)
			{
				if (id_onWebRtcAudioTrackError_Ljava_lang_String_ == IntPtr.Zero)
					id_onWebRtcAudioTrackError_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onWebRtcAudioTrackError", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWebRtcAudioTrackError_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_onWebRtcAudioTrackInitError_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnWebRtcAudioTrackInitError_Ljava_lang_String_Handler ()
			{
				if (cb_onWebRtcAudioTrackInitError_Ljava_lang_String_ == null)
					cb_onWebRtcAudioTrackInitError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnWebRtcAudioTrackInitError_Ljava_lang_String_);
				return cb_onWebRtcAudioTrackInitError_Ljava_lang_String_;
			}

			static void n_OnWebRtcAudioTrackInitError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.Voiceengine.WebRtcAudioTrack.IWebRtcAudioTrackErrorCallback __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Voiceengine.WebRtcAudioTrack.IWebRtcAudioTrackErrorCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnWebRtcAudioTrackInitError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onWebRtcAudioTrackInitError_Ljava_lang_String_;
			public unsafe void OnWebRtcAudioTrackInitError (string p0)
			{
				if (id_onWebRtcAudioTrackInitError_Ljava_lang_String_ == IntPtr.Zero)
					id_onWebRtcAudioTrackInitError_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onWebRtcAudioTrackInitError", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWebRtcAudioTrackInitError_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_onWebRtcAudioTrackStartError_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnWebRtcAudioTrackStartError_Ljava_lang_String_Handler ()
			{
				if (cb_onWebRtcAudioTrackStartError_Ljava_lang_String_ == null)
					cb_onWebRtcAudioTrackStartError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnWebRtcAudioTrackStartError_Ljava_lang_String_);
				return cb_onWebRtcAudioTrackStartError_Ljava_lang_String_;
			}

			static void n_OnWebRtcAudioTrackStartError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.Voiceengine.WebRtcAudioTrack.IWebRtcAudioTrackErrorCallback __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Voiceengine.WebRtcAudioTrack.IWebRtcAudioTrackErrorCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnWebRtcAudioTrackStartError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onWebRtcAudioTrackStartError_Ljava_lang_String_;
			public unsafe void OnWebRtcAudioTrackStartError (string p0)
			{
				if (id_onWebRtcAudioTrackStartError_Ljava_lang_String_ == IntPtr.Zero)
					id_onWebRtcAudioTrackStartError_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onWebRtcAudioTrackStartError", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWebRtcAudioTrackStartError_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/voiceengine/WebRtcAudioTrack", typeof (WebRtcAudioTrack));
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

		protected WebRtcAudioTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioTrack']/method[@name='setAudioTrackUsageAttribute' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAudioTrackUsageAttribute", "(I)V", "")]
		public static unsafe void SetAudioTrackUsageAttribute (int usage)
		{
			const string __id = "setAudioTrackUsageAttribute.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (usage);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioTrack']/method[@name='setErrorCallback' and count(parameter)=1 and parameter[1][@type='org.webrtc.voiceengine.WebRtcAudioTrack.ErrorCallback']]"
		[Register ("setErrorCallback", "(Lorg/webrtc/voiceengine/WebRtcAudioTrack$ErrorCallback;)V", "")]
		public static unsafe void SetErrorCallback (global::Org.Webrtc.Voiceengine.WebRtcAudioTrack.IErrorCallback errorCallback)
		{
			const string __id = "setErrorCallback.(Lorg/webrtc/voiceengine/WebRtcAudioTrack$ErrorCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((errorCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) errorCallback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioTrack']/method[@name='setErrorCallback' and count(parameter)=1 and parameter[1][@type='org.webrtc.voiceengine.WebRtcAudioTrack.WebRtcAudioTrackErrorCallback']]"
		[Obsolete (@"deprecated")]
		[Register ("setErrorCallback", "(Lorg/webrtc/voiceengine/WebRtcAudioTrack$WebRtcAudioTrackErrorCallback;)V", "")]
		public static unsafe void SetErrorCallback (global::Org.Webrtc.Voiceengine.WebRtcAudioTrack.IWebRtcAudioTrackErrorCallback errorCallback)
		{
			const string __id = "setErrorCallback.(Lorg/webrtc/voiceengine/WebRtcAudioTrack$WebRtcAudioTrackErrorCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((errorCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) errorCallback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioTrack']/method[@name='setSpeakerMute' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSpeakerMute", "(Z)V", "")]
		public static unsafe void SetSpeakerMute (bool mute)
		{
			const string __id = "setSpeakerMute.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (mute);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
