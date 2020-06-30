using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceViewRenderer']"
	[global::Android.Runtime.Register ("org/webrtc/SurfaceViewRenderer", DoNotGenerateAcw=true)]
	public partial class SurfaceViewRenderer : global::Android.Views.SurfaceView, global::Android.Views.ISurfaceHolderCallback, global::Org.Webrtc.RendererCommon.IRendererEvents, global::Org.Webrtc.IVideoSink {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/SurfaceViewRenderer", typeof (SurfaceViewRenderer));
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

		protected SurfaceViewRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceViewRenderer']/constructor[@name='SurfaceViewRenderer' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe SurfaceViewRenderer (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceViewRenderer']/constructor[@name='SurfaceViewRenderer' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe SurfaceViewRenderer (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addFrameListener_Lorg_webrtc_EglRenderer_FrameListener_F;
#pragma warning disable 0169
		static Delegate GetAddFrameListener_Lorg_webrtc_EglRenderer_FrameListener_FHandler ()
		{
			if (cb_addFrameListener_Lorg_webrtc_EglRenderer_FrameListener_F == null)
				cb_addFrameListener_Lorg_webrtc_EglRenderer_FrameListener_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float>) n_AddFrameListener_Lorg_webrtc_EglRenderer_FrameListener_F);
			return cb_addFrameListener_Lorg_webrtc_EglRenderer_FrameListener_F;
		}

		static void n_AddFrameListener_Lorg_webrtc_EglRenderer_FrameListener_F (IntPtr jnienv, IntPtr native__this, IntPtr native_listener, float scale)
		{
			global::Org.Webrtc.SurfaceViewRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceViewRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.EglRenderer.IFrameListener listener = (global::Org.Webrtc.EglRenderer.IFrameListener)global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglRenderer.IFrameListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.AddFrameListener (listener, scale);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceViewRenderer']/method[@name='addFrameListener' and count(parameter)=2 and parameter[1][@type='org.webrtc.EglRenderer.FrameListener'] and parameter[2][@type='float']]"
		[Register ("addFrameListener", "(Lorg/webrtc/EglRenderer$FrameListener;F)V", "GetAddFrameListener_Lorg_webrtc_EglRenderer_FrameListener_FHandler")]
		public virtual unsafe void AddFrameListener (global::Org.Webrtc.EglRenderer.IFrameListener listener, float scale)
		{
			const string __id = "addFrameListener.(Lorg/webrtc/EglRenderer$FrameListener;F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [1] = new JniArgumentValue (scale);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addFrameListener_Lorg_webrtc_EglRenderer_FrameListener_FLorg_webrtc_RendererCommon_GlDrawer_;
#pragma warning disable 0169
		static Delegate GetAddFrameListener_Lorg_webrtc_EglRenderer_FrameListener_FLorg_webrtc_RendererCommon_GlDrawer_Handler ()
		{
			if (cb_addFrameListener_Lorg_webrtc_EglRenderer_FrameListener_FLorg_webrtc_RendererCommon_GlDrawer_ == null)
				cb_addFrameListener_Lorg_webrtc_EglRenderer_FrameListener_FLorg_webrtc_RendererCommon_GlDrawer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, IntPtr>) n_AddFrameListener_Lorg_webrtc_EglRenderer_FrameListener_FLorg_webrtc_RendererCommon_GlDrawer_);
			return cb_addFrameListener_Lorg_webrtc_EglRenderer_FrameListener_FLorg_webrtc_RendererCommon_GlDrawer_;
		}

		static void n_AddFrameListener_Lorg_webrtc_EglRenderer_FrameListener_FLorg_webrtc_RendererCommon_GlDrawer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener, float scale, IntPtr native_drawerParam)
		{
			global::Org.Webrtc.SurfaceViewRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceViewRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.EglRenderer.IFrameListener listener = (global::Org.Webrtc.EglRenderer.IFrameListener)global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglRenderer.IFrameListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.RendererCommon.IGlDrawer drawerParam = (global::Org.Webrtc.RendererCommon.IGlDrawer)global::Java.Lang.Object.GetObject<global::Org.Webrtc.RendererCommon.IGlDrawer> (native_drawerParam, JniHandleOwnership.DoNotTransfer);
			__this.AddFrameListener (listener, scale, drawerParam);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceViewRenderer']/method[@name='addFrameListener' and count(parameter)=3 and parameter[1][@type='org.webrtc.EglRenderer.FrameListener'] and parameter[2][@type='float'] and parameter[3][@type='org.webrtc.RendererCommon.GlDrawer']]"
		[Register ("addFrameListener", "(Lorg/webrtc/EglRenderer$FrameListener;FLorg/webrtc/RendererCommon$GlDrawer;)V", "GetAddFrameListener_Lorg_webrtc_EglRenderer_FrameListener_FLorg_webrtc_RendererCommon_GlDrawer_Handler")]
		public virtual unsafe void AddFrameListener (global::Org.Webrtc.EglRenderer.IFrameListener listener, float scale, global::Org.Webrtc.RendererCommon.IGlDrawer drawerParam)
		{
			const string __id = "addFrameListener.(Lorg/webrtc/EglRenderer$FrameListener;FLorg/webrtc/RendererCommon$GlDrawer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [1] = new JniArgumentValue (scale);
				__args [2] = new JniArgumentValue ((drawerParam == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawerParam).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_clearImage;
#pragma warning disable 0169
		static Delegate GetClearImageHandler ()
		{
			if (cb_clearImage == null)
				cb_clearImage = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearImage);
			return cb_clearImage;
		}

		static void n_ClearImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.SurfaceViewRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceViewRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearImage ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceViewRenderer']/method[@name='clearImage' and count(parameter)=0]"
		[Register ("clearImage", "()V", "GetClearImageHandler")]
		public virtual unsafe void ClearImage ()
		{
			const string __id = "clearImage.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_disableFpsReduction;
#pragma warning disable 0169
		static Delegate GetDisableFpsReductionHandler ()
		{
			if (cb_disableFpsReduction == null)
				cb_disableFpsReduction = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisableFpsReduction);
			return cb_disableFpsReduction;
		}

		static void n_DisableFpsReduction (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.SurfaceViewRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceViewRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableFpsReduction ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceViewRenderer']/method[@name='disableFpsReduction' and count(parameter)=0]"
		[Register ("disableFpsReduction", "()V", "GetDisableFpsReductionHandler")]
		public virtual unsafe void DisableFpsReduction ()
		{
			const string __id = "disableFpsReduction.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_init_Lorg_webrtc_EglBase_Context_Lorg_webrtc_RendererCommon_RendererEvents_;
#pragma warning disable 0169
		static Delegate GetInit_Lorg_webrtc_EglBase_Context_Lorg_webrtc_RendererCommon_RendererEvents_Handler ()
		{
			if (cb_init_Lorg_webrtc_EglBase_Context_Lorg_webrtc_RendererCommon_RendererEvents_ == null)
				cb_init_Lorg_webrtc_EglBase_Context_Lorg_webrtc_RendererCommon_RendererEvents_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Init_Lorg_webrtc_EglBase_Context_Lorg_webrtc_RendererCommon_RendererEvents_);
			return cb_init_Lorg_webrtc_EglBase_Context_Lorg_webrtc_RendererCommon_RendererEvents_;
		}

		static void n_Init_Lorg_webrtc_EglBase_Context_Lorg_webrtc_RendererCommon_RendererEvents_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sharedContext, IntPtr native_rendererEvents)
		{
			global::Org.Webrtc.SurfaceViewRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceViewRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.IEglBaseContext sharedContext = (global::Org.Webrtc.IEglBaseContext)global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBaseContext> (native_sharedContext, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.RendererCommon.IRendererEvents rendererEvents = (global::Org.Webrtc.RendererCommon.IRendererEvents)global::Java.Lang.Object.GetObject<global::Org.Webrtc.RendererCommon.IRendererEvents> (native_rendererEvents, JniHandleOwnership.DoNotTransfer);
			__this.Init (sharedContext, rendererEvents);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceViewRenderer']/method[@name='init' and count(parameter)=2 and parameter[1][@type='org.webrtc.EglBase.Context'] and parameter[2][@type='org.webrtc.RendererCommon.RendererEvents']]"
		[Register ("init", "(Lorg/webrtc/EglBase$Context;Lorg/webrtc/RendererCommon$RendererEvents;)V", "GetInit_Lorg_webrtc_EglBase_Context_Lorg_webrtc_RendererCommon_RendererEvents_Handler")]
		public virtual unsafe void Init (global::Org.Webrtc.IEglBaseContext sharedContext, global::Org.Webrtc.RendererCommon.IRendererEvents rendererEvents)
		{
			const string __id = "init.(Lorg/webrtc/EglBase$Context;Lorg/webrtc/RendererCommon$RendererEvents;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((sharedContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sharedContext).Handle);
				__args [1] = new JniArgumentValue ((rendererEvents == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rendererEvents).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_init_Lorg_webrtc_EglBase_Context_Lorg_webrtc_RendererCommon_RendererEvents_arrayILorg_webrtc_RendererCommon_GlDrawer_;
#pragma warning disable 0169
		static Delegate GetInit_Lorg_webrtc_EglBase_Context_Lorg_webrtc_RendererCommon_RendererEvents_arrayILorg_webrtc_RendererCommon_GlDrawer_Handler ()
		{
			if (cb_init_Lorg_webrtc_EglBase_Context_Lorg_webrtc_RendererCommon_RendererEvents_arrayILorg_webrtc_RendererCommon_GlDrawer_ == null)
				cb_init_Lorg_webrtc_EglBase_Context_Lorg_webrtc_RendererCommon_RendererEvents_arrayILorg_webrtc_RendererCommon_GlDrawer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Init_Lorg_webrtc_EglBase_Context_Lorg_webrtc_RendererCommon_RendererEvents_arrayILorg_webrtc_RendererCommon_GlDrawer_);
			return cb_init_Lorg_webrtc_EglBase_Context_Lorg_webrtc_RendererCommon_RendererEvents_arrayILorg_webrtc_RendererCommon_GlDrawer_;
		}

		static void n_Init_Lorg_webrtc_EglBase_Context_Lorg_webrtc_RendererCommon_RendererEvents_arrayILorg_webrtc_RendererCommon_GlDrawer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sharedContext, IntPtr native_rendererEvents, IntPtr native_configAttributes, IntPtr native_drawer)
		{
			global::Org.Webrtc.SurfaceViewRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceViewRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.IEglBaseContext sharedContext = (global::Org.Webrtc.IEglBaseContext)global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBaseContext> (native_sharedContext, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.RendererCommon.IRendererEvents rendererEvents = (global::Org.Webrtc.RendererCommon.IRendererEvents)global::Java.Lang.Object.GetObject<global::Org.Webrtc.RendererCommon.IRendererEvents> (native_rendererEvents, JniHandleOwnership.DoNotTransfer);
			int[] configAttributes = (int[]) JNIEnv.GetArray (native_configAttributes, JniHandleOwnership.DoNotTransfer, typeof (int));
			global::Org.Webrtc.RendererCommon.IGlDrawer drawer = (global::Org.Webrtc.RendererCommon.IGlDrawer)global::Java.Lang.Object.GetObject<global::Org.Webrtc.RendererCommon.IGlDrawer> (native_drawer, JniHandleOwnership.DoNotTransfer);
			__this.Init (sharedContext, rendererEvents, configAttributes, drawer);
			if (configAttributes != null)
				JNIEnv.CopyArray (configAttributes, native_configAttributes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceViewRenderer']/method[@name='init' and count(parameter)=4 and parameter[1][@type='org.webrtc.EglBase.Context'] and parameter[2][@type='org.webrtc.RendererCommon.RendererEvents'] and parameter[3][@type='int[]'] and parameter[4][@type='org.webrtc.RendererCommon.GlDrawer']]"
		[Register ("init", "(Lorg/webrtc/EglBase$Context;Lorg/webrtc/RendererCommon$RendererEvents;[ILorg/webrtc/RendererCommon$GlDrawer;)V", "GetInit_Lorg_webrtc_EglBase_Context_Lorg_webrtc_RendererCommon_RendererEvents_arrayILorg_webrtc_RendererCommon_GlDrawer_Handler")]
		public virtual unsafe void Init (global::Org.Webrtc.IEglBaseContext sharedContext, global::Org.Webrtc.RendererCommon.IRendererEvents rendererEvents, int[] configAttributes, global::Org.Webrtc.RendererCommon.IGlDrawer drawer)
		{
			const string __id = "init.(Lorg/webrtc/EglBase$Context;Lorg/webrtc/RendererCommon$RendererEvents;[ILorg/webrtc/RendererCommon$GlDrawer;)V";
			IntPtr native_configAttributes = JNIEnv.NewArray (configAttributes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((sharedContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sharedContext).Handle);
				__args [1] = new JniArgumentValue ((rendererEvents == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rendererEvents).Handle);
				__args [2] = new JniArgumentValue (native_configAttributes);
				__args [3] = new JniArgumentValue ((drawer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawer).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (configAttributes != null) {
					JNIEnv.CopyArray (native_configAttributes, configAttributes);
					JNIEnv.DeleteLocalRef (native_configAttributes);
				}
			}
		}

		static Delegate cb_onFirstFrameRendered;
#pragma warning disable 0169
		static Delegate GetOnFirstFrameRenderedHandler ()
		{
			if (cb_onFirstFrameRendered == null)
				cb_onFirstFrameRendered = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnFirstFrameRendered);
			return cb_onFirstFrameRendered;
		}

		static void n_OnFirstFrameRendered (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.SurfaceViewRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceViewRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFirstFrameRendered ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceViewRenderer']/method[@name='onFirstFrameRendered' and count(parameter)=0]"
		[Register ("onFirstFrameRendered", "()V", "GetOnFirstFrameRenderedHandler")]
		public virtual unsafe void OnFirstFrameRendered ()
		{
			const string __id = "onFirstFrameRendered.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onFrame_Lorg_webrtc_VideoFrame_;
#pragma warning disable 0169
		static Delegate GetOnFrame_Lorg_webrtc_VideoFrame_Handler ()
		{
			if (cb_onFrame_Lorg_webrtc_VideoFrame_ == null)
				cb_onFrame_Lorg_webrtc_VideoFrame_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFrame_Lorg_webrtc_VideoFrame_);
			return cb_onFrame_Lorg_webrtc_VideoFrame_;
		}

		static void n_OnFrame_Lorg_webrtc_VideoFrame_ (IntPtr jnienv, IntPtr native__this, IntPtr native_frame)
		{
			global::Org.Webrtc.SurfaceViewRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceViewRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.VideoFrame frame = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame> (native_frame, JniHandleOwnership.DoNotTransfer);
			__this.OnFrame (frame);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceViewRenderer']/method[@name='onFrame' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoFrame']]"
		[Register ("onFrame", "(Lorg/webrtc/VideoFrame;)V", "GetOnFrame_Lorg_webrtc_VideoFrame_Handler")]
		public virtual unsafe void OnFrame (global::Org.Webrtc.VideoFrame frame)
		{
			const string __id = "onFrame.(Lorg/webrtc/VideoFrame;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((frame == null) ? IntPtr.Zero : ((global::Java.Lang.Object) frame).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onFrameResolutionChanged_III;
#pragma warning disable 0169
		static Delegate GetOnFrameResolutionChanged_IIIHandler ()
		{
			if (cb_onFrameResolutionChanged_III == null)
				cb_onFrameResolutionChanged_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_OnFrameResolutionChanged_III);
			return cb_onFrameResolutionChanged_III;
		}

		static void n_OnFrameResolutionChanged_III (IntPtr jnienv, IntPtr native__this, int videoWidth, int videoHeight, int rotation)
		{
			global::Org.Webrtc.SurfaceViewRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceViewRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFrameResolutionChanged (videoWidth, videoHeight, rotation);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceViewRenderer']/method[@name='onFrameResolutionChanged' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onFrameResolutionChanged", "(III)V", "GetOnFrameResolutionChanged_IIIHandler")]
		public virtual unsafe void OnFrameResolutionChanged (int videoWidth, int videoHeight, int rotation)
		{
			const string __id = "onFrameResolutionChanged.(III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (videoWidth);
				__args [1] = new JniArgumentValue (videoHeight);
				__args [2] = new JniArgumentValue (rotation);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_pauseVideo;
#pragma warning disable 0169
		static Delegate GetPauseVideoHandler ()
		{
			if (cb_pauseVideo == null)
				cb_pauseVideo = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PauseVideo);
			return cb_pauseVideo;
		}

		static void n_PauseVideo (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.SurfaceViewRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceViewRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PauseVideo ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceViewRenderer']/method[@name='pauseVideo' and count(parameter)=0]"
		[Register ("pauseVideo", "()V", "GetPauseVideoHandler")]
		public virtual unsafe void PauseVideo ()
		{
			const string __id = "pauseVideo.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
			global::Org.Webrtc.SurfaceViewRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceViewRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceViewRenderer']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_removeFrameListener_Lorg_webrtc_EglRenderer_FrameListener_;
#pragma warning disable 0169
		static Delegate GetRemoveFrameListener_Lorg_webrtc_EglRenderer_FrameListener_Handler ()
		{
			if (cb_removeFrameListener_Lorg_webrtc_EglRenderer_FrameListener_ == null)
				cb_removeFrameListener_Lorg_webrtc_EglRenderer_FrameListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveFrameListener_Lorg_webrtc_EglRenderer_FrameListener_);
			return cb_removeFrameListener_Lorg_webrtc_EglRenderer_FrameListener_;
		}

		static void n_RemoveFrameListener_Lorg_webrtc_EglRenderer_FrameListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Org.Webrtc.SurfaceViewRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceViewRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.EglRenderer.IFrameListener listener = (global::Org.Webrtc.EglRenderer.IFrameListener)global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglRenderer.IFrameListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.RemoveFrameListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceViewRenderer']/method[@name='removeFrameListener' and count(parameter)=1 and parameter[1][@type='org.webrtc.EglRenderer.FrameListener']]"
		[Register ("removeFrameListener", "(Lorg/webrtc/EglRenderer$FrameListener;)V", "GetRemoveFrameListener_Lorg_webrtc_EglRenderer_FrameListener_Handler")]
		public virtual unsafe void RemoveFrameListener (global::Org.Webrtc.EglRenderer.IFrameListener listener)
		{
			const string __id = "removeFrameListener.(Lorg/webrtc/EglRenderer$FrameListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setEnableHardwareScaler_Z;
#pragma warning disable 0169
		static Delegate GetSetEnableHardwareScaler_ZHandler ()
		{
			if (cb_setEnableHardwareScaler_Z == null)
				cb_setEnableHardwareScaler_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetEnableHardwareScaler_Z);
			return cb_setEnableHardwareScaler_Z;
		}

		static void n_SetEnableHardwareScaler_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::Org.Webrtc.SurfaceViewRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceViewRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetEnableHardwareScaler (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceViewRenderer']/method[@name='setEnableHardwareScaler' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnableHardwareScaler", "(Z)V", "GetSetEnableHardwareScaler_ZHandler")]
		public virtual unsafe void SetEnableHardwareScaler (bool enabled)
		{
			const string __id = "setEnableHardwareScaler.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setFpsReduction_F;
#pragma warning disable 0169
		static Delegate GetSetFpsReduction_FHandler ()
		{
			if (cb_setFpsReduction_F == null)
				cb_setFpsReduction_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetFpsReduction_F);
			return cb_setFpsReduction_F;
		}

		static void n_SetFpsReduction_F (IntPtr jnienv, IntPtr native__this, float fps)
		{
			global::Org.Webrtc.SurfaceViewRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceViewRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFpsReduction (fps);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceViewRenderer']/method[@name='setFpsReduction' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setFpsReduction", "(F)V", "GetSetFpsReduction_FHandler")]
		public virtual unsafe void SetFpsReduction (float fps)
		{
			const string __id = "setFpsReduction.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (fps);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setMirror_Z;
#pragma warning disable 0169
		static Delegate GetSetMirror_ZHandler ()
		{
			if (cb_setMirror_Z == null)
				cb_setMirror_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetMirror_Z);
			return cb_setMirror_Z;
		}

		static void n_SetMirror_Z (IntPtr jnienv, IntPtr native__this, bool mirror)
		{
			global::Org.Webrtc.SurfaceViewRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceViewRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMirror (mirror);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceViewRenderer']/method[@name='setMirror' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setMirror", "(Z)V", "GetSetMirror_ZHandler")]
		public virtual unsafe void SetMirror (bool mirror)
		{
			const string __id = "setMirror.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (mirror);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setScalingType_Lorg_webrtc_RendererCommon_ScalingType_;
#pragma warning disable 0169
		static Delegate GetSetScalingType_Lorg_webrtc_RendererCommon_ScalingType_Handler ()
		{
			if (cb_setScalingType_Lorg_webrtc_RendererCommon_ScalingType_ == null)
				cb_setScalingType_Lorg_webrtc_RendererCommon_ScalingType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetScalingType_Lorg_webrtc_RendererCommon_ScalingType_);
			return cb_setScalingType_Lorg_webrtc_RendererCommon_ScalingType_;
		}

		static void n_SetScalingType_Lorg_webrtc_RendererCommon_ScalingType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scalingType)
		{
			global::Org.Webrtc.SurfaceViewRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceViewRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.RendererCommon.ScalingType scalingType = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RendererCommon.ScalingType> (native_scalingType, JniHandleOwnership.DoNotTransfer);
			__this.SetScalingType (scalingType);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceViewRenderer']/method[@name='setScalingType' and count(parameter)=1 and parameter[1][@type='org.webrtc.RendererCommon.ScalingType']]"
		[Register ("setScalingType", "(Lorg/webrtc/RendererCommon$ScalingType;)V", "GetSetScalingType_Lorg_webrtc_RendererCommon_ScalingType_Handler")]
		public virtual unsafe void SetScalingType (global::Org.Webrtc.RendererCommon.ScalingType scalingType)
		{
			const string __id = "setScalingType.(Lorg/webrtc/RendererCommon$ScalingType;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((scalingType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scalingType).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setScalingType_Lorg_webrtc_RendererCommon_ScalingType_Lorg_webrtc_RendererCommon_ScalingType_;
#pragma warning disable 0169
		static Delegate GetSetScalingType_Lorg_webrtc_RendererCommon_ScalingType_Lorg_webrtc_RendererCommon_ScalingType_Handler ()
		{
			if (cb_setScalingType_Lorg_webrtc_RendererCommon_ScalingType_Lorg_webrtc_RendererCommon_ScalingType_ == null)
				cb_setScalingType_Lorg_webrtc_RendererCommon_ScalingType_Lorg_webrtc_RendererCommon_ScalingType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetScalingType_Lorg_webrtc_RendererCommon_ScalingType_Lorg_webrtc_RendererCommon_ScalingType_);
			return cb_setScalingType_Lorg_webrtc_RendererCommon_ScalingType_Lorg_webrtc_RendererCommon_ScalingType_;
		}

		static void n_SetScalingType_Lorg_webrtc_RendererCommon_ScalingType_Lorg_webrtc_RendererCommon_ScalingType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scalingTypeMatchOrientation, IntPtr native_scalingTypeMismatchOrientation)
		{
			global::Org.Webrtc.SurfaceViewRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceViewRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.RendererCommon.ScalingType scalingTypeMatchOrientation = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RendererCommon.ScalingType> (native_scalingTypeMatchOrientation, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.RendererCommon.ScalingType scalingTypeMismatchOrientation = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RendererCommon.ScalingType> (native_scalingTypeMismatchOrientation, JniHandleOwnership.DoNotTransfer);
			__this.SetScalingType (scalingTypeMatchOrientation, scalingTypeMismatchOrientation);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceViewRenderer']/method[@name='setScalingType' and count(parameter)=2 and parameter[1][@type='org.webrtc.RendererCommon.ScalingType'] and parameter[2][@type='org.webrtc.RendererCommon.ScalingType']]"
		[Register ("setScalingType", "(Lorg/webrtc/RendererCommon$ScalingType;Lorg/webrtc/RendererCommon$ScalingType;)V", "GetSetScalingType_Lorg_webrtc_RendererCommon_ScalingType_Lorg_webrtc_RendererCommon_ScalingType_Handler")]
		public virtual unsafe void SetScalingType (global::Org.Webrtc.RendererCommon.ScalingType scalingTypeMatchOrientation, global::Org.Webrtc.RendererCommon.ScalingType scalingTypeMismatchOrientation)
		{
			const string __id = "setScalingType.(Lorg/webrtc/RendererCommon$ScalingType;Lorg/webrtc/RendererCommon$ScalingType;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((scalingTypeMatchOrientation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scalingTypeMatchOrientation).Handle);
				__args [1] = new JniArgumentValue ((scalingTypeMismatchOrientation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scalingTypeMismatchOrientation).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_surfaceChanged_Landroid_view_SurfaceHolder_III;
#pragma warning disable 0169
		static Delegate GetSurfaceChanged_Landroid_view_SurfaceHolder_IIIHandler ()
		{
			if (cb_surfaceChanged_Landroid_view_SurfaceHolder_III == null)
				cb_surfaceChanged_Landroid_view_SurfaceHolder_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int>) n_SurfaceChanged_Landroid_view_SurfaceHolder_III);
			return cb_surfaceChanged_Landroid_view_SurfaceHolder_III;
		}

		static void n_SurfaceChanged_Landroid_view_SurfaceHolder_III (IntPtr jnienv, IntPtr native__this, IntPtr native_holder, int native_format, int width, int height)
		{
			global::Org.Webrtc.SurfaceViewRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceViewRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder holder = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_holder, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Format format = (global::Android.Graphics.Format) native_format;
			__this.SurfaceChanged (holder, format, width, height);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceViewRenderer']/method[@name='surfaceChanged' and count(parameter)=4 and parameter[1][@type='android.view.SurfaceHolder'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("surfaceChanged", "(Landroid/view/SurfaceHolder;III)V", "GetSurfaceChanged_Landroid_view_SurfaceHolder_IIIHandler")]
		public virtual unsafe void SurfaceChanged (global::Android.Views.ISurfaceHolder holder, [global::Android.Runtime.GeneratedEnum] global::Android.Graphics.Format format, int width, int height)
		{
			const string __id = "surfaceChanged.(Landroid/view/SurfaceHolder;III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((holder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) holder).Handle);
				__args [1] = new JniArgumentValue ((int) format);
				__args [2] = new JniArgumentValue (width);
				__args [3] = new JniArgumentValue (height);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_surfaceCreated_Landroid_view_SurfaceHolder_;
#pragma warning disable 0169
		static Delegate GetSurfaceCreated_Landroid_view_SurfaceHolder_Handler ()
		{
			if (cb_surfaceCreated_Landroid_view_SurfaceHolder_ == null)
				cb_surfaceCreated_Landroid_view_SurfaceHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SurfaceCreated_Landroid_view_SurfaceHolder_);
			return cb_surfaceCreated_Landroid_view_SurfaceHolder_;
		}

		static void n_SurfaceCreated_Landroid_view_SurfaceHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_holder)
		{
			global::Org.Webrtc.SurfaceViewRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceViewRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder holder = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_holder, JniHandleOwnership.DoNotTransfer);
			__this.SurfaceCreated (holder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceViewRenderer']/method[@name='surfaceCreated' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
		[Register ("surfaceCreated", "(Landroid/view/SurfaceHolder;)V", "GetSurfaceCreated_Landroid_view_SurfaceHolder_Handler")]
		public virtual unsafe void SurfaceCreated (global::Android.Views.ISurfaceHolder holder)
		{
			const string __id = "surfaceCreated.(Landroid/view/SurfaceHolder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((holder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) holder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_surfaceDestroyed_Landroid_view_SurfaceHolder_;
#pragma warning disable 0169
		static Delegate GetSurfaceDestroyed_Landroid_view_SurfaceHolder_Handler ()
		{
			if (cb_surfaceDestroyed_Landroid_view_SurfaceHolder_ == null)
				cb_surfaceDestroyed_Landroid_view_SurfaceHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SurfaceDestroyed_Landroid_view_SurfaceHolder_);
			return cb_surfaceDestroyed_Landroid_view_SurfaceHolder_;
		}

		static void n_SurfaceDestroyed_Landroid_view_SurfaceHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_holder)
		{
			global::Org.Webrtc.SurfaceViewRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceViewRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder holder = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_holder, JniHandleOwnership.DoNotTransfer);
			__this.SurfaceDestroyed (holder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceViewRenderer']/method[@name='surfaceDestroyed' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
		[Register ("surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V", "GetSurfaceDestroyed_Landroid_view_SurfaceHolder_Handler")]
		public virtual unsafe void SurfaceDestroyed (global::Android.Views.ISurfaceHolder holder)
		{
			const string __id = "surfaceDestroyed.(Landroid/view/SurfaceHolder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((holder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) holder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
