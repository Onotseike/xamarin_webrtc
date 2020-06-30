using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='MediaTransportFactoryFactory']"
	[Register ("org/webrtc/MediaTransportFactoryFactory", "", "Org.Webrtc.IMediaTransportFactoryFactoryInvoker")]
	public partial interface IMediaTransportFactoryFactory : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='MediaTransportFactoryFactory']/method[@name='createNativeMediaTransportFactory' and count(parameter)=0]"
		[Register ("createNativeMediaTransportFactory", "()J", "GetCreateNativeMediaTransportFactoryHandler:Org.Webrtc.IMediaTransportFactoryFactoryInvoker, webrtc_android")]
		long CreateNativeMediaTransportFactory ();

	}

	[global::Android.Runtime.Register ("org/webrtc/MediaTransportFactoryFactory", DoNotGenerateAcw=true)]
	internal partial class IMediaTransportFactoryFactoryInvoker : global::Java.Lang.Object, IMediaTransportFactoryFactory {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/MediaTransportFactoryFactory", typeof (IMediaTransportFactoryFactoryInvoker));

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

		public static IMediaTransportFactoryFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMediaTransportFactoryFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.MediaTransportFactoryFactory"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMediaTransportFactoryFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_createNativeMediaTransportFactory;
#pragma warning disable 0169
		static Delegate GetCreateNativeMediaTransportFactoryHandler ()
		{
			if (cb_createNativeMediaTransportFactory == null)
				cb_createNativeMediaTransportFactory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_CreateNativeMediaTransportFactory);
			return cb_createNativeMediaTransportFactory;
		}

		static long n_CreateNativeMediaTransportFactory (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.IMediaTransportFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IMediaTransportFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CreateNativeMediaTransportFactory ();
		}
#pragma warning restore 0169

		IntPtr id_createNativeMediaTransportFactory;
		public unsafe long CreateNativeMediaTransportFactory ()
		{
			if (id_createNativeMediaTransportFactory == IntPtr.Zero)
				id_createNativeMediaTransportFactory = JNIEnv.GetMethodID (class_ref, "createNativeMediaTransportFactory", "()J");
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_createNativeMediaTransportFactory);
		}

	}

}
