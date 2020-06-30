using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='NV21Buffer']"
	[global::Android.Runtime.Register ("org/webrtc/NV21Buffer", DoNotGenerateAcw=true)]
	public partial class NV21Buffer : global::Java.Lang.Object, global::Org.Webrtc.VideoFrame.IBuffer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/NV21Buffer", typeof (NV21Buffer));
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

		protected NV21Buffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='NV21Buffer']/constructor[@name='NV21Buffer' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.Runnable']]"
		[Register (".ctor", "([BIILjava/lang/Runnable;)V", "")]
		public unsafe NV21Buffer (byte[] data, int width, int height, global::Java.Lang.IRunnable releaseCallback)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([BIILjava/lang/Runnable;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (width);
				__args [2] = new JniArgumentValue (height);
				__args [3] = new JniArgumentValue ((releaseCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) releaseCallback).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.NV21Buffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.NV21Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		public virtual unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NV21Buffer']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				const string __id = "getHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidth);
			return cb_getWidth;
		}

		static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.NV21Buffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.NV21Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		public virtual unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NV21Buffer']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler")]
			get {
				const string __id = "getWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_cropAndScale_IIIIII;
#pragma warning disable 0169
		static Delegate GetCropAndScale_IIIIIIHandler ()
		{
			if (cb_cropAndScale_IIIIII == null)
				cb_cropAndScale_IIIIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, int, int, int, IntPtr>) n_CropAndScale_IIIIII);
			return cb_cropAndScale_IIIIII;
		}

		static IntPtr n_CropAndScale_IIIIII (IntPtr jnienv, IntPtr native__this, int cropX, int cropY, int cropWidth, int cropHeight, int scaleWidth, int scaleHeight)
		{
			global::Org.Webrtc.NV21Buffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.NV21Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CropAndScale (cropX, cropY, cropWidth, cropHeight, scaleWidth, scaleHeight));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NV21Buffer']/method[@name='cropAndScale' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("cropAndScale", "(IIIIII)Lorg/webrtc/VideoFrame$Buffer;", "GetCropAndScale_IIIIIIHandler")]
		public virtual unsafe global::Org.Webrtc.VideoFrame.IBuffer CropAndScale (int cropX, int cropY, int cropWidth, int cropHeight, int scaleWidth, int scaleHeight)
		{
			const string __id = "cropAndScale.(IIIIII)Lorg/webrtc/VideoFrame$Buffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (cropX);
				__args [1] = new JniArgumentValue (cropY);
				__args [2] = new JniArgumentValue (cropWidth);
				__args [3] = new JniArgumentValue (cropHeight);
				__args [4] = new JniArgumentValue (scaleWidth);
				__args [5] = new JniArgumentValue (scaleHeight);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.IBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.NV21Buffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.NV21Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NV21Buffer']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_retain;
#pragma warning disable 0169
		static Delegate GetRetainHandler ()
		{
			if (cb_retain == null)
				cb_retain = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Retain);
			return cb_retain;
		}

		static void n_Retain (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.NV21Buffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.NV21Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Retain ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NV21Buffer']/method[@name='retain' and count(parameter)=0]"
		[Register ("retain", "()V", "GetRetainHandler")]
		public virtual unsafe void Retain ()
		{
			const string __id = "retain.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_toI420;
#pragma warning disable 0169
		static Delegate GetToI420Handler ()
		{
			if (cb_toI420 == null)
				cb_toI420 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToI420);
			return cb_toI420;
		}

		static IntPtr n_ToI420 (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.NV21Buffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.NV21Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToI420 ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='NV21Buffer']/method[@name='toI420' and count(parameter)=0]"
		[Register ("toI420", "()Lorg/webrtc/VideoFrame$I420Buffer;", "GetToI420Handler")]
		public virtual unsafe global::Org.Webrtc.VideoFrame.II420Buffer ToI420 ()
		{
			const string __id = "toI420.()Lorg/webrtc/VideoFrame$I420Buffer;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.II420Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
