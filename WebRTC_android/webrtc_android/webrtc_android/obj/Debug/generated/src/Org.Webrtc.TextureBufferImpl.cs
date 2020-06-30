using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='TextureBufferImpl']"
	[global::Android.Runtime.Register ("org/webrtc/TextureBufferImpl", DoNotGenerateAcw=true)]
	public partial class TextureBufferImpl : global::Java.Lang.Object, global::Org.Webrtc.VideoFrame.ITextureBuffer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/TextureBufferImpl", typeof (TextureBufferImpl));
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

		protected TextureBufferImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='TextureBufferImpl']/constructor[@name='TextureBufferImpl' and count(parameter)=8 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='org.webrtc.VideoFrame.TextureBuffer.Type'] and parameter[4][@type='int'] and parameter[5][@type='android.graphics.Matrix'] and parameter[6][@type='android.os.Handler'] and parameter[7][@type='org.webrtc.YuvConverter'] and parameter[8][@type='java.lang.Runnable']]"
		[Register (".ctor", "(IILorg/webrtc/VideoFrame$TextureBuffer$Type;ILandroid/graphics/Matrix;Landroid/os/Handler;Lorg/webrtc/YuvConverter;Ljava/lang/Runnable;)V", "")]
		public unsafe TextureBufferImpl (int width, int height, global::Org.Webrtc.VideoFrame.TextureBufferType type, int id, global::Android.Graphics.Matrix transformMatrix, global::Android.OS.Handler toI420Handler, global::Org.Webrtc.YuvConverter yuvConverter, global::Java.Lang.IRunnable releaseCallback)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IILorg/webrtc/VideoFrame$TextureBuffer$Type;ILandroid/graphics/Matrix;Landroid/os/Handler;Lorg/webrtc/YuvConverter;Ljava/lang/Runnable;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
				__args [2] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				__args [3] = new JniArgumentValue (id);
				__args [4] = new JniArgumentValue ((transformMatrix == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transformMatrix).Handle);
				__args [5] = new JniArgumentValue ((toI420Handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) toI420Handler).Handle);
				__args [6] = new JniArgumentValue ((yuvConverter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) yuvConverter).Handle);
				__args [7] = new JniArgumentValue ((releaseCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) releaseCallback).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
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
			global::Org.Webrtc.TextureBufferImpl __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.TextureBufferImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		public virtual unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='TextureBufferImpl']/method[@name='getHeight' and count(parameter)=0]"
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

		static Delegate cb_getTextureId;
#pragma warning disable 0169
		static Delegate GetGetTextureIdHandler ()
		{
			if (cb_getTextureId == null)
				cb_getTextureId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTextureId);
			return cb_getTextureId;
		}

		static int n_GetTextureId (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.TextureBufferImpl __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.TextureBufferImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TextureId;
		}
#pragma warning restore 0169

		public virtual unsafe int TextureId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='TextureBufferImpl']/method[@name='getTextureId' and count(parameter)=0]"
			[Register ("getTextureId", "()I", "GetGetTextureIdHandler")]
			get {
				const string __id = "getTextureId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getToI420Handler;
#pragma warning disable 0169
		static Delegate GetGetToI420HandlerHandler ()
		{
			if (cb_getToI420Handler == null)
				cb_getToI420Handler = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetToI420Handler);
			return cb_getToI420Handler;
		}

		static IntPtr n_GetToI420Handler (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.TextureBufferImpl __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.TextureBufferImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToI420Handler);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.OS.Handler ToI420Handler {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='TextureBufferImpl']/method[@name='getToI420Handler' and count(parameter)=0]"
			[Register ("getToI420Handler", "()Landroid/os/Handler;", "GetGetToI420HandlerHandler")]
			get {
				const string __id = "getToI420Handler.()Landroid/os/Handler;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTransformMatrix;
#pragma warning disable 0169
		static Delegate GetGetTransformMatrixHandler ()
		{
			if (cb_getTransformMatrix == null)
				cb_getTransformMatrix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransformMatrix);
			return cb_getTransformMatrix;
		}

		static IntPtr n_GetTransformMatrix (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.TextureBufferImpl __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.TextureBufferImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TransformMatrix);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Matrix TransformMatrix {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='TextureBufferImpl']/method[@name='getTransformMatrix' and count(parameter)=0]"
			[Register ("getTransformMatrix", "()Landroid/graphics/Matrix;", "GetGetTransformMatrixHandler")]
			get {
				const string __id = "getTransformMatrix.()Landroid/graphics/Matrix;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.TextureBufferImpl __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.TextureBufferImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Webrtc.VideoFrame.TextureBufferType Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='TextureBufferImpl']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Lorg/webrtc/VideoFrame$TextureBuffer$Type;", "GetGetTypeHandler")]
			get {
				const string __id = "getType.()Lorg/webrtc/VideoFrame$TextureBuffer$Type;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.TextureBufferType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUnscaledHeight;
#pragma warning disable 0169
		static Delegate GetGetUnscaledHeightHandler ()
		{
			if (cb_getUnscaledHeight == null)
				cb_getUnscaledHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUnscaledHeight);
			return cb_getUnscaledHeight;
		}

		static int n_GetUnscaledHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.TextureBufferImpl __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.TextureBufferImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnscaledHeight;
		}
