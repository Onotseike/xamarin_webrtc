using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='AudioDecoderFactoryFactory']"
	[Register ("org/webrtc/AudioDecoderFactoryFactory", "", "Org.Webrtc.IAudioDecoderFactoryFactoryInvoker")]
	public partial interface IAudioDecoderFactoryFactory : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='AudioDecoderFactoryFactory']/method[@name='createNativeAudioDecoderFactory' and count(parameter)=0]"
		[Register ("createNativeAudioDecoderFactory", "()J", "GetCreateNativeAudioDecoderFactoryHandler:Org.Webrtc.IAudioDecoderFactoryFactoryInvoker, webrtc_android")]
		long CreateNativeAudioDecoderFactory ();

	}

	[global::Android.Runtime.Register ("org/webrtc/AudioDecoderFactoryFactory", DoNotGenerateAcw=true)]
	internal partial class IAudioDecoderFactoryFactoryInvoker : global::Java.Lang.Object, IAudioDecoderFactoryFactory {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/AudioDecoderFactoryFactory", typeof (IAudioDecoderFactoryFactoryInvoker));

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

		public static IAudioDecoderFactoryFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAudioDecoderFactoryFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.AudioDecoderFactoryFactory"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAudioDecoderFactoryFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_createNativeAudioDecoderFactory;
#pragma warning disable 0169
		static Delegate GetCreateNativeAudioDecoderFactoryHandler ()
		{
			if (cb_createNativeAudioDecoderFactory == null)
				cb_createNativeAudioDecoderFactory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_CreateNativeAudioDecoderFactory);
			return cb_createNativeAudioDecoderFactory;
		}

		static long n_CreateNativeAudioDecoderFactory (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.IAudioDecoderFactoryFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IAudioDecoderFactoryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CreateNativeAudioDecoderFactory ();
		}
#pragma warning restore 0169

		IntPtr id_createNativeAudioDecoderFactory;
		public unsafe long CreateNativeAudioDecoderFactory ()
		{
			if (id_createNativeAudioDecoderFactory == IntPtr.Zero)
				id_createNativeAudioDecoderFactory = JNIEnv.GetMethodID (class_ref, "createNativeAudioDecoderFactory", "()J");
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_createNativeAudioDecoderFactory);
		}

	}

}
