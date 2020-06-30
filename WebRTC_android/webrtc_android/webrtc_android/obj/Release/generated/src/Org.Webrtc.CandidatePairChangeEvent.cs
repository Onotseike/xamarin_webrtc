using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='CandidatePairChangeEvent']"
	[global::Android.Runtime.Register ("org/webrtc/CandidatePairChangeEvent", DoNotGenerateAcw=true)]
	public sealed partial class CandidatePairChangeEvent : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='CandidatePairChangeEvent']/field[@name='lastDataReceivedMs']"
		[Register ("lastDataReceivedMs")]
		public int LastDataReceivedMs {
			get {
				const string __id = "lastDataReceivedMs.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "lastDataReceivedMs.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='CandidatePairChangeEvent']/field[@name='local']"
		[Register ("local")]
		public global::Org.Webrtc.IceCandidate Local {
			get {
				const string __id = "local.Lorg/webrtc/IceCandidate;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.IceCandidate> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "local.Lorg/webrtc/IceCandidate;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='CandidatePairChangeEvent']/field[@name='reason']"
		[Register ("reason")]
		public string Reason {
			get {
				const string __id = "reason.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "reason.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='CandidatePairChangeEvent']/field[@name='remote']"
		[Register ("remote")]
		public global::Org.Webrtc.IceCandidate Remote {
			get {
				const string __id = "remote.Lorg/webrtc/IceCandidate;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.IceCandidate> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "remote.Lorg/webrtc/IceCandidate;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/CandidatePairChangeEvent", typeof (CandidatePairChangeEvent));
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

		internal CandidatePairChangeEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
