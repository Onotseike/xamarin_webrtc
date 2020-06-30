using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc.Audio {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule']"
	[global::Android.Runtime.Register ("org/webrtc/audio/JavaAudioDeviceModule", DoNotGenerateAcw=true)]
	public partial class JavaAudioDeviceModule : global::Java.Lang.Object, global::Org.Webrtc.Audio.IAudioDeviceModule {

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc.audio']/interface[@name='JavaAudioDeviceModule.AudioRecordErrorCallback']"
		[Register ("org/webrtc/audio/JavaAudioDeviceModule$AudioRecordErrorCallback", "", "Org.Webrtc.Audio.JavaAudioDeviceModule/IAudioRecordErrorCallbackInvoker")]
		public partial interface IAudioRecordErrorCallback : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/interface[@name='JavaAudioDeviceModule.AudioRecordErrorCallback']/method[@name='onWebRtcAudioRecordError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onWebRtcAudioRecordError", "(Ljava/lang/String;)V", "GetOnWebRtcAudioRecordError_Ljava_lang_String_Handler:Org.Webrtc.Audio.JavaAudioDeviceModule/IAudioRecordErrorCallbackInvoker, webrtc_android")]
			void OnWebRtcAudioRecordError (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/interface[@name='JavaAudioDeviceModule.AudioRecordErrorCallback']/method[@name='onWebRtcAudioRecordInitError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onWebRtcAudioRecordInitError", "(Ljava/lang/String;)V", "GetOnWebRtcAudioRecordInitError_Ljava_lang_String_Handler:Org.Webrtc.Audio.JavaAudioDeviceModule/IAudioRecordErrorCallbackInvoker, webrtc_android")]
			void OnWebRtcAudioRecordInitError (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/interface[@name='JavaAudioDeviceModule.AudioRecordErrorCallback']/method[@name='onWebRtcAudioRecordStartError' and count(parameter)=2 and parameter[1][@type='org.webrtc.audio.JavaAudioDeviceModule.AudioRecordStartErrorCode'] and parameter[2][@type='java.lang.String']]"
			[Register ("onWebRtcAudioRecordStartError", "(Lorg/webrtc/audio/JavaAudioDeviceModule$AudioRecordStartErrorCode;Ljava/lang/String;)V", "GetOnWebRtcAudioRecordStartError_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioRecordStartErrorCode_Ljava_lang_String_Handler:Org.Webrtc.Audio.JavaAudioDeviceModule/IAudioRecordErrorCallbackInvoker, webrtc_android")]
			void OnWebRtcAudioRecordStartError (global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioRecordStartErrorCode p0, string p1);

		}

		[global::Android.Runtime.Register ("org/webrtc/audio/JavaAudioDeviceModule$AudioRecordErrorCallback", DoNotGenerateAcw=true)]
		internal partial class IAudioRecordErrorCallbackInvoker : global::Java.Lang.Object, IAudioRecordErrorCallback {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/audio/JavaAudioDeviceModule$AudioRecordErrorCallback", typeof (IAudioRecordErrorCallbackInvoker));

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

			public static IAudioRecordErrorCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAudioRecordErrorCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.audio.JavaAudioDeviceModule.AudioRecordErrorCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAudioRecordErrorCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioRecordErrorCallback __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioRecordErrorCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioRecordErrorCallback __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioRecordErrorCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

			static Delegate cb_onWebRtcAudioRecordStartError_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioRecordStartErrorCode_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnWebRtcAudioRecordStartError_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioRecordStartErrorCode_Ljava_lang_String_Handler ()
			{
				if (cb_onWebRtcAudioRecordStartError_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioRecordStartErrorCode_Ljava_lang_String_ == null)
					cb_onWebRtcAudioRecordStartError_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioRecordStartErrorCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnWebRtcAudioRecordStartError_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioRecordStartErrorCode_Ljava_lang_String_);
				return cb_onWebRtcAudioRecordStartError_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioRecordStartErrorCode_Ljava_lang_String_;
			}

			static void n_OnWebRtcAudioRecordStartError_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioRecordStartErrorCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioRecordErrorCallback __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioRecordErrorCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioRecordStartErrorCode p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioRecordStartErrorCode> (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnWebRtcAudioRecordStartError (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onWebRtcAudioRecordStartError_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioRecordStartErrorCode_Ljava_lang_String_;
			public unsafe void OnWebRtcAudioRecordStartError (global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioRecordStartErrorCode p0, string p1)
			{
				if (id_onWebRtcAudioRecordStartError_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioRecordStartErrorCode_Ljava_lang_String_ == IntPtr.Zero)
					id_onWebRtcAudioRecordStartError_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioRecordStartErrorCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onWebRtcAudioRecordStartError", "(Lorg/webrtc/audio/JavaAudioDeviceModule$AudioRecordStartErrorCode;Ljava/lang/String;)V");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWebRtcAudioRecordStartError_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioRecordStartErrorCode_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p1);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule.AudioRecordStartErrorCode']"
		[global::Android.Runtime.Register ("org/webrtc/audio/JavaAudioDeviceModule$AudioRecordStartErrorCode", DoNotGenerateAcw=true)]
		public sealed partial class AudioRecordStartErrorCode : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule.AudioRecordStartErrorCode']/field[@name='AUDIO_RECORD_START_EXCEPTION']"
			[Register ("AUDIO_RECORD_START_EXCEPTION")]
			public static global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioRecordStartErrorCode AudioRecordStartException {
				get {
					const string __id = "AUDIO_RECORD_START_EXCEPTION.Lorg/webrtc/audio/JavaAudioDeviceModule$AudioRecordStartErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioRecordStartErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule.AudioRecordStartErrorCode']/field[@name='AUDIO_RECORD_START_STATE_MISMATCH']"
			[Register ("AUDIO_RECORD_START_STATE_MISMATCH")]
			public static global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioRecordStartErrorCode AudioRecordStartStateMismatch {
				get {
					const string __id = "AUDIO_RECORD_START_STATE_MISMATCH.Lorg/webrtc/audio/JavaAudioDeviceModule$AudioRecordStartErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioRecordStartErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/audio/JavaAudioDeviceModule$AudioRecordStartErrorCode", typeof (AudioRecordStartErrorCode));
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

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule.AudioRecordStartErrorCode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/audio/JavaAudioDeviceModule$AudioRecordStartErrorCode;", "")]
			public static unsafe global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioRecordStartErrorCode ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/webrtc/audio/JavaAudioDeviceModule$AudioRecordStartErrorCode;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioRecordStartErrorCode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule.AudioRecordStartErrorCode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/audio/JavaAudioDeviceModule$AudioRecordStartErrorCode;", "")]
			public static unsafe global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioRecordStartErrorCode[] Values ()
			{
				const string __id = "values.()[Lorg/webrtc/audio/JavaAudioDeviceModule$AudioRecordStartErrorCode;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioRecordStartErrorCode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioRecordStartErrorCode));
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc.audio']/interface[@name='JavaAudioDeviceModule.AudioRecordStateCallback']"
		[Register ("org/webrtc/audio/JavaAudioDeviceModule$AudioRecordStateCallback", "", "Org.Webrtc.Audio.JavaAudioDeviceModule/IAudioRecordStateCallbackInvoker")]
		public partial interface IAudioRecordStateCallback : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/interface[@name='JavaAudioDeviceModule.AudioRecordStateCallback']/method[@name='onWebRtcAudioRecordStart' and count(parameter)=0]"
			[Register ("onWebRtcAudioRecordStart", "()V", "GetOnWebRtcAudioRecordStartHandler:Org.Webrtc.Audio.JavaAudioDeviceModule/IAudioRecordStateCallbackInvoker, webrtc_android")]
			void OnWebRtcAudioRecordStart ();

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/interface[@name='JavaAudioDeviceModule.AudioRecordStateCallback']/method[@name='onWebRtcAudioRecordStop' and count(parameter)=0]"
			[Register ("onWebRtcAudioRecordStop", "()V", "GetOnWebRtcAudioRecordStopHandler:Org.Webrtc.Audio.JavaAudioDeviceModule/IAudioRecordStateCallbackInvoker, webrtc_android")]
			void OnWebRtcAudioRecordStop ();

		}

		[global::Android.Runtime.Register ("org/webrtc/audio/JavaAudioDeviceModule$AudioRecordStateCallback", DoNotGenerateAcw=true)]
		internal partial class IAudioRecordStateCallbackInvoker : global::Java.Lang.Object, IAudioRecordStateCallback {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/audio/JavaAudioDeviceModule$AudioRecordStateCallback", typeof (IAudioRecordStateCallbackInvoker));

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

			public static IAudioRecordStateCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAudioRecordStateCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.audio.JavaAudioDeviceModule.AudioRecordStateCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAudioRecordStateCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onWebRtcAudioRecordStart;
#pragma warning disable 0169
			static Delegate GetOnWebRtcAudioRecordStartHandler ()
			{
				if (cb_onWebRtcAudioRecordStart == null)
					cb_onWebRtcAudioRecordStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnWebRtcAudioRecordStart);
				return cb_onWebRtcAudioRecordStart;
			}

			static void n_OnWebRtcAudioRecordStart (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioRecordStateCallback __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioRecordStateCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnWebRtcAudioRecordStart ();
			}
#pragma warning restore 0169

			IntPtr id_onWebRtcAudioRecordStart;
			public unsafe void OnWebRtcAudioRecordStart ()
			{
				if (id_onWebRtcAudioRecordStart == IntPtr.Zero)
					id_onWebRtcAudioRecordStart = JNIEnv.GetMethodID (class_ref, "onWebRtcAudioRecordStart", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWebRtcAudioRecordStart);
			}

			static Delegate cb_onWebRtcAudioRecordStop;
#pragma warning disable 0169
			static Delegate GetOnWebRtcAudioRecordStopHandler ()
			{
				if (cb_onWebRtcAudioRecordStop == null)
					cb_onWebRtcAudioRecordStop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnWebRtcAudioRecordStop);
				return cb_onWebRtcAudioRecordStop;
			}

			static void n_OnWebRtcAudioRecordStop (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioRecordStateCallback __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioRecordStateCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnWebRtcAudioRecordStop ();
			}
#pragma warning restore 0169

			IntPtr id_onWebRtcAudioRecordStop;
			public unsafe void OnWebRtcAudioRecordStop ()
			{
				if (id_onWebRtcAudioRecordStop == IntPtr.Zero)
					id_onWebRtcAudioRecordStop = JNIEnv.GetMethodID (class_ref, "onWebRtcAudioRecordStop", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWebRtcAudioRecordStop);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule.AudioSamples']"
		[global::Android.Runtime.Register ("org/webrtc/audio/JavaAudioDeviceModule$AudioSamples", DoNotGenerateAcw=true)]
		public partial class AudioSamples : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/audio/JavaAudioDeviceModule$AudioSamples", typeof (AudioSamples));
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule.AudioSamples']/constructor[@name='JavaAudioDeviceModule.AudioSamples' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
			[Register (".ctor", "(III[B)V", "")]
			public unsafe AudioSamples (int audioFormat, int channelCount, int sampleRate, byte[] data)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(III[B)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_data = JNIEnv.NewArray (data);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (audioFormat);
					__args [1] = new JniArgumentValue (channelCount);
					__args [2] = new JniArgumentValue (sampleRate);
					__args [3] = new JniArgumentValue (native_data);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					if (data != null) {
						JNIEnv.CopyArray (native_data, data);
						JNIEnv.DeleteLocalRef (native_data);
					}
				}
			}

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
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioSamples __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioSamples> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.AudioFormat;
			}
#pragma warning restore 0169

			public virtual unsafe int AudioFormat {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule.AudioSamples']/method[@name='getAudioFormat' and count(parameter)=0]"
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
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioSamples __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioSamples> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ChannelCount;
			}
#pragma warning restore 0169

			public virtual unsafe int ChannelCount {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule.AudioSamples']/method[@name='getChannelCount' and count(parameter)=0]"
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
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioSamples __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioSamples> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.SampleRate;
			}
#pragma warning restore 0169

			public virtual unsafe int SampleRate {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule.AudioSamples']/method[@name='getSampleRate' and count(parameter)=0]"
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
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioSamples __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioSamples> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetData ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule.AudioSamples']/method[@name='getData' and count(parameter)=0]"
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

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc.audio']/interface[@name='JavaAudioDeviceModule.AudioTrackErrorCallback']"
		[Register ("org/webrtc/audio/JavaAudioDeviceModule$AudioTrackErrorCallback", "", "Org.Webrtc.Audio.JavaAudioDeviceModule/IAudioTrackErrorCallbackInvoker")]
		public partial interface IAudioTrackErrorCallback : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/interface[@name='JavaAudioDeviceModule.AudioTrackErrorCallback']/method[@name='onWebRtcAudioTrackError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onWebRtcAudioTrackError", "(Ljava/lang/String;)V", "GetOnWebRtcAudioTrackError_Ljava_lang_String_Handler:Org.Webrtc.Audio.JavaAudioDeviceModule/IAudioTrackErrorCallbackInvoker, webrtc_android")]
			void OnWebRtcAudioTrackError (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/interface[@name='JavaAudioDeviceModule.AudioTrackErrorCallback']/method[@name='onWebRtcAudioTrackInitError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onWebRtcAudioTrackInitError", "(Ljava/lang/String;)V", "GetOnWebRtcAudioTrackInitError_Ljava_lang_String_Handler:Org.Webrtc.Audio.JavaAudioDeviceModule/IAudioTrackErrorCallbackInvoker, webrtc_android")]
			void OnWebRtcAudioTrackInitError (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/interface[@name='JavaAudioDeviceModule.AudioTrackErrorCallback']/method[@name='onWebRtcAudioTrackStartError' and count(parameter)=2 and parameter[1][@type='org.webrtc.audio.JavaAudioDeviceModule.AudioTrackStartErrorCode'] and parameter[2][@type='java.lang.String']]"
			[Register ("onWebRtcAudioTrackStartError", "(Lorg/webrtc/audio/JavaAudioDeviceModule$AudioTrackStartErrorCode;Ljava/lang/String;)V", "GetOnWebRtcAudioTrackStartError_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioTrackStartErrorCode_Ljava_lang_String_Handler:Org.Webrtc.Audio.JavaAudioDeviceModule/IAudioTrackErrorCallbackInvoker, webrtc_android")]
			void OnWebRtcAudioTrackStartError (global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioTrackStartErrorCode p0, string p1);

		}

		[global::Android.Runtime.Register ("org/webrtc/audio/JavaAudioDeviceModule$AudioTrackErrorCallback", DoNotGenerateAcw=true)]
		internal partial class IAudioTrackErrorCallbackInvoker : global::Java.Lang.Object, IAudioTrackErrorCallback {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/audio/JavaAudioDeviceModule$AudioTrackErrorCallback", typeof (IAudioTrackErrorCallbackInvoker));

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

			public static IAudioTrackErrorCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAudioTrackErrorCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.audio.JavaAudioDeviceModule.AudioTrackErrorCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAudioTrackErrorCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioTrackErrorCallback __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioTrackErrorCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioTrackErrorCallback __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioTrackErrorCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

			static Delegate cb_onWebRtcAudioTrackStartError_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioTrackStartErrorCode_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnWebRtcAudioTrackStartError_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioTrackStartErrorCode_Ljava_lang_String_Handler ()
			{
				if (cb_onWebRtcAudioTrackStartError_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioTrackStartErrorCode_Ljava_lang_String_ == null)
					cb_onWebRtcAudioTrackStartError_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioTrackStartErrorCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnWebRtcAudioTrackStartError_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioTrackStartErrorCode_Ljava_lang_String_);
				return cb_onWebRtcAudioTrackStartError_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioTrackStartErrorCode_Ljava_lang_String_;
			}

			static void n_OnWebRtcAudioTrackStartError_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioTrackStartErrorCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioTrackErrorCallback __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioTrackErrorCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioTrackStartErrorCode p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioTrackStartErrorCode> (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnWebRtcAudioTrackStartError (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onWebRtcAudioTrackStartError_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioTrackStartErrorCode_Ljava_lang_String_;
			public unsafe void OnWebRtcAudioTrackStartError (global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioTrackStartErrorCode p0, string p1)
			{
				if (id_onWebRtcAudioTrackStartError_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioTrackStartErrorCode_Ljava_lang_String_ == IntPtr.Zero)
					id_onWebRtcAudioTrackStartError_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioTrackStartErrorCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onWebRtcAudioTrackStartError", "(Lorg/webrtc/audio/JavaAudioDeviceModule$AudioTrackStartErrorCode;Ljava/lang/String;)V");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWebRtcAudioTrackStartError_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioTrackStartErrorCode_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p1);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule.AudioTrackStartErrorCode']"
		[global::Android.Runtime.Register ("org/webrtc/audio/JavaAudioDeviceModule$AudioTrackStartErrorCode", DoNotGenerateAcw=true)]
		public sealed partial class AudioTrackStartErrorCode : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule.AudioTrackStartErrorCode']/field[@name='AUDIO_TRACK_START_EXCEPTION']"
			[Register ("AUDIO_TRACK_START_EXCEPTION")]
			public static global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioTrackStartErrorCode AudioTrackStartException {
				get {
					const string __id = "AUDIO_TRACK_START_EXCEPTION.Lorg/webrtc/audio/JavaAudioDeviceModule$AudioTrackStartErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioTrackStartErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule.AudioTrackStartErrorCode']/field[@name='AUDIO_TRACK_START_STATE_MISMATCH']"
			[Register ("AUDIO_TRACK_START_STATE_MISMATCH")]
			public static global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioTrackStartErrorCode AudioTrackStartStateMismatch {
				get {
					const string __id = "AUDIO_TRACK_START_STATE_MISMATCH.Lorg/webrtc/audio/JavaAudioDeviceModule$AudioTrackStartErrorCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioTrackStartErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/audio/JavaAudioDeviceModule$AudioTrackStartErrorCode", typeof (AudioTrackStartErrorCode));
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

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule.AudioTrackStartErrorCode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/audio/JavaAudioDeviceModule$AudioTrackStartErrorCode;", "")]
			public static unsafe global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioTrackStartErrorCode ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/webrtc/audio/JavaAudioDeviceModule$AudioTrackStartErrorCode;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioTrackStartErrorCode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule.AudioTrackStartErrorCode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/audio/JavaAudioDeviceModule$AudioTrackStartErrorCode;", "")]
			public static unsafe global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioTrackStartErrorCode[] Values ()
			{
				const string __id = "values.()[Lorg/webrtc/audio/JavaAudioDeviceModule$AudioTrackStartErrorCode;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioTrackStartErrorCode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioTrackStartErrorCode));
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc.audio']/interface[@name='JavaAudioDeviceModule.AudioTrackStateCallback']"
		[Register ("org/webrtc/audio/JavaAudioDeviceModule$AudioTrackStateCallback", "", "Org.Webrtc.Audio.JavaAudioDeviceModule/IAudioTrackStateCallbackInvoker")]
		public partial interface IAudioTrackStateCallback : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/interface[@name='JavaAudioDeviceModule.AudioTrackStateCallback']/method[@name='onWebRtcAudioTrackStart' and count(parameter)=0]"
			[Register ("onWebRtcAudioTrackStart", "()V", "GetOnWebRtcAudioTrackStartHandler:Org.Webrtc.Audio.JavaAudioDeviceModule/IAudioTrackStateCallbackInvoker, webrtc_android")]
			void OnWebRtcAudioTrackStart ();

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/interface[@name='JavaAudioDeviceModule.AudioTrackStateCallback']/method[@name='onWebRtcAudioTrackStop' and count(parameter)=0]"
			[Register ("onWebRtcAudioTrackStop", "()V", "GetOnWebRtcAudioTrackStopHandler:Org.Webrtc.Audio.JavaAudioDeviceModule/IAudioTrackStateCallbackInvoker, webrtc_android")]
			void OnWebRtcAudioTrackStop ();

		}

		[global::Android.Runtime.Register ("org/webrtc/audio/JavaAudioDeviceModule$AudioTrackStateCallback", DoNotGenerateAcw=true)]
		internal partial class IAudioTrackStateCallbackInvoker : global::Java.Lang.Object, IAudioTrackStateCallback {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/audio/JavaAudioDeviceModule$AudioTrackStateCallback", typeof (IAudioTrackStateCallbackInvoker));

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

			public static IAudioTrackStateCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAudioTrackStateCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.audio.JavaAudioDeviceModule.AudioTrackStateCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAudioTrackStateCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onWebRtcAudioTrackStart;
#pragma warning disable 0169
			static Delegate GetOnWebRtcAudioTrackStartHandler ()
			{
				if (cb_onWebRtcAudioTrackStart == null)
					cb_onWebRtcAudioTrackStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnWebRtcAudioTrackStart);
				return cb_onWebRtcAudioTrackStart;
			}

			static void n_OnWebRtcAudioTrackStart (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioTrackStateCallback __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioTrackStateCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnWebRtcAudioTrackStart ();
			}
#pragma warning restore 0169

			IntPtr id_onWebRtcAudioTrackStart;
			public unsafe void OnWebRtcAudioTrackStart ()
			{
				if (id_onWebRtcAudioTrackStart == IntPtr.Zero)
					id_onWebRtcAudioTrackStart = JNIEnv.GetMethodID (class_ref, "onWebRtcAudioTrackStart", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWebRtcAudioTrackStart);
			}

			static Delegate cb_onWebRtcAudioTrackStop;
#pragma warning disable 0169
			static Delegate GetOnWebRtcAudioTrackStopHandler ()
			{
				if (cb_onWebRtcAudioTrackStop == null)
					cb_onWebRtcAudioTrackStop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnWebRtcAudioTrackStop);
				return cb_onWebRtcAudioTrackStop;
			}

			static void n_OnWebRtcAudioTrackStop (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioTrackStateCallback __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioTrackStateCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnWebRtcAudioTrackStop ();
			}
#pragma warning restore 0169

			IntPtr id_onWebRtcAudioTrackStop;
			public unsafe void OnWebRtcAudioTrackStop ()
			{
				if (id_onWebRtcAudioTrackStop == IntPtr.Zero)
					id_onWebRtcAudioTrackStop = JNIEnv.GetMethodID (class_ref, "onWebRtcAudioTrackStop", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWebRtcAudioTrackStop);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule.Builder']"
		[global::Android.Runtime.Register ("org/webrtc/audio/JavaAudioDeviceModule$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/audio/JavaAudioDeviceModule$Builder", typeof (Builder));
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

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_createAudioDeviceModule;
#pragma warning disable 0169
			static Delegate GetCreateAudioDeviceModuleHandler ()
			{
				if (cb_createAudioDeviceModule == null)
					cb_createAudioDeviceModule = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreateAudioDeviceModule);
				return cb_createAudioDeviceModule;
			}

			static IntPtr n_CreateAudioDeviceModule (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.CreateAudioDeviceModule ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule.Builder']/method[@name='createAudioDeviceModule' and count(parameter)=0]"
			[Register ("createAudioDeviceModule", "()Lorg/webrtc/audio/AudioDeviceModule;", "GetCreateAudioDeviceModuleHandler")]
			public virtual unsafe global::Org.Webrtc.Audio.IAudioDeviceModule CreateAudioDeviceModule ()
			{
				const string __id = "createAudioDeviceModule.()Lorg/webrtc/audio/AudioDeviceModule;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.IAudioDeviceModule> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setAudioFormat_I;
#pragma warning disable 0169
			static Delegate GetSetAudioFormat_IHandler ()
			{
				if (cb_setAudioFormat_I == null)
					cb_setAudioFormat_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetAudioFormat_I);
				return cb_setAudioFormat_I;
			}

			static IntPtr n_SetAudioFormat_I (IntPtr jnienv, IntPtr native__this, int audioFormat)
			{
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetAudioFormat (audioFormat));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule.Builder']/method[@name='setAudioFormat' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAudioFormat", "(I)Lorg/webrtc/audio/JavaAudioDeviceModule$Builder;", "GetSetAudioFormat_IHandler")]
			public virtual unsafe global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder SetAudioFormat (int audioFormat)
			{
				const string __id = "setAudioFormat.(I)Lorg/webrtc/audio/JavaAudioDeviceModule$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (audioFormat);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setAudioRecordErrorCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioRecordErrorCallback_;
#pragma warning disable 0169
			static Delegate GetSetAudioRecordErrorCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioRecordErrorCallback_Handler ()
			{
				if (cb_setAudioRecordErrorCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioRecordErrorCallback_ == null)
					cb_setAudioRecordErrorCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioRecordErrorCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAudioRecordErrorCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioRecordErrorCallback_);
				return cb_setAudioRecordErrorCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioRecordErrorCallback_;
			}

			static IntPtr n_SetAudioRecordErrorCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioRecordErrorCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_audioRecordErrorCallback)
			{
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioRecordErrorCallback audioRecordErrorCallback = (global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioRecordErrorCallback)global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioRecordErrorCallback> (native_audioRecordErrorCallback, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAudioRecordErrorCallback (audioRecordErrorCallback));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule.Builder']/method[@name='setAudioRecordErrorCallback' and count(parameter)=1 and parameter[1][@type='org.webrtc.audio.JavaAudioDeviceModule.AudioRecordErrorCallback']]"
			[Register ("setAudioRecordErrorCallback", "(Lorg/webrtc/audio/JavaAudioDeviceModule$AudioRecordErrorCallback;)Lorg/webrtc/audio/JavaAudioDeviceModule$Builder;", "GetSetAudioRecordErrorCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioRecordErrorCallback_Handler")]
			public virtual unsafe global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder SetAudioRecordErrorCallback (global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioRecordErrorCallback audioRecordErrorCallback)
			{
				const string __id = "setAudioRecordErrorCallback.(Lorg/webrtc/audio/JavaAudioDeviceModule$AudioRecordErrorCallback;)Lorg/webrtc/audio/JavaAudioDeviceModule$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((audioRecordErrorCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) audioRecordErrorCallback).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setAudioRecordStateCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioRecordStateCallback_;
#pragma warning disable 0169
			static Delegate GetSetAudioRecordStateCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioRecordStateCallback_Handler ()
			{
				if (cb_setAudioRecordStateCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioRecordStateCallback_ == null)
					cb_setAudioRecordStateCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioRecordStateCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAudioRecordStateCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioRecordStateCallback_);
				return cb_setAudioRecordStateCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioRecordStateCallback_;
			}

			static IntPtr n_SetAudioRecordStateCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioRecordStateCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_audioRecordStateCallback)
			{
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioRecordStateCallback audioRecordStateCallback = (global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioRecordStateCallback)global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioRecordStateCallback> (native_audioRecordStateCallback, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAudioRecordStateCallback (audioRecordStateCallback));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule.Builder']/method[@name='setAudioRecordStateCallback' and count(parameter)=1 and parameter[1][@type='org.webrtc.audio.JavaAudioDeviceModule.AudioRecordStateCallback']]"
			[Register ("setAudioRecordStateCallback", "(Lorg/webrtc/audio/JavaAudioDeviceModule$AudioRecordStateCallback;)Lorg/webrtc/audio/JavaAudioDeviceModule$Builder;", "GetSetAudioRecordStateCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioRecordStateCallback_Handler")]
			public virtual unsafe global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder SetAudioRecordStateCallback (global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioRecordStateCallback audioRecordStateCallback)
			{
				const string __id = "setAudioRecordStateCallback.(Lorg/webrtc/audio/JavaAudioDeviceModule$AudioRecordStateCallback;)Lorg/webrtc/audio/JavaAudioDeviceModule$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((audioRecordStateCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) audioRecordStateCallback).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setAudioSource_I;
#pragma warning disable 0169
			static Delegate GetSetAudioSource_IHandler ()
			{
				if (cb_setAudioSource_I == null)
					cb_setAudioSource_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetAudioSource_I);
				return cb_setAudioSource_I;
			}

			static IntPtr n_SetAudioSource_I (IntPtr jnienv, IntPtr native__this, int audioSource)
			{
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetAudioSource (audioSource));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule.Builder']/method[@name='setAudioSource' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAudioSource", "(I)Lorg/webrtc/audio/JavaAudioDeviceModule$Builder;", "GetSetAudioSource_IHandler")]
			public virtual unsafe global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder SetAudioSource (int audioSource)
			{
				const string __id = "setAudioSource.(I)Lorg/webrtc/audio/JavaAudioDeviceModule$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (audioSource);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setAudioTrackErrorCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioTrackErrorCallback_;
#pragma warning disable 0169
			static Delegate GetSetAudioTrackErrorCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioTrackErrorCallback_Handler ()
			{
				if (cb_setAudioTrackErrorCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioTrackErrorCallback_ == null)
					cb_setAudioTrackErrorCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioTrackErrorCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAudioTrackErrorCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioTrackErrorCallback_);
				return cb_setAudioTrackErrorCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioTrackErrorCallback_;
			}

			static IntPtr n_SetAudioTrackErrorCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioTrackErrorCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_audioTrackErrorCallback)
			{
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioTrackErrorCallback audioTrackErrorCallback = (global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioTrackErrorCallback)global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioTrackErrorCallback> (native_audioTrackErrorCallback, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAudioTrackErrorCallback (audioTrackErrorCallback));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule.Builder']/method[@name='setAudioTrackErrorCallback' and count(parameter)=1 and parameter[1][@type='org.webrtc.audio.JavaAudioDeviceModule.AudioTrackErrorCallback']]"
			[Register ("setAudioTrackErrorCallback", "(Lorg/webrtc/audio/JavaAudioDeviceModule$AudioTrackErrorCallback;)Lorg/webrtc/audio/JavaAudioDeviceModule$Builder;", "GetSetAudioTrackErrorCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioTrackErrorCallback_Handler")]
			public virtual unsafe global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder SetAudioTrackErrorCallback (global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioTrackErrorCallback audioTrackErrorCallback)
			{
				const string __id = "setAudioTrackErrorCallback.(Lorg/webrtc/audio/JavaAudioDeviceModule$AudioTrackErrorCallback;)Lorg/webrtc/audio/JavaAudioDeviceModule$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((audioTrackErrorCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) audioTrackErrorCallback).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setAudioTrackStateCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioTrackStateCallback_;
#pragma warning disable 0169
			static Delegate GetSetAudioTrackStateCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioTrackStateCallback_Handler ()
			{
				if (cb_setAudioTrackStateCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioTrackStateCallback_ == null)
					cb_setAudioTrackStateCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioTrackStateCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAudioTrackStateCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioTrackStateCallback_);
				return cb_setAudioTrackStateCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioTrackStateCallback_;
			}

			static IntPtr n_SetAudioTrackStateCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioTrackStateCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_audioTrackStateCallback)
			{
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioTrackStateCallback audioTrackStateCallback = (global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioTrackStateCallback)global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioTrackStateCallback> (native_audioTrackStateCallback, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAudioTrackStateCallback (audioTrackStateCallback));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule.Builder']/method[@name='setAudioTrackStateCallback' and count(parameter)=1 and parameter[1][@type='org.webrtc.audio.JavaAudioDeviceModule.AudioTrackStateCallback']]"
			[Register ("setAudioTrackStateCallback", "(Lorg/webrtc/audio/JavaAudioDeviceModule$AudioTrackStateCallback;)Lorg/webrtc/audio/JavaAudioDeviceModule$Builder;", "GetSetAudioTrackStateCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioTrackStateCallback_Handler")]
			public virtual unsafe global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder SetAudioTrackStateCallback (global::Org.Webrtc.Audio.JavaAudioDeviceModule.IAudioTrackStateCallback audioTrackStateCallback)
			{
				const string __id = "setAudioTrackStateCallback.(Lorg/webrtc/audio/JavaAudioDeviceModule$AudioTrackStateCallback;)Lorg/webrtc/audio/JavaAudioDeviceModule$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((audioTrackStateCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) audioTrackStateCallback).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setInputSampleRate_I;
#pragma warning disable 0169
			static Delegate GetSetInputSampleRate_IHandler ()
			{
				if (cb_setInputSampleRate_I == null)
					cb_setInputSampleRate_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetInputSampleRate_I);
				return cb_setInputSampleRate_I;
			}

			static IntPtr n_SetInputSampleRate_I (IntPtr jnienv, IntPtr native__this, int inputSampleRate)
			{
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetInputSampleRate (inputSampleRate));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule.Builder']/method[@name='setInputSampleRate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setInputSampleRate", "(I)Lorg/webrtc/audio/JavaAudioDeviceModule$Builder;", "GetSetInputSampleRate_IHandler")]
			public virtual unsafe global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder SetInputSampleRate (int inputSampleRate)
			{
				const string __id = "setInputSampleRate.(I)Lorg/webrtc/audio/JavaAudioDeviceModule$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (inputSampleRate);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setOutputSampleRate_I;
#pragma warning disable 0169
			static Delegate GetSetOutputSampleRate_IHandler ()
			{
				if (cb_setOutputSampleRate_I == null)
					cb_setOutputSampleRate_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetOutputSampleRate_I);
				return cb_setOutputSampleRate_I;
			}

			static IntPtr n_SetOutputSampleRate_I (IntPtr jnienv, IntPtr native__this, int outputSampleRate)
			{
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetOutputSampleRate (outputSampleRate));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule.Builder']/method[@name='setOutputSampleRate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setOutputSampleRate", "(I)Lorg/webrtc/audio/JavaAudioDeviceModule$Builder;", "GetSetOutputSampleRate_IHandler")]
			public virtual unsafe global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder SetOutputSampleRate (int outputSampleRate)
			{
				const string __id = "setOutputSampleRate.(I)Lorg/webrtc/audio/JavaAudioDeviceModule$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (outputSampleRate);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setSampleRate_I;
#pragma warning disable 0169
			static Delegate GetSetSampleRate_IHandler ()
			{
				if (cb_setSampleRate_I == null)
					cb_setSampleRate_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetSampleRate_I);
				return cb_setSampleRate_I;
			}

			static IntPtr n_SetSampleRate_I (IntPtr jnienv, IntPtr native__this, int sampleRate)
			{
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetSampleRate (sampleRate));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule.Builder']/method[@name='setSampleRate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSampleRate", "(I)Lorg/webrtc/audio/JavaAudioDeviceModule$Builder;", "GetSetSampleRate_IHandler")]
			public virtual unsafe global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder SetSampleRate (int sampleRate)
			{
				const string __id = "setSampleRate.(I)Lorg/webrtc/audio/JavaAudioDeviceModule$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (sampleRate);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setSamplesReadyCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_SamplesReadyCallback_;
#pragma warning disable 0169
			static Delegate GetSetSamplesReadyCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_SamplesReadyCallback_Handler ()
			{
				if (cb_setSamplesReadyCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_SamplesReadyCallback_ == null)
					cb_setSamplesReadyCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_SamplesReadyCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetSamplesReadyCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_SamplesReadyCallback_);
				return cb_setSamplesReadyCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_SamplesReadyCallback_;
			}

			static IntPtr n_SetSamplesReadyCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_SamplesReadyCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_samplesReadyCallback)
			{
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.ISamplesReadyCallback samplesReadyCallback = (global::Org.Webrtc.Audio.JavaAudioDeviceModule.ISamplesReadyCallback)global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.ISamplesReadyCallback> (native_samplesReadyCallback, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSamplesReadyCallback (samplesReadyCallback));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule.Builder']/method[@name='setSamplesReadyCallback' and count(parameter)=1 and parameter[1][@type='org.webrtc.audio.JavaAudioDeviceModule.SamplesReadyCallback']]"
			[Register ("setSamplesReadyCallback", "(Lorg/webrtc/audio/JavaAudioDeviceModule$SamplesReadyCallback;)Lorg/webrtc/audio/JavaAudioDeviceModule$Builder;", "GetSetSamplesReadyCallback_Lorg_webrtc_audio_JavaAudioDeviceModule_SamplesReadyCallback_Handler")]
			public virtual unsafe global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder SetSamplesReadyCallback (global::Org.Webrtc.Audio.JavaAudioDeviceModule.ISamplesReadyCallback samplesReadyCallback)
			{
				const string __id = "setSamplesReadyCallback.(Lorg/webrtc/audio/JavaAudioDeviceModule$SamplesReadyCallback;)Lorg/webrtc/audio/JavaAudioDeviceModule$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((samplesReadyCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) samplesReadyCallback).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setUseHardwareAcousticEchoCanceler_Z;
#pragma warning disable 0169
			static Delegate GetSetUseHardwareAcousticEchoCanceler_ZHandler ()
			{
				if (cb_setUseHardwareAcousticEchoCanceler_Z == null)
					cb_setUseHardwareAcousticEchoCanceler_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetUseHardwareAcousticEchoCanceler_Z);
				return cb_setUseHardwareAcousticEchoCanceler_Z;
			}

			static IntPtr n_SetUseHardwareAcousticEchoCanceler_Z (IntPtr jnienv, IntPtr native__this, bool useHardwareAcousticEchoCanceler)
			{
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetUseHardwareAcousticEchoCanceler (useHardwareAcousticEchoCanceler));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule.Builder']/method[@name='setUseHardwareAcousticEchoCanceler' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseHardwareAcousticEchoCanceler", "(Z)Lorg/webrtc/audio/JavaAudioDeviceModule$Builder;", "GetSetUseHardwareAcousticEchoCanceler_ZHandler")]
			public virtual unsafe global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder SetUseHardwareAcousticEchoCanceler (bool useHardwareAcousticEchoCanceler)
			{
				const string __id = "setUseHardwareAcousticEchoCanceler.(Z)Lorg/webrtc/audio/JavaAudioDeviceModule$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (useHardwareAcousticEchoCanceler);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setUseHardwareNoiseSuppressor_Z;
#pragma warning disable 0169
			static Delegate GetSetUseHardwareNoiseSuppressor_ZHandler ()
			{
				if (cb_setUseHardwareNoiseSuppressor_Z == null)
					cb_setUseHardwareNoiseSuppressor_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetUseHardwareNoiseSuppressor_Z);
				return cb_setUseHardwareNoiseSuppressor_Z;
			}

			static IntPtr n_SetUseHardwareNoiseSuppressor_Z (IntPtr jnienv, IntPtr native__this, bool useHardwareNoiseSuppressor)
			{
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetUseHardwareNoiseSuppressor (useHardwareNoiseSuppressor));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule.Builder']/method[@name='setUseHardwareNoiseSuppressor' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseHardwareNoiseSuppressor", "(Z)Lorg/webrtc/audio/JavaAudioDeviceModule$Builder;", "GetSetUseHardwareNoiseSuppressor_ZHandler")]
			public virtual unsafe global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder SetUseHardwareNoiseSuppressor (bool useHardwareNoiseSuppressor)
			{
				const string __id = "setUseHardwareNoiseSuppressor.(Z)Lorg/webrtc/audio/JavaAudioDeviceModule$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (useHardwareNoiseSuppressor);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setUseStereoInput_Z;
#pragma warning disable 0169
			static Delegate GetSetUseStereoInput_ZHandler ()
			{
				if (cb_setUseStereoInput_Z == null)
					cb_setUseStereoInput_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetUseStereoInput_Z);
				return cb_setUseStereoInput_Z;
			}

			static IntPtr n_SetUseStereoInput_Z (IntPtr jnienv, IntPtr native__this, bool useStereoInput)
			{
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetUseStereoInput (useStereoInput));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule.Builder']/method[@name='setUseStereoInput' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseStereoInput", "(Z)Lorg/webrtc/audio/JavaAudioDeviceModule$Builder;", "GetSetUseStereoInput_ZHandler")]
			public virtual unsafe global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder SetUseStereoInput (bool useStereoInput)
			{
				const string __id = "setUseStereoInput.(Z)Lorg/webrtc/audio/JavaAudioDeviceModule$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (useStereoInput);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setUseStereoOutput_Z;
#pragma warning disable 0169
			static Delegate GetSetUseStereoOutput_ZHandler ()
			{
				if (cb_setUseStereoOutput_Z == null)
					cb_setUseStereoOutput_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetUseStereoOutput_Z);
				return cb_setUseStereoOutput_Z;
			}

			static IntPtr n_SetUseStereoOutput_Z (IntPtr jnienv, IntPtr native__this, bool useStereoOutput)
			{
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetUseStereoOutput (useStereoOutput));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule.Builder']/method[@name='setUseStereoOutput' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseStereoOutput", "(Z)Lorg/webrtc/audio/JavaAudioDeviceModule$Builder;", "GetSetUseStereoOutput_ZHandler")]
			public virtual unsafe global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder SetUseStereoOutput (bool useStereoOutput)
			{
				const string __id = "setUseStereoOutput.(Z)Lorg/webrtc/audio/JavaAudioDeviceModule$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (useStereoOutput);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc.audio']/interface[@name='JavaAudioDeviceModule.SamplesReadyCallback']"
		[Register ("org/webrtc/audio/JavaAudioDeviceModule$SamplesReadyCallback", "", "Org.Webrtc.Audio.JavaAudioDeviceModule/ISamplesReadyCallbackInvoker")]
		public partial interface ISamplesReadyCallback : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/interface[@name='JavaAudioDeviceModule.SamplesReadyCallback']/method[@name='onWebRtcAudioRecordSamplesReady' and count(parameter)=1 and parameter[1][@type='org.webrtc.audio.JavaAudioDeviceModule.AudioSamples']]"
			[Register ("onWebRtcAudioRecordSamplesReady", "(Lorg/webrtc/audio/JavaAudioDeviceModule$AudioSamples;)V", "GetOnWebRtcAudioRecordSamplesReady_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioSamples_Handler:Org.Webrtc.Audio.JavaAudioDeviceModule/ISamplesReadyCallbackInvoker, webrtc_android")]
			void OnWebRtcAudioRecordSamplesReady (global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioSamples p0);

		}

		[global::Android.Runtime.Register ("org/webrtc/audio/JavaAudioDeviceModule$SamplesReadyCallback", DoNotGenerateAcw=true)]
		internal partial class ISamplesReadyCallbackInvoker : global::Java.Lang.Object, ISamplesReadyCallback {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/audio/JavaAudioDeviceModule$SamplesReadyCallback", typeof (ISamplesReadyCallbackInvoker));

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

			public static ISamplesReadyCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISamplesReadyCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.audio.JavaAudioDeviceModule.SamplesReadyCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISamplesReadyCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onWebRtcAudioRecordSamplesReady_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioSamples_;
#pragma warning disable 0169
			static Delegate GetOnWebRtcAudioRecordSamplesReady_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioSamples_Handler ()
			{
				if (cb_onWebRtcAudioRecordSamplesReady_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioSamples_ == null)
					cb_onWebRtcAudioRecordSamplesReady_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioSamples_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnWebRtcAudioRecordSamplesReady_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioSamples_);
				return cb_onWebRtcAudioRecordSamplesReady_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioSamples_;
			}

			static void n_OnWebRtcAudioRecordSamplesReady_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioSamples_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.ISamplesReadyCallback __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.ISamplesReadyCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioSamples p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioSamples> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnWebRtcAudioRecordSamplesReady (p0);
			}
#pragma warning restore 0169

			IntPtr id_onWebRtcAudioRecordSamplesReady_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioSamples_;
			public unsafe void OnWebRtcAudioRecordSamplesReady (global::Org.Webrtc.Audio.JavaAudioDeviceModule.AudioSamples p0)
			{
				if (id_onWebRtcAudioRecordSamplesReady_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioSamples_ == IntPtr.Zero)
					id_onWebRtcAudioRecordSamplesReady_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioSamples_ = JNIEnv.GetMethodID (class_ref, "onWebRtcAudioRecordSamplesReady", "(Lorg/webrtc/audio/JavaAudioDeviceModule$AudioSamples;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWebRtcAudioRecordSamplesReady_Lorg_webrtc_audio_JavaAudioDeviceModule_AudioSamples_, __args);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/audio/JavaAudioDeviceModule", typeof (JavaAudioDeviceModule));
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

		protected JavaAudioDeviceModule (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe bool IsBuiltInAcousticEchoCancelerSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule']/method[@name='isBuiltInAcousticEchoCancelerSupported' and count(parameter)=0]"
			[Register ("isBuiltInAcousticEchoCancelerSupported", "()Z", "")]
			get {
				const string __id = "isBuiltInAcousticEchoCancelerSupported.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsBuiltInNoiseSuppressorSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule']/method[@name='isBuiltInNoiseSuppressorSupported' and count(parameter)=0]"
			[Register ("isBuiltInNoiseSuppressorSupported", "()Z", "")]
			get {
				const string __id = "isBuiltInNoiseSuppressorSupported.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getNativeAudioDeviceModulePointer;
#pragma warning disable 0169
		static Delegate GetGetNativeAudioDeviceModulePointerHandler ()
		{
			if (cb_getNativeAudioDeviceModulePointer == null)
				cb_getNativeAudioDeviceModulePointer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetNativeAudioDeviceModulePointer);
			return cb_getNativeAudioDeviceModulePointer;
		}

		static long n_GetNativeAudioDeviceModulePointer (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.Audio.JavaAudioDeviceModule __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NativeAudioDeviceModulePointer;
		}
#pragma warning restore 0169

		public virtual unsafe long NativeAudioDeviceModulePointer {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule']/method[@name='getNativeAudioDeviceModulePointer' and count(parameter)=0]"
			[Register ("getNativeAudioDeviceModulePointer", "()J", "GetGetNativeAudioDeviceModulePointerHandler")]
			get {
				const string __id = "getNativeAudioDeviceModulePointer.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule']/method[@name='builder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("builder", "(Landroid/content/Context;)Lorg/webrtc/audio/JavaAudioDeviceModule$Builder;", "")]
		public static unsafe global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder InvokeBuilder (global::Android.Content.Context context)
		{
			const string __id = "builder.(Landroid/content/Context;)Lorg/webrtc/audio/JavaAudioDeviceModule$Builder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Org.Webrtc.Audio.JavaAudioDeviceModule __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setMicrophoneMute_Z;
#pragma warning disable 0169
		static Delegate GetSetMicrophoneMute_ZHandler ()
		{
			if (cb_setMicrophoneMute_Z == null)
				cb_setMicrophoneMute_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetMicrophoneMute_Z);
			return cb_setMicrophoneMute_Z;
		}

		static void n_SetMicrophoneMute_Z (IntPtr jnienv, IntPtr native__this, bool mute)
		{
			global::Org.Webrtc.Audio.JavaAudioDeviceModule __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMicrophoneMute (mute);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule']/method[@name='setMicrophoneMute' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setMicrophoneMute", "(Z)V", "GetSetMicrophoneMute_ZHandler")]
		public virtual unsafe void SetMicrophoneMute (bool mute)
		{
			const string __id = "setMicrophoneMute.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (mute);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setPreferredInputDevice_Landroid_media_AudioDeviceInfo_;
#pragma warning disable 0169
		static Delegate GetSetPreferredInputDevice_Landroid_media_AudioDeviceInfo_Handler ()
		{
			if (cb_setPreferredInputDevice_Landroid_media_AudioDeviceInfo_ == null)
				cb_setPreferredInputDevice_Landroid_media_AudioDeviceInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPreferredInputDevice_Landroid_media_AudioDeviceInfo_);
			return cb_setPreferredInputDevice_Landroid_media_AudioDeviceInfo_;
		}

		static void n_SetPreferredInputDevice_Landroid_media_AudioDeviceInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_preferredInputDevice)
		{
			global::Org.Webrtc.Audio.JavaAudioDeviceModule __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.AudioDeviceInfo preferredInputDevice = global::Java.Lang.Object.GetObject<global::Android.Media.AudioDeviceInfo> (native_preferredInputDevice, JniHandleOwnership.DoNotTransfer);
			__this.SetPreferredInputDevice (preferredInputDevice);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule']/method[@name='setPreferredInputDevice' and count(parameter)=1 and parameter[1][@type='android.media.AudioDeviceInfo']]"
		[Register ("setPreferredInputDevice", "(Landroid/media/AudioDeviceInfo;)V", "GetSetPreferredInputDevice_Landroid_media_AudioDeviceInfo_Handler")]
		public virtual unsafe void SetPreferredInputDevice (global::Android.Media.AudioDeviceInfo preferredInputDevice)
		{
			const string __id = "setPreferredInputDevice.(Landroid/media/AudioDeviceInfo;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((preferredInputDevice == null) ? IntPtr.Zero : ((global::Java.Lang.Object) preferredInputDevice).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setSpeakerMute_Z;
#pragma warning disable 0169
		static Delegate GetSetSpeakerMute_ZHandler ()
		{
			if (cb_setSpeakerMute_Z == null)
				cb_setSpeakerMute_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSpeakerMute_Z);
			return cb_setSpeakerMute_Z;
		}

		static void n_SetSpeakerMute_Z (IntPtr jnienv, IntPtr native__this, bool mute)
		{
			global::Org.Webrtc.Audio.JavaAudioDeviceModule __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.JavaAudioDeviceModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSpeakerMute (mute);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/class[@name='JavaAudioDeviceModule']/method[@name='setSpeakerMute' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSpeakerMute", "(Z)V", "GetSetSpeakerMute_ZHandler")]
		public virtual unsafe void SetSpeakerMute (bool mute)
		{
			const string __id = "setSpeakerMute.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (mute);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
