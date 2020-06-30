using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoDecoder.Callback']"
	[Register ("org/webrtc/VideoDecoder$Callback", "", "Org.Webrtc.IVideoDecoderCallbackInvoker")]
	public partial interface IVideoDecoderCallback : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoDecoder.Callback']/method[@name='onDecodedFrame' and count(parameter)=3 and parameter[1][@type='org.webrtc.VideoFrame'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='java.lang.Integer']]"
		[Register ("onDecodedFrame", "(Lorg/webrtc/VideoFrame;Ljava/lang/Integer;Ljava/lang/Integer;)V", "GetOnDecodedFrame_Lorg_webrtc_VideoFrame_Ljava_lang_Integer_Ljava_lang_Integer_Handler:Org.Webrtc.IVideoDecoderCallbackInvoker, webrtc_android")]
		void OnDecodedFrame (global::Org.Webrtc.VideoFrame p0, global::Java.Lang.Integer p1, global::Java.Lang.Integer p2);

	}

	[global::Android.Runtime.Register ("org/webrtc/VideoDecoder$Callback", DoNotGenerateAcw=true)]
	internal partial class IVideoDecoderCallbackInvoker : global::Java.Lang.Object, IVideoDecoderCallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoDecoder$Callback", typeof (IVideoDecoderCallbackInvoker));

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

		public static IVideoDecoderCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoDecoderCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.VideoDecoder.Callback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoDecoderCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onDecodedFrame_Lorg_webrtc_VideoFrame_Ljava_lang_Integer_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetOnDecodedFrame_Lorg_webrtc_VideoFrame_Ljava_lang_Integer_Ljava_lang_Integer_Handler ()
		{
			if (cb_onDecodedFrame_Lorg_webrtc_VideoFrame_Ljava_lang_Integer_Ljava_lang_Integer_ == null)
				cb_onDecodedFrame_Lorg_webrtc_VideoFrame_Ljava_lang_Integer_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnDecodedFrame_Lorg_webrtc_VideoFrame_Ljava_lang_Integer_Ljava_lang_Integer_);
			return cb_onDecodedFrame_Lorg_webrtc_VideoFrame_Ljava_lang_Integer_Ljava_lang_Integer_;
		}

		static void n_OnDecodedFrame_Lorg_webrtc_VideoFrame_Ljava_lang_Integer_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Webrtc.IVideoDecoderCallback __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoDecoderCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.VideoFrame p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnDecodedFrame (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onDecodedFrame_Lorg_webrtc_VideoFrame_Ljava_lang_Integer_Ljava_lang_Integer_;
		public unsafe void OnDecodedFrame (global::Org.Webrtc.VideoFrame p0, global::Java.Lang.Integer p1, global::Java.Lang.Integer p2)
		{
			if (id_onDecodedFrame_Lorg_webrtc_VideoFrame_Ljava_lang_Integer_Ljava_lang_Integer_ == IntPtr.Zero)
				id_onDecodedFrame_Lorg_webrtc_VideoFrame_Ljava_lang_Integer_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "onDecodedFrame", "(Lorg/webrtc/VideoFrame;Ljava/lang/Integer;Ljava/lang/Integer;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDecodedFrame_Lorg_webrtc_VideoFrame_Ljava_lang_Integer_Ljava_lang_Integer_, __args);
		}

	}


	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoDecoder.DecodeInfo']"
	[global::Android.Runtime.Register ("org/webrtc/VideoDecoder$DecodeInfo", DoNotGenerateAcw=true)]
	public partial class VideoDecoderDecodeInfo : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoDecoder.DecodeInfo']/field[@name='isMissingFrames']"
		[Register ("isMissingFrames")]
		public bool IsMissingFrames {
			get {
				const string __id = "isMissingFrames.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isMissingFrames.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoDecoder.DecodeInfo']/field[@name='renderTimeMs']"
		[Register ("renderTimeMs")]
		public long RenderTimeMs {
			get {
				const string __id = "renderTimeMs.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "renderTimeMs.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoDecoder$DecodeInfo", typeof (VideoDecoderDecodeInfo));
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

		protected VideoDecoderDecodeInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoDecoder.DecodeInfo']/constructor[@name='VideoDecoder.DecodeInfo' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='long']]"
		[Register (".ctor", "(ZJ)V", "")]
		public unsafe VideoDecoderDecodeInfo (bool isMissingFrames, long renderTimeMs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ZJ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (isMissingFrames);
				__args [1] = new JniArgumentValue (renderTimeMs);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoDecoder.Settings']"
	[global::Android.Runtime.Register ("org/webrtc/VideoDecoder$Settings", DoNotGenerateAcw=true)]
	public partial class VideoDecoderSettings : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoDecoder.Settings']/field[@name='height']"
		[Register ("height")]
		public int Height {
			get {
				const string __id = "height.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "height.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoDecoder.Settings']/field[@name='numberOfCores']"
		[Register ("numberOfCores")]
		public int NumberOfCores {
			get {
				const string __id = "numberOfCores.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "numberOfCores.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoDecoder.Settings']/field[@name='width']"
		[Register ("width")]
		public int Width {
			get {
				const string __id = "width.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "width.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoDecoder$Settings", typeof (VideoDecoderSettings));
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

		protected VideoDecoderSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoDecoder.Settings']/constructor[@name='VideoDecoder.Settings' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(III)V", "")]
		public unsafe VideoDecoderSettings (int numberOfCores, int width, int height)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(III)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (numberOfCores);
				__args [1] = new JniArgumentValue (width);
				__args [2] = new JniArgumentValue (height);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoDecoder']"
	[Register ("org/webrtc/VideoDecoder", "", "Org.Webrtc.IVideoDecoderInvoker")]
	public partial interface IVideoDecoder : IJavaObject, IJavaPeerable {

		string ImplementationName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoDecoder']/method[@name='getImplementationName' and count(parameter)=0]"
			[Register ("getImplementationName", "()Ljava/lang/String;", "GetGetImplementationNameHandler:Org.Webrtc.IVideoDecoderInvoker, webrtc_android")] get;
		}

		bool PrefersLateDecoding {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoDecoder']/method[@name='getPrefersLateDecoding' and count(parameter)=0]"
			[Register ("getPrefersLateDecoding", "()Z", "GetGetPrefersLateDecodingHandler:Org.Webrtc.IVideoDecoderInvoker, webrtc_android")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoDecoder']/method[@name='decode' and count(parameter)=2 and parameter[1][@type='org.webrtc.EncodedImage'] and parameter[2][@type='org.webrtc.VideoDecoder.DecodeInfo']]"
		[Register ("decode", "(Lorg/webrtc/EncodedImage;Lorg/webrtc/VideoDecoder$DecodeInfo;)Lorg/webrtc/VideoCodecStatus;", "GetDecode_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoDecoder_DecodeInfo_Handler:Org.Webrtc.IVideoDecoderInvoker, webrtc_android")]
		global::Org.Webrtc.VideoCodecStatus Decode (global::Org.Webrtc.EncodedImage p0, global::Org.Webrtc.VideoDecoderDecodeInfo p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoDecoder']/method[@name='initDecode' and count(parameter)=2 and parameter[1][@type='org.webrtc.VideoDecoder.Settings'] and parameter[2][@type='org.webrtc.VideoDecoder.Callback']]"
		[Register ("initDecode", "(Lorg/webrtc/VideoDecoder$Settings;Lorg/webrtc/VideoDecoder$Callback;)Lorg/webrtc/VideoCodecStatus;", "GetInitDecode_Lorg_webrtc_VideoDecoder_Settings_Lorg_webrtc_VideoDecoder_Callback_Handler:Org.Webrtc.IVideoDecoderInvoker, webrtc_android")]
		global::Org.Webrtc.VideoCodecStatus InitDecode (global::Org.Webrtc.VideoDecoderSettings p0, global::Org.Webrtc.IVideoDecoderCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoDecoder']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()Lorg/webrtc/VideoCodecStatus;", "GetReleaseHandler:Org.Webrtc.IVideoDecoderInvoker, webrtc_android")]
		global::Org.Webrtc.VideoCodecStatus Release ();

	}

	[global::Android.Runtime.Register ("org/webrtc/VideoDecoder", DoNotGenerateAcw=true)]
	internal partial class IVideoDecoderInvoker : global::Java.Lang.Object, IVideoDecoder {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoDecoder", typeof (IVideoDecoderInvoker));

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

		public static IVideoDecoder GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoDecoder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.VideoDecoder"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoDecoderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getImplementationName;
#pragma warning disable 0169
		static Delegate GetGetImplementationNameHandler ()
		{
			if (cb_getImplementationName == null)
				cb_getImplementationName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImplementationName);
			return cb_getImplementationName;
		}

		static IntPtr n_GetImplementationName (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.IVideoDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ImplementationName);
		}
#pragma warning restore 0169

		IntPtr id_getImplementationName;
		public unsafe string ImplementationName {
			get {
				if (id_getImplementationName == IntPtr.Zero)
					id_getImplementationName = JNIEnv.GetMethodID (class_ref, "getImplementationName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImplementationName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPrefersLateDecoding;
#pragma warning disable 0169
		static Delegate GetGetPrefersLateDecodingHandler ()
		{
			if (cb_getPrefersLateDecoding == null)
				cb_getPrefersLateDecoding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetPrefersLateDecoding);
			return cb_getPrefersLateDecoding;
		}

		static bool n_GetPrefersLateDecoding (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.IVideoDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PrefersLateDecoding;
		}
#pragma warning restore 0169

		IntPtr id_getPrefersLateDecoding;
		public unsafe bool PrefersLateDecoding {
			get {
				if (id_getPrefersLateDecoding == IntPtr.Zero)
					id_getPrefersLateDecoding = JNIEnv.GetMethodID (class_ref, "getPrefersLateDecoding", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getPrefersLateDecoding);
			}
		}

		static Delegate cb_decode_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoDecoder_DecodeInfo_;
#pragma warning disable 0169
		static Delegate GetDecode_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoDecoder_DecodeInfo_Handler ()
		{
			if (cb_decode_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoDecoder_DecodeInfo_ == null)
				cb_decode_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoDecoder_DecodeInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Decode_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoDecoder_DecodeInfo_);
			return cb_decode_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoDecoder_DecodeInfo_;
		}

		static IntPtr n_Decode_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoDecoder_DecodeInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Webrtc.IVideoDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.EncodedImage p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EncodedImage> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.VideoDecoderDecodeInfo p1 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoDecoderDecodeInfo> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_decode_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoDecoder_DecodeInfo_;
		public unsafe global::Org.Webrtc.VideoCodecStatus Decode (global::Org.Webrtc.EncodedImage p0, global::Org.Webrtc.VideoDecoderDecodeInfo p1)
		{
			if (id_decode_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoDecoder_DecodeInfo_ == IntPtr.Zero)
				id_decode_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoDecoder_DecodeInfo_ = JNIEnv.GetMethodID (class_ref, "decode", "(Lorg/webrtc/EncodedImage;Lorg/webrtc/VideoDecoder$DecodeInfo;)Lorg/webrtc/VideoCodecStatus;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Org.Webrtc.VideoCodecStatus __ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecStatus> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decode_Lorg_webrtc_EncodedImage_Lorg_webrtc_VideoDecoder_DecodeInfo_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_initDecode_Lorg_webrtc_VideoDecoder_Settings_Lorg_webrtc_VideoDecoder_Callback_;
#pragma warning disable 0169
		static Delegate GetInitDecode_Lorg_webrtc_VideoDecoder_Settings_Lorg_webrtc_VideoDecoder_Callback_Handler ()
		{
			if (cb_initDecode_Lorg_webrtc_VideoDecoder_Settings_Lorg_webrtc_VideoDecoder_Callback_ == null)
				cb_initDecode_Lorg_webrtc_VideoDecoder_Settings_Lorg_webrtc_VideoDecoder_Callback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_InitDecode_Lorg_webrtc_VideoDecoder_Settings_Lorg_webrtc_VideoDecoder_Callback_);
			return cb_initDecode_Lorg_webrtc_VideoDecoder_Settings_Lorg_webrtc_VideoDecoder_Callback_;
		}

		static IntPtr n_InitDecode_Lorg_webrtc_VideoDecoder_Settings_Lorg_webrtc_VideoDecoder_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Webrtc.IVideoDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.VideoDecoderSettings p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoDecoderSettings> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.IVideoDecoderCallback p1 = (global::Org.Webrtc.IVideoDecoderCallback)global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoDecoderCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InitDecode (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_initDecode_Lorg_webrtc_VideoDecoder_Settings_Lorg_webrtc_VideoDecoder_Callback_;
		public unsafe global::Org.Webrtc.VideoCodecStatus InitDecode (global::Org.Webrtc.VideoDecoderSettings p0, global::Org.Webrtc.IVideoDecoderCallback p1)
		{
			if (id_initDecode_Lorg_webrtc_VideoDecoder_Settings_Lorg_webrtc_VideoDecoder_Callback_ == IntPtr.Zero)
				id_initDecode_Lorg_webrtc_VideoDecoder_Settings_Lorg_webrtc_VideoDecoder_Callback_ = JNIEnv.GetMethodID (class_ref, "initDecode", "(Lorg/webrtc/VideoDecoder$Settings;Lorg/webrtc/VideoDecoder$Callback;)Lorg/webrtc/VideoCodecStatus;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Org.Webrtc.VideoCodecStatus __ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecStatus> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_initDecode_Lorg_webrtc_VideoDecoder_Settings_Lorg_webrtc_VideoDecoder_Callback_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Release);
			return cb_release;
		}

		static IntPtr n_Release (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.IVideoDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Release ());
		}
#pragma warning restore 0169

		IntPtr id_release;
		public unsafe global::Org.Webrtc.VideoCodecStatus Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()Lorg/webrtc/VideoCodecStatus;");
			return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCodecStatus> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_release), JniHandleOwnership.TransferLocalRef);
		}

	}

}
