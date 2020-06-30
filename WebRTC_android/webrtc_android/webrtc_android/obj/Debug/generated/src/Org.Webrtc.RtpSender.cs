using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='RtpSender']"
	[global::Android.Runtime.Register ("org/webrtc/RtpSender", DoNotGenerateAcw=true)]
	public partial class RtpSender : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/RtpSender", typeof (RtpSender));
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

		protected RtpSender (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='RtpSender']/constructor[@name='RtpSender' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe RtpSender (long nativeRtpSender)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (nativeRtpSender);
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
			global::Org.Webrtc.RtpSender __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Parameters);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Webrtc.RtpParameters Parameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpSender']/method[@name='getParameters' and count(parameter)=0]"
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

		static Delegate cb_getStreams;
#pragma warning disable 0169
		static Delegate GetGetStreamsHandler ()
		{
			if (cb_getStreams == null)
				cb_getStreams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStreams);
			return cb_getStreams;
		}

		static IntPtr n_GetStreams (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.RtpSender __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.Streams);
		}
#pragma warning restore 0169

		static Delegate cb_setStreams_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetStreams_Ljava_util_List_Handler ()
		{
			if (cb_setStreams_Ljava_util_List_ == null)
				cb_setStreams_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStreams_Ljava_util_List_);
			return cb_setStreams_Ljava_util_List_;
		}

		static void n_SetStreams_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_streamIds)
		{
			global::Org.Webrtc.RtpSender __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var streamIds = global::Android.Runtime.JavaList<string>.FromJniHandle (native_streamIds, JniHandleOwnership.DoNotTransfer);
			__this.Streams = streamIds;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> Streams {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpSender']/method[@name='getStreams' and count(parameter)=0]"
			[Register ("getStreams", "()Ljava/util/List;", "GetGetStreamsHandler")]
			get {
				const string __id = "getStreams.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpSender']/method[@name='setStreams' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setStreams", "(Ljava/util/List;)V", "GetSetStreams_Ljava_util_List_Handler")]
			set {
				const string __id = "setStreams.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
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
			global::Org.Webrtc.RtpSender __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpSender']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public virtual unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_dtmf;
#pragma warning disable 0169
		static Delegate GetDtmfHandler ()
		{
			if (cb_dtmf == null)
				cb_dtmf = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Dtmf);
			return cb_dtmf;
		}

		static IntPtr n_Dtmf (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.RtpSender __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Dtmf ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpSender']/method[@name='dtmf' and count(parameter)=0]"
		[Register ("dtmf", "()Lorg/webrtc/DtmfSender;", "GetDtmfHandler")]
		public virtual unsafe global::Org.Webrtc.DtmfSender Dtmf ()
		{
			const string __id = "dtmf.()Lorg/webrtc/DtmfSender;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.DtmfSender> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Org.Webrtc.RtpSender __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpSender']/method[@name='id' and count(parameter)=0]"
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

		static Delegate cb_setFrameEncryptor_Lorg_webrtc_FrameEncryptor_;
#pragma warning disable 0169
		static Delegate GetSetFrameEncryptor_Lorg_webrtc_FrameEncryptor_Handler ()
		{
			if (cb_setFrameEncryptor_Lorg_webrtc_FrameEncryptor_ == null)
				cb_setFrameEncryptor_Lorg_webrtc_FrameEncryptor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFrameEncryptor_Lorg_webrtc_FrameEncryptor_);
			return cb_setFrameEncryptor_Lorg_webrtc_FrameEncryptor_;
		}

		static void n_SetFrameEncryptor_Lorg_webrtc_FrameEncryptor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_frameEncryptor)
		{
			global::Org.Webrtc.RtpSender __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.IFrameEncryptor frameEncryptor = (global::Org.Webrtc.IFrameEncryptor)global::Java.Lang.Object.GetObject<global::Org.Webrtc.IFrameEncryptor> (native_frameEncryptor, JniHandleOwnership.DoNotTransfer);
			__this.SetFrameEncryptor (frameEncryptor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpSender']/method[@name='setFrameEncryptor' and count(parameter)=1 and parameter[1][@type='org.webrtc.FrameEncryptor']]"
		[Register ("setFrameEncryptor", "(Lorg/webrtc/FrameEncryptor;)V", "GetSetFrameEncryptor_Lorg_webrtc_FrameEncryptor_Handler")]
		public virtual unsafe void SetFrameEncryptor (global::Org.Webrtc.IFrameEncryptor frameEncryptor)
		{
			const string __id = "setFrameEncryptor.(Lorg/webrtc/FrameEncryptor;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((frameEncryptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) frameEncryptor).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setParameters_Lorg_webrtc_RtpParameters_;
#pragma warning disable 0169
		static Delegate GetSetParameters_Lorg_webrtc_RtpParameters_Handler ()
		{
			if (cb_setParameters_Lorg_webrtc_RtpParameters_ == null)
				cb_setParameters_Lorg_webrtc_RtpParameters_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetParameters_Lorg_webrtc_RtpParameters_);
			return cb_setParameters_Lorg_webrtc_RtpParameters_;
		}

		static bool n_SetParameters_Lorg_webrtc_RtpParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameters)
		{
			global::Org.Webrtc.RtpSender __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.RtpParameters parameters = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpParameters> (native_parameters, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetParameters (parameters);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpSender']/method[@name='setParameters' and count(parameter)=1 and parameter[1][@type='org.webrtc.RtpParameters']]"
		[Register ("setParameters", "(Lorg/webrtc/RtpParameters;)Z", "GetSetParameters_Lorg_webrtc_RtpParameters_Handler")]
		public virtual unsafe bool SetParameters (global::Org.Webrtc.RtpParameters parameters)
		{
			const string __id = "setParameters.(Lorg/webrtc/RtpParameters;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setTrack_Lorg_webrtc_MediaStreamTrack_Z;
#pragma warning disable 0169
		static Delegate GetSetTrack_Lorg_webrtc_MediaStreamTrack_ZHandler ()
		{
			if (cb_setTrack_Lorg_webrtc_MediaStreamTrack_Z == null)
				cb_setTrack_Lorg_webrtc_MediaStreamTrack_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, bool>) n_SetTrack_Lorg_webrtc_MediaStreamTrack_Z);
			return cb_setTrack_Lorg_webrtc_MediaStreamTrack_Z;
		}

		static bool n_SetTrack_Lorg_webrtc_MediaStreamTrack_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_track, bool takeOwnership)
		{
			global::Org.Webrtc.RtpSender __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.MediaStreamTrack track = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack> (native_track, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetTrack (track, takeOwnership);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpSender']/method[@name='setTrack' and count(parameter)=2 and parameter[1][@type='org.webrtc.MediaStreamTrack'] and parameter[2][@type='boolean']]"
		[Register ("setTrack", "(Lorg/webrtc/MediaStreamTrack;Z)Z", "GetSetTrack_Lorg_webrtc_MediaStreamTrack_ZHandler")]
		public virtual unsafe bool SetTrack (global::Org.Webrtc.MediaStreamTrack track, bool takeOwnership)
		{
			const string __id = "setTrack.(Lorg/webrtc/MediaStreamTrack;Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((track == null) ? IntPtr.Zero : ((global::Java.Lang.Object) track).Handle);
				__args [1] = new JniArgumentValue (takeOwnership);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
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
			global::Org.Webrtc.RtpSender __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Track ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpSender']/method[@name='track' and count(parameter)=0]"
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
