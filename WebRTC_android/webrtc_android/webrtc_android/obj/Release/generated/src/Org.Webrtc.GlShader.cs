using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='GlShader']"
	[global::Android.Runtime.Register ("org/webrtc/GlShader", DoNotGenerateAcw=true)]
	public partial class GlShader : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/GlShader", typeof (GlShader));
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

		protected GlShader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='GlShader']/constructor[@name='GlShader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe GlShader (string vertexSource, string fragmentSource)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_vertexSource = JNIEnv.NewString (vertexSource);
			IntPtr native_fragmentSource = JNIEnv.NewString (fragmentSource);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_vertexSource);
				__args [1] = new JniArgumentValue (native_fragmentSource);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_vertexSource);
				JNIEnv.DeleteLocalRef (native_fragmentSource);
			}
		}

		static Delegate cb_getAttribLocation_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAttribLocation_Ljava_lang_String_Handler ()
		{
			if (cb_getAttribLocation_Ljava_lang_String_ == null)
				cb_getAttribLocation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetAttribLocation_Ljava_lang_String_);
			return cb_getAttribLocation_Ljava_lang_String_;
		}

		static int n_GetAttribLocation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_label)
		{
			global::Org.Webrtc.GlShader __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.GlShader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string label = JNIEnv.GetString (native_label, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetAttribLocation (label);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='GlShader']/method[@name='getAttribLocation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAttribLocation", "(Ljava/lang/String;)I", "GetGetAttribLocation_Ljava_lang_String_Handler")]
		public virtual unsafe int GetAttribLocation (string label)
		{
			const string __id = "getAttribLocation.(Ljava/lang/String;)I";
			IntPtr native_label = JNIEnv.NewString (label);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_label);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_label);
			}
		}

		static Delegate cb_getUniformLocation_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetUniformLocation_Ljava_lang_String_Handler ()
		{
			if (cb_getUniformLocation_Ljava_lang_String_ == null)
				cb_getUniformLocation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetUniformLocation_Ljava_lang_String_);
			return cb_getUniformLocation_Ljava_lang_String_;
		}

		static int n_GetUniformLocation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_label)
		{
			global::Org.Webrtc.GlShader __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.GlShader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string label = JNIEnv.GetString (native_label, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetUniformLocation (label);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='GlShader']/method[@name='getUniformLocation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getUniformLocation", "(Ljava/lang/String;)I", "GetGetUniformLocation_Ljava_lang_String_Handler")]
		public virtual unsafe int GetUniformLocation (string label)
		{
			const string __id = "getUniformLocation.(Ljava/lang/String;)I";
			IntPtr native_label = JNIEnv.NewString (label);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_label);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_label);
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
			global::Org.Webrtc.GlShader __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.GlShader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='GlShader']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setVertexAttribArray_Ljava_lang_String_IILjava_nio_FloatBuffer_;
#pragma warning disable 0169
		static Delegate GetSetVertexAttribArray_Ljava_lang_String_IILjava_nio_FloatBuffer_Handler ()
		{
			if (cb_setVertexAttribArray_Ljava_lang_String_IILjava_nio_FloatBuffer_ == null)
				cb_setVertexAttribArray_Ljava_lang_String_IILjava_nio_FloatBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_SetVertexAttribArray_Ljava_lang_String_IILjava_nio_FloatBuffer_);
			return cb_setVertexAttribArray_Ljava_lang_String_IILjava_nio_FloatBuffer_;
		}

		static void n_SetVertexAttribArray_Ljava_lang_String_IILjava_nio_FloatBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_label, int dimension, int stride, IntPtr native_buffer)
		{
			global::Org.Webrtc.GlShader __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.GlShader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string label = JNIEnv.GetString (native_label, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.FloatBuffer buffer = global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			__this.SetVertexAttribArray (label, dimension, stride, buffer);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='GlShader']/method[@name='setVertexAttribArray' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.nio.FloatBuffer']]"
		[Register ("setVertexAttribArray", "(Ljava/lang/String;IILjava/nio/FloatBuffer;)V", "GetSetVertexAttribArray_Ljava_lang_String_IILjava_nio_FloatBuffer_Handler")]
		public virtual unsafe void SetVertexAttribArray (string label, int dimension, int stride, global::Java.Nio.FloatBuffer buffer)
		{
			const string __id = "setVertexAttribArray.(Ljava/lang/String;IILjava/nio/FloatBuffer;)V";
			IntPtr native_label = JNIEnv.NewString (label);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_label);
				__args [1] = new JniArgumentValue (dimension);
				__args [2] = new JniArgumentValue (stride);
				__args [3] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_label);
			}
		}

		static Delegate cb_setVertexAttribArray_Ljava_lang_String_ILjava_nio_FloatBuffer_;
#pragma warning disable 0169
		static Delegate GetSetVertexAttribArray_Ljava_lang_String_ILjava_nio_FloatBuffer_Handler ()
		{
			if (cb_setVertexAttribArray_Ljava_lang_String_ILjava_nio_FloatBuffer_ == null)
				cb_setVertexAttribArray_Ljava_lang_String_ILjava_nio_FloatBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_SetVertexAttribArray_Ljava_lang_String_ILjava_nio_FloatBuffer_);
			return cb_setVertexAttribArray_Ljava_lang_String_ILjava_nio_FloatBuffer_;
		}

		static void n_SetVertexAttribArray_Ljava_lang_String_ILjava_nio_FloatBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_label, int dimension, IntPtr native_buffer)
		{
			global::Org.Webrtc.GlShader __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.GlShader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string label = JNIEnv.GetString (native_label, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.FloatBuffer buffer = global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			__this.SetVertexAttribArray (label, dimension, buffer);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='GlShader']/method[@name='setVertexAttribArray' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.nio.FloatBuffer']]"
		[Register ("setVertexAttribArray", "(Ljava/lang/String;ILjava/nio/FloatBuffer;)V", "GetSetVertexAttribArray_Ljava_lang_String_ILjava_nio_FloatBuffer_Handler")]
		public virtual unsafe void SetVertexAttribArray (string label, int dimension, global::Java.Nio.FloatBuffer buffer)
		{
			const string __id = "setVertexAttribArray.(Ljava/lang/String;ILjava/nio/FloatBuffer;)V";
			IntPtr native_label = JNIEnv.NewString (label);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_label);
				__args [1] = new JniArgumentValue (dimension);
				__args [2] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_label);
			}
		}

		static Delegate cb_useProgram;
#pragma warning disable 0169
		static Delegate GetUseProgramHandler ()
		{
			if (cb_useProgram == null)
				cb_useProgram = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UseProgram);
			return cb_useProgram;
		}

		static void n_UseProgram (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.GlShader __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.GlShader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UseProgram ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='GlShader']/method[@name='useProgram' and count(parameter)=0]"
		[Register ("useProgram", "()V", "GetUseProgramHandler")]
		public virtual unsafe void UseProgram ()
		{
			const string __id = "useProgram.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
