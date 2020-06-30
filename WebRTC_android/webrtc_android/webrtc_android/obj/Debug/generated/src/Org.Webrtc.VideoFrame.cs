using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoFrame']"
	[global::Android.Runtime.Register ("org/webrtc/VideoFrame", DoNotGenerateAcw=true)]
	public partial class VideoFrame : global::Java.Lang.Object, global::Org.Webrtc.IRefCounted {

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoFrame.Buffer']"
		[Register ("org/webrtc/VideoFrame$Buffer", "", "Org.Webrtc.VideoFrame/IBufferInvoker")]
		public partial interface IBuffer : global::Org.Webrtc.IRefCounted {

			int Height {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoFrame.Buffer']/method[@name='getHeight' and count(parameter)=0]"
				[Register ("getHeight", "()I", "GetGetHeightHandler:Org.Webrtc.VideoFrame/IBufferInvoker, webrtc_android")] get;
			}

			int Width {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoFrame.Buffer']/method[@name='getWidth' and count(parameter)=0]"
				[Register ("getWidth", "()I", "GetGetWidthHandler:Org.Webrtc.VideoFrame/IBufferInvoker, webrtc_android")] get;
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoFrame.Buffer']/method[@name='cropAndScale' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
			[Register ("cropAndScale", "(IIIIII)Lorg/webrtc/VideoFrame$Buffer;", "GetCropAndScale_IIIIIIHandler:Org.Webrtc.VideoFrame/IBufferInvoker, webrtc_android")]
			global::Org.Webrtc.VideoFrame.IBuffer CropAndScale (int p0, int p1, int p2, int p3, int p4, int p5);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoFrame.Buffer']/method[@name='release' and count(parameter)=0]"
			[Register ("release", "()V", "GetReleaseHandler:Org.Webrtc.VideoFrame/IBufferInvoker, webrtc_android")]
			void Release ();

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoFrame.Buffer']/method[@name='retain' and count(parameter)=0]"
			[Register ("retain", "()V", "GetRetainHandler:Org.Webrtc.VideoFrame/IBufferInvoker, webrtc_android")]
			void Retain ();

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoFrame.Buffer']/method[@name='toI420' and count(parameter)=0]"
			[Register ("toI420", "()Lorg/webrtc/VideoFrame$I420Buffer;", "GetToI420Handler:Org.Webrtc.VideoFrame/IBufferInvoker, webrtc_android")]
			global::Org.Webrtc.VideoFrame.II420Buffer ToI420 ();

		}

		[global::Android.Runtime.Register ("org/webrtc/VideoFrame$Buffer", DoNotGenerateAcw=true)]
		internal partial class IBufferInvoker : global::Java.Lang.Object, IBuffer {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoFrame$Buffer", typeof (IBufferInvoker));

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

			public static IBuffer GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IBuffer> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.VideoFrame.Buffer"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IBufferInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
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
				global::Org.Webrtc.VideoFrame.IBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.IBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Height;
			}
#pragma warning restore 0169

			IntPtr id_getHeight;
			public unsafe int Height {
				get {
					if (id_getHeight == IntPtr.Zero)
						id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHeight);
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
				global::Org.Webrtc.VideoFrame.IBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.IBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Width;
			}
#pragma warning restore 0169

			IntPtr id_getWidth;
			public unsafe int Width {
				get {
					if (id_getWidth == IntPtr.Zero)
						id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWidth);
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

			static IntPtr n_CropAndScale_IIIIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, int p4, int p5)
			{
				global::Org.Webrtc.VideoFrame.IBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.IBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.CropAndScale (p0, p1, p2, p3, p4, p5));
			}
#pragma warning restore 0169

			IntPtr id_cropAndScale_IIIIII;
			public unsafe global::Org.Webrtc.VideoFrame.IBuffer CropAndScale (int p0, int p1, int p2, int p3, int p4, int p5)
			{
				if (id_cropAndScale_IIIIII == IntPtr.Zero)
					id_cropAndScale_IIIIII = JNIEnv.GetMethodID (class_ref, "cropAndScale", "(IIIIII)Lorg/webrtc/VideoFrame$Buffer;");
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.IBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cropAndScale_IIIIII, __args), JniHandleOwnership.TransferLocalRef);
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
				global::Org.Webrtc.VideoFrame.IBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.IBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Release ();
			}
#pragma warning restore 0169

			IntPtr id_release;
			public unsafe void Release ()
			{
				if (id_release == IntPtr.Zero)
					id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
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
				global::Org.Webrtc.VideoFrame.IBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.IBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Retain ();
			}
