using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc.Voiceengine {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioManager']"
	[global::Android.Runtime.Register ("org/webrtc/voiceengine/WebRtcAudioManager", DoNotGenerateAcw=true)]
	public partial class WebRtcAudioManager : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/voiceengine/WebRtcAudioManager", typeof (WebRtcAudioManager));
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

		protected WebRtcAudioManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_isLowLatencyInputSupported;
#pragma warning disable 0169
		static Delegate GetIsLowLatencyInputSupportedHandler ()
		{
			if (cb_isLowLatencyInputSupported == null)
				cb_isLowLatencyInputSupported = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLowLatencyInputSupported);
			return cb_isLowLatencyInputSupported;
		}

		static bool n_IsLowLatencyInputSupported (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.Voiceengine.WebRtcAudioManager __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Voiceengine.WebRtcAudioManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLowLatencyInputSupported;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsLowLatencyInputSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioManager']/method[@name='isLowLatencyInputSupported' and count(parameter)=0]"
			[Register ("isLowLatencyInputSupported", "()Z", "GetIsLowLatencyInputSupportedHandler")]
			get {
				const string __id = "isLowLatencyInputSupported.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool StereoInput {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioManager']/method[@name='getStereoInput' and count(parameter)=0]"
			[Register ("getStereoInput", "()Z", "")]
			get {
				const string __id = "getStereoInput.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioManager']/method[@name='setStereoInput' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setStereoInput", "(Z)V", "")]
			set {
				const string __id = "setStereoInput.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		public static unsafe bool StereoOutput {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioManager']/method[@name='getStereoOutput' and count(parameter)=0]"
			[Register ("getStereoOutput", "()Z", "")]
			get {
				const string __id = "getStereoOutput.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioManager']/method[@name='setStereoOutput' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setStereoOutput", "(Z)V", "")]
			set {
				const string __id = "setStereoOutput.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioManager']/method[@name='setBlacklistDeviceForOpenSLESUsage' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setBlacklistDeviceForOpenSLESUsage", "(Z)V", "")]
		public static unsafe void SetBlacklistDeviceForOpenSLESUsage (bool enable)
		{
			const string __id = "setBlacklistDeviceForOpenSLESUsage.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enable);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