#pragma warning restore 0169

		public virtual unsafe int UnscaledHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='TextureBufferImpl']/method[@name='getUnscaledHeight' and count(parameter)=0]"
			[Register ("getUnscaledHeight", "()I", "GetGetUnscaledHeightHandler")]
			get {
				const string __id = "getUnscaledHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getUnscaledWidth;
#pragma warning disable 0169
		static Delegate GetGetUnscaledWidthHandler ()
		{
			if (cb_getUnscaledWidth == null)
				cb_getUnscaledWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUnscaledWidth);
			return cb_getUnscaledWidth;
		}

		static int n_GetUnscaledWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.TextureBufferImpl __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.TextureBufferImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnscaledWidth;
		}
#pragma warning restore 0169

		public virtual unsafe int UnscaledWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='TextureBufferImpl']/method[@name='getUnscaledWidth' and count(parameter)=0]"
			[Register ("getUnscaledWidth", "()I", "GetGetUnscaledWidthHandler")]
			get {
				const string __id = "getUnscaledWidth.()I";
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
			global::Org.Webrtc.TextureBufferImpl __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.TextureBufferImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		public virtual unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='TextureBufferImpl']/method[@name='getWidth' and count(parameter)=0]"
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

		static Delegate cb_getYuvConverter;
#pragma warning disable 0169
		static Delegate GetGetYuvConverterHandler ()
		{
			if (cb_getYuvConverter == null)
				cb_getYuvConverter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetYuvConverter);
			return cb_getYuvConverter;
		}

		static IntPtr n_GetYuvConverter (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.TextureBufferImpl __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.TextureBufferImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.YuvConverter);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Webrtc.YuvConverter YuvConverter {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='TextureBufferImpl']/method[@name='getYuvConverter' and count(parameter)=0]"
			[Register ("getYuvConverter", "()Lorg/webrtc/YuvConverter;", "GetGetYuvConverterHandler")]
			get {
				const string __id = "getYuvConverter.()Lorg/webrtc/YuvConverter;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.YuvConverter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_applyTransformMatrix_Landroid_graphics_Matrix_II;
#pragma warning disable 0169
		static Delegate GetApplyTransformMatrix_Landroid_graphics_Matrix_IIHandler ()
		{
			if (cb_applyTransformMatrix_Landroid_graphics_Matrix_II == null)
				cb_applyTransformMatrix_Landroid_graphics_Matrix_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_ApplyTransformMatrix_Landroid_graphics_Matrix_II);
			return cb_applyTransformMatrix_Landroid_graphics_Matrix_II;
		}

		static IntPtr n_ApplyTransformMatrix_Landroid_graphics_Matrix_II (IntPtr jnienv, IntPtr native__this, IntPtr native_transformMatrix, int newWidth, int newHeight)
		{
			global::Org.Webrtc.TextureBufferImpl __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.TextureBufferImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Matrix transformMatrix = global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (native_transformMatrix, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ApplyTransformMatrix (transformMatrix, newWidth, newHeight));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='TextureBufferImpl']/method[@name='applyTransformMatrix' and count(parameter)=3 and parameter[1][@type='android.graphics.Matrix'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("applyTransformMatrix", "(Landroid/graphics/Matrix;II)Lorg/webrtc/TextureBufferImpl;", "GetApplyTransformMatrix_Landroid_graphics_Matrix_IIHandler")]
		public virtual unsafe global::Org.Webrtc.TextureBufferImpl ApplyTransformMatrix (global::Android.Graphics.Matrix transformMatrix, int newWidth, int newHeight)
		{
			const string __id = "applyTransformMatrix.(Landroid/graphics/Matrix;II)Lorg/webrtc/TextureBufferImpl;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((transformMatrix == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transformMatrix).Handle);
				__args [1] = new JniArgumentValue (newWidth);
				__args [2] = new JniArgumentValue (newHeight);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.TextureBufferImpl> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Org.Webrtc.TextureBufferImpl __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.TextureBufferImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CropAndScale (cropX, cropY, cropWidth, cropHeight, scaleWidth, scaleHeight));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='TextureBufferImpl']/method[@name='cropAndScale' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
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
			global::Org.Webrtc.TextureBufferImpl __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.TextureBufferImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='TextureBufferImpl']/method[@name='release' and count(parameter)=0]"
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
			global::Org.Webrtc.TextureBufferImpl __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.TextureBufferImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Retain ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='TextureBufferImpl']/method[@name='retain' and count(parameter)=0]"
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
			global::Org.Webrtc.TextureBufferImpl __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.TextureBufferImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToI420 ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='TextureBufferImpl']/method[@name='toI420' and count(parameter)=0]"
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

	}
}