#pragma warning restore 0169

			IntPtr id_retain;
			public unsafe void Retain ()
			{
				if (id_retain == IntPtr.Zero)
					id_retain = JNIEnv.GetMethodID (class_ref, "retain", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_retain);
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
				global::Org.Webrtc.VideoFrame.IBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.IBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ToI420 ());
			}
#pragma warning restore 0169

			IntPtr id_toI420;
			public unsafe global::Org.Webrtc.VideoFrame.II420Buffer ToI420 ()
			{
				if (id_toI420 == IntPtr.Zero)
					id_toI420 = JNIEnv.GetMethodID (class_ref, "toI420", "()Lorg/webrtc/VideoFrame$I420Buffer;");
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.II420Buffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toI420), JniHandleOwnership.TransferLocalRef);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoFrame.I420Buffer']"
		[Register ("org/webrtc/VideoFrame$I420Buffer", "", "Org.Webrtc.VideoFrame/II420BufferInvoker")]
		public partial interface II420Buffer : global::Org.Webrtc.VideoFrame.IBuffer {

			global::Java.Nio.ByteBuffer DataU {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoFrame.I420Buffer']/method[@name='getDataU' and count(parameter)=0]"
				[Register ("getDataU", "()Ljava/nio/ByteBuffer;", "GetGetDataUHandler:Org.Webrtc.VideoFrame/II420BufferInvoker, webrtc_android")] get;
			}

			global::Java.Nio.ByteBuffer DataV {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoFrame.I420Buffer']/method[@name='getDataV' and count(parameter)=0]"
				[Register ("getDataV", "()Ljava/nio/ByteBuffer;", "GetGetDataVHandler:Org.Webrtc.VideoFrame/II420BufferInvoker, webrtc_android")] get;
			}

			global::Java.Nio.ByteBuffer DataY {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoFrame.I420Buffer']/method[@name='getDataY' and count(parameter)=0]"
				[Register ("getDataY", "()Ljava/nio/ByteBuffer;", "GetGetDataYHandler:Org.Webrtc.VideoFrame/II420BufferInvoker, webrtc_android")] get;
			}

			int StrideU {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoFrame.I420Buffer']/method[@name='getStrideU' and count(parameter)=0]"
				[Register ("getStrideU", "()I", "GetGetStrideUHandler:Org.Webrtc.VideoFrame/II420BufferInvoker, webrtc_android")] get;
			}

			int StrideV {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoFrame.I420Buffer']/method[@name='getStrideV' and count(parameter)=0]"
				[Register ("getStrideV", "()I", "GetGetStrideVHandler:Org.Webrtc.VideoFrame/II420BufferInvoker, webrtc_android")] get;
			}

			int StrideY {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoFrame.I420Buffer']/method[@name='getStrideY' and count(parameter)=0]"
				[Register ("getStrideY", "()I", "GetGetStrideYHandler:Org.Webrtc.VideoFrame/II420BufferInvoker, webrtc_android")] get;
			}

		}

		[global::Android.Runtime.Register ("org/webrtc/VideoFrame$I420Buffer", DoNotGenerateAcw=true)]
		internal partial class II420BufferInvoker : global::Java.Lang.Object, II420Buffer {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoFrame$I420Buffer", typeof (II420BufferInvoker));

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

			public static II420Buffer GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<II420Buffer> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.VideoFrame.I420Buffer"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public II420BufferInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_getDataU;
#pragma warning disable 0169
			static Delegate GetGetDataUHandler ()
			{
				if (cb_getDataU == null)
					cb_getDataU = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDataU);
				return cb_getDataU;
			}

			static IntPtr n_GetDataU (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.VideoFrame.II420Buffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.II420Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.DataU);
			}
#pragma warning restore 0169

			IntPtr id_getDataU;
			public unsafe global::Java.Nio.ByteBuffer DataU {
				get {
					if (id_getDataU == IntPtr.Zero)
						id_getDataU = JNIEnv.GetMethodID (class_ref, "getDataU", "()Ljava/nio/ByteBuffer;");
					return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDataU), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getDataV;
#pragma warning disable 0169
			static Delegate GetGetDataVHandler ()
			{
				if (cb_getDataV == null)
					cb_getDataV = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDataV);
				return cb_getDataV;
			}

			static IntPtr n_GetDataV (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.VideoFrame.II420Buffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.II420Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.DataV);
			}
