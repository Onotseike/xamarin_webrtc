using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='RendererCommon']"
	[global::Android.Runtime.Register ("org/webrtc/RendererCommon", DoNotGenerateAcw=true)]
	public partial class RendererCommon : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='RendererCommon.GlDrawer']"
		[Register ("org/webrtc/RendererCommon$GlDrawer", "", "Org.Webrtc.RendererCommon/IGlDrawerInvoker")]
		public partial interface IGlDrawer : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='RendererCommon.GlDrawer']/method[@name='drawOes' and count(parameter)=8 and parameter[1][@type='int'] and parameter[2][@type='float[]'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int']]"
			[Register ("drawOes", "(I[FIIIIII)V", "GetDrawOes_IarrayFIIIIIIHandler:Org.Webrtc.RendererCommon/IGlDrawerInvoker, webrtc_android")]
			void DrawOes (int p0, float[] p1, int p2, int p3, int p4, int p5, int p6, int p7);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='RendererCommon.GlDrawer']/method[@name='drawRgb' and count(parameter)=8 and parameter[1][@type='int'] and parameter[2][@type='float[]'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int']]"
			[Register ("drawRgb", "(I[FIIIIII)V", "GetDrawRgb_IarrayFIIIIIIHandler:Org.Webrtc.RendererCommon/IGlDrawerInvoker, webrtc_android")]
			void DrawRgb (int p0, float[] p1, int p2, int p3, int p4, int p5, int p6, int p7);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='RendererCommon.GlDrawer']/method[@name='drawYuv' and count(parameter)=8 and parameter[1][@type='int[]'] and parameter[2][@type='float[]'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int']]"
			[Register ("drawYuv", "([I[FIIIIII)V", "GetDrawYuv_arrayIarrayFIIIIIIHandler:Org.Webrtc.RendererCommon/IGlDrawerInvoker, webrtc_android")]
			void DrawYuv (int[] p0, float[] p1, int p2, int p3, int p4, int p5, int p6, int p7);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='RendererCommon.GlDrawer']/method[@name='release' and count(parameter)=0]"
			[Register ("release", "()V", "GetReleaseHandler:Org.Webrtc.RendererCommon/IGlDrawerInvoker, webrtc_android")]
			void Release ();

		}

		[global::Android.Runtime.Register ("org/webrtc/RendererCommon$GlDrawer", DoNotGenerateAcw=true)]
		internal partial class IGlDrawerInvoker : global::Java.Lang.Object, IGlDrawer {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/RendererCommon$GlDrawer", typeof (IGlDrawerInvoker));

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

			public static IGlDrawer GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IGlDrawer> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.RendererCommon.GlDrawer"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IGlDrawerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_drawOes_IarrayFIIIIII;
#pragma warning disable 0169
			static Delegate GetDrawOes_IarrayFIIIIIIHandler ()
			{
				if (cb_drawOes_IarrayFIIIIII == null)
					cb_drawOes_IarrayFIIIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, int, int, int, int, int, int>) n_DrawOes_IarrayFIIIIII);
				return cb_drawOes_IarrayFIIIIII;
			}

			static void n_DrawOes_IarrayFIIIIII (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2, int p3, int p4, int p5, int p6, int p7)
			{
				global::Org.Webrtc.RendererCommon.IGlDrawer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RendererCommon.IGlDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				float[] p1 = (float[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (float));
				__this.DrawOes (p0, p1, p2, p3, p4, p5, p6, p7);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
			}
#pragma warning restore 0169

			IntPtr id_drawOes_IarrayFIIIIII;
			public unsafe void DrawOes (int p0, float[] p1, int p2, int p3, int p4, int p5, int p6, int p7)
			{
				if (id_drawOes_IarrayFIIIIII == IntPtr.Zero)
					id_drawOes_IarrayFIIIIII = JNIEnv.GetMethodID (class_ref, "drawOes", "(I[FIIIIII)V");
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_drawOes_IarrayFIIIIII, __args);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_drawRgb_IarrayFIIIIII;
#pragma warning disable 0169
			static Delegate GetDrawRgb_IarrayFIIIIIIHandler ()
			{
				if (cb_drawRgb_IarrayFIIIIII == null)
					cb_drawRgb_IarrayFIIIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, int, int, int, int, int, int>) n_DrawRgb_IarrayFIIIIII);
				return cb_drawRgb_IarrayFIIIIII;
			}

			static void n_DrawRgb_IarrayFIIIIII (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2, int p3, int p4, int p5, int p6, int p7)
			{
				global::Org.Webrtc.RendererCommon.IGlDrawer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RendererCommon.IGlDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				float[] p1 = (float[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (float));
				__this.DrawRgb (p0, p1, p2, p3, p4, p5, p6, p7);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
			}
#pragma warning restore 0169

			IntPtr id_drawRgb_IarrayFIIIIII;
			public unsafe void DrawRgb (int p0, float[] p1, int p2, int p3, int p4, int p5, int p6, int p7)
			{
				if (id_drawRgb_IarrayFIIIIII == IntPtr.Zero)
					id_drawRgb_IarrayFIIIIII = JNIEnv.GetMethodID (class_ref, "drawRgb", "(I[FIIIIII)V");
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_drawRgb_IarrayFIIIIII, __args);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_drawYuv_arrayIarrayFIIIIII;
#pragma warning disable 0169
			static Delegate GetDrawYuv_arrayIarrayFIIIIIIHandler ()
			{
				if (cb_drawYuv_arrayIarrayFIIIIII == null)
					cb_drawYuv_arrayIarrayFIIIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, int, int, int>) n_DrawYuv_arrayIarrayFIIIIII);
				return cb_drawYuv_arrayIarrayFIIIIII;
			}

			static void n_DrawYuv_arrayIarrayFIIIIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3, int p4, int p5, int p6, int p7)
			{
				global::Org.Webrtc.RendererCommon.IGlDrawer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RendererCommon.IGlDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
				float[] p1 = (float[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (float));
				__this.DrawYuv (p0, p1, p2, p3, p4, p5, p6, p7);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
			}
#pragma warning restore 0169

			IntPtr id_drawYuv_arrayIarrayFIIIIII;
			public unsafe void DrawYuv (int[] p0, float[] p1, int p2, int p3, int p4, int p5, int p6, int p7)
			{
				if (id_drawYuv_arrayIarrayFIIIIII == IntPtr.Zero)
					id_drawYuv_arrayIarrayFIIIIII = JNIEnv.GetMethodID (class_ref, "drawYuv", "([I[FIIIIII)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_drawYuv_arrayIarrayFIIIIII, __args);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
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
				global::Org.Webrtc.RendererCommon.IGlDrawer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RendererCommon.IGlDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='RendererCommon.RendererEvents']"
		[Register ("org/webrtc/RendererCommon$RendererEvents", "", "Org.Webrtc.RendererCommon/IRendererEventsInvoker")]
		public partial interface IRendererEvents : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='RendererCommon.RendererEvents']/method[@name='onFirstFrameRendered' and count(parameter)=0]"
			[Register ("onFirstFrameRendered", "()V", "GetOnFirstFrameRenderedHandler:Org.Webrtc.RendererCommon/IRendererEventsInvoker, webrtc_android")]
			void OnFirstFrameRendered ();

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='RendererCommon.RendererEvents']/method[@name='onFrameResolutionChanged' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onFrameResolutionChanged", "(III)V", "GetOnFrameResolutionChanged_IIIHandler:Org.Webrtc.RendererCommon/IRendererEventsInvoker, webrtc_android")]
			void OnFrameResolutionChanged (int p0, int p1, int p2);

		}

		[global::Android.Runtime.Register ("org/webrtc/RendererCommon$RendererEvents", DoNotGenerateAcw=true)]
		internal partial class IRendererEventsInvoker : global::Java.Lang.Object, IRendererEvents {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/RendererCommon$RendererEvents", typeof (IRendererEventsInvoker));

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

			public static IRendererEvents GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRendererEvents> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.RendererCommon.RendererEvents"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRendererEventsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
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
				global::Org.Webrtc.RendererCommon.IRendererEvents __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RendererCommon.IRendererEvents> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnFirstFrameRendered ();
			}
