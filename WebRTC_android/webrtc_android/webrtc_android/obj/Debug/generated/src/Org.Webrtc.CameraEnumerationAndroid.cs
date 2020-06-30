using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='CameraEnumerationAndroid']"
	[global::Android.Runtime.Register ("org/webrtc/CameraEnumerationAndroid", DoNotGenerateAcw=true)]
	public partial class CameraEnumerationAndroid : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='CameraEnumerationAndroid.CaptureFormat']"
		[global::Android.Runtime.Register ("org/webrtc/CameraEnumerationAndroid$CaptureFormat", DoNotGenerateAcw=true)]
		public partial class CaptureFormat : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='CameraEnumerationAndroid.CaptureFormat']/field[@name='framerate']"
			[Register ("framerate")]
			public global::Org.Webrtc.CameraEnumerationAndroid.CaptureFormat.FramerateRange Framerate {
				get {
					const string __id = "framerate.Lorg/webrtc/CameraEnumerationAndroid$CaptureFormat$FramerateRange;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.CameraEnumerationAndroid.CaptureFormat.FramerateRange> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "framerate.Lorg/webrtc/CameraEnumerationAndroid$CaptureFormat$FramerateRange;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='CameraEnumerationAndroid.CaptureFormat']/field[@name='height']"
			[Register ("height")]
			public int Height {
				get {
					const string __id = "height.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "height.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='CameraEnumerationAndroid.CaptureFormat']/field[@name='imageFormat']"
			[Register ("imageFormat")]
			public int ImageFormat {
				get {
					const string __id = "imageFormat.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "imageFormat.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='CameraEnumerationAndroid.CaptureFormat']/field[@name='width']"
			[Register ("width")]
			public int Width {
				get {
					const string __id = "width.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "width.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='CameraEnumerationAndroid.CaptureFormat.FramerateRange']"
			[global::Android.Runtime.Register ("org/webrtc/CameraEnumerationAndroid$CaptureFormat$FramerateRange", DoNotGenerateAcw=true)]
			public partial class FramerateRange : global::Java.Lang.Object {



				// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='CameraEnumerationAndroid.CaptureFormat.FramerateRange']/field[@name='max']"
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


				// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='CameraEnumerationAndroid.CaptureFormat.FramerateRange']/field[@name='min']"
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
				static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/CameraEnumerationAndroid$CaptureFormat$FramerateRange", typeof (FramerateRange));
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

				protected FramerateRange (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='CameraEnumerationAndroid.CaptureFormat.FramerateRange']/constructor[@name='CameraEnumerationAndroid.CaptureFormat.FramerateRange' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
				[Register (".ctor", "(II)V", "")]
				public unsafe FramerateRange (int min, int max)
					: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
				{
					const string __id = "(II)V";

					if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
						return;

					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [2];
						__args [0] = new JniArgumentValue (min);
						__args [1] = new JniArgumentValue (max);
						var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
						SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
						_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
					} finally {
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/CameraEnumerationAndroid$CaptureFormat", typeof (CaptureFormat));
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

			protected CaptureFormat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='CameraEnumerationAndroid.CaptureFormat']/constructor[@name='CameraEnumerationAndroid.CaptureFormat' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register (".ctor", "(IIII)V", "")]
			public unsafe CaptureFormat (int width, int height, int minFramerate, int maxFramerate)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(IIII)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (width);
					__args [1] = new JniArgumentValue (height);
					__args [2] = new JniArgumentValue (minFramerate);
					__args [3] = new JniArgumentValue (maxFramerate);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='CameraEnumerationAndroid.CaptureFormat']/constructor[@name='CameraEnumerationAndroid.CaptureFormat' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='org.webrtc.CameraEnumerationAndroid.CaptureFormat.FramerateRange']]"
			[Register (".ctor", "(IILorg/webrtc/CameraEnumerationAndroid$CaptureFormat$FramerateRange;)V", "")]
			public unsafe CaptureFormat (int width, int height, global::Org.Webrtc.CameraEnumerationAndroid.CaptureFormat.FramerateRange framerate)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(IILorg/webrtc/CameraEnumerationAndroid$CaptureFormat$FramerateRange;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (width);
					__args [1] = new JniArgumentValue (height);
					__args [2] = new JniArgumentValue ((framerate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) framerate).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_frameSize;
#pragma warning disable 0169
			static Delegate GetFrameSizeHandler ()
			{
				if (cb_frameSize == null)
					cb_frameSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_FrameSize);
				return cb_frameSize;
			}

			static int n_FrameSize (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.CameraEnumerationAndroid.CaptureFormat __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.CameraEnumerationAndroid.CaptureFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.FrameSize ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='CameraEnumerationAndroid.CaptureFormat']/method[@name='frameSize' and count(parameter)=0]"
			[Register ("frameSize", "()I", "GetFrameSizeHandler")]
			public virtual unsafe int FrameSize ()
			{
				const string __id = "frameSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='CameraEnumerationAndroid.CaptureFormat']/method[@name='frameSize' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("frameSize", "(III)I", "")]
			public static unsafe int FrameSize (int width, int height, int imageFormat)
			{
				const string __id = "frameSize.(III)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (width);
					__args [1] = new JniArgumentValue (height);
					__args [2] = new JniArgumentValue (imageFormat);
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
					return __rm;
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/CameraEnumerationAndroid", typeof (CameraEnumerationAndroid));
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

		protected CameraEnumerationAndroid (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='CameraEnumerationAndroid']/constructor[@name='CameraEnumerationAndroid' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CameraEnumerationAndroid ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='CameraEnumerationAndroid']/method[@name='getClosestSupportedFramerateRange' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;org.webrtc.CameraEnumerationAndroid.CaptureFormat.FramerateRange&gt;'] and parameter[2][@type='int']]"
		[Register ("getClosestSupportedFramerateRange", "(Ljava/util/List;I)Lorg/webrtc/CameraEnumerationAndroid$CaptureFormat$FramerateRange;", "")]
		public static unsafe global::Org.Webrtc.CameraEnumerationAndroid.CaptureFormat.FramerateRange GetClosestSupportedFramerateRange (global::System.Collections.Generic.IList<global::Org.Webrtc.CameraEnumerationAndroid.CaptureFormat.FramerateRange> supportedFramerates, int requestedFps)
		{
			const string __id = "getClosestSupportedFramerateRange.(Ljava/util/List;I)Lorg/webrtc/CameraEnumerationAndroid$CaptureFormat$FramerateRange;";
			IntPtr native_supportedFramerates = global::Android.Runtime.JavaList<global::Org.Webrtc.CameraEnumerationAndroid.CaptureFormat.FramerateRange>.ToLocalJniHandle (supportedFramerates);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_supportedFramerates);
				__args [1] = new JniArgumentValue (requestedFps);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.CameraEnumerationAndroid.CaptureFormat.FramerateRange> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_supportedFramerates);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='CameraEnumerationAndroid']/method[@name='getClosestSupportedSize' and count(parameter)=3 and parameter[1][@type='java.util.List&lt;org.webrtc.Size&gt;'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getClosestSupportedSize", "(Ljava/util/List;II)Lorg/webrtc/Size;", "")]
		public static unsafe global::Org.Webrtc.Size GetClosestSupportedSize (global::System.Collections.Generic.IList<global::Org.Webrtc.Size> supportedSizes, int requestedWidth, int requestedHeight)
		{
			const string __id = "getClosestSupportedSize.(Ljava/util/List;II)Lorg/webrtc/Size;";
			IntPtr native_supportedSizes = global::Android.Runtime.JavaList<global::Org.Webrtc.Size>.ToLocalJniHandle (supportedSizes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_supportedSizes);
				__args [1] = new JniArgumentValue (requestedWidth);
				__args [2] = new JniArgumentValue (requestedHeight);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Size> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_supportedSizes);
			}
		}

	}
}
