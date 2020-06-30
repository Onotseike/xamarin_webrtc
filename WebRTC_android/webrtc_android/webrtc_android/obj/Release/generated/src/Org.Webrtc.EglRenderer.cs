using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='EglRenderer']"
	[global::Android.Runtime.Register ("org/webrtc/EglRenderer", DoNotGenerateAcw=true)]
	public partial class EglRenderer : global::Java.Lang.Object, global::Org.Webrtc.IVideoSink {



		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='EglRenderer']/field[@name='name']"
		[Register ("name")]
		protected string Name {
			get {
				const string __id = "name.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "name.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='EglRenderer.ErrorCallback']"
		[Register ("org/webrtc/EglRenderer$ErrorCallback", "", "Org.Webrtc.EglRenderer/IErrorCallbackInvoker")]
		public partial interface IErrorCallback : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='EglRenderer.ErrorCallback']/method[@name='onGlOutOfMemory' and count(parameter)=0]"
			[Register ("onGlOutOfMemory", "()V", "GetOnGlOutOfMemoryHandler:Org.Webrtc.EglRenderer/IErrorCallbackInvoker, webrtc_android")]
			void OnGlOutOfMemory ();

		}

		[global::Android.Runtime.Register ("org/webrtc/EglRenderer$ErrorCallback", DoNotGenerateAcw=true)]
		internal partial class IErrorCallbackInvoker : global::Java.Lang.Object, IErrorCallback {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/EglRenderer$ErrorCallback", typeof (IErrorCallbackInvoker));

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

			public static IErrorCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IErrorCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.EglRenderer.ErrorCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IErrorCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onGlOutOfMemory;
#pragma warning disable 0169
			static Delegate GetOnGlOutOfMemoryHandler ()
			{
				if (cb_onGlOutOfMemory == null)
					cb_onGlOutOfMemory = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnGlOutOfMemory);
				return cb_onGlOutOfMemory;
			}

			static void n_OnGlOutOfMemory (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.EglRenderer.IErrorCallback __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglRenderer.IErrorCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnGlOutOfMemory ();
			}
#pragma warning restore 0169

			IntPtr id_onGlOutOfMemory;
			public unsafe void OnGlOutOfMemory ()
			{
				if (id_onGlOutOfMemory == IntPtr.Zero)
					id_onGlOutOfMemory = JNIEnv.GetMethodID (class_ref, "onGlOutOfMemory", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onGlOutOfMemory);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='EglRenderer.FrameListener']"
		[Register ("org/webrtc/EglRenderer$FrameListener", "", "Org.Webrtc.EglRenderer/IFrameListenerInvoker")]
		public partial interface IFrameListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='EglRenderer.FrameListener']/method[@name='onFrame' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("onFrame", "(Landroid/graphics/Bitmap;)V", "GetOnFrame_Landroid_graphics_Bitmap_Handler:Org.Webrtc.EglRenderer/IFrameListenerInvoker, webrtc_android")]
			void OnFrame (global::Android.Graphics.Bitmap p0);

		}

		[global::Android.Runtime.Register ("org/webrtc/EglRenderer$FrameListener", DoNotGenerateAcw=true)]
		internal partial class IFrameListenerInvoker : global::Java.Lang.Object, IFrameListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/EglRenderer$FrameListener", typeof (IFrameListenerInvoker));

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

			public static IFrameListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IFrameListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.EglRenderer.FrameListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IFrameListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onFrame_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
			static Delegate GetOnFrame_Landroid_graphics_Bitmap_Handler ()
			{
				if (cb_onFrame_Landroid_graphics_Bitmap_ == null)
					cb_onFrame_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFrame_Landroid_graphics_Bitmap_);
				return cb_onFrame_Landroid_graphics_Bitmap_;
			}

			static void n_OnFrame_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.EglRenderer.IFrameListener __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglRenderer.IFrameListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnFrame (p0);
			}
