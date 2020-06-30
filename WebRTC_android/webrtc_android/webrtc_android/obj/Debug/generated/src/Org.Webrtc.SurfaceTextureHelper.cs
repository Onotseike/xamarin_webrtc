using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceTextureHelper']"
	[global::Android.Runtime.Register ("org/webrtc/SurfaceTextureHelper", DoNotGenerateAcw=true)]
	public partial class SurfaceTextureHelper : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='SurfaceTextureHelper.FrameRefMonitor']"
		[Register ("org/webrtc/SurfaceTextureHelper$FrameRefMonitor", "", "Org.Webrtc.SurfaceTextureHelper/IFrameRefMonitorInvoker")]
		public partial interface IFrameRefMonitor : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='SurfaceTextureHelper.FrameRefMonitor']/method[@name='onDestroyBuffer' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoFrame.TextureBuffer']]"
			[Register ("onDestroyBuffer", "(Lorg/webrtc/VideoFrame$TextureBuffer;)V", "GetOnDestroyBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_Handler:Org.Webrtc.SurfaceTextureHelper/IFrameRefMonitorInvoker, webrtc_android")]
			void OnDestroyBuffer (global::Org.Webrtc.VideoFrame.ITextureBuffer p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='SurfaceTextureHelper.FrameRefMonitor']/method[@name='onNewBuffer' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoFrame.TextureBuffer']]"
			[Register ("onNewBuffer", "(Lorg/webrtc/VideoFrame$TextureBuffer;)V", "GetOnNewBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_Handler:Org.Webrtc.SurfaceTextureHelper/IFrameRefMonitorInvoker, webrtc_android")]
			void OnNewBuffer (global::Org.Webrtc.VideoFrame.ITextureBuffer p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='SurfaceTextureHelper.FrameRefMonitor']/method[@name='onReleaseBuffer' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoFrame.TextureBuffer']]"
			[Register ("onReleaseBuffer", "(Lorg/webrtc/VideoFrame$TextureBuffer;)V", "GetOnReleaseBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_Handler:Org.Webrtc.SurfaceTextureHelper/IFrameRefMonitorInvoker, webrtc_android")]
			void OnReleaseBuffer (global::Org.Webrtc.VideoFrame.ITextureBuffer p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='SurfaceTextureHelper.FrameRefMonitor']/method[@name='onRetainBuffer' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoFrame.TextureBuffer']]"
			[Register ("onRetainBuffer", "(Lorg/webrtc/VideoFrame$TextureBuffer;)V", "GetOnRetainBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_Handler:Org.Webrtc.SurfaceTextureHelper/IFrameRefMonitorInvoker, webrtc_android")]
			void OnRetainBuffer (global::Org.Webrtc.VideoFrame.ITextureBuffer p0);

		}

		[global::Android.Runtime.Register ("org/webrtc/SurfaceTextureHelper$FrameRefMonitor", DoNotGenerateAcw=true)]
		internal partial class IFrameRefMonitorInvoker : global::Java.Lang.Object, IFrameRefMonitor {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/SurfaceTextureHelper$FrameRefMonitor", typeof (IFrameRefMonitorInvoker));

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

			public static IFrameRefMonitor GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IFrameRefMonitor> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.SurfaceTextureHelper.FrameRefMonitor"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IFrameRefMonitorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onDestroyBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_;
#pragma warning disable 0169
			static Delegate GetOnDestroyBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_Handler ()
			{
				if (cb_onDestroyBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_ == null)
					cb_onDestroyBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDestroyBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_);
				return cb_onDestroyBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_;
			}

			static void n_OnDestroyBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.SurfaceTextureHelper.IFrameRefMonitor __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceTextureHelper.IFrameRefMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.VideoFrame.ITextureBuffer p0 = (global::Org.Webrtc.VideoFrame.ITextureBuffer)global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.ITextureBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnDestroyBuffer (p0);
			}
#pragma warning restore 0169

			IntPtr id_onDestroyBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_;
			public unsafe void OnDestroyBuffer (global::Org.Webrtc.VideoFrame.ITextureBuffer p0)
			{
				if (id_onDestroyBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_ == IntPtr.Zero)
					id_onDestroyBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_ = JNIEnv.GetMethodID (class_ref, "onDestroyBuffer", "(Lorg/webrtc/VideoFrame$TextureBuffer;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDestroyBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_, __args);
			}

			static Delegate cb_onNewBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_;
#pragma warning disable 0169
			static Delegate GetOnNewBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_Handler ()
			{
				if (cb_onNewBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_ == null)
					cb_onNewBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNewBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_);
				return cb_onNewBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_;
			}

			static void n_OnNewBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.SurfaceTextureHelper.IFrameRefMonitor __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceTextureHelper.IFrameRefMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.VideoFrame.ITextureBuffer p0 = (global::Org.Webrtc.VideoFrame.ITextureBuffer)global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.ITextureBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnNewBuffer (p0);
			}
#pragma warning restore 0169

			IntPtr id_onNewBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_;
			public unsafe void OnNewBuffer (global::Org.Webrtc.VideoFrame.ITextureBuffer p0)
			{
				if (id_onNewBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_ == IntPtr.Zero)
					id_onNewBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_ = JNIEnv.GetMethodID (class_ref, "onNewBuffer", "(Lorg/webrtc/VideoFrame$TextureBuffer;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNewBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_, __args);
			}

			static Delegate cb_onReleaseBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_;
#pragma warning disable 0169
			static Delegate GetOnReleaseBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_Handler ()
			{
				if (cb_onReleaseBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_ == null)
					cb_onReleaseBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnReleaseBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_);
				return cb_onReleaseBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_;
			}

			static void n_OnReleaseBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.SurfaceTextureHelper.IFrameRefMonitor __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceTextureHelper.IFrameRefMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.VideoFrame.ITextureBuffer p0 = (global::Org.Webrtc.VideoFrame.ITextureBuffer)global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.ITextureBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnReleaseBuffer (p0);
			}
