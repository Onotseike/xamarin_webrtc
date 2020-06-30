using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc.Voiceengine {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioRecord']"
	[global::Android.Runtime.Register ("org/webrtc/voiceengine/WebRtcAudioRecord", DoNotGenerateAcw=true)]
	public partial class WebRtcAudioRecord : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioRecord.AudioRecordStartErrorCode']"
		[global::Android.Runtime.Register ("org/webrtc/voiceengine/WebRtcAudioRecord$AudioRecordStartErrorCode", DoNotGenerateAcw=true)]
		public sealed partial class AudioRecordStartErrorCode : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioRecord.AudioRecordStartErrorCode']/field[@name='AUDIO_RECORD_START_EXCEPTION']"
			[Register ("AUDIO_RECORD_START_EXCEPTION")]
			public static global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.AudioRecordStartErrorCode AudioRecordStartException {
				get {
					const string __id = "AUDIO_RECORD_START_EXCEPTION.Lorg/webrtc/voiceengine/WebRtcAudioRecord$AudioRecordStartErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.AudioRecordStartErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioRecord.AudioRecordStartErrorCode']/field[@name='AUDIO_RECORD_START_STATE_MISMATCH']"
			[Register ("AUDIO_RECORD_START_STATE_MISMATCH")]
			public static global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.AudioRecordStartErrorCode AudioRecordStartStateMismatch {
				get {
					const string __id = "AUDIO_RECORD_START_STATE_MISMATCH.Lorg/webrtc/voiceengine/WebRtcAudioRecord$AudioRecordStartErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.AudioRecordStartErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/voiceengine/WebRtcAudioRecord$AudioRecordStartErrorCode", typeof (AudioRecordStartErrorCode));
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

			internal AudioRecordStartErrorCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioRecord.AudioRecordStartErrorCode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/voiceengine/WebRtcAudioRecord$AudioRecordStartErrorCode;", "")]
			public static unsafe global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.AudioRecordStartErrorCode ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/webrtc/voiceengine/WebRtcAudioRecord$AudioRecordStartErrorCode;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.AudioRecordStartErrorCode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioRecord.AudioRecordStartErrorCode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/voiceengine/WebRtcAudioRecord$AudioRecordStartErrorCode;", "")]
			public static unsafe global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.AudioRecordStartErrorCode[] Values ()
			{
				const string __id = "values.()[Lorg/webrtc/voiceengine/WebRtcAudioRecord$AudioRecordStartErrorCode;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.AudioRecordStartErrorCode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.AudioRecordStartErrorCode));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioRecord.AudioSamples']"
		[global::Android.Runtime.Register ("org/webrtc/voiceengine/WebRtcAudioRecord$AudioSamples", DoNotGenerateAcw=true)]
		public partial class AudioSamples : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/voiceengine/WebRtcAudioRecord$AudioSamples", typeof (AudioSamples));
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

			protected AudioSamples (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getAudioFormat;
#pragma warning disable 0169
			static Delegate GetGetAudioFormatHandler ()
			{
				if (cb_getAudioFormat == null)
					cb_getAudioFormat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAudioFormat);
				return cb_getAudioFormat;
			}

			static int n_GetAudioFormat (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.AudioSamples __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.AudioSamples> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.AudioFormat;
			}
#pragma warning restore 0169

			public virtual unsafe int AudioFormat {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioRecord.AudioSamples']/method[@name='getAudioFormat' and count(parameter)=0]"
				[Register ("getAudioFormat", "()I", "GetGetAudioFormatHandler")]
				get {
					const string __id = "getAudioFormat.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getChannelCount;
#pragma warning disable 0169
			static Delegate GetGetChannelCountHandler ()
			{
				if (cb_getChannelCount == null)
					cb_getChannelCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetChannelCount);
				return cb_getChannelCount;
			}

			static int n_GetChannelCount (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.AudioSamples __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.AudioSamples> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ChannelCount;
			}
#pragma warning restore 0169

			public virtual unsafe int ChannelCount {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioRecord.AudioSamples']/method[@name='getChannelCount' and count(parameter)=0]"
				[Register ("getChannelCount", "()I", "GetGetChannelCountHandler")]
				get {
					const string __id = "getChannelCount.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getSampleRate;
#pragma warning disable 0169
			static Delegate GetGetSampleRateHandler ()
			{
				if (cb_getSampleRate == null)
					cb_getSampleRate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSampleRate);
				return cb_getSampleRate;
			}

			static int n_GetSampleRate (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.AudioSamples __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.AudioSamples> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.SampleRate;
			}
#pragma warning restore 0169

			public virtual unsafe int SampleRate {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioRecord.AudioSamples']/method[@name='getSampleRate' and count(parameter)=0]"
				[Register ("getSampleRate", "()I", "GetGetSampleRateHandler")]
				get {
					const string __id = "getSampleRate.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getData;
#pragma warning disable 0169
			static Delegate GetGetDataHandler ()
			{
				if (cb_getData == null)
					cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
				return cb_getData;
			}

			static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.AudioSamples __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.AudioSamples> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetData ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioRecord.AudioSamples']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()[B", "GetGetDataHandler")]
			public virtual unsafe byte[] GetData ()
			{
				const string __id = "getData.()[B";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc.voiceengine']/interface[@name='WebRtcAudioRecord.WebRtcAudioRecordErrorCallback']"
		[Register ("org/webrtc/voiceengine/WebRtcAudioRecord$WebRtcAudioRecordErrorCallback", "", "Org.Webrtc.Voiceengine.WebRtcAudioRecord/IWebRtcAudioRecordErrorCallbackInvoker")]
		public partial interface IWebRtcAudioRecordErrorCallback : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/interface[@name='WebRtcAudioRecord.WebRtcAudioRecordErrorCallback']/method[@name='onWebRtcAudioRecordError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onWebRtcAudioRecordError", "(Ljava/lang/String;)V", "GetOnWebRtcAudioRecordError_Ljava_lang_String_Handler:Org.Webrtc.Voiceengine.WebRtcAudioRecord/IWebRtcAudioRecordErrorCallbackInvoker, webrtc_android")]
			void OnWebRtcAudioRecordError (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/interface[@name='WebRtcAudioRecord.WebRtcAudioRecordErrorCallback']/method[@name='onWebRtcAudioRecordInitError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onWebRtcAudioRecordInitError", "(Ljava/lang/String;)V", "GetOnWebRtcAudioRecordInitError_Ljava_lang_String_Handler:Org.Webrtc.Voiceengine.WebRtcAudioRecord/IWebRtcAudioRecordErrorCallbackInvoker, webrtc_android")]
			void OnWebRtcAudioRecordInitError (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/interface[@name='WebRtcAudioRecord.WebRtcAudioRecordErrorCallback']/method[@name='onWebRtcAudioRecordStartError' and count(parameter)=2 and parameter[1][@type='org.webrtc.voiceengine.WebRtcAudioRecord.AudioRecordStartErrorCode'] and parameter[2][@type='java.lang.String']]"
			[Register ("onWebRtcAudioRecordStartError", "(Lorg/webrtc/voiceengine/WebRtcAudioRecord$AudioRecordStartErrorCode;Ljava/lang/String;)V", "GetOnWebRtcAudioRecordStartError_Lorg_webrtc_voiceengine_WebRtcAudioRecord_AudioRecordStartErrorCode_Ljava_lang_String_Handler:Org.Webrtc.Voiceengine.WebRtcAudioRecord/IWebRtcAudioRecordErrorCallbackInvoker, webrtc_android")]
			void OnWebRtcAudioRecordStartError (global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.AudioRecordStartErrorCode p0, string p1);

		}

		[global::Android.Runtime.Register ("org/webrtc/voiceengine/WebRtcAudioRecord$WebRtcAudioRecordErrorCallback", DoNotGenerateAcw=true)]
		internal partial class IWebRtcAudioRecordErrorCallbackInvoker : global::Java.Lang.Object, IWebRtcAudioRecordErrorCallback {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/voiceengine/WebRtcAudioRecord$WebRtcAudioRecordErrorCallback", typeof (IWebRtcAudioRecordErrorCallbackInvoker));

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

			public static IWebRtcAudioRecordErrorCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IWebRtcAudioRecordErrorCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.voiceengine.WebRtcAudioRecord.WebRtcAudioRecordErrorCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IWebRtcAudioRecordErrorCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onWebRtcAudioRecordError_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnWebRtcAudioRecordError_Ljava_lang_String_Handler ()
			{
				if (cb_onWebRtcAudioRecordError_Ljava_lang_String_ == null)
					cb_onWebRtcAudioRecordError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnWebRtcAudioRecordError_Ljava_lang_String_);
				return cb_onWebRtcAudioRecordError_Ljava_lang_String_;
			}

			static void n_OnWebRtcAudioRecordError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.IWebRtcAudioRecordErrorCallback __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.IWebRtcAudioRecordErrorCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnWebRtcAudioRecordError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onWebRtcAudioRecordError_Ljava_lang_String_;
			public unsafe void OnWebRtcAudioRecordError (string p0)
			{
				if (id_onWebRtcAudioRecordError_Ljava_lang_String_ == IntPtr.Zero)
					id_onWebRtcAudioRecordError_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onWebRtcAudioRecordError", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWebRtcAudioRecordError_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_onWebRtcAudioRecordInitError_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnWebRtcAudioRecordInitError_Ljava_lang_String_Handler ()
			{
				if (cb_onWebRtcAudioRecordInitError_Ljava_lang_String_ == null)
					cb_onWebRtcAudioRecordInitError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnWebRtcAudioRecordInitError_Ljava_lang_String_);
				return cb_onWebRtcAudioRecordInitError_Ljava_lang_String_;
			}

			static void n_OnWebRtcAudioRecordInitError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.IWebRtcAudioRecordErrorCallback __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.IWebRtcAudioRecordErrorCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnWebRtcAudioRecordInitError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onWebRtcAudioRecordInitError_Ljava_lang_String_;
			public unsafe void OnWebRtcAudioRecordInitError (string p0)
			{
				if (id_onWebRtcAudioRecordInitError_Ljava_lang_String_ == IntPtr.Zero)
					id_onWebRtcAudioRecordInitError_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onWebRtcAudioRecordInitError", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWebRtcAudioRecordInitError_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_onWebRtcAudioRecordStartError_Lorg_webrtc_voiceengine_WebRtcAudioRecord_AudioRecordStartErrorCode_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnWebRtcAudioRecordStartError_Lorg_webrtc_voiceengine_WebRtcAudioRecord_AudioRecordStartErrorCode_Ljava_lang_String_Handler ()
			{
				if (cb_onWebRtcAudioRecordStartError_Lorg_webrtc_voiceengine_WebRtcAudioRecord_AudioRecordStartErrorCode_Ljava_lang_String_ == null)
					cb_onWebRtcAudioRecordStartError_Lorg_webrtc_voiceengine_WebRtcAudioRecord_AudioRecordStartErrorCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnWebRtcAudioRecordStartError_Lorg_webrtc_voiceengine_WebRtcAudioRecord_AudioRecordStartErrorCode_Ljava_lang_String_);
				return cb_onWebRtcAudioRecordStartError_Lorg_webrtc_voiceengine_WebRtcAudioRecord_AudioRecordStartErrorCode_Ljava_lang_String_;
			}

			static void n_OnWebRtcAudioRecordStartError_Lorg_webrtc_voiceengine_WebRtcAudioRecord_AudioRecordStartErrorCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.IWebRtcAudioRecordErrorCallback __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.IWebRtcAudioRecordErrorCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.AudioRecordStartErrorCode p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.AudioRecordStartErrorCode> (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnWebRtcAudioRecordStartError (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onWebRtcAudioRecordStartError_Lorg_webrtc_voiceengine_WebRtcAudioRecord_AudioRecordStartErrorCode_Ljava_lang_String_;
			public unsafe void OnWebRtcAudioRecordStartError (global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.AudioRecordStartErrorCode p0, string p1)
			{
				if (id_onWebRtcAudioRecordStartError_Lorg_webrtc_voiceengine_WebRtcAudioRecord_AudioRecordStartErrorCode_Ljava_lang_String_ == IntPtr.Zero)
					id_onWebRtcAudioRecordStartError_Lorg_webrtc_voiceengine_WebRtcAudioRecord_AudioRecordStartErrorCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onWebRtcAudioRecordStartError", "(Lorg/webrtc/voiceengine/WebRtcAudioRecord$AudioRecordStartErrorCode;Ljava/lang/String;)V");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWebRtcAudioRecordStartError_Lorg_webrtc_voiceengine_WebRtcAudioRecord_AudioRecordStartErrorCode_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p1);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc.voiceengine']/interface[@name='WebRtcAudioRecord.WebRtcAudioRecordSamplesReadyCallback']"
		[Register ("org/webrtc/voiceengine/WebRtcAudioRecord$WebRtcAudioRecordSamplesReadyCallback", "", "Org.Webrtc.Voiceengine.WebRtcAudioRecord/IWebRtcAudioRecordSamplesReadyCallbackInvoker")]
		public partial interface IWebRtcAudioRecordSamplesReadyCallback : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/interface[@name='WebRtcAudioRecord.WebRtcAudioRecordSamplesReadyCallback']/method[@name='onWebRtcAudioRecordSamplesReady' and count(parameter)=1 and parameter[1][@type='org.webrtc.voiceengine.WebRtcAudioRecord.AudioSamples']]"
			[Register ("onWebRtcAudioRecordSamplesReady", "(Lorg/webrtc/voiceengine/WebRtcAudioRecord$AudioSamples;)V", "GetOnWebRtcAudioRecordSamplesReady_Lorg_webrtc_voiceengine_WebRtcAudioRecord_AudioSamples_Handler:Org.Webrtc.Voiceengine.WebRtcAudioRecord/IWebRtcAudioRecordSamplesReadyCallbackInvoker, webrtc_android")]
			void OnWebRtcAudioRecordSamplesReady (global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.AudioSamples p0);

		}

		[global::Android.Runtime.Register ("org/webrtc/voiceengine/WebRtcAudioRecord$WebRtcAudioRecordSamplesReadyCallback", DoNotGenerateAcw=true)]
		internal partial class IWebRtcAudioRecordSamplesReadyCallbackInvoker : global::Java.Lang.Object, IWebRtcAudioRecordSamplesReadyCallback {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/voiceengine/WebRtcAudioRecord$WebRtcAudioRecordSamplesReadyCallback", typeof (IWebRtcAudioRecordSamplesReadyCallbackInvoker));

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

			public static IWebRtcAudioRecordSamplesReadyCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IWebRtcAudioRecordSamplesReadyCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.voiceengine.WebRtcAudioRecord.WebRtcAudioRecordSamplesReadyCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IWebRtcAudioRecordSamplesReadyCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onWebRtcAudioRecordSamplesReady_Lorg_webrtc_voiceengine_WebRtcAudioRecord_AudioSamples_;
#pragma warning disable 0169
			static Delegate GetOnWebRtcAudioRecordSamplesReady_Lorg_webrtc_voiceengine_WebRtcAudioRecord_AudioSamples_Handler ()
			{
				if (cb_onWebRtcAudioRecordSamplesReady_Lorg_webrtc_voiceengine_WebRtcAudioRecord_AudioSamples_ == null)
					cb_onWebRtcAudioRecordSamplesReady_Lorg_webrtc_voiceengine_WebRtcAudioRecord_AudioSamples_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnWebRtcAudioRecordSamplesReady_Lorg_webrtc_voiceengine_WebRtcAudioRecord_AudioSamples_);
				return cb_onWebRtcAudioRecordSamplesReady_Lorg_webrtc_voiceengine_WebRtcAudioRecord_AudioSamples_;
			}

			static void n_OnWebRtcAudioRecordSamplesReady_Lorg_webrtc_voiceengine_WebRtcAudioRecord_AudioSamples_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.IWebRtcAudioRecordSamplesReadyCallback __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.IWebRtcAudioRecordSamplesReadyCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.AudioSamples p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.AudioSamples> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnWebRtcAudioRecordSamplesReady (p0);
			}
#pragma warning restore 0169

			IntPtr id_onWebRtcAudioRecordSamplesReady_Lorg_webrtc_voiceengine_WebRtcAudioRecord_AudioSamples_;
			public unsafe void OnWebRtcAudioRecordSamplesReady (global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.AudioSamples p0)
			{
				if (id_onWebRtcAudioRecordSamplesReady_Lorg_webrtc_voiceengine_WebRtcAudioRecord_AudioSamples_ == IntPtr.Zero)
					id_onWebRtcAudioRecordSamplesReady_Lorg_webrtc_voiceengine_WebRtcAudioRecord_AudioSamples_ = JNIEnv.GetMethodID (class_ref, "onWebRtcAudioRecordSamplesReady", "(Lorg/webrtc/voiceengine/WebRtcAudioRecord$AudioSamples;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWebRtcAudioRecordSamplesReady_Lorg_webrtc_voiceengine_WebRtcAudioRecord_AudioSamples_, __args);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/voiceengine/WebRtcAudioRecord", typeof (WebRtcAudioRecord));
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

		protected WebRtcAudioRecord (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioRecord']/method[@name='setAudioSource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAudioSource", "(I)V", "")]
		public static unsafe void SetAudioSource (int source)
		{
			const string __id = "setAudioSource.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (source);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioRecord']/method[@name='setErrorCallback' and count(parameter)=1 and parameter[1][@type='org.webrtc.voiceengine.WebRtcAudioRecord.WebRtcAudioRecordErrorCallback']]"
		[Register ("setErrorCallback", "(Lorg/webrtc/voiceengine/WebRtcAudioRecord$WebRtcAudioRecordErrorCallback;)V", "")]
		public static unsafe void SetErrorCallback (global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.IWebRtcAudioRecordErrorCallback errorCallback)
		{
			const string __id = "setErrorCallback.(Lorg/webrtc/voiceengine/WebRtcAudioRecord$WebRtcAudioRecordErrorCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((errorCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) errorCallback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioRecord']/method[@name='setMicrophoneMute' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setMicrophoneMute", "(Z)V", "")]
		public static unsafe void SetMicrophoneMute (bool mute)
		{
			const string __id = "setMicrophoneMute.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (mute);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioRecord']/method[@name='setOnAudioSamplesReady' and count(parameter)=1 and parameter[1][@type='org.webrtc.voiceengine.WebRtcAudioRecord.WebRtcAudioRecordSamplesReadyCallback']]"
		[Register ("setOnAudioSamplesReady", "(Lorg/webrtc/voiceengine/WebRtcAudioRecord$WebRtcAudioRecordSamplesReadyCallback;)V", "")]
		public static unsafe void SetOnAudioSamplesReady (global::Org.Webrtc.Voiceengine.WebRtcAudioRecord.IWebRtcAudioRecordSamplesReadyCallback @callback)
		{
			const string __id = "setOnAudioSamplesReady.(Lorg/webrtc/voiceengine/WebRtcAudioRecord$WebRtcAudioRecordSamplesReadyCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
