using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='JavaI420Buffer']"
	[global::Android.Runtime.Register ("org/webrtc/JavaI420Buffer", DoNotGenerateAcw=true)]
	public partial class JavaI420Buffer : global::Java.Lang.Object, global::Org.Webrtc.VideoFrame.II420Buffer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/JavaI420Buffer", typeof (JavaI420Buffer));
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

		protected JavaI420Buffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getDataU;
#pragma warning disable 0169
		static Delegate GetGetDataUHandler ()
		{
			if (cb_getDataU == null)
				cb_getDataU = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDataU);
			return cb_getDataU;
		}

		static IntPtr n_GetDataU (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.JavaI420Buffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.JavaI420Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DataU);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Nio.ByteBuffer DataU {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='JavaI420Buffer']/method[@name='getDataU' and count(parameter)=0]"
			[Register ("getDataU", "()Ljava/nio/ByteBuffer;", "GetGetDataUHandler")]
			get {
				const string __id = "getDataU.()Ljava/nio/ByteBuffer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDataV;
#pragma warning disable 0169
		static Delegate GetGetDataVHandler ()
		{
			if (cb_getDataV == null)
				cb_getDataV = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDataV);
			return cb_getDataV;
		}

		static IntPtr n_GetDataV (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.JavaI420Buffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.JavaI420Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DataV);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Nio.ByteBuffer DataV {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='JavaI420Buffer']/method[@name='getDataV' and count(parameter)=0]"
			[Register ("getDataV", "()Ljava/nio/ByteBuffer;", "GetGetDataVHandler")]
			get {
				const string __id = "getDataV.()Ljava/nio/ByteBuffer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDataY;
#pragma warning disable 0169
		static Delegate GetGetDataYHandler ()
		{
			if (cb_getDataY == null)
				cb_getDataY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDataY);
			return cb_getDataY;
		}

		static IntPtr n_GetDataY (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.JavaI420Buffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.JavaI420Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DataY);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Nio.ByteBuffer DataY {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='JavaI420Buffer']/method[@name='getDataY' and count(parameter)=0]"
			[Register ("getDataY", "()Ljava/nio/ByteBuffer;", "GetGetDataYHandler")]
			get {
				const string __id = "getDataY.()Ljava/nio/ByteBuffer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.JavaI420Buffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.JavaI420Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		public virtual unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='JavaI420Buffer']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				const string __id = "getHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getStrideU;
#pragma warning disable 0169
		static Delegate GetGetStrideUHandler ()
		{
			if (cb_getStrideU == null)
				cb_getStrideU = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStrideU);
			return cb_getStrideU;
		}

		static int n_GetStrideU (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.JavaI420Buffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.JavaI420Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StrideU;
		}
#pragma warning restore 0169

		public virtual unsafe int StrideU {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='JavaI420Buffer']/method[@name='getStrideU' and count(parameter)=0]"
			[Register ("getStrideU", "()I", "GetGetStrideUHandler")]
			get {
				const string __id = "getStrideU.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getStrideV;
#pragma warning disable 0169
		static Delegate GetGetStrideVHandler ()
		{
			if (cb_getStrideV == null)
				cb_getStrideV = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStrideV);
			return cb_getStrideV;
		}

		static int n_GetStrideV (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.JavaI420Buffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.JavaI420Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StrideV;
		}
#pragma warning restore 0169

		public virtual unsafe int StrideV {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='JavaI420Buffer']/method[@name='getStrideV' and count(parameter)=0]"
			[Register ("getStrideV", "()I", "GetGetStrideVHandler")]
			get {
				const string __id = "getStrideV.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getStrideY;
#pragma warning disable 0169
		static Delegate GetGetStrideYHandler ()
		{
			if (cb_getStrideY == null)
				cb_getStrideY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStrideY);
			return cb_getStrideY;
		}

		static int n_GetStrideY (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.JavaI420Buffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.JavaI420Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StrideY;
		}