#pragma warning restore 0169

			IntPtr id_onReleaseBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_;
			public unsafe void OnReleaseBuffer (global::Org.Webrtc.VideoFrame.ITextureBuffer p0)
			{
				if (id_onReleaseBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_ == IntPtr.Zero)
					id_onReleaseBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_ = JNIEnv.GetMethodID (class_ref, "onReleaseBuffer", "(Lorg/webrtc/VideoFrame$TextureBuffer;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReleaseBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_, __args);
			}

			static Delegate cb_onRetainBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_;
#pragma warning disable 0169
			static Delegate GetOnRetainBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_Handler ()
			{
				if (cb_onRetainBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_ == null)
					cb_onRetainBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRetainBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_);
				return cb_onRetainBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_;
			}

			static void n_OnRetainBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.SurfaceTextureHelper.IFrameRefMonitor __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceTextureHelper.IFrameRefMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.VideoFrame.ITextureBuffer p0 = (global::Org.Webrtc.VideoFrame.ITextureBuffer)global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.ITextureBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnRetainBuffer (p0);
			}
#pragma warning restore 0169

			IntPtr id_onRetainBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_;
			public unsafe void OnRetainBuffer (global::Org.Webrtc.VideoFrame.ITextureBuffer p0)
			{
				if (id_onRetainBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_ == IntPtr.Zero)
					id_onRetainBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_ = JNIEnv.GetMethodID (class_ref, "onRetainBuffer", "(Lorg/webrtc/VideoFrame$TextureBuffer;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRetainBuffer_Lorg_webrtc_VideoFrame_TextureBuffer_, __args);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/SurfaceTextureHelper", typeof (SurfaceTextureHelper));
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

		protected SurfaceTextureHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getHandler;
#pragma warning disable 0169
		static Delegate GetGetHandlerHandler ()
		{
			if (cb_getHandler == null)
				cb_getHandler = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHandler);
			return cb_getHandler;
		}

		static IntPtr n_GetHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.SurfaceTextureHelper __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceTextureHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Handler);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.OS.Handler Handler {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceTextureHelper']/method[@name='getHandler' and count(parameter)=0]"
			[Register ("getHandler", "()Landroid/os/Handler;", "GetGetHandlerHandler")]
			get {
				const string __id = "getHandler.()Landroid/os/Handler;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isTextureInUse;
#pragma warning disable 0169
		static Delegate GetIsTextureInUseHandler ()
		{
			if (cb_isTextureInUse == null)
				cb_isTextureInUse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTextureInUse);
			return cb_isTextureInUse;
		}

		static bool n_IsTextureInUse (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.SurfaceTextureHelper __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceTextureHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsTextureInUse;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsTextureInUse {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceTextureHelper']/method[@name='isTextureInUse' and count(parameter)=0]"
			[Register ("isTextureInUse", "()Z", "GetIsTextureInUseHandler")]
			get {
				const string __id = "isTextureInUse.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSurfaceTexture;
#pragma warning disable 0169
		static Delegate GetGetSurfaceTextureHandler ()
		{
			if (cb_getSurfaceTexture == null)
				cb_getSurfaceTexture = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSurfaceTexture);
			return cb_getSurfaceTexture;
		}

		static IntPtr n_GetSurfaceTexture (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.SurfaceTextureHelper __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceTextureHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SurfaceTexture);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.SurfaceTexture SurfaceTexture {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceTextureHelper']/method[@name='getSurfaceTexture' and count(parameter)=0]"
			[Register ("getSurfaceTexture", "()Landroid/graphics/SurfaceTexture;", "GetGetSurfaceTextureHandler")]
			get {
				const string __id = "getSurfaceTexture.()Landroid/graphics/SurfaceTexture;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceTextureHelper']/method[@name='create' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.webrtc.EglBase.Context']]"
		[Register ("create", "(Ljava/lang/String;Lorg/webrtc/EglBase$Context;)Lorg/webrtc/SurfaceTextureHelper;", "")]
		public static unsafe global::Org.Webrtc.SurfaceTextureHelper Create (string threadName, global::Org.Webrtc.IEglBaseContext sharedContext)
		{
			const string __id = "create.(Ljava/lang/String;Lorg/webrtc/EglBase$Context;)Lorg/webrtc/SurfaceTextureHelper;";
			IntPtr native_threadName = JNIEnv.NewString (threadName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_threadName);
				__args [1] = new JniArgumentValue ((sharedContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sharedContext).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceTextureHelper> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_threadName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceTextureHelper']/method[@name='create' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.webrtc.EglBase.Context'] and parameter[3][@type='boolean']]"
		[Register ("create", "(Ljava/lang/String;Lorg/webrtc/EglBase$Context;Z)Lorg/webrtc/SurfaceTextureHelper;", "")]
		public static unsafe global::Org.Webrtc.SurfaceTextureHelper Create (string threadName, global::Org.Webrtc.IEglBaseContext sharedContext, bool alignTimestamps)
		{
			const string __id = "create.(Ljava/lang/String;Lorg/webrtc/EglBase$Context;Z)Lorg/webrtc/SurfaceTextureHelper;";
			IntPtr native_threadName = JNIEnv.NewString (threadName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_threadName);
				__args [1] = new JniArgumentValue ((sharedContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sharedContext).Handle);
				__args [2] = new JniArgumentValue (alignTimestamps);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceTextureHelper> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_threadName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceTextureHelper']/method[@name='create' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.webrtc.EglBase.Context'] and parameter[3][@type='boolean'] and parameter[4][@type='org.webrtc.YuvConverter']]"
		[Register ("create", "(Ljava/lang/String;Lorg/webrtc/EglBase$Context;ZLorg/webrtc/YuvConverter;)Lorg/webrtc/SurfaceTextureHelper;", "")]
		public static unsafe global::Org.Webrtc.SurfaceTextureHelper Create (string threadName, global::Org.Webrtc.IEglBaseContext sharedContext, bool alignTimestamps, global::Org.Webrtc.YuvConverter yuvConverter)
		{
			const string __id = "create.(Ljava/lang/String;Lorg/webrtc/EglBase$Context;ZLorg/webrtc/YuvConverter;)Lorg/webrtc/SurfaceTextureHelper;";
			IntPtr native_threadName = JNIEnv.NewString (threadName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_threadName);
				__args [1] = new JniArgumentValue ((sharedContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sharedContext).Handle);
				__args [2] = new JniArgumentValue (alignTimestamps);
				__args [3] = new JniArgumentValue ((yuvConverter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) yuvConverter).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceTextureHelper> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_threadName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceTextureHelper']/method[@name='create' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.webrtc.EglBase.Context'] and parameter[3][@type='boolean'] and parameter[4][@type='org.webrtc.YuvConverter'] and parameter[5][@type='org.webrtc.SurfaceTextureHelper.FrameRefMonitor']]"
		[Register ("create", "(Ljava/lang/String;Lorg/webrtc/EglBase$Context;ZLorg/webrtc/YuvConverter;Lorg/webrtc/SurfaceTextureHelper$FrameRefMonitor;)Lorg/webrtc/SurfaceTextureHelper;", "")]
		public static unsafe global::Org.Webrtc.SurfaceTextureHelper Create (string threadName, global::Org.Webrtc.IEglBaseContext sharedContext, bool alignTimestamps, global::Org.Webrtc.YuvConverter yuvConverter, global::Org.Webrtc.SurfaceTextureHelper.IFrameRefMonitor frameRefMonitor)
		{
			const string __id = "create.(Ljava/lang/String;Lorg/webrtc/EglBase$Context;ZLorg/webrtc/YuvConverter;Lorg/webrtc/SurfaceTextureHelper$FrameRefMonitor;)Lorg/webrtc/SurfaceTextureHelper;";
			IntPtr native_threadName = JNIEnv.NewString (threadName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_threadName);
				__args [1] = new JniArgumentValue ((sharedContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sharedContext).Handle);
				__args [2] = new JniArgumentValue (alignTimestamps);
				__args [3] = new JniArgumentValue ((yuvConverter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) yuvConverter).Handle);
				__args [4] = new JniArgumentValue ((frameRefMonitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) frameRefMonitor).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceTextureHelper> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_threadName);
			}
		}

		static Delegate cb_dispose;
