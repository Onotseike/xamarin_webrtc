using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='EncodedImage']"
	[global::Android.Runtime.Register ("org/webrtc/EncodedImage", DoNotGenerateAcw=true)]
	public partial class EncodedImage : global::Java.Lang.Object, global::Org.Webrtc.IRefCounted {



		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='EncodedImage']/field[@name='buffer']"
		[Register ("buffer")]
		public global::Java.Nio.ByteBuffer Buffer {
			get {
				const string __id = "buffer.Ljava/nio/ByteBuffer;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "buffer.Ljava/nio/ByteBuffer;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='EncodedImage']/field[@name='captureTimeMs']"
		[Register ("captureTimeMs")]
		public long CaptureTimeMs {
			get {
				const string __id = "captureTimeMs.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "captureTimeMs.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='EncodedImage']/field[@name='captureTimeNs']"
		[Register ("captureTimeNs")]
		public long CaptureTimeNs {
			get {
				const string __id = "captureTimeNs.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "captureTimeNs.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='EncodedImage']/field[@name='completeFrame']"
		[Register ("completeFrame")]
		public bool CompleteFrame {
			get {
				const string __id = "completeFrame.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "completeFrame.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='EncodedImage']/field[@name='encodedHeight']"
		[Register ("encodedHeight")]
		public int EncodedHeight {
			get {
				const string __id = "encodedHeight.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "encodedHeight.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='EncodedImage']/field[@name='encodedWidth']"
		[Register ("encodedWidth")]
		public int EncodedWidth {
			get {
				const string __id = "encodedWidth.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "encodedWidth.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='EncodedImage']/field[@name='qp']"
		[Register ("qp")]
		public global::Java.Lang.Integer Qp {
			get {
				const string __id = "qp.Ljava/lang/Integer;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "qp.Ljava/lang/Integer;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='EncodedImage']/field[@name='rotation']"
		[Register ("rotation")]
		public int Rotation {
			get {
				const string __id = "rotation.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "rotation.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='EncodedImage.Builder']"
		[global::Android.Runtime.Register ("org/webrtc/EncodedImage$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/EncodedImage$Builder", typeof (Builder));
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

			static Delegate cb_createEncodedImage;
#pragma warning disable 0169
			static Delegate GetCreateEncodedImageHandler ()
			{
				if (cb_createEncodedImage == null)
					cb_createEncodedImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreateEncodedImage);
				return cb_createEncodedImage;
			}

			static IntPtr n_CreateEncodedImage (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.EncodedImage.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EncodedImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.CreateEncodedImage ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EncodedImage.Builder']/method[@name='createEncodedImage' and count(parameter)=0]"
			[Register ("createEncodedImage", "()Lorg/webrtc/EncodedImage;", "GetCreateEncodedImageHandler")]
			public virtual unsafe global::Org.Webrtc.EncodedImage CreateEncodedImage ()
			{
				const string __id = "createEncodedImage.()Lorg/webrtc/EncodedImage;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.EncodedImage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setBuffer_Ljava_nio_ByteBuffer_Ljava_lang_Runnable_;
#pragma warning disable 0169
			static Delegate GetSetBuffer_Ljava_nio_ByteBuffer_Ljava_lang_Runnable_Handler ()
			{
				if (cb_setBuffer_Ljava_nio_ByteBuffer_Ljava_lang_Runnable_ == null)
					cb_setBuffer_Ljava_nio_ByteBuffer_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetBuffer_Ljava_nio_ByteBuffer_Ljava_lang_Runnable_);
				return cb_setBuffer_Ljava_nio_ByteBuffer_Ljava_lang_Runnable_;
			}

			static IntPtr n_SetBuffer_Ljava_nio_ByteBuffer_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, IntPtr native_releaseCallback)
			{
				global::Org.Webrtc.EncodedImage.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EncodedImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Nio.ByteBuffer buffer = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.IRunnable releaseCallback = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_releaseCallback, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetBuffer (buffer, releaseCallback));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EncodedImage.Builder']/method[@name='setBuffer' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='java.lang.Runnable']]"
			[Register ("setBuffer", "(Ljava/nio/ByteBuffer;Ljava/lang/Runnable;)Lorg/webrtc/EncodedImage$Builder;", "GetSetBuffer_Ljava_nio_ByteBuffer_Ljava_lang_Runnable_Handler")]
			public virtual unsafe global::Org.Webrtc.EncodedImage.Builder SetBuffer (global::Java.Nio.ByteBuffer buffer, global::Java.Lang.IRunnable releaseCallback)
			{
				const string __id = "setBuffer.(Ljava/nio/ByteBuffer;Ljava/lang/Runnable;)Lorg/webrtc/EncodedImage$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
					__args [1] = new JniArgumentValue ((releaseCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) releaseCallback).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.EncodedImage.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setCaptureTimeMs_J;
#pragma warning disable 0169
			[Obsolete]
			static Delegate GetSetCaptureTimeMs_JHandler ()
			{
				if (cb_setCaptureTimeMs_J == null)
					cb_setCaptureTimeMs_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetCaptureTimeMs_J);
				return cb_setCaptureTimeMs_J;
			}

			[Obsolete]
			static IntPtr n_SetCaptureTimeMs_J (IntPtr jnienv, IntPtr native__this, long captureTimeMs)
			{
				global::Org.Webrtc.EncodedImage.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EncodedImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetCaptureTimeMs (captureTimeMs));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EncodedImage.Builder']/method[@name='setCaptureTimeMs' and count(parameter)=1 and parameter[1][@type='long']]"
			[Obsolete (@"deprecated")]
			[Register ("setCaptureTimeMs", "(J)Lorg/webrtc/EncodedImage$Builder;", "GetSetCaptureTimeMs_JHandler")]
			public virtual unsafe global::Org.Webrtc.EncodedImage.Builder SetCaptureTimeMs (long captureTimeMs)
			{
				const string __id = "setCaptureTimeMs.(J)Lorg/webrtc/EncodedImage$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (captureTimeMs);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.EncodedImage.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setCaptureTimeNs_J;
#pragma warning disable 0169
			static Delegate GetSetCaptureTimeNs_JHandler ()
			{
				if (cb_setCaptureTimeNs_J == null)
					cb_setCaptureTimeNs_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetCaptureTimeNs_J);
				return cb_setCaptureTimeNs_J;
			}

			static IntPtr n_SetCaptureTimeNs_J (IntPtr jnienv, IntPtr native__this, long captureTimeNs)
			{
				global::Org.Webrtc.EncodedImage.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EncodedImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetCaptureTimeNs (captureTimeNs));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EncodedImage.Builder']/method[@name='setCaptureTimeNs' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setCaptureTimeNs", "(J)Lorg/webrtc/EncodedImage$Builder;", "GetSetCaptureTimeNs_JHandler")]
			public virtual unsafe global::Org.Webrtc.EncodedImage.Builder SetCaptureTimeNs (long captureTimeNs)
			{
				const string __id = "setCaptureTimeNs.(J)Lorg/webrtc/EncodedImage$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (captureTimeNs);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.EncodedImage.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setCompleteFrame_Z;
#pragma warning disable 0169
			static Delegate GetSetCompleteFrame_ZHandler ()
			{
				if (cb_setCompleteFrame_Z == null)
					cb_setCompleteFrame_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetCompleteFrame_Z);
				return cb_setCompleteFrame_Z;
			}

			static IntPtr n_SetCompleteFrame_Z (IntPtr jnienv, IntPtr native__this, bool completeFrame)
			{
				global::Org.Webrtc.EncodedImage.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EncodedImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetCompleteFrame (completeFrame));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EncodedImage.Builder']/method[@name='setCompleteFrame' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCompleteFrame", "(Z)Lorg/webrtc/EncodedImage$Builder;", "GetSetCompleteFrame_ZHandler")]
			public virtual unsafe global::Org.Webrtc.EncodedImage.Builder SetCompleteFrame (bool completeFrame)
			{
				const string __id = "setCompleteFrame.(Z)Lorg/webrtc/EncodedImage$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (completeFrame);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.EncodedImage.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setEncodedHeight_I;
#pragma warning disable 0169
			static Delegate GetSetEncodedHeight_IHandler ()
			{
				if (cb_setEncodedHeight_I == null)
					cb_setEncodedHeight_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetEncodedHeight_I);
				return cb_setEncodedHeight_I;
			}

			static IntPtr n_SetEncodedHeight_I (IntPtr jnienv, IntPtr native__this, int encodedHeight)
			{
				global::Org.Webrtc.EncodedImage.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EncodedImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetEncodedHeight (encodedHeight));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EncodedImage.Builder']/method[@name='setEncodedHeight' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setEncodedHeight", "(I)Lorg/webrtc/EncodedImage$Builder;", "GetSetEncodedHeight_IHandler")]
			public virtual unsafe global::Org.Webrtc.EncodedImage.Builder SetEncodedHeight (int encodedHeight)
			{
				const string __id = "setEncodedHeight.(I)Lorg/webrtc/EncodedImage$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (encodedHeight);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.EncodedImage.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setEncodedWidth_I;
#pragma warning disable 0169
			static Delegate GetSetEncodedWidth_IHandler ()
			{
				if (cb_setEncodedWidth_I == null)
					cb_setEncodedWidth_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetEncodedWidth_I);
				return cb_setEncodedWidth_I;
			}

			static IntPtr n_SetEncodedWidth_I (IntPtr jnienv, IntPtr native__this, int encodedWidth)
			{
				global::Org.Webrtc.EncodedImage.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EncodedImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetEncodedWidth (encodedWidth));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EncodedImage.Builder']/method[@name='setEncodedWidth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setEncodedWidth", "(I)Lorg/webrtc/EncodedImage$Builder;", "GetSetEncodedWidth_IHandler")]
			public virtual unsafe global::Org.Webrtc.EncodedImage.Builder SetEncodedWidth (int encodedWidth)
			{
				const string __id = "setEncodedWidth.(I)Lorg/webrtc/EncodedImage$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (encodedWidth);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.EncodedImage.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setFrameType_Lorg_webrtc_EncodedImage_FrameType_;
#pragma warning disable 0169
			static Delegate GetSetFrameType_Lorg_webrtc_EncodedImage_FrameType_Handler ()
			{
				if (cb_setFrameType_Lorg_webrtc_EncodedImage_FrameType_ == null)
					cb_setFrameType_Lorg_webrtc_EncodedImage_FrameType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetFrameType_Lorg_webrtc_EncodedImage_FrameType_);
				return cb_setFrameType_Lorg_webrtc_EncodedImage_FrameType_;
			}

			static IntPtr n_SetFrameType_Lorg_webrtc_EncodedImage_FrameType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_frameType)
			{
				global::Org.Webrtc.EncodedImage.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EncodedImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.EncodedImage.FrameType frameType = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EncodedImage.FrameType> (native_frameType, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFrameType (frameType));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EncodedImage.Builder']/method[@name='setFrameType' and count(parameter)=1 and parameter[1][@type='org.webrtc.EncodedImage.FrameType']]"
			[Register ("setFrameType", "(Lorg/webrtc/EncodedImage$FrameType;)Lorg/webrtc/EncodedImage$Builder;", "GetSetFrameType_Lorg_webrtc_EncodedImage_FrameType_Handler")]
			public virtual unsafe global::Org.Webrtc.EncodedImage.Builder SetFrameType (global::Org.Webrtc.EncodedImage.FrameType frameType)
			{
				const string __id = "setFrameType.(Lorg/webrtc/EncodedImage$FrameType;)Lorg/webrtc/EncodedImage$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((frameType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) frameType).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.EncodedImage.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setQp_Ljava_lang_Integer_;
#pragma warning disable 0169
			static Delegate GetSetQp_Ljava_lang_Integer_Handler ()
			{
				if (cb_setQp_Ljava_lang_Integer_ == null)
					cb_setQp_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetQp_Ljava_lang_Integer_);
				return cb_setQp_Ljava_lang_Integer_;
			}

			static IntPtr n_SetQp_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_qp)
			{
				global::Org.Webrtc.EncodedImage.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EncodedImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Integer qp = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_qp, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetQp (qp));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EncodedImage.Builder']/method[@name='setQp' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setQp", "(Ljava/lang/Integer;)Lorg/webrtc/EncodedImage$Builder;", "GetSetQp_Ljava_lang_Integer_Handler")]
			public virtual unsafe global::Org.Webrtc.EncodedImage.Builder SetQp (global::Java.Lang.Integer qp)
			{
				const string __id = "setQp.(Ljava/lang/Integer;)Lorg/webrtc/EncodedImage$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((qp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) qp).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.EncodedImage.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setRotation_I;
#pragma warning disable 0169
			static Delegate GetSetRotation_IHandler ()
			{
				if (cb_setRotation_I == null)
					cb_setRotation_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetRotation_I);
				return cb_setRotation_I;
			}

			static IntPtr n_SetRotation_I (IntPtr jnienv, IntPtr native__this, int rotation)
			{
				global::Org.Webrtc.EncodedImage.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EncodedImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetRotation (rotation));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EncodedImage.Builder']/method[@name='setRotation' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRotation", "(I)Lorg/webrtc/EncodedImage$Builder;", "GetSetRotation_IHandler")]
			public virtual unsafe global::Org.Webrtc.EncodedImage.Builder SetRotation (int rotation)
			{
				const string __id = "setRotation.(I)Lorg/webrtc/EncodedImage$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (rotation);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.EncodedImage.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='EncodedImage.FrameType']"
		[global::Android.Runtime.Register ("org/webrtc/EncodedImage$FrameType", DoNotGenerateAcw=true)]
		public sealed partial class FrameType : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='EncodedImage.FrameType']/field[@name='EmptyFrame']"
			[Register ("EmptyFrame")]
			public static global::Org.Webrtc.EncodedImage.FrameType EmptyFrame {
				get {
					const string __id = "EmptyFrame.Lorg/webrtc/EncodedImage$FrameType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.EncodedImage.FrameType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='EncodedImage.FrameType']/field[@name='VideoFrameDelta']"
			[Register ("VideoFrameDelta")]
			public static global::Org.Webrtc.EncodedImage.FrameType VideoFrameDelta {
				get {
					const string __id = "VideoFrameDelta.Lorg/webrtc/EncodedImage$FrameType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.EncodedImage.FrameType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='EncodedImage.FrameType']/field[@name='VideoFrameKey']"
			[Register ("VideoFrameKey")]
			public static global::Org.Webrtc.EncodedImage.FrameType VideoFrameKey {
				get {
					const string __id = "VideoFrameKey.Lorg/webrtc/EncodedImage$FrameType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.EncodedImage.FrameType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/EncodedImage$FrameType", typeof (FrameType));
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

			internal FrameType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			public unsafe int Native {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EncodedImage.FrameType']/method[@name='getNative' and count(parameter)=0]"
				[Register ("getNative", "()I", "")]
				get {
					const string __id = "getNative.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EncodedImage.FrameType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/EncodedImage$FrameType;", "")]
			public static unsafe global::Org.Webrtc.EncodedImage.FrameType ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/webrtc/EncodedImage$FrameType;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.EncodedImage.FrameType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EncodedImage.FrameType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/EncodedImage$FrameType;", "")]
			public static unsafe global::Org.Webrtc.EncodedImage.FrameType[] Values ()
			{
				const string __id = "values.()[Lorg/webrtc/EncodedImage$FrameType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Webrtc.EncodedImage.FrameType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.EncodedImage.FrameType));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/EncodedImage", typeof (EncodedImage));
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

		protected EncodedImage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EncodedImage']/method[@name='builder' and count(parameter)=0]"
		[Register ("builder", "()Lorg/webrtc/EncodedImage$Builder;", "")]
		public static unsafe global::Org.Webrtc.EncodedImage.Builder InvokeBuilder ()
		{
			const string __id = "builder.()Lorg/webrtc/EncodedImage$Builder;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.EncodedImage.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Org.Webrtc.EncodedImage __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EncodedImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EncodedImage']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_retain;
#pragma warning disable 0169
		static Delegate GetRetainHandler ()
		{
			if (cb_retain == null)
				cb_retain = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Retain);
			return cb_retain;
		}

		static void n_Retain (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.EncodedImage __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EncodedImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Retain ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EncodedImage']/method[@name='retain' and count(parameter)=0]"
		[Register ("retain", "()V", "GetRetainHandler")]
		public virtual unsafe void Retain ()
		{
			const string __id = "retain.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
