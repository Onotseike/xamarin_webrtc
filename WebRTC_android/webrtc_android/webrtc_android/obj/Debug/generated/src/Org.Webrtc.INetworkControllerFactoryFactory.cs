using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='NetworkControllerFactoryFactory']"
	[Register ("org/webrtc/NetworkControllerFactoryFactory", "", "Org.Webrtc.INetworkControllerFactoryFactoryInvoker")]
	public partial interface INetworkControllerFactoryFactory : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='NetworkControllerFactoryFactory']/method[@name='createNativeNetworkControllerFactory' and count(parameter)=0]"
		[Register ("createNativeNetworkControllerFactory", "()J", "GetCreateNativeNetworkControllerFactoryHandler:Org.Webrtc.INetworkControllerFactoryFactoryInvoker, webrtc_android")]
		long CreateNativeNetworkControllerFactory ();

	}

	[global::Android.Runtime.Register ("org/webrtc/NetworkControllerFactoryFactory", DoNotGenerateAcw=true)]
	internal partial class INetworkControllerFactoryFactoryInvoker : global::Java.Lang.Object, INetworkControllerFactoryFactory {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/NetworkControllerFactoryFactory", typeof (INetworkControllerFactoryFactoryInvoker));

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

		public static INetworkControllerFactoryFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INetworkControllerFactoryFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.NetworkControllerFactoryFactory"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INetworkControllerFactoryFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_createNativeNetworkControllerFactory;
#pragma warning disable 0169
		static Delegate GetCreateNativeNetworkControllerFactoryHandler ()
		{
			if (cb_createNativeNetworkControllerFactory == null)
				cb_createNativeNetworkControllerFactory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_CreateNativeNetworkControllerFactory);
			return cb_createNativeNetworkControllerFactory;
		}

		static long n_CreateNativeNetworkControllerFactory (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.INetworkControllerFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetworkControllerFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CreateNativeNetworkControllerFactory ();
		}
#pragma warning restore 0169

		IntPtr id_createNativeNetworkControllerFactory;
		public unsafe long CreateNativeNetworkControllerFactory ()
		{
			if (id_createNativeNetworkControllerFactory == IntPtr.Zero)
				id_createNativeNetworkControllerFactory = JNIEnv.GetMethodID (class_ref, "createNativeNetworkControllerFactory", "()J");
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_createNativeNetworkControllerFactory);
		}

	}

}