#pragma warning disable 0169
		static Delegate GetDisposeHandler ()
		{
			if (cb_dispose == null)
				cb_dispose = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Dispose);
			return cb_dispose;
		}

		static void n_Dispose (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.SurfaceTextureHelper __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceTextureHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceTextureHelper']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public virtual unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setFrameRotation_I;
#pragma warning disable 0169
		static Delegate GetSetFrameRotation_IHandler ()
		{
			if (cb_setFrameRotation_I == null)
				cb_setFrameRotation_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFrameRotation_I);
			return cb_setFrameRotation_I;
		}

		static void n_SetFrameRotation_I (IntPtr jnienv, IntPtr native__this, int rotation)
		{
			global::Org.Webrtc.SurfaceTextureHelper __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceTextureHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFrameRotation (rotation);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceTextureHelper']/method[@name='setFrameRotation' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setFrameRotation", "(I)V", "GetSetFrameRotation_IHandler")]
		public virtual unsafe void SetFrameRotation (int rotation)
		{
			const string __id = "setFrameRotation.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (rotation);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTextureSize_II;
#pragma warning disable 0169
		static Delegate GetSetTextureSize_IIHandler ()
		{
			if (cb_setTextureSize_II == null)
				cb_setTextureSize_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetTextureSize_II);
			return cb_setTextureSize_II;
		}

		static void n_SetTextureSize_II (IntPtr jnienv, IntPtr native__this, int textureWidth, int textureHeight)
		{
			global::Org.Webrtc.SurfaceTextureHelper __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceTextureHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTextureSize (textureWidth, textureHeight);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceTextureHelper']/method[@name='setTextureSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setTextureSize", "(II)V", "GetSetTextureSize_IIHandler")]
		public virtual unsafe void SetTextureSize (int textureWidth, int textureHeight)
		{
			const string __id = "setTextureSize.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (textureWidth);
				__args [1] = new JniArgumentValue (textureHeight);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startListening_Lorg_webrtc_VideoSink_;
#pragma warning disable 0169
		static Delegate GetStartListening_Lorg_webrtc_VideoSink_Handler ()
		{
			if (cb_startListening_Lorg_webrtc_VideoSink_ == null)
				cb_startListening_Lorg_webrtc_VideoSink_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartListening_Lorg_webrtc_VideoSink_);
			return cb_startListening_Lorg_webrtc_VideoSink_;
		}

		static void n_StartListening_Lorg_webrtc_VideoSink_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Org.Webrtc.SurfaceTextureHelper __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceTextureHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.IVideoSink listener = (global::Org.Webrtc.IVideoSink)global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoSink> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.StartListening (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceTextureHelper']/method[@name='startListening' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoSink']]"
		[Register ("startListening", "(Lorg/webrtc/VideoSink;)V", "GetStartListening_Lorg_webrtc_VideoSink_Handler")]
		public virtual unsafe void StartListening (global::Org.Webrtc.IVideoSink listener)
		{
			const string __id = "startListening.(Lorg/webrtc/VideoSink;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_stopListening;
#pragma warning disable 0169
		static Delegate GetStopListeningHandler ()
		{
			if (cb_stopListening == null)
				cb_stopListening = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopListening);
			return cb_stopListening;
		}

		static void n_StopListening (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.SurfaceTextureHelper __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceTextureHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopListening ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceTextureHelper']/method[@name='stopListening' and count(parameter)=0]"
		[Register ("stopListening", "()V", "GetStopListeningHandler")]
		public virtual unsafe void StopListening ()
		{
			const string __id = "stopListening.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_textureToYuv_Lorg_webrtc_VideoFrame_TextureBuffer_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetTextureToYuv_Lorg_webrtc_VideoFrame_TextureBuffer_Handler ()
		{
			if (cb_textureToYuv_Lorg_webrtc_VideoFrame_TextureBuffer_ == null)
				cb_textureToYuv_Lorg_webrtc_VideoFrame_TextureBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_TextureToYuv_Lorg_webrtc_VideoFrame_TextureBuffer_);
			return cb_textureToYuv_Lorg_webrtc_VideoFrame_TextureBuffer_;
		}

		[Obsolete]
		static IntPtr n_TextureToYuv_Lorg_webrtc_VideoFrame_TextureBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_textureBuffer)
		{
			global::Org.Webrtc.SurfaceTextureHelper __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceTextureHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.VideoFrame.ITextureBuffer textureBuffer = (global::Org.Webrtc.VideoFrame.ITextureBuffer)global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.ITextureBuffer> (native_textureBuffer, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TextureToYuv (textureBuffer));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceTextureHelper']/method[@name='textureToYuv' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoFrame.TextureBuffer']]"
		[Obsolete (@"deprecated")]
		[Register ("textureToYuv", "(Lorg/webrtc/VideoFrame$TextureBuffer;)Lorg/webrtc/VideoFrame$I420Buffer;", "GetTextureToYuv_Lorg_webrtc_VideoFrame_TextureBuffer_Handler")]
		public virtual unsafe global::Org.Webrtc.VideoFrame.II420Buffer TextureToYuv (global::Org.Webrtc.VideoFrame.ITextureBuffer textureBuffer)
		{
			const string __id = "textureToYuv.(Lorg/webrtc/VideoFrame$TextureBuffer;)Lorg/webrtc/VideoFrame$I420Buffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((textureBuffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) textureBuffer).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.II420Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
