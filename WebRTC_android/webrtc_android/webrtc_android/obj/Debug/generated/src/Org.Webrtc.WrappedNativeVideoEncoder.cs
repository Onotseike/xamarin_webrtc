using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='WrappedNativeVideoEncoder']"
	[global::Android.Runtime.Register ("org/webrtc/WrappedNativeVideoEncoder", DoNotGenerateAcw=true)]
	public abstract partial class WrappedNativeVideoEncoder : global::Java.Lang.Object, global::Org.Webrtc.IVideoEncoder {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/WrappedNativeVideoEncoder", typeof (WrappedNativeVideoEncoder));
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

		protected WrappedNativeVideoEncoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='WrappedNativeVideoEncoder']/constructor[@name='WrappedNativeVideoEncoder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WrappedNativeVideoEncoder ()
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

		public unsafe string ImplementationName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='WrappedNativeVideoEncoder']/method[@name='getImplementationName' and count(parameter)=0]"
			[Register ("getImplementationName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getImplementationName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isHardwareEncoder;
#pragma warning disable 0169
		static Delegate GetIsHardwareEncoderHandler ()
		{
			if (cb_isHardwareEncoder == null)
				cb_isHardwareEncoder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHardwareEncoder);
			return cb_isHardwareEncoder;
		}

		static bool n_IsHardwareEncoder (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.WrappedNativeVideoEncoder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.WrappedNativeVideoEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHardwareEncoder;
		}
#pragma warning restore 0169

		public abstract bool IsHardwareEncoder {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='WrappedNativeVideoEncoder']/method[@name='isHardwareEncoder' and count(parameter)=0]"
			[Register ("isHardwareEncoder", "()Z", "GetIsHardwareEncoderHandler")] get;
		}

		public unsafe global::Org.Webrtc.VideoEncoderScalingSettings ScalingSettings {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='WrappedNativeVideoEncoder']/method[@name='getScalingSettings' and count(parameter)=0]"
			[Register ("getScalingSettings", "()Lorg/webrtc/VideoEncoder$ScalingSettings;", "")]
			get {
				const string __id = "getScalingSettings.()Lorg/webrtc/VideoEncoder$ScalingSettings;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoEncoderScalingSettings> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_createNativeVideoEncoder;
#pragma warning disable 0169
		static Delegate GetCreateNativeVideoEncoderHandler ()
		{
			if (cb_createNativeVideoEncoder == null)
				cb_createNativeVideoEncoder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_CreateNativeVideoEncoder);
			return cb_createNativeVideoEncoder;
		}

		static long n_CreateNativeVideoEncoder (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.WrappedNativeVideoEncoder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.WrappedNativeVideoEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CreateNativeVideoEncoder ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='WrappedNativeVideoEncoder']/method[@name='createNativeVideoEncoder' and count(parameter)=0]"
		[Register ("createNativeVideoEncoder", "()J", "GetCreateNativeVideoEncoderHandler")]
		public abstract long CreateNativeVideoEncoder ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='WrappedNativeVideoEncoder']/method[@name='encode' and count(parameter)=2 and parameter[1][@type='org.webrtc.VideoFrame'] and parameter[2][@type='org.webrtc.VideoEncoder.EncodeInfo']]"
		[Register ("encode", "(Lorg/webrtc/VideoFrame;Lorg/webrtc/VideoEncoder$EncodeInfo;)Lorg/webrtc/VideoCodecStatus;", "")]
		public unsafe global::Org.Webrtc.VideoCodecStatus Encode (global::Org.Webrtc.VideoFrame frame, global::Org.Webrtc.VideoEncoderEncodeInfo info)
		{
			const string __id = "encode.(Lorg/webrtc/VideoFrame;Lorg/webrtc/VideoEncoder$EncodeInfo;)Lorg/webrtc/VideoCodecStatus;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((frame == null) ? IntPtr.Zero : ((global::Java.Lang.Object) frame).Handle);
				__args [1] = new JniArgumentValue ((info == null) ? IntPtr.Zero : ((global::Java.Lang.Object) info).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='WrappedNativeVideoEncoder']/method[@name='initEncode' and count(parameter)=2 and parameter[1][@type='org.webrtc.VideoEncoder.Settings'] and parameter[2][@type='org.webrtc.VideoEncoder.Callback']]"
		[Register ("initEncode", "(Lorg/webrtc/VideoEncoder$Settings;Lorg/webrtc/VideoEncoder$Callback;)Lorg/webrtc/VideoCodecStatus;", "")]
		public unsafe global::Org.Webrtc.VideoCodecStatus InitEncode (global::Org.Webrtc.VideoEncoderSettings settings, global::Org.Webrtc.IVideoEncoderCallback encodeCallback)
		{
			const string __id = "initEncode.(Lorg/webrtc/VideoEncoder$Settings;Lorg/webrtc/VideoEncoder$Callback;)Lorg/webrtc/VideoCodecStatus;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((settings == null) ? IntPtr.Zero : ((global::Java.Lang.Object) settings).Handle);
				__args [1] = new JniArgumentValue ((encodeCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) encodeCallback).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='WrappedNativeVideoEncoder']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()Lorg/webrtc/VideoCodecStatus;", "")]
		public unsafe global::Org.Webrtc.VideoCodecStatus Release ()
		{
			const string __id = "release.()Lorg/webrtc/VideoCodecStatus;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='WrappedNativeVideoEncoder']/method[@name='setRateAllocation' and count(parameter)=2 and parameter[1][@type='org.webrtc.VideoEncoder.BitrateAllocation'] and parameter[2][@type='int']]"
		[Register ("setRateAllocation", "(Lorg/webrtc/VideoEncoder$BitrateAllocation;I)Lorg/webrtc/VideoCodecStatus;", "")]
		public unsafe global::Org.Webrtc.VideoCodecStatus SetRateAllocation (global::Org.Webrtc.VideoEncoderBitrateAllocation allocation, int framerate)
		{
			const string __id = "setRateAllocation.(Lorg/webrtc/VideoEncoder$BitrateAllocation;I)Lorg/webrtc/VideoCodecStatus;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((allocation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) allocation).Handle);
				__args [1] = new JniArgumentValue (framerate);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/webrtc/WrappedNativeVideoEncoder", DoNotGenerateAcw=true)]
	internal partial class WrappedNativeVideoEncoderInvoker : WrappedNativeVideoEncoder {

		public WrappedNativeVideoEncoderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/WrappedNativeVideoEncoder", typeof (WrappedNativeVideoEncoderInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe bool IsHardwareEncoder {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='WrappedNativeVideoEncoder']/method[@name='isHardwareEncoder' and count(parameter)=0]"
			[Register ("isHardwareEncoder", "()Z", "GetIsHardwareEncoderHandler")]
			get {
				const string __id = "isHardwareEncoder.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='WrappedNativeVideoEncoder']/method[@name='createNativeVideoEncoder' and count(parameter)=0]"
		[Register ("createNativeVideoEncoder", "()J", "GetCreateNativeVideoEncoderHandler")]
		public override unsafe long CreateNativeVideoEncoder ()
		{
			const string __id = "createNativeVideoEncoder.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}

}
