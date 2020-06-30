using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='RTCStatsCollectorCallback']"
	[Register ("org/webrtc/RTCStatsCollectorCallback", "", "Org.Webrtc.IRTCStatsCollectorCallbackInvoker")]
	public partial interface IRTCStatsCollectorCallback : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='RTCStatsCollectorCallback']/method[@name='onStatsDelivered' and count(parameter)=1 and parameter[1][@type='org.webrtc.RTCStatsReport']]"
		[Register ("onStatsDelivered", "(Lorg/webrtc/RTCStatsReport;)V", "GetOnStatsDelivered_Lorg_webrtc_RTCStatsReport_Handler:Org.Webrtc.IRTCStatsCollectorCallbackInvoker, webrtc_android")]
		void OnStatsDelivered (global::Org.Webrtc.RTCStatsReport p0);

	}

	[global::Android.Runtime.Register ("org/webrtc/RTCStatsCollectorCallback", DoNotGenerateAcw=true)]
	internal partial class IRTCStatsCollectorCallbackInvoker : global::Java.Lang.Object, IRTCStatsCollectorCallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/RTCStatsCollectorCallback", typeof (IRTCStatsCollectorCallbackInvoker));

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

		public static IRTCStatsCollectorCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRTCStatsCollectorCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.RTCStatsCollectorCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRTCStatsCollectorCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onStatsDelivered_Lorg_webrtc_RTCStatsReport_;
#pragma warning disable 0169
		static Delegate GetOnStatsDelivered_Lorg_webrtc_RTCStatsReport_Handler ()
		{
			if (cb_onStatsDelivered_Lorg_webrtc_RTCStatsReport_ == null)
				cb_onStatsDelivered_Lorg_webrtc_RTCStatsReport_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStatsDelivered_Lorg_webrtc_RTCStatsReport_);
			return cb_onStatsDelivered_Lorg_webrtc_RTCStatsReport_;
		}

		static void n_OnStatsDelivered_Lorg_webrtc_RTCStatsReport_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.IRTCStatsCollectorCallback __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IRTCStatsCollectorCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.RTCStatsReport p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RTCStatsReport> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnStatsDelivered (p0);
		}
#pragma warning restore 0169

		IntPtr id_onStatsDelivered_Lorg_webrtc_RTCStatsReport_;
		public unsafe void OnStatsDelivered (global::Org.Webrtc.RTCStatsReport p0)
		{
			if (id_onStatsDelivered_Lorg_webrtc_RTCStatsReport_ == IntPtr.Zero)
				id_onStatsDelivered_Lorg_webrtc_RTCStatsReport_ = JNIEnv.GetMethodID (class_ref, "onStatsDelivered", "(Lorg/webrtc/RTCStatsReport;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStatsDelivered_Lorg_webrtc_RTCStatsReport_, __args);
		}

	}

}
