using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='EglBase.ConfigBuilder']"
	[global::Android.Runtime.Register ("org/webrtc/EglBase$ConfigBuilder", DoNotGenerateAcw=true)]
	public partial class EglBaseConfigBuilder : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/EglBase$ConfigBuilder", typeof (EglBaseConfigBuilder));
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

		protected EglBaseConfigBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='EglBase.ConfigBuilder']/constructor[@name='EglBase.ConfigBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EglBaseConfigBuilder ()
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

		static Delegate cb_createConfigAttributes;
#pragma warning disable 0169
		static Delegate GetCreateConfigAttributesHandler ()
		{
			if (cb_createConfigAttributes == null)
				cb_createConfigAttributes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreateConfigAttributes);
			return cb_createConfigAttributes;
		}

		static IntPtr n_CreateConfigAttributes (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.EglBaseConfigBuilder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglBaseConfigBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.CreateConfigAttributes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglBase.ConfigBuilder']/method[@name='createConfigAttributes' and count(parameter)=0]"
		[Register ("createConfigAttributes", "()[I", "GetCreateConfigAttributesHandler")]
		public virtual unsafe int[] CreateConfigAttributes ()
		{
			const string __id = "createConfigAttributes.()[I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_setHasAlphaChannel_Z;
#pragma warning disable 0169
		static Delegate GetSetHasAlphaChannel_ZHandler ()
		{
			if (cb_setHasAlphaChannel_Z == null)
				cb_setHasAlphaChannel_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetHasAlphaChannel_Z);
			return cb_setHasAlphaChannel_Z;
		}

		static IntPtr n_SetHasAlphaChannel_Z (IntPtr jnienv, IntPtr native__this, bool hasAlphaChannel)
		{
			global::Org.Webrtc.EglBaseConfigBuilder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglBaseConfigBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetHasAlphaChannel (hasAlphaChannel));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglBase.ConfigBuilder']/method[@name='setHasAlphaChannel' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setHasAlphaChannel", "(Z)Lorg/webrtc/EglBase$ConfigBuilder;", "GetSetHasAlphaChannel_ZHandler")]
		public virtual unsafe global::Org.Webrtc.EglBaseConfigBuilder SetHasAlphaChannel (bool hasAlphaChannel)
		{
			const string __id = "setHasAlphaChannel.(Z)Lorg/webrtc/EglBase$ConfigBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (hasAlphaChannel);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglBaseConfigBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setIsRecordable_Z;
#pragma warning disable 0169
		static Delegate GetSetIsRecordable_ZHandler ()
		{
			if (cb_setIsRecordable_Z == null)
				cb_setIsRecordable_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetIsRecordable_Z);
			return cb_setIsRecordable_Z;
		}

		static IntPtr n_SetIsRecordable_Z (IntPtr jnienv, IntPtr native__this, bool isRecordable)
		{
			global::Org.Webrtc.EglBaseConfigBuilder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglBaseConfigBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetIsRecordable (isRecordable));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglBase.ConfigBuilder']/method[@name='setIsRecordable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIsRecordable", "(Z)Lorg/webrtc/EglBase$ConfigBuilder;", "GetSetIsRecordable_ZHandler")]
		public virtual unsafe global::Org.Webrtc.EglBaseConfigBuilder SetIsRecordable (bool isRecordable)
		{
			const string __id = "setIsRecordable.(Z)Lorg/webrtc/EglBase$ConfigBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isRecordable);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglBaseConfigBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setOpenGlesVersion_I;
#pragma warning disable 0169
		static Delegate GetSetOpenGlesVersion_IHandler ()
		{
			if (cb_setOpenGlesVersion_I == null)
				cb_setOpenGlesVersion_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetOpenGlesVersion_I);
			return cb_setOpenGlesVersion_I;
		}

		static IntPtr n_SetOpenGlesVersion_I (IntPtr jnienv, IntPtr native__this, int version)
		{
			global::Org.Webrtc.EglBaseConfigBuilder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglBaseConfigBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetOpenGlesVersion (version));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglBase.ConfigBuilder']/method[@name='setOpenGlesVersion' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setOpenGlesVersion", "(I)Lorg/webrtc/EglBase$ConfigBuilder;", "GetSetOpenGlesVersion_IHandler")]
		public virtual unsafe global::Org.Webrtc.EglBaseConfigBuilder SetOpenGlesVersion (int version)
		{
			const string __id = "setOpenGlesVersion.(I)Lorg/webrtc/EglBase$ConfigBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (version);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglBaseConfigBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setSupportsPixelBuffer_Z;
#pragma warning disable 0169
		static Delegate GetSetSupportsPixelBuffer_ZHandler ()
		{
			if (cb_setSupportsPixelBuffer_Z == null)
				cb_setSupportsPixelBuffer_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetSupportsPixelBuffer_Z);
			return cb_setSupportsPixelBuffer_Z;
		}

		static IntPtr n_SetSupportsPixelBuffer_Z (IntPtr jnienv, IntPtr native__this, bool supportsPixelBuffer)
		{
			global::Org.Webrtc.EglBaseConfigBuilder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglBaseConfigBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetSupportsPixelBuffer (supportsPixelBuffer));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglBase.ConfigBuilder']/method[@name='setSupportsPixelBuffer' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSupportsPixelBuffer", "(Z)Lorg/webrtc/EglBase$ConfigBuilder;", "GetSetSupportsPixelBuffer_ZHandler")]
		public virtual unsafe global::Org.Webrtc.EglBaseConfigBuilder SetSupportsPixelBuffer (bool supportsPixelBuffer)
		{
			const string __id = "setSupportsPixelBuffer.(Z)Lorg/webrtc/EglBase$ConfigBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (supportsPixelBuffer);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglBaseConfigBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[Register ("org/webrtc/EglBase$Context", DoNotGenerateAcw=true)]
	public abstract class EglBaseContext : Java.Lang.Object {

		internal EglBaseContext ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase.Context']/field[@name='NO_CONTEXT']"
		[Register ("NO_CONTEXT")]
		public const long NoContext = (long) 0;
	}

	[Register ("org/webrtc/EglBase$Context", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'EglBaseContext' type. This type will be removed in a future release.", error: true)]
	public abstract class EglBaseContextConsts : EglBaseContext {

		private EglBaseContextConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase.Context']"
	[Register ("org/webrtc/EglBase$Context", "", "Org.Webrtc.IEglBaseContextInvoker")]
	public partial interface IEglBaseContext : IJavaObject, IJavaPeerable {

		long NativeEglContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase.Context']/method[@name='getNativeEglContext' and count(parameter)=0]"
			[Register ("getNativeEglContext", "()J", "GetGetNativeEglContextHandler:Org.Webrtc.IEglBaseContextInvoker, webrtc_android")] get;
		}

	}

	[global::Android.Runtime.Register ("org/webrtc/EglBase$Context", DoNotGenerateAcw=true)]
	internal partial class IEglBaseContextInvoker : global::Java.Lang.Object, IEglBaseContext {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/EglBase$Context", typeof (IEglBaseContextInvoker));

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

		public static IEglBaseContext GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEglBaseContext> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.EglBase.Context"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEglBaseContextInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getNativeEglContext;
#pragma warning disable 0169
		static Delegate GetGetNativeEglContextHandler ()
		{
			if (cb_getNativeEglContext == null)
				cb_getNativeEglContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetNativeEglContext);
			return cb_getNativeEglContext;
		}

		static long n_GetNativeEglContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.IEglBaseContext __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBaseContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NativeEglContext;
		}
#pragma warning restore 0169

		IntPtr id_getNativeEglContext;
		public unsafe long NativeEglContext {
			get {
				if (id_getNativeEglContext == IntPtr.Zero)
					id_getNativeEglContext = JNIEnv.GetMethodID (class_ref, "getNativeEglContext", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getNativeEglContext);
			}
		}

	}


	[Register ("org/webrtc/EglBase", DoNotGenerateAcw=true)]
	public abstract class EglBase : Java.Lang.Object {

		internal EglBase ()
		{
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']/field[@name='CONFIG_PIXEL_BUFFER']"
		[Register ("CONFIG_PIXEL_BUFFER")]
		public static IList<int> ConfigPixelBuffer {
			get {
				const string __id = "CONFIG_PIXEL_BUFFER.[I";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']/field[@name='CONFIG_PIXEL_RGBA_BUFFER']"
		[Register ("CONFIG_PIXEL_RGBA_BUFFER")]
		public static IList<int> ConfigPixelRgbaBuffer {
			get {
				const string __id = "CONFIG_PIXEL_RGBA_BUFFER.[I";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']/field[@name='CONFIG_PLAIN']"
		[Register ("CONFIG_PLAIN")]
		public static IList<int> ConfigPlain {
			get {
				const string __id = "CONFIG_PLAIN.[I";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']/field[@name='CONFIG_RECORDABLE']"
		[Register ("CONFIG_RECORDABLE")]
		public static IList<int> ConfigRecordable {
			get {
				const string __id = "CONFIG_RECORDABLE.[I";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']/field[@name='CONFIG_RGBA']"
		[Register ("CONFIG_RGBA")]
		public static IList<int> ConfigRgba {
			get {
				const string __id = "CONFIG_RGBA.[I";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']/field[@name='EGL_OPENGL_ES2_BIT']"
		[Register ("EGL_OPENGL_ES2_BIT")]
		public const int EglOpenglEs2Bit = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']/field[@name='EGL_OPENGL_ES3_BIT']"
		[Register ("EGL_OPENGL_ES3_BIT")]
		public const int EglOpenglEs3Bit = (int) 64;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']/field[@name='EGL_RECORDABLE_ANDROID']"
		[Register ("EGL_RECORDABLE_ANDROID")]
		public const int EglRecordableAndroid = (int) 12610;


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']/field[@name='lock']"
		[Register ("lock")]
		public static global::Java.Lang.Object Lock {
			get {
				const string __id = "lock.Ljava/lang/Object;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']/method[@name='configBuilder' and count(parameter)=0]"
		[Register ("configBuilder", "()Lorg/webrtc/EglBase$ConfigBuilder;", "")]
		public static unsafe global::Org.Webrtc.EglBaseConfigBuilder ConfigBuilder ()
		{
			const string __id = "configBuilder.()Lorg/webrtc/EglBase$ConfigBuilder;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglBaseConfigBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lorg/webrtc/EglBase;", "")]
		public static unsafe global::Org.Webrtc.IEglBase Create ()
		{
			const string __id = "create.()Lorg/webrtc/EglBase;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']/method[@name='create' and count(parameter)=1 and parameter[1][@type='org.webrtc.EglBase.Context']]"
		[Register ("create", "(Lorg/webrtc/EglBase$Context;)Lorg/webrtc/EglBase;", "")]
		public static unsafe global::Org.Webrtc.IEglBase Create (global::Org.Webrtc.IEglBaseContext sharedContext)
		{
			const string __id = "create.(Lorg/webrtc/EglBase$Context;)Lorg/webrtc/EglBase;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sharedContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sharedContext).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']/method[@name='create' and count(parameter)=2 and parameter[1][@type='org.webrtc.EglBase.Context'] and parameter[2][@type='int[]']]"
		[Register ("create", "(Lorg/webrtc/EglBase$Context;[I)Lorg/webrtc/EglBase;", "")]
		public static unsafe global::Org.Webrtc.IEglBase Create (global::Org.Webrtc.IEglBaseContext sharedContext, int[] configAttributes)
		{
			const string __id = "create.(Lorg/webrtc/EglBase$Context;[I)Lorg/webrtc/EglBase;";
			IntPtr native_configAttributes = JNIEnv.NewArray (configAttributes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((sharedContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sharedContext).Handle);
				__args [1] = new JniArgumentValue (native_configAttributes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (configAttributes != null) {
					JNIEnv.CopyArray (native_configAttributes, configAttributes);
					JNIEnv.DeleteLocalRef (native_configAttributes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']/method[@name='createEgl10' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("createEgl10", "([I)Lorg/webrtc/EglBase10;", "")]
		public static unsafe global::Org.Webrtc.IEglBase10 CreateEgl10 (int[] configAttributes)
		{
			const string __id = "createEgl10.([I)Lorg/webrtc/EglBase10;";
			IntPtr native_configAttributes = JNIEnv.NewArray (configAttributes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_configAttributes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase10> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (configAttributes != null) {
					JNIEnv.CopyArray (native_configAttributes, configAttributes);
					JNIEnv.DeleteLocalRef (native_configAttributes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']/method[@name='createEgl10' and count(parameter)=2 and parameter[1][@type='javax.microedition.khronos.egl.EGLContext'] and parameter[2][@type='int[]']]"
		[Register ("createEgl10", "(Ljavax/microedition/khronos/egl/EGLContext;[I)Lorg/webrtc/EglBase10;", "")]
		public static unsafe global::Org.Webrtc.IEglBase10 CreateEgl10 (global::Javax.Microedition.Khronos.Egl.EGLContext sharedContext, int[] configAttributes)
		{
			const string __id = "createEgl10.(Ljavax/microedition/khronos/egl/EGLContext;[I)Lorg/webrtc/EglBase10;";
			IntPtr native_configAttributes = JNIEnv.NewArray (configAttributes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((sharedContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sharedContext).Handle);
				__args [1] = new JniArgumentValue (native_configAttributes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase10> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (configAttributes != null) {
					JNIEnv.CopyArray (native_configAttributes, configAttributes);
					JNIEnv.DeleteLocalRef (native_configAttributes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']/method[@name='createEgl10' and count(parameter)=2 and parameter[1][@type='org.webrtc.EglBase10.Context'] and parameter[2][@type='int[]']]"
		[Register ("createEgl10", "(Lorg/webrtc/EglBase10$Context;[I)Lorg/webrtc/EglBase10;", "")]
		public static unsafe global::Org.Webrtc.IEglBase10 CreateEgl10 (global::Org.Webrtc.IEglBase10Context sharedContext, int[] configAttributes)
		{
			const string __id = "createEgl10.(Lorg/webrtc/EglBase10$Context;[I)Lorg/webrtc/EglBase10;";
			IntPtr native_configAttributes = JNIEnv.NewArray (configAttributes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((sharedContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sharedContext).Handle);
				__args [1] = new JniArgumentValue (native_configAttributes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase10> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (configAttributes != null) {
					JNIEnv.CopyArray (native_configAttributes, configAttributes);
					JNIEnv.DeleteLocalRef (native_configAttributes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']/method[@name='createEgl14' and count(parameter)=2 and parameter[1][@type='android.opengl.EGLContext'] and parameter[2][@type='int[]']]"
		[Register ("createEgl14", "(Landroid/opengl/EGLContext;[I)Lorg/webrtc/EglBase14;", "")]
		public static unsafe global::Org.Webrtc.IEglBase14 CreateEgl14 (global::Android.Opengl.EGLContext sharedContext, int[] configAttributes)
		{
			const string __id = "createEgl14.(Landroid/opengl/EGLContext;[I)Lorg/webrtc/EglBase14;";
			IntPtr native_configAttributes = JNIEnv.NewArray (configAttributes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((sharedContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sharedContext).Handle);
				__args [1] = new JniArgumentValue (native_configAttributes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase14> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (configAttributes != null) {
					JNIEnv.CopyArray (native_configAttributes, configAttributes);
					JNIEnv.DeleteLocalRef (native_configAttributes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']/method[@name='createEgl14' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("createEgl14", "([I)Lorg/webrtc/EglBase14;", "")]
		public static unsafe global::Org.Webrtc.IEglBase14 CreateEgl14 (int[] configAttributes)
		{
			const string __id = "createEgl14.([I)Lorg/webrtc/EglBase14;";
			IntPtr native_configAttributes = JNIEnv.NewArray (configAttributes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_configAttributes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase14> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (configAttributes != null) {
					JNIEnv.CopyArray (native_configAttributes, configAttributes);
					JNIEnv.DeleteLocalRef (native_configAttributes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']/method[@name='createEgl14' and count(parameter)=2 and parameter[1][@type='org.webrtc.EglBase14.Context'] and parameter[2][@type='int[]']]"
		[Register ("createEgl14", "(Lorg/webrtc/EglBase14$Context;[I)Lorg/webrtc/EglBase14;", "")]
		public static unsafe global::Org.Webrtc.IEglBase14 CreateEgl14 (global::Org.Webrtc.IEglBase14Context sharedContext, int[] configAttributes)
		{
			const string __id = "createEgl14.(Lorg/webrtc/EglBase14$Context;[I)Lorg/webrtc/EglBase14;";
			IntPtr native_configAttributes = JNIEnv.NewArray (configAttributes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((sharedContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sharedContext).Handle);
				__args [1] = new JniArgumentValue (native_configAttributes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase14> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (configAttributes != null) {
					JNIEnv.CopyArray (native_configAttributes, configAttributes);
					JNIEnv.DeleteLocalRef (native_configAttributes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']/method[@name='getOpenGlesVersionFromConfig' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("getOpenGlesVersionFromConfig", "([I)I", "")]
		public static unsafe int GetOpenGlesVersionFromConfig (int[] configAttributes)
		{
			const string __id = "getOpenGlesVersionFromConfig.([I)I";
			IntPtr native_configAttributes = JNIEnv.NewArray (configAttributes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_configAttributes);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (configAttributes != null) {
					JNIEnv.CopyArray (native_configAttributes, configAttributes);
					JNIEnv.DeleteLocalRef (native_configAttributes);
				}
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/EglBase", typeof (EglBase));
	}

	[Register ("org/webrtc/EglBase", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'EglBase' type. This type will be removed in a future release.", error: true)]
	public abstract class EglBaseConsts : EglBase {

		private EglBaseConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']"
	[Register ("org/webrtc/EglBase", "", "Org.Webrtc.IEglBaseInvoker")]
	public partial interface IEglBase : IJavaObject, IJavaPeerable {

		global::Org.Webrtc.IEglBaseContext EglBaseContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']/method[@name='getEglBaseContext' and count(parameter)=0]"
			[Register ("getEglBaseContext", "()Lorg/webrtc/EglBase$Context;", "GetGetEglBaseContextHandler:Org.Webrtc.IEglBaseInvoker, webrtc_android")] get;
		}

		bool HasSurface {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']/method[@name='hasSurface' and count(parameter)=0]"
			[Register ("hasSurface", "()Z", "GetHasSurfaceHandler:Org.Webrtc.IEglBaseInvoker, webrtc_android")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']/method[@name='createDummyPbufferSurface' and count(parameter)=0]"
		[Register ("createDummyPbufferSurface", "()V", "GetCreateDummyPbufferSurfaceHandler:Org.Webrtc.IEglBaseInvoker, webrtc_android")]
		void CreateDummyPbufferSurface ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']/method[@name='createPbufferSurface' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("createPbufferSurface", "(II)V", "GetCreatePbufferSurface_IIHandler:Org.Webrtc.IEglBaseInvoker, webrtc_android")]
		void CreatePbufferSurface (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']/method[@name='createSurface' and count(parameter)=1 and parameter[1][@type='android.graphics.SurfaceTexture']]"
		[Register ("createSurface", "(Landroid/graphics/SurfaceTexture;)V", "GetCreateSurface_Landroid_graphics_SurfaceTexture_Handler:Org.Webrtc.IEglBaseInvoker, webrtc_android")]
		void CreateSurface (global::Android.Graphics.SurfaceTexture p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']/method[@name='createSurface' and count(parameter)=1 and parameter[1][@type='android.view.Surface']]"
		[Register ("createSurface", "(Landroid/view/Surface;)V", "GetCreateSurface_Landroid_view_Surface_Handler:Org.Webrtc.IEglBaseInvoker, webrtc_android")]
		void CreateSurface (global::Android.Views.Surface p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']/method[@name='detachCurrent' and count(parameter)=0]"
		[Register ("detachCurrent", "()V", "GetDetachCurrentHandler:Org.Webrtc.IEglBaseInvoker, webrtc_android")]
		void DetachCurrent ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']/method[@name='makeCurrent' and count(parameter)=0]"
		[Register ("makeCurrent", "()V", "GetMakeCurrentHandler:Org.Webrtc.IEglBaseInvoker, webrtc_android")]
		void MakeCurrent ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler:Org.Webrtc.IEglBaseInvoker, webrtc_android")]
		void Release ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']/method[@name='releaseSurface' and count(parameter)=0]"
		[Register ("releaseSurface", "()V", "GetReleaseSurfaceHandler:Org.Webrtc.IEglBaseInvoker, webrtc_android")]
		void ReleaseSurface ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']/method[@name='surfaceHeight' and count(parameter)=0]"
		[Register ("surfaceHeight", "()I", "GetSurfaceHeightHandler:Org.Webrtc.IEglBaseInvoker, webrtc_android")]
		int SurfaceHeight ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']/method[@name='surfaceWidth' and count(parameter)=0]"
		[Register ("surfaceWidth", "()I", "GetSurfaceWidthHandler:Org.Webrtc.IEglBaseInvoker, webrtc_android")]
		int SurfaceWidth ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']/method[@name='swapBuffers' and count(parameter)=0]"
		[Register ("swapBuffers", "()V", "GetSwapBuffersHandler:Org.Webrtc.IEglBaseInvoker, webrtc_android")]
		void SwapBuffers ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='EglBase']/method[@name='swapBuffers' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("swapBuffers", "(J)V", "GetSwapBuffers_JHandler:Org.Webrtc.IEglBaseInvoker, webrtc_android")]
		void SwapBuffers (long p0);

	}

	[global::Android.Runtime.Register ("org/webrtc/EglBase", DoNotGenerateAcw=true)]
	internal partial class IEglBaseInvoker : global::Java.Lang.Object, IEglBase {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/EglBase", typeof (IEglBaseInvoker));

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

		public static IEglBase GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEglBase> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.EglBase"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEglBaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getEglBaseContext;
#pragma warning disable 0169
		static Delegate GetGetEglBaseContextHandler ()
		{
			if (cb_getEglBaseContext == null)
				cb_getEglBaseContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEglBaseContext);
			return cb_getEglBaseContext;
		}

		static IntPtr n_GetEglBaseContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.IEglBase __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EglBaseContext);
		}
#pragma warning restore 0169

		IntPtr id_getEglBaseContext;
		public unsafe global::Org.Webrtc.IEglBaseContext EglBaseContext {
			get {
				if (id_getEglBaseContext == IntPtr.Zero)
					id_getEglBaseContext = JNIEnv.GetMethodID (class_ref, "getEglBaseContext", "()Lorg/webrtc/EglBase$Context;");
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBaseContext> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEglBaseContext), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_hasSurface;
#pragma warning disable 0169
		static Delegate GetHasSurfaceHandler ()
		{
			if (cb_hasSurface == null)
				cb_hasSurface = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasSurface);
			return cb_hasSurface;
		}

		static bool n_HasSurface (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.IEglBase __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasSurface;
		}
#pragma warning restore 0169

		IntPtr id_hasSurface;
		public unsafe bool HasSurface {
			get {
				if (id_hasSurface == IntPtr.Zero)
					id_hasSurface = JNIEnv.GetMethodID (class_ref, "hasSurface", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasSurface);
			}
		}

		static Delegate cb_createDummyPbufferSurface;
#pragma warning disable 0169
		static Delegate GetCreateDummyPbufferSurfaceHandler ()
		{
			if (cb_createDummyPbufferSurface == null)
				cb_createDummyPbufferSurface = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CreateDummyPbufferSurface);
			return cb_createDummyPbufferSurface;
		}

		static void n_CreateDummyPbufferSurface (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.IEglBase __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CreateDummyPbufferSurface ();
		}
#pragma warning restore 0169

		IntPtr id_createDummyPbufferSurface;
		public unsafe void CreateDummyPbufferSurface ()
		{
			if (id_createDummyPbufferSurface == IntPtr.Zero)
				id_createDummyPbufferSurface = JNIEnv.GetMethodID (class_ref, "createDummyPbufferSurface", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createDummyPbufferSurface);
		}

		static Delegate cb_createPbufferSurface_II;
#pragma warning disable 0169
		static Delegate GetCreatePbufferSurface_IIHandler ()
		{
			if (cb_createPbufferSurface_II == null)
				cb_createPbufferSurface_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_CreatePbufferSurface_II);
			return cb_createPbufferSurface_II;
		}

		static void n_CreatePbufferSurface_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Org.Webrtc.IEglBase __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CreatePbufferSurface (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_createPbufferSurface_II;
		public unsafe void CreatePbufferSurface (int p0, int p1)
		{
			if (id_createPbufferSurface_II == IntPtr.Zero)
				id_createPbufferSurface_II = JNIEnv.GetMethodID (class_ref, "createPbufferSurface", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createPbufferSurface_II, __args);
		}

		static Delegate cb_createSurface_Landroid_graphics_SurfaceTexture_;
#pragma warning disable 0169
		static Delegate GetCreateSurface_Landroid_graphics_SurfaceTexture_Handler ()
		{
			if (cb_createSurface_Landroid_graphics_SurfaceTexture_ == null)
				cb_createSurface_Landroid_graphics_SurfaceTexture_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CreateSurface_Landroid_graphics_SurfaceTexture_);
			return cb_createSurface_Landroid_graphics_SurfaceTexture_;
		}

		static void n_CreateSurface_Landroid_graphics_SurfaceTexture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.IEglBase __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.SurfaceTexture p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CreateSurface (p0);
		}
#pragma warning restore 0169

		IntPtr id_createSurface_Landroid_graphics_SurfaceTexture_;
		public unsafe void CreateSurface (global::Android.Graphics.SurfaceTexture p0)
		{
			if (id_createSurface_Landroid_graphics_SurfaceTexture_ == IntPtr.Zero)
				id_createSurface_Landroid_graphics_SurfaceTexture_ = JNIEnv.GetMethodID (class_ref, "createSurface", "(Landroid/graphics/SurfaceTexture;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createSurface_Landroid_graphics_SurfaceTexture_, __args);
		}

		static Delegate cb_createSurface_Landroid_view_Surface_;
#pragma warning disable 0169
		static Delegate GetCreateSurface_Landroid_view_Surface_Handler ()
		{
			if (cb_createSurface_Landroid_view_Surface_ == null)
				cb_createSurface_Landroid_view_Surface_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CreateSurface_Landroid_view_Surface_);
			return cb_createSurface_Landroid_view_Surface_;
		}

		static void n_CreateSurface_Landroid_view_Surface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.IEglBase __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Surface p0 = global::Java.Lang.Object.GetObject<global::Android.Views.Surface> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CreateSurface (p0);
		}
#pragma warning restore 0169

		IntPtr id_createSurface_Landroid_view_Surface_;
		public unsafe void CreateSurface (global::Android.Views.Surface p0)
		{
			if (id_createSurface_Landroid_view_Surface_ == IntPtr.Zero)
				id_createSurface_Landroid_view_Surface_ = JNIEnv.GetMethodID (class_ref, "createSurface", "(Landroid/view/Surface;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createSurface_Landroid_view_Surface_, __args);
		}

		static Delegate cb_detachCurrent;
#pragma warning disable 0169
		static Delegate GetDetachCurrentHandler ()
		{
			if (cb_detachCurrent == null)
				cb_detachCurrent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DetachCurrent);
			return cb_detachCurrent;
		}

		static void n_DetachCurrent (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.IEglBase __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DetachCurrent ();
		}
#pragma warning restore 0169

		IntPtr id_detachCurrent;
		public unsafe void DetachCurrent ()
		{
			if (id_detachCurrent == IntPtr.Zero)
				id_detachCurrent = JNIEnv.GetMethodID (class_ref, "detachCurrent", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_detachCurrent);
		}

		static Delegate cb_makeCurrent;
#pragma warning disable 0169
		static Delegate GetMakeCurrentHandler ()
		{
			if (cb_makeCurrent == null)
				cb_makeCurrent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_MakeCurrent);
			return cb_makeCurrent;
		}

		static void n_MakeCurrent (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.IEglBase __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MakeCurrent ();
		}
#pragma warning restore 0169

		IntPtr id_makeCurrent;
		public unsafe void MakeCurrent ()
		{
			if (id_makeCurrent == IntPtr.Zero)
				id_makeCurrent = JNIEnv.GetMethodID (class_ref, "makeCurrent", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_makeCurrent);
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
			global::Org.Webrtc.IEglBase __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		IntPtr id_release;
		public unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
		}

		static Delegate cb_releaseSurface;
#pragma warning disable 0169
		static Delegate GetReleaseSurfaceHandler ()
		{
			if (cb_releaseSurface == null)
				cb_releaseSurface = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReleaseSurface);
			return cb_releaseSurface;
		}

		static void n_ReleaseSurface (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.IEglBase __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseSurface ();
		}
#pragma warning restore 0169

		IntPtr id_releaseSurface;
		public unsafe void ReleaseSurface ()
		{
			if (id_releaseSurface == IntPtr.Zero)
				id_releaseSurface = JNIEnv.GetMethodID (class_ref, "releaseSurface", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_releaseSurface);
		}

		static Delegate cb_surfaceHeight;
#pragma warning disable 0169
		static Delegate GetSurfaceHeightHandler ()
		{
			if (cb_surfaceHeight == null)
				cb_surfaceHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_SurfaceHeight);
			return cb_surfaceHeight;
		}

		static int n_SurfaceHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.IEglBase __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SurfaceHeight ();
		}
#pragma warning restore 0169

		IntPtr id_surfaceHeight;
		public unsafe int SurfaceHeight ()
		{
			if (id_surfaceHeight == IntPtr.Zero)
				id_surfaceHeight = JNIEnv.GetMethodID (class_ref, "surfaceHeight", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_surfaceHeight);
		}

		static Delegate cb_surfaceWidth;
#pragma warning disable 0169
		static Delegate GetSurfaceWidthHandler ()
		{
			if (cb_surfaceWidth == null)
				cb_surfaceWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_SurfaceWidth);
			return cb_surfaceWidth;
		}

		static int n_SurfaceWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.IEglBase __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SurfaceWidth ();
		}
#pragma warning restore 0169

		IntPtr id_surfaceWidth;
		public unsafe int SurfaceWidth ()
		{
			if (id_surfaceWidth == IntPtr.Zero)
				id_surfaceWidth = JNIEnv.GetMethodID (class_ref, "surfaceWidth", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_surfaceWidth);
		}

		static Delegate cb_swapBuffers;
#pragma warning disable 0169
		static Delegate GetSwapBuffersHandler ()
		{
			if (cb_swapBuffers == null)
				cb_swapBuffers = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SwapBuffers);
			return cb_swapBuffers;
		}

		static void n_SwapBuffers (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.IEglBase __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SwapBuffers ();
		}
#pragma warning restore 0169

		IntPtr id_swapBuffers;
		public unsafe void SwapBuffers ()
		{
			if (id_swapBuffers == IntPtr.Zero)
				id_swapBuffers = JNIEnv.GetMethodID (class_ref, "swapBuffers", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_swapBuffers);
		}

		static Delegate cb_swapBuffers_J;
#pragma warning disable 0169
		static Delegate GetSwapBuffers_JHandler ()
		{
			if (cb_swapBuffers_J == null)
				cb_swapBuffers_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SwapBuffers_J);
			return cb_swapBuffers_J;
		}

		static void n_SwapBuffers_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Org.Webrtc.IEglBase __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SwapBuffers (p0);
		}
#pragma warning restore 0169

		IntPtr id_swapBuffers_J;
		public unsafe void SwapBuffers (long p0)
		{
			if (id_swapBuffers_J == IntPtr.Zero)
				id_swapBuffers_J = JNIEnv.GetMethodID (class_ref, "swapBuffers", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_swapBuffers_J, __args);
		}

	}

}
