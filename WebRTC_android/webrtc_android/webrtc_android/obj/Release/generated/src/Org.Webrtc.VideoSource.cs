using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoSource']"
	[global::Android.Runtime.Register ("org/webrtc/VideoSource", DoNotGenerateAcw=true)]
	public partial class VideoSource : global::Org.Webrtc.MediaSource {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoSource.AspectRatio']"
		[global::Android.Runtime.Register ("org/webrtc/VideoSource$AspectRatio", DoNotGenerateAcw=true)]
		public partial class AspectRatio : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoSource.AspectRatio']/field[@name='UNDEFINED']"
			[Register ("UNDEFINED")]
			public static global::Org.Webrtc.VideoSource.AspectRatio Undefined {
				get {
					const string __id = "UNDEFINED.Lorg/webrtc/VideoSource$AspectRatio;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoSource.AspectRatio> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoSource.AspectRatio']/field[@name='height']"
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


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoSource.AspectRatio']/field[@name='width']"
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
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoSource$AspectRatio", typeof (AspectRatio));
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

			protected AspectRatio (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoSource.AspectRatio']/constructor[@name='VideoSource.AspectRatio' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register (".ctor", "(II)V", "")]
			public unsafe AspectRatio (int width, int height)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(II)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (width);
					__args [1] = new JniArgumentValue (height);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoSource", typeof (VideoSource));
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

		protected VideoSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoSource']/constructor[@name='VideoSource' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe VideoSource (long nativeSource)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (nativeSource);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getCapturerObserver;
#pragma warning disable 0169
		static Delegate GetGetCapturerObserverHandler ()
		{
			if (cb_getCapturerObserver == null)
				cb_getCapturerObserver = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCapturerObserver);
			return cb_getCapturerObserver;
		}

		static IntPtr n_GetCapturerObserver (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.VideoSource __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CapturerObserver);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Webrtc.ICapturerObserver CapturerObserver {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoSource']/method[@name='getCapturerObserver' and count(parameter)=0]"
			[Register ("getCapturerObserver", "()Lorg/webrtc/CapturerObserver;", "GetGetCapturerObserverHandler")]
			get {
				const string __id = "getCapturerObserver.()Lorg/webrtc/CapturerObserver;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.ICapturerObserver> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_adaptOutputFormat_III;
#pragma warning disable 0169
		static Delegate GetAdaptOutputFormat_IIIHandler ()
		{
			if (cb_adaptOutputFormat_III == null)
				cb_adaptOutputFormat_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_AdaptOutputFormat_III);
			return cb_adaptOutputFormat_III;
		}

		static void n_AdaptOutputFormat_III (IntPtr jnienv, IntPtr native__this, int width, int height, int fps)
		{
			global::Org.Webrtc.VideoSource __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AdaptOutputFormat (width, height, fps);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoSource']/method[@name='adaptOutputFormat' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("adaptOutputFormat", "(III)V", "GetAdaptOutputFormat_IIIHandler")]
		public virtual unsafe void AdaptOutputFormat (int width, int height, int fps)
		{
			const string __id = "adaptOutputFormat.(III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
				__args [2] = new JniArgumentValue (fps);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_adaptOutputFormat_IIIII;
#pragma warning disable 0169
		static Delegate GetAdaptOutputFormat_IIIIIHandler ()
		{
			if (cb_adaptOutputFormat_IIIII == null)
				cb_adaptOutputFormat_IIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int, int>) n_AdaptOutputFormat_IIIII);
			return cb_adaptOutputFormat_IIIII;
		}

		static void n_AdaptOutputFormat_IIIII (IntPtr jnienv, IntPtr native__this, int landscapeWidth, int landscapeHeight, int portraitWidth, int portraitHeight, int fps)
		{
			global::Org.Webrtc.VideoSource __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AdaptOutputFormat (landscapeWidth, landscapeHeight, portraitWidth, portraitHeight, fps);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoSource']/method[@name='adaptOutputFormat' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("adaptOutputFormat", "(IIIII)V", "GetAdaptOutputFormat_IIIIIHandler")]
		public virtual unsafe void AdaptOutputFormat (int landscapeWidth, int landscapeHeight, int portraitWidth, int portraitHeight, int fps)
		{
			const string __id = "adaptOutputFormat.(IIIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (landscapeWidth);
				__args [1] = new JniArgumentValue (landscapeHeight);
				__args [2] = new JniArgumentValue (portraitWidth);
				__args [3] = new JniArgumentValue (portraitHeight);
				__args [4] = new JniArgumentValue (fps);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_adaptOutputFormat_Lorg_webrtc_VideoSource_AspectRatio_Ljava_lang_Integer_Lorg_webrtc_VideoSource_AspectRatio_Ljava_lang_Integer_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetAdaptOutputFormat_Lorg_webrtc_VideoSource_AspectRatio_Ljava_lang_Integer_Lorg_webrtc_VideoSource_AspectRatio_Ljava_lang_Integer_Ljava_lang_Integer_Handler ()
		{
			if (cb_adaptOutputFormat_Lorg_webrtc_VideoSource_AspectRatio_Ljava_lang_Integer_Lorg_webrtc_VideoSource_AspectRatio_Ljava_lang_Integer_Ljava_lang_Integer_ == null)
				cb_adaptOutputFormat_Lorg_webrtc_VideoSource_AspectRatio_Ljava_lang_Integer_Lorg_webrtc_VideoSource_AspectRatio_Ljava_lang_Integer_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AdaptOutputFormat_Lorg_webrtc_VideoSource_AspectRatio_Ljava_lang_Integer_Lorg_webrtc_VideoSource_AspectRatio_Ljava_lang_Integer_Ljava_lang_Integer_);
			return cb_adaptOutputFormat_Lorg_webrtc_VideoSource_AspectRatio_Ljava_lang_Integer_Lorg_webrtc_VideoSource_AspectRatio_Ljava_lang_Integer_Ljava_lang_Integer_;
		}

		static void n_AdaptOutputFormat_Lorg_webrtc_VideoSource_AspectRatio_Ljava_lang_Integer_Lorg_webrtc_VideoSource_AspectRatio_Ljava_lang_Integer_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_targetLandscapeAspectRatio, IntPtr native_maxLandscapePixelCount, IntPtr native_targetPortraitAspectRatio, IntPtr native_maxPortraitPixelCount, IntPtr native_maxFps)
		{
			global::Org.Webrtc.VideoSource __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.VideoSource.AspectRatio targetLandscapeAspectRatio = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoSource.AspectRatio> (native_targetLandscapeAspectRatio, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer maxLandscapePixelCount = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_maxLandscapePixelCount, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.VideoSource.AspectRatio targetPortraitAspectRatio = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoSource.AspectRatio> (native_targetPortraitAspectRatio, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer maxPortraitPixelCount = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_maxPortraitPixelCount, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer maxFps = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_maxFps, JniHandleOwnership.DoNotTransfer);
			__this.AdaptOutputFormat (targetLandscapeAspectRatio, maxLandscapePixelCount, targetPortraitAspectRatio, maxPortraitPixelCount, maxFps);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoSource']/method[@name='adaptOutputFormat' and count(parameter)=5 and parameter[1][@type='org.webrtc.VideoSource.AspectRatio'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='org.webrtc.VideoSource.AspectRatio'] and parameter[4][@type='java.lang.Integer'] and parameter[5][@type='java.lang.Integer']]"
		[Register ("adaptOutputFormat", "(Lorg/webrtc/VideoSource$AspectRatio;Ljava/lang/Integer;Lorg/webrtc/VideoSource$AspectRatio;Ljava/lang/Integer;Ljava/lang/Integer;)V", "GetAdaptOutputFormat_Lorg_webrtc_VideoSource_AspectRatio_Ljava_lang_Integer_Lorg_webrtc_VideoSource_AspectRatio_Ljava_lang_Integer_Ljava_lang_Integer_Handler")]
		public virtual unsafe void AdaptOutputFormat (global::Org.Webrtc.VideoSource.AspectRatio targetLandscapeAspectRatio, global::Java.Lang.Integer maxLandscapePixelCount, global::Org.Webrtc.VideoSource.AspectRatio targetPortraitAspectRatio, global::Java.Lang.Integer maxPortraitPixelCount, global::Java.Lang.Integer maxFps)
		{
			const string __id = "adaptOutputFormat.(Lorg/webrtc/VideoSource$AspectRatio;Ljava/lang/Integer;Lorg/webrtc/VideoSource$AspectRatio;Ljava/lang/Integer;Ljava/lang/Integer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((targetLandscapeAspectRatio == null) ? IntPtr.Zero : ((global::Java.Lang.Object) targetLandscapeAspectRatio).Handle);
				__args [1] = new JniArgumentValue ((maxLandscapePixelCount == null) ? IntPtr.Zero : ((global::Java.Lang.Object) maxLandscapePixelCount).Handle);
				__args [2] = new JniArgumentValue ((targetPortraitAspectRatio == null) ? IntPtr.Zero : ((global::Java.Lang.Object) targetPortraitAspectRatio).Handle);
				__args [3] = new JniArgumentValue ((maxPortraitPixelCount == null) ? IntPtr.Zero : ((global::Java.Lang.Object) maxPortraitPixelCount).Handle);
				__args [4] = new JniArgumentValue ((maxFps == null) ? IntPtr.Zero : ((global::Java.Lang.Object) maxFps).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setIsScreencast_Z;
#pragma warning disable 0169
		static Delegate GetSetIsScreencast_ZHandler ()
		{
			if (cb_setIsScreencast_Z == null)
				cb_setIsScreencast_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIsScreencast_Z);
			return cb_setIsScreencast_Z;
		}

		static void n_SetIsScreencast_Z (IntPtr jnienv, IntPtr native__this, bool isScreencast)
		{
			global::Org.Webrtc.VideoSource __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIsScreencast (isScreencast);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoSource']/method[@name='setIsScreencast' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIsScreencast", "(Z)V", "GetSetIsScreencast_ZHandler")]
		public virtual unsafe void SetIsScreencast (bool isScreencast)
		{
			const string __id = "setIsScreencast.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isScreencast);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setVideoProcessor_Lorg_webrtc_VideoProcessor_;
#pragma warning disable 0169
		static Delegate GetSetVideoProcessor_Lorg_webrtc_VideoProcessor_Handler ()
		{
			if (cb_setVideoProcessor_Lorg_webrtc_VideoProcessor_ == null)
				cb_setVideoProcessor_Lorg_webrtc_VideoProcessor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVideoProcessor_Lorg_webrtc_VideoProcessor_);
			return cb_setVideoProcessor_Lorg_webrtc_VideoProcessor_;
		}

		static void n_SetVideoProcessor_Lorg_webrtc_VideoProcessor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_newVideoProcessor)
		{
			global::Org.Webrtc.VideoSource __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.IVideoProcessor newVideoProcessor = (global::Org.Webrtc.IVideoProcessor)global::Java.Lang.Object.GetObject<global::Org.Webrtc.IVideoProcessor> (native_newVideoProcessor, JniHandleOwnership.DoNotTransfer);
			__this.SetVideoProcessor (newVideoProcessor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoSource']/method[@name='setVideoProcessor' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoProcessor']]"
		[Register ("setVideoProcessor", "(Lorg/webrtc/VideoProcessor;)V", "GetSetVideoProcessor_Lorg_webrtc_VideoProcessor_Handler")]
		public virtual unsafe void SetVideoProcessor (global::Org.Webrtc.IVideoProcessor newVideoProcessor)
		{
			const string __id = "setVideoProcessor.(Lorg/webrtc/VideoProcessor;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((newVideoProcessor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newVideoProcessor).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
