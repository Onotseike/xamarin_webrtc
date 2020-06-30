using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='GlRectDrawer']"
	[global::Android.Runtime.Register ("org/webrtc/GlRectDrawer", DoNotGenerateAcw=true)]
	public partial class GlRectDrawer : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/GlRectDrawer", typeof (GlRectDrawer));
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

		protected GlRectDrawer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='GlRectDrawer']/constructor[@name='GlRectDrawer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GlRectDrawer ()
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
			global::Org.Webrtc.GlRectDrawer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.GlRectDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p1 = (float[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.DrawOes (p0, p1, p2, p3, p4, p5, p6, p7);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='GlRectDrawer']/method[@name='drawOes' and count(parameter)=8 and parameter[1][@type='int'] and parameter[2][@type='float[]'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int']]"
		[Register ("drawOes", "(I[FIIIIII)V", "GetDrawOes_IarrayFIIIIIIHandler")]
		public virtual unsafe void DrawOes (int p0, float[] p1, int p2, int p3, int p4, int p5, int p6, int p7)
		{
			const string __id = "drawOes.(I[FIIIIII)V";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (p5);
				__args [6] = new JniArgumentValue (p6);
				__args [7] = new JniArgumentValue (p7);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
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
			global::Org.Webrtc.GlRectDrawer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.GlRectDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p1 = (float[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.DrawRgb (p0, p1, p2, p3, p4, p5, p6, p7);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='GlRectDrawer']/method[@name='drawRgb' and count(parameter)=8 and parameter[1][@type='int'] and parameter[2][@type='float[]'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int']]"
		[Register ("drawRgb", "(I[FIIIIII)V", "GetDrawRgb_IarrayFIIIIIIHandler")]
		public virtual unsafe void DrawRgb (int p0, float[] p1, int p2, int p3, int p4, int p5, int p6, int p7)
		{
			const string __id = "drawRgb.(I[FIIIIII)V";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (p5);
				__args [6] = new JniArgumentValue (p6);
				__args [7] = new JniArgumentValue (p7);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
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
			global::Org.Webrtc.GlRectDrawer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.GlRectDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			float[] p1 = (float[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.DrawYuv (p0, p1, p2, p3, p4, p5, p6, p7);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='GlRectDrawer']/method[@name='drawYuv' and count(parameter)=8 and parameter[1][@type='int[]'] and parameter[2][@type='float[]'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int']]"
		[Register ("drawYuv", "([I[FIIIIII)V", "GetDrawYuv_arrayIarrayFIIIIIIHandler")]
		public virtual unsafe void DrawYuv (int[] p0, float[] p1, int p2, int p3, int p4, int p5, int p6, int p7)
		{
			const string __id = "drawYuv.([I[FIIIIII)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (p5);
				__args [6] = new JniArgumentValue (p6);
				__args [7] = new JniArgumentValue (p7);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
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
			global::Org.Webrtc.GlRectDrawer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.GlRectDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='GlRectDrawer']/method[@name='release' and count(parameter)=0]"
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
