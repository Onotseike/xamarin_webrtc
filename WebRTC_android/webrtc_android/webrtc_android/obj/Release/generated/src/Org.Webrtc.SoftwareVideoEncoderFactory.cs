using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='SoftwareVideoEncoderFactory']"
	[global::Android.Runtime.Register ("org/webrtc/SoftwareVideoEncoderFactory", DoNotGenerateAcw=true)]
	public partial class SoftwareVideoEncoderFactory : global::Java.Lang.Object, global::Org.Webrtc.IVideoEncoderFactory {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/SoftwareVideoEncoderFactory", typeof (SoftwareVideoEncoderFactory));
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

		protected SoftwareVideoEncoderFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='SoftwareVideoEncoderFactory']/constructor[@name='SoftwareVideoEncoderFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SoftwareVideoEncoderFactory ()
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

		static Delegate cb_createEncoder_Lorg_webrtc_VideoCodecInfo_;
#pragma warning disable 0169
		static Delegate GetCreateEncoder_Lorg_webrtc_VideoCodecInfo_Handler ()
		{
			if (cb_createEncoder_Lorg_webrtc_VideoCodecInfo_ == null)
				cb_createEncoder_Lorg_webrtc_VideoCodecInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateEncoder_Lorg_webrtc_VideoCodecInfo_);
			return cb_createEncoder_Lorg_webrtc_VideoCodecInfo_;
		}

		static IntPtr n_CreateEncoder_Lorg_webrtc_VideoCodecInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_info)
		{
			global::Org.Webrtc.SoftwareVideoEncoderFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SoftwareVideoEncoderFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.VideoCodecInfo info = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecInfo> (native_info, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateEncoder (info));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SoftwareVideoEncoderFactory']/method[@name='createEncoder' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoCodecInfo']]"
		[Register ("createEncoder", "(Lorg/webrtc/VideoCodecInfo;)Lorg/webrtc/VideoEncoder;", "GetCreateEncoder_Lorg_webrtc_VideoCodecInfo_Handler")]
		public virtual unsafe global::Org.Webrtc.IVideoEncoder CreateEncoder (global::Org.Webrtc.VideoCodecInfo info)
		{
			const string __id = "createEncoder.(Lorg/webrtc/VideoCodecInfo;)Lorg/webrtc/VideoEncoder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((info == null) ? IntPtr.Zero : ((global::Java.Lang.Object) info).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoEncoder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getSupportedCodecs;
#pragma warning disable 0169
		static Delegate GetGetSupportedCodecsHandler ()
		{
			if (cb_getSupportedCodecs == null)
				cb_getSupportedCodecs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSupportedCodecs);
			return cb_getSupportedCodecs;
		}

		static IntPtr n_GetSupportedCodecs (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.SoftwareVideoEncoderFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SoftwareVideoEncoderFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSupportedCodecs ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SoftwareVideoEncoderFactory']/method[@name='getSupportedCodecs' and count(parameter)=0]"
		[Register ("getSupportedCodecs", "()[Lorg/webrtc/VideoCodecInfo;", "GetGetSupportedCodecsHandler")]
		public virtual unsafe global::Org.Webrtc.VideoCodecInfo[] GetSupportedCodecs ()
		{
			const string __id = "getSupportedCodecs.()[Lorg/webrtc/VideoCodecInfo;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Org.Webrtc.VideoCodecInfo[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.VideoCodecInfo));
			} finally {
			}
		}

	}
}
