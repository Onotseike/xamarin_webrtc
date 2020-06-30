using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='RTCStats']"
	[global::Android.Runtime.Register ("org/webrtc/RTCStats", DoNotGenerateAcw=true)]
	public partial class RTCStats : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/RTCStats", typeof (RTCStats));
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

		protected RTCStats (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='RTCStats']/constructor[@name='RTCStats' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register (".ctor", "(JLjava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "")]
		public unsafe RTCStats (long timestampUs, string type, string id, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> members)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(JLjava/lang/String;Ljava/lang/String;Ljava/util/Map;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_type = JNIEnv.NewString (type);
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_members = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (members);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (timestampUs);
				__args [1] = new JniArgumentValue (native_type);
				__args [2] = new JniArgumentValue (native_id);
				__args [3] = new JniArgumentValue (native_members);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_type);
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_members);
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.RTCStats __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RTCStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RTCStats']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				const string __id = "getId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMembers;
#pragma warning disable 0169
		static Delegate GetGetMembersHandler ()
		{
			if (cb_getMembers == null)
				cb_getMembers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMembers);
			return cb_getMembers;
		}

		static IntPtr n_GetMembers (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.RTCStats __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RTCStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.Members);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> Members {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RTCStats']/method[@name='getMembers' and count(parameter)=0]"
			[Register ("getMembers", "()Ljava/util/Map;", "GetGetMembersHandler")]
			get {
				const string __id = "getMembers.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTimestampUs;
#pragma warning disable 0169
		static Delegate GetGetTimestampUsHandler ()
		{
			if (cb_getTimestampUs == null)
				cb_getTimestampUs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetTimestampUs);
			return cb_getTimestampUs;
		}

		static double n_GetTimestampUs (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.RTCStats __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RTCStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimestampUs;
		}
#pragma warning restore 0169

		public virtual unsafe double TimestampUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RTCStats']/method[@name='getTimestampUs' and count(parameter)=0]"
			[Register ("getTimestampUs", "()D", "GetGetTimestampUsHandler")]
			get {
				const string __id = "getTimestampUs.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.RTCStats __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RTCStats> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Type);
		}
#pragma warning restore 0169

		public virtual unsafe string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RTCStats']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
			get {
				const string __id = "getType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