#pragma warning restore 0169

			IntPtr id_getDataV;
			public unsafe global::Java.Nio.ByteBuffer DataV {
				get {
					if (id_getDataV == IntPtr.Zero)
						id_getDataV = JNIEnv.GetMethodID (class_ref, "getDataV", "()Ljava/nio/ByteBuffer;");
					return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDataV), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getDataY;
#pragma warning disable 0169
			static Delegate GetGetDataYHandler ()
			{
				if (cb_getDataY == null)
					cb_getDataY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDataY);
				return cb_getDataY;
			}

			static IntPtr n_GetDataY (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.VideoFrame.II420Buffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.II420Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.DataY);
			}
#pragma warning restore 0169

			IntPtr id_getDataY;
			public unsafe global::Java.Nio.ByteBuffer DataY {
				get {
					if (id_getDataY == IntPtr.Zero)
						id_getDataY = JNIEnv.GetMethodID (class_ref, "getDataY", "()Ljava/nio/ByteBuffer;");
					return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDataY), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getStrideU;
#pragma warning disable 0169
			static Delegate GetGetStrideUHandler ()
			{
				if (cb_getStrideU == null)
					cb_getStrideU = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStrideU);
				return cb_getStrideU;
			}

			static int n_GetStrideU (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.VideoFrame.II420Buffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.II420Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.StrideU;
			}
#pragma warning restore 0169

			IntPtr id_getStrideU;
			public unsafe int StrideU {
				get {
					if (id_getStrideU == IntPtr.Zero)
						id_getStrideU = JNIEnv.GetMethodID (class_ref, "getStrideU", "()I");
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getStrideU);
				}
			}

			static Delegate cb_getStrideV;
#pragma warning disable 0169
			static Delegate GetGetStrideVHandler ()
			{
				if (cb_getStrideV == null)
					cb_getStrideV = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStrideV);
				return cb_getStrideV;
			}

			static int n_GetStrideV (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.VideoFrame.II420Buffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.II420Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.StrideV;
			}
#pragma warning restore 0169

			IntPtr id_getStrideV;
			public unsafe int StrideV {
				get {
					if (id_getStrideV == IntPtr.Zero)
						id_getStrideV = JNIEnv.GetMethodID (class_ref, "getStrideV", "()I");
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getStrideV);
				}
			}

			static Delegate cb_getStrideY;
#pragma warning disable 0169
			static Delegate GetGetStrideYHandler ()
			{
				if (cb_getStrideY == null)
					cb_getStrideY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStrideY);
				return cb_getStrideY;
			}

			static int n_GetStrideY (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.VideoFrame.II420Buffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.II420Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.StrideY;
			}
#pragma warning restore 0169

			IntPtr id_getStrideY;
			public unsafe int StrideY {
				get {
					if (id_getStrideY == IntPtr.Zero)
						id_getStrideY = JNIEnv.GetMethodID (class_ref, "getStrideY", "()I");
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getStrideY);
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
				global::Org.Webrtc.VideoFrame.II420Buffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.II420Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Height;
			}
#pragma warning restore 0169

			IntPtr id_getHeight;
			public unsafe int Height {
				get {
					if (id_getHeight == IntPtr.Zero)
						id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHeight);
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
				global::Org.Webrtc.VideoFrame.II420Buffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.II420Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Width;
			}
#pragma warning restore 0169

			IntPtr id_getWidth;
			public unsafe int Width {
				get {
					if (id_getWidth == IntPtr.Zero)
						id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWidth);
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

			static IntPtr n_CropAndScale_IIIIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, int p4, int p5)
			{
				global::Org.Webrtc.VideoFrame.II420Buffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.II420Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.CropAndScale (p0, p1, p2, p3, p4, p5));
			}
#pragma warning restore 0169

			IntPtr id_cropAndScale_IIIIII;
			public unsafe global::Org.Webrtc.VideoFrame.IBuffer CropAndScale (int p0, int p1, int p2, int p3, int p4, int p5)
			{
				if (id_cropAndScale_IIIIII == IntPtr.Zero)
					id_cropAndScale_IIIIII = JNIEnv.GetMethodID (class_ref, "cropAndScale", "(IIIIII)Lorg/webrtc/VideoFrame$Buffer;");
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.IBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cropAndScale_IIIIII, __args), JniHandleOwnership.TransferLocalRef);
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
				global::Org.Webrtc.VideoFrame.II420Buffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.II420Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Release ();
			}
