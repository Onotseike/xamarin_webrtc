using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='FecControllerFactoryFactoryInterface']"
	[Register ("org/webrtc/FecControllerFactoryFactoryInterface", "", "Org.Webrtc.IFecControllerFactoryFactoryInterfaceInvoker")]
	public partial interface IFecControllerFactoryFactoryInterface : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='FecControllerFactoryFactoryInterface']/method[@name='createNative' and count(parameter)=0]"
		[Register ("createNative", "()J", "GetCreateNativeHandler:Org.Webrtc.IFecControllerFactoryFactoryInterfaceInvoker, webrtc_android")]
		long CreateNative ();

	}

	[global::Android.Runtime.Register ("org/webrtc/FecControllerFactoryFactoryInterface", DoNotGenerateAcw=true)]
	internal partial class IFecControllerFactoryFactoryInterfaceInvoker : global::Java.Lang.Object, IFecControllerFactoryFactoryInterface {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/FecControllerFactoryFactoryInterface", typeof (IFecControllerFactoryFactoryInterfaceInvoker));

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

		public static IFecControllerFactoryFactoryInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFecControllerFactoryFactoryInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.FecControllerFactoryFactoryInterface"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFecControllerFactoryFactoryInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_createNative;
#pragma warning disable 0169
		static Delegate GetCreateNativeHandler ()
		{
			if (cb_createNative == null)
				cb_createNative = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_CreateNative);
			return cb_createNative;
		}

		static long n_CreateNative (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.IFecControllerFactoryFactoryInterface __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IFecControllerFactoryFactoryInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CreateNative ();
		}
#pragma warning restore 0169

		IntPtr id_createNative;
		public unsafe long CreateNative ()
		{
			if (id_createNative == IntPtr.Zero)
				id_createNative = JNIEnv.GetMethodID (class_ref, "createNative", "()J");
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_createNative);
		}

	}

}
