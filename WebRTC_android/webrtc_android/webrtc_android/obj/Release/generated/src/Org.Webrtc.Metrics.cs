using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='Metrics']"
	[global::Android.Runtime.Register ("org/webrtc/Metrics", DoNotGenerateAcw=true)]
	public partial class Metrics : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Metrics']/field[@name='map']"
		[Register ("map")]
		public global::System.Collections.IDictionary Map {
			get {
				const string __id = "map.Ljava/util/Map;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "map.Ljava/util/Map;";

				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='Metrics.HistogramInfo']"
		[global::Android.Runtime.Register ("org/webrtc/Metrics$HistogramInfo", DoNotGenerateAcw=true)]
		public partial class HistogramInfo : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Metrics.HistogramInfo']/field[@name='bucketCount']"
			[Register ("bucketCount")]
			public int BucketCount {
				get {
					const string __id = "bucketCount.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "bucketCount.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Metrics.HistogramInfo']/field[@name='max']"
			[Register ("max")]
			public int Max {
				get {
					const string __id = "max.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "max.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Metrics.HistogramInfo']/field[@name='min']"
			[Register ("min")]
			public int Min {
				get {
					const string __id = "min.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "min.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Metrics.HistogramInfo']/field[@name='samples']"
			[Register ("samples")]
			public global::System.Collections.IDictionary Samples {
				get {
					const string __id = "samples.Ljava/util/Map;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "samples.Ljava/util/Map;";

					IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/Metrics$HistogramInfo", typeof (HistogramInfo));
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

			protected HistogramInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='Metrics.HistogramInfo']/constructor[@name='Metrics.HistogramInfo' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register (".ctor", "(III)V", "")]
			public unsafe HistogramInfo (int min, int max, int bucketCount)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(III)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (min);
					__args [1] = new JniArgumentValue (max);
					__args [2] = new JniArgumentValue (bucketCount);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_addSample_II;
#pragma warning disable 0169
			static Delegate GetAddSample_IIHandler ()
			{
				if (cb_addSample_II == null)
					cb_addSample_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_AddSample_II);
				return cb_addSample_II;
			}

			static void n_AddSample_II (IntPtr jnienv, IntPtr native__this, int value, int numEvents)
			{
				global::Org.Webrtc.Metrics.HistogramInfo __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Metrics.HistogramInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.AddSample (value, numEvents);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Metrics.HistogramInfo']/method[@name='addSample' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("addSample", "(II)V", "GetAddSample_IIHandler")]
			public virtual unsafe void AddSample (int value, int numEvents)
			{
				const string __id = "addSample.(II)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (value);
					__args [1] = new JniArgumentValue (numEvents);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/Metrics", typeof (Metrics));
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

		protected Metrics (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Org.Webrtc.Metrics AndReset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Metrics']/method[@name='getAndReset' and count(parameter)=0]"
			[Register ("getAndReset", "()Lorg/webrtc/Metrics;", "")]
			get {
				const string __id = "getAndReset.()Lorg/webrtc/Metrics;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Metrics> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Metrics']/method[@name='enable' and count(parameter)=0]"
		[Register ("enable", "()V", "")]
		public static unsafe void Enable ()
		{
			const string __id = "enable.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

	}
}
