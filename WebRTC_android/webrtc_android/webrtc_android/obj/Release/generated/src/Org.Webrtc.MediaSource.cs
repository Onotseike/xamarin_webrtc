using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='MediaSource']"
	[global::Android.Runtime.Register ("org/webrtc/MediaSource", DoNotGenerateAcw=true)]
	public partial class MediaSource : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='MediaSource.State']"
		[global::Android.Runtime.Register ("org/webrtc/MediaSource$State", DoNotGenerateAcw=true)]
		public sealed partial class State : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='MediaSource.State']/field[@name='ENDED']"
			[Register ("ENDED")]
			public static global::Org.Webrtc.MediaSource.State Ended {
				get {
					const string __id = "ENDED.Lorg/webrtc/MediaSource$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaSource.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='MediaSource.State']/field[@name='INITIALIZING']"
			[Register ("INITIALIZING")]
			public static global::Org.Webrtc.MediaSource.State Initializing {
				get {
					const string __id = "INITIALIZING.Lorg/webrtc/MediaSource$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaSource.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='MediaSource.State']/field[@name='LIVE']"
			[Register ("LIVE")]
			public static global::Org.Webrtc.MediaSource.State Live {
				get {
					const string __id = "LIVE.Lorg/webrtc/MediaSource$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaSource.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='MediaSource.State']/field[@name='MUTED']"
			[Register ("MUTED")]
			public static global::Org.Webrtc.MediaSource.State Muted {
				get {
					const string __id = "MUTED.Lorg/webrtc/MediaSource$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaSource.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/MediaSource$State", typeof (State));
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

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaSource.State']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/MediaSource$State;", "")]
			public static unsafe global::Org.Webrtc.MediaSource.State ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/webrtc/MediaSource$State;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaSource.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaSource.State']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/MediaSource$State;", "")]
			public static unsafe global::Org.Webrtc.MediaSource.State[] Values ()
			{
				const string __id = "values.()[Lorg/webrtc/MediaSource$State;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Webrtc.MediaSource.State[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.MediaSource.State));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/MediaSource", typeof (MediaSource));
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

		protected MediaSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='MediaSource']/constructor[@name='MediaSource' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe MediaSource (long nativeSource)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (nativeSource);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getNativeMediaSource;
#pragma warning disable 0169
		static Delegate GetGetNativeMediaSourceHandler ()
		{
			if (cb_getNativeMediaSource == null)
				cb_getNativeMediaSource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetNativeMediaSource);
			return cb_getNativeMediaSource;
		}

		static long n_GetNativeMediaSource (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.MediaSource __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NativeMediaSource;
		}
#pragma warning restore 0169

		protected virtual unsafe long NativeMediaSource {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaSource']/method[@name='getNativeMediaSource' and count(parameter)=0]"
			[Register ("getNativeMediaSource", "()J", "GetGetNativeMediaSourceHandler")]
			get {
				const string __id = "getNativeMediaSource.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
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
			global::Org.Webrtc.MediaSource __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaSource']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public virtual unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
			global::Org.Webrtc.MediaSource __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeState ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaSource']/method[@name='state' and count(parameter)=0]"
		[Register ("state", "()Lorg/webrtc/MediaSource$State;", "GetInvokeStateHandler")]
		public virtual unsafe global::Org.Webrtc.MediaSource.State InvokeState ()
		{
			const string __id = "state.()Lorg/webrtc/MediaSource$State;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaSource.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
