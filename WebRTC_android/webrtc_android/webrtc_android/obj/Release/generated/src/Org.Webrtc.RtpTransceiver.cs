using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='RtpTransceiver']"
	[global::Android.Runtime.Register ("org/webrtc/RtpTransceiver", DoNotGenerateAcw=true)]
	public partial class RtpTransceiver : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='RtpTransceiver.RtpTransceiverDirection']"
		[global::Android.Runtime.Register ("org/webrtc/RtpTransceiver$RtpTransceiverDirection", DoNotGenerateAcw=true)]
		public sealed partial class RtpTransceiverDirection : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='RtpTransceiver.RtpTransceiverDirection']/field[@name='INACTIVE']"
			[Register ("INACTIVE")]
			public static global::Org.Webrtc.RtpTransceiver.RtpTransceiverDirection Inactive {
				get {
					const string __id = "INACTIVE.Lorg/webrtc/RtpTransceiver$RtpTransceiverDirection;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpTransceiver.RtpTransceiverDirection> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='RtpTransceiver.RtpTransceiverDirection']/field[@name='RECV_ONLY']"
			[Register ("RECV_ONLY")]
			public static global::Org.Webrtc.RtpTransceiver.RtpTransceiverDirection RecvOnly {
				get {
					const string __id = "RECV_ONLY.Lorg/webrtc/RtpTransceiver$RtpTransceiverDirection;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpTransceiver.RtpTransceiverDirection> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='RtpTransceiver.RtpTransceiverDirection']/field[@name='SEND_ONLY']"
			[Register ("SEND_ONLY")]
			public static global::Org.Webrtc.RtpTransceiver.RtpTransceiverDirection SendOnly {
				get {
					const string __id = "SEND_ONLY.Lorg/webrtc/RtpTransceiver$RtpTransceiverDirection;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpTransceiver.RtpTransceiverDirection> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='RtpTransceiver.RtpTransceiverDirection']/field[@name='SEND_RECV']"
			[Register ("SEND_RECV")]
			public static global::Org.Webrtc.RtpTransceiver.RtpTransceiverDirection SendRecv {
				get {
					const string __id = "SEND_RECV.Lorg/webrtc/RtpTransceiver$RtpTransceiverDirection;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpTransceiver.RtpTransceiverDirection> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/RtpTransceiver$RtpTransceiverDirection", typeof (RtpTransceiverDirection));
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

			internal RtpTransceiverDirection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpTransceiver.RtpTransceiverDirection']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/RtpTransceiver$RtpTransceiverDirection;", "")]
			public static unsafe global::Org.Webrtc.RtpTransceiver.RtpTransceiverDirection ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/webrtc/RtpTransceiver$RtpTransceiverDirection;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpTransceiver.RtpTransceiverDirection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpTransceiver.RtpTransceiverDirection']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/RtpTransceiver$RtpTransceiverDirection;", "")]
			public static unsafe global::Org.Webrtc.RtpTransceiver.RtpTransceiverDirection[] Values ()
			{
				const string __id = "values.()[Lorg/webrtc/RtpTransceiver$RtpTransceiverDirection;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Webrtc.RtpTransceiver.RtpTransceiverDirection[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.RtpTransceiver.RtpTransceiverDirection));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='RtpTransceiver.RtpTransceiverInit']"
		[global::Android.Runtime.Register ("org/webrtc/RtpTransceiver$RtpTransceiverInit", DoNotGenerateAcw=true)]
		public sealed partial class RtpTransceiverInit : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/RtpTransceiver$RtpTransceiverInit", typeof (RtpTransceiverInit));
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

			internal RtpTransceiverInit (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='RtpTransceiver.RtpTransceiverInit']/constructor[@name='RtpTransceiver.RtpTransceiverInit' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe RtpTransceiverInit ()
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='RtpTransceiver.RtpTransceiverInit']/constructor[@name='RtpTransceiver.RtpTransceiverInit' and count(parameter)=1 and parameter[1][@type='org.webrtc.RtpTransceiver.RtpTransceiverDirection']]"
			[Register (".ctor", "(Lorg/webrtc/RtpTransceiver$RtpTransceiverDirection;)V", "")]
			public unsafe RtpTransceiverInit (global::Org.Webrtc.RtpTransceiver.RtpTransceiverDirection direction)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lorg/webrtc/RtpTransceiver$RtpTransceiverDirection;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((direction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) direction).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='RtpTransceiver.RtpTransceiverInit']/constructor[@name='RtpTransceiver.RtpTransceiverInit' and count(parameter)=2 and parameter[1][@type='org.webrtc.RtpTransceiver.RtpTransceiverDirection'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register (".ctor", "(Lorg/webrtc/RtpTransceiver$RtpTransceiverDirection;Ljava/util/List;)V", "")]
			public unsafe RtpTransceiverInit (global::Org.Webrtc.RtpTransceiver.RtpTransceiverDirection direction, global::System.Collections.Generic.IList<string> streamIds)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lorg/webrtc/RtpTransceiver$RtpTransceiverDirection;Ljava/util/List;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_streamIds = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (streamIds);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((direction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) direction).Handle);
					__args [1] = new JniArgumentValue (native_streamIds);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_streamIds);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='RtpTransceiver.RtpTransceiverInit']/constructor[@name='RtpTransceiver.RtpTransceiverInit' and count(parameter)=3 and parameter[1][@type='org.webrtc.RtpTransceiver.RtpTransceiverDirection'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[3][@type='java.util.List&lt;org.webrtc.RtpParameters.Encoding&gt;']]"
			[Register (".ctor", "(Lorg/webrtc/RtpTransceiver$RtpTransceiverDirection;Ljava/util/List;Ljava/util/List;)V", "")]
			public unsafe RtpTransceiverInit (global::Org.Webrtc.RtpTransceiver.RtpTransceiverDirection direction, global::System.Collections.Generic.IList<string> streamIds, global::System.Collections.Generic.IList<global::Org.Webrtc.RtpParameters.Encoding> sendEncodings)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lorg/webrtc/RtpTransceiver$RtpTransceiverDirection;Ljava/util/List;Ljava/util/List;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_streamIds = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (streamIds);
				IntPtr native_sendEncodings = global::Android.Runtime.JavaList<global::Org.Webrtc.RtpParameters.Encoding>.ToLocalJniHandle (sendEncodings);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((direction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) direction).Handle);
					__args [1] = new JniArgumentValue (native_streamIds);
					__args [2] = new JniArgumentValue (native_sendEncodings);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_streamIds);
					JNIEnv.DeleteLocalRef (native_sendEncodings);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/RtpTransceiver", typeof (RtpTransceiver));
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

		protected RtpTransceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='RtpTransceiver']/constructor[@name='RtpTransceiver' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe RtpTransceiver (long nativeRtpTransceiver)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (nativeRtpTransceiver);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getCurrentDirection;
#pragma warning disable 0169
		static Delegate GetGetCurrentDirectionHandler ()
		{
			if (cb_getCurrentDirection == null)
				cb_getCurrentDirection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentDirection);
			return cb_getCurrentDirection;
		}

		static IntPtr n_GetCurrentDirection (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.RtpTransceiver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpTransceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentDirection);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Webrtc.RtpTransceiver.RtpTransceiverDirection CurrentDirection {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpTransceiver']/method[@name='getCurrentDirection' and count(parameter)=0]"
			[Register ("getCurrentDirection", "()Lorg/webrtc/RtpTransceiver$RtpTransceiverDirection;", "GetGetCurrentDirectionHandler")]
			get {
				const string __id = "getCurrentDirection.()Lorg/webrtc/RtpTransceiver$RtpTransceiverDirection;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpTransceiver.RtpTransceiverDirection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDirection;
#pragma warning disable 0169
		static Delegate GetGetDirectionHandler ()
		{
			if (cb_getDirection == null)
				cb_getDirection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDirection);
			return cb_getDirection;
		}

		static IntPtr n_GetDirection (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.RtpTransceiver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpTransceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Direction);
		}
#pragma warning restore 0169

		static Delegate cb_setDirection_Lorg_webrtc_RtpTransceiver_RtpTransceiverDirection_;
#pragma warning disable 0169
		static Delegate GetSetDirection_Lorg_webrtc_RtpTransceiver_RtpTransceiverDirection_Handler ()
		{
			if (cb_setDirection_Lorg_webrtc_RtpTransceiver_RtpTransceiverDirection_ == null)
				cb_setDirection_Lorg_webrtc_RtpTransceiver_RtpTransceiverDirection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDirection_Lorg_webrtc_RtpTransceiver_RtpTransceiverDirection_);
			return cb_setDirection_Lorg_webrtc_RtpTransceiver_RtpTransceiverDirection_;
		}

		static void n_SetDirection_Lorg_webrtc_RtpTransceiver_RtpTransceiverDirection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rtpTransceiverDirection)
		{
			global::Org.Webrtc.RtpTransceiver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpTransceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.RtpTransceiver.RtpTransceiverDirection rtpTransceiverDirection = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpTransceiver.RtpTransceiverDirection> (native_rtpTransceiverDirection, JniHandleOwnership.DoNotTransfer);
			__this.Direction = rtpTransceiverDirection;
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Webrtc.RtpTransceiver.RtpTransceiverDirection Direction {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpTransceiver']/method[@name='getDirection' and count(parameter)=0]"
			[Register ("getDirection", "()Lorg/webrtc/RtpTransceiver$RtpTransceiverDirection;", "GetGetDirectionHandler")]
			get {
				const string __id = "getDirection.()Lorg/webrtc/RtpTransceiver$RtpTransceiverDirection;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpTransceiver.RtpTransceiverDirection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpTransceiver']/method[@name='setDirection' and count(parameter)=1 and parameter[1][@type='org.webrtc.RtpTransceiver.RtpTransceiverDirection']]"
			[Register ("setDirection", "(Lorg/webrtc/RtpTransceiver$RtpTransceiverDirection;)V", "GetSetDirection_Lorg_webrtc_RtpTransceiver_RtpTransceiverDirection_Handler")]
			set {
				const string __id = "setDirection.(Lorg/webrtc/RtpTransceiver$RtpTransceiverDirection;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isStopped;
#pragma warning disable 0169
		static Delegate GetIsStoppedHandler ()
		{
			if (cb_isStopped == null)
				cb_isStopped = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsStopped);
			return cb_isStopped;
		}

		static bool n_IsStopped (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.RtpTransceiver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpTransceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStopped;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsStopped {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpTransceiver']/method[@name='isStopped' and count(parameter)=0]"
			[Register ("isStopped", "()Z", "GetIsStoppedHandler")]
			get {
				const string __id = "isStopped.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMediaType;
#pragma warning disable 0169
		static Delegate GetGetMediaTypeHandler ()
		{
			if (cb_getMediaType == null)
				cb_getMediaType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMediaType);
			return cb_getMediaType;
		}

		static IntPtr n_GetMediaType (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.RtpTransceiver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpTransceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MediaType);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Webrtc.MediaStreamTrack.MediaType MediaType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpTransceiver']/method[@name='getMediaType' and count(parameter)=0]"
			[Register ("getMediaType", "()Lorg/webrtc/MediaStreamTrack$MediaType;", "GetGetMediaTypeHandler")]
			get {
				const string __id = "getMediaType.()Lorg/webrtc/MediaStreamTrack$MediaType;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack.MediaType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMid;
#pragma warning disable 0169
		static Delegate GetGetMidHandler ()
		{
			if (cb_getMid == null)
				cb_getMid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMid);
			return cb_getMid;
		}

		static IntPtr n_GetMid (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.RtpTransceiver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpTransceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Mid);
		}
#pragma warning restore 0169

		public virtual unsafe string Mid {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpTransceiver']/method[@name='getMid' and count(parameter)=0]"
			[Register ("getMid", "()Ljava/lang/String;", "GetGetMidHandler")]
			get {
				const string __id = "getMid.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getReceiver;
#pragma warning disable 0169
		static Delegate GetGetReceiverHandler ()
		{
			if (cb_getReceiver == null)
				cb_getReceiver = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReceiver);
			return cb_getReceiver;
		}

		static IntPtr n_GetReceiver (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.RtpTransceiver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpTransceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Receiver);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Webrtc.RtpReceiver Receiver {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpTransceiver']/method[@name='getReceiver' and count(parameter)=0]"
			[Register ("getReceiver", "()Lorg/webrtc/RtpReceiver;", "GetGetReceiverHandler")]
			get {
				const string __id = "getReceiver.()Lorg/webrtc/RtpReceiver;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpReceiver> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSender;
#pragma warning disable 0169
		static Delegate GetGetSenderHandler ()
		{
			if (cb_getSender == null)
				cb_getSender = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSender);
			return cb_getSender;
		}

		static IntPtr n_GetSender (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.RtpTransceiver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpTransceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Sender);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Webrtc.RtpSender Sender {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpTransceiver']/method[@name='getSender' and count(parameter)=0]"
			[Register ("getSender", "()Lorg/webrtc/RtpSender;", "GetGetSenderHandler")]
			get {
				const string __id = "getSender.()Lorg/webrtc/RtpSender;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpSender> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Org.Webrtc.RtpTransceiver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpTransceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpTransceiver']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public virtual unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.RtpTransceiver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.RtpTransceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='RtpTransceiver']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
