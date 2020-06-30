using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='ThreadUtils']"
	[global::Android.Runtime.Register ("org/webrtc/ThreadUtils", DoNotGenerateAcw=true)]
	public partial class ThreadUtils : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='ThreadUtils.BlockingOperation']"
		[Register ("org/webrtc/ThreadUtils$BlockingOperation", "", "Org.Webrtc.ThreadUtils/IBlockingOperationInvoker")]
		public partial interface IBlockingOperation : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='ThreadUtils.BlockingOperation']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler:Org.Webrtc.ThreadUtils/IBlockingOperationInvoker, webrtc_android")]
			void Run ();

		}

		[global::Android.Runtime.Register ("org/webrtc/ThreadUtils$BlockingOperation", DoNotGenerateAcw=true)]
		internal partial class IBlockingOperationInvoker : global::Java.Lang.Object, IBlockingOperation {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/ThreadUtils$BlockingOperation", typeof (IBlockingOperationInvoker));

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

			public static IBlockingOperation GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IBlockingOperation> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.ThreadUtils.BlockingOperation"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IBlockingOperationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.ThreadUtils.IBlockingOperation __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ThreadUtils.IBlockingOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			IntPtr id_run;
			public unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='ThreadUtils.ThreadChecker']"
		[global::Android.Runtime.Register ("org/webrtc/ThreadUtils$ThreadChecker", DoNotGenerateAcw=true)]
		public partial class ThreadChecker : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/ThreadUtils$ThreadChecker", typeof (ThreadChecker));
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

			protected ThreadChecker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='ThreadUtils.ThreadChecker']/constructor[@name='ThreadUtils.ThreadChecker' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe ThreadChecker ()
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

			static Delegate cb_checkIsOnValidThread;
#pragma warning disable 0169
			static Delegate GetCheckIsOnValidThreadHandler ()
			{
				if (cb_checkIsOnValidThread == null)
					cb_checkIsOnValidThread = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CheckIsOnValidThread);
				return cb_checkIsOnValidThread;
			}

			static void n_CheckIsOnValidThread (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.ThreadUtils.ThreadChecker __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ThreadUtils.ThreadChecker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.CheckIsOnValidThread ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='ThreadUtils.ThreadChecker']/method[@name='checkIsOnValidThread' and count(parameter)=0]"
			[Register ("checkIsOnValidThread", "()V", "GetCheckIsOnValidThreadHandler")]
			public virtual unsafe void CheckIsOnValidThread ()
			{
				const string __id = "checkIsOnValidThread.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_detachThread;
#pragma warning disable 0169
			static Delegate GetDetachThreadHandler ()
			{
				if (cb_detachThread == null)
					cb_detachThread = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DetachThread);
				return cb_detachThread;
			}

			static void n_DetachThread (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.ThreadUtils.ThreadChecker __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ThreadUtils.ThreadChecker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.DetachThread ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='ThreadUtils.ThreadChecker']/method[@name='detachThread' and count(parameter)=0]"
			[Register ("detachThread", "()V", "GetDetachThreadHandler")]
			public virtual unsafe void DetachThread ()
			{
				const string __id = "detachThread.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/ThreadUtils", typeof (ThreadUtils));
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

		protected ThreadUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='ThreadUtils']/constructor[@name='ThreadUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ThreadUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='ThreadUtils']/method[@name='awaitUninterruptibly' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.CountDownLatch']]"
		[Register ("awaitUninterruptibly", "(Ljava/util/concurrent/CountDownLatch;)V", "")]
		public static unsafe void AwaitUninterruptibly (global::Java.Util.Concurrent.CountDownLatch latch)
		{
			const string __id = "awaitUninterruptibly.(Ljava/util/concurrent/CountDownLatch;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((latch == null) ? IntPtr.Zero : ((global::Java.Lang.Object) latch).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='ThreadUtils']/method[@name='awaitUninterruptibly' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.CountDownLatch'] and parameter[2][@type='long']]"
		[Register ("awaitUninterruptibly", "(Ljava/util/concurrent/CountDownLatch;J)Z", "")]
		public static unsafe bool AwaitUninterruptibly (global::Java.Util.Concurrent.CountDownLatch barrier, long timeoutMs)
		{
			const string __id = "awaitUninterruptibly.(Ljava/util/concurrent/CountDownLatch;J)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((barrier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) barrier).Handle);
				__args [1] = new JniArgumentValue (timeoutMs);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='ThreadUtils']/method[@name='checkIsOnMainThread' and count(parameter)=0]"
		[Register ("checkIsOnMainThread", "()V", "")]
		public static unsafe void CheckIsOnMainThread ()
		{
			const string __id = "checkIsOnMainThread.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='ThreadUtils']/method[@name='executeUninterruptibly' and count(parameter)=1 and parameter[1][@type='org.webrtc.ThreadUtils.BlockingOperation']]"
		[Register ("executeUninterruptibly", "(Lorg/webrtc/ThreadUtils$BlockingOperation;)V", "")]
		public static unsafe void ExecuteUninterruptibly (global::Org.Webrtc.ThreadUtils.IBlockingOperation operation)
		{
			const string __id = "executeUninterruptibly.(Lorg/webrtc/ThreadUtils$BlockingOperation;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((operation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) operation).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='ThreadUtils']/method[@name='invokeAtFrontUninterruptibly' and count(parameter)=2 and parameter[1][@type='android.os.Handler'] and parameter[2][@type='java.lang.Runnable']]"
		[Register ("invokeAtFrontUninterruptibly", "(Landroid/os/Handler;Ljava/lang/Runnable;)V", "")]
		public static unsafe void InvokeAtFrontUninterruptibly (global::Android.OS.Handler handler, global::Java.Lang.IRunnable runner)
		{
			const string __id = "invokeAtFrontUninterruptibly.(Landroid/os/Handler;Ljava/lang/Runnable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
				__args [1] = new JniArgumentValue ((runner == null) ? IntPtr.Zero : ((global::Java.Lang.Object) runner).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='ThreadUtils']/method[@name='invokeAtFrontUninterruptibly' and count(parameter)=2 and parameter[1][@type='android.os.Handler'] and parameter[2][@type='java.util.concurrent.Callable&lt;V&gt;']]"
		[Register ("invokeAtFrontUninterruptibly", "(Landroid/os/Handler;Ljava/util/concurrent/Callable;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"V"})]
		public static unsafe global::Java.Lang.Object InvokeAtFrontUninterruptibly (global::Android.OS.Handler handler, global::Java.Util.Concurrent.ICallable callable)
		{
			const string __id = "invokeAtFrontUninterruptibly.(Landroid/os/Handler;Ljava/util/concurrent/Callable;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
				__args [1] = new JniArgumentValue ((callable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callable).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='ThreadUtils']/method[@name='joinUninterruptibly' and count(parameter)=1 and parameter[1][@type='java.lang.Thread']]"
		[Register ("joinUninterruptibly", "(Ljava/lang/Thread;)V", "")]
		public static unsafe void JoinUninterruptibly (global::Java.Lang.Thread thread)
		{
			const string __id = "joinUninterruptibly.(Ljava/lang/Thread;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='ThreadUtils']/method[@name='joinUninterruptibly' and count(parameter)=2 and parameter[1][@type='java.lang.Thread'] and parameter[2][@type='long']]"
		[Register ("joinUninterruptibly", "(Ljava/lang/Thread;J)Z", "")]
		public static unsafe bool JoinUninterruptibly (global::Java.Lang.Thread thread, long timeoutMs)
		{
			const string __id = "joinUninterruptibly.(Ljava/lang/Thread;J)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
				__args [1] = new JniArgumentValue (timeoutMs);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
