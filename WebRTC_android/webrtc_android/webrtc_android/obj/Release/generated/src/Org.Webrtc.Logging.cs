using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='Logging']"
	[global::Android.Runtime.Register ("org/webrtc/Logging", DoNotGenerateAcw=true)]
	public partial class Logging : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.Severity']"
		[global::Android.Runtime.Register ("org/webrtc/Logging$Severity", DoNotGenerateAcw=true)]
		public sealed partial class Severity : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.Severity']/field[@name='LS_ERROR']"
			[Register ("LS_ERROR")]
			public static global::Org.Webrtc.Logging.Severity LsError {
				get {
					const string __id = "LS_ERROR.Lorg/webrtc/Logging$Severity;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.Severity> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.Severity']/field[@name='LS_INFO']"
			[Register ("LS_INFO")]
			public static global::Org.Webrtc.Logging.Severity LsInfo {
				get {
					const string __id = "LS_INFO.Lorg/webrtc/Logging$Severity;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.Severity> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.Severity']/field[@name='LS_NONE']"
			[Register ("LS_NONE")]
			public static global::Org.Webrtc.Logging.Severity LsNone {
				get {
					const string __id = "LS_NONE.Lorg/webrtc/Logging$Severity;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.Severity> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.Severity']/field[@name='LS_VERBOSE']"
			[Register ("LS_VERBOSE")]
			public static global::Org.Webrtc.Logging.Severity LsVerbose {
				get {
					const string __id = "LS_VERBOSE.Lorg/webrtc/Logging$Severity;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.Severity> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.Severity']/field[@name='LS_WARNING']"
			[Register ("LS_WARNING")]
			public static global::Org.Webrtc.Logging.Severity LsWarning {
				get {
					const string __id = "LS_WARNING.Lorg/webrtc/Logging$Severity;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.Severity> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/Logging$Severity", typeof (Severity));
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

			internal Severity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.Severity']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/Logging$Severity;", "")]
			public static unsafe global::Org.Webrtc.Logging.Severity ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/webrtc/Logging$Severity;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.Severity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.Severity']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/Logging$Severity;", "")]
			public static unsafe global::Org.Webrtc.Logging.Severity[] Values ()
			{
				const string __id = "values.()[Lorg/webrtc/Logging$Severity;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Webrtc.Logging.Severity[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.Logging.Severity));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']"
		[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
		[global::Android.Runtime.Register ("org/webrtc/Logging$TraceLevel", DoNotGenerateAcw=true)]
		public sealed partial class TraceLevel : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/field[@name='TRACE_ALL']"
			[Register ("TRACE_ALL")]
			public static global::Org.Webrtc.Logging.TraceLevel TraceAll {
				get {
					const string __id = "TRACE_ALL.Lorg/webrtc/Logging$TraceLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.TraceLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/field[@name='TRACE_APICALL']"
			[Register ("TRACE_APICALL")]
			public static global::Org.Webrtc.Logging.TraceLevel TraceApicall {
				get {
					const string __id = "TRACE_APICALL.Lorg/webrtc/Logging$TraceLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.TraceLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/field[@name='TRACE_CRITICAL']"
			[Register ("TRACE_CRITICAL")]
			public static global::Org.Webrtc.Logging.TraceLevel TraceCritical {
				get {
					const string __id = "TRACE_CRITICAL.Lorg/webrtc/Logging$TraceLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.TraceLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/field[@name='TRACE_DEBUG']"
			[Register ("TRACE_DEBUG")]
			public static global::Org.Webrtc.Logging.TraceLevel TraceDebug {
				get {
					const string __id = "TRACE_DEBUG.Lorg/webrtc/Logging$TraceLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.TraceLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/field[@name='TRACE_DEFAULT']"
			[Register ("TRACE_DEFAULT")]
			public static global::Org.Webrtc.Logging.TraceLevel TraceDefault {
				get {
					const string __id = "TRACE_DEFAULT.Lorg/webrtc/Logging$TraceLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.TraceLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/field[@name='TRACE_ERROR']"
			[Register ("TRACE_ERROR")]
			public static global::Org.Webrtc.Logging.TraceLevel TraceError {
				get {
					const string __id = "TRACE_ERROR.Lorg/webrtc/Logging$TraceLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.TraceLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/field[@name='TRACE_INFO']"
			[Register ("TRACE_INFO")]
			public static global::Org.Webrtc.Logging.TraceLevel TraceInfo {
				get {
					const string __id = "TRACE_INFO.Lorg/webrtc/Logging$TraceLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.TraceLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/field[@name='TRACE_MEMORY']"
			[Register ("TRACE_MEMORY")]
			public static global::Org.Webrtc.Logging.TraceLevel TraceMemory {
				get {
					const string __id = "TRACE_MEMORY.Lorg/webrtc/Logging$TraceLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.TraceLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/field[@name='TRACE_MODULECALL']"
			[Register ("TRACE_MODULECALL")]
			public static global::Org.Webrtc.Logging.TraceLevel TraceModulecall {
				get {
					const string __id = "TRACE_MODULECALL.Lorg/webrtc/Logging$TraceLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.TraceLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/field[@name='TRACE_NONE']"
			[Register ("TRACE_NONE")]
			public static global::Org.Webrtc.Logging.TraceLevel TraceNone {
				get {
					const string __id = "TRACE_NONE.Lorg/webrtc/Logging$TraceLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.TraceLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/field[@name='TRACE_STATEINFO']"
			[Register ("TRACE_STATEINFO")]
			public static global::Org.Webrtc.Logging.TraceLevel TraceStateinfo {
				get {
					const string __id = "TRACE_STATEINFO.Lorg/webrtc/Logging$TraceLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.TraceLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/field[@name='TRACE_STREAM']"
			[Register ("TRACE_STREAM")]
			public static global::Org.Webrtc.Logging.TraceLevel TraceStream {
				get {
					const string __id = "TRACE_STREAM.Lorg/webrtc/Logging$TraceLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.TraceLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/field[@name='TRACE_TERSEINFO']"
			[Register ("TRACE_TERSEINFO")]
			public static global::Org.Webrtc.Logging.TraceLevel TraceTerseinfo {
				get {
					const string __id = "TRACE_TERSEINFO.Lorg/webrtc/Logging$TraceLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.TraceLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/field[@name='TRACE_TIMER']"
			[Register ("TRACE_TIMER")]
			public static global::Org.Webrtc.Logging.TraceLevel TraceTimer {
				get {
					const string __id = "TRACE_TIMER.Lorg/webrtc/Logging$TraceLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.TraceLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/field[@name='TRACE_WARNING']"
			[Register ("TRACE_WARNING")]
			public static global::Org.Webrtc.Logging.TraceLevel TraceWarning {
				get {
					const string __id = "TRACE_WARNING.Lorg/webrtc/Logging$TraceLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.TraceLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/field[@name='level']"
			[Register ("level")]
			public int Level {
				get {
					const string __id = "level.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "level.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/Logging$TraceLevel", typeof (TraceLevel));
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

			internal TraceLevel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/Logging$TraceLevel;", "")]
			public static unsafe global::Org.Webrtc.Logging.TraceLevel ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/webrtc/Logging$TraceLevel;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.TraceLevel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/Logging$TraceLevel;", "")]
			public static unsafe global::Org.Webrtc.Logging.TraceLevel[] Values ()
			{
				const string __id = "values.()[Lorg/webrtc/Logging$TraceLevel;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Webrtc.Logging.TraceLevel[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.Logging.TraceLevel));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/Logging", typeof (Logging));
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

		protected Logging (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='Logging']/constructor[@name='Logging' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Logging ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Logging']/method[@name='d' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void D (string tag, string message)
		{
			const string __id = "d.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_message);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Logging']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void E (string tag, string message)
		{
			const string __id = "e.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_message);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Logging']/method[@name='e' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void E (string tag, string message, global::Java.Lang.Throwable e)
		{
			const string __id = "e.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_message);
				__args [2] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Logging']/method[@name='enableLogThreads' and count(parameter)=0]"
		[Register ("enableLogThreads", "()V", "")]
		public static unsafe void EnableLogThreads ()
		{
			const string __id = "enableLogThreads.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Logging']/method[@name='enableLogTimeStamps' and count(parameter)=0]"
		[Register ("enableLogTimeStamps", "()V", "")]
		public static unsafe void EnableLogTimeStamps ()
		{
			const string __id = "enableLogTimeStamps.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Logging']/method[@name='enableLogToDebugOutput' and count(parameter)=1 and parameter[1][@type='org.webrtc.Logging.Severity']]"
		[Register ("enableLogToDebugOutput", "(Lorg/webrtc/Logging$Severity;)V", "")]
		public static unsafe void EnableLogToDebugOutput (global::Org.Webrtc.Logging.Severity severity)
		{
			const string __id = "enableLogToDebugOutput.(Lorg/webrtc/Logging$Severity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((severity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) severity).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Logging']/method[@name='enableTracing' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.EnumSet&lt;org.webrtc.Logging.TraceLevel&gt;']]"
		[Obsolete (@"deprecated")]
		[Register ("enableTracing", "(Ljava/lang/String;Ljava/util/EnumSet;)V", "")]
		public static unsafe void EnableTracing (string path, global::Java.Util.EnumSet levels)
		{
			const string __id = "enableTracing.(Ljava/lang/String;Ljava/util/EnumSet;)V";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue ((levels == null) ? IntPtr.Zero : ((global::Java.Lang.Object) levels).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Logging']/method[@name='log' and count(parameter)=3 and parameter[1][@type='org.webrtc.Logging.Severity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("log", "(Lorg/webrtc/Logging$Severity;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void Log (global::Org.Webrtc.Logging.Severity severity, string tag, string message)
		{
			const string __id = "log.(Lorg/webrtc/Logging$Severity;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((severity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) severity).Handle);
				__args [1] = new JniArgumentValue (native_tag);
				__args [2] = new JniArgumentValue (native_message);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Logging']/method[@name='v' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("v", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void V (string tag, string message)
		{
			const string __id = "v.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_message);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Logging']/method[@name='w' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void W (string tag, string message)
		{
			const string __id = "w.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_message);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Logging']/method[@name='w' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void W (string tag, string message, global::Java.Lang.Throwable e)
		{
			const string __id = "w.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_message);
				__args [2] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

	}
}
