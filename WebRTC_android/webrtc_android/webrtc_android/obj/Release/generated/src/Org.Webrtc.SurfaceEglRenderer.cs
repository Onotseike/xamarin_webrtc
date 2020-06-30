using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceEglRenderer']"
	[global::Android.Runtime.Register ("org/webrtc/SurfaceEglRenderer", DoNotGenerateAcw=true)]
	public partial class SurfaceEglRenderer : global::Org.Webrtc.EglRenderer, global::Android.Views.ISurfaceHolderCallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/SurfaceEglRenderer", typeof (SurfaceEglRenderer));
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

		protected SurfaceEglRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceEglRenderer']/constructor[@name='SurfaceEglRenderer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe SurfaceEglRenderer (string name)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
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
			global::Org.Webrtc.SurfaceEglRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceEglRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.IEglBaseContext sharedContext = (global::Org.Webrtc.IEglBaseContext)global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBaseContext> (native_sharedContext, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.RendererCommon.IRendererEvents rendererEvents = (global::Org.Webrtc.RendererCommon.IRendererEvents)global::Java.Lang.Object.GetObject<global::Org.Webrtc.RendererCommon.IRendererEvents> (native_rendererEvents, JniHandleOwnership.DoNotTransfer);
			int[] configAttributes = (int[]) JNIEnv.GetArray (native_configAttributes, JniHandleOwnership.DoNotTransfer, typeof (int));
			global::Org.Webrtc.RendererCommon.IGlDrawer drawer = (global::Org.Webrtc.RendererCommon.IGlDrawer)global::Java.Lang.Object.GetObject<global::Org.Webrtc.RendererCommon.IGlDrawer> (native_drawer, JniHandleOwnership.DoNotTransfer);
			__this.Init (sharedContext, rendererEvents, configAttributes, drawer);
			if (configAttributes != null)
				JNIEnv.CopyArray (configAttributes, native_configAttributes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceEglRenderer']/method[@name='init' and count(parameter)=4 and parameter[1][@type='org.webrtc.EglBase.Context'] and parameter[2][@type='org.webrtc.RendererCommon.RendererEvents'] and parameter[3][@type='int[]'] and parameter[4][@type='org.webrtc.RendererCommon.GlDrawer']]"
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
			global::Org.Webrtc.SurfaceEglRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceEglRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder holder = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_holder, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Format format = (global::Android.Graphics.Format) native_format;
			__this.SurfaceChanged (holder, format, width, height);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceEglRenderer']/method[@name='surfaceChanged' and count(parameter)=4 and parameter[1][@type='android.view.SurfaceHolder'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
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
			global::Org.Webrtc.SurfaceEglRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceEglRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder holder = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_holder, JniHandleOwnership.DoNotTransfer);
			__this.SurfaceCreated (holder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceEglRenderer']/method[@name='surfaceCreated' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
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
			global::Org.Webrtc.SurfaceEglRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SurfaceEglRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder holder = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_holder, JniHandleOwnership.DoNotTransfer);
			__this.SurfaceDestroyed (holder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SurfaceEglRenderer']/method[@name='surfaceDestroyed' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
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