#pragma warning restore 0169

			IntPtr id_onFrame_Landroid_graphics_Bitmap_;
			public unsafe void OnFrame (global::Android.Graphics.Bitmap p0)
			{
				if (id_onFrame_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_onFrame_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "onFrame", "(Landroid/graphics/Bitmap;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFrame_Landroid_graphics_Bitmap_, __args);
			}

		}

		// event args for org.webrtc.EglRenderer.FrameListener.onFrame
		public partial class FrameEventArgs : global::System.EventArgs {

			public FrameEventArgs (global::Android.Graphics.Bitmap p0)
			{
				this.p0 = p0;
			}

			global::Android.Graphics.Bitmap p0;
			public global::Android.Graphics.Bitmap P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/org/webrtc/EglRenderer_FrameListenerImplementor")]
		internal sealed partial class IFrameListenerImplementor : global::Java.Lang.Object, IFrameListener {

			object sender;

			public IFrameListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/org/webrtc/EglRenderer_FrameListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<FrameEventArgs> Handler;
#pragma warning restore 0649

			public void OnFrame (global::Android.Graphics.Bitmap p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new FrameEventArgs (p0));
			}

			internal static bool __IsEmpty (IFrameListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/EglRenderer", typeof (EglRenderer));
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

		protected EglRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='EglRenderer']/constructor[@name='EglRenderer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe EglRenderer (string name)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='EglRenderer']/constructor[@name='EglRenderer' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.webrtc.VideoFrameDrawer']]"
		[Register (".ctor", "(Ljava/lang/String;Lorg/webrtc/VideoFrameDrawer;)V", "")]
		public unsafe EglRenderer (string name, global::Org.Webrtc.VideoFrameDrawer videoFrameDrawer)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lorg/webrtc/VideoFrameDrawer;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((videoFrameDrawer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) videoFrameDrawer).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
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
			global::Org.Webrtc.EglRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.EglRenderer.IFrameListener listener = (global::Org.Webrtc.EglRenderer.IFrameListener)global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglRenderer.IFrameListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.AddFrameListener (listener, scale);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglRenderer']/method[@name='addFrameListener' and count(parameter)=2 and parameter[1][@type='org.webrtc.EglRenderer.FrameListener'] and parameter[2][@type='float']]"
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
			global::Org.Webrtc.EglRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.EglRenderer.IFrameListener listener = (global::Org.Webrtc.EglRenderer.IFrameListener)global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglRenderer.IFrameListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.RendererCommon.IGlDrawer drawerParam = (global::Org.Webrtc.RendererCommon.IGlDrawer)global::Java.Lang.Object.GetObject<global::Org.Webrtc.RendererCommon.IGlDrawer> (native_drawerParam, JniHandleOwnership.DoNotTransfer);
			__this.AddFrameListener (listener, scale, drawerParam);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglRenderer']/method[@name='addFrameListener' and count(parameter)=3 and parameter[1][@type='org.webrtc.EglRenderer.FrameListener'] and parameter[2][@type='float'] and parameter[3][@type='org.webrtc.RendererCommon.GlDrawer']]"
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

		static Delegate cb_addFrameListener_Lorg_webrtc_EglRenderer_FrameListener_FLorg_webrtc_RendererCommon_GlDrawer_Z;
