using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='SoftwareVideoDecoderFactory']"
	[global::Android.Runtime.Register ("org/webrtc/SoftwareVideoDecoderFactory", DoNotGenerateAcw=true)]
	public partial class SoftwareVideoDecoderFactory : global::Java.Lang.Object, global::Org.Webrtc.IVideoDecoderFactory {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/SoftwareVideoDecoderFactory", typeof (SoftwareVideoDecoderFactory));
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

		protected SoftwareVideoDecoderFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='SoftwareVideoDecoderFactory']/constructor[@name='SoftwareVideoDecoderFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SoftwareVideoDecoderFactory ()
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

		static Delegate cb_createDecoder_Ljava_lang_String_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetCreateDecoder_Ljava_lang_String_Handler ()
		{
			if (cb_createDecoder_Ljava_lang_String_ == null)
				cb_createDecoder_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateDecoder_Ljava_lang_String_);
			return cb_createDecoder_Ljava_lang_String_;
		}

		[Obsolete]
		static IntPtr n_CreateDecoder_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_codecType)
		{
			global::Org.Webrtc.SoftwareVideoDecoderFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SoftwareVideoDecoderFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string codecType = JNIEnv.GetString (native_codecType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateDecoder (codecType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SoftwareVideoDecoderFactory']/method[@name='createDecoder' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("createDecoder", "(Ljava/lang/String;)Lorg/webrtc/VideoDecoder;", "GetCreateDecoder_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Webrtc.IVideoDecoder CreateDecoder (string codecType)
		{
			const string __id = "createDecoder.(Ljava/lang/String;)Lorg/webrtc/VideoDecoder;";
			IntPtr native_codecType = JNIEnv.NewString (codecType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_codecType);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoDecoder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_codecType);
			}
		}

		static Delegate cb_createDecoder_Lorg_webrtc_VideoCodecInfo_;
#pragma warning disable 0169
		static Delegate GetCreateDecoder_Lorg_webrtc_VideoCodecInfo_Handler ()
		{
			if (cb_createDecoder_Lorg_webrtc_VideoCodecInfo_ == null)
				cb_createDecoder_Lorg_webrtc_VideoCodecInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateDecoder_Lorg_webrtc_VideoCodecInfo_);
			return cb_createDecoder_Lorg_webrtc_VideoCodecInfo_;
		}

		static IntPtr n_CreateDecoder_Lorg_webrtc_VideoCodecInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_codecType)
		{
			global::Org.Webrtc.SoftwareVideoDecoderFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SoftwareVideoDecoderFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.VideoCodecInfo codecType = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecInfo> (native_codecType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateDecoder (codecType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SoftwareVideoDecoderFactory']/method[@name='createDecoder' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoCodecInfo']]"
		[Register ("createDecoder", "(Lorg/webrtc/VideoCodecInfo;)Lorg/webrtc/VideoDecoder;", "GetCreateDecoder_Lorg_webrtc_VideoCodecInfo_Handler")]
		public virtual unsafe global::Org.Webrtc.IVideoDecoder CreateDecoder (global::Org.Webrtc.VideoCodecInfo codecType)
		{
			const string __id = "createDecoder.(Lorg/webrtc/VideoCodecInfo;)Lorg/webrtc/VideoDecoder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((codecType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) codecType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoDecoder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Org.Webrtc.SoftwareVideoDecoderFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SoftwareVideoDecoderFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSupportedCodecs ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SoftwareVideoDecoderFactory']/method[@name='getSupportedCodecs' and count(parameter)=0]"
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