#pragma warning restore 0169

			IntPtr id_onFirstFrameRendered;
			public unsafe void OnFirstFrameRendered ()
			{
				if (id_onFirstFrameRendered == IntPtr.Zero)
					id_onFirstFrameRendered = JNIEnv.GetMethodID (class_ref, "onFirstFrameRendered", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFirstFrameRendered);
			}

			static Delegate cb_onFrameResolutionChanged_III;
#pragma warning disable 0169
			static Delegate GetOnFrameResolutionChanged_IIIHandler ()
			{
				if (cb_onFrameResolutionChanged_III == null)
					cb_onFrameResolutionChanged_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_OnFrameResolutionChanged_III);
				return cb_onFrameResolutionChanged_III;
			}

			static void n_OnFrameResolutionChanged_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
			{
				global::Org.Webrtc.RendererCommon.IRendererEvents __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RendererCommon.IRendererEvents> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnFrameResolutionChanged (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onFrameResolutionChanged_III;
			public unsafe void OnFrameResolutionChanged (int p0, int p1, int p2)
			{
				if (id_onFrameResolutionChanged_III == IntPtr.Zero)
					id_onFrameResolutionChanged_III = JNIEnv.GetMethodID (class_ref, "onFrameResolutionChanged", "(III)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFrameResolutionChanged_III, __args);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='RendererCommon.ScalingType']"
		[global::Android.Runtime.Register ("org/webrtc/RendererCommon$ScalingType", DoNotGenerateAcw=true)]
		public sealed partial class ScalingType : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='RendererCommon.ScalingType']/field[@name='SCALE_ASPECT_BALANCED']"
			[Register ("SCALE_ASPECT_BALANCED")]
			public static global::Org.Webrtc.RendererCommon.ScalingType ScaleAspectBalanced {
				get {
					const string __id = "SCALE_ASPECT_BALANCED.Lorg/webrtc/RendererCommon$ScalingType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.RendererCommon.ScalingType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='RendererCommon.ScalingType']/field[@name='SCALE_ASPECT_FILL']"
			[Register ("SCALE_ASPECT_FILL")]
			public static global::Org.Webrtc.RendererCommon.ScalingType ScaleAspectFill {
				get {
					const string __id = "SCALE_ASPECT_FILL.Lorg/webrtc/RendererCommon$ScalingType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.RendererCommon.ScalingType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='RendererCommon.ScalingType']/field[@name='SCALE_ASPECT_FIT']"
			[Register ("SCALE_ASPECT_FIT")]
			public static global::Org.Webrtc.RendererCommon.ScalingType ScaleAspectFit {
				get {
					const string __id = "SCALE_ASPECT_FIT.Lorg/webrtc/RendererCommon$ScalingType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.RendererCommon.ScalingType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/RendererCommon$ScalingType", typeof (ScalingType));
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

			internal ScalingType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RendererCommon.ScalingType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/RendererCommon$ScalingType;", "")]
			public static unsafe global::Org.Webrtc.RendererCommon.ScalingType ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/webrtc/RendererCommon$ScalingType;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.RendererCommon.ScalingType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RendererCommon.ScalingType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/RendererCommon$ScalingType;", "")]
			public static unsafe global::Org.Webrtc.RendererCommon.ScalingType[] Values ()
			{
				const string __id = "values.()[Lorg/webrtc/RendererCommon$ScalingType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Webrtc.RendererCommon.ScalingType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.RendererCommon.ScalingType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='RendererCommon.VideoLayoutMeasure']"
		[global::Android.Runtime.Register ("org/webrtc/RendererCommon$VideoLayoutMeasure", DoNotGenerateAcw=true)]
		public partial class VideoLayoutMeasure : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/RendererCommon$VideoLayoutMeasure", typeof (VideoLayoutMeasure));
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

			protected VideoLayoutMeasure (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='RendererCommon.VideoLayoutMeasure']/constructor[@name='RendererCommon.VideoLayoutMeasure' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe VideoLayoutMeasure ()
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

			static Delegate cb_measure_IIII;
#pragma warning disable 0169
			static Delegate GetMeasure_IIIIHandler ()
			{
				if (cb_measure_IIII == null)
					cb_measure_IIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, int, IntPtr>) n_Measure_IIII);
				return cb_measure_IIII;
			}

			static IntPtr n_Measure_IIII (IntPtr jnienv, IntPtr native__this, int widthSpec, int heightSpec, int frameWidth, int frameHeight)
			{
				global::Org.Webrtc.RendererCommon.VideoLayoutMeasure __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RendererCommon.VideoLayoutMeasure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Measure (widthSpec, heightSpec, frameWidth, frameHeight));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RendererCommon.VideoLayoutMeasure']/method[@name='measure' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("measure", "(IIII)Landroid/graphics/Point;", "GetMeasure_IIIIHandler")]
			public virtual unsafe global::Android.Graphics.Point Measure (int widthSpec, int heightSpec, int frameWidth, int frameHeight)
			{
				const string __id = "measure.(IIII)Landroid/graphics/Point;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (widthSpec);
					__args [1] = new JniArgumentValue (heightSpec);
					__args [2] = new JniArgumentValue (frameWidth);
					__args [3] = new JniArgumentValue (frameHeight);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				global::Org.Webrtc.RendererCommon.VideoLayoutMeasure __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RendererCommon.VideoLayoutMeasure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.RendererCommon.ScalingType scalingType = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RendererCommon.ScalingType> (native_scalingType, JniHandleOwnership.DoNotTransfer);
				__this.SetScalingType (scalingType);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RendererCommon.VideoLayoutMeasure']/method[@name='setScalingType' and count(parameter)=1 and parameter[1][@type='org.webrtc.RendererCommon.ScalingType']]"
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
				global::Org.Webrtc.RendererCommon.VideoLayoutMeasure __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RendererCommon.VideoLayoutMeasure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.RendererCommon.ScalingType scalingTypeMatchOrientation = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RendererCommon.ScalingType> (native_scalingTypeMatchOrientation, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.RendererCommon.ScalingType scalingTypeMismatchOrientation = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RendererCommon.ScalingType> (native_scalingTypeMismatchOrientation, JniHandleOwnership.DoNotTransfer);
				__this.SetScalingType (scalingTypeMatchOrientation, scalingTypeMismatchOrientation);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RendererCommon.VideoLayoutMeasure']/method[@name='setScalingType' and count(parameter)=2 and parameter[1][@type='org.webrtc.RendererCommon.ScalingType'] and parameter[2][@type='org.webrtc.RendererCommon.ScalingType']]"
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

			static Delegate cb_setVisibleFraction_FF;
#pragma warning disable 0169
			static Delegate GetSetVisibleFraction_FFHandler ()
			{
				if (cb_setVisibleFraction_FF == null)
					cb_setVisibleFraction_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_SetVisibleFraction_FF);
				return cb_setVisibleFraction_FF;
			}

			static void n_SetVisibleFraction_FF (IntPtr jnienv, IntPtr native__this, float visibleFractionMatchOrientation, float visibleFractionMismatchOrientation)
			{
				global::Org.Webrtc.RendererCommon.VideoLayoutMeasure __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RendererCommon.VideoLayoutMeasure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetVisibleFraction (visibleFractionMatchOrientation, visibleFractionMismatchOrientation);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RendererCommon.VideoLayoutMeasure']/method[@name='setVisibleFraction' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
			[Register ("setVisibleFraction", "(FF)V", "GetSetVisibleFraction_FFHandler")]
			public virtual unsafe void SetVisibleFraction (float visibleFractionMatchOrientation, float visibleFractionMismatchOrientation)
			{
				const string __id = "setVisibleFraction.(FF)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (visibleFractionMatchOrientation);
					__args [1] = new JniArgumentValue (visibleFractionMismatchOrientation);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/RendererCommon", typeof (RendererCommon));
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

		protected RendererCommon (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='RendererCommon']/constructor[@name='RendererCommon' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RendererCommon ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RendererCommon']/method[@name='convertMatrixFromAndroidGraphicsMatrix' and count(parameter)=1 and parameter[1][@type='android.graphics.Matrix']]"
		[Register ("convertMatrixFromAndroidGraphicsMatrix", "(Landroid/graphics/Matrix;)[F", "")]
		public static unsafe float[] ConvertMatrixFromAndroidGraphicsMatrix (global::Android.Graphics.Matrix matrix)
		{
			const string __id = "convertMatrixFromAndroidGraphicsMatrix.(Landroid/graphics/Matrix;)[F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((matrix == null) ? IntPtr.Zero : ((global::Java.Lang.Object) matrix).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RendererCommon']/method[@name='convertMatrixToAndroidGraphicsMatrix' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("convertMatrixToAndroidGraphicsMatrix", "([F)Landroid/graphics/Matrix;", "")]
		public static unsafe global::Android.Graphics.Matrix ConvertMatrixToAndroidGraphicsMatrix (float[] matrix4x4)
		{
			const string __id = "convertMatrixToAndroidGraphicsMatrix.([F)Landroid/graphics/Matrix;";
			IntPtr native_matrix4x4 = JNIEnv.NewArray (matrix4x4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_matrix4x4);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (matrix4x4 != null) {
					JNIEnv.CopyArray (native_matrix4x4, matrix4x4);
					JNIEnv.DeleteLocalRef (native_matrix4x4);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RendererCommon']/method[@name='getDisplaySize' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("getDisplaySize", "(FFII)Landroid/graphics/Point;", "")]
		public static unsafe global::Android.Graphics.Point GetDisplaySize (float minVisibleFraction, float videoAspectRatio, int maxDisplayWidth, int maxDisplayHeight)
		{
			const string __id = "getDisplaySize.(FFII)Landroid/graphics/Point;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (minVisibleFraction);
				__args [1] = new JniArgumentValue (videoAspectRatio);
				__args [2] = new JniArgumentValue (maxDisplayWidth);
				__args [3] = new JniArgumentValue (maxDisplayHeight);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RendererCommon']/method[@name='getDisplaySize' and count(parameter)=4 and parameter[1][@type='org.webrtc.RendererCommon.ScalingType'] and parameter[2][@type='float'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("getDisplaySize", "(Lorg/webrtc/RendererCommon$ScalingType;FII)Landroid/graphics/Point;", "")]
		public static unsafe global::Android.Graphics.Point GetDisplaySize (global::Org.Webrtc.RendererCommon.ScalingType scalingType, float videoAspectRatio, int maxDisplayWidth, int maxDisplayHeight)
		{
			const string __id = "getDisplaySize.(Lorg/webrtc/RendererCommon$ScalingType;FII)Landroid/graphics/Point;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((scalingType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scalingType).Handle);
				__args [1] = new JniArgumentValue (videoAspectRatio);
				__args [2] = new JniArgumentValue (maxDisplayWidth);
				__args [3] = new JniArgumentValue (maxDisplayHeight);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RendererCommon']/method[@name='getLayoutMatrix' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("getLayoutMatrix", "(ZFF)[F", "")]
		public static unsafe float[] GetLayoutMatrix (bool mirror, float videoAspectRatio, float displayAspectRatio)
		{
			const string __id = "getLayoutMatrix.(ZFF)[F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (mirror);
				__args [1] = new JniArgumentValue (videoAspectRatio);
				__args [2] = new JniArgumentValue (displayAspectRatio);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

	}
}
