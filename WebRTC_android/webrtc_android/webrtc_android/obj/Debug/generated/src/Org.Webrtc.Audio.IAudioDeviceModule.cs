using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc.Audio {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc.audio']/interface[@name='AudioDeviceModule']"
	[Register ("org/webrtc/audio/AudioDeviceModule", "", "Org.Webrtc.Audio.IAudioDeviceModuleInvoker")]
	public partial interface IAudioDeviceModule : IJavaObject, IJavaPeerable {

		long NativeAudioDeviceModulePointer {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/interface[@name='AudioDeviceModule']/method[@name='getNativeAudioDeviceModulePointer' and count(parameter)=0]"
			[Register ("getNativeAudioDeviceModulePointer", "()J", "GetGetNativeAudioDeviceModulePointerHandler:Org.Webrtc.Audio.IAudioDeviceModuleInvoker, webrtc_android")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/interface[@name='AudioDeviceModule']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler:Org.Webrtc.Audio.IAudioDeviceModuleInvoker, webrtc_android")]
		void Release ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/interface[@name='AudioDeviceModule']/method[@name='setMicrophoneMute' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setMicrophoneMute", "(Z)V", "GetSetMicrophoneMute_ZHandler:Org.Webrtc.Audio.IAudioDeviceModuleInvoker, webrtc_android")]
		void SetMicrophoneMute (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.audio']/interface[@name='AudioDeviceModule']/method[@name='setSpeakerMute' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSpeakerMute", "(Z)V", "GetSetSpeakerMute_ZHandler:Org.Webrtc.Audio.IAudioDeviceModuleInvoker, webrtc_android")]
		void SetSpeakerMute (bool p0);

	}

	[global::Android.Runtime.Register ("org/webrtc/audio/AudioDeviceModule", DoNotGenerateAcw=true)]
	internal partial class IAudioDeviceModuleInvoker : global::Java.Lang.Object, IAudioDeviceModule {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/audio/AudioDeviceModule", typeof (IAudioDeviceModuleInvoker));

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

		public static IAudioDeviceModule GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAudioDeviceModule> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.audio.AudioDeviceModule"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAudioDeviceModuleInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Org.Webrtc.Audio.IAudioDeviceModule __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.IAudioDeviceModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NativeAudioDeviceModulePointer;
		}
#pragma warning restore 0169

		IntPtr id_getNativeAudioDeviceModulePointer;
		public unsafe long NativeAudioDeviceModulePointer {
			get {
				if (id_getNativeAudioDeviceModulePointer == IntPtr.Zero)
					id_getNativeAudioDeviceModulePointer = JNIEnv.GetMethodID (class_ref, "getNativeAudioDeviceModulePointer", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getNativeAudioDeviceModulePointer);
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
			global::Org.Webrtc.Audio.IAudioDeviceModule __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.IAudioDeviceModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		IntPtr id_release;
		public unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
		}

		static Delegate cb_setMicrophoneMute_Z;
#pragma warning disable 0169
		static Delegate GetSetMicrophoneMute_ZHandler ()
		{
			if (cb_setMicrophoneMute_Z == null)
				cb_setMicrophoneMute_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetMicrophoneMute_Z);
			return cb_setMicrophoneMute_Z;
		}

		static void n_SetMicrophoneMute_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Webrtc.Audio.IAudioDeviceModule __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.IAudioDeviceModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMicrophoneMute (p0);
		}
#pragma warning restore 0169

		IntPtr id_setMicrophoneMute_Z;
		public unsafe void SetMicrophoneMute (bool p0)
		{
			if (id_setMicrophoneMute_Z == IntPtr.Zero)
				id_setMicrophoneMute_Z = JNIEnv.GetMethodID (class_ref, "setMicrophoneMute", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMicrophoneMute_Z, __args);
		}

		static Delegate cb_setSpeakerMute_Z;
#pragma warning disable 0169
		static Delegate GetSetSpeakerMute_ZHandler ()
		{
			if (cb_setSpeakerMute_Z == null)
				cb_setSpeakerMute_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSpeakerMute_Z);
			return cb_setSpeakerMute_Z;
		}

		static void n_SetSpeakerMute_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Webrtc.Audio.IAudioDeviceModule __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Audio.IAudioDeviceModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSpeakerMute (p0);
		}
#pragma warning restore 0169

		IntPtr id_setSpeakerMute_Z;
		public unsafe void SetSpeakerMute (bool p0)
		{
			if (id_setSpeakerMute_Z == IntPtr.Zero)
				id_setSpeakerMute_Z = JNIEnv.GetMethodID (class_ref, "setSpeakerMute", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSpeakerMute_Z, __args);
		}

	}

}
