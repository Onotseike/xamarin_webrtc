using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoFrameDrawer']"
	[global::Android.Runtime.Register ("org/webrtc/VideoFrameDrawer", DoNotGenerateAcw=true)]
	public partial class VideoFrameDrawer : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoFrameDrawer']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "VideoFrameDrawer";
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoFrameDrawer", typeof (VideoFrameDrawer));
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

		protected VideoFrameDrawer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoFrameDrawer']/constructor[@name='VideoFrameDrawer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VideoFrameDrawer ()
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

		static Delegate cb_drawFrame_Lorg_webrtc_VideoFrame_Lorg_webrtc_RendererCommon_GlDrawer_;
#pragma warning disable 0169
		static Delegate GetDrawFrame_Lorg_webrtc_VideoFrame_Lorg_webrtc_RendererCommon_GlDrawer_Handler ()
		{
			if (cb_drawFrame_Lorg_webrtc_VideoFrame_Lorg_webrtc_RendererCommon_GlDrawer_ == null)
				cb_drawFrame_Lorg_webrtc_VideoFrame_Lorg_webrtc_RendererCommon_GlDrawer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DrawFrame_Lorg_webrtc_VideoFrame_Lorg_webrtc_RendererCommon_GlDrawer_);
			return cb_drawFrame_Lorg_webrtc_VideoFrame_Lorg_webrtc_RendererCommon_GlDrawer_;
		}

		static void n_DrawFrame_Lorg_webrtc_VideoFrame_Lorg_webrtc_RendererCommon_GlDrawer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_frame, IntPtr native_drawer)
		{
			global::Org.Webrtc.VideoFrameDrawer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrameDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.VideoFrame frame = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame> (native_frame, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.RendererCommon.IGlDrawer drawer = (global::Org.Webrtc.RendererCommon.IGlDrawer)global::Java.Lang.Object.GetObject<global::Org.Webrtc.RendererCommon.IGlDrawer> (native_drawer, JniHandleOwnership.DoNotTransfer);
			__this.DrawFrame (frame, drawer);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoFrameDrawer']/method[@name='drawFrame' and count(parameter)=2 and parameter[1][@type='org.webrtc.VideoFrame'] and parameter[2][@type='org.webrtc.RendererCommon.GlDrawer']]"
		[Register ("drawFrame", "(Lorg/webrtc/VideoFrame;Lorg/webrtc/RendererCommon$GlDrawer;)V", "GetDrawFrame_Lorg_webrtc_VideoFrame_Lorg_webrtc_RendererCommon_GlDrawer_Handler")]
		public virtual unsafe void DrawFrame (global::Org.Webrtc.VideoFrame frame, global::Org.Webrtc.RendererCommon.IGlDrawer drawer)
		{
			const string __id = "drawFrame.(Lorg/webrtc/VideoFrame;Lorg/webrtc/RendererCommon$GlDrawer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((frame == null) ? IntPtr.Zero : ((global::Java.Lang.Object) frame).Handle);
				__args [1] = new JniArgumentValue ((drawer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawer).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_drawFrame_Lorg_webrtc_VideoFrame_Lorg_webrtc_RendererCommon_GlDrawer_Landroid_graphics_Matrix_;
#pragma warning disable 0169
		static Delegate GetDrawFrame_Lorg_webrtc_VideoFrame_Lorg_webrtc_RendererCommon_GlDrawer_Landroid_graphics_Matrix_Handler ()
		{
			if (cb_drawFrame_Lorg_webrtc_VideoFrame_Lorg_webrtc_RendererCommon_GlDrawer_Landroid_graphics_Matrix_ == null)
				cb_drawFrame_Lorg_webrtc_VideoFrame_Lorg_webrtc_RendererCommon_GlDrawer_Landroid_graphics_Matrix_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DrawFrame_Lorg_webrtc_VideoFrame_Lorg_webrtc_RendererCommon_GlDrawer_Landroid_graphics_Matrix_);
			return cb_drawFrame_Lorg_webrtc_VideoFrame_Lorg_webrtc_RendererCommon_GlDrawer_Landroid_graphics_Matrix_;
		}

		static void n_DrawFrame_Lorg_webrtc_VideoFrame_Lorg_webrtc_RendererCommon_GlDrawer_Landroid_graphics_Matrix_ (IntPtr jnienv, IntPtr native__this, IntPtr native_frame, IntPtr native_drawer, IntPtr native_additionalRenderMatrix)
		{
			global::Org.Webrtc.VideoFrameDrawer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrameDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.VideoFrame frame = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame> (native_frame, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.RendererCommon.IGlDrawer drawer = (global::Org.Webrtc.RendererCommon.IGlDrawer)global::Java.Lang.Object.GetObject<global::Org.Webrtc.RendererCommon.IGlDrawer> (native_drawer, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Matrix additionalRenderMatrix = global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (native_additionalRenderMatrix, JniHandleOwnership.DoNotTransfer);
			__this.DrawFrame (frame, drawer, additionalRenderMatrix);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoFrameDrawer']/method[@name='drawFrame' and count(parameter)=3 and parameter[1][@type='org.webrtc.VideoFrame'] and parameter[2][@type='org.webrtc.RendererCommon.GlDrawer'] and parameter[3][@type='android.graphics.Matrix']]"
		[Register ("drawFrame", "(Lorg/webrtc/VideoFrame;Lorg/webrtc/RendererCommon$GlDrawer;Landroid/graphics/Matrix;)V", "GetDrawFrame_Lorg_webrtc_VideoFrame_Lorg_webrtc_RendererCommon_GlDrawer_Landroid_graphics_Matrix_Handler")]
		public virtual unsafe void DrawFrame (global::Org.Webrtc.VideoFrame frame, global::Org.Webrtc.RendererCommon.IGlDrawer drawer, global::Android.Graphics.Matrix additionalRenderMatrix)
		{
			const string __id = "drawFrame.(Lorg/webrtc/VideoFrame;Lorg/webrtc/RendererCommon$GlDrawer;Landroid/graphics/Matrix;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((frame == null) ? IntPtr.Zero : ((global::Java.Lang.Object) frame).Handle);
				__args [1] = new JniArgumentValue ((drawer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawer).Handle);
				__args [2] = new JniArgumentValue ((additionalRenderMatrix == null) ? IntPtr.Zero : ((global::Java.Lang.Object) additionalRenderMatrix).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_drawFrame_Lorg_webrtc_VideoFrame_Lorg_webrtc_RendererCommon_GlDrawer_Landroid_graphics_Matrix_IIII;
#pragma warning disable 0169
		static Delegate GetDrawFrame_Lorg_webrtc_VideoFrame_Lorg_webrtc_RendererCommon_GlDrawer_Landroid_graphics_Matrix_IIIIHandler ()
		{
			if (cb_drawFrame_Lorg_webrtc_VideoFrame_Lorg_webrtc_RendererCommon_GlDrawer_Landroid_graphics_Matrix_IIII == null)
				cb_drawFrame_Lorg_webrtc_VideoFrame_Lorg_webrtc_RendererCommon_GlDrawer_Landroid_graphics_Matrix_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, int>) n_DrawFrame_Lorg_webrtc_VideoFrame_Lorg_webrtc_RendererCommon_GlDrawer_Landroid_graphics_Matrix_IIII);
			return cb_drawFrame_Lorg_webrtc_VideoFrame_Lorg_webrtc_RendererCommon_GlDrawer_Landroid_graphics_Matrix_IIII;
		}

		static void n_DrawFrame_Lorg_webrtc_VideoFrame_Lorg_webrtc_RendererCommon_GlDrawer_Landroid_graphics_Matrix_IIII (IntPtr jnienv, IntPtr native__this, IntPtr native_frame, IntPtr native_drawer, IntPtr native_additionalRenderMatrix, int viewportX, int viewportY, int viewportWidth, int viewportHeight)
		{
			global::Org.Webrtc.VideoFrameDrawer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrameDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.VideoFrame frame = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame> (native_frame, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.RendererCommon.IGlDrawer drawer = (global::Org.Webrtc.RendererCommon.IGlDrawer)global::Java.Lang.Object.GetObject<global::Org.Webrtc.RendererCommon.IGlDrawer> (native_drawer, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Matrix additionalRenderMatrix = global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (native_additionalRenderMatrix, JniHandleOwnership.DoNotTransfer);
			__this.DrawFrame (frame, drawer, additionalRenderMatrix, viewportX, viewportY, viewportWidth, viewportHeight);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoFrameDrawer']/method[@name='drawFrame' and count(parameter)=7 and parameter[1][@type='org.webrtc.VideoFrame'] and parameter[2][@type='org.webrtc.RendererCommon.GlDrawer'] and parameter[3][@type='android.graphics.Matrix'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("drawFrame", "(Lorg/webrtc/VideoFrame;Lorg/webrtc/RendererCommon$GlDrawer;Landroid/graphics/Matrix;IIII)V", "GetDrawFrame_Lorg_webrtc_VideoFrame_Lorg_webrtc_RendererCommon_GlDrawer_Landroid_graphics_Matrix_IIIIHandler")]
		public virtual unsafe void DrawFrame (global::Org.Webrtc.VideoFrame frame, global::Org.Webrtc.RendererCommon.IGlDrawer drawer, global::Android.Graphics.Matrix additionalRenderMatrix, int viewportX, int viewportY, int viewportWidth, int viewportHeight)
		{
			const string __id = "drawFrame.(Lorg/webrtc/VideoFrame;Lorg/webrtc/RendererCommon$GlDrawer;Landroid/graphics/Matrix;IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((frame == null) ? IntPtr.Zero : ((global::Java.Lang.Object) frame).Handle);
				__args [1] = new JniArgumentValue ((drawer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawer).Handle);
				__args [2] = new JniArgumentValue ((additionalRenderMatrix == null) ? IntPtr.Zero : ((global::Java.Lang.Object) additionalRenderMatrix).Handle);
				__args [3] = new JniArgumentValue (viewportX);
				__args [4] = new JniArgumentValue (viewportY);
				__args [5] = new JniArgumentValue (viewportWidth);
				__args [6] = new JniArgumentValue (viewportHeight);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoFrameDrawer']/method[@name='drawTexture' and count(parameter)=9 and parameter[1][@type='org.webrtc.RendererCommon.GlDrawer'] and parameter[2][@type='org.webrtc.VideoFrame.TextureBuffer'] and parameter[3][@type='android.graphics.Matrix'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int']]"
		[Register ("drawTexture", "(Lorg/webrtc/RendererCommon$GlDrawer;Lorg/webrtc/VideoFrame$TextureBuffer;Landroid/graphics/Matrix;IIIIII)V", "")]
		public static unsafe void DrawTexture (global::Org.Webrtc.RendererCommon.IGlDrawer drawer, global::Org.Webrtc.VideoFrame.ITextureBuffer buffer, global::Android.Graphics.Matrix renderMatrix, int frameWidth, int frameHeight, int viewportX, int viewportY, int viewportWidth, int viewportHeight)
		{
			const string __id = "drawTexture.(Lorg/webrtc/RendererCommon$GlDrawer;Lorg/webrtc/VideoFrame$TextureBuffer;Landroid/graphics/Matrix;IIIIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue ((drawer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawer).Handle);
				__args [1] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				__args [2] = new JniArgumentValue ((renderMatrix == null) ? IntPtr.Zero : ((global::Java.Lang.Object) renderMatrix).Handle);
				__args [3] = new JniArgumentValue (frameWidth);
				__args [4] = new JniArgumentValue (frameHeight);
				__args [5] = new JniArgumentValue (viewportX);
				__args [6] = new JniArgumentValue (viewportY);
				__args [7] = new JniArgumentValue (viewportWidth);
				__args [8] = new JniArgumentValue (viewportHeight);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		static Delegate cb_prepareBufferForViewportSize_Lorg_webrtc_VideoFrame_Buffer_II;
#pragma warning disable 0169
		static Delegate GetPrepareBufferForViewportSize_Lorg_webrtc_VideoFrame_Buffer_IIHandler ()
		{
			if (cb_prepareBufferForViewportSize_Lorg_webrtc_VideoFrame_Buffer_II == null)
				cb_prepareBufferForViewportSize_Lorg_webrtc_VideoFrame_Buffer_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_PrepareBufferForViewportSize_Lorg_webrtc_VideoFrame_Buffer_II);
			return cb_prepareBufferForViewportSize_Lorg_webrtc_VideoFrame_Buffer_II;
		}

		static IntPtr n_PrepareBufferForViewportSize_Lorg_webrtc_VideoFrame_Buffer_II (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, int width, int height)
		{
			global::Org.Webrtc.VideoFrameDrawer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrameDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.VideoFrame.IBuffer buffer = (global::Org.Webrtc.VideoFrame.IBuffer)global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.IBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PrepareBufferForViewportSize (buffer, width, height));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoFrameDrawer']/method[@name='prepareBufferForViewportSize' and count(parameter)=3 and parameter[1][@type='org.webrtc.VideoFrame.Buffer'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("prepareBufferForViewportSize", "(Lorg/webrtc/VideoFrame$Buffer;II)Lorg/webrtc/VideoFrame$Buffer;", "GetPrepareBufferForViewportSize_Lorg_webrtc_VideoFrame_Buffer_IIHandler")]
		public virtual unsafe global::Org.Webrtc.VideoFrame.IBuffer PrepareBufferForViewportSize (global::Org.Webrtc.VideoFrame.IBuffer buffer, int width, int height)
		{
			const string __id = "prepareBufferForViewportSize.(Lorg/webrtc/VideoFrame$Buffer;II)Lorg/webrtc/VideoFrame$Buffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				__args [1] = new JniArgumentValue (width);
				__args [2] = new JniArgumentValue (height);
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
			global::Org.Webrtc.VideoFrameDrawer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrameDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoFrameDrawer']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
