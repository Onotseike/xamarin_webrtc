using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='NetworkStatePredictorFactoryFactory']"
	[Register ("org/webrtc/NetworkStatePredictorFactoryFactory", "", "Org.Webrtc.INetworkStatePredictorFactoryFactoryInvoker")]
	public partial interface INetworkStatePredictorFactoryFactory : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='NetworkStatePredictorFactoryFactory']/method[@name='createNativeNetworkStatePredictorFactory' and count(parameter)=0]"
		[Register ("createNativeNetworkStatePredictorFactory", "()J", "GetCreateNativeNetworkStatePredictorFactoryHandler:Org.Webrtc.INetworkStatePredictorFactoryFactoryInvoker, webrtc_android")]
		long CreateNativeNetworkStatePredictorFactory ();

	}

	[global::Android.Runtime.Register ("org/webrtc/NetworkStatePredictorFactoryFactory", DoNotGenerateAcw=true)]
	internal partial class INetworkStatePredictorFactoryFactoryInvoker : global::Java.Lang.Object, INetworkStatePredictorFactoryFactory {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/NetworkStatePredictorFactoryFactory", typeof (INetworkStatePredictorFactoryFactoryInvoker));

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

		public static INetworkStatePredictorFactoryFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INetworkStatePredictorFactoryFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.NetworkStatePredictorFactoryFactory"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INetworkStatePredictorFactoryFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_createNativeNetworkStatePredictorFactory;
#pragma warning disable 0169
		static Delegate GetCreateNativeNetworkStatePredictorFactoryHandler ()
		{
			if (cb_createNativeNetworkStatePredictorFactory == null)
				cb_createNativeNetworkStatePredictorFactory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_CreateNativeNetworkStatePredictorFactory);
			return cb_createNativeNetworkStatePredictorFactory;
		}

		static long n_CreateNativeNetworkStatePredictorFactory (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.INetworkStatePredictorFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.INetworkStatePredictorFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CreateNativeNetworkStatePredictorFactory ();
		}
#pragma warning restore 0169

		IntPtr id_createNativeNetworkStatePredictorFactory;
		public unsafe long CreateNativeNetworkStatePredictorFactory ()
		{
			if (id_createNativeNetworkStatePredictorFactory == IntPtr.Zero)
				id_createNativeNetworkStatePredictorFactory = JNIEnv.GetMethodID (class_ref, "createNativeNetworkStatePredictorFactory", "()J");
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_createNativeNetworkStatePredictorFactory);
		}

	}

}
