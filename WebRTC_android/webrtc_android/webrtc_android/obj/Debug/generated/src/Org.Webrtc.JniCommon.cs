using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='JniCommon']"
	[global::Android.Runtime.Register ("org/webrtc/JniCommon", DoNotGenerateAcw=true)]
	public partial class JniCommon : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/JniCommon", typeof (JniCommon));
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

		protected JniCommon (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='JniCommon']/constructor[@name='JniCommon' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JniCommon ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='JniCommon']/method[@name='nativeAddRef' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("nativeAddRef", "(J)V", "")]
		public static unsafe void NativeAddRef (long p0)
		{
			const string __id = "nativeAddRef.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='JniCommon']/method[@name='nativeAllocateByteBuffer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("nativeAllocateByteBuffer", "(I)Ljava/nio/ByteBuffer;", "")]
		public static unsafe global::Java.Nio.ByteBuffer NativeAllocateByteBuffer (int p0)
		{
			const string __id = "nativeAllocateByteBuffer.(I)Ljava/nio/ByteBuffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='JniCommon']/method[@name='nativeFreeByteBuffer' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("nativeFreeByteBuffer", "(Ljava/nio/ByteBuffer;)V", "")]
		public static unsafe void NativeFreeByteBuffer (global::Java.Nio.ByteBuffer p0)
		{
			const string __id = "nativeFreeByteBuffer.(Ljava/nio/ByteBuffer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='JniCommon']/method[@name='nativeReleaseRef' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("nativeReleaseRef", "(J)V", "")]
		public static unsafe void NativeReleaseRef (long p0)
		{
			const string __id = "nativeReleaseRef.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
