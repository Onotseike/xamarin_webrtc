using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='YuvHelper']"
	[global::Android.Runtime.Register ("org/webrtc/YuvHelper", DoNotGenerateAcw=true)]
	public partial class YuvHelper : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/YuvHelper", typeof (YuvHelper));
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

		protected YuvHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='YuvHelper']/constructor[@name='YuvHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe YuvHelper ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='YuvHelper']/method[@name='ABGRToI420' and count(parameter)=10 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int'] and parameter[3][@type='java.nio.ByteBuffer'] and parameter[4][@type='int'] and parameter[5][@type='java.nio.ByteBuffer'] and parameter[6][@type='int'] and parameter[7][@type='java.nio.ByteBuffer'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='int']]"
		[Register ("ABGRToI420", "(Ljava/nio/ByteBuffer;ILjava/nio/ByteBuffer;ILjava/nio/ByteBuffer;ILjava/nio/ByteBuffer;III)V", "")]
		public static unsafe void ABGRToI420 (global::Java.Nio.ByteBuffer src, int srcStride, global::Java.Nio.ByteBuffer dstY, int dstStrideY, global::Java.Nio.ByteBuffer dstU, int dstStrideU, global::Java.Nio.ByteBuffer dstV, int dstStrideV, int width, int height)
		{
			const string __id = "ABGRToI420.(Ljava/nio/ByteBuffer;ILjava/nio/ByteBuffer;ILjava/nio/ByteBuffer;ILjava/nio/ByteBuffer;III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [10];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				__args [1] = new JniArgumentValue (srcStride);
				__args [2] = new JniArgumentValue ((dstY == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dstY).Handle);
				__args [3] = new JniArgumentValue (dstStrideY);
				__args [4] = new JniArgumentValue ((dstU == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dstU).Handle);
				__args [5] = new JniArgumentValue (dstStrideU);
				__args [6] = new JniArgumentValue ((dstV == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dstV).Handle);
				__args [7] = new JniArgumentValue (dstStrideV);
				__args [8] = new JniArgumentValue (width);
				__args [9] = new JniArgumentValue (height);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='YuvHelper']/method[@name='I420Copy' and count(parameter)=9 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int'] and parameter[3][@type='java.nio.ByteBuffer'] and parameter[4][@type='int'] and parameter[5][@type='java.nio.ByteBuffer'] and parameter[6][@type='int'] and parameter[7][@type='java.nio.ByteBuffer'] and parameter[8][@type='int'] and parameter[9][@type='int']]"
		[Register ("I420Copy", "(Ljava/nio/ByteBuffer;ILjava/nio/ByteBuffer;ILjava/nio/ByteBuffer;ILjava/nio/ByteBuffer;II)V", "")]
		public static unsafe void I420Copy (global::Java.Nio.ByteBuffer srcY, int srcStrideY, global::Java.Nio.ByteBuffer srcU, int srcStrideU, global::Java.Nio.ByteBuffer srcV, int srcStrideV, global::Java.Nio.ByteBuffer dst, int width, int height)
		{
			const string __id = "I420Copy.(Ljava/nio/ByteBuffer;ILjava/nio/ByteBuffer;ILjava/nio/ByteBuffer;ILjava/nio/ByteBuffer;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue ((srcY == null) ? IntPtr.Zero : ((global::Java.Lang.Object) srcY).Handle);
				__args [1] = new JniArgumentValue (srcStrideY);
				__args [2] = new JniArgumentValue ((srcU == null) ? IntPtr.Zero : ((global::Java.Lang.Object) srcU).Handle);
				__args [3] = new JniArgumentValue (srcStrideU);
				__args [4] = new JniArgumentValue ((srcV == null) ? IntPtr.Zero : ((global::Java.Lang.Object) srcV).Handle);
				__args [5] = new JniArgumentValue (srcStrideV);
				__args [6] = new JniArgumentValue ((dst == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dst).Handle);
				__args [7] = new JniArgumentValue (width);
				__args [8] = new JniArgumentValue (height);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='YuvHelper']/method[@name='I420Copy' and count(parameter)=14 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int'] and parameter[3][@type='java.nio.ByteBuffer'] and parameter[4][@type='int'] and parameter[5][@type='java.nio.ByteBuffer'] and parameter[6][@type='int'] and parameter[7][@type='java.nio.ByteBuffer'] and parameter[8][@type='int'] and parameter[9][@type='java.nio.ByteBuffer'] and parameter[10][@type='int'] and parameter[11][@type='java.nio.ByteBuffer'] and parameter[12][@type='int'] and parameter[13][@type='int'] and parameter[14][@type='int']]"
		[Register ("I420Copy", "(Ljava/nio/ByteBuffer;ILjava/nio/ByteBuffer;ILjava/nio/ByteBuffer;ILjava/nio/ByteBuffer;ILjava/nio/ByteBuffer;ILjava/nio/ByteBuffer;III)V", "")]
		public static unsafe void I420Copy (global::Java.Nio.ByteBuffer srcY, int srcStrideY, global::Java.Nio.ByteBuffer srcU, int srcStrideU, global::Java.Nio.ByteBuffer srcV, int srcStrideV, global::Java.Nio.ByteBuffer dstY, int dstStrideY, global::Java.Nio.ByteBuffer dstU, int dstStrideU, global::Java.Nio.ByteBuffer dstV, int dstStrideV, int width, int height)
		{
			const string __id = "I420Copy.(Ljava/nio/ByteBuffer;ILjava/nio/ByteBuffer;ILjava/nio/ByteBuffer;ILjava/nio/ByteBuffer;ILjava/nio/ByteBuffer;ILjava/nio/ByteBuffer;III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [14];
				__args [0] = new JniArgumentValue ((srcY == null) ? IntPtr.Zero : ((global::Java.Lang.Object) srcY).Handle);
				__args [1] = new JniArgumentValue (srcStrideY);
				__args [2] = new JniArgumentValue ((srcU == null) ? IntPtr.Zero : ((global::Java.Lang.Object) srcU).Handle);
				__args [3] = new JniArgumentValue (srcStrideU);
				__args [4] = new JniArgumentValue ((srcV == null) ? IntPtr.Zero : ((global::Java.Lang.Object) srcV).Handle);
				__args [5] = new JniArgumentValue (srcStrideV);
				__args [6] = new JniArgumentValue ((dstY == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dstY).Handle);
				__args [7] = new JniArgumentValue (dstStrideY);
				__args [8] = new JniArgumentValue ((dstU == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dstU).Handle);
				__args [9] = new JniArgumentValue (dstStrideU);
				__args [10] = new JniArgumentValue ((dstV == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dstV).Handle);
				__args [11] = new JniArgumentValue (dstStrideV);
				__args [12] = new JniArgumentValue (width);
				__args [13] = new JniArgumentValue (height);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='YuvHelper']/method[@name='I420Rotate' and count(parameter)=10 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int'] and parameter[3][@type='java.nio.ByteBuffer'] and parameter[4][@type='int'] and parameter[5][@type='java.nio.ByteBuffer'] and parameter[6][@type='int'] and parameter[7][@type='java.nio.ByteBuffer'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='int']]"
		[Register ("I420Rotate", "(Ljava/nio/ByteBuffer;ILjava/nio/ByteBuffer;ILjava/nio/ByteBuffer;ILjava/nio/ByteBuffer;III)V", "")]
		public static unsafe void I420Rotate (global::Java.Nio.ByteBuffer srcY, int srcStrideY, global::Java.Nio.ByteBuffer srcU, int srcStrideU, global::Java.Nio.ByteBuffer srcV, int srcStrideV, global::Java.Nio.ByteBuffer dst, int srcWidth, int srcHeight, int rotationMode)
		{
			const string __id = "I420Rotate.(Ljava/nio/ByteBuffer;ILjava/nio/ByteBuffer;ILjava/nio/ByteBuffer;ILjava/nio/ByteBuffer;III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [10];
				__args [0] = new JniArgumentValue ((srcY == null) ? IntPtr.Zero : ((global::Java.Lang.Object) srcY).Handle);
				__args [1] = new JniArgumentValue (srcStrideY);
				__args [2] = new JniArgumentValue ((srcU == null) ? IntPtr.Zero : ((global::Java.Lang.Object) srcU).Handle);
				__args [3] = new JniArgumentValue (srcStrideU);
				__args [4] = new JniArgumentValue ((srcV == null) ? IntPtr.Zero : ((global::Java.Lang.Object) srcV).Handle);
				__args [5] = new JniArgumentValue (srcStrideV);
				__args [6] = new JniArgumentValue ((dst == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dst).Handle);
				__args [7] = new JniArgumentValue (srcWidth);
				__args [8] = new JniArgumentValue (srcHeight);
				__args [9] = new JniArgumentValue (rotationMode);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='YuvHelper']/method[@name='I420ToNV12' and count(parameter)=9 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int'] and parameter[3][@type='java.nio.ByteBuffer'] and parameter[4][@type='int'] and parameter[5][@type='java.nio.ByteBuffer'] and parameter[6][@type='int'] and parameter[7][@type='java.nio.ByteBuffer'] and parameter[8][@type='int'] and parameter[9][@type='int']]"
		[Register ("I420ToNV12", "(Ljava/nio/ByteBuffer;ILjava/nio/ByteBuffer;ILjava/nio/ByteBuffer;ILjava/nio/ByteBuffer;II)V", "")]
		public static unsafe void I420ToNV12 (global::Java.Nio.ByteBuffer srcY, int srcStrideY, global::Java.Nio.ByteBuffer srcU, int srcStrideU, global::Java.Nio.ByteBuffer srcV, int srcStrideV, global::Java.Nio.ByteBuffer dst, int width, int height)
		{
			const string __id = "I420ToNV12.(Ljava/nio/ByteBuffer;ILjava/nio/ByteBuffer;ILjava/nio/ByteBuffer;ILjava/nio/ByteBuffer;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue ((srcY == null) ? IntPtr.Zero : ((global::Java.Lang.Object) srcY).Handle);
				__args [1] = new JniArgumentValue (srcStrideY);
				__args [2] = new JniArgumentValue ((srcU == null) ? IntPtr.Zero : ((global::Java.Lang.Object) srcU).Handle);
				__args [3] = new JniArgumentValue (srcStrideU);
				__args [4] = new JniArgumentValue ((srcV == null) ? IntPtr.Zero : ((global::Java.Lang.Object) srcV).Handle);
				__args [5] = new JniArgumentValue (srcStrideV);
				__args [6] = new JniArgumentValue ((dst == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dst).Handle);
				__args [7] = new JniArgumentValue (width);
				__args [8] = new JniArgumentValue (height);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='YuvHelper']/method[@name='I420ToNV12' and count(parameter)=12 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int'] and parameter[3][@type='java.nio.ByteBuffer'] and parameter[4][@type='int'] and parameter[5][@type='java.nio.ByteBuffer'] and parameter[6][@type='int'] and parameter[7][@type='java.nio.ByteBuffer'] and parameter[8][@type='int'] and parameter[9][@type='java.nio.ByteBuffer'] and parameter[10][@type='int'] and parameter[11][@type='int'] and parameter[12][@type='int']]"
		[Register ("I420ToNV12", "(Ljava/nio/ByteBuffer;ILjava/nio/ByteBuffer;ILjava/nio/ByteBuffer;ILjava/nio/ByteBuffer;ILjava/nio/ByteBuffer;III)V", "")]
		public static unsafe void I420ToNV12 (global::Java.Nio.ByteBuffer srcY, int srcStrideY, global::Java.Nio.ByteBuffer srcU, int srcStrideU, global::Java.Nio.ByteBuffer srcV, int srcStrideV, global::Java.Nio.ByteBuffer dstY, int dstStrideY, global::Java.Nio.ByteBuffer dstUV, int dstStrideUV, int width, int height)
		{
			const string __id = "I420ToNV12.(Ljava/nio/ByteBuffer;ILjava/nio/ByteBuffer;ILjava/nio/ByteBuffer;ILjava/nio/ByteBuffer;ILjava/nio/ByteBuffer;III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [12];
				__args [0] = new JniArgumentValue ((srcY == null) ? IntPtr.Zero : ((global::Java.Lang.Object) srcY).Handle);
				__args [1] = new JniArgumentValue (srcStrideY);
				__args [2] = new JniArgumentValue ((srcU == null) ? IntPtr.Zero : ((global::Java.Lang.Object) srcU).Handle);
				__args [3] = new JniArgumentValue (srcStrideU);
				__args [4] = new JniArgumentValue ((srcV == null) ? IntPtr.Zero : ((global::Java.Lang.Object) srcV).Handle);
				__args [5] = new JniArgumentValue (srcStrideV);
				__args [6] = new JniArgumentValue ((dstY == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dstY).Handle);
				__args [7] = new JniArgumentValue (dstStrideY);
				__args [8] = new JniArgumentValue ((dstUV == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dstUV).Handle);
				__args [9] = new JniArgumentValue (dstStrideUV);
				__args [10] = new JniArgumentValue (width);
				__args [11] = new JniArgumentValue (height);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='YuvHelper']/method[@name='copyPlane' and count(parameter)=6 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int'] and parameter[3][@type='java.nio.ByteBuffer'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("copyPlane", "(Ljava/nio/ByteBuffer;ILjava/nio/ByteBuffer;III)V", "")]
		public static unsafe void CopyPlane (global::Java.Nio.ByteBuffer src, int srcStride, global::Java.Nio.ByteBuffer dst, int dstStride, int width, int height)
		{
			const string __id = "copyPlane.(Ljava/nio/ByteBuffer;ILjava/nio/ByteBuffer;III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				__args [1] = new JniArgumentValue (srcStride);
				__args [2] = new JniArgumentValue ((dst == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dst).Handle);
				__args [3] = new JniArgumentValue (dstStride);
				__args [4] = new JniArgumentValue (width);
				__args [5] = new JniArgumentValue (height);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
