using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='TimestampAligner']"
	[global::Android.Runtime.Register ("org/webrtc/TimestampAligner", DoNotGenerateAcw=true)]
	public partial class TimestampAligner : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/TimestampAligner", typeof (TimestampAligner));
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

		protected TimestampAligner (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='TimestampAligner']/constructor[@name='TimestampAligner' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TimestampAligner ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		public static unsafe long RtcTimeNanos {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='TimestampAligner']/method[@name='getRtcTimeNanos' and count(parameter)=0]"
			[Register ("getRtcTimeNanos", "()J", "")]
			get {
				const string __id = "getRtcTimeNanos.()J";
				try {
					var __rm = _members.StaticMethods.InvokeInt64Method (__id, null);
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
			global::Org.Webrtc.TimestampAligner __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.TimestampAligner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='TimestampAligner']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public virtual unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_translateTimestamp_J;
#pragma warning disable 0169
		static Delegate GetTranslateTimestamp_JHandler ()
		{
			if (cb_translateTimestamp_J == null)
				cb_translateTimestamp_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long>) n_TranslateTimestamp_J);
			return cb_translateTimestamp_J;
		}

		static long n_TranslateTimestamp_J (IntPtr jnienv, IntPtr native__this, long cameraTimeNs)
		{
			global::Org.Webrtc.TimestampAligner __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.TimestampAligner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TranslateTimestamp (cameraTimeNs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='TimestampAligner']/method[@name='translateTimestamp' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("translateTimestamp", "(J)J", "GetTranslateTimestamp_JHandler")]
		public virtual unsafe long TranslateTimestamp (long cameraTimeNs)
		{
			const string __id = "translateTimestamp.(J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (cameraTimeNs);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
