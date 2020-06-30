using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='RtpReceiver']"
	[global::Android.Runtime.Register ("org/webrtc/RtpReceiver", DoNotGenerateAcw=true)]
	public partial class RtpReceiver : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='RtpReceiver.Observer']"
		[Register ("org/webrtc/RtpReceiver$Observer", "", "Org.Webrtc.RtpReceiver/IObserverInvoker")]
		public partial interface IObserver : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='RtpReceiver.Observer']/method[@name='onFirstPacketReceived' and count(parameter)=1 and parameter[1][@type='org.webrtc.MediaStreamTrack.MediaType']]"
			[Register ("onFirstPacketReceived", "(Lorg/webrtc/MediaStreamTrack$MediaType;)V", "GetOnFirstPacketReceived_Lorg_webrtc_MediaStreamTrack_MediaType_Handler:Org.Webrtc.RtpReceiver/IObserverInvoker, webrtc_android")]
			void OnFirstPacketReceived (global::Org.Webrtc.MediaStreamTrack.MediaType p0);

		}

		[global::Android.Runtime.Register ("org/webrtc/RtpReceiver$Observer", DoNotGenerateAcw=true)]
		internal partial class IObserverInvoker : global::Java.Lang.Object, IObserver {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/RtpReceiver$Observer", typeof (IObserverInvoker));

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

			public static IObserver GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IObserver> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.RtpReceiver.Observer"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IObserverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onFirstPacketReceived_Lorg_webrtc_MediaStreamTrack_MediaType_;
#pragma warning disable 0169
			static Delegate GetOnFirstPacketReceived_Lorg_webrtc_MediaStreamTrack_MediaType_Handler ()
			{
				if (cb_onFirstPacketReceived_Lorg_webrtc_MediaStreamTrack_MediaType_ == null)
					cb_onFirstPacketReceived_Lorg_webrtc_MediaStreamTrack_MediaType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFirstPacketReceived_Lorg_webrtc_MediaStreamTrack_MediaType_);
				return cb_onFirstPacketReceived_Lorg_webrtc_MediaStreamTrack_MediaType_;
			}

			static void n_OnFirstPacketReceived_Lorg_webrtc_MediaStreamTrack_MediaType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.RtpReceiver.IObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpReceiver.IObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.MediaStreamTrack.MediaType p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack.MediaType> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnFirstPacketReceived (p0);
			}
