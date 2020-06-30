using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='RTCStatsReport']"
	[global::Android.Runtime.Register ("org/webrtc/RTCStatsReport", DoNotGenerateAcw=true)]
	public partial class RTCStatsReport : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/RTCStatsReport", typeof (RTCStatsReport));
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

		protected RTCStatsReport (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='RTCStatsReport']/constructor[@name='RTCStatsReport' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.Map&lt;java.lang.String, org.webrtc.RTCStats&gt;']]"
		[Register (".ctor", "(JLjava/util/Map;)V", "")]
		public unsafe RTCStatsReport (long timestampUs, global::System.Collections.Generic.IDictionary<string, global::Org.Webrtc.RTCStats> stats)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(JLjava/util/Map;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_stats = global::Android.Runtime.JavaDictionary<string, global::Org.Webrtc.RTCStats>.ToLocalJniHandle (stats);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (timestampUs);
				__args [1] = new JniArgumentValue (native_stats);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_stats);
			}
		}

		static Delegate cb_getStatsMap;
#pragma warning disable 0169
		static Delegate GetGetStatsMapHandler ()
		{
			if (cb_getStatsMap == null)
				cb_getStatsMap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStatsMap);
			return cb_getStatsMap;
		}

		static IntPtr n_GetStatsMap (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.RTCStatsReport __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RTCStatsReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Org.Webrtc.RTCStats>.ToLocalJniHandle (__this.StatsMap);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Org.Webrtc.RTCStats> StatsMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RTCStatsReport']/method[@name='getStatsMap' and count(parameter)=0]"
			[Register ("getStatsMap", "()Ljava/util/Map;", "GetGetStatsMapHandler")]
			get {
				const string __id = "getStatsMap.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Org.Webrtc.RTCStats>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Org.Webrtc.RTCStatsReport __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RTCStatsReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimestampUs;
		}
#pragma warning restore 0169

		public virtual unsafe double TimestampUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RTCStatsReport']/method[@name='getTimestampUs' and count(parameter)=0]"
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

	}
}
