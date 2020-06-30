using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack']"
	[global::Android.Runtime.Register ("org/webrtc/MediaStreamTrack", DoNotGenerateAcw=true)]
	public partial class MediaStreamTrack : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack']/field[@name='AUDIO_TRACK_KIND']"
		[Register ("AUDIO_TRACK_KIND")]
		public const string AudioTrackKind = (string) "audio";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack']/field[@name='VIDEO_TRACK_KIND']"
		[Register ("VIDEO_TRACK_KIND")]
		public const string VideoTrackKind = (string) "video";
		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack.MediaType']"
		[global::Android.Runtime.Register ("org/webrtc/MediaStreamTrack$MediaType", DoNotGenerateAcw=true)]
		public sealed partial class MediaType : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack.MediaType']/field[@name='MEDIA_TYPE_AUDIO']"
			[Register ("MEDIA_TYPE_AUDIO")]
			public static global::Org.Webrtc.MediaStreamTrack.MediaType MediaTypeAudio {
				get {
					const string __id = "MEDIA_TYPE_AUDIO.Lorg/webrtc/MediaStreamTrack$MediaType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack.MediaType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack.MediaType']/field[@name='MEDIA_TYPE_VIDEO']"
			[Register ("MEDIA_TYPE_VIDEO")]
			public static global::Org.Webrtc.MediaStreamTrack.MediaType MediaTypeVideo {
				get {
					const string __id = "MEDIA_TYPE_VIDEO.Lorg/webrtc/MediaStreamTrack$MediaType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack.MediaType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/MediaStreamTrack$MediaType", typeof (MediaType));
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

			internal MediaType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack.MediaType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/MediaStreamTrack$MediaType;", "")]
			public static unsafe global::Org.Webrtc.MediaStreamTrack.MediaType ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/webrtc/MediaStreamTrack$MediaType;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack.MediaType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack.MediaType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/MediaStreamTrack$MediaType;", "")]
			public static unsafe global::Org.Webrtc.MediaStreamTrack.MediaType[] Values ()
			{
				const string __id = "values.()[Lorg/webrtc/MediaStreamTrack$MediaType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Webrtc.MediaStreamTrack.MediaType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.MediaStreamTrack.MediaType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack.State']"
		[global::Android.Runtime.Register ("org/webrtc/MediaStreamTrack$State", DoNotGenerateAcw=true)]
		public sealed partial class State : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack.State']/field[@name='ENDED']"
			[Register ("ENDED")]
			public static global::Org.Webrtc.MediaStreamTrack.State Ended {
				get {
					const string __id = "ENDED.Lorg/webrtc/MediaStreamTrack$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack.State']/field[@name='LIVE']"
			[Register ("LIVE")]
			public static global::Org.Webrtc.MediaStreamTrack.State Live {
				get {
					const string __id = "LIVE.Lorg/webrtc/MediaStreamTrack$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/MediaStreamTrack$State", typeof (State));
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

			internal State (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack.State']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/MediaStreamTrack$State;", "")]
			public static unsafe global::Org.Webrtc.MediaStreamTrack.State ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/webrtc/MediaStreamTrack$State;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack.State']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/MediaStreamTrack$State;", "")]
			public static unsafe global::Org.Webrtc.MediaStreamTrack.State[] Values ()
			{
				const string __id = "values.()[Lorg/webrtc/MediaStreamTrack$State;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Webrtc.MediaStreamTrack.State[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.MediaStreamTrack.State));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/MediaStreamTrack", typeof (MediaStreamTrack));
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

		protected MediaStreamTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack']/constructor[@name='MediaStreamTrack' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe MediaStreamTrack (long nativeTrack)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (nativeTrack);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
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
			global::Org.Webrtc.MediaStreamTrack __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public virtual unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_enabled;
#pragma warning disable 0169
		static Delegate GetEnabledHandler ()
		{
			if (cb_enabled == null)
				cb_enabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Enabled);
			return cb_enabled;
		}

		static bool n_Enabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.MediaStreamTrack __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Enabled ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack']/method[@name='enabled' and count(parameter)=0]"
		[Register ("enabled", "()Z", "GetEnabledHandler")]
		public virtual unsafe bool Enabled ()
		{
			const string __id = "enabled.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
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
			global::Org.Webrtc.MediaStreamTrack __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack']/method[@name='id' and count(parameter)=0]"
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

		static Delegate cb_kind;
#pragma warning disable 0169
		static Delegate GetKindHandler ()
		{
			if (cb_kind == null)
				cb_kind = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Kind);
			return cb_kind;
		}

		static IntPtr n_Kind (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.MediaStreamTrack __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Kind ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack']/method[@name='kind' and count(parameter)=0]"
		[Register ("kind", "()Ljava/lang/String;", "GetKindHandler")]
		public virtual unsafe string Kind ()
		{
			const string __id = "kind.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetEnabled_ZHandler ()
		{
			if (cb_setEnabled_Z == null)
				cb_setEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool>) n_SetEnabled_Z);
			return cb_setEnabled_Z;
		}

		static bool n_SetEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enable)
		{
			global::Org.Webrtc.MediaStreamTrack __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetEnabled (enable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack']/method[@name='setEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnabled", "(Z)Z", "GetSetEnabled_ZHandler")]
		public virtual unsafe bool SetEnabled (bool enable)
		{
			const string __id = "setEnabled.(Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enable);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_state;
#pragma warning disable 0169
		static Delegate GetInvokeStateHandler ()
		{
			if (cb_state == null)
				cb_state = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_InvokeState);
			return cb_state;
		}

		static IntPtr n_InvokeState (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.MediaStreamTrack __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeState ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack']/method[@name='state' and count(parameter)=0]"
		[Register ("state", "()Lorg/webrtc/MediaStreamTrack$State;", "GetInvokeStateHandler")]
		public virtual unsafe global::Org.Webrtc.MediaStreamTrack.State InvokeState ()
		{
			const string __id = "state.()Lorg/webrtc/MediaStreamTrack$State;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
