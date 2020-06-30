using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='CallSessionFileRotatingLogSink']"
	[global::Android.Runtime.Register ("org/webrtc/CallSessionFileRotatingLogSink", DoNotGenerateAcw=true)]
	public partial class CallSessionFileRotatingLogSink : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/CallSessionFileRotatingLogSink", typeof (CallSessionFileRotatingLogSink));
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

		protected CallSessionFileRotatingLogSink (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='CallSessionFileRotatingLogSink']/constructor[@name='CallSessionFileRotatingLogSink' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='org.webrtc.Logging.Severity']]"
		[Register (".ctor", "(Ljava/lang/String;ILorg/webrtc/Logging$Severity;)V", "")]
		public unsafe CallSessionFileRotatingLogSink (string dirPath, int maxFileSize, global::Org.Webrtc.Logging.Severity severity)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;ILorg/webrtc/Logging$Severity;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_dirPath = JNIEnv.NewString (dirPath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_dirPath);
				__args [1] = new JniArgumentValue (maxFileSize);
				__args [2] = new JniArgumentValue ((severity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) severity).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_dirPath);
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
			global::Org.Webrtc.CallSessionFileRotatingLogSink __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.CallSessionFileRotatingLogSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='CallSessionFileRotatingLogSink']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public virtual unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='CallSessionFileRotatingLogSink']/method[@name='getLogData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLogData", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] GetLogData (string dirPath)
		{
			const string __id = "getLogData.(Ljava/lang/String;)[B";
			IntPtr native_dirPath = JNIEnv.NewString (dirPath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_dirPath);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_dirPath);
			}
		}

	}
}