#pragma warning restore 0169

		public virtual unsafe int StrideY {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='JavaI420Buffer']/method[@name='getStrideY' and count(parameter)=0]"
			[Register ("getStrideY", "()I", "GetGetStrideYHandler")]
			get {
				const string __id = "getStrideY.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidth);
			return cb_getWidth;
		}

		static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.JavaI420Buffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.JavaI420Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		public virtual unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='JavaI420Buffer']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler")]
			get {
				const string __id = "getWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='JavaI420Buffer']/method[@name='allocate' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("allocate", "(II)Lorg/webrtc/JavaI420Buffer;", "")]
		public static unsafe global::Org.Webrtc.JavaI420Buffer Allocate (int width, int height)
		{
			const string __id = "allocate.(II)Lorg/webrtc/JavaI420Buffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.JavaI420Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_cropAndScale_IIIIII;
#pragma warning disable 0169
		static Delegate GetCropAndScale_IIIIIIHandler ()
		{
			if (cb_cropAndScale_IIIIII == null)
				cb_cropAndScale_IIIIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, int, int, int, IntPtr>) n_CropAndScale_IIIIII);
			return cb_cropAndScale_IIIIII;
		}

		static IntPtr n_CropAndScale_IIIIII (IntPtr jnienv, IntPtr native__this, int cropX, int cropY, int cropWidth, int cropHeight, int scaleWidth, int scaleHeight)
		{
			global::Org.Webrtc.JavaI420Buffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.JavaI420Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CropAndScale (cropX, cropY, cropWidth, cropHeight, scaleWidth, scaleHeight));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='JavaI420Buffer']/method[@name='cropAndScale' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("cropAndScale", "(IIIIII)Lorg/webrtc/VideoFrame$Buffer;", "GetCropAndScale_IIIIIIHandler")]
		public virtual unsafe global::Org.Webrtc.VideoFrame.IBuffer CropAndScale (int cropX, int cropY, int cropWidth, int cropHeight, int scaleWidth, int scaleHeight)
		{
			const string __id = "cropAndScale.(IIIIII)Lorg/webrtc/VideoFrame$Buffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (cropX);
				__args [1] = new JniArgumentValue (cropY);
				__args [2] = new JniArgumentValue (cropWidth);
				__args [3] = new JniArgumentValue (cropHeight);
				__args [4] = new JniArgumentValue (scaleWidth);
				__args [5] = new JniArgumentValue (scaleHeight);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.IBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='JavaI420Buffer']/method[@name='cropAndScaleI420' and count(parameter)=7 and parameter[1][@type='org.webrtc.VideoFrame.I420Buffer'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("cropAndScaleI420", "(Lorg/webrtc/VideoFrame$I420Buffer;IIIIII)Lorg/webrtc/VideoFrame$Buffer;", "")]
		public static unsafe global::Org.Webrtc.VideoFrame.IBuffer CropAndScaleI420 (global::Org.Webrtc.VideoFrame.II420Buffer buffer, int cropX, int cropY, int cropWidth, int cropHeight, int scaleWidth, int scaleHeight)
		{
			const string __id = "cropAndScaleI420.(Lorg/webrtc/VideoFrame$I420Buffer;IIIIII)Lorg/webrtc/VideoFrame$Buffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				__args [1] = new JniArgumentValue (cropX);
				__args [2] = new JniArgumentValue (cropY);
				__args [3] = new JniArgumentValue (cropWidth);
				__args [4] = new JniArgumentValue (cropHeight);
				__args [5] = new JniArgumentValue (scaleWidth);
				__args [6] = new JniArgumentValue (scaleHeight);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.IBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Org.Webrtc.JavaI420Buffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.JavaI420Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='JavaI420Buffer']/method[@name='release' and count(parameter)=0]"
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
			global::Org.Webrtc.JavaI420Buffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.JavaI420Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Retain ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='JavaI420Buffer']/method[@name='retain' and count(parameter)=0]"
		[Register ("retain", "()V", "GetRetainHandler")]
		public virtual unsafe void Retain ()
		{
			const string __id = "retain.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_toI420;
#pragma warning disable 0169
		static Delegate GetToI420Handler ()
		{
			if (cb_toI420 == null)
				cb_toI420 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToI420);
			return cb_toI420;
		}

		static IntPtr n_ToI420 (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.JavaI420Buffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.JavaI420Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToI420 ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='JavaI420Buffer']/method[@name='toI420' and count(parameter)=0]"
		[Register ("toI420", "()Lorg/webrtc/VideoFrame$I420Buffer;", "GetToI420Handler")]
		public virtual unsafe global::Org.Webrtc.VideoFrame.II420Buffer ToI420 ()
		{
			const string __id = "toI420.()Lorg/webrtc/VideoFrame$I420Buffer;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.II420Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='JavaI420Buffer']/method[@name='wrap' and count(parameter)=9 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.nio.ByteBuffer'] and parameter[4][@type='int'] and parameter[5][@type='java.nio.ByteBuffer'] and parameter[6][@type='int'] and parameter[7][@type='java.nio.ByteBuffer'] and parameter[8][@type='int'] and parameter[9][@type='java.lang.Runnable']]"
		[Register ("wrap", "(IILjava/nio/ByteBuffer;ILjava/nio/ByteBuffer;ILjava/nio/ByteBuffer;ILjava/lang/Runnable;)Lorg/webrtc/JavaI420Buffer;", "")]
		public static unsafe global::Org.Webrtc.JavaI420Buffer Wrap (int width, int height, global::Java.Nio.ByteBuffer dataY, int strideY, global::Java.Nio.ByteBuffer dataU, int strideU, global::Java.Nio.ByteBuffer dataV, int strideV, global::Java.Lang.IRunnable releaseCallback)
		{
			const string __id = "wrap.(IILjava/nio/ByteBuffer;ILjava/nio/ByteBuffer;ILjava/nio/ByteBuffer;ILjava/lang/Runnable;)Lorg/webrtc/JavaI420Buffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
				__args [2] = new JniArgumentValue ((dataY == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataY).Handle);
				__args [3] = new JniArgumentValue (strideY);
				__args [4] = new JniArgumentValue ((dataU == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataU).Handle);
				__args [5] = new JniArgumentValue (strideU);
				__args [6] = new JniArgumentValue ((dataV == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataV).Handle);
				__args [7] = new JniArgumentValue (strideV);
				__args [8] = new JniArgumentValue ((releaseCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) releaseCallback).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.JavaI420Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
