using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitor']"
	[global::Android.Runtime.Register ("org/webrtc/NetworkMonitor", DoNotGenerateAcw=true)]
	public partial class NetworkMonitor : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='NetworkMonitor.NetworkObserver']"
		[Register ("org/webrtc/NetworkMonitor$NetworkObserver", "", "Org.Webrtc.NetworkMonitor/INetworkObserverInvoker")]
		public partial interface INetworkObserver : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='NetworkMonitor.NetworkObserver']/method[@name='onConnectionTypeChanged' and count(parameter)=1 and parameter[1][@type='org.webrtc.NetworkMonitorAutoDetect.ConnectionType']]"
			[Register ("onConnectionTypeChanged", "(Lorg/webrtc/NetworkMonitorAutoDetect$ConnectionType;)V", "GetOnConnectionTypeChanged_Lorg_webrtc_NetworkMonitorAutoDetect_ConnectionType_Handler:Org.Webrtc.NetworkMonitor/INetworkObserverInvoker, webrtc_android")]
			void OnConnectionTypeChanged (global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType p0);

		}

		[global::Android.Runtime.Register ("org/webrtc/NetworkMonitor$NetworkObserver", DoNotGenerateAcw=true)]
		internal partial class INetworkObserverInvoker : global::Java.Lang.Object, INetworkObserver {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/NetworkMonitor$NetworkObserver", typeof (INetworkObserverInvoker));

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

			public static INetworkObserver GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<INetworkObserver> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.NetworkMonitor.NetworkObserver"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public INetworkObserverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onConnectionTypeChanged_Lorg_webrtc_NetworkMonitorAutoDetect_ConnectionType_;
#pragma warning disable 0169
			static Delegate GetOnConnectionTypeChanged_Lorg_webrtc_NetworkMonitorAutoDetect_ConnectionType_Handler ()
			{
				if (cb_onConnectionTypeChanged_Lorg_webrtc_NetworkMonitorAutoDetect_ConnectionType_ == null)
					cb_onConnectionTypeChanged_Lorg_webrtc_NetworkMonitorAutoDetect_ConnectionType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnectionTypeChanged_Lorg_webrtc_NetworkMonitorAutoDetect_ConnectionType_);
				return cb_onConnectionTypeChanged_Lorg_webrtc_NetworkMonitorAutoDetect_ConnectionType_;
			}

			static void n_OnConnectionTypeChanged_Lorg_webrtc_NetworkMonitorAutoDetect_ConnectionType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.NetworkMonitor.INetworkObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitor.INetworkObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnConnectionTypeChanged (p0);
			}
