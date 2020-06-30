using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='RefCounted']"
	[Register ("org/webrtc/RefCounted", "", "Org.Webrtc.IRefCountedInvoker")]
	public partial interface IRefCounted : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='RefCounted']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler:Org.Webrtc.IRefCountedInvoker, webrtc_android")]
		void Release ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='RefCounted']/method[@name='retain' and count(parameter)=0]"
		[Register ("retain", "()V", "GetRetainHandler:Org.Webrtc.IRefCountedInvoker, webrtc_android")]
		void Retain ();

	}

	[global::Android.Runtime.Register ("org/webrtc/RefCounted", DoNotGenerateAcw=true)]
	internal partial class IRefCountedInvoker : global::Java.Lang.Object, IRefCounted {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/RefCounted", typeof (IRefCountedInvoker));

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

		public static IRefCounted GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRefCounted> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.RefCounted"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRefCountedInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Org.Webrtc.IRefCounted __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IRefCounted> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Webrtc.IRefCounted __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IRefCounted> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Retain ();
		}
#pragma warning restore 0169

		IntPtr id_retain;
		public unsafe void Retain ()
		{
			if (id_retain == IntPtr.Zero)
				id_retain = JNIEnv.GetMethodID (class_ref, "retain", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_retain);
		}

	}

}