#pragma warning restore 0169

			IntPtr id_release;
			public unsafe void Release ()
			{
				if (id_release == IntPtr.Zero)
					id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
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
				global::Org.Webrtc.VideoFrame.II420Buffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.II420Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Retain ();
			}
#pragma warning restore 0169

			IntPtr id_retain;
			public unsafe void Retain ()
			{
				if (id_retain == IntPtr.Zero)
					id_retain = JNIEnv.GetMethodID (class_ref, "retain", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_retain);
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
				global::Org.Webrtc.VideoFrame.II420Buffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.II420Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ToI420 ());
			}
#pragma warning restore 0169

			IntPtr id_toI420;
			public unsafe global::Org.Webrtc.VideoFrame.II420Buffer ToI420 ()
			{
				if (id_toI420 == IntPtr.Zero)
					id_toI420 = JNIEnv.GetMethodID (class_ref, "toI420", "()Lorg/webrtc/VideoFrame$I420Buffer;");
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.II420Buffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toI420), JniHandleOwnership.TransferLocalRef);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoFrame.TextureBuffer.Type']"
		[global::Android.Runtime.Register ("org/webrtc/VideoFrame$TextureBuffer$Type", DoNotGenerateAcw=true)]
		public sealed partial class TextureBufferType : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoFrame.TextureBuffer.Type']/field[@name='OES']"
			[Register ("OES")]
			public static global::Org.Webrtc.VideoFrame.TextureBufferType Oes {
				get {
					const string __id = "OES.Lorg/webrtc/VideoFrame$TextureBuffer$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.TextureBufferType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoFrame.TextureBuffer.Type']/field[@name='RGB']"
			[Register ("RGB")]
			public static global::Org.Webrtc.VideoFrame.TextureBufferType Rgb {
				get {
					const string __id = "RGB.Lorg/webrtc/VideoFrame$TextureBuffer$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.TextureBufferType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoFrame$TextureBuffer$Type", typeof (TextureBufferType));
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

			internal TextureBufferType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			public unsafe int GlTarget {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoFrame.TextureBuffer.Type']/method[@name='getGlTarget' and count(parameter)=0]"
				[Register ("getGlTarget", "()I", "")]
				get {
					const string __id = "getGlTarget.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoFrame.TextureBuffer.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/VideoFrame$TextureBuffer$Type;", "")]
			public static unsafe global::Org.Webrtc.VideoFrame.TextureBufferType ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lorg/webrtc/VideoFrame$TextureBuffer$Type;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.TextureBufferType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoFrame.TextureBuffer.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/VideoFrame$TextureBuffer$Type;", "")]
			public static unsafe global::Org.Webrtc.VideoFrame.TextureBufferType[] Values ()
			{
				const string __id = "values.()[Lorg/webrtc/VideoFrame$TextureBuffer$Type;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Org.Webrtc.VideoFrame.TextureBufferType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.VideoFrame.TextureBufferType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoFrame.TextureBuffer']"
		[Register ("org/webrtc/VideoFrame$TextureBuffer", "", "Org.Webrtc.VideoFrame/ITextureBufferInvoker")]
		public partial interface ITextureBuffer : global::Org.Webrtc.VideoFrame.IBuffer {

			int TextureId {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoFrame.TextureBuffer']/method[@name='getTextureId' and count(parameter)=0]"
				[Register ("getTextureId", "()I", "GetGetTextureIdHandler:Org.Webrtc.VideoFrame/ITextureBufferInvoker, webrtc_android")] get;
			}

			global::Android.Graphics.Matrix TransformMatrix {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoFrame.TextureBuffer']/method[@name='getTransformMatrix' and count(parameter)=0]"
				[Register ("getTransformMatrix", "()Landroid/graphics/Matrix;", "GetGetTransformMatrixHandler:Org.Webrtc.VideoFrame/ITextureBufferInvoker, webrtc_android")] get;
			}

			global::Org.Webrtc.VideoFrame.TextureBufferType Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoFrame.TextureBuffer']/method[@name='getType' and count(parameter)=0]"
				[Register ("getType", "()Lorg/webrtc/VideoFrame$TextureBuffer$Type;", "GetGetTypeHandler:Org.Webrtc.VideoFrame/ITextureBufferInvoker, webrtc_android")] get;
			}

		}

		[global::Android.Runtime.Register ("org/webrtc/VideoFrame$TextureBuffer", DoNotGenerateAcw=true)]
		internal partial class ITextureBufferInvoker : global::Java.Lang.Object, ITextureBuffer {

			static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoFrame$TextureBuffer", typeof (ITextureBufferInvoker));

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

			public static ITextureBuffer GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ITextureBuffer> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.VideoFrame.TextureBuffer"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ITextureBufferInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_getTextureId;
#pragma warning disable 0169
			static Delegate GetGetTextureIdHandler ()
			{
				if (cb_getTextureId == null)
					cb_getTextureId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTextureId);
				return cb_getTextureId;
			}

			static int n_GetTextureId (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.VideoFrame.ITextureBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.ITextureBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.TextureId;
			}
#pragma warning restore 0169

			IntPtr id_getTextureId;
			public unsafe int TextureId {
				get {
					if (id_getTextureId == IntPtr.Zero)
						id_getTextureId = JNIEnv.GetMethodID (class_ref, "getTextureId", "()I");
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTextureId);
				}
			}

			static Delegate cb_getTransformMatrix;
#pragma warning disable 0169
			static Delegate GetGetTransformMatrixHandler ()
			{
				if (cb_getTransformMatrix == null)
					cb_getTransformMatrix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransformMatrix);
				return cb_getTransformMatrix;
			}

			static IntPtr n_GetTransformMatrix (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.VideoFrame.ITextureBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.ITextureBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.TransformMatrix);
			}