#pragma warning restore 0169

			IntPtr id_onConnectionTypeChanged_Lorg_webrtc_NetworkMonitorAutoDetect_ConnectionType_;
			public unsafe void OnConnectionTypeChanged (global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType p0)
			{
				if (id_onConnectionTypeChanged_Lorg_webrtc_NetworkMonitorAutoDetect_ConnectionType_ == IntPtr.Zero)
					id_onConnectionTypeChanged_Lorg_webrtc_NetworkMonitorAutoDetect_ConnectionType_ = JNIEnv.GetMethodID (class_ref, "onConnectionTypeChanged", "(Lorg/webrtc/NetworkMonitorAutoDetect$ConnectionType;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionTypeChanged_Lorg_webrtc_NetworkMonitorAutoDetect_ConnectionType_, __args);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/NetworkMonitor", typeof (NetworkMonitor));
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

		protected NetworkMonitor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Org.Webrtc.NetworkMonitor Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitor']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lorg/webrtc/NetworkMonitor;", "")]
			get {
				const string __id = "getInstance.()Lorg/webrtc/NetworkMonitor;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe bool IsOnline {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitor']/method[@name='isOnline' and count(parameter)=0]"
			[Register ("isOnline", "()Z", "")]
			get {
				const string __id = "isOnline.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitor']/method[@name='addNetworkObserver' and count(parameter)=1 and parameter[1][@type='org.webrtc.NetworkMonitor.NetworkObserver']]"
		[Obsolete (@"deprecated")]
		[Register ("addNetworkObserver", "(Lorg/webrtc/NetworkMonitor$NetworkObserver;)V", "")]
		public static unsafe void AddNetworkObserver (global::Org.Webrtc.NetworkMonitor.INetworkObserver observer)
		{
			const string __id = "addNetworkObserver.(Lorg/webrtc/NetworkMonitor$NetworkObserver;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((observer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) observer).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		static Delegate cb_addObserver_Lorg_webrtc_NetworkMonitor_NetworkObserver_;
#pragma warning disable 0169
		static Delegate GetAddObserver_Lorg_webrtc_NetworkMonitor_NetworkObserver_Handler ()
		{
			if (cb_addObserver_Lorg_webrtc_NetworkMonitor_NetworkObserver_ == null)
				cb_addObserver_Lorg_webrtc_NetworkMonitor_NetworkObserver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddObserver_Lorg_webrtc_NetworkMonitor_NetworkObserver_);
			return cb_addObserver_Lorg_webrtc_NetworkMonitor_NetworkObserver_;
		}

		static void n_AddObserver_Lorg_webrtc_NetworkMonitor_NetworkObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_observer)
		{
			global::Org.Webrtc.NetworkMonitor __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.NetworkMonitor.INetworkObserver observer = (global::Org.Webrtc.NetworkMonitor.INetworkObserver)global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitor.INetworkObserver> (native_observer, JniHandleOwnership.DoNotTransfer);
			__this.AddObserver (observer);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitor']/method[@name='addObserver' and count(parameter)=1 and parameter[1][@type='org.webrtc.NetworkMonitor.NetworkObserver']]"
		[Register ("addObserver", "(Lorg/webrtc/NetworkMonitor$NetworkObserver;)V", "GetAddObserver_Lorg_webrtc_NetworkMonitor_NetworkObserver_Handler")]
		public virtual unsafe void AddObserver (global::Org.Webrtc.NetworkMonitor.INetworkObserver observer)
		{
			const string __id = "addObserver.(Lorg/webrtc/NetworkMonitor$NetworkObserver;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((observer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) observer).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitor']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Obsolete (@"deprecated")]
		[Register ("init", "(Landroid/content/Context;)V", "")]
		public static unsafe void Init (global::Android.Content.Context context)
		{
			const string __id = "init.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitor']/method[@name='removeNetworkObserver' and count(parameter)=1 and parameter[1][@type='org.webrtc.NetworkMonitor.NetworkObserver']]"
		[Obsolete (@"deprecated")]
		[Register ("removeNetworkObserver", "(Lorg/webrtc/NetworkMonitor$NetworkObserver;)V", "")]
		public static unsafe void RemoveNetworkObserver (global::Org.Webrtc.NetworkMonitor.INetworkObserver observer)
		{
			const string __id = "removeNetworkObserver.(Lorg/webrtc/NetworkMonitor$NetworkObserver;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((observer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) observer).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		static Delegate cb_removeObserver_Lorg_webrtc_NetworkMonitor_NetworkObserver_;
#pragma warning disable 0169
		static Delegate GetRemoveObserver_Lorg_webrtc_NetworkMonitor_NetworkObserver_Handler ()
		{
			if (cb_removeObserver_Lorg_webrtc_NetworkMonitor_NetworkObserver_ == null)
				cb_removeObserver_Lorg_webrtc_NetworkMonitor_NetworkObserver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveObserver_Lorg_webrtc_NetworkMonitor_NetworkObserver_);
			return cb_removeObserver_Lorg_webrtc_NetworkMonitor_NetworkObserver_;
		}

		static void n_RemoveObserver_Lorg_webrtc_NetworkMonitor_NetworkObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_observer)
		{
			global::Org.Webrtc.NetworkMonitor __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.NetworkMonitor.INetworkObserver observer = (global::Org.Webrtc.NetworkMonitor.INetworkObserver)global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitor.INetworkObserver> (native_observer, JniHandleOwnership.DoNotTransfer);
			__this.RemoveObserver (observer);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitor']/method[@name='removeObserver' and count(parameter)=1 and parameter[1][@type='org.webrtc.NetworkMonitor.NetworkObserver']]"
		[Register ("removeObserver", "(Lorg/webrtc/NetworkMonitor$NetworkObserver;)V", "GetRemoveObserver_Lorg_webrtc_NetworkMonitor_NetworkObserver_Handler")]
		public virtual unsafe void RemoveObserver (global::Org.Webrtc.NetworkMonitor.INetworkObserver observer)
		{
			const string __id = "removeObserver.(Lorg/webrtc/NetworkMonitor$NetworkObserver;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((observer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) observer).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startMonitoring;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetStartMonitoringHandler ()
		{
			if (cb_startMonitoring == null)
				cb_startMonitoring = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartMonitoring);
			return cb_startMonitoring;
		}

		[Obsolete]
		static void n_StartMonitoring (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.NetworkMonitor __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartMonitoring ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitor']/method[@name='startMonitoring' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("startMonitoring", "()V", "GetStartMonitoringHandler")]
		public virtual unsafe void StartMonitoring ()
		{
			const string __id = "startMonitoring.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_startMonitoring_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetStartMonitoring_Landroid_content_Context_Handler ()
		{
			if (cb_startMonitoring_Landroid_content_Context_ == null)
				cb_startMonitoring_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartMonitoring_Landroid_content_Context_);
			return cb_startMonitoring_Landroid_content_Context_;
		}

		static void n_StartMonitoring_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_applicationContext)
		{
			global::Org.Webrtc.NetworkMonitor __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context applicationContext = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_applicationContext, JniHandleOwnership.DoNotTransfer);
			__this.StartMonitoring (applicationContext);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitor']/method[@name='startMonitoring' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("startMonitoring", "(Landroid/content/Context;)V", "GetStartMonitoring_Landroid_content_Context_Handler")]
		public virtual unsafe void StartMonitoring (global::Android.Content.Context applicationContext)
		{
			const string __id = "startMonitoring.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((applicationContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) applicationContext).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_stopMonitoring;
#pragma warning disable 0169
		static Delegate GetStopMonitoringHandler ()
		{
			if (cb_stopMonitoring == null)
				cb_stopMonitoring = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopMonitoring);
			return cb_stopMonitoring;
		}

		static void n_StopMonitoring (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.NetworkMonitor __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopMonitoring ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitor']/method[@name='stopMonitoring' and count(parameter)=0]"
		[Register ("stopMonitoring", "()V", "GetStopMonitoringHandler")]
		public virtual unsafe void StopMonitoring ()
		{
			const string __id = "stopMonitoring.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
