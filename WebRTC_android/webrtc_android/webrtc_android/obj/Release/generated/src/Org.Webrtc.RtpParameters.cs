using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters']"
	[global::Android.Runtime.Register ("org/webrtc/RtpParameters", DoNotGenerateAcw=true)]
	public partial class RtpParameters : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters']/field[@name='codecs']"
		[Register ("codecs")]
		public global::System.Collections.IList Codecs {
			get {
				const string __id = "codecs.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "codecs.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters']/field[@name='encodings']"
		[Register ("encodings")]
		public global::System.Collections.IList Encodings {
			get {
				const string __id = "encodings.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "encodings.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters']/field[@name='transactionId']"
		[Register ("transactionId")]
		public string TransactionId {
			get {
				const string __id = "transactionId.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "transactionId.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters.Codec']"
		[global::Android.Runtime.Register ("org/webrtc/RtpParameters$Codec", DoNotGenerateAcw=true)]
		public partial class Codec : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters.Codec']/field[@name='clockRate']"
			[Register ("clockRate")]
			public global::Java.Lang.Integer ClockRate {
				get {
					const string __id = "clockRate.Ljava/lang/Integer;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "clockRate.Ljava/lang/Integer;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters.Codec']/field[@name='name']"
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


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters.Codec']/field[@name='numChannels']"
			[Register ("numChannels")]
			public global::Java.Lang.Integer NumChannels {
				get {
					const string __id = "numChannels.Ljava/lang/Integer;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "numChannels.Ljava/lang/Integer;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters.Codec']/field[@name='parameters']"
			[Register ("parameters")]
			public global::System.Collections.IDictionary Parameters {
				get {
					const string __id = "parameters.Ljava/util/Map;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "parameters.Ljava/util/Map;";

					IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters.Codec']/field[@name='payloadType']"
			[Register ("payloadType")]
			public int PayloadType {
				get {
					const string __id = "payloadType.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "payloadType.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/RtpParameters$Codec", typeof (Codec));
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

			protected Codec (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters.DegradationPreference']"
		[global::Android.Runtime.Register ("org/webrtc/RtpParameters$DegradationPreference", DoNotGenerateAcw=true)]
		public sealed partial class DegradationPreference : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters.DegradationPreference']/field[@name='BALANCED']"
			[Register ("BALANCED")]
			public static global::Org.Webrtc.RtpParameters.DegradationPreference Balanced {
				get {
					const string __id = "BALANCED.Lorg/webrtc/RtpParameters$DegradationPreference;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpParameters.DegradationPreference> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters.DegradationPreference']/field[@name='DISABLED']"
			[Register ("DISABLED")]
			public static global::Org.Webrtc.RtpParameters.DegradationPreference Disabled {
				get {
					const string __id = "DISABLED.Lorg/webrtc/RtpParameters$DegradationPreference;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpParameters.DegradationPreference> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters.DegradationPreference']/field[@name='MAINTAIN_FRAMERATE']"
			[Register ("MAINTAIN_FRAMERATE")]
			public static global::Org.Webrtc.RtpParameters.DegradationPreference MaintainFramerate {
				get {
					const string __id = "MAINTAIN_FRAMERATE.Lorg/webrtc/RtpParameters$DegradationPreference;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpParameters.DegradationPreference> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters.DegradationPreference']/field[@name='MAINTAIN_RESOLUTION']"
			[Register ("MAINTAIN_RESOLUTION")]
			public static global::Org.Webrtc.RtpParameters.DegradationPreference MaintainResolution {
				get {
					const string __id = "MAINTAIN_RESOLUTION.Lorg/webrtc/RtpParameters$DegradationPreference;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpParameters.DegradationPreference> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/RtpParameters$DegradationPreference", typeof (DegradationPreference));
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

			internal DegradationPreference (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters.DegradationPreference']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/RtpParameters$DegradationPreference;", "")]
			public static unsafe global::Org.Webrtc.RtpParameters.DegradationPreference ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/webrtc/RtpParameters$DegradationPreference;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpParameters.DegradationPreference> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters.DegradationPreference']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/RtpParameters$DegradationPreference;", "")]
			public static unsafe global::Org.Webrtc.RtpParameters.DegradationPreference[] Values ()
			{
				const string __id = "values.()[Lorg/webrtc/RtpParameters$DegradationPreference;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Webrtc.RtpParameters.DegradationPreference[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.RtpParameters.DegradationPreference));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters.Encoding']"
		[global::Android.Runtime.Register ("org/webrtc/RtpParameters$Encoding", DoNotGenerateAcw=true)]
		public partial class Encoding : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters.Encoding']/field[@name='active']"
			[Register ("active")]
			public bool Active {
				get {
					const string __id = "active.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "active.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters.Encoding']/field[@name='bitratePriority']"
			[Register ("bitratePriority")]
			public double BitratePriority {
				get {
					const string __id = "bitratePriority.D";

					var __v = _members.InstanceFields.GetDoubleValue (__id, this);
					return __v;
				}
				set {
					const string __id = "bitratePriority.D";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters.Encoding']/field[@name='maxBitrateBps']"
			[Register ("maxBitrateBps")]
			public global::Java.Lang.Integer MaxBitrateBps {
				get {
					const string __id = "maxBitrateBps.Ljava/lang/Integer;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "maxBitrateBps.Ljava/lang/Integer;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters.Encoding']/field[@name='maxFramerate']"
			[Register ("maxFramerate")]
			public global::Java.Lang.Integer MaxFramerate {
				get {
					const string __id = "maxFramerate.Ljava/lang/Integer;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "maxFramerate.Ljava/lang/Integer;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters.Encoding']/field[@name='minBitrateBps']"
			[Register ("minBitrateBps")]
			public global::Java.Lang.Integer MinBitrateBps {
				get {
					const string __id = "minBitrateBps.Ljava/lang/Integer;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "minBitrateBps.Ljava/lang/Integer;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters.Encoding']/field[@name='networkPriority']"
			[Register ("networkPriority")]
			public int NetworkPriority {
				get {
					const string __id = "networkPriority.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "networkPriority.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters.Encoding']/field[@name='numTemporalLayers']"
			[Register ("numTemporalLayers")]
			public global::Java.Lang.Integer NumTemporalLayers {
				get {
					const string __id = "numTemporalLayers.Ljava/lang/Integer;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "numTemporalLayers.Ljava/lang/Integer;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters.Encoding']/field[@name='rid']"
			[Register ("rid")]
			public string Rid {
				get {
					const string __id = "rid.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "rid.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters.Encoding']/field[@name='scaleResolutionDownBy']"
			[Register ("scaleResolutionDownBy")]
			public global::Java.Lang.Double ScaleResolutionDownBy {
				get {
					const string __id = "scaleResolutionDownBy.Ljava/lang/Double;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "scaleResolutionDownBy.Ljava/lang/Double;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters.Encoding']/field[@name='ssrc']"
			[Register ("ssrc")]
			public global::Java.Lang.Long Ssrc {
				get {
					const string __id = "ssrc.Ljava/lang/Long;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "ssrc.Ljava/lang/Long;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/RtpParameters$Encoding", typeof (Encoding));
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

			protected Encoding (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters.Encoding']/constructor[@name='RtpParameters.Encoding' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.Double']]"
			[Register (".ctor", "(Ljava/lang/String;ZLjava/lang/Double;)V", "")]
			public unsafe Encoding (string rid, bool active, global::Java.Lang.Double scaleResolutionDownBy)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;ZLjava/lang/Double;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_rid = JNIEnv.NewString (rid);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_rid);
					__args [1] = new JniArgumentValue (active);
					__args [2] = new JniArgumentValue ((scaleResolutionDownBy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scaleResolutionDownBy).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_rid);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters.HeaderExtension']"
		[global::Android.Runtime.Register ("org/webrtc/RtpParameters$HeaderExtension", DoNotGenerateAcw=true)]
		public partial class HeaderExtension : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/RtpParameters$HeaderExtension", typeof (HeaderExtension));
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

			protected HeaderExtension (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getEncrypted;
#pragma warning disable 0169
			static Delegate GetGetEncryptedHandler ()
			{
				if (cb_getEncrypted == null)
					cb_getEncrypted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetEncrypted);
				return cb_getEncrypted;
			}

			static bool n_GetEncrypted (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.RtpParameters.HeaderExtension __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpParameters.HeaderExtension> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Encrypted;
			}
#pragma warning restore 0169

			public virtual unsafe bool Encrypted {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters.HeaderExtension']/method[@name='getEncrypted' and count(parameter)=0]"
				[Register ("getEncrypted", "()Z", "GetGetEncryptedHandler")]
				get {
					const string __id = "getEncrypted.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getId;
#pragma warning disable 0169
			static Delegate GetGetIdHandler ()
			{
				if (cb_getId == null)
					cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetId);
				return cb_getId;
			}

			static int n_GetId (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.RtpParameters.HeaderExtension __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpParameters.HeaderExtension> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Id;
			}
#pragma warning restore 0169

			public virtual unsafe int Id {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters.HeaderExtension']/method[@name='getId' and count(parameter)=0]"
				[Register ("getId", "()I", "GetGetIdHandler")]
				get {
					const string __id = "getId.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getUri;
#pragma warning disable 0169
			static Delegate GetGetUriHandler ()
			{
				if (cb_getUri == null)
					cb_getUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUri);
				return cb_getUri;
			}

			static IntPtr n_GetUri (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.RtpParameters.HeaderExtension __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpParameters.HeaderExtension> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Uri);
			}
#pragma warning restore 0169

			public virtual unsafe string Uri {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters.HeaderExtension']/method[@name='getUri' and count(parameter)=0]"
				[Register ("getUri", "()Ljava/lang/String;", "GetGetUriHandler")]
				get {
					const string __id = "getUri.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters.Rtcp']"
		[global::Android.Runtime.Register ("org/webrtc/RtpParameters$Rtcp", DoNotGenerateAcw=true)]
		public partial class Rtcp : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/RtpParameters$Rtcp", typeof (Rtcp));
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

			protected Rtcp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getCname;
#pragma warning disable 0169
			static Delegate GetGetCnameHandler ()
			{
				if (cb_getCname == null)
					cb_getCname = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCname);
				return cb_getCname;
			}

			static IntPtr n_GetCname (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.RtpParameters.Rtcp __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpParameters.Rtcp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Cname);
			}
#pragma warning restore 0169

			public virtual unsafe string Cname {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters.Rtcp']/method[@name='getCname' and count(parameter)=0]"
				[Register ("getCname", "()Ljava/lang/String;", "GetGetCnameHandler")]
				get {
					const string __id = "getCname.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getReducedSize;
#pragma warning disable 0169
			static Delegate GetGetReducedSizeHandler ()
			{
				if (cb_getReducedSize == null)
					cb_getReducedSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetReducedSize);
				return cb_getReducedSize;
			}

			static bool n_GetReducedSize (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.RtpParameters.Rtcp __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpParameters.Rtcp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ReducedSize;
			}
#pragma warning restore 0169

			public virtual unsafe bool ReducedSize {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters.Rtcp']/method[@name='getReducedSize' and count(parameter)=0]"
				[Register ("getReducedSize", "()Z", "GetGetReducedSizeHandler")]
				get {
					const string __id = "getReducedSize.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/RtpParameters", typeof (RtpParameters));
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

		protected RtpParameters (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getHeaderExtensions;
#pragma warning disable 0169
		static Delegate GetGetHeaderExtensionsHandler ()
		{
			if (cb_getHeaderExtensions == null)
				cb_getHeaderExtensions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeaderExtensions);
			return cb_getHeaderExtensions;
		}

		static IntPtr n_GetHeaderExtensions (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.RtpParameters __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Webrtc.RtpParameters.HeaderExtension>.ToLocalJniHandle (__this.HeaderExtensions);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Webrtc.RtpParameters.HeaderExtension> HeaderExtensions {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters']/method[@name='getHeaderExtensions' and count(parameter)=0]"
			[Register ("getHeaderExtensions", "()Ljava/util/List;", "GetGetHeaderExtensionsHandler")]
			get {
				const string __id = "getHeaderExtensions.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Org.Webrtc.RtpParameters.HeaderExtension>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRtcp;
#pragma warning disable 0169
		static Delegate GetGetRtcpHandler ()
		{
			if (cb_getRtcp == null)
				cb_getRtcp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRtcp);
			return cb_getRtcp;
		}

		static IntPtr n_GetRtcp (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.RtpParameters __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetRtcp ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpParameters']/method[@name='getRtcp' and count(parameter)=0]"
		[Register ("getRtcp", "()Lorg/webrtc/RtpParameters$Rtcp;", "GetGetRtcpHandler")]
		public virtual unsafe global::Org.Webrtc.RtpParameters.Rtcp GetRtcp ()
		{
			const string __id = "getRtcp.()Lorg/webrtc/RtpParameters$Rtcp;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpParameters.Rtcp> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