#pragma warning restore 0169

			IntPtr id_getTransformMatrix;
			public unsafe global::Android.Graphics.Matrix TransformMatrix {
				get {
					if (id_getTransformMatrix == IntPtr.Zero)
						id_getTransformMatrix = JNIEnv.GetMethodID (class_ref, "getTransformMatrix", "()Landroid/graphics/Matrix;");
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTransformMatrix), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getType;
#pragma warning disable 0169
			static Delegate GetGetTypeHandler ()
			{
				if (cb_getType == null)
					cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
				return cb_getType;
			}

			static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.VideoFrame.ITextureBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.ITextureBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Type);
			}
#pragma warning restore 0169

			IntPtr id_getType;
			public unsafe global::Org.Webrtc.VideoFrame.TextureBufferType Type {
				get {
					if (id_getType == IntPtr.Zero)
						id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lorg/webrtc/VideoFrame$TextureBuffer$Type;");
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.TextureBufferType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
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
				global::Org.Webrtc.VideoFrame.ITextureBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.ITextureBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Height;
			}
#pragma warning restore 0169

			IntPtr id_getHeight;
			public unsafe int Height {
				get {
					if (id_getHeight == IntPtr.Zero)
						id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHeight);
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
				global::Org.Webrtc.VideoFrame.ITextureBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.ITextureBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Width;
			}
#pragma warning restore 0169

			IntPtr id_getWidth;
			public unsafe int Width {
				get {
					if (id_getWidth == IntPtr.Zero)
						id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWidth);
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

			static IntPtr n_CropAndScale_IIIIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, int p4, int p5)
			{
				global::Org.Webrtc.VideoFrame.ITextureBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.ITextureBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.CropAndScale (p0, p1, p2, p3, p4, p5));
			}
#pragma warning restore 0169

			IntPtr id_cropAndScale_IIIIII;
			public unsafe global::Org.Webrtc.VideoFrame.IBuffer CropAndScale (int p0, int p1, int p2, int p3, int p4, int p5)
			{
				if (id_cropAndScale_IIIIII == IntPtr.Zero)
					id_cropAndScale_IIIIII = JNIEnv.GetMethodID (class_ref, "cropAndScale", "(IIIIII)Lorg/webrtc/VideoFrame$Buffer;");
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.IBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cropAndScale_IIIIII, __args), JniHandleOwnership.TransferLocalRef);
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
				global::Org.Webrtc.VideoFrame.ITextureBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.ITextureBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Release ();
			}
#pragma warning restore 0169

			IntPtr id_release;
			public unsafe void Release ()
			{
				if (id_release == IntPtr.Zero)
					id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
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
				global::Org.Webrtc.VideoFrame.ITextureBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.ITextureBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Retain ();
			}
#pragma warning restore 0169

			IntPtr id_retain;
			public unsafe void Retain ()
			{
				if (id_retain == IntPtr.Zero)
					id_retain = JNIEnv.GetMethodID (class_ref, "retain", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_retain);
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
				global::Org.Webrtc.VideoFrame.ITextureBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.ITextureBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ToI420 ());
			}
