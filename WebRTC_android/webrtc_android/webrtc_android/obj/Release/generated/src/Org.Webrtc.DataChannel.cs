using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel']"
	[global::Android.Runtime.Register ("org/webrtc/DataChannel", DoNotGenerateAcw=true)]
	public partial class DataChannel : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.Buffer']"
		[global::Android.Runtime.Register ("org/webrtc/DataChannel$Buffer", DoNotGenerateAcw=true)]
		public partial class Buffer : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.Buffer']/field[@name='binary']"
			[Register ("binary")]
			public bool Binary {
				get {
					const string __id = "binary.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "binary.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.Buffer']/field[@name='data']"
			[Register ("data")]
			public global::Java.Nio.ByteBuffer Data {
				get {
					const string __id = "data.Ljava/nio/ByteBuffer;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "data.Ljava/nio/ByteBuffer;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/DataChannel$Buffer", typeof (Buffer));
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

			protected Buffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.Buffer']/constructor[@name='DataChannel.Buffer' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='boolean']]"
			[Register (".ctor", "(Ljava/nio/ByteBuffer;Z)V", "")]
			public unsafe Buffer (global::Java.Nio.ByteBuffer data, bool binary)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/nio/ByteBuffer;Z)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
					__args [1] = new JniArgumentValue (binary);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.Init']"
		[global::Android.Runtime.Register ("org/webrtc/DataChannel$Init", DoNotGenerateAcw=true)]
		public partial class Init : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.Init']/field[@name='id']"
			[Register ("id")]
			public int Id {
				get {
					const string __id = "id.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "id.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.Init']/field[@name='maxRetransmitTimeMs']"
			[Register ("maxRetransmitTimeMs")]
			public int MaxRetransmitTimeMs {
				get {
					const string __id = "maxRetransmitTimeMs.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "maxRetransmitTimeMs.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.Init']/field[@name='maxRetransmits']"
			[Register ("maxRetransmits")]
			public int MaxRetransmits {
				get {
					const string __id = "maxRetransmits.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "maxRetransmits.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.Init']/field[@name='negotiated']"
			[Register ("negotiated")]
			public bool Negotiated {
				get {
					const string __id = "negotiated.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "negotiated.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.Init']/field[@name='ordered']"
			[Register ("ordered")]
			public bool Ordered {
				get {
					const string __id = "ordered.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "ordered.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.Init']/field[@name='protocol']"
			[Register ("protocol")]
			public string Protocol {
				get {
					const string __id = "protocol.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "protocol.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/DataChannel$Init", typeof (Init));
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

			protected Init (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.Init']/constructor[@name='DataChannel.Init' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Init ()
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

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='DataChannel.Observer']"
		[Register ("org/webrtc/DataChannel$Observer", "", "Org.Webrtc.DataChannel/IObserverInvoker")]
		public partial interface IObserver : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='DataChannel.Observer']/method[@name='onBufferedAmountChange' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("onBufferedAmountChange", "(J)V", "GetOnBufferedAmountChange_JHandler:Org.Webrtc.DataChannel/IObserverInvoker, webrtc_android")]
			void OnBufferedAmountChange (long p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='DataChannel.Observer']/method[@name='onMessage' and count(parameter)=1 and parameter[1][@type='org.webrtc.DataChannel.Buffer']]"
			[Register ("onMessage", "(Lorg/webrtc/DataChannel$Buffer;)V", "GetOnMessage_Lorg_webrtc_DataChannel_Buffer_Handler:Org.Webrtc.DataChannel/IObserverInvoker, webrtc_android")]
			void OnMessage (global::Org.Webrtc.DataChannel.Buffer p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='DataChannel.Observer']/method[@name='onStateChange' and count(parameter)=0]"
			[Register ("onStateChange", "()V", "GetOnStateChangeHandler:Org.Webrtc.DataChannel/IObserverInvoker, webrtc_android")]
			void OnStateChange ();

		}

		[global::Android.Runtime.Register ("org/webrtc/DataChannel$Observer", DoNotGenerateAcw=true)]
		internal partial class IObserverInvoker : global::Java.Lang.Object, IObserver {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/DataChannel$Observer", typeof (IObserverInvoker));

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
								JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.DataChannel.Observer"));
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

			static Delegate cb_onBufferedAmountChange_J;
#pragma warning disable 0169
			static Delegate GetOnBufferedAmountChange_JHandler ()
			{
				if (cb_onBufferedAmountChange_J == null)
					cb_onBufferedAmountChange_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_OnBufferedAmountChange_J);
				return cb_onBufferedAmountChange_J;
			}

			static void n_OnBufferedAmountChange_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Org.Webrtc.DataChannel.IObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel.IObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnBufferedAmountChange (p0);
			}
#pragma warning restore 0169

			IntPtr id_onBufferedAmountChange_J;
			public unsafe void OnBufferedAmountChange (long p0)
			{
				if (id_onBufferedAmountChange_J == IntPtr.Zero)
					id_onBufferedAmountChange_J = JNIEnv.GetMethodID (class_ref, "onBufferedAmountChange", "(J)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBufferedAmountChange_J, __args);
			}

			static Delegate cb_onMessage_Lorg_webrtc_DataChannel_Buffer_;
#pragma warning disable 0169
			static Delegate GetOnMessage_Lorg_webrtc_DataChannel_Buffer_Handler ()
			{
				if (cb_onMessage_Lorg_webrtc_DataChannel_Buffer_ == null)
					cb_onMessage_Lorg_webrtc_DataChannel_Buffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMessage_Lorg_webrtc_DataChannel_Buffer_);
				return cb_onMessage_Lorg_webrtc_DataChannel_Buffer_;
			}

			static void n_OnMessage_Lorg_webrtc_DataChannel_Buffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.DataChannel.IObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel.IObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.DataChannel.Buffer p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel.Buffer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMessage (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMessage_Lorg_webrtc_DataChannel_Buffer_;
			public unsafe void OnMessage (global::Org.Webrtc.DataChannel.Buffer p0)
			{
				if (id_onMessage_Lorg_webrtc_DataChannel_Buffer_ == IntPtr.Zero)
					id_onMessage_Lorg_webrtc_DataChannel_Buffer_ = JNIEnv.GetMethodID (class_ref, "onMessage", "(Lorg/webrtc/DataChannel$Buffer;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMessage_Lorg_webrtc_DataChannel_Buffer_, __args);
			}

			static Delegate cb_onStateChange;
#pragma warning disable 0169
			static Delegate GetOnStateChangeHandler ()
			{
				if (cb_onStateChange == null)
					cb_onStateChange = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStateChange);
				return cb_onStateChange;
			}

			static void n_OnStateChange (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.DataChannel.IObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel.IObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnStateChange ();
			}
#pragma warning restore 0169

			IntPtr id_onStateChange;
			public unsafe void OnStateChange ()
			{
				if (id_onStateChange == IntPtr.Zero)
					id_onStateChange = JNIEnv.GetMethodID (class_ref, "onStateChange", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStateChange);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.State']"
		[global::Android.Runtime.Register ("org/webrtc/DataChannel$State", DoNotGenerateAcw=true)]
		public sealed partial class State : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.State']/field[@name='CLOSED']"
			[Register ("CLOSED")]
			public static global::Org.Webrtc.DataChannel.State Closed {
				get {
					const string __id = "CLOSED.Lorg/webrtc/DataChannel$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.State']/field[@name='CLOSING']"
			[Register ("CLOSING")]
			public static global::Org.Webrtc.DataChannel.State Closing {
				get {
					const string __id = "CLOSING.Lorg/webrtc/DataChannel$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.State']/field[@name='CONNECTING']"
			[Register ("CONNECTING")]
			public static global::Org.Webrtc.DataChannel.State Connecting {
				get {
					const string __id = "CONNECTING.Lorg/webrtc/DataChannel$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.State']/field[@name='OPEN']"
			[Register ("OPEN")]
			public static global::Org.Webrtc.DataChannel.State Open {
				get {
					const string __id = "OPEN.Lorg/webrtc/DataChannel$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/DataChannel$State", typeof (State));
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

			internal State (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.State']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/DataChannel$State;", "")]
			public static unsafe global::Org.Webrtc.DataChannel.State ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/webrtc/DataChannel$State;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.State']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/DataChannel$State;", "")]
			public static unsafe global::Org.Webrtc.DataChannel.State[] Values ()
			{
				const string __id = "values.()[Lorg/webrtc/DataChannel$State;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Webrtc.DataChannel.State[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.DataChannel.State));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/DataChannel", typeof (DataChannel));
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

		protected DataChannel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel']/constructor[@name='DataChannel' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe DataChannel (long nativeDataChannel)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (nativeDataChannel);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_bufferedAmount;
#pragma warning disable 0169
		static Delegate GetBufferedAmountHandler ()
		{
			if (cb_bufferedAmount == null)
				cb_bufferedAmount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_BufferedAmount);
			return cb_bufferedAmount;
		}

		static long n_BufferedAmount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.DataChannel __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BufferedAmount ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel']/method[@name='bufferedAmount' and count(parameter)=0]"
		[Register ("bufferedAmount", "()J", "GetBufferedAmountHandler")]
		public virtual unsafe long BufferedAmount ()
		{
			const string __id = "bufferedAmount.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
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
			global::Org.Webrtc.DataChannel __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
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
			global::Org.Webrtc.DataChannel __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public virtual unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_id;
#pragma warning disable 0169
		static Delegate GetIdHandler ()
		{
			if (cb_id == null)
				cb_id = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Id);
			return cb_id;
		}

		static int n_Id (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.DataChannel __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Id ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel']/method[@name='id' and count(parameter)=0]"
		[Register ("id", "()I", "GetIdHandler")]
		public virtual unsafe int Id ()
		{
			const string __id = "id.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_label;
#pragma warning disable 0169
		static Delegate GetLabelHandler ()
		{
			if (cb_label == null)
				cb_label = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Label);
			return cb_label;
		}

		static IntPtr n_Label (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.DataChannel __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Label ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel']/method[@name='label' and count(parameter)=0]"
		[Register ("label", "()Ljava/lang/String;", "GetLabelHandler")]
		public virtual unsafe string Label ()
		{
			const string __id = "label.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_registerObserver_Lorg_webrtc_DataChannel_Observer_;
#pragma warning disable 0169
		static Delegate GetRegisterObserver_Lorg_webrtc_DataChannel_Observer_Handler ()
		{
			if (cb_registerObserver_Lorg_webrtc_DataChannel_Observer_ == null)
				cb_registerObserver_Lorg_webrtc_DataChannel_Observer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterObserver_Lorg_webrtc_DataChannel_Observer_);
			return cb_registerObserver_Lorg_webrtc_DataChannel_Observer_;
		}

		static void n_RegisterObserver_Lorg_webrtc_DataChannel_Observer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_observer)
		{
			global::Org.Webrtc.DataChannel __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.DataChannel.IObserver observer = (global::Org.Webrtc.DataChannel.IObserver)global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel.IObserver> (native_observer, JniHandleOwnership.DoNotTransfer);
			__this.RegisterObserver (observer);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel']/method[@name='registerObserver' and count(parameter)=1 and parameter[1][@type='org.webrtc.DataChannel.Observer']]"
		[Register ("registerObserver", "(Lorg/webrtc/DataChannel$Observer;)V", "GetRegisterObserver_Lorg_webrtc_DataChannel_Observer_Handler")]
		public virtual unsafe void RegisterObserver (global::Org.Webrtc.DataChannel.IObserver observer)
		{
			const string __id = "registerObserver.(Lorg/webrtc/DataChannel$Observer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((observer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) observer).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_send_Lorg_webrtc_DataChannel_Buffer_;
#pragma warning disable 0169
		static Delegate GetSend_Lorg_webrtc_DataChannel_Buffer_Handler ()
		{
			if (cb_send_Lorg_webrtc_DataChannel_Buffer_ == null)
				cb_send_Lorg_webrtc_DataChannel_Buffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Send_Lorg_webrtc_DataChannel_Buffer_);
			return cb_send_Lorg_webrtc_DataChannel_Buffer_;
		}

		static bool n_Send_Lorg_webrtc_DataChannel_Buffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer)
		{
			global::Org.Webrtc.DataChannel __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.DataChannel.Buffer buffer = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel.Buffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Send (buffer);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel']/method[@name='send' and count(parameter)=1 and parameter[1][@type='org.webrtc.DataChannel.Buffer']]"
		[Register ("send", "(Lorg/webrtc/DataChannel$Buffer;)Z", "GetSend_Lorg_webrtc_DataChannel_Buffer_Handler")]
		public virtual unsafe bool Send (global::Org.Webrtc.DataChannel.Buffer buffer)
		{
			const string __id = "send.(Lorg/webrtc/DataChannel$Buffer;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_state;
#pragma warning disable 0169
		static Delegate GetInvokeStateHandler ()
		{
			if (cb_state == null)
				cb_state = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_InvokeState);
			return cb_state;
		}

		static IntPtr n_InvokeState (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.DataChannel __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeState ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel']/method[@name='state' and count(parameter)=0]"
		[Register ("state", "()Lorg/webrtc/DataChannel$State;", "GetInvokeStateHandler")]
		public virtual unsafe global::Org.Webrtc.DataChannel.State InvokeState ()
		{
			const string __id = "state.()Lorg/webrtc/DataChannel$State;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_unregisterObserver;
#pragma warning disable 0169
		static Delegate GetUnregisterObserverHandler ()
		{
			if (cb_unregisterObserver == null)
				cb_unregisterObserver = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UnregisterObserver);
			return cb_unregisterObserver;
		}

		static void n_UnregisterObserver (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.DataChannel __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterObserver ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel']/method[@name='unregisterObserver' and count(parameter)=0]"
		[Register ("unregisterObserver", "()V", "GetUnregisterObserverHandler")]
		public virtual unsafe void UnregisterObserver ()
		{
			const string __id = "unregisterObserver.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
