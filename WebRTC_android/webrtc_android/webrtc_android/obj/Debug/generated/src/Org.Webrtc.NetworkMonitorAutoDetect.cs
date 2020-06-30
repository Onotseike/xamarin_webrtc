using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect']"
	[global::Android.Runtime.Register ("org/webrtc/NetworkMonitorAutoDetect", DoNotGenerateAcw=true)]
	public partial class NetworkMonitorAutoDetect : global::Android.Content.BroadcastReceiver {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect.ConnectionType']"
		[global::Android.Runtime.Register ("org/webrtc/NetworkMonitorAutoDetect$ConnectionType", DoNotGenerateAcw=true)]
		public sealed partial class ConnectionType : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect.ConnectionType']/field[@name='CONNECTION_2G']"
			[Register ("CONNECTION_2G")]
			public static global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType Connection2g {
				get {
					const string __id = "CONNECTION_2G.Lorg/webrtc/NetworkMonitorAutoDetect$ConnectionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect.ConnectionType']/field[@name='CONNECTION_3G']"
			[Register ("CONNECTION_3G")]
			public static global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType Connection3g {
				get {
					const string __id = "CONNECTION_3G.Lorg/webrtc/NetworkMonitorAutoDetect$ConnectionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect.ConnectionType']/field[@name='CONNECTION_4G']"
			[Register ("CONNECTION_4G")]
			public static global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType Connection4g {
				get {
					const string __id = "CONNECTION_4G.Lorg/webrtc/NetworkMonitorAutoDetect$ConnectionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect.ConnectionType']/field[@name='CONNECTION_5G']"
			[Register ("CONNECTION_5G")]
			public static global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType Connection5g {
				get {
					const string __id = "CONNECTION_5G.Lorg/webrtc/NetworkMonitorAutoDetect$ConnectionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect.ConnectionType']/field[@name='CONNECTION_BLUETOOTH']"
			[Register ("CONNECTION_BLUETOOTH")]
			public static global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType ConnectionBluetooth {
				get {
					const string __id = "CONNECTION_BLUETOOTH.Lorg/webrtc/NetworkMonitorAutoDetect$ConnectionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect.ConnectionType']/field[@name='CONNECTION_ETHERNET']"
			[Register ("CONNECTION_ETHERNET")]
			public static global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType ConnectionEthernet {
				get {
					const string __id = "CONNECTION_ETHERNET.Lorg/webrtc/NetworkMonitorAutoDetect$ConnectionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect.ConnectionType']/field[@name='CONNECTION_NONE']"
			[Register ("CONNECTION_NONE")]
			public static global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType ConnectionNone {
				get {
					const string __id = "CONNECTION_NONE.Lorg/webrtc/NetworkMonitorAutoDetect$ConnectionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect.ConnectionType']/field[@name='CONNECTION_UNKNOWN']"
			[Register ("CONNECTION_UNKNOWN")]
			public static global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType ConnectionUnknown {
				get {
					const string __id = "CONNECTION_UNKNOWN.Lorg/webrtc/NetworkMonitorAutoDetect$ConnectionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect.ConnectionType']/field[@name='CONNECTION_UNKNOWN_CELLULAR']"
			[Register ("CONNECTION_UNKNOWN_CELLULAR")]
			public static global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType ConnectionUnknownCellular {
				get {
					const string __id = "CONNECTION_UNKNOWN_CELLULAR.Lorg/webrtc/NetworkMonitorAutoDetect$ConnectionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect.ConnectionType']/field[@name='CONNECTION_VPN']"
			[Register ("CONNECTION_VPN")]
			public static global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType ConnectionVpn {
				get {
					const string __id = "CONNECTION_VPN.Lorg/webrtc/NetworkMonitorAutoDetect$ConnectionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect.ConnectionType']/field[@name='CONNECTION_WIFI']"
			[Register ("CONNECTION_WIFI")]
			public static global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType ConnectionWifi {
				get {
					const string __id = "CONNECTION_WIFI.Lorg/webrtc/NetworkMonitorAutoDetect$ConnectionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/NetworkMonitorAutoDetect$ConnectionType", typeof (ConnectionType));
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

			internal ConnectionType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect.ConnectionType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/NetworkMonitorAutoDetect$ConnectionType;", "")]
			public static unsafe global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/webrtc/NetworkMonitorAutoDetect$ConnectionType;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect.ConnectionType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/NetworkMonitorAutoDetect$ConnectionType;", "")]
			public static unsafe global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType[] Values ()
			{
				const string __id = "values.()[Lorg/webrtc/NetworkMonitorAutoDetect$ConnectionType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect.IPAddress']"
		[global::Android.Runtime.Register ("org/webrtc/NetworkMonitorAutoDetect$IPAddress", DoNotGenerateAcw=true)]
		public partial class IPAddress : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect.IPAddress']/field[@name='address']"
			[Register ("address")]
			public IList<byte> Address {
				get {
					const string __id = "address.[B";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "address.[B";

					IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/NetworkMonitorAutoDetect$IPAddress", typeof (IPAddress));
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

			protected IPAddress (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect.IPAddress']/constructor[@name='NetworkMonitorAutoDetect.IPAddress' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register (".ctor", "([B)V", "")]
			public unsafe IPAddress (byte[] address)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "([B)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_address = JNIEnv.NewArray (address);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_address);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					if (address != null) {
						JNIEnv.CopyArray (native_address, address);
						JNIEnv.DeleteLocalRef (native_address);
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect.NetworkInformation']"
		[global::Android.Runtime.Register ("org/webrtc/NetworkMonitorAutoDetect$NetworkInformation", DoNotGenerateAcw=true)]
		public partial class NetworkInformation : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect.NetworkInformation']/field[@name='handle']"
			[Register ("handle")]
			public long Handle {
				get {
					const string __id = "handle.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "handle.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect.NetworkInformation']/field[@name='ipAddresses']"
			[Register ("ipAddresses")]
			public IList<Org.Webrtc.NetworkMonitorAutoDetect.IPAddress> IpAddresses {
				get {
					const string __id = "ipAddresses.[Lorg/webrtc/NetworkMonitorAutoDetect$IPAddress;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<global::Org.Webrtc.NetworkMonitorAutoDetect.IPAddress>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "ipAddresses.[Lorg/webrtc/NetworkMonitorAutoDetect$IPAddress;";

					IntPtr native_value = global::Android.Runtime.JavaArray<global::Org.Webrtc.NetworkMonitorAutoDetect.IPAddress>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect.NetworkInformation']/field[@name='name']"
			[Register ("name")]
			public string Name {
				get {
					const string __id = "name.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "name.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect.NetworkInformation']/field[@name='type']"
			[Register ("type")]
			public global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType Type {
				get {
					const string __id = "type.Lorg/webrtc/NetworkMonitorAutoDetect$ConnectionType;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "type.Lorg/webrtc/NetworkMonitorAutoDetect$ConnectionType;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect.NetworkInformation']/field[@name='underlyingTypeForVpn']"
			[Register ("underlyingTypeForVpn")]
			public global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType UnderlyingTypeForVpn {
				get {
					const string __id = "underlyingTypeForVpn.Lorg/webrtc/NetworkMonitorAutoDetect$ConnectionType;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "underlyingTypeForVpn.Lorg/webrtc/NetworkMonitorAutoDetect$ConnectionType;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/NetworkMonitorAutoDetect$NetworkInformation", typeof (NetworkInformation));
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

			protected NetworkInformation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect.NetworkInformation']/constructor[@name='NetworkMonitorAutoDetect.NetworkInformation' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.webrtc.NetworkMonitorAutoDetect.ConnectionType'] and parameter[3][@type='org.webrtc.NetworkMonitorAutoDetect.ConnectionType'] and parameter[4][@type='long'] and parameter[5][@type='org.webrtc.NetworkMonitorAutoDetect.IPAddress[]']]"
			[Register (".ctor", "(Ljava/lang/String;Lorg/webrtc/NetworkMonitorAutoDetect$ConnectionType;Lorg/webrtc/NetworkMonitorAutoDetect$ConnectionType;J[Lorg/webrtc/NetworkMonitorAutoDetect$IPAddress;)V", "")]
			public unsafe NetworkInformation (string name, global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType type, global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType underlyingTypeForVpn, long handle, global::Org.Webrtc.NetworkMonitorAutoDetect.IPAddress[] addresses)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Lorg/webrtc/NetworkMonitorAutoDetect$ConnectionType;Lorg/webrtc/NetworkMonitorAutoDetect$ConnectionType;J[Lorg/webrtc/NetworkMonitorAutoDetect$IPAddress;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_addresses = JNIEnv.NewArray (addresses);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (native_name);
					__args [1] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
					__args [2] = new JniArgumentValue ((underlyingTypeForVpn == null) ? IntPtr.Zero : ((global::Java.Lang.Object) underlyingTypeForVpn).Handle);
					__args [3] = new JniArgumentValue (handle);
					__args [4] = new JniArgumentValue (native_addresses);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					if (addresses != null) {
						JNIEnv.CopyArray (native_addresses, addresses);
						JNIEnv.DeleteLocalRef (native_addresses);
					}
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='NetworkMonitorAutoDetect.Observer']"
		[Register ("org/webrtc/NetworkMonitorAutoDetect$Observer", "", "Org.Webrtc.NetworkMonitorAutoDetect/IObserverInvoker")]
		public partial interface IObserver : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='NetworkMonitorAutoDetect.Observer']/method[@name='onConnectionTypeChanged' and count(parameter)=1 and parameter[1][@type='org.webrtc.NetworkMonitorAutoDetect.ConnectionType']]"
			[Register ("onConnectionTypeChanged", "(Lorg/webrtc/NetworkMonitorAutoDetect$ConnectionType;)V", "GetOnConnectionTypeChanged_Lorg_webrtc_NetworkMonitorAutoDetect_ConnectionType_Handler:Org.Webrtc.NetworkMonitorAutoDetect/IObserverInvoker, webrtc_android")]
			void OnConnectionTypeChanged (global::Org.Webrtc.NetworkMonitorAutoDetect.ConnectionType p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='NetworkMonitorAutoDetect.Observer']/method[@name='onNetworkConnect' and count(parameter)=1 and parameter[1][@type='org.webrtc.NetworkMonitorAutoDetect.NetworkInformation']]"
			[Register ("onNetworkConnect", "(Lorg/webrtc/NetworkMonitorAutoDetect$NetworkInformation;)V", "GetOnNetworkConnect_Lorg_webrtc_NetworkMonitorAutoDetect_NetworkInformation_Handler:Org.Webrtc.NetworkMonitorAutoDetect/IObserverInvoker, webrtc_android")]
			void OnNetworkConnect (global::Org.Webrtc.NetworkMonitorAutoDetect.NetworkInformation p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='NetworkMonitorAutoDetect.Observer']/method[@name='onNetworkDisconnect' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("onNetworkDisconnect", "(J)V", "GetOnNetworkDisconnect_JHandler:Org.Webrtc.NetworkMonitorAutoDetect/IObserverInvoker, webrtc_android")]
			void OnNetworkDisconnect (long p0);

		}

		[global::Android.Runtime.Register ("org/webrtc/NetworkMonitorAutoDetect$Observer", DoNotGenerateAcw=true)]
		internal partial class IObserverInvoker : global::Java.Lang.Object, IObserver {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/NetworkMonitorAutoDetect$Observer", typeof (IObserverInvoker));

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
								JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.NetworkMonitorAutoDetect.Observer"));
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
				global::Org.Webrtc.NetworkMonitorAutoDetect.IObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitorAutoDetect.IObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

			static Delegate cb_onNetworkConnect_Lorg_webrtc_NetworkMonitorAutoDetect_NetworkInformation_;
#pragma warning disable 0169
			static Delegate GetOnNetworkConnect_Lorg_webrtc_NetworkMonitorAutoDetect_NetworkInformation_Handler ()
			{
				if (cb_onNetworkConnect_Lorg_webrtc_NetworkMonitorAutoDetect_NetworkInformation_ == null)
					cb_onNetworkConnect_Lorg_webrtc_NetworkMonitorAutoDetect_NetworkInformation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNetworkConnect_Lorg_webrtc_NetworkMonitorAutoDetect_NetworkInformation_);
				return cb_onNetworkConnect_Lorg_webrtc_NetworkMonitorAutoDetect_NetworkInformation_;
			}

			static void n_OnNetworkConnect_Lorg_webrtc_NetworkMonitorAutoDetect_NetworkInformation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.NetworkMonitorAutoDetect.IObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitorAutoDetect.IObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.NetworkMonitorAutoDetect.NetworkInformation p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitorAutoDetect.NetworkInformation> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnNetworkConnect (p0);
			}
#pragma warning restore 0169

			IntPtr id_onNetworkConnect_Lorg_webrtc_NetworkMonitorAutoDetect_NetworkInformation_;
			public unsafe void OnNetworkConnect (global::Org.Webrtc.NetworkMonitorAutoDetect.NetworkInformation p0)
			{
				if (id_onNetworkConnect_Lorg_webrtc_NetworkMonitorAutoDetect_NetworkInformation_ == IntPtr.Zero)
					id_onNetworkConnect_Lorg_webrtc_NetworkMonitorAutoDetect_NetworkInformation_ = JNIEnv.GetMethodID (class_ref, "onNetworkConnect", "(Lorg/webrtc/NetworkMonitorAutoDetect$NetworkInformation;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNetworkConnect_Lorg_webrtc_NetworkMonitorAutoDetect_NetworkInformation_, __args);
			}

			static Delegate cb_onNetworkDisconnect_J;
#pragma warning disable 0169
			static Delegate GetOnNetworkDisconnect_JHandler ()
			{
				if (cb_onNetworkDisconnect_J == null)
					cb_onNetworkDisconnect_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_OnNetworkDisconnect_J);
				return cb_onNetworkDisconnect_J;
			}

			static void n_OnNetworkDisconnect_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Org.Webrtc.NetworkMonitorAutoDetect.IObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitorAutoDetect.IObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnNetworkDisconnect (p0);
			}
#pragma warning restore 0169

			IntPtr id_onNetworkDisconnect_J;
			public unsafe void OnNetworkDisconnect (long p0)
			{
				if (id_onNetworkDisconnect_J == IntPtr.Zero)
					id_onNetworkDisconnect_J = JNIEnv.GetMethodID (class_ref, "onNetworkDisconnect", "(J)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNetworkDisconnect_J, __args);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/NetworkMonitorAutoDetect", typeof (NetworkMonitorAutoDetect));
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

		protected NetworkMonitorAutoDetect (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect']/constructor[@name='NetworkMonitorAutoDetect' and count(parameter)=2 and parameter[1][@type='org.webrtc.NetworkMonitorAutoDetect.Observer'] and parameter[2][@type='android.content.Context']]"
		[Register (".ctor", "(Lorg/webrtc/NetworkMonitorAutoDetect$Observer;Landroid/content/Context;)V", "")]
		public unsafe NetworkMonitorAutoDetect (global::Org.Webrtc.NetworkMonitorAutoDetect.IObserver observer, global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/webrtc/NetworkMonitorAutoDetect$Observer;Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((observer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) observer).Handle);
				__args [1] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getCurrentNetworkState;
#pragma warning disable 0169
		static Delegate GetGetCurrentNetworkStateHandler ()
		{
			if (cb_getCurrentNetworkState == null)
				cb_getCurrentNetworkState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentNetworkState);
			return cb_getCurrentNetworkState;
		}

		static IntPtr n_GetCurrentNetworkState (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.NetworkMonitorAutoDetect __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitorAutoDetect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentNetworkState);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object CurrentNetworkState {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect']/method[@name='getCurrentNetworkState' and count(parameter)=0]"
			[Register ("getCurrentNetworkState", "()Ljava/lang/Object;", "GetGetCurrentNetworkStateHandler")]
			get {
				const string __id = "getCurrentNetworkState.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDefaultNetId;
#pragma warning disable 0169
		static Delegate GetGetDefaultNetIdHandler ()
		{
			if (cb_getDefaultNetId == null)
				cb_getDefaultNetId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDefaultNetId);
			return cb_getDefaultNetId;
		}

		static long n_GetDefaultNetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.NetworkMonitorAutoDetect __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitorAutoDetect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DefaultNetId;
		}
#pragma warning restore 0169

		public virtual unsafe long DefaultNetId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect']/method[@name='getDefaultNetId' and count(parameter)=0]"
			[Register ("getDefaultNetId", "()J", "GetGetDefaultNetIdHandler")]
			get {
				const string __id = "getDefaultNetId.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.NetworkMonitorAutoDetect __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitorAutoDetect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public virtual unsafe void Destroy ()
		{
			const string __id = "destroy.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler ()
		{
			if (cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ == null)
				cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnReceive_Landroid_content_Context_Landroid_content_Intent_);
			return cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
		}

		static void n_OnReceive_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_intent)
		{
			global::Org.Webrtc.NetworkMonitorAutoDetect __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitorAutoDetect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			__this.OnReceive (context, intent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler")]
		public override unsafe void OnReceive (global::Android.Content.Context context, global::Android.Content.Intent intent)
		{
			const string __id = "onReceive.(Landroid/content/Context;Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_supportNetworkCallback;
#pragma warning disable 0169
		static Delegate GetSupportNetworkCallbackHandler ()
		{
			if (cb_supportNetworkCallback == null)
				cb_supportNetworkCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_SupportNetworkCallback);
			return cb_supportNetworkCallback;
		}

		static bool n_SupportNetworkCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.NetworkMonitorAutoDetect __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.NetworkMonitorAutoDetect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SupportNetworkCallback ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NetworkMonitorAutoDetect']/method[@name='supportNetworkCallback' and count(parameter)=0]"
		[Register ("supportNetworkCallback", "()Z", "GetSupportNetworkCallbackHandler")]
		public virtual unsafe bool SupportNetworkCallback ()
		{
			const string __id = "supportNetworkCallback.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
