using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc.Voiceengine {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioEffects']"
	[global::Android.Runtime.Register ("org/webrtc/voiceengine/WebRtcAudioEffects", DoNotGenerateAcw=true)]
	public partial class WebRtcAudioEffects : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/voiceengine/WebRtcAudioEffects", typeof (WebRtcAudioEffects));
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

		protected WebRtcAudioEffects (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe bool IsAcousticEchoCancelerBlacklisted {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioEffects']/method[@name='isAcousticEchoCancelerBlacklisted' and count(parameter)=0]"
			[Register ("isAcousticEchoCancelerBlacklisted", "()Z", "")]
			get {
				const string __id = "isAcousticEchoCancelerBlacklisted.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsAcousticEchoCancelerSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioEffects']/method[@name='isAcousticEchoCancelerSupported' and count(parameter)=0]"
			[Register ("isAcousticEchoCancelerSupported", "()Z", "")]
			get {
				const string __id = "isAcousticEchoCancelerSupported.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsNoiseSuppressorBlacklisted {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioEffects']/method[@name='isNoiseSuppressorBlacklisted' and count(parameter)=0]"
			[Register ("isNoiseSuppressorBlacklisted", "()Z", "")]
			get {
				const string __id = "isNoiseSuppressorBlacklisted.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsNoiseSuppressorSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioEffects']/method[@name='isNoiseSuppressorSupported' and count(parameter)=0]"
			[Register ("isNoiseSuppressorSupported", "()Z", "")]
			get {
				const string __id = "isNoiseSuppressorSupported.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioEffects']/method[@name='canUseAcousticEchoCanceler' and count(parameter)=0]"
		[Register ("canUseAcousticEchoCanceler", "()Z", "")]
		public static unsafe bool CanUseAcousticEchoCanceler ()
		{
			const string __id = "canUseAcousticEchoCanceler.()Z";
			try {
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioEffects']/method[@name='canUseNoiseSuppressor' and count(parameter)=0]"
		[Register ("canUseNoiseSuppressor", "()Z", "")]
		public static unsafe bool CanUseNoiseSuppressor ()
		{
			const string __id = "canUseNoiseSuppressor.()Z";
			try {
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioEffects']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lorg/webrtc/voiceengine/WebRtcAudioEffects;", "")]
		public static unsafe global::Org.Webrtc.Voiceengine.WebRtcAudioEffects Create ()
		{
			const string __id = "create.()Lorg/webrtc/voiceengine/WebRtcAudioEffects;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Voiceengine.WebRtcAudioEffects> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_enable_I;
#pragma warning disable 0169
		static Delegate GetEnable_IHandler ()
		{
			if (cb_enable_I == null)
				cb_enable_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Enable_I);
			return cb_enable_I;
		}

		static void n_Enable_I (IntPtr jnienv, IntPtr native__this, int audioSession)
		{
			global::Org.Webrtc.Voiceengine.WebRtcAudioEffects __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Voiceengine.WebRtcAudioEffects> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Enable (audioSession);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioEffects']/method[@name='enable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("enable", "(I)V", "GetEnable_IHandler")]
		public virtual unsafe void Enable (int audioSession)
		{
			const string __id = "enable.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (audioSession);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Org.Webrtc.Voiceengine.WebRtcAudioEffects __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Voiceengine.WebRtcAudioEffects> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioEffects']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setAEC_Z;
#pragma warning disable 0169
		static Delegate GetSetAEC_ZHandler ()
		{
			if (cb_setAEC_Z == null)
				cb_setAEC_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool>) n_SetAEC_Z);
			return cb_setAEC_Z;
		}

		static bool n_SetAEC_Z (IntPtr jnienv, IntPtr native__this, bool enable)
		{
			global::Org.Webrtc.Voiceengine.WebRtcAudioEffects __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Voiceengine.WebRtcAudioEffects> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetAEC (enable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioEffects']/method[@name='setAEC' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAEC", "(Z)Z", "GetSetAEC_ZHandler")]
		public virtual unsafe bool SetAEC (bool enable)
		{
			const string __id = "setAEC.(Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enable);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setNS_Z;
#pragma warning disable 0169
		static Delegate GetSetNS_ZHandler ()
		{
			if (cb_setNS_Z == null)
				cb_setNS_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool>) n_SetNS_Z);
			return cb_setNS_Z;
		}

		static bool n_SetNS_Z (IntPtr jnienv, IntPtr native__this, bool enable)
		{
			global::Org.Webrtc.Voiceengine.WebRtcAudioEffects __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Voiceengine.WebRtcAudioEffects> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetNS (enable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioEffects']/method[@name='setNS' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setNS", "(Z)Z", "GetSetNS_ZHandler")]
		public virtual unsafe bool SetNS (bool enable)
		{
			const string __id = "setNS.(Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enable);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
