using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='SessionDescription']"
	[global::Android.Runtime.Register ("org/webrtc/SessionDescription", DoNotGenerateAcw=true)]
	public partial class SessionDescription : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='SessionDescription']/field[@name='description']"
		[Register ("description")]
		public string Description {
			get {
				const string __id = "description.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "description.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='SessionDescription.Type']"
		[global::Android.Runtime.Register ("org/webrtc/SessionDescription$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='SessionDescription.Type']/field[@name='ANSWER']"
			[Register ("ANSWER")]
			public static global::Org.Webrtc.SessionDescription.Type Answer {
				get {
					const string __id = "ANSWER.Lorg/webrtc/SessionDescription$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.SessionDescription.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='SessionDescription.Type']/field[@name='OFFER']"
			[Register ("OFFER")]
			public static global::Org.Webrtc.SessionDescription.Type Offer {
				get {
					const string __id = "OFFER.Lorg/webrtc/SessionDescription$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.SessionDescription.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='SessionDescription.Type']/field[@name='PRANSWER']"
			[Register ("PRANSWER")]
			public static global::Org.Webrtc.SessionDescription.Type Pranswer {
				get {
					const string __id = "PRANSWER.Lorg/webrtc/SessionDescription$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.SessionDescription.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/SessionDescription$Type", typeof (Type));
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

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SessionDescription.Type']/method[@name='canonicalForm' and count(parameter)=0]"
			[Register ("canonicalForm", "()Ljava/lang/String;", "")]
			public unsafe string CanonicalForm ()
			{
				const string __id = "canonicalForm.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SessionDescription.Type']/method[@name='fromCanonicalForm' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromCanonicalForm", "(Ljava/lang/String;)Lorg/webrtc/SessionDescription$Type;", "")]
			public static unsafe global::Org.Webrtc.SessionDescription.Type FromCanonicalForm (string canonical)
			{
				const string __id = "fromCanonicalForm.(Ljava/lang/String;)Lorg/webrtc/SessionDescription$Type;";
				IntPtr native_canonical = JNIEnv.NewString (canonical);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_canonical);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.SessionDescription.Type> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_canonical);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SessionDescription.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/SessionDescription$Type;", "")]
			public static unsafe global::Org.Webrtc.SessionDescription.Type ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/webrtc/SessionDescription$Type;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.SessionDescription.Type> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SessionDescription.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/SessionDescription$Type;", "")]
			public static unsafe global::Org.Webrtc.SessionDescription.Type[] Values ()
			{
				const string __id = "values.()[Lorg/webrtc/SessionDescription$Type;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Webrtc.SessionDescription.Type[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.SessionDescription.Type));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/SessionDescription", typeof (SessionDescription));
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

		protected SessionDescription (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='SessionDescription']/constructor[@name='SessionDescription' and count(parameter)=2 and parameter[1][@type='org.webrtc.SessionDescription.Type'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lorg/webrtc/SessionDescription$Type;Ljava/lang/String;)V", "")]
		public unsafe SessionDescription (global::Org.Webrtc.SessionDescription.Type type, string description)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/webrtc/SessionDescription$Type;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_description = JNIEnv.NewString (description);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				__args [1] = new JniArgumentValue (native_description);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_description);
			}
		}

	}
}
