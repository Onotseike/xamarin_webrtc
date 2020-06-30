using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']"
	[global::Android.Runtime.Register ("org/webrtc/PeerConnection", DoNotGenerateAcw=true)]
	public partial class PeerConnection : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.AdapterType']"
		[global::Android.Runtime.Register ("org/webrtc/PeerConnection$AdapterType", DoNotGenerateAcw=true)]
		public sealed partial class AdapterType : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.AdapterType']/field[@name='ADAPTER_TYPE_ANY']"
			[Register ("ADAPTER_TYPE_ANY")]
			public static global::Org.Webrtc.PeerConnection.AdapterType AdapterTypeAny {
				get {
					const string __id = "ADAPTER_TYPE_ANY.Lorg/webrtc/PeerConnection$AdapterType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.AdapterType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.AdapterType']/field[@name='CELLULAR']"
			[Register ("CELLULAR")]
			public static global::Org.Webrtc.PeerConnection.AdapterType Cellular {
				get {
					const string __id = "CELLULAR.Lorg/webrtc/PeerConnection$AdapterType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.AdapterType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.AdapterType']/field[@name='CELLULAR_2G']"
			[Register ("CELLULAR_2G")]
			public static global::Org.Webrtc.PeerConnection.AdapterType Cellular2g {
				get {
					const string __id = "CELLULAR_2G.Lorg/webrtc/PeerConnection$AdapterType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.AdapterType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.AdapterType']/field[@name='CELLULAR_3G']"
			[Register ("CELLULAR_3G")]
			public static global::Org.Webrtc.PeerConnection.AdapterType Cellular3g {
				get {
					const string __id = "CELLULAR_3G.Lorg/webrtc/PeerConnection$AdapterType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.AdapterType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.AdapterType']/field[@name='CELLULAR_4G']"
			[Register ("CELLULAR_4G")]
			public static global::Org.Webrtc.PeerConnection.AdapterType Cellular4g {
				get {
					const string __id = "CELLULAR_4G.Lorg/webrtc/PeerConnection$AdapterType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.AdapterType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.AdapterType']/field[@name='CELLULAR_5G']"
			[Register ("CELLULAR_5G")]
			public static global::Org.Webrtc.PeerConnection.AdapterType Cellular5g {
				get {
					const string __id = "CELLULAR_5G.Lorg/webrtc/PeerConnection$AdapterType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.AdapterType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.AdapterType']/field[@name='ETHERNET']"
			[Register ("ETHERNET")]
			public static global::Org.Webrtc.PeerConnection.AdapterType Ethernet {
				get {
					const string __id = "ETHERNET.Lorg/webrtc/PeerConnection$AdapterType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.AdapterType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.AdapterType']/field[@name='LOOPBACK']"
			[Register ("LOOPBACK")]
			public static global::Org.Webrtc.PeerConnection.AdapterType Loopback {
				get {
					const string __id = "LOOPBACK.Lorg/webrtc/PeerConnection$AdapterType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.AdapterType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.AdapterType']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Org.Webrtc.PeerConnection.AdapterType Unknown {
				get {
					const string __id = "UNKNOWN.Lorg/webrtc/PeerConnection$AdapterType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.AdapterType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.AdapterType']/field[@name='VPN']"
			[Register ("VPN")]
			public static global::Org.Webrtc.PeerConnection.AdapterType Vpn {
				get {
					const string __id = "VPN.Lorg/webrtc/PeerConnection$AdapterType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.AdapterType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.AdapterType']/field[@name='WIFI']"
			[Register ("WIFI")]
			public static global::Org.Webrtc.PeerConnection.AdapterType Wifi {
				get {
					const string __id = "WIFI.Lorg/webrtc/PeerConnection$AdapterType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.AdapterType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.AdapterType']/field[@name='bitMask']"
			[Register ("bitMask")]
			public global::Java.Lang.Integer BitMask {
				get {
					const string __id = "bitMask.Ljava/lang/Integer;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "bitMask.Ljava/lang/Integer;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/PeerConnection$AdapterType", typeof (AdapterType));
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

			internal AdapterType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.AdapterType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/PeerConnection$AdapterType;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.AdapterType ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/webrtc/PeerConnection$AdapterType;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.AdapterType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.AdapterType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/PeerConnection$AdapterType;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.AdapterType[] Values ()
			{
				const string __id = "values.()[Lorg/webrtc/PeerConnection$AdapterType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Webrtc.PeerConnection.AdapterType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.PeerConnection.AdapterType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.BundlePolicy']"
		[global::Android.Runtime.Register ("org/webrtc/PeerConnection$BundlePolicy", DoNotGenerateAcw=true)]
		public sealed partial class BundlePolicy : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.BundlePolicy']/field[@name='BALANCED']"
			[Register ("BALANCED")]
			public static global::Org.Webrtc.PeerConnection.BundlePolicy Balanced {
				get {
					const string __id = "BALANCED.Lorg/webrtc/PeerConnection$BundlePolicy;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.BundlePolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.BundlePolicy']/field[@name='MAXBUNDLE']"
			[Register ("MAXBUNDLE")]
			public static global::Org.Webrtc.PeerConnection.BundlePolicy Maxbundle {
				get {
					const string __id = "MAXBUNDLE.Lorg/webrtc/PeerConnection$BundlePolicy;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.BundlePolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.BundlePolicy']/field[@name='MAXCOMPAT']"
			[Register ("MAXCOMPAT")]
			public static global::Org.Webrtc.PeerConnection.BundlePolicy Maxcompat {
				get {
					const string __id = "MAXCOMPAT.Lorg/webrtc/PeerConnection$BundlePolicy;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.BundlePolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/PeerConnection$BundlePolicy", typeof (BundlePolicy));
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

			internal BundlePolicy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.BundlePolicy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/PeerConnection$BundlePolicy;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.BundlePolicy ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/webrtc/PeerConnection$BundlePolicy;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.BundlePolicy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.BundlePolicy']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/PeerConnection$BundlePolicy;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.BundlePolicy[] Values ()
			{
				const string __id = "values.()[Lorg/webrtc/PeerConnection$BundlePolicy;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Webrtc.PeerConnection.BundlePolicy[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.PeerConnection.BundlePolicy));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.CandidateNetworkPolicy']"
		[global::Android.Runtime.Register ("org/webrtc/PeerConnection$CandidateNetworkPolicy", DoNotGenerateAcw=true)]
		public sealed partial class CandidateNetworkPolicy : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.CandidateNetworkPolicy']/field[@name='ALL']"
			[Register ("ALL")]
			public static global::Org.Webrtc.PeerConnection.CandidateNetworkPolicy All {
				get {
					const string __id = "ALL.Lorg/webrtc/PeerConnection$CandidateNetworkPolicy;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.CandidateNetworkPolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.CandidateNetworkPolicy']/field[@name='LOW_COST']"
			[Register ("LOW_COST")]
			public static global::Org.Webrtc.PeerConnection.CandidateNetworkPolicy LowCost {
				get {
					const string __id = "LOW_COST.Lorg/webrtc/PeerConnection$CandidateNetworkPolicy;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.CandidateNetworkPolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/PeerConnection$CandidateNetworkPolicy", typeof (CandidateNetworkPolicy));
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

			internal CandidateNetworkPolicy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.CandidateNetworkPolicy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/PeerConnection$CandidateNetworkPolicy;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.CandidateNetworkPolicy ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/webrtc/PeerConnection$CandidateNetworkPolicy;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.CandidateNetworkPolicy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.CandidateNetworkPolicy']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/PeerConnection$CandidateNetworkPolicy;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.CandidateNetworkPolicy[] Values ()
			{
				const string __id = "values.()[Lorg/webrtc/PeerConnection$CandidateNetworkPolicy;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Webrtc.PeerConnection.CandidateNetworkPolicy[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.PeerConnection.CandidateNetworkPolicy));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.ContinualGatheringPolicy']"
		[global::Android.Runtime.Register ("org/webrtc/PeerConnection$ContinualGatheringPolicy", DoNotGenerateAcw=true)]
		public sealed partial class ContinualGatheringPolicy : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.ContinualGatheringPolicy']/field[@name='GATHER_CONTINUALLY']"
			[Register ("GATHER_CONTINUALLY")]
			public static global::Org.Webrtc.PeerConnection.ContinualGatheringPolicy GatherContinually {
				get {
					const string __id = "GATHER_CONTINUALLY.Lorg/webrtc/PeerConnection$ContinualGatheringPolicy;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.ContinualGatheringPolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.ContinualGatheringPolicy']/field[@name='GATHER_ONCE']"
			[Register ("GATHER_ONCE")]
			public static global::Org.Webrtc.PeerConnection.ContinualGatheringPolicy GatherOnce {
				get {
					const string __id = "GATHER_ONCE.Lorg/webrtc/PeerConnection$ContinualGatheringPolicy;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.ContinualGatheringPolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/PeerConnection$ContinualGatheringPolicy", typeof (ContinualGatheringPolicy));
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

			internal ContinualGatheringPolicy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.ContinualGatheringPolicy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/PeerConnection$ContinualGatheringPolicy;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.ContinualGatheringPolicy ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/webrtc/PeerConnection$ContinualGatheringPolicy;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.ContinualGatheringPolicy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.ContinualGatheringPolicy']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/PeerConnection$ContinualGatheringPolicy;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.ContinualGatheringPolicy[] Values ()
			{
				const string __id = "values.()[Lorg/webrtc/PeerConnection$ContinualGatheringPolicy;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Webrtc.PeerConnection.ContinualGatheringPolicy[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.PeerConnection.ContinualGatheringPolicy));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceConnectionState']"
		[global::Android.Runtime.Register ("org/webrtc/PeerConnection$IceConnectionState", DoNotGenerateAcw=true)]
		public sealed partial class IceConnectionState : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceConnectionState']/field[@name='CHECKING']"
			[Register ("CHECKING")]
			public static global::Org.Webrtc.PeerConnection.IceConnectionState Checking {
				get {
					const string __id = "CHECKING.Lorg/webrtc/PeerConnection$IceConnectionState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceConnectionState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceConnectionState']/field[@name='CLOSED']"
			[Register ("CLOSED")]
			public static global::Org.Webrtc.PeerConnection.IceConnectionState Closed {
				get {
					const string __id = "CLOSED.Lorg/webrtc/PeerConnection$IceConnectionState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceConnectionState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceConnectionState']/field[@name='COMPLETED']"
			[Register ("COMPLETED")]
			public static global::Org.Webrtc.PeerConnection.IceConnectionState Completed {
				get {
					const string __id = "COMPLETED.Lorg/webrtc/PeerConnection$IceConnectionState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceConnectionState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceConnectionState']/field[@name='CONNECTED']"
			[Register ("CONNECTED")]
			public static global::Org.Webrtc.PeerConnection.IceConnectionState Connected {
				get {
					const string __id = "CONNECTED.Lorg/webrtc/PeerConnection$IceConnectionState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceConnectionState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceConnectionState']/field[@name='DISCONNECTED']"
			[Register ("DISCONNECTED")]
			public static global::Org.Webrtc.PeerConnection.IceConnectionState Disconnected {
				get {
					const string __id = "DISCONNECTED.Lorg/webrtc/PeerConnection$IceConnectionState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceConnectionState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceConnectionState']/field[@name='FAILED']"
			[Register ("FAILED")]
			public static global::Org.Webrtc.PeerConnection.IceConnectionState Failed {
				get {
					const string __id = "FAILED.Lorg/webrtc/PeerConnection$IceConnectionState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceConnectionState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceConnectionState']/field[@name='NEW']"
			[Register ("NEW")]
			public static global::Org.Webrtc.PeerConnection.IceConnectionState New {
				get {
					const string __id = "NEW.Lorg/webrtc/PeerConnection$IceConnectionState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceConnectionState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/PeerConnection$IceConnectionState", typeof (IceConnectionState));
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

			internal IceConnectionState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceConnectionState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/PeerConnection$IceConnectionState;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.IceConnectionState ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/webrtc/PeerConnection$IceConnectionState;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceConnectionState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceConnectionState']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/PeerConnection$IceConnectionState;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.IceConnectionState[] Values ()
			{
				const string __id = "values.()[Lorg/webrtc/PeerConnection$IceConnectionState;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Webrtc.PeerConnection.IceConnectionState[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.PeerConnection.IceConnectionState));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceGatheringState']"
		[global::Android.Runtime.Register ("org/webrtc/PeerConnection$IceGatheringState", DoNotGenerateAcw=true)]
		public sealed partial class IceGatheringState : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceGatheringState']/field[@name='COMPLETE']"
			[Register ("COMPLETE")]
			public static global::Org.Webrtc.PeerConnection.IceGatheringState Complete {
				get {
					const string __id = "COMPLETE.Lorg/webrtc/PeerConnection$IceGatheringState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceGatheringState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceGatheringState']/field[@name='GATHERING']"
			[Register ("GATHERING")]
			public static global::Org.Webrtc.PeerConnection.IceGatheringState Gathering {
				get {
					const string __id = "GATHERING.Lorg/webrtc/PeerConnection$IceGatheringState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceGatheringState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceGatheringState']/field[@name='NEW']"
			[Register ("NEW")]
			public static global::Org.Webrtc.PeerConnection.IceGatheringState New {
				get {
					const string __id = "NEW.Lorg/webrtc/PeerConnection$IceGatheringState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceGatheringState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/PeerConnection$IceGatheringState", typeof (IceGatheringState));
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

			internal IceGatheringState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceGatheringState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/PeerConnection$IceGatheringState;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.IceGatheringState ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/webrtc/PeerConnection$IceGatheringState;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceGatheringState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceGatheringState']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/PeerConnection$IceGatheringState;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.IceGatheringState[] Values ()
			{
				const string __id = "values.()[Lorg/webrtc/PeerConnection$IceGatheringState;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Webrtc.PeerConnection.IceGatheringState[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.PeerConnection.IceGatheringState));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceServer']"
		[global::Android.Runtime.Register ("org/webrtc/PeerConnection$IceServer", DoNotGenerateAcw=true)]
		public partial class IceServer : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceServer']/field[@name='hostname']"
			[Register ("hostname")]
			public string Hostname {
				get {
					const string __id = "hostname.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "hostname.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceServer']/field[@name='password']"
			[Register ("password")]
			public string Password {
				get {
					const string __id = "password.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "password.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceServer']/field[@name='tlsAlpnProtocols']"
			[Register ("tlsAlpnProtocols")]
			public global::System.Collections.IList TlsAlpnProtocols {
				get {
					const string __id = "tlsAlpnProtocols.Ljava/util/List;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "tlsAlpnProtocols.Ljava/util/List;";

					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceServer']/field[@name='tlsCertPolicy']"
			[Register ("tlsCertPolicy")]
			public global::Org.Webrtc.PeerConnection.TlsCertPolicy TlsCertPolicy {
				get {
					const string __id = "tlsCertPolicy.Lorg/webrtc/PeerConnection$TlsCertPolicy;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.TlsCertPolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "tlsCertPolicy.Lorg/webrtc/PeerConnection$TlsCertPolicy;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceServer']/field[@name='tlsEllipticCurves']"
			[Register ("tlsEllipticCurves")]
			public global::System.Collections.IList TlsEllipticCurves {
				get {
					const string __id = "tlsEllipticCurves.Ljava/util/List;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "tlsEllipticCurves.Ljava/util/List;";

					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceServer']/field[@name='uri']"
			[Register ("uri")]
			[Obsolete ("deprecated")]
			public string Uri {
				get {
					const string __id = "uri.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "uri.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceServer']/field[@name='urls']"
			[Register ("urls")]
			public global::System.Collections.IList Urls {
				get {
					const string __id = "urls.Ljava/util/List;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "urls.Ljava/util/List;";

					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceServer']/field[@name='username']"
			[Register ("username")]
			public string Username {
				get {
					const string __id = "username.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "username.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceServer.Builder']"
			[global::Android.Runtime.Register ("org/webrtc/PeerConnection$IceServer$Builder", DoNotGenerateAcw=true)]
			public partial class Builder : global::Java.Lang.Object {

				static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/PeerConnection$IceServer$Builder", typeof (Builder));
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

				protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static Delegate cb_createIceServer;
#pragma warning disable 0169
				static Delegate GetCreateIceServerHandler ()
				{
					if (cb_createIceServer == null)
						cb_createIceServer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreateIceServer);
					return cb_createIceServer;
				}

				static IntPtr n_CreateIceServer (IntPtr jnienv, IntPtr native__this)
				{
					global::Org.Webrtc.PeerConnection.IceServer.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceServer.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					return JNIEnv.ToLocalJniHandle (__this.CreateIceServer ());
				}
#pragma warning restore 0169

				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceServer.Builder']/method[@name='createIceServer' and count(parameter)=0]"
				[Register ("createIceServer", "()Lorg/webrtc/PeerConnection$IceServer;", "GetCreateIceServerHandler")]
				public virtual unsafe global::Org.Webrtc.PeerConnection.IceServer CreateIceServer ()
				{
					const string __id = "createIceServer.()Lorg/webrtc/PeerConnection$IceServer;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceServer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}

				static Delegate cb_setHostname_Ljava_lang_String_;
#pragma warning disable 0169
				static Delegate GetSetHostname_Ljava_lang_String_Handler ()
				{
					if (cb_setHostname_Ljava_lang_String_ == null)
						cb_setHostname_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetHostname_Ljava_lang_String_);
					return cb_setHostname_Ljava_lang_String_;
				}

				static IntPtr n_SetHostname_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_hostname)
				{
					global::Org.Webrtc.PeerConnection.IceServer.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceServer.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					string hostname = JNIEnv.GetString (native_hostname, JniHandleOwnership.DoNotTransfer);
					IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetHostname (hostname));
					return __ret;
				}
#pragma warning restore 0169

				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceServer.Builder']/method[@name='setHostname' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setHostname", "(Ljava/lang/String;)Lorg/webrtc/PeerConnection$IceServer$Builder;", "GetSetHostname_Ljava_lang_String_Handler")]
				public virtual unsafe global::Org.Webrtc.PeerConnection.IceServer.Builder SetHostname (string hostname)
				{
					const string __id = "setHostname.(Ljava/lang/String;)Lorg/webrtc/PeerConnection$IceServer$Builder;";
					IntPtr native_hostname = JNIEnv.NewString (hostname);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_hostname);
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceServer.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_hostname);
					}
				}

				static Delegate cb_setPassword_Ljava_lang_String_;
#pragma warning disable 0169
				static Delegate GetSetPassword_Ljava_lang_String_Handler ()
				{
					if (cb_setPassword_Ljava_lang_String_ == null)
						cb_setPassword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPassword_Ljava_lang_String_);
					return cb_setPassword_Ljava_lang_String_;
				}

				static IntPtr n_SetPassword_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_password)
				{
					global::Org.Webrtc.PeerConnection.IceServer.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceServer.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					string password = JNIEnv.GetString (native_password, JniHandleOwnership.DoNotTransfer);
					IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPassword (password));
					return __ret;
				}
#pragma warning restore 0169

				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceServer.Builder']/method[@name='setPassword' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setPassword", "(Ljava/lang/String;)Lorg/webrtc/PeerConnection$IceServer$Builder;", "GetSetPassword_Ljava_lang_String_Handler")]
				public virtual unsafe global::Org.Webrtc.PeerConnection.IceServer.Builder SetPassword (string password)
				{
					const string __id = "setPassword.(Ljava/lang/String;)Lorg/webrtc/PeerConnection$IceServer$Builder;";
					IntPtr native_password = JNIEnv.NewString (password);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_password);
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceServer.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_password);
					}
				}

				static Delegate cb_setTlsAlpnProtocols_Ljava_util_List_;
#pragma warning disable 0169
				static Delegate GetSetTlsAlpnProtocols_Ljava_util_List_Handler ()
				{
					if (cb_setTlsAlpnProtocols_Ljava_util_List_ == null)
						cb_setTlsAlpnProtocols_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTlsAlpnProtocols_Ljava_util_List_);
					return cb_setTlsAlpnProtocols_Ljava_util_List_;
				}

				static IntPtr n_SetTlsAlpnProtocols_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tlsAlpnProtocols)
				{
					global::Org.Webrtc.PeerConnection.IceServer.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceServer.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					var tlsAlpnProtocols = global::Android.Runtime.JavaList<string>.FromJniHandle (native_tlsAlpnProtocols, JniHandleOwnership.DoNotTransfer);
					IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTlsAlpnProtocols (tlsAlpnProtocols));
					return __ret;
				}
#pragma warning restore 0169

				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceServer.Builder']/method[@name='setTlsAlpnProtocols' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
				[Register ("setTlsAlpnProtocols", "(Ljava/util/List;)Lorg/webrtc/PeerConnection$IceServer$Builder;", "GetSetTlsAlpnProtocols_Ljava_util_List_Handler")]
				public virtual unsafe global::Org.Webrtc.PeerConnection.IceServer.Builder SetTlsAlpnProtocols (global::System.Collections.Generic.IList<string> tlsAlpnProtocols)
				{
					const string __id = "setTlsAlpnProtocols.(Ljava/util/List;)Lorg/webrtc/PeerConnection$IceServer$Builder;";
					IntPtr native_tlsAlpnProtocols = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (tlsAlpnProtocols);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_tlsAlpnProtocols);
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceServer.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_tlsAlpnProtocols);
					}
				}

				static Delegate cb_setTlsCertPolicy_Lorg_webrtc_PeerConnection_TlsCertPolicy_;
#pragma warning disable 0169
				static Delegate GetSetTlsCertPolicy_Lorg_webrtc_PeerConnection_TlsCertPolicy_Handler ()
				{
					if (cb_setTlsCertPolicy_Lorg_webrtc_PeerConnection_TlsCertPolicy_ == null)
						cb_setTlsCertPolicy_Lorg_webrtc_PeerConnection_TlsCertPolicy_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTlsCertPolicy_Lorg_webrtc_PeerConnection_TlsCertPolicy_);
					return cb_setTlsCertPolicy_Lorg_webrtc_PeerConnection_TlsCertPolicy_;
				}

				static IntPtr n_SetTlsCertPolicy_Lorg_webrtc_PeerConnection_TlsCertPolicy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tlsCertPolicy)
				{
					global::Org.Webrtc.PeerConnection.IceServer.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceServer.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					global::Org.Webrtc.PeerConnection.TlsCertPolicy tlsCertPolicy = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.TlsCertPolicy> (native_tlsCertPolicy, JniHandleOwnership.DoNotTransfer);
					IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTlsCertPolicy (tlsCertPolicy));
					return __ret;
				}
#pragma warning restore 0169

				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceServer.Builder']/method[@name='setTlsCertPolicy' and count(parameter)=1 and parameter[1][@type='org.webrtc.PeerConnection.TlsCertPolicy']]"
				[Register ("setTlsCertPolicy", "(Lorg/webrtc/PeerConnection$TlsCertPolicy;)Lorg/webrtc/PeerConnection$IceServer$Builder;", "GetSetTlsCertPolicy_Lorg_webrtc_PeerConnection_TlsCertPolicy_Handler")]
				public virtual unsafe global::Org.Webrtc.PeerConnection.IceServer.Builder SetTlsCertPolicy (global::Org.Webrtc.PeerConnection.TlsCertPolicy tlsCertPolicy)
				{
					const string __id = "setTlsCertPolicy.(Lorg/webrtc/PeerConnection$TlsCertPolicy;)Lorg/webrtc/PeerConnection$IceServer$Builder;";
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue ((tlsCertPolicy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tlsCertPolicy).Handle);
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceServer.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}

				static Delegate cb_setTlsEllipticCurves_Ljava_util_List_;
#pragma warning disable 0169
				static Delegate GetSetTlsEllipticCurves_Ljava_util_List_Handler ()
				{
					if (cb_setTlsEllipticCurves_Ljava_util_List_ == null)
						cb_setTlsEllipticCurves_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTlsEllipticCurves_Ljava_util_List_);
					return cb_setTlsEllipticCurves_Ljava_util_List_;
				}

				static IntPtr n_SetTlsEllipticCurves_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tlsEllipticCurves)
				{
					global::Org.Webrtc.PeerConnection.IceServer.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceServer.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					var tlsEllipticCurves = global::Android.Runtime.JavaList<string>.FromJniHandle (native_tlsEllipticCurves, JniHandleOwnership.DoNotTransfer);
					IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTlsEllipticCurves (tlsEllipticCurves));
					return __ret;
				}
#pragma warning restore 0169

				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceServer.Builder']/method[@name='setTlsEllipticCurves' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
				[Register ("setTlsEllipticCurves", "(Ljava/util/List;)Lorg/webrtc/PeerConnection$IceServer$Builder;", "GetSetTlsEllipticCurves_Ljava_util_List_Handler")]
				public virtual unsafe global::Org.Webrtc.PeerConnection.IceServer.Builder SetTlsEllipticCurves (global::System.Collections.Generic.IList<string> tlsEllipticCurves)
				{
					const string __id = "setTlsEllipticCurves.(Ljava/util/List;)Lorg/webrtc/PeerConnection$IceServer$Builder;";
					IntPtr native_tlsEllipticCurves = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (tlsEllipticCurves);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_tlsEllipticCurves);
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceServer.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_tlsEllipticCurves);
					}
				}

				static Delegate cb_setUsername_Ljava_lang_String_;
#pragma warning disable 0169
				static Delegate GetSetUsername_Ljava_lang_String_Handler ()
				{
					if (cb_setUsername_Ljava_lang_String_ == null)
						cb_setUsername_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetUsername_Ljava_lang_String_);
					return cb_setUsername_Ljava_lang_String_;
				}

				static IntPtr n_SetUsername_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_username)
				{
					global::Org.Webrtc.PeerConnection.IceServer.Builder __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceServer.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					string username = JNIEnv.GetString (native_username, JniHandleOwnership.DoNotTransfer);
					IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUsername (username));
					return __ret;
				}
#pragma warning restore 0169

				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceServer.Builder']/method[@name='setUsername' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setUsername", "(Ljava/lang/String;)Lorg/webrtc/PeerConnection$IceServer$Builder;", "GetSetUsername_Ljava_lang_String_Handler")]
				public virtual unsafe global::Org.Webrtc.PeerConnection.IceServer.Builder SetUsername (string username)
				{
					const string __id = "setUsername.(Ljava/lang/String;)Lorg/webrtc/PeerConnection$IceServer$Builder;";
					IntPtr native_username = JNIEnv.NewString (username);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_username);
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
						return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceServer.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_username);
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/PeerConnection$IceServer", typeof (IceServer));
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

			protected IceServer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceServer']/constructor[@name='PeerConnection.IceServer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			[Obsolete (@"deprecated")]
			public unsafe IceServer (string uri)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_uri = JNIEnv.NewString (uri);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_uri);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_uri);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceServer']/constructor[@name='PeerConnection.IceServer' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
			[Obsolete (@"deprecated")]
			public unsafe IceServer (string uri, string username, string password)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_uri = JNIEnv.NewString (uri);
				IntPtr native_username = JNIEnv.NewString (username);
				IntPtr native_password = JNIEnv.NewString (password);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_uri);
					__args [1] = new JniArgumentValue (native_username);
					__args [2] = new JniArgumentValue (native_password);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_uri);
					JNIEnv.DeleteLocalRef (native_username);
					JNIEnv.DeleteLocalRef (native_password);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceServer']/constructor[@name='PeerConnection.IceServer' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='org.webrtc.PeerConnection.TlsCertPolicy']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/webrtc/PeerConnection$TlsCertPolicy;)V", "")]
			[Obsolete (@"deprecated")]
			public unsafe IceServer (string uri, string username, string password, global::Org.Webrtc.PeerConnection.TlsCertPolicy tlsCertPolicy)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/webrtc/PeerConnection$TlsCertPolicy;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_uri = JNIEnv.NewString (uri);
				IntPtr native_username = JNIEnv.NewString (username);
				IntPtr native_password = JNIEnv.NewString (password);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (native_uri);
					__args [1] = new JniArgumentValue (native_username);
					__args [2] = new JniArgumentValue (native_password);
					__args [3] = new JniArgumentValue ((tlsCertPolicy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tlsCertPolicy).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_uri);
					JNIEnv.DeleteLocalRef (native_username);
					JNIEnv.DeleteLocalRef (native_password);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceServer']/constructor[@name='PeerConnection.IceServer' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='org.webrtc.PeerConnection.TlsCertPolicy'] and parameter[5][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/webrtc/PeerConnection$TlsCertPolicy;Ljava/lang/String;)V", "")]
			[Obsolete (@"deprecated")]
			public unsafe IceServer (string uri, string username, string password, global::Org.Webrtc.PeerConnection.TlsCertPolicy tlsCertPolicy, string hostname)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/webrtc/PeerConnection$TlsCertPolicy;Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_uri = JNIEnv.NewString (uri);
				IntPtr native_username = JNIEnv.NewString (username);
				IntPtr native_password = JNIEnv.NewString (password);
				IntPtr native_hostname = JNIEnv.NewString (hostname);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue (native_uri);
					__args [1] = new JniArgumentValue (native_username);
					__args [2] = new JniArgumentValue (native_password);
					__args [3] = new JniArgumentValue ((tlsCertPolicy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tlsCertPolicy).Handle);
					__args [4] = new JniArgumentValue (native_hostname);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_uri);
					JNIEnv.DeleteLocalRef (native_username);
					JNIEnv.DeleteLocalRef (native_password);
					JNIEnv.DeleteLocalRef (native_hostname);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceServer']/method[@name='builder' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("builder", "(Ljava/lang/String;)Lorg/webrtc/PeerConnection$IceServer$Builder;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.IceServer.Builder InvokeBuilder (string uri)
			{
				const string __id = "builder.(Ljava/lang/String;)Lorg/webrtc/PeerConnection$IceServer$Builder;";
				IntPtr native_uri = JNIEnv.NewString (uri);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_uri);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceServer.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_uri);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceServer']/method[@name='builder' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("builder", "(Ljava/util/List;)Lorg/webrtc/PeerConnection$IceServer$Builder;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.IceServer.Builder InvokeBuilder (global::System.Collections.Generic.IList<string> urls)
			{
				const string __id = "builder.(Ljava/util/List;)Lorg/webrtc/PeerConnection$IceServer$Builder;";
				IntPtr native_urls = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (urls);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_urls);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceServer.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_urls);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceTransportsType']"
		[global::Android.Runtime.Register ("org/webrtc/PeerConnection$IceTransportsType", DoNotGenerateAcw=true)]
		public sealed partial class IceTransportsType : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceTransportsType']/field[@name='ALL']"
			[Register ("ALL")]
			public static global::Org.Webrtc.PeerConnection.IceTransportsType All {
				get {
					const string __id = "ALL.Lorg/webrtc/PeerConnection$IceTransportsType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceTransportsType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceTransportsType']/field[@name='NOHOST']"
			[Register ("NOHOST")]
			public static global::Org.Webrtc.PeerConnection.IceTransportsType Nohost {
				get {
					const string __id = "NOHOST.Lorg/webrtc/PeerConnection$IceTransportsType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceTransportsType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceTransportsType']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::Org.Webrtc.PeerConnection.IceTransportsType None {
				get {
					const string __id = "NONE.Lorg/webrtc/PeerConnection$IceTransportsType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceTransportsType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceTransportsType']/field[@name='RELAY']"
			[Register ("RELAY")]
			public static global::Org.Webrtc.PeerConnection.IceTransportsType Relay {
				get {
					const string __id = "RELAY.Lorg/webrtc/PeerConnection$IceTransportsType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceTransportsType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/PeerConnection$IceTransportsType", typeof (IceTransportsType));
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

			internal IceTransportsType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceTransportsType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/PeerConnection$IceTransportsType;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.IceTransportsType ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/webrtc/PeerConnection$IceTransportsType;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceTransportsType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceTransportsType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/PeerConnection$IceTransportsType;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.IceTransportsType[] Values ()
			{
				const string __id = "values.()[Lorg/webrtc/PeerConnection$IceTransportsType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Webrtc.PeerConnection.IceTransportsType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.PeerConnection.IceTransportsType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.KeyType']"
		[global::Android.Runtime.Register ("org/webrtc/PeerConnection$KeyType", DoNotGenerateAcw=true)]
		public sealed partial class KeyType : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.KeyType']/field[@name='ECDSA']"
			[Register ("ECDSA")]
			public static global::Org.Webrtc.PeerConnection.KeyType Ecdsa {
				get {
					const string __id = "ECDSA.Lorg/webrtc/PeerConnection$KeyType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.KeyType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.KeyType']/field[@name='RSA']"
			[Register ("RSA")]
			public static global::Org.Webrtc.PeerConnection.KeyType Rsa {
				get {
					const string __id = "RSA.Lorg/webrtc/PeerConnection$KeyType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.KeyType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/PeerConnection$KeyType", typeof (KeyType));
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

			internal KeyType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.KeyType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/PeerConnection$KeyType;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.KeyType ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/webrtc/PeerConnection$KeyType;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.KeyType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.KeyType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/PeerConnection$KeyType;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.KeyType[] Values ()
			{
				const string __id = "values.()[Lorg/webrtc/PeerConnection$KeyType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Webrtc.PeerConnection.KeyType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.PeerConnection.KeyType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='PeerConnection.Observer']"
		[Register ("org/webrtc/PeerConnection$Observer", "", "Org.Webrtc.PeerConnection/IObserverInvoker")]
		public partial interface IObserver : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='PeerConnection.Observer']/method[@name='onAddStream' and count(parameter)=1 and parameter[1][@type='org.webrtc.MediaStream']]"
			[Register ("onAddStream", "(Lorg/webrtc/MediaStream;)V", "GetOnAddStream_Lorg_webrtc_MediaStream_Handler:Org.Webrtc.PeerConnection/IObserverInvoker, webrtc_android")]
			void OnAddStream (global::Org.Webrtc.MediaStream p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='PeerConnection.Observer']/method[@name='onAddTrack' and count(parameter)=2 and parameter[1][@type='org.webrtc.RtpReceiver'] and parameter[2][@type='org.webrtc.MediaStream[]']]"
			[Register ("onAddTrack", "(Lorg/webrtc/RtpReceiver;[Lorg/webrtc/MediaStream;)V", "GetOnAddTrack_Lorg_webrtc_RtpReceiver_arrayLorg_webrtc_MediaStream_Handler:Org.Webrtc.PeerConnection/IObserverInvoker, webrtc_android")]
			void OnAddTrack (global::Org.Webrtc.RtpReceiver p0, global::Org.Webrtc.MediaStream[] p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='PeerConnection.Observer']/method[@name='onDataChannel' and count(parameter)=1 and parameter[1][@type='org.webrtc.DataChannel']]"
			[Register ("onDataChannel", "(Lorg/webrtc/DataChannel;)V", "GetOnDataChannel_Lorg_webrtc_DataChannel_Handler:Org.Webrtc.PeerConnection/IObserverInvoker, webrtc_android")]
			void OnDataChannel (global::Org.Webrtc.DataChannel p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='PeerConnection.Observer']/method[@name='onIceCandidate' and count(parameter)=1 and parameter[1][@type='org.webrtc.IceCandidate']]"
			[Register ("onIceCandidate", "(Lorg/webrtc/IceCandidate;)V", "GetOnIceCandidate_Lorg_webrtc_IceCandidate_Handler:Org.Webrtc.PeerConnection/IObserverInvoker, webrtc_android")]
			void OnIceCandidate (global::Org.Webrtc.IceCandidate p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='PeerConnection.Observer']/method[@name='onIceCandidatesRemoved' and count(parameter)=1 and parameter[1][@type='org.webrtc.IceCandidate[]']]"
			[Register ("onIceCandidatesRemoved", "([Lorg/webrtc/IceCandidate;)V", "GetOnIceCandidatesRemoved_arrayLorg_webrtc_IceCandidate_Handler:Org.Webrtc.PeerConnection/IObserverInvoker, webrtc_android")]
			void OnIceCandidatesRemoved (global::Org.Webrtc.IceCandidate[] p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='PeerConnection.Observer']/method[@name='onIceConnectionChange' and count(parameter)=1 and parameter[1][@type='org.webrtc.PeerConnection.IceConnectionState']]"
			[Register ("onIceConnectionChange", "(Lorg/webrtc/PeerConnection$IceConnectionState;)V", "GetOnIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_Handler:Org.Webrtc.PeerConnection/IObserverInvoker, webrtc_android")]
			void OnIceConnectionChange (global::Org.Webrtc.PeerConnection.IceConnectionState p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='PeerConnection.Observer']/method[@name='onIceConnectionReceivingChange' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("onIceConnectionReceivingChange", "(Z)V", "GetOnIceConnectionReceivingChange_ZHandler:Org.Webrtc.PeerConnection/IObserverInvoker, webrtc_android")]
			void OnIceConnectionReceivingChange (bool p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='PeerConnection.Observer']/method[@name='onIceGatheringChange' and count(parameter)=1 and parameter[1][@type='org.webrtc.PeerConnection.IceGatheringState']]"
			[Register ("onIceGatheringChange", "(Lorg/webrtc/PeerConnection$IceGatheringState;)V", "GetOnIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_Handler:Org.Webrtc.PeerConnection/IObserverInvoker, webrtc_android")]
			void OnIceGatheringChange (global::Org.Webrtc.PeerConnection.IceGatheringState p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='PeerConnection.Observer']/method[@name='onRemoveStream' and count(parameter)=1 and parameter[1][@type='org.webrtc.MediaStream']]"
			[Register ("onRemoveStream", "(Lorg/webrtc/MediaStream;)V", "GetOnRemoveStream_Lorg_webrtc_MediaStream_Handler:Org.Webrtc.PeerConnection/IObserverInvoker, webrtc_android")]
			void OnRemoveStream (global::Org.Webrtc.MediaStream p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='PeerConnection.Observer']/method[@name='onRenegotiationNeeded' and count(parameter)=0]"
			[Register ("onRenegotiationNeeded", "()V", "GetOnRenegotiationNeededHandler:Org.Webrtc.PeerConnection/IObserverInvoker, webrtc_android")]
			void OnRenegotiationNeeded ();

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='PeerConnection.Observer']/method[@name='onSignalingChange' and count(parameter)=1 and parameter[1][@type='org.webrtc.PeerConnection.SignalingState']]"
			[Register ("onSignalingChange", "(Lorg/webrtc/PeerConnection$SignalingState;)V", "GetOnSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_Handler:Org.Webrtc.PeerConnection/IObserverInvoker, webrtc_android")]
			void OnSignalingChange (global::Org.Webrtc.PeerConnection.SignalingState p0);

		}

		[global::Android.Runtime.Register ("org/webrtc/PeerConnection$Observer", DoNotGenerateAcw=true)]
		internal partial class IObserverInvoker : global::Java.Lang.Object, IObserver {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/PeerConnection$Observer", typeof (IObserverInvoker));

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
								JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.PeerConnection.Observer"));
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

			static Delegate cb_onAddStream_Lorg_webrtc_MediaStream_;
#pragma warning disable 0169
			static Delegate GetOnAddStream_Lorg_webrtc_MediaStream_Handler ()
			{
				if (cb_onAddStream_Lorg_webrtc_MediaStream_ == null)
					cb_onAddStream_Lorg_webrtc_MediaStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAddStream_Lorg_webrtc_MediaStream_);
				return cb_onAddStream_Lorg_webrtc_MediaStream_;
			}

			static void n_OnAddStream_Lorg_webrtc_MediaStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.PeerConnection.IObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.MediaStream p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStream> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAddStream (p0);
			}
#pragma warning restore 0169

			IntPtr id_onAddStream_Lorg_webrtc_MediaStream_;
			public unsafe void OnAddStream (global::Org.Webrtc.MediaStream p0)
			{
				if (id_onAddStream_Lorg_webrtc_MediaStream_ == IntPtr.Zero)
					id_onAddStream_Lorg_webrtc_MediaStream_ = JNIEnv.GetMethodID (class_ref, "onAddStream", "(Lorg/webrtc/MediaStream;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAddStream_Lorg_webrtc_MediaStream_, __args);
			}

			static Delegate cb_onAddTrack_Lorg_webrtc_RtpReceiver_arrayLorg_webrtc_MediaStream_;
#pragma warning disable 0169
			static Delegate GetOnAddTrack_Lorg_webrtc_RtpReceiver_arrayLorg_webrtc_MediaStream_Handler ()
			{
				if (cb_onAddTrack_Lorg_webrtc_RtpReceiver_arrayLorg_webrtc_MediaStream_ == null)
					cb_onAddTrack_Lorg_webrtc_RtpReceiver_arrayLorg_webrtc_MediaStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnAddTrack_Lorg_webrtc_RtpReceiver_arrayLorg_webrtc_MediaStream_);
				return cb_onAddTrack_Lorg_webrtc_RtpReceiver_arrayLorg_webrtc_MediaStream_;
			}

			static void n_OnAddTrack_Lorg_webrtc_RtpReceiver_arrayLorg_webrtc_MediaStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Org.Webrtc.PeerConnection.IObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.RtpReceiver p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpReceiver> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.MediaStream[] p1 = (global::Org.Webrtc.MediaStream[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Webrtc.MediaStream));
				__this.OnAddTrack (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
			}
#pragma warning restore 0169

			IntPtr id_onAddTrack_Lorg_webrtc_RtpReceiver_arrayLorg_webrtc_MediaStream_;
			public unsafe void OnAddTrack (global::Org.Webrtc.RtpReceiver p0, global::Org.Webrtc.MediaStream[] p1)
			{
				if (id_onAddTrack_Lorg_webrtc_RtpReceiver_arrayLorg_webrtc_MediaStream_ == IntPtr.Zero)
					id_onAddTrack_Lorg_webrtc_RtpReceiver_arrayLorg_webrtc_MediaStream_ = JNIEnv.GetMethodID (class_ref, "onAddTrack", "(Lorg/webrtc/RtpReceiver;[Lorg/webrtc/MediaStream;)V");
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAddTrack_Lorg_webrtc_RtpReceiver_arrayLorg_webrtc_MediaStream_, __args);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_onDataChannel_Lorg_webrtc_DataChannel_;
#pragma warning disable 0169
			static Delegate GetOnDataChannel_Lorg_webrtc_DataChannel_Handler ()
			{
				if (cb_onDataChannel_Lorg_webrtc_DataChannel_ == null)
					cb_onDataChannel_Lorg_webrtc_DataChannel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDataChannel_Lorg_webrtc_DataChannel_);
				return cb_onDataChannel_Lorg_webrtc_DataChannel_;
			}

			static void n_OnDataChannel_Lorg_webrtc_DataChannel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.PeerConnection.IObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.DataChannel p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnDataChannel (p0);
			}
#pragma warning restore 0169

			IntPtr id_onDataChannel_Lorg_webrtc_DataChannel_;
			public unsafe void OnDataChannel (global::Org.Webrtc.DataChannel p0)
			{
				if (id_onDataChannel_Lorg_webrtc_DataChannel_ == IntPtr.Zero)
					id_onDataChannel_Lorg_webrtc_DataChannel_ = JNIEnv.GetMethodID (class_ref, "onDataChannel", "(Lorg/webrtc/DataChannel;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDataChannel_Lorg_webrtc_DataChannel_, __args);
			}

			static Delegate cb_onIceCandidate_Lorg_webrtc_IceCandidate_;
#pragma warning disable 0169
			static Delegate GetOnIceCandidate_Lorg_webrtc_IceCandidate_Handler ()
			{
				if (cb_onIceCandidate_Lorg_webrtc_IceCandidate_ == null)
					cb_onIceCandidate_Lorg_webrtc_IceCandidate_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnIceCandidate_Lorg_webrtc_IceCandidate_);
				return cb_onIceCandidate_Lorg_webrtc_IceCandidate_;
			}

			static void n_OnIceCandidate_Lorg_webrtc_IceCandidate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.PeerConnection.IObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.IceCandidate p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IceCandidate> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnIceCandidate (p0);
			}
#pragma warning restore 0169

			IntPtr id_onIceCandidate_Lorg_webrtc_IceCandidate_;
			public unsafe void OnIceCandidate (global::Org.Webrtc.IceCandidate p0)
			{
				if (id_onIceCandidate_Lorg_webrtc_IceCandidate_ == IntPtr.Zero)
					id_onIceCandidate_Lorg_webrtc_IceCandidate_ = JNIEnv.GetMethodID (class_ref, "onIceCandidate", "(Lorg/webrtc/IceCandidate;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onIceCandidate_Lorg_webrtc_IceCandidate_, __args);
			}

			static Delegate cb_onIceCandidatesRemoved_arrayLorg_webrtc_IceCandidate_;
#pragma warning disable 0169
			static Delegate GetOnIceCandidatesRemoved_arrayLorg_webrtc_IceCandidate_Handler ()
			{
				if (cb_onIceCandidatesRemoved_arrayLorg_webrtc_IceCandidate_ == null)
					cb_onIceCandidatesRemoved_arrayLorg_webrtc_IceCandidate_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnIceCandidatesRemoved_arrayLorg_webrtc_IceCandidate_);
				return cb_onIceCandidatesRemoved_arrayLorg_webrtc_IceCandidate_;
			}

			static void n_OnIceCandidatesRemoved_arrayLorg_webrtc_IceCandidate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.PeerConnection.IObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.IceCandidate[] p0 = (global::Org.Webrtc.IceCandidate[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Webrtc.IceCandidate));
				__this.OnIceCandidatesRemoved (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			IntPtr id_onIceCandidatesRemoved_arrayLorg_webrtc_IceCandidate_;
			public unsafe void OnIceCandidatesRemoved (global::Org.Webrtc.IceCandidate[] p0)
			{
				if (id_onIceCandidatesRemoved_arrayLorg_webrtc_IceCandidate_ == IntPtr.Zero)
					id_onIceCandidatesRemoved_arrayLorg_webrtc_IceCandidate_ = JNIEnv.GetMethodID (class_ref, "onIceCandidatesRemoved", "([Lorg/webrtc/IceCandidate;)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onIceCandidatesRemoved_arrayLorg_webrtc_IceCandidate_, __args);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_onIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_;
#pragma warning disable 0169
			static Delegate GetOnIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_Handler ()
			{
				if (cb_onIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_ == null)
					cb_onIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_);
				return cb_onIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_;
			}

			static void n_OnIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.PeerConnection.IObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.PeerConnection.IceConnectionState p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceConnectionState> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnIceConnectionChange (p0);
			}
#pragma warning restore 0169

			IntPtr id_onIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_;
			public unsafe void OnIceConnectionChange (global::Org.Webrtc.PeerConnection.IceConnectionState p0)
			{
				if (id_onIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_ == IntPtr.Zero)
					id_onIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_ = JNIEnv.GetMethodID (class_ref, "onIceConnectionChange", "(Lorg/webrtc/PeerConnection$IceConnectionState;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_, __args);
			}

			static Delegate cb_onIceConnectionReceivingChange_Z;
#pragma warning disable 0169
			static Delegate GetOnIceConnectionReceivingChange_ZHandler ()
			{
				if (cb_onIceConnectionReceivingChange_Z == null)
					cb_onIceConnectionReceivingChange_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnIceConnectionReceivingChange_Z);
				return cb_onIceConnectionReceivingChange_Z;
			}

			static void n_OnIceConnectionReceivingChange_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Org.Webrtc.PeerConnection.IObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnIceConnectionReceivingChange (p0);
			}
#pragma warning restore 0169

			IntPtr id_onIceConnectionReceivingChange_Z;
			public unsafe void OnIceConnectionReceivingChange (bool p0)
			{
				if (id_onIceConnectionReceivingChange_Z == IntPtr.Zero)
					id_onIceConnectionReceivingChange_Z = JNIEnv.GetMethodID (class_ref, "onIceConnectionReceivingChange", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onIceConnectionReceivingChange_Z, __args);
			}

			static Delegate cb_onIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_;
#pragma warning disable 0169
			static Delegate GetOnIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_Handler ()
			{
				if (cb_onIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_ == null)
					cb_onIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_);
				return cb_onIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_;
			}

			static void n_OnIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.PeerConnection.IObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.PeerConnection.IceGatheringState p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceGatheringState> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnIceGatheringChange (p0);
			}
#pragma warning restore 0169

			IntPtr id_onIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_;
			public unsafe void OnIceGatheringChange (global::Org.Webrtc.PeerConnection.IceGatheringState p0)
			{
				if (id_onIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_ == IntPtr.Zero)
					id_onIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_ = JNIEnv.GetMethodID (class_ref, "onIceGatheringChange", "(Lorg/webrtc/PeerConnection$IceGatheringState;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_, __args);
			}

			static Delegate cb_onRemoveStream_Lorg_webrtc_MediaStream_;
#pragma warning disable 0169
			static Delegate GetOnRemoveStream_Lorg_webrtc_MediaStream_Handler ()
			{
				if (cb_onRemoveStream_Lorg_webrtc_MediaStream_ == null)
					cb_onRemoveStream_Lorg_webrtc_MediaStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRemoveStream_Lorg_webrtc_MediaStream_);
				return cb_onRemoveStream_Lorg_webrtc_MediaStream_;
			}

			static void n_OnRemoveStream_Lorg_webrtc_MediaStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.PeerConnection.IObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.MediaStream p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStream> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnRemoveStream (p0);
			}
#pragma warning restore 0169

			IntPtr id_onRemoveStream_Lorg_webrtc_MediaStream_;
			public unsafe void OnRemoveStream (global::Org.Webrtc.MediaStream p0)
			{
				if (id_onRemoveStream_Lorg_webrtc_MediaStream_ == IntPtr.Zero)
					id_onRemoveStream_Lorg_webrtc_MediaStream_ = JNIEnv.GetMethodID (class_ref, "onRemoveStream", "(Lorg/webrtc/MediaStream;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRemoveStream_Lorg_webrtc_MediaStream_, __args);
			}

			static Delegate cb_onRenegotiationNeeded;
#pragma warning disable 0169
			static Delegate GetOnRenegotiationNeededHandler ()
			{
				if (cb_onRenegotiationNeeded == null)
					cb_onRenegotiationNeeded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRenegotiationNeeded);
				return cb_onRenegotiationNeeded;
			}

			static void n_OnRenegotiationNeeded (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.PeerConnection.IObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnRenegotiationNeeded ();
			}
#pragma warning restore 0169

			IntPtr id_onRenegotiationNeeded;
			public unsafe void OnRenegotiationNeeded ()
			{
				if (id_onRenegotiationNeeded == IntPtr.Zero)
					id_onRenegotiationNeeded = JNIEnv.GetMethodID (class_ref, "onRenegotiationNeeded", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRenegotiationNeeded);
			}

			static Delegate cb_onSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_;
#pragma warning disable 0169
			static Delegate GetOnSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_Handler ()
			{
				if (cb_onSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_ == null)
					cb_onSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_);
				return cb_onSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_;
			}

			static void n_OnSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.PeerConnection.IObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.PeerConnection.SignalingState p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.SignalingState> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSignalingChange (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_;
			public unsafe void OnSignalingChange (global::Org.Webrtc.PeerConnection.SignalingState p0)
			{
				if (id_onSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_ == IntPtr.Zero)
					id_onSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_ = JNIEnv.GetMethodID (class_ref, "onSignalingChange", "(Lorg/webrtc/PeerConnection$SignalingState;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_, __args);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.PeerConnectionState']"
		[global::Android.Runtime.Register ("org/webrtc/PeerConnection$PeerConnectionState", DoNotGenerateAcw=true)]
		public sealed partial class PeerConnectionState : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.PeerConnectionState']/field[@name='CLOSED']"
			[Register ("CLOSED")]
			public static global::Org.Webrtc.PeerConnection.PeerConnectionState Closed {
				get {
					const string __id = "CLOSED.Lorg/webrtc/PeerConnection$PeerConnectionState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.PeerConnectionState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.PeerConnectionState']/field[@name='CONNECTED']"
			[Register ("CONNECTED")]
			public static global::Org.Webrtc.PeerConnection.PeerConnectionState Connected {
				get {
					const string __id = "CONNECTED.Lorg/webrtc/PeerConnection$PeerConnectionState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.PeerConnectionState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.PeerConnectionState']/field[@name='CONNECTING']"
			[Register ("CONNECTING")]
			public static global::Org.Webrtc.PeerConnection.PeerConnectionState Connecting {
				get {
					const string __id = "CONNECTING.Lorg/webrtc/PeerConnection$PeerConnectionState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.PeerConnectionState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.PeerConnectionState']/field[@name='DISCONNECTED']"
			[Register ("DISCONNECTED")]
			public static global::Org.Webrtc.PeerConnection.PeerConnectionState Disconnected {
				get {
					const string __id = "DISCONNECTED.Lorg/webrtc/PeerConnection$PeerConnectionState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.PeerConnectionState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.PeerConnectionState']/field[@name='FAILED']"
			[Register ("FAILED")]
			public static global::Org.Webrtc.PeerConnection.PeerConnectionState Failed {
				get {
					const string __id = "FAILED.Lorg/webrtc/PeerConnection$PeerConnectionState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.PeerConnectionState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.PeerConnectionState']/field[@name='NEW']"
			[Register ("NEW")]
			public static global::Org.Webrtc.PeerConnection.PeerConnectionState New {
				get {
					const string __id = "NEW.Lorg/webrtc/PeerConnection$PeerConnectionState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.PeerConnectionState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/PeerConnection$PeerConnectionState", typeof (PeerConnectionState));
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

			internal PeerConnectionState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.PeerConnectionState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/PeerConnection$PeerConnectionState;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.PeerConnectionState ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/webrtc/PeerConnection$PeerConnectionState;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.PeerConnectionState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.PeerConnectionState']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/PeerConnection$PeerConnectionState;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.PeerConnectionState[] Values ()
			{
				const string __id = "values.()[Lorg/webrtc/PeerConnection$PeerConnectionState;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Webrtc.PeerConnection.PeerConnectionState[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.PeerConnection.PeerConnectionState));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.PortPrunePolicy']"
		[global::Android.Runtime.Register ("org/webrtc/PeerConnection$PortPrunePolicy", DoNotGenerateAcw=true)]
		public sealed partial class PortPrunePolicy : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.PortPrunePolicy']/field[@name='KEEP_FIRST_READY']"
			[Register ("KEEP_FIRST_READY")]
			public static global::Org.Webrtc.PeerConnection.PortPrunePolicy KeepFirstReady {
				get {
					const string __id = "KEEP_FIRST_READY.Lorg/webrtc/PeerConnection$PortPrunePolicy;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.PortPrunePolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.PortPrunePolicy']/field[@name='NO_PRUNE']"
			[Register ("NO_PRUNE")]
			public static global::Org.Webrtc.PeerConnection.PortPrunePolicy NoPrune {
				get {
					const string __id = "NO_PRUNE.Lorg/webrtc/PeerConnection$PortPrunePolicy;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.PortPrunePolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.PortPrunePolicy']/field[@name='PRUNE_BASED_ON_PRIORITY']"
			[Register ("PRUNE_BASED_ON_PRIORITY")]
			public static global::Org.Webrtc.PeerConnection.PortPrunePolicy PruneBasedOnPriority {
				get {
					const string __id = "PRUNE_BASED_ON_PRIORITY.Lorg/webrtc/PeerConnection$PortPrunePolicy;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.PortPrunePolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/PeerConnection$PortPrunePolicy", typeof (PortPrunePolicy));
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

			internal PortPrunePolicy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.PortPrunePolicy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/PeerConnection$PortPrunePolicy;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.PortPrunePolicy ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/webrtc/PeerConnection$PortPrunePolicy;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.PortPrunePolicy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.PortPrunePolicy']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/PeerConnection$PortPrunePolicy;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.PortPrunePolicy[] Values ()
			{
				const string __id = "values.()[Lorg/webrtc/PeerConnection$PortPrunePolicy;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Webrtc.PeerConnection.PortPrunePolicy[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.PeerConnection.PortPrunePolicy));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']"
		[global::Android.Runtime.Register ("org/webrtc/PeerConnection$RTCConfiguration", DoNotGenerateAcw=true)]
		public partial class RTCConfiguration : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='activeResetSrtpParams']"
			[Register ("activeResetSrtpParams")]
			public bool ActiveResetSrtpParams {
				get {
					const string __id = "activeResetSrtpParams.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "activeResetSrtpParams.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='allowCodecSwitching']"
			[Register ("allowCodecSwitching")]
			public global::Java.Lang.Boolean AllowCodecSwitching {
				get {
					const string __id = "allowCodecSwitching.Ljava/lang/Boolean;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "allowCodecSwitching.Ljava/lang/Boolean;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='audioJitterBufferFastAccelerate']"
			[Register ("audioJitterBufferFastAccelerate")]
			public bool AudioJitterBufferFastAccelerate {
				get {
					const string __id = "audioJitterBufferFastAccelerate.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "audioJitterBufferFastAccelerate.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='audioJitterBufferMaxPackets']"
			[Register ("audioJitterBufferMaxPackets")]
			public int AudioJitterBufferMaxPackets {
				get {
					const string __id = "audioJitterBufferMaxPackets.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "audioJitterBufferMaxPackets.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='bundlePolicy']"
			[Register ("bundlePolicy")]
			public global::Org.Webrtc.PeerConnection.BundlePolicy BundlePolicy {
				get {
					const string __id = "bundlePolicy.Lorg/webrtc/PeerConnection$BundlePolicy;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.BundlePolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "bundlePolicy.Lorg/webrtc/PeerConnection$BundlePolicy;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='candidateNetworkPolicy']"
			[Register ("candidateNetworkPolicy")]
			public global::Org.Webrtc.PeerConnection.CandidateNetworkPolicy CandidateNetworkPolicy {
				get {
					const string __id = "candidateNetworkPolicy.Lorg/webrtc/PeerConnection$CandidateNetworkPolicy;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.CandidateNetworkPolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "candidateNetworkPolicy.Lorg/webrtc/PeerConnection$CandidateNetworkPolicy;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='certificate']"
			[Register ("certificate")]
			public global::Org.Webrtc.RtcCertificatePem Certificate {
				get {
					const string __id = "certificate.Lorg/webrtc/RtcCertificatePem;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtcCertificatePem> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "certificate.Lorg/webrtc/RtcCertificatePem;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='combinedAudioVideoBwe']"
			[Register ("combinedAudioVideoBwe")]
			public global::Java.Lang.Boolean CombinedAudioVideoBwe {
				get {
					const string __id = "combinedAudioVideoBwe.Ljava/lang/Boolean;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "combinedAudioVideoBwe.Ljava/lang/Boolean;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='continualGatheringPolicy']"
			[Register ("continualGatheringPolicy")]
			public global::Org.Webrtc.PeerConnection.ContinualGatheringPolicy ContinualGatheringPolicy {
				get {
					const string __id = "continualGatheringPolicy.Lorg/webrtc/PeerConnection$ContinualGatheringPolicy;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.ContinualGatheringPolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "continualGatheringPolicy.Lorg/webrtc/PeerConnection$ContinualGatheringPolicy;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='cryptoOptions']"
			[Register ("cryptoOptions")]
			public global::Org.Webrtc.CryptoOptions CryptoOptions {
				get {
					const string __id = "cryptoOptions.Lorg/webrtc/CryptoOptions;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.CryptoOptions> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "cryptoOptions.Lorg/webrtc/CryptoOptions;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='disableIPv6OnWifi']"
			[Register ("disableIPv6OnWifi")]
			public bool DisableIPv6OnWifi {
				get {
					const string __id = "disableIPv6OnWifi.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "disableIPv6OnWifi.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='disableIpv6']"
			[Register ("disableIpv6")]
			public bool DisableIpv6 {
				get {
					const string __id = "disableIpv6.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "disableIpv6.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='enableCpuOveruseDetection']"
			[Register ("enableCpuOveruseDetection")]
			public bool EnableCpuOveruseDetection {
				get {
					const string __id = "enableCpuOveruseDetection.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "enableCpuOveruseDetection.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='enableDscp']"
			[Register ("enableDscp")]
			public bool EnableDscp {
				get {
					const string __id = "enableDscp.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "enableDscp.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='enableDtlsSrtp']"
			[Register ("enableDtlsSrtp")]
			public global::Java.Lang.Boolean EnableDtlsSrtp {
				get {
					const string __id = "enableDtlsSrtp.Ljava/lang/Boolean;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "enableDtlsSrtp.Ljava/lang/Boolean;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='enableRtpDataChannel']"
			[Register ("enableRtpDataChannel")]
			public bool EnableRtpDataChannel {
				get {
					const string __id = "enableRtpDataChannel.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "enableRtpDataChannel.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='iceBackupCandidatePairPingInterval']"
			[Register ("iceBackupCandidatePairPingInterval")]
			public int IceBackupCandidatePairPingInterval {
				get {
					const string __id = "iceBackupCandidatePairPingInterval.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "iceBackupCandidatePairPingInterval.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='iceCandidatePoolSize']"
			[Register ("iceCandidatePoolSize")]
			public int IceCandidatePoolSize {
				get {
					const string __id = "iceCandidatePoolSize.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "iceCandidatePoolSize.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='iceCheckIntervalStrongConnectivityMs']"
			[Register ("iceCheckIntervalStrongConnectivityMs")]
			public global::Java.Lang.Integer IceCheckIntervalStrongConnectivityMs {
				get {
					const string __id = "iceCheckIntervalStrongConnectivityMs.Ljava/lang/Integer;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "iceCheckIntervalStrongConnectivityMs.Ljava/lang/Integer;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='iceCheckIntervalWeakConnectivityMs']"
			[Register ("iceCheckIntervalWeakConnectivityMs")]
			public global::Java.Lang.Integer IceCheckIntervalWeakConnectivityMs {
				get {
					const string __id = "iceCheckIntervalWeakConnectivityMs.Ljava/lang/Integer;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "iceCheckIntervalWeakConnectivityMs.Ljava/lang/Integer;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='iceCheckMinInterval']"
			[Register ("iceCheckMinInterval")]
			public global::Java.Lang.Integer IceCheckMinInterval {
				get {
					const string __id = "iceCheckMinInterval.Ljava/lang/Integer;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "iceCheckMinInterval.Ljava/lang/Integer;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='iceConnectionReceivingTimeout']"
			[Register ("iceConnectionReceivingTimeout")]
			public int IceConnectionReceivingTimeout {
				get {
					const string __id = "iceConnectionReceivingTimeout.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "iceConnectionReceivingTimeout.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='iceServers']"
			[Register ("iceServers")]
			public global::System.Collections.IList IceServers {
				get {
					const string __id = "iceServers.Ljava/util/List;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "iceServers.Ljava/util/List;";

					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='iceTransportsType']"
			[Register ("iceTransportsType")]
			public global::Org.Webrtc.PeerConnection.IceTransportsType IceTransportsType {
				get {
					const string __id = "iceTransportsType.Lorg/webrtc/PeerConnection$IceTransportsType;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceTransportsType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "iceTransportsType.Lorg/webrtc/PeerConnection$IceTransportsType;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='iceUnwritableMinChecks']"
			[Register ("iceUnwritableMinChecks")]
			public global::Java.Lang.Integer IceUnwritableMinChecks {
				get {
					const string __id = "iceUnwritableMinChecks.Ljava/lang/Integer;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "iceUnwritableMinChecks.Ljava/lang/Integer;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='iceUnwritableTimeMs']"
			[Register ("iceUnwritableTimeMs")]
			public global::Java.Lang.Integer IceUnwritableTimeMs {
				get {
					const string __id = "iceUnwritableTimeMs.Ljava/lang/Integer;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "iceUnwritableTimeMs.Ljava/lang/Integer;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='keyType']"
			[Register ("keyType")]
			public global::Org.Webrtc.PeerConnection.KeyType KeyType {
				get {
					const string __id = "keyType.Lorg/webrtc/PeerConnection$KeyType;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.KeyType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "keyType.Lorg/webrtc/PeerConnection$KeyType;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='maxIPv6Networks']"
			[Register ("maxIPv6Networks")]
			public int MaxIPv6Networks {
				get {
					const string __id = "maxIPv6Networks.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "maxIPv6Networks.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='networkPreference']"
			[Register ("networkPreference")]
			public global::Org.Webrtc.PeerConnection.AdapterType NetworkPreference {
				get {
					const string __id = "networkPreference.Lorg/webrtc/PeerConnection$AdapterType;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.AdapterType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "networkPreference.Lorg/webrtc/PeerConnection$AdapterType;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='presumeWritableWhenFullyRelayed']"
			[Register ("presumeWritableWhenFullyRelayed")]
			public bool PresumeWritableWhenFullyRelayed {
				get {
					const string __id = "presumeWritableWhenFullyRelayed.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "presumeWritableWhenFullyRelayed.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='pruneTurnPorts']"
			[Register ("pruneTurnPorts")]
			[Obsolete ("deprecated")]
			public bool PruneTurnPorts {
				get {
					const string __id = "pruneTurnPorts.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "pruneTurnPorts.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='rtcpMuxPolicy']"
			[Register ("rtcpMuxPolicy")]
			public global::Org.Webrtc.PeerConnection.RtcpMuxPolicy RtcpMuxPolicy {
				get {
					const string __id = "rtcpMuxPolicy.Lorg/webrtc/PeerConnection$RtcpMuxPolicy;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.RtcpMuxPolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "rtcpMuxPolicy.Lorg/webrtc/PeerConnection$RtcpMuxPolicy;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='screencastMinBitrate']"
			[Register ("screencastMinBitrate")]
			public global::Java.Lang.Integer ScreencastMinBitrate {
				get {
					const string __id = "screencastMinBitrate.Ljava/lang/Integer;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "screencastMinBitrate.Ljava/lang/Integer;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='sdpSemantics']"
			[Register ("sdpSemantics")]
			public global::Org.Webrtc.PeerConnection.SdpSemantics SdpSemantics {
				get {
					const string __id = "sdpSemantics.Lorg/webrtc/PeerConnection$SdpSemantics;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.SdpSemantics> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "sdpSemantics.Lorg/webrtc/PeerConnection$SdpSemantics;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='stunCandidateKeepaliveIntervalMs']"
			[Register ("stunCandidateKeepaliveIntervalMs")]
			public global::Java.Lang.Integer StunCandidateKeepaliveIntervalMs {
				get {
					const string __id = "stunCandidateKeepaliveIntervalMs.Ljava/lang/Integer;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "stunCandidateKeepaliveIntervalMs.Ljava/lang/Integer;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='surfaceIceCandidatesOnIceTransportTypeChanged']"
			[Register ("surfaceIceCandidatesOnIceTransportTypeChanged")]
			public bool SurfaceIceCandidatesOnIceTransportTypeChanged {
				get {
					const string __id = "surfaceIceCandidatesOnIceTransportTypeChanged.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "surfaceIceCandidatesOnIceTransportTypeChanged.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='suspendBelowMinBitrate']"
			[Register ("suspendBelowMinBitrate")]
			public bool SuspendBelowMinBitrate {
				get {
					const string __id = "suspendBelowMinBitrate.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "suspendBelowMinBitrate.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='tcpCandidatePolicy']"
			[Register ("tcpCandidatePolicy")]
			public global::Org.Webrtc.PeerConnection.TcpCandidatePolicy TcpCandidatePolicy {
				get {
					const string __id = "tcpCandidatePolicy.Lorg/webrtc/PeerConnection$TcpCandidatePolicy;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.TcpCandidatePolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "tcpCandidatePolicy.Lorg/webrtc/PeerConnection$TcpCandidatePolicy;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='turnCustomizer']"
			[Register ("turnCustomizer")]
			public global::Org.Webrtc.TurnCustomizer TurnCustomizer {
				get {
					const string __id = "turnCustomizer.Lorg/webrtc/TurnCustomizer;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.TurnCustomizer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "turnCustomizer.Lorg/webrtc/TurnCustomizer;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='turnLoggingId']"
			[Register ("turnLoggingId")]
			public string TurnLoggingId {
				get {
					const string __id = "turnLoggingId.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "turnLoggingId.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='turnPortPrunePolicy']"
			[Register ("turnPortPrunePolicy")]
			public global::Org.Webrtc.PeerConnection.PortPrunePolicy TurnPortPrunePolicy {
				get {
					const string __id = "turnPortPrunePolicy.Lorg/webrtc/PeerConnection$PortPrunePolicy;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.PortPrunePolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "turnPortPrunePolicy.Lorg/webrtc/PeerConnection$PortPrunePolicy;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='useMediaTransport']"
			[Register ("useMediaTransport")]
			public bool UseMediaTransport {
				get {
					const string __id = "useMediaTransport.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "useMediaTransport.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='useMediaTransportForDataChannels']"
			[Register ("useMediaTransportForDataChannels")]
			public bool UseMediaTransportForDataChannels {
				get {
					const string __id = "useMediaTransportForDataChannels.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "useMediaTransportForDataChannels.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/PeerConnection$RTCConfiguration", typeof (RTCConfiguration));
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

			protected RTCConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/constructor[@name='PeerConnection.RTCConfiguration' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.webrtc.PeerConnection.IceServer&gt;']]"
			[Register (".ctor", "(Ljava/util/List;)V", "")]
			public unsafe RTCConfiguration (global::System.Collections.Generic.IList<global::Org.Webrtc.PeerConnection.IceServer> iceServers)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/util/List;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_iceServers = global::Android.Runtime.JavaList<global::Org.Webrtc.PeerConnection.IceServer>.ToLocalJniHandle (iceServers);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_iceServers);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_iceServers);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RtcpMuxPolicy']"
		[global::Android.Runtime.Register ("org/webrtc/PeerConnection$RtcpMuxPolicy", DoNotGenerateAcw=true)]
		public sealed partial class RtcpMuxPolicy : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RtcpMuxPolicy']/field[@name='NEGOTIATE']"
			[Register ("NEGOTIATE")]
			public static global::Org.Webrtc.PeerConnection.RtcpMuxPolicy Negotiate {
				get {
					const string __id = "NEGOTIATE.Lorg/webrtc/PeerConnection$RtcpMuxPolicy;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.RtcpMuxPolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RtcpMuxPolicy']/field[@name='REQUIRE']"
			[Register ("REQUIRE")]
			public static global::Org.Webrtc.PeerConnection.RtcpMuxPolicy Require {
				get {
					const string __id = "REQUIRE.Lorg/webrtc/PeerConnection$RtcpMuxPolicy;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.RtcpMuxPolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/PeerConnection$RtcpMuxPolicy", typeof (RtcpMuxPolicy));
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

			internal RtcpMuxPolicy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RtcpMuxPolicy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/PeerConnection$RtcpMuxPolicy;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.RtcpMuxPolicy ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/webrtc/PeerConnection$RtcpMuxPolicy;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.RtcpMuxPolicy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RtcpMuxPolicy']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/PeerConnection$RtcpMuxPolicy;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.RtcpMuxPolicy[] Values ()
			{
				const string __id = "values.()[Lorg/webrtc/PeerConnection$RtcpMuxPolicy;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Webrtc.PeerConnection.RtcpMuxPolicy[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.PeerConnection.RtcpMuxPolicy));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.SdpSemantics']"
		[global::Android.Runtime.Register ("org/webrtc/PeerConnection$SdpSemantics", DoNotGenerateAcw=true)]
		public sealed partial class SdpSemantics : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.SdpSemantics']/field[@name='PLAN_B']"
			[Register ("PLAN_B")]
			public static global::Org.Webrtc.PeerConnection.SdpSemantics PlanB {
				get {
					const string __id = "PLAN_B.Lorg/webrtc/PeerConnection$SdpSemantics;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.SdpSemantics> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.SdpSemantics']/field[@name='UNIFIED_PLAN']"
			[Register ("UNIFIED_PLAN")]
			public static global::Org.Webrtc.PeerConnection.SdpSemantics UnifiedPlan {
				get {
					const string __id = "UNIFIED_PLAN.Lorg/webrtc/PeerConnection$SdpSemantics;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.SdpSemantics> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/PeerConnection$SdpSemantics", typeof (SdpSemantics));
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

			internal SdpSemantics (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.SdpSemantics']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/PeerConnection$SdpSemantics;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.SdpSemantics ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/webrtc/PeerConnection$SdpSemantics;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.SdpSemantics> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.SdpSemantics']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/PeerConnection$SdpSemantics;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.SdpSemantics[] Values ()
			{
				const string __id = "values.()[Lorg/webrtc/PeerConnection$SdpSemantics;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Webrtc.PeerConnection.SdpSemantics[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.PeerConnection.SdpSemantics));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.SignalingState']"
		[global::Android.Runtime.Register ("org/webrtc/PeerConnection$SignalingState", DoNotGenerateAcw=true)]
		public sealed partial class SignalingState : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.SignalingState']/field[@name='CLOSED']"
			[Register ("CLOSED")]
			public static global::Org.Webrtc.PeerConnection.SignalingState Closed {
				get {
					const string __id = "CLOSED.Lorg/webrtc/PeerConnection$SignalingState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.SignalingState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.SignalingState']/field[@name='HAVE_LOCAL_OFFER']"
			[Register ("HAVE_LOCAL_OFFER")]
			public static global::Org.Webrtc.PeerConnection.SignalingState HaveLocalOffer {
				get {
					const string __id = "HAVE_LOCAL_OFFER.Lorg/webrtc/PeerConnection$SignalingState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.SignalingState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.SignalingState']/field[@name='HAVE_LOCAL_PRANSWER']"
			[Register ("HAVE_LOCAL_PRANSWER")]
			public static global::Org.Webrtc.PeerConnection.SignalingState HaveLocalPranswer {
				get {
					const string __id = "HAVE_LOCAL_PRANSWER.Lorg/webrtc/PeerConnection$SignalingState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.SignalingState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.SignalingState']/field[@name='HAVE_REMOTE_OFFER']"
			[Register ("HAVE_REMOTE_OFFER")]
			public static global::Org.Webrtc.PeerConnection.SignalingState HaveRemoteOffer {
				get {
					const string __id = "HAVE_REMOTE_OFFER.Lorg/webrtc/PeerConnection$SignalingState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.SignalingState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.SignalingState']/field[@name='HAVE_REMOTE_PRANSWER']"
			[Register ("HAVE_REMOTE_PRANSWER")]
			public static global::Org.Webrtc.PeerConnection.SignalingState HaveRemotePranswer {
				get {
					const string __id = "HAVE_REMOTE_PRANSWER.Lorg/webrtc/PeerConnection$SignalingState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.SignalingState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.SignalingState']/field[@name='STABLE']"
			[Register ("STABLE")]
			public static global::Org.Webrtc.PeerConnection.SignalingState Stable {
				get {
					const string __id = "STABLE.Lorg/webrtc/PeerConnection$SignalingState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.SignalingState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/PeerConnection$SignalingState", typeof (SignalingState));
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

			internal SignalingState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.SignalingState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/PeerConnection$SignalingState;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.SignalingState ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/webrtc/PeerConnection$SignalingState;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.SignalingState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.SignalingState']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/PeerConnection$SignalingState;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.SignalingState[] Values ()
			{
				const string __id = "values.()[Lorg/webrtc/PeerConnection$SignalingState;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Webrtc.PeerConnection.SignalingState[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.PeerConnection.SignalingState));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.TcpCandidatePolicy']"
		[global::Android.Runtime.Register ("org/webrtc/PeerConnection$TcpCandidatePolicy", DoNotGenerateAcw=true)]
		public sealed partial class TcpCandidatePolicy : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.TcpCandidatePolicy']/field[@name='DISABLED']"
			[Register ("DISABLED")]
			public static global::Org.Webrtc.PeerConnection.TcpCandidatePolicy Disabled {
				get {
					const string __id = "DISABLED.Lorg/webrtc/PeerConnection$TcpCandidatePolicy;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.TcpCandidatePolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.TcpCandidatePolicy']/field[@name='ENABLED']"
			[Register ("ENABLED")]
			public static global::Org.Webrtc.PeerConnection.TcpCandidatePolicy Enabled {
				get {
					const string __id = "ENABLED.Lorg/webrtc/PeerConnection$TcpCandidatePolicy;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.TcpCandidatePolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/PeerConnection$TcpCandidatePolicy", typeof (TcpCandidatePolicy));
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

			internal TcpCandidatePolicy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.TcpCandidatePolicy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/PeerConnection$TcpCandidatePolicy;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.TcpCandidatePolicy ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/webrtc/PeerConnection$TcpCandidatePolicy;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.TcpCandidatePolicy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.TcpCandidatePolicy']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/PeerConnection$TcpCandidatePolicy;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.TcpCandidatePolicy[] Values ()
			{
				const string __id = "values.()[Lorg/webrtc/PeerConnection$TcpCandidatePolicy;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Webrtc.PeerConnection.TcpCandidatePolicy[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.PeerConnection.TcpCandidatePolicy));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.TlsCertPolicy']"
		[global::Android.Runtime.Register ("org/webrtc/PeerConnection$TlsCertPolicy", DoNotGenerateAcw=true)]
		public sealed partial class TlsCertPolicy : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.TlsCertPolicy']/field[@name='TLS_CERT_POLICY_INSECURE_NO_CHECK']"
			[Register ("TLS_CERT_POLICY_INSECURE_NO_CHECK")]
			public static global::Org.Webrtc.PeerConnection.TlsCertPolicy TlsCertPolicyInsecureNoCheck {
				get {
					const string __id = "TLS_CERT_POLICY_INSECURE_NO_CHECK.Lorg/webrtc/PeerConnection$TlsCertPolicy;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.TlsCertPolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.TlsCertPolicy']/field[@name='TLS_CERT_POLICY_SECURE']"
			[Register ("TLS_CERT_POLICY_SECURE")]
			public static global::Org.Webrtc.PeerConnection.TlsCertPolicy TlsCertPolicySecure {
				get {
					const string __id = "TLS_CERT_POLICY_SECURE.Lorg/webrtc/PeerConnection$TlsCertPolicy;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.TlsCertPolicy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/PeerConnection$TlsCertPolicy", typeof (TlsCertPolicy));
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

			internal TlsCertPolicy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.TlsCertPolicy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/PeerConnection$TlsCertPolicy;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.TlsCertPolicy ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/webrtc/PeerConnection$TlsCertPolicy;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.TlsCertPolicy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.TlsCertPolicy']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/PeerConnection$TlsCertPolicy;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.TlsCertPolicy[] Values ()
			{
				const string __id = "values.()[Lorg/webrtc/PeerConnection$TlsCertPolicy;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Webrtc.PeerConnection.TlsCertPolicy[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.PeerConnection.TlsCertPolicy));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/PeerConnection", typeof (PeerConnection));
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

		protected PeerConnection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/constructor[@name='PeerConnection' and count(parameter)=1 and parameter[1][@type='org.webrtc.NativePeerConnectionFactory']]"
		[Register (".ctor", "(Lorg/webrtc/NativePeerConnectionFactory;)V", "")]
		public unsafe PeerConnection (global::Org.Webrtc.INativePeerConnectionFactory factory)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/webrtc/NativePeerConnectionFactory;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((factory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) factory).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getCertificate;
#pragma warning disable 0169
		static Delegate GetGetCertificateHandler ()
		{
			if (cb_getCertificate == null)
				cb_getCertificate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCertificate);
			return cb_getCertificate;
		}

		static IntPtr n_GetCertificate (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Certificate);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Webrtc.RtcCertificatePem Certificate {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='getCertificate' and count(parameter)=0]"
			[Register ("getCertificate", "()Lorg/webrtc/RtcCertificatePem;", "GetGetCertificateHandler")]
			get {
				const string __id = "getCertificate.()Lorg/webrtc/RtcCertificatePem;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtcCertificatePem> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLocalDescription;
#pragma warning disable 0169
		static Delegate GetGetLocalDescriptionHandler ()
		{
			if (cb_getLocalDescription == null)
				cb_getLocalDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocalDescription);
			return cb_getLocalDescription;
		}

		static IntPtr n_GetLocalDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LocalDescription);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Webrtc.SessionDescription LocalDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='getLocalDescription' and count(parameter)=0]"
			[Register ("getLocalDescription", "()Lorg/webrtc/SessionDescription;", "GetGetLocalDescriptionHandler")]
			get {
				const string __id = "getLocalDescription.()Lorg/webrtc/SessionDescription;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.SessionDescription> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNativePeerConnection;
#pragma warning disable 0169
		static Delegate GetGetNativePeerConnectionHandler ()
		{
			if (cb_getNativePeerConnection == null)
				cb_getNativePeerConnection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetNativePeerConnection);
			return cb_getNativePeerConnection;
		}

		static long n_GetNativePeerConnection (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NativePeerConnection;
		}
#pragma warning restore 0169

		public virtual unsafe long NativePeerConnection {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='getNativePeerConnection' and count(parameter)=0]"
			[Register ("getNativePeerConnection", "()J", "GetGetNativePeerConnectionHandler")]
			get {
				const string __id = "getNativePeerConnection.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getReceivers;
#pragma warning disable 0169
		static Delegate GetGetReceiversHandler ()
		{
			if (cb_getReceivers == null)
				cb_getReceivers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReceivers);
			return cb_getReceivers;
		}

		static IntPtr n_GetReceivers (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Webrtc.RtpReceiver>.ToLocalJniHandle (__this.Receivers);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Webrtc.RtpReceiver> Receivers {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='getReceivers' and count(parameter)=0]"
			[Register ("getReceivers", "()Ljava/util/List;", "GetGetReceiversHandler")]
			get {
				const string __id = "getReceivers.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Org.Webrtc.RtpReceiver>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRemoteDescription;
#pragma warning disable 0169
		static Delegate GetGetRemoteDescriptionHandler ()
		{
			if (cb_getRemoteDescription == null)
				cb_getRemoteDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRemoteDescription);
			return cb_getRemoteDescription;
		}

		static IntPtr n_GetRemoteDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoteDescription);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Webrtc.SessionDescription RemoteDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='getRemoteDescription' and count(parameter)=0]"
			[Register ("getRemoteDescription", "()Lorg/webrtc/SessionDescription;", "GetGetRemoteDescriptionHandler")]
			get {
				const string __id = "getRemoteDescription.()Lorg/webrtc/SessionDescription;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.SessionDescription> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSenders;
#pragma warning disable 0169
		static Delegate GetGetSendersHandler ()
		{
			if (cb_getSenders == null)
				cb_getSenders = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSenders);
			return cb_getSenders;
		}

		static IntPtr n_GetSenders (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Webrtc.RtpSender>.ToLocalJniHandle (__this.Senders);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Webrtc.RtpSender> Senders {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='getSenders' and count(parameter)=0]"
			[Register ("getSenders", "()Ljava/util/List;", "GetGetSendersHandler")]
			get {
				const string __id = "getSenders.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Org.Webrtc.RtpSender>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTransceivers;
#pragma warning disable 0169
		static Delegate GetGetTransceiversHandler ()
		{
			if (cb_getTransceivers == null)
				cb_getTransceivers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransceivers);
			return cb_getTransceivers;
		}

		static IntPtr n_GetTransceivers (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Webrtc.RtpTransceiver>.ToLocalJniHandle (__this.Transceivers);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Webrtc.RtpTransceiver> Transceivers {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='getTransceivers' and count(parameter)=0]"
			[Register ("getTransceivers", "()Ljava/util/List;", "GetGetTransceiversHandler")]
			get {
				const string __id = "getTransceivers.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Org.Webrtc.RtpTransceiver>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addIceCandidate_Lorg_webrtc_IceCandidate_;
#pragma warning disable 0169
		static Delegate GetAddIceCandidate_Lorg_webrtc_IceCandidate_Handler ()
		{
			if (cb_addIceCandidate_Lorg_webrtc_IceCandidate_ == null)
				cb_addIceCandidate_Lorg_webrtc_IceCandidate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AddIceCandidate_Lorg_webrtc_IceCandidate_);
			return cb_addIceCandidate_Lorg_webrtc_IceCandidate_;
		}

		static bool n_AddIceCandidate_Lorg_webrtc_IceCandidate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_candidate)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.IceCandidate candidate = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IceCandidate> (native_candidate, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddIceCandidate (candidate);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='addIceCandidate' and count(parameter)=1 and parameter[1][@type='org.webrtc.IceCandidate']]"
		[Register ("addIceCandidate", "(Lorg/webrtc/IceCandidate;)Z", "GetAddIceCandidate_Lorg_webrtc_IceCandidate_Handler")]
		public virtual unsafe bool AddIceCandidate (global::Org.Webrtc.IceCandidate candidate)
		{
			const string __id = "addIceCandidate.(Lorg/webrtc/IceCandidate;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((candidate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) candidate).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_addStream_Lorg_webrtc_MediaStream_;
#pragma warning disable 0169
		static Delegate GetAddStream_Lorg_webrtc_MediaStream_Handler ()
		{
			if (cb_addStream_Lorg_webrtc_MediaStream_ == null)
				cb_addStream_Lorg_webrtc_MediaStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AddStream_Lorg_webrtc_MediaStream_);
			return cb_addStream_Lorg_webrtc_MediaStream_;
		}

		static bool n_AddStream_Lorg_webrtc_MediaStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_stream)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.MediaStream stream = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStream> (native_stream, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddStream (stream);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='addStream' and count(parameter)=1 and parameter[1][@type='org.webrtc.MediaStream']]"
		[Register ("addStream", "(Lorg/webrtc/MediaStream;)Z", "GetAddStream_Lorg_webrtc_MediaStream_Handler")]
		public virtual unsafe bool AddStream (global::Org.Webrtc.MediaStream stream)
		{
			const string __id = "addStream.(Lorg/webrtc/MediaStream;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((stream == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stream).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_addTrack_Lorg_webrtc_MediaStreamTrack_;
#pragma warning disable 0169
		static Delegate GetAddTrack_Lorg_webrtc_MediaStreamTrack_Handler ()
		{
			if (cb_addTrack_Lorg_webrtc_MediaStreamTrack_ == null)
				cb_addTrack_Lorg_webrtc_MediaStreamTrack_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddTrack_Lorg_webrtc_MediaStreamTrack_);
			return cb_addTrack_Lorg_webrtc_MediaStreamTrack_;
		}

		static IntPtr n_AddTrack_Lorg_webrtc_MediaStreamTrack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_track)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.MediaStreamTrack track = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack> (native_track, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddTrack (track));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='addTrack' and count(parameter)=1 and parameter[1][@type='org.webrtc.MediaStreamTrack']]"
		[Register ("addTrack", "(Lorg/webrtc/MediaStreamTrack;)Lorg/webrtc/RtpSender;", "GetAddTrack_Lorg_webrtc_MediaStreamTrack_Handler")]
		public virtual unsafe global::Org.Webrtc.RtpSender AddTrack (global::Org.Webrtc.MediaStreamTrack track)
		{
			const string __id = "addTrack.(Lorg/webrtc/MediaStreamTrack;)Lorg/webrtc/RtpSender;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((track == null) ? IntPtr.Zero : ((global::Java.Lang.Object) track).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpSender> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addTrack_Lorg_webrtc_MediaStreamTrack_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAddTrack_Lorg_webrtc_MediaStreamTrack_Ljava_util_List_Handler ()
		{
			if (cb_addTrack_Lorg_webrtc_MediaStreamTrack_Ljava_util_List_ == null)
				cb_addTrack_Lorg_webrtc_MediaStreamTrack_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddTrack_Lorg_webrtc_MediaStreamTrack_Ljava_util_List_);
			return cb_addTrack_Lorg_webrtc_MediaStreamTrack_Ljava_util_List_;
		}

		static IntPtr n_AddTrack_Lorg_webrtc_MediaStreamTrack_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_track, IntPtr native_streamIds)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.MediaStreamTrack track = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack> (native_track, JniHandleOwnership.DoNotTransfer);
			var streamIds = global::Android.Runtime.JavaList<string>.FromJniHandle (native_streamIds, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddTrack (track, streamIds));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='addTrack' and count(parameter)=2 and parameter[1][@type='org.webrtc.MediaStreamTrack'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("addTrack", "(Lorg/webrtc/MediaStreamTrack;Ljava/util/List;)Lorg/webrtc/RtpSender;", "GetAddTrack_Lorg_webrtc_MediaStreamTrack_Ljava_util_List_Handler")]
		public virtual unsafe global::Org.Webrtc.RtpSender AddTrack (global::Org.Webrtc.MediaStreamTrack track, global::System.Collections.Generic.IList<string> streamIds)
		{
			const string __id = "addTrack.(Lorg/webrtc/MediaStreamTrack;Ljava/util/List;)Lorg/webrtc/RtpSender;";
			IntPtr native_streamIds = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (streamIds);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((track == null) ? IntPtr.Zero : ((global::Java.Lang.Object) track).Handle);
				__args [1] = new JniArgumentValue (native_streamIds);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpSender> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_streamIds);
			}
		}

		static Delegate cb_addTransceiver_Lorg_webrtc_MediaStreamTrack_;
#pragma warning disable 0169
		static Delegate GetAddTransceiver_Lorg_webrtc_MediaStreamTrack_Handler ()
		{
			if (cb_addTransceiver_Lorg_webrtc_MediaStreamTrack_ == null)
				cb_addTransceiver_Lorg_webrtc_MediaStreamTrack_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddTransceiver_Lorg_webrtc_MediaStreamTrack_);
			return cb_addTransceiver_Lorg_webrtc_MediaStreamTrack_;
		}

		static IntPtr n_AddTransceiver_Lorg_webrtc_MediaStreamTrack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_track)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.MediaStreamTrack track = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack> (native_track, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddTransceiver (track));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='addTransceiver' and count(parameter)=1 and parameter[1][@type='org.webrtc.MediaStreamTrack']]"
		[Register ("addTransceiver", "(Lorg/webrtc/MediaStreamTrack;)Lorg/webrtc/RtpTransceiver;", "GetAddTransceiver_Lorg_webrtc_MediaStreamTrack_Handler")]
		public virtual unsafe global::Org.Webrtc.RtpTransceiver AddTransceiver (global::Org.Webrtc.MediaStreamTrack track)
		{
			const string __id = "addTransceiver.(Lorg/webrtc/MediaStreamTrack;)Lorg/webrtc/RtpTransceiver;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((track == null) ? IntPtr.Zero : ((global::Java.Lang.Object) track).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpTransceiver> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addTransceiver_Lorg_webrtc_MediaStreamTrack_Lorg_webrtc_RtpTransceiver_RtpTransceiverInit_;
#pragma warning disable 0169
		static Delegate GetAddTransceiver_Lorg_webrtc_MediaStreamTrack_Lorg_webrtc_RtpTransceiver_RtpTransceiverInit_Handler ()
		{
			if (cb_addTransceiver_Lorg_webrtc_MediaStreamTrack_Lorg_webrtc_RtpTransceiver_RtpTransceiverInit_ == null)
				cb_addTransceiver_Lorg_webrtc_MediaStreamTrack_Lorg_webrtc_RtpTransceiver_RtpTransceiverInit_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddTransceiver_Lorg_webrtc_MediaStreamTrack_Lorg_webrtc_RtpTransceiver_RtpTransceiverInit_);
			return cb_addTransceiver_Lorg_webrtc_MediaStreamTrack_Lorg_webrtc_RtpTransceiver_RtpTransceiverInit_;
		}

		static IntPtr n_AddTransceiver_Lorg_webrtc_MediaStreamTrack_Lorg_webrtc_RtpTransceiver_RtpTransceiverInit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_track, IntPtr native_init)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.MediaStreamTrack track = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack> (native_track, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.RtpTransceiver.RtpTransceiverInit init = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpTransceiver.RtpTransceiverInit> (native_init, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddTransceiver (track, init));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='addTransceiver' and count(parameter)=2 and parameter[1][@type='org.webrtc.MediaStreamTrack'] and parameter[2][@type='org.webrtc.RtpTransceiver.RtpTransceiverInit']]"
		[Register ("addTransceiver", "(Lorg/webrtc/MediaStreamTrack;Lorg/webrtc/RtpTransceiver$RtpTransceiverInit;)Lorg/webrtc/RtpTransceiver;", "GetAddTransceiver_Lorg_webrtc_MediaStreamTrack_Lorg_webrtc_RtpTransceiver_RtpTransceiverInit_Handler")]
		public virtual unsafe global::Org.Webrtc.RtpTransceiver AddTransceiver (global::Org.Webrtc.MediaStreamTrack track, global::Org.Webrtc.RtpTransceiver.RtpTransceiverInit init)
		{
			const string __id = "addTransceiver.(Lorg/webrtc/MediaStreamTrack;Lorg/webrtc/RtpTransceiver$RtpTransceiverInit;)Lorg/webrtc/RtpTransceiver;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((track == null) ? IntPtr.Zero : ((global::Java.Lang.Object) track).Handle);
				__args [1] = new JniArgumentValue ((init == null) ? IntPtr.Zero : ((global::Java.Lang.Object) init).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpTransceiver> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addTransceiver_Lorg_webrtc_MediaStreamTrack_MediaType_;
#pragma warning disable 0169
		static Delegate GetAddTransceiver_Lorg_webrtc_MediaStreamTrack_MediaType_Handler ()
		{
			if (cb_addTransceiver_Lorg_webrtc_MediaStreamTrack_MediaType_ == null)
				cb_addTransceiver_Lorg_webrtc_MediaStreamTrack_MediaType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddTransceiver_Lorg_webrtc_MediaStreamTrack_MediaType_);
			return cb_addTransceiver_Lorg_webrtc_MediaStreamTrack_MediaType_;
		}

		static IntPtr n_AddTransceiver_Lorg_webrtc_MediaStreamTrack_MediaType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mediaType)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.MediaStreamTrack.MediaType mediaType = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack.MediaType> (native_mediaType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddTransceiver (mediaType));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='addTransceiver' and count(parameter)=1 and parameter[1][@type='org.webrtc.MediaStreamTrack.MediaType']]"
		[Register ("addTransceiver", "(Lorg/webrtc/MediaStreamTrack$MediaType;)Lorg/webrtc/RtpTransceiver;", "GetAddTransceiver_Lorg_webrtc_MediaStreamTrack_MediaType_Handler")]
		public virtual unsafe global::Org.Webrtc.RtpTransceiver AddTransceiver (global::Org.Webrtc.MediaStreamTrack.MediaType mediaType)
		{
			const string __id = "addTransceiver.(Lorg/webrtc/MediaStreamTrack$MediaType;)Lorg/webrtc/RtpTransceiver;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mediaType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpTransceiver> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addTransceiver_Lorg_webrtc_MediaStreamTrack_MediaType_Lorg_webrtc_RtpTransceiver_RtpTransceiverInit_;
#pragma warning disable 0169
		static Delegate GetAddTransceiver_Lorg_webrtc_MediaStreamTrack_MediaType_Lorg_webrtc_RtpTransceiver_RtpTransceiverInit_Handler ()
		{
			if (cb_addTransceiver_Lorg_webrtc_MediaStreamTrack_MediaType_Lorg_webrtc_RtpTransceiver_RtpTransceiverInit_ == null)
				cb_addTransceiver_Lorg_webrtc_MediaStreamTrack_MediaType_Lorg_webrtc_RtpTransceiver_RtpTransceiverInit_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddTransceiver_Lorg_webrtc_MediaStreamTrack_MediaType_Lorg_webrtc_RtpTransceiver_RtpTransceiverInit_);
			return cb_addTransceiver_Lorg_webrtc_MediaStreamTrack_MediaType_Lorg_webrtc_RtpTransceiver_RtpTransceiverInit_;
		}

		static IntPtr n_AddTransceiver_Lorg_webrtc_MediaStreamTrack_MediaType_Lorg_webrtc_RtpTransceiver_RtpTransceiverInit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mediaType, IntPtr native_init)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.MediaStreamTrack.MediaType mediaType = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack.MediaType> (native_mediaType, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.RtpTransceiver.RtpTransceiverInit init = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpTransceiver.RtpTransceiverInit> (native_init, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddTransceiver (mediaType, init));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='addTransceiver' and count(parameter)=2 and parameter[1][@type='org.webrtc.MediaStreamTrack.MediaType'] and parameter[2][@type='org.webrtc.RtpTransceiver.RtpTransceiverInit']]"
		[Register ("addTransceiver", "(Lorg/webrtc/MediaStreamTrack$MediaType;Lorg/webrtc/RtpTransceiver$RtpTransceiverInit;)Lorg/webrtc/RtpTransceiver;", "GetAddTransceiver_Lorg_webrtc_MediaStreamTrack_MediaType_Lorg_webrtc_RtpTransceiver_RtpTransceiverInit_Handler")]
		public virtual unsafe global::Org.Webrtc.RtpTransceiver AddTransceiver (global::Org.Webrtc.MediaStreamTrack.MediaType mediaType, global::Org.Webrtc.RtpTransceiver.RtpTransceiverInit init)
		{
			const string __id = "addTransceiver.(Lorg/webrtc/MediaStreamTrack$MediaType;Lorg/webrtc/RtpTransceiver$RtpTransceiverInit;)Lorg/webrtc/RtpTransceiver;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((mediaType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaType).Handle);
				__args [1] = new JniArgumentValue ((init == null) ? IntPtr.Zero : ((global::Java.Lang.Object) init).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpTransceiver> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_connectionState;
#pragma warning disable 0169
		static Delegate GetConnectionStateHandler ()
		{
			if (cb_connectionState == null)
				cb_connectionState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ConnectionState);
			return cb_connectionState;
		}

		static IntPtr n_ConnectionState (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConnectionState ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='connectionState' and count(parameter)=0]"
		[Register ("connectionState", "()Lorg/webrtc/PeerConnection$PeerConnectionState;", "GetConnectionStateHandler")]
		public virtual unsafe global::Org.Webrtc.PeerConnection.PeerConnectionState ConnectionState ()
		{
			const string __id = "connectionState.()Lorg/webrtc/PeerConnection$PeerConnectionState;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.PeerConnectionState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_createAnswer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_;
#pragma warning disable 0169
		static Delegate GetCreateAnswer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_Handler ()
		{
			if (cb_createAnswer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_ == null)
				cb_createAnswer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateAnswer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_);
			return cb_createAnswer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_;
		}

		static void n_CreateAnswer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_ (IntPtr jnienv, IntPtr native__this, IntPtr native_observer, IntPtr native_constraints)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.ISdpObserver observer = (global::Org.Webrtc.ISdpObserver)global::Java.Lang.Object.GetObject<global::Org.Webrtc.ISdpObserver> (native_observer, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.MediaConstraints constraints = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaConstraints> (native_constraints, JniHandleOwnership.DoNotTransfer);
			__this.CreateAnswer (observer, constraints);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='createAnswer' and count(parameter)=2 and parameter[1][@type='org.webrtc.SdpObserver'] and parameter[2][@type='org.webrtc.MediaConstraints']]"
		[Register ("createAnswer", "(Lorg/webrtc/SdpObserver;Lorg/webrtc/MediaConstraints;)V", "GetCreateAnswer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_Handler")]
		public virtual unsafe void CreateAnswer (global::Org.Webrtc.ISdpObserver observer, global::Org.Webrtc.MediaConstraints constraints)
		{
			const string __id = "createAnswer.(Lorg/webrtc/SdpObserver;Lorg/webrtc/MediaConstraints;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((observer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) observer).Handle);
				__args [1] = new JniArgumentValue ((constraints == null) ? IntPtr.Zero : ((global::Java.Lang.Object) constraints).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_createDataChannel_Ljava_lang_String_Lorg_webrtc_DataChannel_Init_;
#pragma warning disable 0169
		static Delegate GetCreateDataChannel_Ljava_lang_String_Lorg_webrtc_DataChannel_Init_Handler ()
		{
			if (cb_createDataChannel_Ljava_lang_String_Lorg_webrtc_DataChannel_Init_ == null)
				cb_createDataChannel_Ljava_lang_String_Lorg_webrtc_DataChannel_Init_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateDataChannel_Ljava_lang_String_Lorg_webrtc_DataChannel_Init_);
			return cb_createDataChannel_Ljava_lang_String_Lorg_webrtc_DataChannel_Init_;
		}

		static IntPtr n_CreateDataChannel_Ljava_lang_String_Lorg_webrtc_DataChannel_Init_ (IntPtr jnienv, IntPtr native__this, IntPtr native_label, IntPtr native_init)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string label = JNIEnv.GetString (native_label, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.DataChannel.Init init = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel.Init> (native_init, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateDataChannel (label, init));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='createDataChannel' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.webrtc.DataChannel.Init']]"
		[Register ("createDataChannel", "(Ljava/lang/String;Lorg/webrtc/DataChannel$Init;)Lorg/webrtc/DataChannel;", "GetCreateDataChannel_Ljava_lang_String_Lorg_webrtc_DataChannel_Init_Handler")]
		public virtual unsafe global::Org.Webrtc.DataChannel CreateDataChannel (string label, global::Org.Webrtc.DataChannel.Init init)
		{
			const string __id = "createDataChannel.(Ljava/lang/String;Lorg/webrtc/DataChannel$Init;)Lorg/webrtc/DataChannel;";
			IntPtr native_label = JNIEnv.NewString (label);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_label);
				__args [1] = new JniArgumentValue ((init == null) ? IntPtr.Zero : ((global::Java.Lang.Object) init).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_label);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='createNativePeerConnectionObserver' and count(parameter)=1 and parameter[1][@type='org.webrtc.PeerConnection.Observer']]"
		[Register ("createNativePeerConnectionObserver", "(Lorg/webrtc/PeerConnection$Observer;)J", "")]
		public static unsafe long CreateNativePeerConnectionObserver (global::Org.Webrtc.PeerConnection.IObserver observer)
		{
			const string __id = "createNativePeerConnectionObserver.(Lorg/webrtc/PeerConnection$Observer;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((observer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) observer).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_createOffer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_;
#pragma warning disable 0169
		static Delegate GetCreateOffer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_Handler ()
		{
			if (cb_createOffer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_ == null)
				cb_createOffer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateOffer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_);
			return cb_createOffer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_;
		}

		static void n_CreateOffer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_ (IntPtr jnienv, IntPtr native__this, IntPtr native_observer, IntPtr native_constraints)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.ISdpObserver observer = (global::Org.Webrtc.ISdpObserver)global::Java.Lang.Object.GetObject<global::Org.Webrtc.ISdpObserver> (native_observer, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.MediaConstraints constraints = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaConstraints> (native_constraints, JniHandleOwnership.DoNotTransfer);
			__this.CreateOffer (observer, constraints);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='createOffer' and count(parameter)=2 and parameter[1][@type='org.webrtc.SdpObserver'] and parameter[2][@type='org.webrtc.MediaConstraints']]"
		[Register ("createOffer", "(Lorg/webrtc/SdpObserver;Lorg/webrtc/MediaConstraints;)V", "GetCreateOffer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_Handler")]
		public virtual unsafe void CreateOffer (global::Org.Webrtc.ISdpObserver observer, global::Org.Webrtc.MediaConstraints constraints)
		{
			const string __id = "createOffer.(Lorg/webrtc/SdpObserver;Lorg/webrtc/MediaConstraints;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((observer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) observer).Handle);
				__args [1] = new JniArgumentValue ((constraints == null) ? IntPtr.Zero : ((global::Java.Lang.Object) constraints).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_createSender_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateSender_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_createSender_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_createSender_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateSender_Ljava_lang_String_Ljava_lang_String_);
			return cb_createSender_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_CreateSender_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_kind, IntPtr native_stream_id)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string kind = JNIEnv.GetString (native_kind, JniHandleOwnership.DoNotTransfer);
			string stream_id = JNIEnv.GetString (native_stream_id, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateSender (kind, stream_id));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='createSender' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("createSender", "(Ljava/lang/String;Ljava/lang/String;)Lorg/webrtc/RtpSender;", "GetCreateSender_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Webrtc.RtpSender CreateSender (string kind, string stream_id)
		{
			const string __id = "createSender.(Ljava/lang/String;Ljava/lang/String;)Lorg/webrtc/RtpSender;";
			IntPtr native_kind = JNIEnv.NewString (kind);
			IntPtr native_stream_id = JNIEnv.NewString (stream_id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_kind);
				__args [1] = new JniArgumentValue (native_stream_id);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpSender> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_kind);
				JNIEnv.DeleteLocalRef (native_stream_id);
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
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public virtual unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getStats_Lorg_webrtc_RTCStatsCollectorCallback_;
#pragma warning disable 0169
		static Delegate GetGetStats_Lorg_webrtc_RTCStatsCollectorCallback_Handler ()
		{
			if (cb_getStats_Lorg_webrtc_RTCStatsCollectorCallback_ == null)
				cb_getStats_Lorg_webrtc_RTCStatsCollectorCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetStats_Lorg_webrtc_RTCStatsCollectorCallback_);
			return cb_getStats_Lorg_webrtc_RTCStatsCollectorCallback_;
		}

		static void n_GetStats_Lorg_webrtc_RTCStatsCollectorCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.IRTCStatsCollectorCallback @callback = (global::Org.Webrtc.IRTCStatsCollectorCallback)global::Java.Lang.Object.GetObject<global::Org.Webrtc.IRTCStatsCollectorCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetStats (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='getStats' and count(parameter)=1 and parameter[1][@type='org.webrtc.RTCStatsCollectorCallback']]"
		[Register ("getStats", "(Lorg/webrtc/RTCStatsCollectorCallback;)V", "GetGetStats_Lorg_webrtc_RTCStatsCollectorCallback_Handler")]
		public virtual unsafe void GetStats (global::Org.Webrtc.IRTCStatsCollectorCallback @callback)
		{
			const string __id = "getStats.(Lorg/webrtc/RTCStatsCollectorCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getStats_Lorg_webrtc_StatsObserver_Lorg_webrtc_MediaStreamTrack_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetGetStats_Lorg_webrtc_StatsObserver_Lorg_webrtc_MediaStreamTrack_Handler ()
		{
			if (cb_getStats_Lorg_webrtc_StatsObserver_Lorg_webrtc_MediaStreamTrack_ == null)
				cb_getStats_Lorg_webrtc_StatsObserver_Lorg_webrtc_MediaStreamTrack_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_GetStats_Lorg_webrtc_StatsObserver_Lorg_webrtc_MediaStreamTrack_);
			return cb_getStats_Lorg_webrtc_StatsObserver_Lorg_webrtc_MediaStreamTrack_;
		}

		[Obsolete]
		static bool n_GetStats_Lorg_webrtc_StatsObserver_Lorg_webrtc_MediaStreamTrack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_observer, IntPtr native_track)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.IStatsObserver observer = (global::Org.Webrtc.IStatsObserver)global::Java.Lang.Object.GetObject<global::Org.Webrtc.IStatsObserver> (native_observer, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.MediaStreamTrack track = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack> (native_track, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetStats (observer, track);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='getStats' and count(parameter)=2 and parameter[1][@type='org.webrtc.StatsObserver'] and parameter[2][@type='org.webrtc.MediaStreamTrack']]"
		[Obsolete (@"deprecated")]
		[Register ("getStats", "(Lorg/webrtc/StatsObserver;Lorg/webrtc/MediaStreamTrack;)Z", "GetGetStats_Lorg_webrtc_StatsObserver_Lorg_webrtc_MediaStreamTrack_Handler")]
		public virtual unsafe bool GetStats (global::Org.Webrtc.IStatsObserver observer, global::Org.Webrtc.MediaStreamTrack track)
		{
			const string __id = "getStats.(Lorg/webrtc/StatsObserver;Lorg/webrtc/MediaStreamTrack;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((observer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) observer).Handle);
				__args [1] = new JniArgumentValue ((track == null) ? IntPtr.Zero : ((global::Java.Lang.Object) track).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_iceConnectionState;
#pragma warning disable 0169
		static Delegate GetInvokeIceConnectionStateHandler ()
		{
			if (cb_iceConnectionState == null)
				cb_iceConnectionState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_InvokeIceConnectionState);
			return cb_iceConnectionState;
		}

		static IntPtr n_InvokeIceConnectionState (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeIceConnectionState ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='iceConnectionState' and count(parameter)=0]"
		[Register ("iceConnectionState", "()Lorg/webrtc/PeerConnection$IceConnectionState;", "GetInvokeIceConnectionStateHandler")]
		public virtual unsafe global::Org.Webrtc.PeerConnection.IceConnectionState InvokeIceConnectionState ()
		{
			const string __id = "iceConnectionState.()Lorg/webrtc/PeerConnection$IceConnectionState;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceConnectionState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_iceGatheringState;
#pragma warning disable 0169
		static Delegate GetInvokeIceGatheringStateHandler ()
		{
			if (cb_iceGatheringState == null)
				cb_iceGatheringState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_InvokeIceGatheringState);
			return cb_iceGatheringState;
		}

		static IntPtr n_InvokeIceGatheringState (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeIceGatheringState ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='iceGatheringState' and count(parameter)=0]"
		[Register ("iceGatheringState", "()Lorg/webrtc/PeerConnection$IceGatheringState;", "GetInvokeIceGatheringStateHandler")]
		public virtual unsafe global::Org.Webrtc.PeerConnection.IceGatheringState InvokeIceGatheringState ()
		{
			const string __id = "iceGatheringState.()Lorg/webrtc/PeerConnection$IceGatheringState;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceGatheringState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeIceCandidates_arrayLorg_webrtc_IceCandidate_;
#pragma warning disable 0169
		static Delegate GetRemoveIceCandidates_arrayLorg_webrtc_IceCandidate_Handler ()
		{
			if (cb_removeIceCandidates_arrayLorg_webrtc_IceCandidate_ == null)
				cb_removeIceCandidates_arrayLorg_webrtc_IceCandidate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveIceCandidates_arrayLorg_webrtc_IceCandidate_);
			return cb_removeIceCandidates_arrayLorg_webrtc_IceCandidate_;
		}

		static bool n_RemoveIceCandidates_arrayLorg_webrtc_IceCandidate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_candidates)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.IceCandidate[] candidates = (global::Org.Webrtc.IceCandidate[]) JNIEnv.GetArray (native_candidates, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Webrtc.IceCandidate));
			bool __ret = __this.RemoveIceCandidates (candidates);
			if (candidates != null)
				JNIEnv.CopyArray (candidates, native_candidates);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='removeIceCandidates' and count(parameter)=1 and parameter[1][@type='org.webrtc.IceCandidate[]']]"
		[Register ("removeIceCandidates", "([Lorg/webrtc/IceCandidate;)Z", "GetRemoveIceCandidates_arrayLorg_webrtc_IceCandidate_Handler")]
		public virtual unsafe bool RemoveIceCandidates (global::Org.Webrtc.IceCandidate[] candidates)
		{
			const string __id = "removeIceCandidates.([Lorg/webrtc/IceCandidate;)Z";
			IntPtr native_candidates = JNIEnv.NewArray (candidates);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_candidates);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (candidates != null) {
					JNIEnv.CopyArray (native_candidates, candidates);
					JNIEnv.DeleteLocalRef (native_candidates);
				}
			}
		}

		static Delegate cb_removeStream_Lorg_webrtc_MediaStream_;
#pragma warning disable 0169
		static Delegate GetRemoveStream_Lorg_webrtc_MediaStream_Handler ()
		{
			if (cb_removeStream_Lorg_webrtc_MediaStream_ == null)
				cb_removeStream_Lorg_webrtc_MediaStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveStream_Lorg_webrtc_MediaStream_);
			return cb_removeStream_Lorg_webrtc_MediaStream_;
		}

		static void n_RemoveStream_Lorg_webrtc_MediaStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_stream)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.MediaStream stream = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStream> (native_stream, JniHandleOwnership.DoNotTransfer);
			__this.RemoveStream (stream);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='removeStream' and count(parameter)=1 and parameter[1][@type='org.webrtc.MediaStream']]"
		[Register ("removeStream", "(Lorg/webrtc/MediaStream;)V", "GetRemoveStream_Lorg_webrtc_MediaStream_Handler")]
		public virtual unsafe void RemoveStream (global::Org.Webrtc.MediaStream stream)
		{
			const string __id = "removeStream.(Lorg/webrtc/MediaStream;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((stream == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stream).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeTrack_Lorg_webrtc_RtpSender_;
#pragma warning disable 0169
		static Delegate GetRemoveTrack_Lorg_webrtc_RtpSender_Handler ()
		{
			if (cb_removeTrack_Lorg_webrtc_RtpSender_ == null)
				cb_removeTrack_Lorg_webrtc_RtpSender_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveTrack_Lorg_webrtc_RtpSender_);
			return cb_removeTrack_Lorg_webrtc_RtpSender_;
		}

		static bool n_RemoveTrack_Lorg_webrtc_RtpSender_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sender)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.RtpSender sender = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpSender> (native_sender, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveTrack (sender);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='removeTrack' and count(parameter)=1 and parameter[1][@type='org.webrtc.RtpSender']]"
		[Register ("removeTrack", "(Lorg/webrtc/RtpSender;)Z", "GetRemoveTrack_Lorg_webrtc_RtpSender_Handler")]
		public virtual unsafe bool RemoveTrack (global::Org.Webrtc.RtpSender sender)
		{
			const string __id = "removeTrack.(Lorg/webrtc/RtpSender;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sender == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sender).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setAudioPlayout_Z;
#pragma warning disable 0169
		static Delegate GetSetAudioPlayout_ZHandler ()
		{
			if (cb_setAudioPlayout_Z == null)
				cb_setAudioPlayout_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAudioPlayout_Z);
			return cb_setAudioPlayout_Z;
		}

		static void n_SetAudioPlayout_Z (IntPtr jnienv, IntPtr native__this, bool playout)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAudioPlayout (playout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='setAudioPlayout' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAudioPlayout", "(Z)V", "GetSetAudioPlayout_ZHandler")]
		public virtual unsafe void SetAudioPlayout (bool playout)
		{
			const string __id = "setAudioPlayout.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (playout);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setAudioRecording_Z;
#pragma warning disable 0169
		static Delegate GetSetAudioRecording_ZHandler ()
		{
			if (cb_setAudioRecording_Z == null)
				cb_setAudioRecording_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAudioRecording_Z);
			return cb_setAudioRecording_Z;
		}

		static void n_SetAudioRecording_Z (IntPtr jnienv, IntPtr native__this, bool recording)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAudioRecording (recording);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='setAudioRecording' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAudioRecording", "(Z)V", "GetSetAudioRecording_ZHandler")]
		public virtual unsafe void SetAudioRecording (bool recording)
		{
			const string __id = "setAudioRecording.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (recording);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setBitrate_Ljava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetBitrate_Ljava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_Handler ()
		{
			if (cb_setBitrate_Ljava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_ == null)
				cb_setBitrate_Ljava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_SetBitrate_Ljava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_);
			return cb_setBitrate_Ljava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_;
		}

		static bool n_SetBitrate_Ljava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_min, IntPtr native_current, IntPtr native_max)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer min = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_min, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer current = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_current, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer max = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_max, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetBitrate (min, current, max);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='setBitrate' and count(parameter)=3 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='java.lang.Integer']]"
		[Register ("setBitrate", "(Ljava/lang/Integer;Ljava/lang/Integer;Ljava/lang/Integer;)Z", "GetSetBitrate_Ljava_lang_Integer_Ljava_lang_Integer_Ljava_lang_Integer_Handler")]
		public virtual unsafe bool SetBitrate (global::Java.Lang.Integer min, global::Java.Lang.Integer current, global::Java.Lang.Integer max)
		{
			const string __id = "setBitrate.(Ljava/lang/Integer;Ljava/lang/Integer;Ljava/lang/Integer;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((min == null) ? IntPtr.Zero : ((global::Java.Lang.Object) min).Handle);
				__args [1] = new JniArgumentValue ((current == null) ? IntPtr.Zero : ((global::Java.Lang.Object) current).Handle);
				__args [2] = new JniArgumentValue ((max == null) ? IntPtr.Zero : ((global::Java.Lang.Object) max).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setConfiguration_Lorg_webrtc_PeerConnection_RTCConfiguration_;
#pragma warning disable 0169
		static Delegate GetSetConfiguration_Lorg_webrtc_PeerConnection_RTCConfiguration_Handler ()
		{
			if (cb_setConfiguration_Lorg_webrtc_PeerConnection_RTCConfiguration_ == null)
				cb_setConfiguration_Lorg_webrtc_PeerConnection_RTCConfiguration_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetConfiguration_Lorg_webrtc_PeerConnection_RTCConfiguration_);
			return cb_setConfiguration_Lorg_webrtc_PeerConnection_RTCConfiguration_;
		}

		static bool n_SetConfiguration_Lorg_webrtc_PeerConnection_RTCConfiguration_ (IntPtr jnienv, IntPtr native__this, IntPtr native_config)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.PeerConnection.RTCConfiguration config = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.RTCConfiguration> (native_config, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetConfiguration (config);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='setConfiguration' and count(parameter)=1 and parameter[1][@type='org.webrtc.PeerConnection.RTCConfiguration']]"
		[Register ("setConfiguration", "(Lorg/webrtc/PeerConnection$RTCConfiguration;)Z", "GetSetConfiguration_Lorg_webrtc_PeerConnection_RTCConfiguration_Handler")]
		public virtual unsafe bool SetConfiguration (global::Org.Webrtc.PeerConnection.RTCConfiguration config)
		{
			const string __id = "setConfiguration.(Lorg/webrtc/PeerConnection$RTCConfiguration;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setLocalDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_;
#pragma warning disable 0169
		static Delegate GetSetLocalDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_Handler ()
		{
			if (cb_setLocalDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_ == null)
				cb_setLocalDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetLocalDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_);
			return cb_setLocalDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_;
		}

		static void n_SetLocalDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_ (IntPtr jnienv, IntPtr native__this, IntPtr native_observer, IntPtr native_sdp)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.ISdpObserver observer = (global::Org.Webrtc.ISdpObserver)global::Java.Lang.Object.GetObject<global::Org.Webrtc.ISdpObserver> (native_observer, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.SessionDescription sdp = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SessionDescription> (native_sdp, JniHandleOwnership.DoNotTransfer);
			__this.SetLocalDescription (observer, sdp);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='setLocalDescription' and count(parameter)=2 and parameter[1][@type='org.webrtc.SdpObserver'] and parameter[2][@type='org.webrtc.SessionDescription']]"
		[Register ("setLocalDescription", "(Lorg/webrtc/SdpObserver;Lorg/webrtc/SessionDescription;)V", "GetSetLocalDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_Handler")]
		public virtual unsafe void SetLocalDescription (global::Org.Webrtc.ISdpObserver observer, global::Org.Webrtc.SessionDescription sdp)
		{
			const string __id = "setLocalDescription.(Lorg/webrtc/SdpObserver;Lorg/webrtc/SessionDescription;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((observer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) observer).Handle);
				__args [1] = new JniArgumentValue ((sdp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sdp).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRemoteDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_;
#pragma warning disable 0169
		static Delegate GetSetRemoteDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_Handler ()
		{
			if (cb_setRemoteDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_ == null)
				cb_setRemoteDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetRemoteDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_);
			return cb_setRemoteDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_;
		}

		static void n_SetRemoteDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_ (IntPtr jnienv, IntPtr native__this, IntPtr native_observer, IntPtr native_sdp)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.ISdpObserver observer = (global::Org.Webrtc.ISdpObserver)global::Java.Lang.Object.GetObject<global::Org.Webrtc.ISdpObserver> (native_observer, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.SessionDescription sdp = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SessionDescription> (native_sdp, JniHandleOwnership.DoNotTransfer);
			__this.SetRemoteDescription (observer, sdp);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='setRemoteDescription' and count(parameter)=2 and parameter[1][@type='org.webrtc.SdpObserver'] and parameter[2][@type='org.webrtc.SessionDescription']]"
		[Register ("setRemoteDescription", "(Lorg/webrtc/SdpObserver;Lorg/webrtc/SessionDescription;)V", "GetSetRemoteDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_Handler")]
		public virtual unsafe void SetRemoteDescription (global::Org.Webrtc.ISdpObserver observer, global::Org.Webrtc.SessionDescription sdp)
		{
			const string __id = "setRemoteDescription.(Lorg/webrtc/SdpObserver;Lorg/webrtc/SessionDescription;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((observer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) observer).Handle);
				__args [1] = new JniArgumentValue ((sdp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sdp).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_signalingState;
#pragma warning disable 0169
		static Delegate GetInvokeSignalingStateHandler ()
		{
			if (cb_signalingState == null)
				cb_signalingState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_InvokeSignalingState);
			return cb_signalingState;
		}

		static IntPtr n_InvokeSignalingState (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeSignalingState ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='signalingState' and count(parameter)=0]"
		[Register ("signalingState", "()Lorg/webrtc/PeerConnection$SignalingState;", "GetInvokeSignalingStateHandler")]
		public virtual unsafe global::Org.Webrtc.PeerConnection.SignalingState InvokeSignalingState ()
		{
			const string __id = "signalingState.()Lorg/webrtc/PeerConnection$SignalingState;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.SignalingState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_startRtcEventLog_II;
#pragma warning disable 0169
		static Delegate GetStartRtcEventLog_IIHandler ()
		{
			if (cb_startRtcEventLog_II == null)
				cb_startRtcEventLog_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, bool>) n_StartRtcEventLog_II);
			return cb_startRtcEventLog_II;
		}

		static bool n_StartRtcEventLog_II (IntPtr jnienv, IntPtr native__this, int file_descriptor, int max_size_bytes)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartRtcEventLog (file_descriptor, max_size_bytes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='startRtcEventLog' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("startRtcEventLog", "(II)Z", "GetStartRtcEventLog_IIHandler")]
		public virtual unsafe bool StartRtcEventLog (int file_descriptor, int max_size_bytes)
		{
			const string __id = "startRtcEventLog.(II)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (file_descriptor);
				__args [1] = new JniArgumentValue (max_size_bytes);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_stopRtcEventLog;
#pragma warning disable 0169
		static Delegate GetStopRtcEventLogHandler ()
		{
			if (cb_stopRtcEventLog == null)
				cb_stopRtcEventLog = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopRtcEventLog);
			return cb_stopRtcEventLog;
		}

		static void n_StopRtcEventLog (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopRtcEventLog ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='stopRtcEventLog' and count(parameter)=0]"
		[Register ("stopRtcEventLog", "()V", "GetStopRtcEventLogHandler")]
		public virtual unsafe void StopRtcEventLog ()
		{
			const string __id = "stopRtcEventLog.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
