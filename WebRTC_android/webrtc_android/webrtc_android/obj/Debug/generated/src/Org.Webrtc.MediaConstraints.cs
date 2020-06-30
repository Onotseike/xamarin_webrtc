using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='MediaConstraints']"
	[global::Android.Runtime.Register ("org/webrtc/MediaConstraints", DoNotGenerateAcw=true)]
	public partial class MediaConstraints : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='MediaConstraints']/field[@name='mandatory']"
		[Register ("mandatory")]
		public global::System.Collections.IList Mandatory {
			get {
				const string __id = "mandatory.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mandatory.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='MediaConstraints']/field[@name='optional']"
		[Register ("optional")]
		public global::System.Collections.IList Optional {
			get {
				const string __id = "optional.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "optional.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='MediaConstraints.KeyValuePair']"
		[global::Android.Runtime.Register ("org/webrtc/MediaConstraints$KeyValuePair", DoNotGenerateAcw=true)]
		public partial class KeyValuePair : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/MediaConstraints$KeyValuePair", typeof (KeyValuePair));
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

			protected KeyValuePair (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='MediaConstraints.KeyValuePair']/constructor[@name='MediaConstraints.KeyValuePair' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe KeyValuePair (string key, string value)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_key = JNIEnv.NewString (key);
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_key);
					__args [1] = new JniArgumentValue (native_value);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_key);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static Delegate cb_getKey;
#pragma warning disable 0169
			static Delegate GetGetKeyHandler ()
			{
				if (cb_getKey == null)
					cb_getKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKey);
				return cb_getKey;
			}

			static IntPtr n_GetKey (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.MediaConstraints.KeyValuePair __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaConstraints.KeyValuePair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Key);
			}
#pragma warning restore 0169

			public virtual unsafe string Key {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaConstraints.KeyValuePair']/method[@name='getKey' and count(parameter)=0]"
				[Register ("getKey", "()Ljava/lang/String;", "GetGetKeyHandler")]
				get {
					const string __id = "getKey.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getValue;
#pragma warning disable 0169
			static Delegate GetGetValueHandler ()
			{
				if (cb_getValue == null)
					cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue);
				return cb_getValue;
			}

			static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.MediaConstraints.KeyValuePair __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaConstraints.KeyValuePair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Value);
			}
#pragma warning restore 0169

			public virtual unsafe string Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaConstraints.KeyValuePair']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()Ljava/lang/String;", "GetGetValueHandler")]
				get {
					const string __id = "getValue.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/MediaConstraints", typeof (MediaConstraints));
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

		protected MediaConstraints (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='MediaConstraints']/constructor[@name='MediaConstraints' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MediaConstraints ()
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

	}
}
