using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='NativePeerConnectionFactory']"
	[Register ("org/webrtc/NativePeerConnectionFactory", "", "Org.Webrtc.INativePeerConnectionFactoryInvoker")]
	public partial interface INativePeerConnectionFactory : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='NativePeerConnectionFactory']/method[@name='createNativePeerConnection' and count(parameter)=0]"
		[Register ("createNativePeerConnection", "()J", "GetCreateNativePeerConnectionHandler:Org.Webrtc.INativePeerConnectionFactoryInvoker, webrtc_android")]
		long CreateNativePeerConnection ();

	}

	[global::Android.Runtime.Register ("org/webrtc/NativePeerConnectionFactory", DoNotGenerateAcw=true)]
	internal partial class INativePeerConnectionFactoryInvoker : global::Java.Lang.Object, INativePeerConnectionFactory {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/NativePeerConnectionFactory", typeof (INativePeerConnectionFactoryInvoker));

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

		public static INativePeerConnectionFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INativePeerConnectionFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.NativePeerConnectionFactory"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INativePeerConnectionFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_createNativePeerConnection;
#pragma warning disable 0169
		static Delegate GetCreateNativePeerConnectionHandler ()
		{
			if (cb_createNativePeerConnection == null)
				cb_createNativePeerConnection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_CreateNativePeerConnection);
			return cb_createNativePeerConnection;
		}

		static long n_CreateNativePeerConnection (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.INativePeerConnectionFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.INativePeerConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CreateNativePeerConnection ();
		}
#pragma warning restore 0169

		IntPtr id_createNativePeerConnection;
		public unsafe long CreateNativePeerConnection ()
		{
			if (id_createNativePeerConnection == IntPtr.Zero)
				id_createNativePeerConnection = JNIEnv.GetMethodID (class_ref, "createNativePeerConnection", "()J");
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_createNativePeerConnection);
		}

	}

}