#pragma warning restore 0169

			IntPtr id_toI420;
			public unsafe global::Org.Webrtc.VideoFrame.II420Buffer ToI420 ()
			{
				if (id_toI420 == IntPtr.Zero)
					id_toI420 = JNIEnv.GetMethodID (class_ref, "toI420", "()Lorg/webrtc/VideoFrame$I420Buffer;");
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.II420Buffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toI420), JniHandleOwnership.TransferLocalRef);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/VideoFrame", typeof (VideoFrame));
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

		protected VideoFrame (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoFrame']/constructor[@name='VideoFrame' and count(parameter)=3 and parameter[1][@type='org.webrtc.VideoFrame.Buffer'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Register (".ctor", "(Lorg/webrtc/VideoFrame$Buffer;IJ)V", "")]
		public unsafe VideoFrame (global::Org.Webrtc.VideoFrame.IBuffer buffer, int rotation, long timestampNs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/webrtc/VideoFrame$Buffer;IJ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				__args [1] = new JniArgumentValue (rotation);
				__args [2] = new JniArgumentValue (timestampNs);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getBuffer;
#pragma warning disable 0169
		static Delegate GetGetBufferHandler ()
		{
			if (cb_getBuffer == null)
				cb_getBuffer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBuffer);
			return cb_getBuffer;
		}

		static IntPtr n_GetBuffer (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.VideoFrame __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Buffer);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Webrtc.VideoFrame.IBuffer Buffer {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoFrame']/method[@name='getBuffer' and count(parameter)=0]"
			[Register ("getBuffer", "()Lorg/webrtc/VideoFrame$Buffer;", "GetGetBufferHandler")]
			get {
				const string __id = "getBuffer.()Lorg/webrtc/VideoFrame$Buffer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame.IBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRotatedHeight;
#pragma warning disable 0169
		static Delegate GetGetRotatedHeightHandler ()
		{
			if (cb_getRotatedHeight == null)
				cb_getRotatedHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRotatedHeight);
			return cb_getRotatedHeight;
		}

		static int n_GetRotatedHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.VideoFrame __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RotatedHeight;
		}
#pragma warning restore 0169

		public virtual unsafe int RotatedHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoFrame']/method[@name='getRotatedHeight' and count(parameter)=0]"
			[Register ("getRotatedHeight", "()I", "GetGetRotatedHeightHandler")]
			get {
				const string __id = "getRotatedHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRotatedWidth;
#pragma warning disable 0169
		static Delegate GetGetRotatedWidthHandler ()
		{
			if (cb_getRotatedWidth == null)
				cb_getRotatedWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRotatedWidth);
			return cb_getRotatedWidth;
		}

		static int n_GetRotatedWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.VideoFrame __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RotatedWidth;
		}
#pragma warning restore 0169

		public virtual unsafe int RotatedWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoFrame']/method[@name='getRotatedWidth' and count(parameter)=0]"
			[Register ("getRotatedWidth", "()I", "GetGetRotatedWidthHandler")]
			get {
				const string __id = "getRotatedWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRotation;
#pragma warning disable 0169
		static Delegate GetGetRotationHandler ()
		{
			if (cb_getRotation == null)
				cb_getRotation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRotation);
			return cb_getRotation;
		}

		static int n_GetRotation (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.VideoFrame __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Rotation;
		}
#pragma warning restore 0169

		public virtual unsafe int Rotation {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoFrame']/method[@name='getRotation' and count(parameter)=0]"
			[Register ("getRotation", "()I", "GetGetRotationHandler")]
			get {
				const string __id = "getRotation.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTimestampNs;
#pragma warning disable 0169
		static Delegate GetGetTimestampNsHandler ()
		{
			if (cb_getTimestampNs == null)
				cb_getTimestampNs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTimestampNs);
			return cb_getTimestampNs;
		}

		static long n_GetTimestampNs (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.VideoFrame __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimestampNs;
		}
#pragma warning restore 0169

		public virtual unsafe long TimestampNs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoFrame']/method[@name='getTimestampNs' and count(parameter)=0]"
			[Register ("getTimestampNs", "()J", "GetGetTimestampNsHandler")]
			get {
				const string __id = "getTimestampNs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
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
			global::Org.Webrtc.VideoFrame __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoFrame']/method[@name='release' and count(parameter)=0]"
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
			global::Org.Webrtc.VideoFrame __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Retain ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoFrame']/method[@name='retain' and count(parameter)=0]"
		[Register ("retain", "()V", "GetRetainHandler")]
		public virtual unsafe void Retain ()
		{
			const string __id = "retain.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
