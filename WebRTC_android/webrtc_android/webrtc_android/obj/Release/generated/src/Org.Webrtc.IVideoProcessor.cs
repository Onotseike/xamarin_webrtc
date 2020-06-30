using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoProcessor.FrameAdaptationParameters']"
	[global::Android.Runtime.Register ("org/webrtc/VideoProcessor$FrameAdaptationParameters", DoNotGenerateAcw=true)]
	public partial class VideoProcessorFrameAdaptationParameters : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoProcessor.FrameAdaptationParameters']/field[@name='cropHeight']"
		[Register ("cropHeight")]
		public int CropHeight {
			get {
				const string __id = "cropHeight.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "cropHeight.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoProcessor.FrameAdaptationParameters']/field[@name='cropWidth']"
		[Register ("cropWidth")]
		public int CropWidth {
			get {
				const string __id = "cropWidth.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "cropWidth.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoProcessor.FrameAdaptationParameters']/field[@name='cropX']"
		[Register ("cropX")]
		public int CropX {
			get {
				const string __id = "cropX.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "cropX.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoProcessor.FrameAdaptationParameters']/field[@name='cropY']"
		[Register ("cropY")]
		public int CropY {
			get {
				const string __id = "cropY.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "cropY.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoProcessor.FrameAdaptationParameters']/field[@name='drop']"
		[Register ("drop")]
		public bool Drop {
			get {
				const string __id = "drop.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "drop.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoProcessor.FrameAdaptationParameters']/field[@name='scaleHeight']"
		[Register ("scaleHeight")]
		public int ScaleHeight {
			get {
				const string __id = "scaleHeight.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "scaleHeight.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoProcessor.FrameAdaptationParameters']/field[@name='scaleWidth']"
		[Register ("scaleWidth")]
		public int ScaleWidth {
			get {
				const string __id = "scaleWidth.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "scaleWidth.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoProcessor.FrameAdaptationParameters']/field[@name='timestampNs']"
		[Register ("timestampNs")]
		public long TimestampNs {
			get {
				const string __id = "timestampNs.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "timestampNs.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoProcessor$FrameAdaptationParameters", typeof (VideoProcessorFrameAdaptationParameters));
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

		protected VideoProcessorFrameAdaptationParameters (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoProcessor.FrameAdaptationParameters']/constructor[@name='VideoProcessor.FrameAdaptationParameters' and count(parameter)=8 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='long'] and parameter[8][@type='boolean']]"
		[Register (".ctor", "(IIIIIIJZ)V", "")]
		public unsafe VideoProcessorFrameAdaptationParameters (int cropX, int cropY, int cropWidth, int cropHeight, int scaleWidth, int scaleHeight, long timestampNs, bool drop)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IIIIIIJZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (cropX);
				__args [1] = new JniArgumentValue (cropY);
				__args [2] = new JniArgumentValue (cropWidth);
				__args [3] = new JniArgumentValue (cropHeight);
				__args [4] = new JniArgumentValue (scaleWidth);
				__args [5] = new JniArgumentValue (scaleHeight);
				__args [6] = new JniArgumentValue (timestampNs);
				__args [7] = new JniArgumentValue (drop);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}

	[Register ("org/webrtc/VideoProcessor", DoNotGenerateAcw=true)]
	public abstract class VideoProcessor : Java.Lang.Object {

		internal VideoProcessor ()
		{
		}

		// The following are fields from: org.webrtc.CapturerObserver
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoProcessor']/method[@name='applyFrameAdaptationParameters' and count(parameter)=2 and parameter[1][@type='org.webrtc.VideoFrame'] and parameter[2][@type='org.webrtc.VideoProcessor.FrameAdaptationParameters']]"
		[Register ("applyFrameAdaptationParameters", "(Lorg/webrtc/VideoFrame;Lorg/webrtc/VideoProcessor$FrameAdaptationParameters;)Lorg/webrtc/VideoFrame;", "")]
		public static unsafe global::Org.Webrtc.VideoFrame ApplyFrameAdaptationParameters (global::Org.Webrtc.VideoFrame frame, global::Org.Webrtc.VideoProcessorFrameAdaptationParameters parameters)
		{
			const string __id = "applyFrameAdaptationParameters.(Lorg/webrtc/VideoFrame;Lorg/webrtc/VideoProcessor$FrameAdaptationParameters;)Lorg/webrtc/VideoFrame;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((frame == null) ? IntPtr.Zero : ((global::Java.Lang.Object) frame).Handle);
				__args [1] = new JniArgumentValue ((parameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameters).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoProcessor", typeof (VideoProcessor));
	}

	[Register ("org/webrtc/VideoProcessor", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'VideoProcessor' type. This type will be removed in a future release.", error: true)]
	public abstract class VideoProcessorConsts : VideoProcessor {

		private VideoProcessorConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoProcessor']"
	[Register ("org/webrtc/VideoProcessor", "", "Org.Webrtc.IVideoProcessorInvoker")]
	public partial interface IVideoProcessor : global::Org.Webrtc.ICapturerObserver {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoProcessor']/method[@name='setSink' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoSink']]"
		[Register ("setSink", "(Lorg/webrtc/VideoSink;)V", "GetSetSink_Lorg_webrtc_VideoSink_Handler:Org.Webrtc.IVideoProcessorInvoker, webrtc_android")]
		void SetSink (global::Org.Webrtc.IVideoSink p0);

	}

	[global::Android.Runtime.Register ("org/webrtc/VideoProcessor", DoNotGenerateAcw=true)]
	internal partial class IVideoProcessorInvoker : global::Java.Lang.Object, IVideoProcessor {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoProcessor", typeof (IVideoProcessorInvoker));

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

		public static IVideoProcessor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoProcessor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.VideoProcessor"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoProcessorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_setSink_Lorg_webrtc_VideoSink_;
#pragma warning disable 0169
		static Delegate GetSetSink_Lorg_webrtc_VideoSink_Handler ()
		{
			if (cb_setSink_Lorg_webrtc_VideoSink_ == null)
				cb_setSink_Lorg_webrtc_VideoSink_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSink_Lorg_webrtc_VideoSink_);
			return cb_setSink_Lorg_webrtc_VideoSink_;
		}

		static void n_SetSink_Lorg_webrtc_VideoSink_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.IVideoProcessor __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.IVideoSink p0 = (global::Org.Webrtc.IVideoSink)global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoSink> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSink (p0);
		}
#pragma warning restore 0169

		IntPtr id_setSink_Lorg_webrtc_VideoSink_;
		public unsafe void SetSink (global::Org.Webrtc.IVideoSink p0)
		{
			if (id_setSink_Lorg_webrtc_VideoSink_ == IntPtr.Zero)
				id_setSink_Lorg_webrtc_VideoSink_ = JNIEnv.GetMethodID (class_ref, "setSink", "(Lorg/webrtc/VideoSink;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSink_Lorg_webrtc_VideoSink_, __args);
		}

		static Delegate cb_onCapturerStarted_Z;
#pragma warning disable 0169
		static Delegate GetOnCapturerStarted_ZHandler ()
		{
			if (cb_onCapturerStarted_Z == null)
				cb_onCapturerStarted_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnCapturerStarted_Z);
			return cb_onCapturerStarted_Z;
		}

		static void n_OnCapturerStarted_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Webrtc.IVideoProcessor __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCapturerStarted (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCapturerStarted_Z;
		public unsafe void OnCapturerStarted (bool p0)
		{
			if (id_onCapturerStarted_Z == IntPtr.Zero)
				id_onCapturerStarted_Z = JNIEnv.GetMethodID (class_ref, "onCapturerStarted", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCapturerStarted_Z, __args);
		}

		static Delegate cb_onCapturerStopped;
#pragma warning disable 0169
		static Delegate GetOnCapturerStoppedHandler ()
		{
			if (cb_onCapturerStopped == null)
				cb_onCapturerStopped = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCapturerStopped);
			return cb_onCapturerStopped;
		}

		static void n_OnCapturerStopped (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.IVideoProcessor __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCapturerStopped ();
		}
#pragma warning restore 0169

		IntPtr id_onCapturerStopped;
		public unsafe void OnCapturerStopped ()
		{
			if (id_onCapturerStopped == IntPtr.Zero)
				id_onCapturerStopped = JNIEnv.GetMethodID (class_ref, "onCapturerStopped", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCapturerStopped);
		}

		static Delegate cb_onFrameCaptured_Lorg_webrtc_VideoFrame_;
#pragma warning disable 0169
		static Delegate GetOnFrameCaptured_Lorg_webrtc_VideoFrame_Handler ()
		{
			if (cb_onFrameCaptured_Lorg_webrtc_VideoFrame_ == null)
				cb_onFrameCaptured_Lorg_webrtc_VideoFrame_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFrameCaptured_Lorg_webrtc_VideoFrame_);
			return cb_onFrameCaptured_Lorg_webrtc_VideoFrame_;
		}

		static void n_OnFrameCaptured_Lorg_webrtc_VideoFrame_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.IVideoProcessor __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.VideoFrame p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFrameCaptured (p0);
		}
#pragma warning restore 0169

		IntPtr id_onFrameCaptured_Lorg_webrtc_VideoFrame_;
		public unsafe void OnFrameCaptured (global::Org.Webrtc.VideoFrame p0)
		{
			if (id_onFrameCaptured_Lorg_webrtc_VideoFrame_ == IntPtr.Zero)
				id_onFrameCaptured_Lorg_webrtc_VideoFrame_ = JNIEnv.GetMethodID (class_ref, "onFrameCaptured", "(Lorg/webrtc/VideoFrame;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFrameCaptured_Lorg_webrtc_VideoFrame_, __args);
		}

	}

}