#pragma warning restore 0169

			IntPtr id_onFirstPacketReceived_Lorg_webrtc_MediaStreamTrack_MediaType_;
			public unsafe void OnFirstPacketReceived (global::Org.Webrtc.MediaStreamTrack.MediaType p0)
			{
				if (id_onFirstPacketReceived_Lorg_webrtc_MediaStreamTrack_MediaType_ == IntPtr.Zero)
					id_onFirstPacketReceived_Lorg_webrtc_MediaStreamTrack_MediaType_ = JNIEnv.GetMethodID (class_ref, "onFirstPacketReceived", "(Lorg/webrtc/MediaStreamTrack$MediaType;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFirstPacketReceived_Lorg_webrtc_MediaStreamTrack_MediaType_, __args);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/RtpReceiver", typeof (RtpReceiver));
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

		protected RtpReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='RtpReceiver']/constructor[@name='RtpReceiver' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe RtpReceiver (long nativeRtpReceiver)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (nativeRtpReceiver);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getParameters;
#pragma warning disable 0169
		static Delegate GetGetParametersHandler ()
		{
			if (cb_getParameters == null)
				cb_getParameters = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParameters);
			return cb_getParameters;
		}

		static IntPtr n_GetParameters (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.RtpReceiver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Parameters);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Webrtc.RtpParameters Parameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpReceiver']/method[@name='getParameters' and count(parameter)=0]"
			[Register ("getParameters", "()Lorg/webrtc/RtpParameters;", "GetGetParametersHandler")]
			get {
				const string __id = "getParameters.()Lorg/webrtc/RtpParameters;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_SetObserver_Lorg_webrtc_RtpReceiver_Observer_;
#pragma warning disable 0169
		static Delegate GetSetObserver_Lorg_webrtc_RtpReceiver_Observer_Handler ()
		{
			if (cb_SetObserver_Lorg_webrtc_RtpReceiver_Observer_ == null)
				cb_SetObserver_Lorg_webrtc_RtpReceiver_Observer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetObserver_Lorg_webrtc_RtpReceiver_Observer_);
			return cb_SetObserver_Lorg_webrtc_RtpReceiver_Observer_;
		}

		static void n_SetObserver_Lorg_webrtc_RtpReceiver_Observer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_observer)
		{
			global::Org.Webrtc.RtpReceiver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.RtpReceiver.IObserver observer = (global::Org.Webrtc.RtpReceiver.IObserver)global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpReceiver.IObserver> (native_observer, JniHandleOwnership.DoNotTransfer);
			__this.SetObserver (observer);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpReceiver']/method[@name='SetObserver' and count(parameter)=1 and parameter[1][@type='org.webrtc.RtpReceiver.Observer']]"
		[Register ("SetObserver", "(Lorg/webrtc/RtpReceiver$Observer;)V", "GetSetObserver_Lorg_webrtc_RtpReceiver_Observer_Handler")]
		public virtual unsafe void SetObserver (global::Org.Webrtc.RtpReceiver.IObserver observer)
		{
			const string __id = "SetObserver.(Lorg/webrtc/RtpReceiver$Observer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((observer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) observer).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_dispose;
#pragma warning disable 0169
		static Delegate GetDisposeHandler ()
		{
			if (cb_dispose == null)
				cb_dispose = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Dispose);
			return cb_dispose;
		}

		static void n_Dispose (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.RtpReceiver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpReceiver']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public virtual unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_id;
#pragma warning disable 0169
		static Delegate GetIdHandler ()
		{
			if (cb_id == null)
				cb_id = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Id);
			return cb_id;
		}

		static IntPtr n_Id (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.RtpReceiver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpReceiver']/method[@name='id' and count(parameter)=0]"
		[Register ("id", "()Ljava/lang/String;", "GetIdHandler")]
		public virtual unsafe string Id ()
		{
			const string __id = "id.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setFrameDecryptor_Lorg_webrtc_FrameDecryptor_;
#pragma warning disable 0169
		static Delegate GetSetFrameDecryptor_Lorg_webrtc_FrameDecryptor_Handler ()
		{
			if (cb_setFrameDecryptor_Lorg_webrtc_FrameDecryptor_ == null)
				cb_setFrameDecryptor_Lorg_webrtc_FrameDecryptor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFrameDecryptor_Lorg_webrtc_FrameDecryptor_);
			return cb_setFrameDecryptor_Lorg_webrtc_FrameDecryptor_;
		}

		static void n_SetFrameDecryptor_Lorg_webrtc_FrameDecryptor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_frameDecryptor)
		{
			global::Org.Webrtc.RtpReceiver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.IFrameDecryptor frameDecryptor = (global::Org.Webrtc.IFrameDecryptor)global::Java.Lang.Object.GetObject<global::Org.Webrtc.IFrameDecryptor> (native_frameDecryptor, JniHandleOwnership.DoNotTransfer);
			__this.SetFrameDecryptor (frameDecryptor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpReceiver']/method[@name='setFrameDecryptor' and count(parameter)=1 and parameter[1][@type='org.webrtc.FrameDecryptor']]"
		[Register ("setFrameDecryptor", "(Lorg/webrtc/FrameDecryptor;)V", "GetSetFrameDecryptor_Lorg_webrtc_FrameDecryptor_Handler")]
		public virtual unsafe void SetFrameDecryptor (global::Org.Webrtc.IFrameDecryptor frameDecryptor)
		{
			const string __id = "setFrameDecryptor.(Lorg/webrtc/FrameDecryptor;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((frameDecryptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) frameDecryptor).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_track;
#pragma warning disable 0169
		static Delegate GetTrackHandler ()
		{
			if (cb_track == null)
				cb_track = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Track);
			return cb_track;
		}

		static IntPtr n_Track (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.RtpReceiver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Track ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpReceiver']/method[@name='track' and count(parameter)=0]"
		[Register ("track", "()Lorg/webrtc/MediaStreamTrack;", "GetTrackHandler")]
		public virtual unsafe global::Org.Webrtc.MediaStreamTrack Track ()
		{
			const string __id = "track.()Lorg/webrtc/MediaStreamTrack;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