#pragma warning disable 0169
		static Delegate GetAddFrameListener_Lorg_webrtc_EglRenderer_FrameListener_FLorg_webrtc_RendererCommon_GlDrawer_ZHandler ()
		{
			if (cb_addFrameListener_Lorg_webrtc_EglRenderer_FrameListener_FLorg_webrtc_RendererCommon_GlDrawer_Z == null)
				cb_addFrameListener_Lorg_webrtc_EglRenderer_FrameListener_FLorg_webrtc_RendererCommon_GlDrawer_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, IntPtr, bool>) n_AddFrameListener_Lorg_webrtc_EglRenderer_FrameListener_FLorg_webrtc_RendererCommon_GlDrawer_Z);
			return cb_addFrameListener_Lorg_webrtc_EglRenderer_FrameListener_FLorg_webrtc_RendererCommon_GlDrawer_Z;
		}

		static void n_AddFrameListener_Lorg_webrtc_EglRenderer_FrameListener_FLorg_webrtc_RendererCommon_GlDrawer_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_listener, float scale, IntPtr native_drawerParam, bool applyFpsReduction)
		{
			global::Org.Webrtc.EglRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.EglRenderer.IFrameListener listener = (global::Org.Webrtc.EglRenderer.IFrameListener)global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglRenderer.IFrameListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.RendererCommon.IGlDrawer drawerParam = (global::Org.Webrtc.RendererCommon.IGlDrawer)global::Java.Lang.Object.GetObject<global::Org.Webrtc.RendererCommon.IGlDrawer> (native_drawerParam, JniHandleOwnership.DoNotTransfer);
			__this.AddFrameListener (listener, scale, drawerParam, applyFpsReduction);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglRenderer']/method[@name='addFrameListener' and count(parameter)=4 and parameter[1][@type='org.webrtc.EglRenderer.FrameListener'] and parameter[2][@type='float'] and parameter[3][@type='org.webrtc.RendererCommon.GlDrawer'] and parameter[4][@type='boolean']]"
		[Register ("addFrameListener", "(Lorg/webrtc/EglRenderer$FrameListener;FLorg/webrtc/RendererCommon$GlDrawer;Z)V", "GetAddFrameListener_Lorg_webrtc_EglRenderer_FrameListener_FLorg_webrtc_RendererCommon_GlDrawer_ZHandler")]
		public virtual unsafe void AddFrameListener (global::Org.Webrtc.EglRenderer.IFrameListener listener, float scale, global::Org.Webrtc.RendererCommon.IGlDrawer drawerParam, bool applyFpsReduction)
		{
			const string __id = "addFrameListener.(Lorg/webrtc/EglRenderer$FrameListener;FLorg/webrtc/RendererCommon$GlDrawer;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [1] = new JniArgumentValue (scale);
				__args [2] = new JniArgumentValue ((drawerParam == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawerParam).Handle);
				__args [3] = new JniArgumentValue (applyFpsReduction);
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
			global::Org.Webrtc.EglRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearImage ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglRenderer']/method[@name='clearImage' and count(parameter)=0]"
		[Register ("clearImage", "()V", "GetClearImageHandler")]
		public virtual unsafe void ClearImage ()
		{
			const string __id = "clearImage.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_clearImage_FFFF;
#pragma warning disable 0169
		static Delegate GetClearImage_FFFFHandler ()
		{
			if (cb_clearImage_FFFF == null)
				cb_clearImage_FFFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float, float>) n_ClearImage_FFFF);
			return cb_clearImage_FFFF;
		}

		static void n_ClearImage_FFFF (IntPtr jnienv, IntPtr native__this, float r, float g, float b, float a)
		{
			global::Org.Webrtc.EglRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearImage (r, g, b, a);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglRenderer']/method[@name='clearImage' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("clearImage", "(FFFF)V", "GetClearImage_FFFFHandler")]
		public virtual unsafe void ClearImage (float r, float g, float b, float a)
		{
			const string __id = "clearImage.(FFFF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (r);
				__args [1] = new JniArgumentValue (g);
				__args [2] = new JniArgumentValue (b);
				__args [3] = new JniArgumentValue (a);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_createEglSurface_Landroid_graphics_SurfaceTexture_;
#pragma warning disable 0169
		static Delegate GetCreateEglSurface_Landroid_graphics_SurfaceTexture_Handler ()
		{
			if (cb_createEglSurface_Landroid_graphics_SurfaceTexture_ == null)
				cb_createEglSurface_Landroid_graphics_SurfaceTexture_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CreateEglSurface_Landroid_graphics_SurfaceTexture_);
			return cb_createEglSurface_Landroid_graphics_SurfaceTexture_;
		}

		static void n_CreateEglSurface_Landroid_graphics_SurfaceTexture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_surfaceTexture)
		{
			global::Org.Webrtc.EglRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.SurfaceTexture surfaceTexture = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_surfaceTexture, JniHandleOwnership.DoNotTransfer);
			__this.CreateEglSurface (surfaceTexture);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglRenderer']/method[@name='createEglSurface' and count(parameter)=1 and parameter[1][@type='android.graphics.SurfaceTexture']]"
		[Register ("createEglSurface", "(Landroid/graphics/SurfaceTexture;)V", "GetCreateEglSurface_Landroid_graphics_SurfaceTexture_Handler")]
		public virtual unsafe void CreateEglSurface (global::Android.Graphics.SurfaceTexture surfaceTexture)
		{
			const string __id = "createEglSurface.(Landroid/graphics/SurfaceTexture;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((surfaceTexture == null) ? IntPtr.Zero : ((global::Java.Lang.Object) surfaceTexture).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_createEglSurface_Landroid_view_Surface_;
#pragma warning disable 0169
		static Delegate GetCreateEglSurface_Landroid_view_Surface_Handler ()
		{
			if (cb_createEglSurface_Landroid_view_Surface_ == null)
				cb_createEglSurface_Landroid_view_Surface_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CreateEglSurface_Landroid_view_Surface_);
			return cb_createEglSurface_Landroid_view_Surface_;
		}

		static void n_CreateEglSurface_Landroid_view_Surface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_surface)
		{
			global::Org.Webrtc.EglRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Surface surface = global::Java.Lang.Object.GetObject<global::Android.Views.Surface> (native_surface, JniHandleOwnership.DoNotTransfer);
			__this.CreateEglSurface (surface);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglRenderer']/method[@name='createEglSurface' and count(parameter)=1 and parameter[1][@type='android.view.Surface']]"
		[Register ("createEglSurface", "(Landroid/view/Surface;)V", "GetCreateEglSurface_Landroid_view_Surface_Handler")]
		public virtual unsafe void CreateEglSurface (global::Android.Views.Surface surface)
		{
			const string __id = "createEglSurface.(Landroid/view/Surface;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((surface == null) ? IntPtr.Zero : ((global::Java.Lang.Object) surface).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Org.Webrtc.EglRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableFpsReduction ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglRenderer']/method[@name='disableFpsReduction' and count(parameter)=0]"
		[Register ("disableFpsReduction", "()V", "GetDisableFpsReductionHandler")]
		public virtual unsafe void DisableFpsReduction ()
		{
			const string __id = "disableFpsReduction.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_init_Lorg_webrtc_EglBase_Context_arrayILorg_webrtc_RendererCommon_GlDrawer_;
#pragma warning disable 0169
		static Delegate GetInit_Lorg_webrtc_EglBase_Context_arrayILorg_webrtc_RendererCommon_GlDrawer_Handler ()
		{
			if (cb_init_Lorg_webrtc_EglBase_Context_arrayILorg_webrtc_RendererCommon_GlDrawer_ == null)
				cb_init_Lorg_webrtc_EglBase_Context_arrayILorg_webrtc_RendererCommon_GlDrawer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Init_Lorg_webrtc_EglBase_Context_arrayILorg_webrtc_RendererCommon_GlDrawer_);
			return cb_init_Lorg_webrtc_EglBase_Context_arrayILorg_webrtc_RendererCommon_GlDrawer_;
		}

		static void n_Init_Lorg_webrtc_EglBase_Context_arrayILorg_webrtc_RendererCommon_GlDrawer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sharedContext, IntPtr native_configAttributes, IntPtr native_drawer)
		{
			global::Org.Webrtc.EglRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.IEglBaseContext sharedContext = (global::Org.Webrtc.IEglBaseContext)global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBaseContext> (native_sharedContext, JniHandleOwnership.DoNotTransfer);
			int[] configAttributes = (int[]) JNIEnv.GetArray (native_configAttributes, JniHandleOwnership.DoNotTransfer, typeof (int));
			global::Org.Webrtc.RendererCommon.IGlDrawer drawer = (global::Org.Webrtc.RendererCommon.IGlDrawer)global::Java.Lang.Object.GetObject<global::Org.Webrtc.RendererCommon.IGlDrawer> (native_drawer, JniHandleOwnership.DoNotTransfer);
			__this.Init (sharedContext, configAttributes, drawer);
			if (configAttributes != null)
				JNIEnv.CopyArray (configAttributes, native_configAttributes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglRenderer']/method[@name='init' and count(parameter)=3 and parameter[1][@type='org.webrtc.EglBase.Context'] and parameter[2][@type='int[]'] and parameter[3][@type='org.webrtc.RendererCommon.GlDrawer']]"
		[Register ("init", "(Lorg/webrtc/EglBase$Context;[ILorg/webrtc/RendererCommon$GlDrawer;)V", "GetInit_Lorg_webrtc_EglBase_Context_arrayILorg_webrtc_RendererCommon_GlDrawer_Handler")]
		public virtual unsafe void Init (global::Org.Webrtc.IEglBaseContext sharedContext, int[] configAttributes, global::Org.Webrtc.RendererCommon.IGlDrawer drawer)
		{
			const string __id = "init.(Lorg/webrtc/EglBase$Context;[ILorg/webrtc/RendererCommon$GlDrawer;)V";
			IntPtr native_configAttributes = JNIEnv.NewArray (configAttributes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((sharedContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sharedContext).Handle);
				__args [1] = new JniArgumentValue (native_configAttributes);
				__args [2] = new JniArgumentValue ((drawer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawer).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (configAttributes != null) {
					JNIEnv.CopyArray (native_configAttributes, configAttributes);
					JNIEnv.DeleteLocalRef (native_configAttributes);
				}
			}
		}

		static Delegate cb_init_Lorg_webrtc_EglBase_Context_arrayILorg_webrtc_RendererCommon_GlDrawer_Z;
#pragma warning disable 0169
		static Delegate GetInit_Lorg_webrtc_EglBase_Context_arrayILorg_webrtc_RendererCommon_GlDrawer_ZHandler ()
		{
			if (cb_init_Lorg_webrtc_EglBase_Context_arrayILorg_webrtc_RendererCommon_GlDrawer_Z == null)
				cb_init_Lorg_webrtc_EglBase_Context_arrayILorg_webrtc_RendererCommon_GlDrawer_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Init_Lorg_webrtc_EglBase_Context_arrayILorg_webrtc_RendererCommon_GlDrawer_Z);
			return cb_init_Lorg_webrtc_EglBase_Context_arrayILorg_webrtc_RendererCommon_GlDrawer_Z;
		}

		static void n_Init_Lorg_webrtc_EglBase_Context_arrayILorg_webrtc_RendererCommon_GlDrawer_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_sharedContext, IntPtr native_configAttributes, IntPtr native_drawer, bool usePresentationTimeStamp)
		{
			global::Org.Webrtc.EglRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.IEglBaseContext sharedContext = (global::Org.Webrtc.IEglBaseContext)global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBaseContext> (native_sharedContext, JniHandleOwnership.DoNotTransfer);
			int[] configAttributes = (int[]) JNIEnv.GetArray (native_configAttributes, JniHandleOwnership.DoNotTransfer, typeof (int));
			global::Org.Webrtc.RendererCommon.IGlDrawer drawer = (global::Org.Webrtc.RendererCommon.IGlDrawer)global::Java.Lang.Object.GetObject<global::Org.Webrtc.RendererCommon.IGlDrawer> (native_drawer, JniHandleOwnership.DoNotTransfer);
			__this.Init (sharedContext, configAttributes, drawer, usePresentationTimeStamp);
			if (configAttributes != null)
				JNIEnv.CopyArray (configAttributes, native_configAttributes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglRenderer']/method[@name='init' and count(parameter)=4 and parameter[1][@type='org.webrtc.EglBase.Context'] and parameter[2][@type='int[]'] and parameter[3][@type='org.webrtc.RendererCommon.GlDrawer'] and parameter[4][@type='boolean']]"
		[Register ("init", "(Lorg/webrtc/EglBase$Context;[ILorg/webrtc/RendererCommon$GlDrawer;Z)V", "GetInit_Lorg_webrtc_EglBase_Context_arrayILorg_webrtc_RendererCommon_GlDrawer_ZHandler")]
		public virtual unsafe void Init (global::Org.Webrtc.IEglBaseContext sharedContext, int[] configAttributes, global::Org.Webrtc.RendererCommon.IGlDrawer drawer, bool usePresentationTimeStamp)
		{
			const string __id = "init.(Lorg/webrtc/EglBase$Context;[ILorg/webrtc/RendererCommon$GlDrawer;Z)V";
			IntPtr native_configAttributes = JNIEnv.NewArray (configAttributes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((sharedContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sharedContext).Handle);
				__args [1] = new JniArgumentValue (native_configAttributes);
				__args [2] = new JniArgumentValue ((drawer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawer).Handle);
				__args [3] = new JniArgumentValue (usePresentationTimeStamp);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (configAttributes != null) {
					JNIEnv.CopyArray (native_configAttributes, configAttributes);
					JNIEnv.DeleteLocalRef (native_configAttributes);
				}
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
			global::Org.Webrtc.EglRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.VideoFrame frame = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame> (native_frame, JniHandleOwnership.DoNotTransfer);
			__this.OnFrame (frame);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglRenderer']/method[@name='onFrame' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoFrame']]"
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
			global::Org.Webrtc.EglRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PauseVideo ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglRenderer']/method[@name='pauseVideo' and count(parameter)=0]"
		[Register ("pauseVideo", "()V", "GetPauseVideoHandler")]
		public virtual unsafe void PauseVideo ()
		{
			const string __id = "pauseVideo.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_printStackTrace;
#pragma warning disable 0169
		static Delegate GetPrintStackTraceHandler ()
		{
			if (cb_printStackTrace == null)
				cb_printStackTrace = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PrintStackTrace);
			return cb_printStackTrace;
		}

		static void n_PrintStackTrace (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.EglRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PrintStackTrace ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglRenderer']/method[@name='printStackTrace' and count(parameter)=0]"
		[Register ("printStackTrace", "()V", "GetPrintStackTraceHandler")]
		public virtual unsafe void PrintStackTrace ()
		{
			const string __id = "printStackTrace.()V";
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
			global::Org.Webrtc.EglRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglRenderer']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_releaseEglSurface_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetReleaseEglSurface_Ljava_lang_Runnable_Handler ()
		{
			if (cb_releaseEglSurface_Ljava_lang_Runnable_ == null)
				cb_releaseEglSurface_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReleaseEglSurface_Ljava_lang_Runnable_);
			return cb_releaseEglSurface_Ljava_lang_Runnable_;
		}

		static void n_ReleaseEglSurface_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_completionCallback)
		{
			global::Org.Webrtc.EglRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable completionCallback = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_completionCallback, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseEglSurface (completionCallback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglRenderer']/method[@name='releaseEglSurface' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("releaseEglSurface", "(Ljava/lang/Runnable;)V", "GetReleaseEglSurface_Ljava_lang_Runnable_Handler")]
		public virtual unsafe void ReleaseEglSurface (global::Java.Lang.IRunnable completionCallback)
		{
			const string __id = "releaseEglSurface.(Ljava/lang/Runnable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((completionCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) completionCallback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Org.Webrtc.EglRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.EglRenderer.IFrameListener listener = (global::Org.Webrtc.EglRenderer.IFrameListener)global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglRenderer.IFrameListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.RemoveFrameListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglRenderer']/method[@name='removeFrameListener' and count(parameter)=1 and parameter[1][@type='org.webrtc.EglRenderer.FrameListener']]"
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

		static Delegate cb_setErrorCallback_Lorg_webrtc_EglRenderer_ErrorCallback_;
#pragma warning disable 0169
		static Delegate GetSetErrorCallback_Lorg_webrtc_EglRenderer_ErrorCallback_Handler ()
		{
			if (cb_setErrorCallback_Lorg_webrtc_EglRenderer_ErrorCallback_ == null)
				cb_setErrorCallback_Lorg_webrtc_EglRenderer_ErrorCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetErrorCallback_Lorg_webrtc_EglRenderer_ErrorCallback_);
			return cb_setErrorCallback_Lorg_webrtc_EglRenderer_ErrorCallback_;
		}

		static void n_SetErrorCallback_Lorg_webrtc_EglRenderer_ErrorCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_errorCallback)
		{
			global::Org.Webrtc.EglRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.EglRenderer.IErrorCallback errorCallback = (global::Org.Webrtc.EglRenderer.IErrorCallback)global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglRenderer.IErrorCallback> (native_errorCallback, JniHandleOwnership.DoNotTransfer);
			__this.SetErrorCallback (errorCallback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglRenderer']/method[@name='setErrorCallback' and count(parameter)=1 and parameter[1][@type='org.webrtc.EglRenderer.ErrorCallback']]"
		[Register ("setErrorCallback", "(Lorg/webrtc/EglRenderer$ErrorCallback;)V", "GetSetErrorCallback_Lorg_webrtc_EglRenderer_ErrorCallback_Handler")]
		public virtual unsafe void SetErrorCallback (global::Org.Webrtc.EglRenderer.IErrorCallback errorCallback)
		{
			const string __id = "setErrorCallback.(Lorg/webrtc/EglRenderer$ErrorCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((errorCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) errorCallback).Handle);
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
			global::Org.Webrtc.EglRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFpsReduction (fps);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglRenderer']/method[@name='setFpsReduction' and count(parameter)=1 and parameter[1][@type='float']]"
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

		static Delegate cb_setLayoutAspectRatio_F;
#pragma warning disable 0169
		static Delegate GetSetLayoutAspectRatio_FHandler ()
		{
			if (cb_setLayoutAspectRatio_F == null)
				cb_setLayoutAspectRatio_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetLayoutAspectRatio_F);
			return cb_setLayoutAspectRatio_F;
		}

		static void n_SetLayoutAspectRatio_F (IntPtr jnienv, IntPtr native__this, float layoutAspectRatio)
		{
			global::Org.Webrtc.EglRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLayoutAspectRatio (layoutAspectRatio);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglRenderer']/method[@name='setLayoutAspectRatio' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setLayoutAspectRatio", "(F)V", "GetSetLayoutAspectRatio_FHandler")]
		public virtual unsafe void SetLayoutAspectRatio (float layoutAspectRatio)
		{
			const string __id = "setLayoutAspectRatio.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (layoutAspectRatio);
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
			global::Org.Webrtc.EglRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMirror (mirror);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglRenderer']/method[@name='setMirror' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_setMirrorVertically_Z;
#pragma warning disable 0169
		static Delegate GetSetMirrorVertically_ZHandler ()
		{
			if (cb_setMirrorVertically_Z == null)
				cb_setMirrorVertically_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetMirrorVertically_Z);
			return cb_setMirrorVertically_Z;
		}

		static void n_SetMirrorVertically_Z (IntPtr jnienv, IntPtr native__this, bool mirrorVertically)
		{
			global::Org.Webrtc.EglRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMirrorVertically (mirrorVertically);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglRenderer']/method[@name='setMirrorVertically' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setMirrorVertically", "(Z)V", "GetSetMirrorVertically_ZHandler")]
		public virtual unsafe void SetMirrorVertically (bool mirrorVertically)
		{
			const string __id = "setMirrorVertically.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (mirrorVertically);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
