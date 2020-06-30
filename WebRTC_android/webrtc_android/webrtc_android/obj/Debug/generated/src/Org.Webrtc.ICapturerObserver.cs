using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='CapturerObserver']"
	[Register ("org/webrtc/CapturerObserver", "", "Org.Webrtc.ICapturerObserverInvoker")]
	public partial interface ICapturerObserver : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='CapturerObserver']/method[@name='onCapturerStarted' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onCapturerStarted", "(Z)V", "GetOnCapturerStarted_ZHandler:Org.Webrtc.ICapturerObserverInvoker, webrtc_android")]
		void OnCapturerStarted (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='CapturerObserver']/method[@name='onCapturerStopped' and count(parameter)=0]"
		[Register ("onCapturerStopped", "()V", "GetOnCapturerStoppedHandler:Org.Webrtc.ICapturerObserverInvoker, webrtc_android")]
		void OnCapturerStopped ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='CapturerObserver']/method[@name='onFrameCaptured' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoFrame']]"
		[Register ("onFrameCaptured", "(Lorg/webrtc/VideoFrame;)V", "GetOnFrameCaptured_Lorg_webrtc_VideoFrame_Handler:Org.Webrtc.ICapturerObserverInvoker, webrtc_android")]
		void OnFrameCaptured (global::Org.Webrtc.VideoFrame p0);

	}

	[global::Android.Runtime.Register ("org/webrtc/CapturerObserver", DoNotGenerateAcw=true)]
	internal partial class ICapturerObserverInvoker : global::Java.Lang.Object, ICapturerObserver {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/CapturerObserver", typeof (ICapturerObserverInvoker));

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

		public static ICapturerObserver GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICapturerObserver> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.CapturerObserver"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICapturerObserverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCapturerStarted_Z;
#pragma warning disable 0169
		static Delegate GetOnCapturerStarted_ZHandler ()
		{
			if (cb_onCapturerStarted_Z == null)
				cb_onCapturerStarted_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnCapturerStarted_Z);
			return cb_onCapturerStarted_Z;
		}

		static void n_OnCapturerStarted_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Webrtc.ICapturerObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICapturerObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCapturerStarted (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCapturerStarted_Z;
		public unsafe void OnCapturerStarted (bool p0)
		{
			if (id_onCapturerStarted_Z == IntPtr.Zero)
				id_onCapturerStarted_Z = JNIEnv.GetMethodID (class_ref, "onCapturerStarted", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCapturerStarted_Z, __args);
		}

		static Delegate cb_onCapturerStopped;
#pragma warning disable 0169
		static Delegate GetOnCapturerStoppedHandler ()
		{
			if (cb_onCapturerStopped == null)
				cb_onCapturerStopped = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCapturerStopped);
			return cb_onCapturerStopped;
		}

		static void n_OnCapturerStopped (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.ICapturerObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICapturerObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCapturerStopped ();
		}
#pragma warning restore 0169

		IntPtr id_onCapturerStopped;
		public unsafe void OnCapturerStopped ()
		{
			if (id_onCapturerStopped == IntPtr.Zero)
				id_onCapturerStopped = JNIEnv.GetMethodID (class_ref, "onCapturerStopped", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCapturerStopped);
		}

		static Delegate cb_onFrameCaptured_Lorg_webrtc_VideoFrame_;
#pragma warning disable 0169
		static Delegate GetOnFrameCaptured_Lorg_webrtc_VideoFrame_Handler ()
		{
			if (cb_onFrameCaptured_Lorg_webrtc_VideoFrame_ == null)
				cb_onFrameCaptured_Lorg_webrtc_VideoFrame_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFrameCaptured_Lorg_webrtc_VideoFrame_);
			return cb_onFrameCaptured_Lorg_webrtc_VideoFrame_;
		}

		static void n_OnFrameCaptured_Lorg_webrtc_VideoFrame_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.ICapturerObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICapturerObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.VideoFrame p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFrameCaptured (p0);
		}
#pragma warning restore 0169

		IntPtr id_onFrameCaptured_Lorg_webrtc_VideoFrame_;
		public unsafe void OnFrameCaptured (global::Org.Webrtc.VideoFrame p0)
		{
			if (id_onFrameCaptured_Lorg_webrtc_VideoFrame_ == IntPtr.Zero)
				id_onFrameCaptured_Lorg_webrtc_VideoFrame_ = JNIEnv.GetMethodID (class_ref, "onFrameCaptured", "(Lorg/webrtc/VideoFrame;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFrameCaptured_Lorg_webrtc_VideoFrame_, __args);
		}

	}

}
