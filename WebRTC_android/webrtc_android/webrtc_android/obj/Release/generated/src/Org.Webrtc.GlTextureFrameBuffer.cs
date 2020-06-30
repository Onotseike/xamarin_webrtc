using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='GlTextureFrameBuffer']"
	[global::Android.Runtime.Register ("org/webrtc/GlTextureFrameBuffer", DoNotGenerateAcw=true)]
	public partial class GlTextureFrameBuffer : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/webrtc/GlTextureFrameBuffer", typeof (GlTextureFrameBuffer));
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

		protected GlTextureFrameBuffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='GlTextureFrameBuffer']/constructor[@name='GlTextureFrameBuffer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe GlTextureFrameBuffer (int pixelFormat)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (pixelFormat);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getFrameBufferId;
#pragma warning disable 0169
		static Delegate GetGetFrameBufferIdHandler ()
		{
			if (cb_getFrameBufferId == null)
				cb_getFrameBufferId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFrameBufferId);
			return cb_getFrameBufferId;
		}

		static int n_GetFrameBufferId (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.GlTextureFrameBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.GlTextureFrameBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FrameBufferId;
		}
#pragma warning restore 0169

		public virtual unsafe int FrameBufferId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='GlTextureFrameBuffer']/method[@name='getFrameBufferId' and count(parameter)=0]"
			[Register ("getFrameBufferId", "()I", "GetGetFrameBufferIdHandler")]
			get {
				const string __id = "getFrameBufferId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
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
			global::Org.Webrtc.GlTextureFrameBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.GlTextureFrameBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		public virtual unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='GlTextureFrameBuffer']/method[@name='getHeight' and count(parameter)=0]"
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
			global::Org.Webrtc.GlTextureFrameBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.GlTextureFrameBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TextureId;
		}
#pragma warning restore 0169

		public virtual unsafe int TextureId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='GlTextureFrameBuffer']/method[@name='getTextureId' and count(parameter)=0]"
			[Register ("getTextureId", "()I", "GetGetTextureIdHandler")]
			get {
				const string __id = "getTextureId.()I";
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
			global::Org.Webrtc.GlTextureFrameBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.GlTextureFrameBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		public virtual unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='GlTextureFrameBuffer']/method[@name='getWidth' and count(parameter)=0]"
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
			global::Org.Webrtc.GlTextureFrameBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.GlTextureFrameBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='GlTextureFrameBuffer']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setSize_II;
#pragma warning disable 0169
		static Delegate GetSetSize_IIHandler ()
		{
			if (cb_setSize_II == null)
				cb_setSize_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetSize_II);
			return cb_setSize_II;
		}

		static void n_SetSize_II (IntPtr jnienv, IntPtr native__this, int width, int height)
		{
			global::Org.Webrtc.GlTextureFrameBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.GlTextureFrameBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSize (width, height);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='GlTextureFrameBuffer']/method[@name='setSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setSize", "(II)V", "GetSetSize_IIHandler")]
		public virtual unsafe void SetSize (int width, int height)
		{
			const string __id = "setSize.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
