using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc.Voiceengine {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioUtils']"
	[global::Android.Runtime.Register ("org/webrtc/voiceengine/WebRtcAudioUtils", DoNotGenerateAcw=true)]
	public sealed partial class WebRtcAudioUtils : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/voiceengine/WebRtcAudioUtils", typeof (WebRtcAudioUtils));
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

		internal WebRtcAudioUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioUtils']/constructor[@name='WebRtcAudioUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WebRtcAudioUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		public static unsafe global::System.Collections.Generic.IList<string> BlackListedModelsForAecUsage {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioUtils']/method[@name='getBlackListedModelsForAecUsage' and count(parameter)=0]"
			[Register ("getBlackListedModelsForAecUsage", "()Ljava/util/List;", "")]
			get {
				const string __id = "getBlackListedModelsForAecUsage.()Ljava/util/List;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::System.Collections.Generic.IList<string> BlackListedModelsForNsUsage {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioUtils']/method[@name='getBlackListedModelsForNsUsage' and count(parameter)=0]"
			[Register ("getBlackListedModelsForNsUsage", "()Ljava/util/List;", "")]
			get {
				const string __id = "getBlackListedModelsForNsUsage.()Ljava/util/List;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe int DefaultSampleRateHz {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioUtils']/method[@name='getDefaultSampleRateHz' and count(parameter)=0]"
			[Register ("getDefaultSampleRateHz", "()I", "")]
			get {
				const string __id = "getDefaultSampleRateHz.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioUtils']/method[@name='setDefaultSampleRateHz' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDefaultSampleRateHz", "(I)V", "")]
			set {
				const string __id = "setDefaultSampleRateHz.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		public static unsafe bool IsAcousticEchoCancelerSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioUtils']/method[@name='isAcousticEchoCancelerSupported' and count(parameter)=0]"
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

		public static unsafe bool IsAutomaticGainControlSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioUtils']/method[@name='isAutomaticGainControlSupported' and count(parameter)=0]"
			[Register ("isAutomaticGainControlSupported", "()Z", "")]
			get {
				const string __id = "isAutomaticGainControlSupported.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsDefaultSampleRateOverridden {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioUtils']/method[@name='isDefaultSampleRateOverridden' and count(parameter)=0]"
			[Register ("isDefaultSampleRateOverridden", "()Z", "")]
			get {
				const string __id = "isDefaultSampleRateOverridden.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsNoiseSuppressorSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioUtils']/method[@name='isNoiseSuppressorSupported' and count(parameter)=0]"
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

		public static unsafe string ThreadInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioUtils']/method[@name='getThreadInfo' and count(parameter)=0]"
			[Register ("getThreadInfo", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getThreadInfo.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioUtils']/method[@name='deviceIsBlacklistedForOpenSLESUsage' and count(parameter)=0]"
		[Register ("deviceIsBlacklistedForOpenSLESUsage", "()Z", "")]
		public static unsafe bool DeviceIsBlacklistedForOpenSLESUsage ()
		{
			const string __id = "deviceIsBlacklistedForOpenSLESUsage.()Z";
			try {
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioUtils']/method[@name='runningOnEmulator' and count(parameter)=0]"
		[Register ("runningOnEmulator", "()Z", "")]
		public static unsafe bool RunningOnEmulator ()
		{
			const string __id = "runningOnEmulator.()Z";
			try {
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioUtils']/method[@name='setWebRtcBasedAcousticEchoCanceler' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setWebRtcBasedAcousticEchoCanceler", "(Z)V", "")]
		public static unsafe void SetWebRtcBasedAcousticEchoCanceler (bool enable)
		{
			const string __id = "setWebRtcBasedAcousticEchoCanceler.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enable);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioUtils']/method[@name='setWebRtcBasedAutomaticGainControl' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setWebRtcBasedAutomaticGainControl", "(Z)V", "")]
		public static unsafe void SetWebRtcBasedAutomaticGainControl (bool enable)
		{
			const string __id = "setWebRtcBasedAutomaticGainControl.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enable);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioUtils']/method[@name='setWebRtcBasedNoiseSuppressor' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setWebRtcBasedNoiseSuppressor", "(Z)V", "")]
		public static unsafe void SetWebRtcBasedNoiseSuppressor (bool enable)
		{
			const string __id = "setWebRtcBasedNoiseSuppressor.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enable);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioUtils']/method[@name='useWebRtcBasedAcousticEchoCanceler' and count(parameter)=0]"
		[Register ("useWebRtcBasedAcousticEchoCanceler", "()Z", "")]
		public static unsafe bool UseWebRtcBasedAcousticEchoCanceler ()
		{
			const string __id = "useWebRtcBasedAcousticEchoCanceler.()Z";
			try {
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioUtils']/method[@name='useWebRtcBasedAutomaticGainControl' and count(parameter)=0]"
		[Register ("useWebRtcBasedAutomaticGainControl", "()Z", "")]
		public static unsafe bool UseWebRtcBasedAutomaticGainControl ()
		{
			const string __id = "useWebRtcBasedAutomaticGainControl.()Z";
			try {
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioUtils']/method[@name='useWebRtcBasedNoiseSuppressor' and count(parameter)=0]"
		[Register ("useWebRtcBasedNoiseSuppressor", "()Z", "")]
		public static unsafe bool UseWebRtcBasedNoiseSuppressor ()
		{
			const string __id = "useWebRtcBasedNoiseSuppressor.()Z";
			try {
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
				return __rm;
			} finally {
			}
		}

	}
}
